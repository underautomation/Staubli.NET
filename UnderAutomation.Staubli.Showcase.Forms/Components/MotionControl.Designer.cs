
    partial class MotionControl
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
        btnPowerOn = new Button();
        btnPowerOff = new Button();
        label1 = new Label();
        btnMoveJC = new Button();
        gridMDesc = new PropertyGrid();
        label2 = new Label();
        gridFrame = new PropertyGrid();
        label3 = new Label();
        label4 = new Label();
        gridJoint = new PropertyGrid();
        btnMoveL = new Button();
        btnMoveJJ = new Button();
        label5 = new Label();
        udRobot = new NumericUpDown();
        lblPowerResult = new Label();
        lblMoveResult = new Label();
        ((System.ComponentModel.ISupportInitialize)udRobot).BeginInit();
        SuspendLayout();
        // 
        // btnPowerOn
        // 
        btnPowerOn.Location = new Point(40, 39);
        btnPowerOn.Name = "btnPowerOn";
        btnPowerOn.Size = new Size(75, 23);
        btnPowerOn.TabIndex = 0;
        btnPowerOn.Text = "Power On";
        btnPowerOn.UseVisualStyleBackColor = true;
        btnPowerOn.Click += btnPowerOn_Click;
        // 
        // btnPowerOff
        // 
        btnPowerOff.Location = new Point(121, 39);
        btnPowerOff.Name = "btnPowerOff";
        btnPowerOff.Size = new Size(75, 23);
        btnPowerOff.TabIndex = 0;
        btnPowerOff.Text = "Power Off";
        btnPowerOff.UseVisualStyleBackColor = true;
        btnPowerOff.Click += btnPowerOff_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(40, 21);
        label1.Name = "label1";
        label1.Size = new Size(141, 15);
        label1.TabIndex = 1;
        label1.Text = "Remote mode is needed :";
        // 
        // btnMoveJC
        // 
        btnMoveJC.Location = new Point(245, 422);
        btnMoveJC.Name = "btnMoveJC";
        btnMoveJC.Size = new Size(75, 23);
        btnMoveJC.TabIndex = 2;
        btnMoveJC.Text = "MoveJ";
        btnMoveJC.UseVisualStyleBackColor = true;
        btnMoveJC.Click += btnMoveJC_Click;
        // 
        // gridMDesc
        // 
        gridMDesc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        gridMDesc.HelpVisible = false;
        gridMDesc.Location = new Point(40, 200);
        gridMDesc.Name = "gridMDesc";
        gridMDesc.PropertySort = PropertySort.NoSort;
        gridMDesc.Size = new Size(156, 340);
        gridMDesc.TabIndex = 8;
        gridMDesc.ToolbarVisible = false;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(40, 182);
        label2.Name = "label2";
        label2.Size = new Size(114, 15);
        label2.TabIndex = 1;
        label2.Text = "Motion description :";
        // 
        // gridFrame
        // 
        gridFrame.HelpVisible = false;
        gridFrame.Location = new Point(245, 134);
        gridFrame.Name = "gridFrame";
        gridFrame.PropertySort = PropertySort.NoSort;
        gridFrame.Size = new Size(156, 282);
        gridFrame.TabIndex = 8;
        gridFrame.ToolbarVisible = false;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(245, 116);
        label3.Name = "label3";
        label3.Size = new Size(142, 15);
        label3.TabIndex = 1;
        label3.Text = "Target cartesian position :";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(450, 116);
        label4.Name = "label4";
        label4.Size = new Size(119, 15);
        label4.TabIndex = 1;
        label4.Text = "Target joint position :";
        // 
        // gridJoint
        // 
        gridJoint.HelpVisible = false;
        gridJoint.Location = new Point(450, 134);
        gridJoint.Name = "gridJoint";
        gridJoint.PropertySort = PropertySort.NoSort;
        gridJoint.Size = new Size(156, 282);
        gridJoint.TabIndex = 8;
        gridJoint.ToolbarVisible = false;
        // 
        // btnMoveL
        // 
        btnMoveL.Location = new Point(326, 422);
        btnMoveL.Name = "btnMoveL";
        btnMoveL.Size = new Size(75, 23);
        btnMoveL.TabIndex = 2;
        btnMoveL.Text = "MoveL";
        btnMoveL.UseVisualStyleBackColor = true;
        btnMoveL.Click += btnMoveL_Click;
        // 
        // btnMoveJJ
        // 
        btnMoveJJ.Location = new Point(485, 422);
        btnMoveJJ.Name = "btnMoveJJ";
        btnMoveJJ.Size = new Size(75, 23);
        btnMoveJJ.TabIndex = 2;
        btnMoveJJ.Text = "MoveJ";
        btnMoveJJ.UseVisualStyleBackColor = true;
        btnMoveJJ.Click += btnMoveJJ_Click;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(40, 116);
        label5.Name = "label5";
        label5.Size = new Size(45, 15);
        label5.TabIndex = 10;
        label5.Text = "Robot :";
        // 
        // udRobot
        // 
        udRobot.Location = new Point(40, 134);
        udRobot.Name = "udRobot";
        udRobot.Size = new Size(156, 23);
        udRobot.TabIndex = 9;
        // 
        // lblPowerResult
        // 
        lblPowerResult.AutoSize = true;
        lblPowerResult.Location = new Point(40, 65);
        lblPowerResult.Name = "lblPowerResult";
        lblPowerResult.Size = new Size(16, 15);
        lblPowerResult.TabIndex = 1;
        lblPowerResult.Text = "...";
        // 
        // lblMoveResult
        // 
        lblMoveResult.AutoSize = true;
        lblMoveResult.Location = new Point(245, 461);
        lblMoveResult.Name = "lblMoveResult";
        lblMoveResult.Size = new Size(16, 15);
        lblMoveResult.TabIndex = 1;
        lblMoveResult.Text = "...";
        // 
        // MotionControl
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(label5);
        Controls.Add(udRobot);
        Controls.Add(gridJoint);
        Controls.Add(gridFrame);
        Controls.Add(gridMDesc);
        Controls.Add(label4);
        Controls.Add(btnMoveL);
        Controls.Add(btnMoveJJ);
        Controls.Add(btnMoveJC);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(lblMoveResult);
        Controls.Add(lblPowerResult);
        Controls.Add(label1);
        Controls.Add(btnPowerOff);
        Controls.Add(btnPowerOn);
        Margin = new Padding(4, 3, 4, 3);
        Name = "MotionControl";
        Size = new Size(957, 543);
        ((System.ComponentModel.ISupportInitialize)udRobot).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btnPowerOn;
    private Button btnPowerOff;
    private Label label1;
    private Button btnMoveJC;
    private PropertyGrid gridMDesc;
    private Label label2;
    private PropertyGrid gridFrame;
    private Label label3;
    private Label label4;
    private PropertyGrid gridJoint;
    private Button btnMoveL;
    private Button btnMoveJJ;
    private Label label5;
    private NumericUpDown udRobot;
    private Label lblPowerResult;
    private Label lblMoveResult;
}
