
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
        SuspendLayout();
        // 
        // btnGetValApplications
        // 
        btnGetValApplications.Anchor = AnchorStyles.Top;
        btnGetValApplications.Location = new Point(390, 7);
        btnGetValApplications.Name = "btnGetValApplications";
        btnGetValApplications.Size = new Size(165, 39);
        btnGetValApplications.TabIndex = 0;
        btnGetValApplications.Text = "Get VAL applications";
        btnGetValApplications.UseVisualStyleBackColor = true;
        btnGetValApplications.Click += btnGetValApplications_Click;
        // 
        // gridValApplications
        // 
        gridValApplications.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
        gridValApplications.HelpVisible = false;
        gridValApplications.Location = new Point(227, 52);
        gridValApplications.Name = "gridValApplications";
        gridValApplications.PropertySort = PropertySort.NoSort;
        gridValApplications.Size = new Size(488, 498);
        gridValApplications.TabIndex = 2;
        gridValApplications.ToolbarVisible = false;
        // 
        // ValApplicationsControl
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(gridValApplications);
        Controls.Add(btnGetValApplications);
        Margin = new Padding(4, 3, 4, 3);
        Name = "ValApplicationsControl";
        Size = new Size(957, 553);
        ResumeLayout(false);
    }

    #endregion

    private Button btnGetValApplications;
    private PropertyGrid gridValApplications;
}
