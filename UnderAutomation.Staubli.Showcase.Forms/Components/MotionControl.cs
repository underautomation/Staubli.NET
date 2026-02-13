using UnderAutomation.Staubli;
using UnderAutomation.Staubli.Soap.Data;

public partial class MotionControl : UserControl, IUserControl
{
    private readonly StaubliController _controller;

    public MotionControl(StaubliController robot)
    {
        _controller = robot;
        InitializeComponent();

        gridMDesc.SelectedObject = new MotionDesc()
        {
            Tool = new Frame(),
            Frame = new Frame(),
            Config = new UnderAutomation.Staubli.Soap.Data.Config() { AnthroConfig = new AnthroConfig() },
            Velocity = 10,
            Acceleration = 100,
            Deceleration = 100,
            TranslationVelocity = 99999,
            RotationVelocity = 99999,
            Frequency = 100
        };

        gridMDesc.ExpandAllGridItems();

        gridJoint.SelectedObject = new double[6];
        gridFrame.SelectedObject = new Frame();
    }

    #region IUserControl
    public string Title => "Move the robot";

    public bool FeatureEnabled => _controller.Soap.Enabled;

    public void PeriodicUpdate() { }

    public void OnClose() { }

    public void OnOpen() { }
    #endregion


    private void btnPowerOn_Click(object sender, EventArgs e)
    {
        var result = _controller.Soap.SetPower(true);
        SetLblPowerResult(result);
    }

    private void btnPowerOff_Click(object sender, EventArgs e)
    {
        var result = _controller.Soap.SetPower(false);
        SetLblPowerResult(result);
    }


    private void SetLblMoveResult(IMoveResult result)
    {
        lblMoveResult.Text = $"{result.Id} : {result.ReturnCode.ToString()}";
        lblMoveResult.ForeColor = result.ReturnCode == MotionReturnCode.Success ? Color.Green : Color.Red;
    }

    private void SetLblPowerResult(PowerReturnCode code)
    {
        lblPowerResult.Text = code.ToString();
        lblPowerResult.ForeColor = code == PowerReturnCode.Success ? Color.Green : Color.Red;
    }
    private void btnMoveJC_Click(object sender, EventArgs e)
    {
        var result = _controller.Soap.MoveJC((int)udRobot.Value, gridFrame.SelectedObject as Frame, gridMDesc.SelectedObject as MotionDesc);
        SetLblMoveResult(result);
    }

    private void btnMoveL_Click(object sender, EventArgs e)
    {
        var result = _controller.Soap.MoveL((int)udRobot.Value, gridFrame.SelectedObject as Frame, gridMDesc.SelectedObject as MotionDesc);
        SetLblMoveResult(result);
    }

    private void btnMoveJJ_Click(object sender, EventArgs e)
    {
        var result = _controller.Soap.MoveJJ((int)udRobot.Value, gridJoint.SelectedObject as double[], gridMDesc.SelectedObject as MotionDesc);
        SetLblMoveResult(result);
    }

    private void btnStopMotion_Click(object sender, EventArgs e)
    {
        var result = _controller.Soap.StopMotion();
    }

    private void btnResetMotion_Click(object sender, EventArgs e)
    {
        var result = _controller.Soap.ResetMotion();
    }

    private void btnRestartMotion_Click(object sender, EventArgs e)
    {
        var result = _controller.Soap.RestartMotion();
    }
}
