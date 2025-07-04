﻿using System.ComponentModel;
using UnderAutomation.Staubli;
using UnderAutomation.Staubli.Soap.Data;

public partial class CurrentPositionControl : UserControl, IUserControl
{
    private readonly StaubliController _controller;

    public CurrentPositionControl(StaubliController robot)
    {
        _controller = robot;
        InitializeComponent();

        // make grid readonly
        TypeDescriptor.AddAttributes(typeof(CartesianJointPosition), new ReadOnlyAttribute(true));
        // make grid expandable
        TypeDescriptor.AddAttributes(typeof(CartesianJointPosition), new TypeConverterAttribute(typeof(ObjectConverter)));
        TypeDescriptor.AddAttributes(typeof(CartesianPosition), new TypeConverterAttribute(typeof(ObjectConverter)));

        gridFrame.SelectedObject = new CartesianPosition();
        gridTool.SelectedObject = new CartesianPosition();
    }

    #region IUserControl
    public string Title => "Get current position";

    public bool FeatureEnabled => _controller.Soap.Enabled;

    public void PeriodicUpdate() { }

    public void OnClose() { }

    public void OnOpen() { }

    #endregion

    private void btnGetCartesianPosition_Click(object sender, EventArgs e)
    {
        CartesianJointPosition position = _controller.Soap.GetCurrentCartesianJointPosition(
            (int)udRobot.Value,
            (CartesianPosition)gridTool.SelectedObject,
            (CartesianPosition)gridFrame.SelectedObject);

        gridCartesianJointsPosition.SelectedObject = position;
        gridCartesianJointsPosition.ExpandAllGridItems();
    }

    private void btnGetJointPosition_Click(object sender, EventArgs e)
    {
        double[] position = _controller.Soap.GetCurrentJointPosition((int)udRobot.Value);
        gridJointPosition.SelectedObject = position;
        gridJointPosition.ExpandAllGridItems();
    }
}
