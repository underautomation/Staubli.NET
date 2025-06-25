using System.ComponentModel;
using UnderAutomation.Staubli;
using UnderAutomation.Staubli.Soap.Data;

public partial class KinematicsControl : UserControl, IUserControl
{
    private readonly StaubliController _controller;

    public KinematicsControl(StaubliController robot)
    {
        _controller = robot;
        InitializeComponent();

        gridJointFK.SelectedObject = new double[6];

        gridJointIK.SelectedObject = new double[6];
        gridFrame.SelectedObject = new Frame();
        gridConfig.SelectedObject = new UnderAutomation.Staubli.Soap.Data.Config() { AnthroConfig = new AnthroConfig(), ScaraConfig = new ScaraConfig(), VrbxConfig = new VrbxConfig() };
        gridRange.SelectedObject = new JointRange() { Max = new double[6], Min = new double[6] };

        // make grid readonly
        TypeDescriptor.AddAttributes(typeof(IForwardKinematics), new ReadOnlyAttribute(true));
        // make grid expandable
        TypeDescriptor.AddAttributes(typeof(IForwardKinematics), new TypeConverterAttribute(typeof(ObjectConverter)));
        TypeDescriptor.AddAttributes(typeof(UnderAutomation.Staubli.Soap.Data.Config), new TypeConverterAttribute(typeof(ObjectConverter)));
        TypeDescriptor.AddAttributes(typeof(Frame), new TypeConverterAttribute(typeof(ObjectConverter)));
        TypeDescriptor.AddAttributes(typeof(AnthroConfig), new TypeConverterAttribute(typeof(ObjectConverter)));
        TypeDescriptor.AddAttributes(typeof(ScaraConfig), new TypeConverterAttribute(typeof(ObjectConverter)));
        TypeDescriptor.AddAttributes(typeof(VrbxConfig), new TypeConverterAttribute(typeof(ObjectConverter)));

    }

    #region IUserControl
    public string Title => "Forward / Reverse Kinematics";

    public bool FeatureEnabled => _controller.Soap.Enabled;

    public void PeriodicUpdate() { }

    public void OnClose() { }

    public void OnOpen() { }
    #endregion


    private void btnForwardKinematics_Click(object sender, EventArgs e)
    {
        IForwardKinematics fk = _controller.Soap.ForwardKinematics((int)udRobot.Value, gridJointFK.SelectedObject as double[]);

        gridForwardKinematics.SelectedObject = fk;
        gridForwardKinematics.ExpandAllGridItems();
    }

    private void btnReverseKinematics_Click(object sender, EventArgs e)
    {
        IReverseKinematics ik = _controller.Soap.ReverseKinematics((int)udRobot.Value,
            gridJointIK.SelectedObject as double[],
            gridFrame.SelectedObject as Frame,
            gridConfig.SelectedObject as UnderAutomation.Staubli.Soap.Data.Config,
            gridRange.SelectedObject as JointRange);

        gridReverseKinematics.SelectedObject = ik;
        gridReverseKinematics.ExpandAllGridItems();

    }
}
