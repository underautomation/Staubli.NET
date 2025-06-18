using System.ComponentModel;
using UnderAutomation.Staubli;
using UnderAutomation.Staubli.Soap.Data;

public partial class ValApplicationsControl : UserControl, IUserControl
{
    private readonly StaubliController _controller;

    public ValApplicationsControl(StaubliController robot)
    {
        _controller = robot;
        InitializeComponent();

        // make grid readonly
        TypeDescriptor.AddAttributes(typeof(ValApplication), new ReadOnlyAttribute(true));
        // make grid expandable
        TypeDescriptor.AddAttributes(typeof(ValApplication), new TypeConverterAttribute(typeof(ObjectConverter)));
    }

    #region IUserControl
    public string Title => "VAL Applications";

    public bool FeatureEnabled => _controller.Soap.Enabled;

    public void PeriodicUpdate() { }

    public void OnClose() { }

    public void OnOpen() { }
    #endregion

    private void btnGetValApplications_Click(object sender, EventArgs e)
    {
        ValApplication[] applications = _controller.Soap.GetValApplications();

        gridValApplications.SelectedObject = applications;
        gridValApplications.ExpandAllGridItems();
    }
}
