
    partial class CurrentPositionControl
{
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

    #region Code généré par le Concepteur de composants

    /// <summary> 
    /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
    /// le contenu de cette méthode avec l'éditeur de code.
    /// </summary>
    private void InitializeComponent()
    {
        btnGetJointPosition = new Button();
        gridJointPosition = new PropertyGrid();
        udRobot = new NumericUpDown();
        label1 = new Label();
        btnGetCartesianPosition = new Button();
        gridTool = new PropertyGrid();
        gridFrame = new PropertyGrid();
        label2 = new Label();
        label3 = new Label();
        gridCartesianJointsPosition = new PropertyGrid();
        ((System.ComponentModel.ISupportInitialize)udRobot).BeginInit();
        SuspendLayout();
        // 
        // btnGetJointPosition
        // 
        btnGetJointPosition.Anchor = AnchorStyles.Top;
        btnGetJointPosition.Location = new Point(203, 58);
        btnGetJointPosition.Name = "btnGetJointPosition";
        btnGetJointPosition.Size = new Size(165, 39);
        btnGetJointPosition.TabIndex = 0;
        btnGetJointPosition.Text = "Get Joint position";
        btnGetJointPosition.UseVisualStyleBackColor = true;
        btnGetJointPosition.Click += btnGetJointPosition_Click;
        // 
        // gridJointPosition
        // 
        gridJointPosition.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
        gridJointPosition.HelpVisible = false;
        gridJointPosition.Location = new Point(171, 103);
        gridJointPosition.Name = "gridJointPosition";
        gridJointPosition.PropertySort = PropertySort.NoSort;
        gridJointPosition.Size = new Size(272, 458);
        gridJointPosition.TabIndex = 2;
        gridJointPosition.ToolbarVisible = false;
        // 
        // udRobot
        // 
        udRobot.Location = new Point(54, 3);
        udRobot.Name = "udRobot";
        udRobot.Size = new Size(120, 23);
        udRobot.TabIndex = 3;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(3, 5);
        label1.Name = "label1";
        label1.Size = new Size(45, 15);
        label1.TabIndex = 4;
        label1.Text = "Robot :";
        // 
        // btnGetCartesianPosition
        // 
        btnGetCartesianPosition.Anchor = AnchorStyles.Top;
        btnGetCartesianPosition.Location = new Point(524, 266);
        btnGetCartesianPosition.Name = "btnGetCartesianPosition";
        btnGetCartesianPosition.Size = new Size(165, 39);
        btnGetCartesianPosition.TabIndex = 0;
        btnGetCartesianPosition.Text = "Get cartesian position ";
        btnGetCartesianPosition.UseVisualStyleBackColor = true;
        btnGetCartesianPosition.Click += btnGetCartesianPosition_Click;
        // 
        // gridTool
        // 
        gridTool.Anchor = AnchorStyles.Top;
        gridTool.HelpVisible = false;
        gridTool.Location = new Point(475, 58);
        gridTool.Name = "gridTool";
        gridTool.PropertySort = PropertySort.NoSort;
        gridTool.Size = new Size(130, 202);
        gridTool.TabIndex = 2;
        gridTool.ToolbarVisible = false;
        // 
        // gridFrame
        // 
        gridFrame.Anchor = AnchorStyles.Top;
        gridFrame.HelpVisible = false;
        gridFrame.Location = new Point(619, 58);
        gridFrame.Name = "gridFrame";
        gridFrame.PropertySort = PropertySort.NoSort;
        gridFrame.Size = new Size(126, 202);
        gridFrame.TabIndex = 2;
        gridFrame.ToolbarVisible = false;
        // 
        // label2
        // 
        label2.Anchor = AnchorStyles.Top;
        label2.AutoSize = true;
        label2.Location = new Point(475, 40);
        label2.Name = "label2";
        label2.Size = new Size(36, 15);
        label2.TabIndex = 4;
        label2.Text = "Tool :";
        // 
        // label3
        // 
        label3.Anchor = AnchorStyles.Top;
        label3.AutoSize = true;
        label3.Location = new Point(619, 40);
        label3.Name = "label3";
        label3.Size = new Size(46, 15);
        label3.TabIndex = 4;
        label3.Text = "Frame :";
        // 
        // gridCartesianJointsPosition
        // 
        gridCartesianJointsPosition.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
        gridCartesianJointsPosition.HelpVisible = false;
        gridCartesianJointsPosition.Location = new Point(475, 311);
        gridCartesianJointsPosition.Name = "gridCartesianJointsPosition";
        gridCartesianJointsPosition.PropertySort = PropertySort.NoSort;
        gridCartesianJointsPosition.Size = new Size(270, 250);
        gridCartesianJointsPosition.TabIndex = 2;
        gridCartesianJointsPosition.ToolbarVisible = false;
        // 
        // CurrentPositionControl
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(udRobot);
        Controls.Add(gridFrame);
        Controls.Add(gridTool);
        Controls.Add(gridCartesianJointsPosition);
        Controls.Add(gridJointPosition);
        Controls.Add(btnGetCartesianPosition);
        Controls.Add(btnGetJointPosition);
        Margin = new Padding(4, 3, 4, 3);
        Name = "CurrentPositionControl";
        Size = new Size(915, 563);
        ((System.ComponentModel.ISupportInitialize)udRobot).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btnGetJointPosition;
    private PropertyGrid gridJointPosition;
    private NumericUpDown udRobot;
    private Label label1;
    private Button btnGetCartesianPosition;
    private PropertyGrid gridTool;
    private PropertyGrid gridFrame;
    private Label label2;
    private Label label3;
    private PropertyGrid gridCartesianJointsPosition;
}
