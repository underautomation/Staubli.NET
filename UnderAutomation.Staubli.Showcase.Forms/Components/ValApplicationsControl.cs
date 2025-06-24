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

        // make grid readonly
        TypeDescriptor.AddAttributes(typeof(ControllerTask), new ReadOnlyAttribute(true));
        // make grid expandable
        TypeDescriptor.AddAttributes(typeof(ControllerTask), new TypeConverterAttribute(typeof(ObjectConverter)));
        TypeDescriptor.AddAttributes(typeof(ProgramLine), new TypeConverterAttribute(typeof(ObjectConverter)));

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

    private void btnStartApplication_Click(object sender, EventArgs e)
    {
        _controller.Soap.StartApplication(txtApplication.Text);
    }

    private void btnStopApplication_Click(object sender, EventArgs e)
    {
        _controller.Soap.StopApplication();
    }

    private void btnStopAndUnloadApplication_Click(object sender, EventArgs e)
    {
        _controller.Soap.StopAndUnloadAll();
    }

    private void btnLoadProject_Click(object sender, EventArgs e)
    {
        _controller.Soap.LoadProject(txtApplication.Text);
    }

    private void btnGetTasks_Click(object sender, EventArgs e)
    {
        ControllerTask[] tasks = _controller.Soap.GetTasks();
        gridTasks.SelectedObject = tasks;
        gridTasks.ExpandAllGridItems();

    }

    private void btnSuspend_Click(object sender, EventArgs e)
    {
        _controller.Soap.TaskSuspend(txtTask.Text, txtCreatedBy.Text);
    }

    private void btnKill_Click(object sender, EventArgs e)
    {
        _controller.Soap.TaskKill(txtTask.Text, txtCreatedBy.Text);
    }

    private void btnResumeTask_Click(object sender, EventArgs e)
    {
        _controller.Soap.TaskResume(txtTask.Text, txtCreatedBy.Text);
    }
}
