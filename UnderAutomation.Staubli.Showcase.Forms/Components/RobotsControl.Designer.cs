
    partial class RobotsControl
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
        btnGetRobots = new Button();
        textBox1 = new TextBox();
        gridRobots = new PropertyGrid();
        SuspendLayout();
        // 
        // btnGetRobots
        // 
        btnGetRobots.Anchor = AnchorStyles.Top;
        btnGetRobots.Location = new Point(397, 52);
        btnGetRobots.Name = "btnGetRobots";
        btnGetRobots.Size = new Size(165, 39);
        btnGetRobots.TabIndex = 0;
        btnGetRobots.Text = "Get Robots";
        btnGetRobots.UseVisualStyleBackColor = true;
        btnGetRobots.Click += btnGetRobots_Click;
        // 
        // textBox1
        // 
        textBox1.Dock = DockStyle.Top;
        textBox1.Location = new Point(0, 0);
        textBox1.Multiline = true;
        textBox1.Name = "textBox1";
        textBox1.ReadOnly = true;
        textBox1.Size = new Size(957, 32);
        textBox1.TabIndex = 1;
        textBox1.Text = "A Staubli controller can handle multiple robots";
        // 
        // gridRobots
        // 
        gridRobots.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
        gridRobots.HelpVisible = false;
        gridRobots.Location = new Point(227, 97);
        gridRobots.Name = "gridRobots";
        gridRobots.PropertySort = PropertySort.NoSort;
        gridRobots.Size = new Size(521, 580);
        gridRobots.TabIndex = 2;
        gridRobots.ToolbarVisible = false;
        // 
        // RobotsControl
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(gridRobots);
        Controls.Add(textBox1);
        Controls.Add(btnGetRobots);
        Margin = new Padding(4, 3, 4, 3);
        Name = "RobotsControl";
        Size = new Size(957, 680);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btnGetRobots;
    private TextBox textBox1;
    private PropertyGrid gridRobots;
}
