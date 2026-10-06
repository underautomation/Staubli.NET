using System.ComponentModel;
using UnderAutomation.Staubli;
using UnderAutomation.Staubli.Files;
using UnderAutomation.Staubli.Files.Internal;

// Explorer of the files of the controller: FTP server of a real controller, or folder of the .controller file of an emulated controller
public partial class FilesControl : UserControl, IUserControl
{
    private readonly StaubliController _controller;

    public FilesControl(StaubliController controller)
    {
        TypeDescriptor.AddAttributes(typeof(FileItem), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
        TypeDescriptor.AddAttributes(typeof(FileItem), new ReadOnlyAttribute(true));

        _controller = controller;
        InitializeComponent();
    }

    #region IUserControl
    public string Title => "Files";

    public bool FeatureEnabled => _controller.File.Enabled;

    public void PeriodicUpdate()
    {
        Enabled = FeatureEnabled;

        if (!FeatureEnabled) lblMode.Text = "Enable the file client in the connection parameters";
        else if (_controller.File.IsSimulated) lblMode.Text = $"Emulated controller: {_controller.File.ControllerFile}";
        else lblMode.Text = $"FTP: {_controller.File.Ip}:{_controller.File.Port}";
    }

    public void OnClose()
    {
        Config.Current.FilesPath = txtPath.Text;
        Config.Save();

        lstFolder.Items.Clear();
        gridFile.SelectedObject = null;
    }

    public void OnOpen()
    {
        if (!_controller.File.Enabled) return;

        try
        {
            FillList(Config.Current.FilesPath ?? FileClientBase.USER_APP_FOLDER);
        }
        catch
        {
            // The folder of the last session does not exist on this controller
            FillList(FileClientBase.USER_APP_FOLDER);
        }
    }
    #endregion

    // Display the content of a folder of the controller, folders first
    private void FillList(string path)
    {
        gridFile.SelectedObject = null;
        lstFolder.Items.Clear();

        if (!_controller.File.Enabled) return;

        path = path.Replace(@"\", "/");
        if (!path.EndsWith("/")) path += "/";

        var items = _controller.File.GetListing(path)
            .OrderBy(item => item.Type == FileItemType.Directory ? 0 : 1)
            .ThenBy(item => item.Name, StringComparer.OrdinalIgnoreCase);

        txtPath.Text = path;

        foreach (var item in items)
        {
            var listItem = lstFolder.Items.Add(item.Name);
            listItem.Tag = item;
            listItem.ImageKey = item.Type == FileItemType.Directory ? "folder" : "file";
        }
    }

    private void ReloadList()
    {
        FillList(GetPath());
    }

    // Current folder, with a final "/"
    private string GetPath()
    {
        var path = txtPath.Text.Replace(@"\", "/");
        return path.EndsWith("/") ? path : path + "/";
    }

    private FileItem[] SelectedItems => lstFolder.SelectedItems.OfType<ListViewItem>().Select(x => x.Tag).OfType<FileItem>().ToArray();

    // Select an item of the list by its name
    private void SelectItem(string? name)
    {
        var listItem = lstFolder.Items.OfType<ListViewItem>().FirstOrDefault(x => string.Equals(x.Text, name, StringComparison.OrdinalIgnoreCase));
        if (listItem != null)
        {
            listItem.Selected = true;
            listItem.EnsureVisible();
        }
    }

    #region Navigation
    // Open a folder after a double click
    private void lstFolder_ItemActivate(object sender, EventArgs e)
    {
        var item = SelectedItems.FirstOrDefault();
        if (item != null && item.Type == FileItemType.Directory) FillList(item.FullName);
    }

    // Parent folder
    private void btnPrevious_Click(object sender, EventArgs e)
    {
        var path = GetPath().TrimEnd('/');
        if (path == "") return;
        var index = path.LastIndexOf('/');
        FillList(index <= 0 ? "/" : path.Substring(0, index));
    }

    // Open the typed folder, or refresh the current one
    private void btnOpenPath_Click(object sender, EventArgs e)
    {
        if (e is KeyEventArgs key && key.KeyCode != Keys.Enter) return;
        ReloadList();
    }

    // Folder of the VAL 3 applications
    private void btnUserApps_Click(object sender, EventArgs e)
    {
        FillList(FileClientBase.USER_APP_FOLDER);
    }
    #endregion

    #region Selection
    private void lstFolder_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
    {
        gridFile.SelectedObject = e.IsSelected ? e.Item?.Tag : SelectedItems.FirstOrDefault();
        UpdateButtons();
    }

    private void lstFolder_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lstFolder.SelectedItems.Count == 0) gridFile.SelectedObject = null;
        UpdateButtons();
    }

    private void UpdateButtons()
    {
        var items = SelectedItems;
        btnDownload.Enabled = items.Length > 0 && items.All(x => x.Type == FileItemType.File);
        btnDelete.Enabled = items.Length > 0;
        btnRename.Enabled = items.Length == 1;
    }
    #endregion

    #region File operations
    // Upload local files to the current folder
    private async void btnUpload_Click(object sender, EventArgs e)
    {
        if (dlgOpen.ShowDialog() != DialogResult.OK) return;

        var folder = GetPath();
        var files = dlgOpen.FileNames;

        await RunTransfer(btnUpload, async progress =>
        {
            for (int i = 0; i < files.Length; i++)
            {
                var index = i;
                await _controller.File.UploadFileToControllerAsync(files[i], folder + Path.GetFileName(files[i]),
                    progress: p => progress((index * 100 + p) / files.Length));
            }
        });

        ReloadList();
        SelectItem(Path.GetFileName(files.Last()));
    }

    // Download the selected files: one file to a chosen file, several files to a chosen folder
    private async void btnDownload_Click(object sender, EventArgs e)
    {
        var files = SelectedItems.Where(x => x.Type == FileItemType.File).ToArray();
        if (files.Length == 0) return;

        if (files.Length == 1)
        {
            dlgSave.FileName = files[0].Name;
            if (dlgSave.ShowDialog() != DialogResult.OK) return;

            var localPath = dlgSave.FileName;
            await RunTransfer(btnDownload, progress =>
                _controller.File.DownloadFileFromControllerAsync(localPath, files[0].FullName, progress));

            Explorer.RevealFile(localPath);
        }
        else
        {
            if (dlgFolder.ShowDialog() != DialogResult.OK) return;

            var localFolder = dlgFolder.SelectedPath;
            await RunTransfer(btnDownload, async progress =>
            {
                for (int i = 0; i < files.Length; i++)
                {
                    var index = i;
                    await _controller.File.DownloadFileFromControllerAsync(Path.Combine(localFolder, files[i].Name), files[i].FullName,
                        p => progress((index * 100 + p) / files.Length));
                }
            });

            Explorer.OpenDirectory(localFolder);
        }
    }

    // Send a complete VAL 3 application to /usr/usrapp/<application>
    private async void btnUploadApp_Click(object sender, EventArgs e)
    {
        if (dlgAppFolder.ShowDialog() != DialogResult.OK) return;

        var localFolder = dlgAppFolder.SelectedPath;
        var name = Path.GetFileName(localFolder.TrimEnd(Path.DirectorySeparatorChar));

        if (!File.Exists(Path.Combine(localFolder, name + ".pjx")) &&
            MessageBox.Show($"{name}.pjx is not in the folder. The project of a VAL 3 application has the name of its folder.\r\n\r\nSend the folder anyway?",
                "Send a VAL 3 application", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;

        if (_controller.File.DirectoryExists(FileClientBase.USER_APP_FOLDER + "/" + name) &&
            MessageBox.Show($"{FileClientBase.USER_APP_FOLDER}/{name} exists on the controller. It will be replaced, and the files that are not in the local folder will be deleted.\r\n\r\nUnload the application first (VAL 3 applications page, or robot.Soap.StopAndUnloadAll()).\r\n\r\nContinue?",
                "Send a VAL 3 application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

        string remoteFolder = "";
        await RunTransfer(btnUploadApp, async progress =>
            remoteFolder = await _controller.File.UploadApplicationToControllerAsync(localFolder, progress));

        FillList(FileClientBase.USER_APP_FOLDER);
        SelectItem(name);

        MessageBox.Show($"The application is in {remoteFolder}.\r\n\r\nLoad it with robot.Soap.LoadProject(\"Disk://{name}/{name}.pjx\").",
            "Send a VAL 3 application", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    // Delete the selected files and folders
    private async void btnDelete_Click(object sender, EventArgs e)
    {
        var items = SelectedItems;
        if (items.Length == 0) return;

        var question = items.Length == 1 ? $"Delete {items[0].FullName}?" : $"Delete the {items.Length} selected items?";
        if (items.Any(x => x.Type == FileItemType.Directory)) question += "\r\n\r\nA folder is deleted with all its content.";
        if (MessageBox.Show(question, "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

        await RunTransfer(btnDelete, async progress =>
        {
            foreach (var item in items)
            {
                if (item.Type == FileItemType.Directory) await _controller.File.DeleteDirectoryAsync(item.FullName);
                else await _controller.File.DeleteFileAsync(item.FullName);
            }
        });

        ReloadList();
    }

    // Edit the name of the selected item, renamed in lstFolder_AfterLabelEdit
    private void btnRename_Click(object sender, EventArgs e)
    {
        lstFolder.SelectedItems.OfType<ListViewItem>().FirstOrDefault()?.BeginEdit();
    }

    // New item in edition, created in lstFolder_AfterLabelEdit
    private void btnNewFolder_Click(object sender, EventArgs e)
    {
        lstFolder.Items.Add("New folder", "folder").BeginEdit();
    }

    // Create the new folder, or rename the edited item
    private void lstFolder_AfterLabelEdit(object sender, LabelEditEventArgs e)
    {
        var listItem = lstFolder.Items[e.Item];
        var item = listItem.Tag as FileItem;

        // The edition is cancelled, or the name is the same
        if (string.IsNullOrWhiteSpace(e.Label) || (item != null && e.Label == item.Name))
        {
            e.CancelEdit = true;
            if (item is null) lstFolder.Items.Remove(listItem);
            return;
        }

        try
        {
            if (item is null) _controller.File.CreateDirectory(GetPath() + e.Label);
            else _controller.File.Rename(item.FullName, GetPath() + e.Label);
        }
        finally
        {
            e.CancelEdit = true;
            BeginInvoke(new Action(() =>
            {
                ReloadList();
                SelectItem(e.Label);
            }));
        }
    }
    #endregion

    // Runs a transfer: the buttons are disabled and the text of the button shows the progress
    private async Task RunTransfer(ToolStripButton button, Func<OnProgressDelegate, Task> transfer)
    {
        var text = button.Text;

        // Called on the thread of the transfer
        OnProgressDelegate progress = p =>
        {
            if (p < 0 || IsDisposed) return;
            BeginInvoke(new Action(() => button.Text = $"{text} ({(int)p}%)"));
        };

        try
        {
            tsFolder.Enabled = false;
            Cursor = Cursors.WaitCursor;
            await transfer(progress);
        }
        finally
        {
            tsFolder.Enabled = true;
            Cursor = Cursors.Default;
            BeginInvoke(new Action(() => button.Text = text));
        }
    }
}
