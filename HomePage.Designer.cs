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
            this.button_login.Location = new System.Drawing.Point(141, 143);
            this.button_login.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(86, 31);
            this.button_login.TabIndex = 2;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(54, 57);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(49, 20);
            this.label_email.TabIndex = 1;
            this.label_email.Text = "Email:";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(54, 92);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(73, 20);
            this.label_password.TabIndex = 2;
            this.label_password.Text = "Password:";
            // 
            // label_not_a_user
            // 
            this.label_not_a_user.AutoSize = true;
            this.label_not_a_user.Location = new System.Drawing.Point(54, 197);
            this.label_not_a_user.Name = "label_not_a_user";
            this.label_not_a_user.Size = new System.Drawing.Size(139, 20);
            this.label_not_a_user.TabIndex = 3;
            this.label_not_a_user.Text = "Not already a User?";
            // 
            // textbox_email
            // 
            this.textbox_email.Location = new System.Drawing.Point(141, 53);
            this.textbox_email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textbox_email.Name = "textbox_email";
            this.textbox_email.Size = new System.Drawing.Size(214, 27);
            this.textbox_email.TabIndex = 0;
            this.textbox_email.Text = "razz2k01@gmail.com";
            // 
            // textbox_password
            // 
            this.textbox_password.Location = new System.Drawing.Point(141, 92);
            this.textbox_password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textbox_password.Name = "textbox_password";
            this.textbox_password.PasswordChar = '•';
            this.textbox_password.Size = new System.Drawing.Size(214, 27);
            this.textbox_password.TabIndex = 1;
            this.textbox_password.Text = "howdyyo5679";
            // 
            // button_register
            // 
            this.button_register.Location = new System.Drawing.Point(199, 192);
            this.button_register.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(117, 31);
            this.button_register.TabIndex = 4;
            this.button_register.Text = "Get Registered";
            this.button_register.UseVisualStyleBackColor = true;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.label_status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 254);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(402, 26);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label_status
            // 
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(297, 20);
            this.label_status.Text = "Welcome to the FICS Database Application.";
            // 
            // button_dashboard
            // 
            this.button_dashboard.AutoSize = true;
            this.button_dashboard.Location = new System.Drawing.Point(233, 143);
            this.button_dashboard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_dashboard.Name = "button_dashboard";
            this.button_dashboard.Size = new System.Drawing.Size(135, 33);
            this.button_dashboard.TabIndex = 3;
            this.button_dashboard.Text = "Go To Dashboard";
            this.button_dashboard.UseVisualStyleBackColor = true;
            this.button_dashboard.Visible = false;
            this.button_dashboard.Click += new System.EventHandler(this.button_dashboard_Click);
            // 
            // HomePage
            // 
            this.AcceptButton = this.button_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 280);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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