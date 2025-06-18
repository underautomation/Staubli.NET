using System.ComponentModel;
using UnderAutomation.Staubli;
using UnderAutomation.Staubli.Soap.Data;

public partial class RobotsControl : UserControl, IUserControl
{
    private readonly StaubliController _controller;

    public RobotsControl(StaubliController robot)
    {
        _controller = robot;
        InitializeComponent();

        // make grid readonly
        TypeDescriptor.AddAttributes(typeof(Robot), new ReadOnlyAttribute(true));
        // make grid expandable
        TypeDescriptor.AddAttributes(typeof(Robot), new TypeConverterAttribute(typeof(ObjectConverter)));
    }

    #region IUserControl
    public string Title => "Get Robots";

    public bool FeatureEnabled => _controller.Soap.Enabled;

    public void PeriodicUpdate() { }

    public void OnClose() { }

    public void OnOpen() { }
    #endregion


    private void btnGetRobots_Click(object sender, EventArgs e)
    {
        Robot[] robots = _controller.Soap.GetRobots();

        gridRobots.SelectedObject = robots;
        gridRobots.ExpandAllGridItems();
    }
}
