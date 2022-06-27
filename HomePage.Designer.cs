namespace FICS_DB
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.button_login = new System.Windows.Forms.Button();
            this.label_email = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.label_not_a_user = new System.Windows.Forms.Label();
            this.textbox_email = new System.Windows.Forms.TextBox();
            this.textbox_password = new System.Windows.Forms.TextBox();
            this.button_register = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.button_dashboard = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(123, 107);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(75, 23);
            this.button_login.TabIndex = 2;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(47, 43);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(39, 15);
            this.label_email.TabIndex = 1;
            this.label_email.Text = "Email:";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(47, 69);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(60, 15);
            this.label_password.TabIndex = 2;
            this.label_password.Text = "Password:";
            // 
            // label_not_a_user
            // 
            this.label_not_a_user.AutoSize = true;
            this.label_not_a_user.Location = new System.Drawing.Point(47, 148);
            this.label_not_a_user.Name = "label_not_a_user";
            this.label_not_a_user.Size = new System.Drawing.Size(108, 15);
            this.label_not_a_user.TabIndex = 3;
            this.label_not_a_user.Text = "Not already a User?";
            // 
            // textbox_email
            // 
            this.textbox_email.Location = new System.Drawing.Point(123, 40);
            this.textbox_email.Name = "textbox_email";
            this.textbox_email.Size = new System.Drawing.Size(188, 23);
            this.textbox_email.TabIndex = 0;
            this.textbox_email.Text = "razz2k01@gmail.com";
            // 
            // textbox_password
            // 
            this.textbox_password.Location = new System.Drawing.Point(123, 69);
            this.textbox_password.Name = "textbox_password";
            this.textbox_password.PasswordChar = '•';
            this.textbox_password.Size = new System.Drawing.Size(188, 23);
            this.textbox_password.TabIndex = 1;
            this.textbox_password.Text = "howdyyo5679";
            // 
            // button_register
            // 
            this.button_register.Location = new System.Drawing.Point(161, 144);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(91, 23);
            this.button_register.TabIndex = 4;
            this.button_register.Text = "Get Registered";
            this.button_register.UseVisualStyleBackColor = true;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.label_status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 188);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(352, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label_status
            // 
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(235, 17);
            this.label_status.Text = "Welcome to the FICS Database Application.";
            // 
            // button_dashboard
            // 
            this.button_dashboard.AutoSize = true;
            this.button_dashboard.Location = new System.Drawing.Point(204, 107);
            this.button_dashboard.Name = "button_dashboard";
            this.button_dashboard.Size = new System.Drawing.Size(107, 25);
            this.button_dashboard.TabIndex = 3;
            this.button_dashboard.Text = "Go To Dashboard";
            this.button_dashboard.UseVisualStyleBackColor = true;
            this.button_dashboard.Visible = false;
            this.button_dashboard.Click += new System.EventHandler(this.button_dashboard_Click);
            // 
            // HomePage
            // 
            this.AcceptButton = this.button_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 210);
            this.Controls.Add(this.button_dashboard);
            this.Controls.Add(this.button_register);
            this.Controls.Add(this.textbox_password);
            this.Controls.Add(this.textbox_email);
            this.Controls.Add(this.label_not_a_user);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.VisibleChanged += new System.EventHandler(this.HomePage_VisibleChanged);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_login;
        private Label label_email;
        private Label label_password;
        private Label label_not_a_user;
        private TextBox textbox_email;
        private TextBox textbox_password;
        private Button button_register;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel label_status;
        private Button button_dashboard;
    }
}