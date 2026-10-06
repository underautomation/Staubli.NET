using UnderAutomation.Staubli;
using UnderAutomation.Staubli.Common;
using UnderAutomation.Staubli.License;

public partial class ConnectControl : UserControl, IUserControl
{
    StaubliController _controller;

    public ConnectControl(StaubliController Staubli)
    {
        _controller = Staubli;
        InitializeComponent();

        // Use stored information or set to default
        txtIP.Text = Config.Current.ConnectParameters?.Address ?? "192.168.0.1";
        txtUser.Text = Config.Current.ConnectParameters?.Soap?.User;
        txtPassword.Text = Config.Current.ConnectParameters?.Soap?.Password;
        // 0: automatic, 851 on a real controller, port of the configuration of an emulated controller
        udSoapPort.Value = (Config.Current.ConnectParameters?.Soap?.Port).GetValueOrDefault();

        // File client: FTP server of a real controller, or folder of the .controller file of an emulated controller
        var file = Config.Current.ConnectParameters?.File ?? new FileConnectParameters();
        chkFile.Checked = file.Enable;
        txtFileUser.Text = file.User;
        txtFilePassword.Text = file.Password;
        udFilePort.Value = file.Port > 0 ? file.Port : FileConnectParameters.DEFAULT_PORT;
    }

    #region IUserControl
    public bool FeatureEnabled => _controller.Enabled;

    public string Title => "Connection";

    public void OnClose() { }

    public void OnOpen() { }

    public void PeriodicUpdate()
    {
        var connected = FeatureEnabled;
        btnDisconnect.Enabled = connected;
        btnConnect.Text = connected ? "Reconnect" : "Connect";
        lblConnected.Text = connected ? "Connected" : "Disconnected";
        lblConnected.ForeColor = connected ? Color.Green : Color.Red;

        if (!_controller.File.Enabled) lblFiles.Text = "";
        else if (_controller.File.IsSimulated) lblFiles.Text = $"Files: folder of {_controller.File.ControllerFile}";
        else lblFiles.Text = $"Files: FTP server {_controller.File.Ip}:{_controller.File.Port}";
    }
    #endregion

    private void btnConnect_Click(object sender, EventArgs e)
    {
        if (e is KeyEventArgs && ((KeyEventArgs)e).KeyCode != Keys.Enter) return;

        var parameters = new ConnectionParameters();
        parameters.Address = txtIP.Text;
        parameters.Soap.User = txtUser.Text;
        parameters.Soap.Password = txtPassword.Text;
        parameters.Soap.Port = (int)udSoapPort.Value;

        // With a .controller file as address, the user, the password and the port of the FTP server are not used
        parameters.File.Enable = chkFile.Checked;
        parameters.File.User = txtFileUser.Text;
        parameters.File.Password = txtFilePassword.Text;
        parameters.File.Port = (int)udFilePort.Value;

        // Store information
        Config.Current.ConnectParameters = parameters;
        Config.Save();

        try
        {
            // Connect to the robot
            _controller.Connect(parameters);
        }
        catch (InvalidLicenseException)
        {
            MessageBox.Show("Your licence is invalid. Please obtain a Trial Licence or enter the licence key you receive after purchasing the SDK", "License error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            MainForm.Instance.SelectNode<LicenseControl>();
        }
    }

    // Emulated controller: the address is the .controller file of the controller of the Staubli Robotics Suite cell
    private void btnBrowse_Click(object sender, EventArgs e)
    {
        if (File.Exists(txtIP.Text)) dlgControllerFile.FileName = txtIP.Text;
        if (dlgControllerFile.ShowDialog() != DialogResult.OK) return;

        txtIP.Text = dlgControllerFile.FileName;
        chkFile.Checked = true;
    }

    private void btnDisconnect_Click(object sender, EventArgs e)
    {
        // Disconnect all services
        _controller.Disconnect();
    }
}
