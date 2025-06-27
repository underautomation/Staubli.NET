using UnderAutomation.Staubli;
using UnderAutomation.Staubli.Common;

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
        if (0 == (Config.Current.ConnectParameters?.Soap?.Port).GetValueOrDefault())
            udSoapPort.Value = SoapConnectParameters.DEFAULT_PORT;
        else
            udSoapPort.Value = Config.Current.ConnectParameters.Soap.Port;
    }

    #region IUserControl
    public bool FeatureEnabled => _controller.Soap.Enabled;

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

        // Connect to the robot
        _controller.Connect(parameters);

        // Store information
        Config.Current.ConnectParameters = parameters;
        Config.Save();
    }

    private void btnDisconnect_Click(object sender, EventArgs e)
    {
        // Disconnect all services
        _controller.Disconnect();
    }
}
