
    partial class PhysicalIosControl
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
        btnGetAllPhysicalIos = new Button();
        gridControllerParameters = new PropertyGrid();
        SuspendLayout();
        // 
        // btnGetAllPhysicalIos
        // 
        btnGetAllPhysicalIos.Anchor = AnchorStyles.Top;
        btnGetAllPhysicalIos.Location = new Point(390, 7);
        btnGetAllPhysicalIos.Name = "btnGetAllPhysicalIos";
        btnGetAllPhysicalIos.Size = new Size(165, 39);
        btnGetAllPhysicalIos.TabIndex = 0;
        btnGetAllPhysicalIos.Text = "Get all physical IOs";
        btnGetAllPhysicalIos.UseVisualStyleBackColor = true;
        btnGetAllPhysicalIos.Click += btnGetAllPhysicalIos_Click;
        // 
        // gridControllerParameters
        // 
        gridControllerParameters.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
        gridControllerParameters.HelpVisible = false;
        gridControllerParameters.Location = new Point(227, 52);
        gridControllerParameters.Name = "gridControllerParameters";
        gridControllerParameters.PropertySort = PropertySort.NoSort;
        gridControllerParameters.Size = new Size(488, 498);
        gridControllerParameters.TabIndex = 2;
        gridControllerParameters.ToolbarVisible = false;
        // 
        // PhysicalIosControl
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(gridControllerParameters);
        Controls.Add(btnGetAllPhysicalIos);
        Margin = new Padding(4, 3, 4, 3);
        Name = "PhysicalIosControl";
        Size = new Size(957, 553);
        ResumeLayout(false);
    }

    #endregion

    private Button btnGetAllPhysicalIos;
    private PropertyGrid gridControllerParameters;
}
