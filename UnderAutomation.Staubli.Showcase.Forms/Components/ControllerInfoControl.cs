using System.ComponentModel;
using UnderAutomation.Staubli;
using UnderAutomation.Staubli.Soap.Data;

public partial class ControllerInfoControl : UserControl, IUserControl
{
    private readonly StaubliController _controller;

    public ControllerInfoControl(StaubliController robot)
    {
        _controller = robot;
        InitializeComponent();

        // make grid readonly
        TypeDescriptor.AddAttributes(typeof(Parameter), new ReadOnlyAttribute(true));
        // make grid expandable
        TypeDescriptor.AddAttributes(typeof(Parameter), new TypeConverterAttribute(typeof(ObjectConverter)));
    }

    #region IUserControl
    public string Title => "Controller parameters";

    public bool FeatureEnabled => _controller.Soap.Enabled;

    public void PeriodicUpdate() { }

    public void OnClose() { }

    public void OnOpen() { }
    #endregion

    private void btnGetControllerParameters_Click(object sender, EventArgs e)
    {
        Parameter[] parameters = _controller.Soap.GetControllerParameters();

        gridControllerParameters.SelectedObject = parameters;
        gridControllerParameters.ExpandAllGridItems();
    }
}
