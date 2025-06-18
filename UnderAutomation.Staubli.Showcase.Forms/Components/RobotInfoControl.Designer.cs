
    partial class RobotInfoControl
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
        btnDhParameters = new Button();
        gridDhParameters = new PropertyGrid();
        udRobot = new NumericUpDown();
        label1 = new Label();
        btnGetJointsRange = new Button();
        gridJointsRange = new PropertyGrid();
        ((System.ComponentModel.ISupportInitialize)udRobot).BeginInit();
        SuspendLayout();
        // 
        // btnDhParameters
        // 
        btnDhParameters.Anchor = AnchorStyles.Top;
        btnDhParameters.Location = new Point(255, 57);
        btnDhParameters.Name = "btnDhParameters";
        btnDhParameters.Size = new Size(165, 39);
        btnDhParameters.TabIndex = 0;
        btnDhParameters.Text = "Get DH parameters";
        btnDhParameters.UseVisualStyleBackColor = true;
        btnDhParameters.Click += btnDhParameters_Click;
        // 
        // gridDhParameters
        // 
        gridDhParameters.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
        gridDhParameters.HelpVisible = false;
        gridDhParameters.Location = new Point(202, 102);
        gridDhParameters.Name = "gridDhParameters";
        gridDhParameters.PropertySort = PropertySort.NoSort;
        gridDhParameters.Size = new Size(272, 458);
        gridDhParameters.TabIndex = 2;
        gridDhParameters.ToolbarVisible = false;
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
        // btnGetJointsRange
        // 
        btnGetJointsRange.Anchor = AnchorStyles.Top;
        btnGetJointsRange.Location = new Point(543, 57);
        btnGetJointsRange.Name = "btnGetJointsRange";
        btnGetJointsRange.Size = new Size(165, 39);
        btnGetJointsRange.TabIndex = 0;
        btnGetJointsRange.Text = "Get Joints range";
        btnGetJointsRange.UseVisualStyleBackColor = true;
        btnGetJointsRange.Click += btnGetJointsRange_Click;
        // 
        // gridJointsRange
        // 
        gridJointsRange.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
        gridJointsRange.HelpVisible = false;
        gridJointsRange.Location = new Point(491, 102);
        gridJointsRange.Name = "gridJointsRange";
        gridJointsRange.PropertySort = PropertySort.NoSort;
        gridJointsRange.Size = new Size(268, 458);
        gridJointsRange.TabIndex = 2;
        gridJointsRange.ToolbarVisible = false;
        // 
        // RobotInfoControl
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(label1);
        Controls.Add(udRobot);
        Controls.Add(gridJointsRange);
        Controls.Add(gridDhParameters);
        Controls.Add(btnGetJointsRange);
        Controls.Add(btnDhParameters);
        Margin = new Padding(4, 3, 4, 3);
        Name = "RobotInfoControl";
        Size = new Size(922, 563);
        ((System.ComponentModel.ISupportInitialize)udRobot).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btnDhParameters;
    private PropertyGrid gridDhParameters;
    private NumericUpDown udRobot;
    private Label label1;
    private Button btnGetJointsRange;
    private PropertyGrid gridJointsRange;
}
