using System.ComponentModel;
using UnderAutomation.Staubli;
using UnderAutomation.Staubli.Soap.Data;

public partial class RobotInfoControl : UserControl, IUserControl
{
    private readonly StaubliController _controller;

    public RobotInfoControl(StaubliController robot)
    {
        _controller = robot;
        InitializeComponent();

        // make grid readonly
        TypeDescriptor.AddAttributes(typeof(DhParameters), new ReadOnlyAttribute(true));
        // make grid expandable
        TypeDescriptor.AddAttributes(typeof(DhParameters), new TypeConverterAttribute(typeof(ObjectConverter)));

    }

    #region IUserControl
    public string Title => "Robot information";

    public bool FeatureEnabled => _controller.Soap.Enabled;

    public void PeriodicUpdate() { }

    public void OnClose() { }

    public void OnOpen() { }

    #endregion

    private void btnGetJointsRange_Click(object sender, EventArgs e)
    {
        JointRange range = _controller.Soap.GetJointRange((int)udRobot.Value);
        gridJointsRange.SelectedObject = range;
        gridJointsRange.ExpandAllGridItems();
    }

    private void btnDhParameters_Click(object sender, EventArgs e)
    {
        DhParameters[] parameters = _controller.Soap.GetDhParameters((int)udRobot.Value);
        gridDhParameters.SelectedObject = parameters;
        gridDhParameters.ExpandAllGridItems();
    }
}
