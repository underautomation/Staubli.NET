
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
        ((System.ComponentModel.ISupportInitialize)udSoapPort).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(63, 44);
        label1.Margin = new Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new Size(63, 15);
        label1.TabIndex = 0;
        label1.Text = "IP address:";
        // 
        // txtIP
        // 
        txtIP.Location = new Point(66, 62);
        txtIP.Margin = new Padding(4, 3, 4, 3);
        txtIP.Name = "txtIP";
        txtIP.Size = new Size(224, 23);
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
        label2.Text = "User:";
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
        label3.Text = "Password";
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
        label4.Size = new Size(68, 15);
        label4.TabIndex = 0;
        label4.Text = "SOAP Port :";
        // 
        // udSoapPort
        // 
        udSoapPort.Location = new Point(66, 228);
        udSoapPort.Maximum = new decimal(new int[] { 1661992959, 1808227885, 5, 0 });
        udSoapPort.Name = "udSoapPort";
        udSoapPort.Size = new Size(120, 23);
        udSoapPort.TabIndex = 6;
        // 
        // ConnectControl
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
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
}
