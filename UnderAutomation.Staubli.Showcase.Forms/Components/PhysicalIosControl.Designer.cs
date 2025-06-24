
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
        gridPhysicalIos = new PropertyGrid();
        ioNamesToRead = new DataGridView();
        ReadIoNameColumn = new DataGridViewTextBoxColumn();
        btnReadIos = new Button();
        gridReadIos = new PropertyGrid();
        ioToWrite = new DataGridView();
        dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
        calueColumn = new DataGridViewTextBoxColumn();
        btnWriteIos = new Button();
        gridWriteIos = new PropertyGrid();
        ((System.ComponentModel.ISupportInitialize)ioNamesToRead).BeginInit();
        ((System.ComponentModel.ISupportInitialize)ioToWrite).BeginInit();
        SuspendLayout();
        // 
        // btnGetAllPhysicalIos
        // 
        btnGetAllPhysicalIos.Location = new Point(75, 10);
        btnGetAllPhysicalIos.Name = "btnGetAllPhysicalIos";
        btnGetAllPhysicalIos.Size = new Size(165, 39);
        btnGetAllPhysicalIos.TabIndex = 0;
        btnGetAllPhysicalIos.Text = "Get all physical I/Os";
        btnGetAllPhysicalIos.UseVisualStyleBackColor = true;
        btnGetAllPhysicalIos.Click += btnGetAllPhysicalIos_Click;
        // 
        // gridPhysicalIos
        // 
        gridPhysicalIos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        gridPhysicalIos.HelpVisible = false;
        gridPhysicalIos.Location = new Point(0, 55);
        gridPhysicalIos.Name = "gridPhysicalIos";
        gridPhysicalIos.PropertySort = PropertySort.NoSort;
        gridPhysicalIos.Size = new Size(347, 854);
        gridPhysicalIos.TabIndex = 2;
        gridPhysicalIos.ToolbarVisible = false;
        // 
        // ioNamesToRead
        // 
        ioNamesToRead.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        ioNamesToRead.Columns.AddRange(new DataGridViewColumn[] { ReadIoNameColumn });
        ioNamesToRead.Location = new Point(393, 7);
        ioNamesToRead.Name = "ioNamesToRead";
        ioNamesToRead.Size = new Size(270, 235);
        ioNamesToRead.TabIndex = 3;
        // 
        // ReadIoNameColumn
        // 
        ReadIoNameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        ReadIoNameColumn.HeaderText = "I/O Names to read";
        ReadIoNameColumn.Name = "ReadIoNameColumn";
        // 
        // btnReadIos
        // 
        btnReadIos.Location = new Point(445, 248);
        btnReadIos.Name = "btnReadIos";
        btnReadIos.Size = new Size(165, 39);
        btnReadIos.TabIndex = 0;
        btnReadIos.Text = "Read I/Os";
        btnReadIos.UseVisualStyleBackColor = true;
        btnReadIos.Click += btnReadIos_Click;
        // 
        // gridReadIos
        // 
        gridReadIos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        gridReadIos.HelpVisible = false;
        gridReadIos.Location = new Point(393, 293);
        gridReadIos.Name = "gridReadIos";
        gridReadIos.PropertySort = PropertySort.NoSort;
        gridReadIos.Size = new Size(270, 616);
        gridReadIos.TabIndex = 2;
        gridReadIos.ToolbarVisible = false;
        // 
        // ioToWrite
        // 
        ioToWrite.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        ioToWrite.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, calueColumn });
        ioToWrite.Location = new Point(733, 7);
        ioToWrite.Name = "ioToWrite";
        ioToWrite.Size = new Size(318, 235);
        ioToWrite.TabIndex = 4;
        ioToWrite.CellValueChanged += ioToWrite_CellValueChanged;
        ioToWrite.DefaultValuesNeeded += ioToWrite_DefaultValuesNeeded;
        // 
        // dataGridViewTextBoxColumn1
        // 
        dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        dataGridViewTextBoxColumn1.HeaderText = "I/O Names to write";
        dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
        // 
        // calueColumn
        // 
        calueColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        calueColumn.HeaderText = "New value";
        calueColumn.Name = "calueColumn";
        // 
        // btnWriteIos
        // 
        btnWriteIos.Location = new Point(810, 248);
        btnWriteIos.Name = "btnWriteIos";
        btnWriteIos.Size = new Size(165, 39);
        btnWriteIos.TabIndex = 5;
        btnWriteIos.Text = "Write I/Os";
        btnWriteIos.UseVisualStyleBackColor = true;
        btnWriteIos.Click += btnWriteIos_Click;
        // 
        // gridWriteIos
        // 
        gridWriteIos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        gridWriteIos.HelpVisible = false;
        gridWriteIos.Location = new Point(733, 293);
        gridWriteIos.Name = "gridWriteIos";
        gridWriteIos.PropertySort = PropertySort.NoSort;
        gridWriteIos.Size = new Size(318, 616);
        gridWriteIos.TabIndex = 6;
        gridWriteIos.ToolbarVisible = false;
        // 
        // PhysicalIosControl
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(gridWriteIos);
        Controls.Add(btnWriteIos);
        Controls.Add(ioToWrite);
        Controls.Add(ioNamesToRead);
        Controls.Add(gridReadIos);
        Controls.Add(gridPhysicalIos);
        Controls.Add(btnReadIos);
        Controls.Add(btnGetAllPhysicalIos);
        Margin = new Padding(4, 3, 4, 3);
        Name = "PhysicalIosControl";
        Size = new Size(1054, 912);
        ((System.ComponentModel.ISupportInitialize)ioNamesToRead).EndInit();
        ((System.ComponentModel.ISupportInitialize)ioToWrite).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Button btnGetAllPhysicalIos;
    private PropertyGrid gridPhysicalIos;
    private DataGridView ioNamesToRead;
    private Button btnReadIos;
    private PropertyGrid gridReadIos;
    private DataGridViewTextBoxColumn ReadIoNameColumn;
    private DataGridView ioToWrite;
    private Button btnWriteIos;
    private PropertyGrid gridWriteIos;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private DataGridViewTextBoxColumn calueColumn;
}
