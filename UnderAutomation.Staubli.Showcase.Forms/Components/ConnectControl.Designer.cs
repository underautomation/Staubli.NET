
partial class ConnectControl
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
        label1 = new Label();
        txtIP = new TextBox();
        btnConnect = new Button();
        btnDisconnect = new Button();
        lblConnected = new Label();
        label2 = new Label();
        txtUser = new TextBox();
        label3 = new Label();
        txtPassword = new TextBox();
        label4 = new Label();
        udSoapPort = new NumericUpDown();
        btnBrowse = new Button();
        chkFile = new CheckBox();
        label5 = new Label();
        txtFileUser = new TextBox();
        label6 = new Label();
        txtFilePassword = new TextBox();
        label7 = new Label();
        udFilePort = new NumericUpDown();
        lblFiles = new Label();
        dlgControllerFile = new OpenFileDialog();
        ((System.ComponentModel.ISupportInitialize)udSoapPort).BeginInit();
        ((System.ComponentModel.ISupportInitialize)udFilePort).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(63, 44);
        label1.Margin = new Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new Size(420, 15);
        label1.TabIndex = 0;
        label1.Text = "IP address, or .controller file of a controller emulated by Staubli Robotics Suite:";
        // 
        // txtIP
        // 
        txtIP.Location = new Point(66, 62);
        txtIP.Margin = new Padding(4, 3, 4, 3);
        txtIP.Name = "txtIP";
        txtIP.Size = new Size(400, 23);
        txtIP.TabIndex = 1;
        txtIP.Text = "192.168.0.1";
        txtIP.KeyDown += btnConnect_Click;
        // 
        // btnConnect
        // 
        btnConnect.Location = new Point(66, 299);
        btnConnect.Margin = new Padding(4, 3, 4, 3);
        btnConnect.Name = "btnConnect";
        btnConnect.Size = new Size(88, 27);
        btnConnect.TabIndex = 3;
        btnConnect.Text = "Connect";
        btnConnect.UseVisualStyleBackColor = true;
        btnConnect.Click += btnConnect_Click;
        // 
        // btnDisconnect
        // 
        btnDisconnect.Location = new Point(161, 299);
        btnDisconnect.Margin = new Padding(4, 3, 4, 3);
        btnDisconnect.Name = "btnDisconnect";
        btnDisconnect.Size = new Size(88, 27);
        btnDisconnect.TabIndex = 3;
        btnDisconnect.Text = "Disconnect";
        btnDisconnect.UseVisualStyleBackColor = true;
        btnDisconnect.Click += btnDisconnect_Click;
        // 
        // lblConnected
        // 
        lblConnected.AutoSize = true;
        lblConnected.Location = new Point(66, 333);
        lblConnected.Margin = new Padding(4, 0, 4, 0);
        lblConnected.Name = "lblConnected";
        lblConnected.Size = new Size(37, 15);
        lblConnected.TabIndex = 5;
        lblConnected.Text = "______";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(63, 100);
        label2.Margin = new Padding(4, 0, 4, 0);
        label2.Name = "label2";
        label2.Size = new Size(33, 15);
        label2.TabIndex = 0;
        label2.Text = "SOAP user:";
        // 
        // txtUser
        // 
        txtUser.Location = new Point(66, 118);
        txtUser.Margin = new Padding(4, 3, 4, 3);
        txtUser.Name = "txtUser";
        txtUser.Size = new Size(120, 23);
        txtUser.TabIndex = 1;
        txtUser.KeyDown += btnConnect_Click;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(63, 150);
        label3.Margin = new Padding(4, 0, 4, 0);
        label3.Name = "label3";
        label3.Size = new Size(57, 15);
        label3.TabIndex = 0;
        label3.Text = "SOAP password:";
        // 
        // txtPassword
        // 
        txtPassword.Location = new Point(66, 168);
        txtPassword.Margin = new Padding(4, 3, 4, 3);
        txtPassword.Name = "txtPassword";
        txtPassword.Size = new Size(120, 23);
        txtPassword.TabIndex = 1;
        txtPassword.UseSystemPasswordChar = true;
        txtPassword.KeyDown += btnConnect_Click;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(63, 210);
        label4.Margin = new Padding(4, 0, 4, 0);
        label4.Name = "label4";
        label4.Size = new Size(120, 15);
        label4.TabIndex = 0;
        label4.Text = "SOAP port (0: auto):";
        // 
        // udSoapPort
        // 
        udSoapPort.Location = new Point(66, 228);
        udSoapPort.Maximum = new decimal(new int[] { 1661992959, 1808227885, 5, 0 });
        udSoapPort.Name = "udSoapPort";
        udSoapPort.Size = new Size(120, 23);
        udSoapPort.TabIndex = 6;
        // 
        // btnBrowse
        // 
        btnBrowse.Location = new Point(472, 61);
        btnBrowse.Name = "btnBrowse";
        btnBrowse.Size = new Size(32, 25);
        btnBrowse.TabIndex = 2;
        btnBrowse.Text = "...";
        btnBrowse.UseVisualStyleBackColor = true;
        btnBrowse.Click += btnBrowse_Click;
        // 
        // chkFile
        // 
        chkFile.AutoSize = true;
        chkFile.Location = new Point(260, 99);
        chkFile.Name = "chkFile";
        chkFile.Size = new Size(240, 19);
        chkFile.TabIndex = 7;
        chkFile.Text = "Files (FTP, or folder of the .controller file)";
        chkFile.UseVisualStyleBackColor = true;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(257, 128);
        label5.Margin = new Padding(4, 0, 4, 0);
        label5.Name = "label5";
        label5.Size = new Size(55, 15);
        label5.TabIndex = 0;
        label5.Text = "FTP user:";
        // 
        // txtFileUser
        // 
        txtFileUser.Location = new Point(260, 146);
        txtFileUser.Margin = new Padding(4, 3, 4, 3);
        txtFileUser.Name = "txtFileUser";
        txtFileUser.Size = new Size(120, 23);
        txtFileUser.TabIndex = 8;
        txtFileUser.KeyDown += btnConnect_Click;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(257, 178);
        label6.Margin = new Padding(4, 0, 4, 0);
        label6.Name = "label6";
        label6.Size = new Size(83, 15);
        label6.TabIndex = 0;
        label6.Text = "FTP password:";
        // 
        // txtFilePassword
        // 
        txtFilePassword.Location = new Point(260, 196);
        txtFilePassword.Margin = new Padding(4, 3, 4, 3);
        txtFilePassword.Name = "txtFilePassword";
        txtFilePassword.Size = new Size(120, 23);
        txtFilePassword.TabIndex = 9;
        txtFilePassword.UseSystemPasswordChar = true;
        txtFilePassword.KeyDown += btnConnect_Click;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(257, 228);
        label7.Margin = new Padding(4, 0, 4, 0);
        label7.Name = "label7";
        label7.Size = new Size(57, 15);
        label7.TabIndex = 0;
        label7.Text = "FTP port:";
        // 
        // udFilePort
        // 
        udFilePort.Location = new Point(260, 246);
        udFilePort.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
        udFilePort.Name = "udFilePort";
        udFilePort.Size = new Size(120, 23);
        udFilePort.TabIndex = 10;
        // 
        // lblFiles
        // 
        lblFiles.AutoSize = true;
        lblFiles.Location = new Point(66, 357);
        lblFiles.Margin = new Padding(4, 0, 4, 0);
        lblFiles.Name = "lblFiles";
        lblFiles.Size = new Size(0, 15);
        lblFiles.TabIndex = 11;
        // 
        // dlgControllerFile
        // 
        dlgControllerFile.Filter = "Controller emulated by Staubli Robotics Suite (*.controller)|*.controller";
        dlgControllerFile.Title = ".controller file of the emulated controller";
        // 
        // ConnectControl
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(lblFiles);
        Controls.Add(udFilePort);
        Controls.Add(label7);
        Controls.Add(txtFilePassword);
        Controls.Add(label6);
        Controls.Add(txtFileUser);
        Controls.Add(label5);
        Controls.Add(chkFile);
        Controls.Add(btnBrowse);
        Controls.Add(udSoapPort);
        Controls.Add(lblConnected);
        Controls.Add(btnDisconnect);
        Controls.Add(btnConnect);
        Controls.Add(label4);
        Controls.Add(txtPassword);
        Controls.Add(label3);
        Controls.Add(txtUser);
        Controls.Add(label2);
        Controls.Add(txtIP);
        Controls.Add(label1);
        Margin = new Padding(4, 3, 4, 3);
        Name = "ConnectControl";
        Size = new Size(734, 532);
        ((System.ComponentModel.ISupportInitialize)udSoapPort).EndInit();
        ((System.ComponentModel.ISupportInitialize)udFilePort).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtIP;
    private System.Windows.Forms.Button btnConnect;
    private System.Windows.Forms.Button btnDisconnect;
    private System.Windows.Forms.Label lblConnected;
    private Label label2;
    private TextBox txtUser;
    private Label label3;
    private TextBox txtPassword;
    private Label label4;
    private NumericUpDown udSoapPort;
    private Button btnBrowse;
    private CheckBox chkFile;
    private Label label5;
    private TextBox txtFileUser;
    private Label label6;
    private TextBox txtFilePassword;
    private Label label7;
    private NumericUpDown udFilePort;
    private Label lblFiles;
    private OpenFileDialog dlgControllerFile;
}
