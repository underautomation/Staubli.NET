partial class FilesControl
{
    /// <summary>
    /// Variable nécessaire au concepteur.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Nettoyage des ressources utilisées.
    /// </summary>
    /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Code généré par le Concepteur de composants

    /// <summary>
    /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
    /// le contenu de cette méthode avec l'éditeur de code.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilesControl));
        SplitContainer2 = new SplitContainer();
        lstFolder = new ListView();
        lstFolderImageList = new ImageList(components);
        ToolStrip1 = new ToolStrip();
        btnPrevious = new ToolStripButton();
        btnUserApps = new ToolStripButton();
        txtPath = new ToolStripTextBox();
        btnOpenPath = new ToolStripButton();
        tsFolder = new ToolStrip();
        btnRefresh = new ToolStripButton();
        btnDownload = new ToolStripButton();
        btnUpload = new ToolStripButton();
        btnNewFolder = new ToolStripButton();
        btnRename = new ToolStripButton();
        btnDelete = new ToolStripButton();
        toolStripSeparator1 = new ToolStripSeparator();
        btnUploadApp = new ToolStripButton();
        statusStrip = new StatusStrip();
        lblMode = new ToolStripStatusLabel();
        gridFile = new PropertyGrid();
        dlgOpen = new OpenFileDialog();
        dlgSave = new SaveFileDialog();
        dlgFolder = new FolderBrowserDialog();
        dlgAppFolder = new FolderBrowserDialog();
        ((System.ComponentModel.ISupportInitialize)SplitContainer2).BeginInit();
        SplitContainer2.Panel1.SuspendLayout();
        SplitContainer2.Panel2.SuspendLayout();
        SplitContainer2.SuspendLayout();
        ToolStrip1.SuspendLayout();
        tsFolder.SuspendLayout();
        statusStrip.SuspendLayout();
        SuspendLayout();
        //
        // SplitContainer2
        //
        SplitContainer2.BorderStyle = BorderStyle.Fixed3D;
        SplitContainer2.Dock = DockStyle.Fill;
        SplitContainer2.Location = new Point(0, 0);
        SplitContainer2.Margin = new Padding(4, 3, 4, 3);
        SplitContainer2.Name = "SplitContainer2";
        //
        // SplitContainer2.Panel1
        //
        SplitContainer2.Panel1.Controls.Add(lstFolder);
        SplitContainer2.Panel1.Controls.Add(statusStrip);
        SplitContainer2.Panel1.Controls.Add(ToolStrip1);
        SplitContainer2.Panel1.Controls.Add(tsFolder);
        //
        // SplitContainer2.Panel2
        //
        SplitContainer2.Panel2.Controls.Add(gridFile);
        SplitContainer2.Size = new Size(818, 764);
        SplitContainer2.SplitterDistance = 560;
        SplitContainer2.SplitterWidth = 5;
        SplitContainer2.TabIndex = 2;
        //
        // lstFolder
        //
        lstFolder.Activation = ItemActivation.TwoClick;
        lstFolder.Dock = DockStyle.Fill;
        lstFolder.LabelEdit = true;
        lstFolder.LargeImageList = lstFolderImageList;
        lstFolder.Location = new Point(0, 50);
        lstFolder.Margin = new Padding(4, 3, 4, 3);
        lstFolder.Name = "lstFolder";
        lstFolder.Size = new Size(556, 688);
        lstFolder.TabIndex = 1;
        lstFolder.UseCompatibleStateImageBehavior = false;
        lstFolder.AfterLabelEdit += lstFolder_AfterLabelEdit;
        lstFolder.ItemActivate += lstFolder_ItemActivate;
        lstFolder.ItemSelectionChanged += lstFolder_ItemSelectionChanged;
        lstFolder.SelectedIndexChanged += lstFolder_SelectedIndexChanged;
        //
        // lstFolderImageList
        //
        lstFolderImageList.ColorDepth = ColorDepth.Depth8Bit;
        lstFolderImageList.ImageStream = (ImageListStreamer)resources.GetObject("lstFolderImageList.ImageStream");
        lstFolderImageList.TransparentColor = Color.Transparent;
        lstFolderImageList.Images.SetKeyName(0, "folder");
        lstFolderImageList.Images.SetKeyName(1, "file");
        lstFolderImageList.Images.SetKeyName(2, "symbolicLink");
        //
        // ToolStrip1
        //
        ToolStrip1.Items.AddRange(new ToolStripItem[] { btnPrevious, btnUserApps, txtPath, btnOpenPath });
        ToolStrip1.Location = new Point(0, 25);
        ToolStrip1.Name = "ToolStrip1";
        ToolStrip1.Size = new Size(556, 25);
        ToolStrip1.TabIndex = 2;
        ToolStrip1.Text = "ToolStrip1";
        //
        // btnPrevious
        //
        btnPrevious.DisplayStyle = ToolStripItemDisplayStyle.Image;
        btnPrevious.Image = UnderAutomation.Staubli.Showcase.Forms.Properties.Resources.arrow_up_line;
        btnPrevious.ImageTransparentColor = Color.Magenta;
        btnPrevious.Name = "btnPrevious";
        btnPrevious.Size = new Size(23, 22);
        btnPrevious.Text = "Parent folder";
        btnPrevious.Click += btnPrevious_Click;
        //
        // btnUserApps
        //
        btnUserApps.DisplayStyle = ToolStripItemDisplayStyle.Image;
        btnUserApps.Image = UnderAutomation.Staubli.Showcase.Forms.Properties.Resources.folder_shared_line;
        btnUserApps.ImageTransparentColor = Color.Magenta;
        btnUserApps.Name = "btnUserApps";
        btnUserApps.Size = new Size(23, 22);
        btnUserApps.Text = "VAL 3 applications (/usr/usrapp)";
        btnUserApps.Click += btnUserApps_Click;
        //
        // txtPath
        //
        txtPath.Name = "txtPath";
        txtPath.Size = new Size(400, 25);
        txtPath.KeyDown += btnOpenPath_Click;
        //
        // btnOpenPath
        //
        btnOpenPath.DisplayStyle = ToolStripItemDisplayStyle.Image;
        btnOpenPath.Image = UnderAutomation.Staubli.Showcase.Forms.Properties.Resources.arrow_right_line;
        btnOpenPath.ImageTransparentColor = Color.Magenta;
        btnOpenPath.Name = "btnOpenPath";
        btnOpenPath.Size = new Size(23, 22);
        btnOpenPath.Text = "Open";
        btnOpenPath.Click += btnOpenPath_Click;
        //
        // tsFolder
        //
        tsFolder.Items.AddRange(new ToolStripItem[] { btnRefresh, btnDownload, btnUpload, btnNewFolder, btnRename, btnDelete, toolStripSeparator1, btnUploadApp });
        tsFolder.Location = new Point(0, 0);
        tsFolder.Name = "tsFolder";
        tsFolder.Size = new Size(556, 25);
        tsFolder.TabIndex = 0;
        tsFolder.Text = "ToolStrip1";
        //
        // btnRefresh
        //
        btnRefresh.Image = UnderAutomation.Staubli.Showcase.Forms.Properties.Resources.refresh_line;
        btnRefresh.ImageTransparentColor = Color.Magenta;
        btnRefresh.Name = "btnRefresh";
        btnRefresh.Size = new Size(66, 22);
        btnRefresh.Text = "Refresh";
        btnRefresh.Click += btnOpenPath_Click;
        //
        // btnDownload
        //
        btnDownload.Enabled = false;
        btnDownload.Image = UnderAutomation.Staubli.Showcase.Forms.Properties.Resources.save_3_fill;
        btnDownload.ImageTransparentColor = Color.Magenta;
        btnDownload.Name = "btnDownload";
        btnDownload.Size = new Size(81, 22);
        btnDownload.Text = "Download";
        btnDownload.Click += btnDownload_Click;
        //
        // btnUpload
        //
        btnUpload.Image = UnderAutomation.Staubli.Showcase.Forms.Properties.Resources.upload_2_line;
        btnUpload.ImageTransparentColor = Color.Magenta;
        btnUpload.Name = "btnUpload";
        btnUpload.Size = new Size(65, 22);
        btnUpload.Text = "Upload";
        btnUpload.Click += btnUpload_Click;
        //
        // btnNewFolder
        //
        btnNewFolder.Image = UnderAutomation.Staubli.Showcase.Forms.Properties.Resources.folder_add_line;
        btnNewFolder.ImageTransparentColor = Color.Magenta;
        btnNewFolder.Name = "btnNewFolder";
        btnNewFolder.Size = new Size(85, 22);
        btnNewFolder.Text = "New folder";
        btnNewFolder.Click += btnNewFolder_Click;
        //
        // btnRename
        //
        btnRename.Enabled = false;
        btnRename.Image = UnderAutomation.Staubli.Showcase.Forms.Properties.Resources.file_edit_line;
        btnRename.ImageTransparentColor = Color.Magenta;
        btnRename.Name = "btnRename";
        btnRename.Size = new Size(70, 22);
        btnRename.Text = "Rename";
        btnRename.Click += btnRename_Click;
        //
        // btnDelete
        //
        btnDelete.Enabled = false;
        btnDelete.Image = UnderAutomation.Staubli.Showcase.Forms.Properties.Resources.delete_bin_5_line;
        btnDelete.ImageTransparentColor = Color.Magenta;
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(60, 22);
        btnDelete.Text = "Delete";
        btnDelete.Click += btnDelete_Click;
        //
        // toolStripSeparator1
        //
        toolStripSeparator1.Name = "toolStripSeparator1";
        toolStripSeparator1.Size = new Size(6, 25);
        //
        // btnUploadApp
        //
        btnUploadApp.Image = UnderAutomation.Staubli.Showcase.Forms.Properties.Resources.download_2_line;
        btnUploadApp.ImageTransparentColor = Color.Magenta;
        btnUploadApp.Name = "btnUploadApp";
        btnUploadApp.Size = new Size(125, 22);
        btnUploadApp.Text = "Upload application";
        btnUploadApp.ToolTipText = "Send the folder of a VAL 3 application to /usr/usrapp";
        btnUploadApp.Click += btnUploadApp_Click;
        //
        // statusStrip
        //
        statusStrip.Items.AddRange(new ToolStripItem[] { lblMode });
        statusStrip.Location = new Point(0, 738);
        statusStrip.Name = "statusStrip";
        statusStrip.Size = new Size(556, 22);
        statusStrip.SizingGrip = false;
        statusStrip.TabIndex = 3;
        //
        // lblMode
        //
        lblMode.Name = "lblMode";
        lblMode.Size = new Size(0, 17);
        //
        // gridFile
        //
        gridFile.Dock = DockStyle.Fill;
        gridFile.HelpVisible = false;
        gridFile.Location = new Point(0, 0);
        gridFile.Margin = new Padding(4, 3, 4, 3);
        gridFile.Name = "gridFile";
        gridFile.Size = new Size(249, 760);
        gridFile.TabIndex = 0;
        gridFile.ToolbarVisible = false;
        //
        // dlgOpen
        //
        dlgOpen.Filter = "All files|*.*";
        dlgOpen.Multiselect = true;
        dlgOpen.ShowHiddenFiles = true;
        dlgOpen.Title = "Select files to upload";
        //
        // dlgSave
        //
        dlgSave.Filter = "All files|*.*";
        dlgSave.RestoreDirectory = true;
        dlgSave.Title = "Download file";
        //
        // dlgFolder
        //
        dlgFolder.Description = "Download the selected files in this folder";
        dlgFolder.UseDescriptionForTitle = true;
        //
        // dlgAppFolder
        //
        dlgAppFolder.Description = "Folder of the VAL 3 application to send (named as the application, with its .pjx file)";
        dlgAppFolder.UseDescriptionForTitle = true;
        //
        // FilesControl
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(SplitContainer2);
        Margin = new Padding(4, 3, 4, 3);
        Name = "FilesControl";
        Size = new Size(818, 764);
        SplitContainer2.Panel1.ResumeLayout(false);
        SplitContainer2.Panel1.PerformLayout();
        SplitContainer2.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)SplitContainer2).EndInit();
        SplitContainer2.ResumeLayout(false);
        ToolStrip1.ResumeLayout(false);
        ToolStrip1.PerformLayout();
        tsFolder.ResumeLayout(false);
        tsFolder.PerformLayout();
        statusStrip.ResumeLayout(false);
        statusStrip.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    internal System.Windows.Forms.SplitContainer SplitContainer2;
    internal System.Windows.Forms.ListView lstFolder;
    internal System.Windows.Forms.ToolStrip ToolStrip1;
    internal System.Windows.Forms.ToolStripButton btnPrevious;
    internal System.Windows.Forms.ToolStripButton btnUserApps;
    internal System.Windows.Forms.ToolStripTextBox txtPath;
    internal System.Windows.Forms.ToolStripButton btnOpenPath;
    internal System.Windows.Forms.ToolStrip tsFolder;
    internal System.Windows.Forms.ToolStripButton btnRefresh;
    internal System.Windows.Forms.ToolStripButton btnDownload;
    internal System.Windows.Forms.ToolStripButton btnUpload;
    internal System.Windows.Forms.ToolStripButton btnNewFolder;
    internal System.Windows.Forms.ToolStripButton btnRename;
    internal System.Windows.Forms.ToolStripButton btnDelete;
    internal System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    internal System.Windows.Forms.ToolStripButton btnUploadApp;
    internal System.Windows.Forms.StatusStrip statusStrip;
    internal System.Windows.Forms.ToolStripStatusLabel lblMode;
    internal System.Windows.Forms.PropertyGrid gridFile;
    internal System.Windows.Forms.OpenFileDialog dlgOpen;
    internal System.Windows.Forms.SaveFileDialog dlgSave;
    internal System.Windows.Forms.ImageList lstFolderImageList;
    private FolderBrowserDialog dlgFolder;
    private FolderBrowserDialog dlgAppFolder;
}
