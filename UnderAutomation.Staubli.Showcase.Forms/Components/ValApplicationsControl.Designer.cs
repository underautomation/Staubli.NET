
    partial class ValApplicationsControl
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
        btnGetValApplications = new Button();
        gridValApplications = new PropertyGrid();
        txtApplication = new TextBox();
        label1 = new Label();
        btnStartApplication = new Button();
        btnStopApplication = new Button();
        btnStopAndUnloadApplication = new Button();
        btnLoadProject = new Button();
        label2 = new Label();
        label3 = new Label();
        btnResumeTask = new Button();
        btnSuspend = new Button();
        btnKill = new Button();
        txtCreatedBy = new TextBox();
        txtTask = new TextBox();
        gridTasks = new PropertyGrid();
        btnGetAllPhysicalIos = new Button();
        SuspendLayout();
        // 
        // btnGetValApplications
        // 
        btnGetValApplications.Location = new Point(104, 178);
        btnGetValApplications.Name = "btnGetValApplications";
        btnGetValApplications.Size = new Size(173, 39);
        btnGetValApplications.TabIndex = 0;
        btnGetValApplications.Text = "Get loaded applications";
        btnGetValApplications.UseVisualStyleBackColor = true;
        btnGetValApplications.Click += btnGetValApplications_Click;
        // 
        // gridValApplications
        // 
        gridValApplications.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        gridValApplications.HelpVisible = false;
        gridValApplications.Location = new Point(3, 223);
        gridValApplications.Name = "gridValApplications";
        gridValApplications.PropertySort = PropertySort.NoSort;
        gridValApplications.Size = new Size(374, 327);
        gridValApplications.TabIndex = 2;
        gridValApplications.ToolbarVisible = false;
        // 
        // txtApplication
        // 
        txtApplication.Location = new Point(55, 33);
        txtApplication.Name = "txtApplication";
        txtApplication.Size = new Size(254, 23);
        txtApplication.TabIndex = 3;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(55, 15);
        label1.Name = "label1";
        label1.Size = new Size(74, 15);
        label1.TabIndex = 4;
        label1.Text = "Application :";
        // 
        // btnStartApplication
        // 
        btnStartApplication.Location = new Point(183, 62);
        btnStartApplication.Name = "btnStartApplication";
        btnStartApplication.Size = new Size(126, 23);
        btnStartApplication.TabIndex = 5;
        btnStartApplication.Text = "Start application";
        btnStartApplication.UseVisualStyleBackColor = true;
        btnStartApplication.Click += btnStartApplication_Click;
        // 
        // btnStopApplication
        // 
        btnStopApplication.Location = new Point(104, 101);
        btnStopApplication.Name = "btnStopApplication";
        btnStopApplication.Size = new Size(173, 23);
        btnStopApplication.TabIndex = 5;
        btnStopApplication.Text = "Stop application";
        btnStopApplication.UseVisualStyleBackColor = true;
        btnStopApplication.Click += btnStopApplication_Click;
        // 
        // btnStopAndUnloadApplication
        // 
        btnStopAndUnloadApplication.Location = new Point(104, 130);
        btnStopAndUnloadApplication.Name = "btnStopAndUnloadApplication";
        btnStopAndUnloadApplication.Size = new Size(173, 23);
        btnStopAndUnloadApplication.TabIndex = 5;
        btnStopAndUnloadApplication.Text = "Stop and unload application";
        btnStopAndUnloadApplication.UseVisualStyleBackColor = true;
        btnStopAndUnloadApplication.Click += btnStopAndUnloadApplication_Click;
        // 
        // btnLoadProject
        // 
        btnLoadProject.Location = new Point(55, 62);
        btnLoadProject.Name = "btnLoadProject";
        btnLoadProject.Size = new Size(126, 23);
        btnLoadProject.TabIndex = 5;
        btnLoadProject.Text = "Load project";
        btnLoadProject.UseVisualStyleBackColor = true;
        btnLoadProject.Click += btnLoadProject_Click;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(556, 64);
        label2.Name = "label2";
        label2.Size = new Size(70, 15);
        label2.TabIndex = 13;
        label2.Text = "Created by :";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(556, 15);
        label3.Name = "label3";
        label3.Size = new Size(36, 15);
        label3.TabIndex = 14;
        label3.Text = "Task :";
        // 
        // btnResumeTask
        // 
        btnResumeTask.Location = new Point(655, 117);
        btnResumeTask.Name = "btnResumeTask";
        btnResumeTask.Size = new Size(93, 23);
        btnResumeTask.TabIndex = 10;
        btnResumeTask.Text = "Resume task";
        btnResumeTask.UseVisualStyleBackColor = true;
        btnResumeTask.Click += btnResumeTask_Click;
        // 
        // btnSuspend
        // 
        btnSuspend.Location = new Point(556, 117);
        btnSuspend.Name = "btnSuspend";
        btnSuspend.Size = new Size(93, 23);
        btnSuspend.TabIndex = 11;
        btnSuspend.Text = "Suspend task";
        btnSuspend.UseVisualStyleBackColor = true;
        btnSuspend.Click += btnSuspend_Click;
        // 
        // btnKill
        // 
        btnKill.Location = new Point(754, 117);
        btnKill.Name = "btnKill";
        btnKill.Size = new Size(75, 23);
        btnKill.TabIndex = 12;
        btnKill.Text = "Kill task";
        btnKill.UseVisualStyleBackColor = true;
        btnKill.Click += btnKill_Click;
        // 
        // txtCreatedBy
        // 
        txtCreatedBy.Location = new Point(556, 82);
        txtCreatedBy.Name = "txtCreatedBy";
        txtCreatedBy.Size = new Size(273, 23);
        txtCreatedBy.TabIndex = 8;
        txtCreatedBy.Text = "Disk://";
        // 
        // txtTask
        // 
        txtTask.Location = new Point(556, 33);
        txtTask.Name = "txtTask";
        txtTask.Size = new Size(273, 23);
        txtTask.TabIndex = 9;
        // 
        // gridTasks
        // 
        gridTasks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        gridTasks.HelpVisible = false;
        gridTasks.Location = new Point(514, 223);
        gridTasks.Name = "gridTasks";
        gridTasks.PropertySort = PropertySort.NoSort;
        gridTasks.Size = new Size(374, 327);
        gridTasks.TabIndex = 7;
        gridTasks.ToolbarVisible = false;
        // 
        // btnGetAllPhysicalIos
        // 
        btnGetAllPhysicalIos.Location = new Point(616, 178);
        btnGetAllPhysicalIos.Name = "btnGetAllPhysicalIos";
        btnGetAllPhysicalIos.Size = new Size(165, 39);
        btnGetAllPhysicalIos.TabIndex = 6;
        btnGetAllPhysicalIos.Text = "Get Tasks";
        btnGetAllPhysicalIos.UseVisualStyleBackColor = true;
        btnGetAllPhysicalIos.Click += btnGetTasks_Click;
        // 
        // ValApplicationsControl
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(label2);
        Controls.Add(label3);
        Controls.Add(btnResumeTask);
        Controls.Add(btnSuspend);
        Controls.Add(btnKill);
        Controls.Add(txtCreatedBy);
        Controls.Add(txtTask);
        Controls.Add(gridTasks);
        Controls.Add(btnGetAllPhysicalIos);
        Controls.Add(btnStopAndUnloadApplication);
        Controls.Add(btnStopApplication);
        Controls.Add(btnLoadProject);
        Controls.Add(btnStartApplication);
        Controls.Add(label1);
        Controls.Add(txtApplication);
        Controls.Add(gridValApplications);
        Controls.Add(btnGetValApplications);
        Margin = new Padding(4, 3, 4, 3);
        Name = "ValApplicationsControl";
        Size = new Size(957, 553);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btnGetValApplications;
    private PropertyGrid gridValApplications;
    private TextBox txtApplication;
    private Label label1;
    private Button btnStartApplication;
    private Button btnStopApplication;
    private Button btnStopAndUnloadApplication;
    private Button btnLoadProject;
    private Label label2;
    private Label label3;
    private Button btnResumeTask;
    private Button btnSuspend;
    private Button btnKill;
    private TextBox txtCreatedBy;
    private TextBox txtTask;
    private PropertyGrid gridTasks;
    private Button btnGetAllPhysicalIos;
}
