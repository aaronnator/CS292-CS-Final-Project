namespace Final_Project___Hardware_Tracker
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelLogin = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnPassword = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radComp = new System.Windows.Forms.RadioButton();
            this.radPack = new System.Windows.Forms.RadioButton();
            this.btnGetData = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createReportToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statStripLogin = new System.Windows.Forms.ToolStripStatusLabel();
            this.hardwareComponentsTableAdapter1 = new Final_Project___Hardware_Tracker.HardwareComponentsDatasetTableAdapters.HardwareComponentsTableAdapter();
            this.panelLogin.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.label3);
            this.panelLogin.Controls.Add(this.label2);
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Controls.Add(this.txtPassword);
            this.panelLogin.Controls.Add(this.txtUsername);
            this.panelLogin.Controls.Add(this.btnPassword);
            this.panelLogin.Location = new System.Drawing.Point(31, 33);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(259, 197);
            this.panelLogin.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Welcome to the Perma-Column Hardware Tracker.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(103, 93);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 2;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(103, 63);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 1;
            // 
            // btnPassword
            // 
            this.btnPassword.Location = new System.Drawing.Point(94, 129);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(75, 23);
            this.btnPassword.TabIndex = 0;
            this.btnPassword.Text = "Login";
            this.btnPassword.UseVisualStyleBackColor = true;
            this.btnPassword.Click += new System.EventHandler(this.btnPassword_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.groupBox1);
            this.panelMenu.Controls.Add(this.btnGetData);
            this.panelMenu.Controls.Add(this.menuStrip1);
            this.panelMenu.Location = new System.Drawing.Point(357, 33);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(269, 197);
            this.panelMenu.TabIndex = 1;
            this.panelMenu.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radComp);
            this.groupBox1.Controls.Add(this.radPack);
            this.groupBox1.Location = new System.Drawing.Point(19, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 47);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pick database.";
            // 
            // radComp
            // 
            this.radComp.AutoSize = true;
            this.radComp.Location = new System.Drawing.Point(114, 19);
            this.radComp.Name = "radComp";
            this.radComp.Size = new System.Drawing.Size(105, 17);
            this.radComp.TabIndex = 2;
            this.radComp.TabStop = true;
            this.radComp.Text = "Component Data";
            this.radComp.UseVisualStyleBackColor = true;
            this.radComp.CheckedChanged += new System.EventHandler(this.radComp_CheckedChanged);
            // 
            // radPack
            // 
            this.radPack.AutoSize = true;
            this.radPack.Location = new System.Drawing.Point(14, 19);
            this.radPack.Name = "radPack";
            this.radPack.Size = new System.Drawing.Size(94, 17);
            this.radPack.TabIndex = 1;
            this.radPack.TabStop = true;
            this.radPack.Text = "Package Data";
            this.radPack.UseVisualStyleBackColor = true;
            this.radPack.CheckedChanged += new System.EventHandler(this.radPack_CheckedChanged);
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(92, 108);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(75, 23);
            this.btnGetData.TabIndex = 3;
            this.btnGetData.Text = "Get Data";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.createReportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(269, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editUsersToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.usersToolStripMenuItem.Text = "User";
            // 
            // editUsersToolStripMenuItem
            // 
            this.editUsersToolStripMenuItem.Name = "editUsersToolStripMenuItem";
            this.editUsersToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editUsersToolStripMenuItem.Text = "Edit Users";
            this.editUsersToolStripMenuItem.Click += new System.EventHandler(this.editUsersToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.logOutToolStripMenuItem.Text = "Log-Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // createReportToolStripMenuItem
            // 
            this.createReportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createReportToolStripMenuItem1});
            this.createReportToolStripMenuItem.Name = "createReportToolStripMenuItem";
            this.createReportToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.createReportToolStripMenuItem.Text = "Data";
            // 
            // createReportToolStripMenuItem1
            // 
            this.createReportToolStripMenuItem1.Name = "createReportToolStripMenuItem1";
            this.createReportToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.createReportToolStripMenuItem1.Text = "Create Report";
            this.createReportToolStripMenuItem1.Click += new System.EventHandler(this.createReportToolStripMenuItem1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statStripLogin});
            this.statusStrip1.Location = new System.Drawing.Point(0, 252);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(683, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statStripLogin
            // 
            this.statStripLogin.Name = "statStripLogin";
            this.statStripLogin.Size = new System.Drawing.Size(0, 17);
            // 
            // hardwareComponentsTableAdapter1
            // 
            this.hardwareComponentsTableAdapter1.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 274);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Hardware Tracker";
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnPassword;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createReportToolStripMenuItem1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statStripLogin;
        private System.Windows.Forms.RadioButton radComp;
        private System.Windows.Forms.RadioButton radPack;
        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.GroupBox groupBox1;
        private HardwareComponentsDatasetTableAdapters.HardwareComponentsTableAdapter hardwareComponentsTableAdapter1;
    }
}

