namespace FICS_DB
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.textbox_email = new System.Windows.Forms.TextBox();
            this.label_email = new System.Windows.Forms.Label();
            this.textbox_password = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.textbox_name = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.textbox_fullname = new System.Windows.Forms.TextBox();
            this.label_fullname = new System.Windows.Forms.Label();
            this.radioButton_scholar = new System.Windows.Forms.RadioButton();
            this.radioButton_mentor = new System.Windows.Forms.RadioButton();
            this.groupbox_person_type = new System.Windows.Forms.GroupBox();
            this.radioButton_counsellor = new System.Windows.Forms.RadioButton();
            this.radioButton_trainer = new System.Windows.Forms.RadioButton();
            this.button_register = new System.Windows.Forms.Button();
            this.button_close_window = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupbox_person_type.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textbox_email
            // 
            this.textbox_email.Location = new System.Drawing.Point(103, 80);
            this.textbox_email.Name = "textbox_email";
            this.textbox_email.Size = new System.Drawing.Size(173, 23);
            this.textbox_email.TabIndex = 3;
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(12, 83);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(39, 15);
            this.label_email.TabIndex = 5;
            this.label_email.Text = "Email:";
            // 
            // textbox_password
            // 
            this.textbox_password.Location = new System.Drawing.Point(103, 112);
            this.textbox_password.Name = "textbox_password";
            this.textbox_password.PasswordChar = '•';
            this.textbox_password.Size = new System.Drawing.Size(173, 23);
            this.textbox_password.TabIndex = 4;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(12, 115);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(60, 15);
            this.label_password.TabIndex = 7;
            this.label_password.Text = "Password:";
            // 
            // textbox_name
            // 
            this.textbox_name.Location = new System.Drawing.Point(103, 22);
            this.textbox_name.Name = "textbox_name";
            this.textbox_name.Size = new System.Drawing.Size(173, 23);
            this.textbox_name.TabIndex = 1;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(12, 25);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(42, 15);
            this.label_name.TabIndex = 9;
            this.label_name.Text = "Name:";
            // 
            // textbox_fullname
            // 
            this.textbox_fullname.Location = new System.Drawing.Point(103, 51);
            this.textbox_fullname.Name = "textbox_fullname";
            this.textbox_fullname.Size = new System.Drawing.Size(173, 23);
            this.textbox_fullname.TabIndex = 2;
            // 
            // label_fullname
            // 
            this.label_fullname.AutoSize = true;
            this.label_fullname.Location = new System.Drawing.Point(12, 54);
            this.label_fullname.Name = "label_fullname";
            this.label_fullname.Size = new System.Drawing.Size(64, 15);
            this.label_fullname.TabIndex = 11;
            this.label_fullname.Text = "Full Name:";
            // 
            // radioButton_scholar
            // 
            this.radioButton_scholar.AutoSize = true;
            this.radioButton_scholar.Location = new System.Drawing.Point(30, 22);
            this.radioButton_scholar.Name = "radioButton_scholar";
            this.radioButton_scholar.Size = new System.Drawing.Size(64, 19);
            this.radioButton_scholar.TabIndex = 1;
            this.radioButton_scholar.TabStop = true;
            this.radioButton_scholar.Text = "Scholar";
            this.radioButton_scholar.UseVisualStyleBackColor = true;
            // 
            // radioButton_mentor
            // 
            this.radioButton_mentor.AutoSize = true;
            this.radioButton_mentor.Location = new System.Drawing.Point(30, 72);
            this.radioButton_mentor.Name = "radioButton_mentor";
            this.radioButton_mentor.Size = new System.Drawing.Size(64, 19);
            this.radioButton_mentor.TabIndex = 3;
            this.radioButton_mentor.TabStop = true;
            this.radioButton_mentor.Text = "Mentor";
            this.radioButton_mentor.UseVisualStyleBackColor = true;
            // 
            // groupbox_person_type
            // 
            this.groupbox_person_type.Controls.Add(this.radioButton_counsellor);
            this.groupbox_person_type.Controls.Add(this.radioButton_trainer);
            this.groupbox_person_type.Controls.Add(this.radioButton_mentor);
            this.groupbox_person_type.Controls.Add(this.radioButton_scholar);
            this.groupbox_person_type.Location = new System.Drawing.Point(12, 141);
            this.groupbox_person_type.Name = "groupbox_person_type";
            this.groupbox_person_type.Size = new System.Drawing.Size(123, 133);
            this.groupbox_person_type.TabIndex = 5;
            this.groupbox_person_type.TabStop = false;
            this.groupbox_person_type.Text = "Register As:";
            // 
            // radioButton_counsellor
            // 
            this.radioButton_counsellor.AutoSize = true;
            this.radioButton_counsellor.Location = new System.Drawing.Point(30, 97);
            this.radioButton_counsellor.Name = "radioButton_counsellor";
            this.radioButton_counsellor.Size = new System.Drawing.Size(82, 19);
            this.radioButton_counsellor.TabIndex = 4;
            this.radioButton_counsellor.TabStop = true;
            this.radioButton_counsellor.Text = "Counsellor";
            this.radioButton_counsellor.UseVisualStyleBackColor = true;
            // 
            // radioButton_trainer
            // 
            this.radioButton_trainer.AutoSize = true;
            this.radioButton_trainer.Location = new System.Drawing.Point(30, 47);
            this.radioButton_trainer.Name = "radioButton_trainer";
            this.radioButton_trainer.Size = new System.Drawing.Size(60, 19);
            this.radioButton_trainer.TabIndex = 2;
            this.radioButton_trainer.TabStop = true;
            this.radioButton_trainer.Text = "Trainer";
            this.radioButton_trainer.UseVisualStyleBackColor = true;
            // 
            // button_register
            // 
            this.button_register.AutoSize = true;
            this.button_register.Location = new System.Drawing.Point(176, 182);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(75, 25);
            this.button_register.TabIndex = 6;
            this.button_register.Text = "Register";
            this.button_register.UseVisualStyleBackColor = true;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // button_close_window
            // 
            this.button_close_window.AutoSize = true;
            this.button_close_window.Location = new System.Drawing.Point(176, 213);
            this.button_close_window.Name = "button_close_window";
            this.button_close_window.Size = new System.Drawing.Size(75, 25);
            this.button_close_window.TabIndex = 7;
            this.button_close_window.Text = "Close";
            this.button_close_window.UseVisualStyleBackColor = true;
            this.button_close_window.Click += new System.EventHandler(this.button_close_window_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.label_status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 292);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(293, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label_status
            // 
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(91, 17);
            this.label_status.Text = "Input your data.";
            // 
            // Register
            // 
            this.AcceptButton = this.button_register;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 314);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button_close_window);
            this.Controls.Add(this.button_register);
            this.Controls.Add(this.textbox_fullname);
            this.Controls.Add(this.label_fullname);
            this.Controls.Add(this.textbox_name);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.textbox_password);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.textbox_email);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.groupbox_person_type);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.groupbox_person_type.ResumeLayout(false);
            this.groupbox_person_type.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textbox_email;
        private Label label_email;
        private TextBox textbox_password;
        private Label label_password;
        private TextBox textbox_name;
        private Label label_name;
        private TextBox textbox_fullname;
        private Label label_fullname;
        private RadioButton radioButton_scholar;
        private RadioButton radioButton_mentor;
        private GroupBox groupbox_person_type;
        private RadioButton radioButton_trainer;
        private RadioButton radioButton_counsellor;
        private Button button_register;
        private Button button_close_window;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel label_status;
    }
}