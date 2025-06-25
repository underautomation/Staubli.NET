
    partial class KinematicsControl
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
        btnForwardKinematics = new Button();
        btnReverseKinematics = new Button();
        label1 = new Label();
        udRobot = new NumericUpDown();
        gridJointFK = new PropertyGrid();
        gridForwardKinematics = new PropertyGrid();
        gridJointIK = new PropertyGrid();
        gridFrame = new PropertyGrid();
        gridConfig = new PropertyGrid();
        gridRange = new PropertyGrid();
        gridReverseKinematics = new PropertyGrid();
        ((System.ComponentModel.ISupportInitialize)udRobot).BeginInit();
        SuspendLayout();
        // 
        // btnForwardKinematics
        // 
        btnForwardKinematics.Location = new Point(59, 241);
        btnForwardKinematics.Name = "btnForwardKinematics";
        btnForwardKinematics.Size = new Size(174, 23);
        btnForwardKinematics.TabIndex = 0;
        btnForwardKinematics.Text = "Get forward kinematics";
        btnForwardKinematics.UseVisualStyleBackColor = true;
        btnForwardKinematics.Click += btnForwardKinematics_Click;
        // 
        // btnReverseKinematics
        // 
        btnReverseKinematics.Location = new Point(497, 301);
        btnReverseKinematics.Name = "btnReverseKinematics";
        btnReverseKinematics.Size = new Size(174, 23);
        btnReverseKinematics.TabIndex = 0;
        btnReverseKinematics.Text = "Get reverse kinematics";
        btnReverseKinematics.UseVisualStyleBackColor = true;
        btnReverseKinematics.Click += btnReverseKinematics_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(12, 5);
        label1.Name = "label1";
        label1.Size = new Size(45, 15);
        label1.TabIndex = 6;
        label1.Text = "Robot :";
        // 
        // udRobot
        // 
        udRobot.Location = new Point(63, 3);
        udRobot.Name = "udRobot";
        udRobot.Size = new Size(120, 23);
        udRobot.TabIndex = 5;
        // 
        // gridJointFK
        // 
        gridJointFK.HelpVisible = false;
        gridJointFK.Location = new Point(59, 58);
        gridJointFK.Name = "gridJointFK";
        gridJointFK.PropertySort = PropertySort.NoSort;
        gridJointFK.Size = new Size(174, 167);
        gridJointFK.TabIndex = 7;
        gridJointFK.ToolbarVisible = false;
        // 
        // gridForwardKinematics
        // 
        gridForwardKinematics.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        gridForwardKinematics.HelpVisible = false;
        gridForwardKinematics.Location = new Point(59, 283);
        gridForwardKinematics.Name = "gridForwardKinematics";
        gridForwardKinematics.PropertySort = PropertySort.NoSort;
        gridForwardKinematics.Size = new Size(174, 394);
        gridForwardKinematics.TabIndex = 7;
        gridForwardKinematics.ToolbarVisible = false;
        // 
        // gridJointIK
        // 
        gridJointIK.HelpVisible = false;
        gridJointIK.Location = new Point(317, 58);
        gridJointIK.Name = "gridJointIK";
        gridJointIK.PropertySort = PropertySort.NoSort;
        gridJointIK.Size = new Size(126, 224);
        gridJointIK.TabIndex = 7;
        gridJointIK.ToolbarVisible = false;
        // 
        // gridFrame
        // 
        gridFrame.HelpVisible = false;
        gridFrame.Location = new Point(449, 58);
        gridFrame.Name = "gridFrame";
        gridFrame.PropertySort = PropertySort.NoSort;
        gridFrame.Size = new Size(126, 224);
        gridFrame.TabIndex = 7;
        gridFrame.ToolbarVisible = false;
        // 
        // gridConfig
        // 
        gridConfig.HelpVisible = false;
        gridConfig.Location = new Point(581, 58);
        gridConfig.Name = "gridConfig";
        gridConfig.PropertySort = PropertySort.NoSort;
        gridConfig.Size = new Size(201, 224);
        gridConfig.TabIndex = 7;
        gridConfig.ToolbarVisible = false;
        // 
        // gridRange
        // 
        gridRange.HelpVisible = false;
        gridRange.Location = new Point(788, 58);
        gridRange.Name = "gridRange";
        gridRange.PropertySort = PropertySort.NoSort;
        gridRange.Size = new Size(126, 224);
        gridRange.TabIndex = 7;
        gridRange.ToolbarVisible = false;
        // 
        // gridReverseKinematics
        // 
        gridReverseKinematics.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        gridReverseKinematics.HelpVisible = false;
        gridReverseKinematics.Location = new Point(497, 349);
        gridReverseKinematics.Name = "gridReverseKinematics";
        gridReverseKinematics.PropertySort = PropertySort.NoSort;
        gridReverseKinematics.Size = new Size(174, 328);
        gridReverseKinematics.TabIndex = 7;
        gridReverseKinematics.ToolbarVisible = false;
        // 
        // KinematicsControl
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(gridReverseKinematics);
        Controls.Add(gridForwardKinematics);
        Controls.Add(gridRange);
        Controls.Add(gridConfig);
        Controls.Add(gridFrame);
        Controls.Add(gridJointIK);
        Controls.Add(gridJointFK);
        Controls.Add(label1);
        Controls.Add(udRobot);
        Controls.Add(btnReverseKinematics);
        Controls.Add(btnForwardKinematics);
        Margin = new Padding(4, 3, 4, 3);
        Name = "KinematicsControl";
        Size = new Size(957, 680);
        ((System.ComponentModel.ISupportInitialize)udRobot).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btnForwardKinematics;
    private Button btnReverseKinematics;
    private Label label1;
    private NumericUpDown udRobot;
    private PropertyGrid gridJointFK;
    private PropertyGrid gridForwardKinematics;
    private PropertyGrid gridJointIK;
    private PropertyGrid gridFrame;
    private PropertyGrid gridConfig;
    private PropertyGrid gridRange;
    private PropertyGrid gridReverseKinematics;
}
