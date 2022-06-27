namespace FICS_DB
{
    partial class Scholar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Scholar));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.label_name = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.group_tasks = new System.Windows.Forms.GroupBox();
            this.table_tasks = new System.Windows.Forms.TableLayoutPanel();
            this.button_counsellor = new System.Windows.Forms.Button();
            this.button_mentor = new System.Windows.Forms.Button();
            this.button_trainer = new System.Windows.Forms.Button();
            this.button_report = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage_current = new System.Windows.Forms.TabPage();
            this.dataGrid_courses_current = new System.Windows.Forms.DataGridView();
            this.tabPage_previous = new System.Windows.Forms.TabPage();
            this.group_counselling = new System.Windows.Forms.GroupBox();
            this.dataGrid_counselling = new System.Windows.Forms.DataGridView();
            this.group_mentoring = new System.Windows.Forms.GroupBox();
            this.dataGrid_mentorship = new System.Windows.Forms.DataGridView();
            this.group_courses_previous = new System.Windows.Forms.GroupBox();
            this.dataGrid_courses_previous = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.group_tasks.SuspendLayout();
            this.table_tasks.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage_current.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_courses_current)).BeginInit();
            this.tabPage_previous.SuspendLayout();
            this.group_counselling.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_counselling)).BeginInit();
            this.group_mentoring.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_mentorship)).BeginInit();
            this.group_courses_previous.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_courses_previous)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(856, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripDropDownButton1.Image = global::FICS_DB.Properties.Resources.categories;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(97, 22);
            this.toolStripDropDownButton1.Text = "Application";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Image = global::FICS_DB.Properties.Resources.shutdown__1_;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::FICS_DB.Properties.Resources.failed;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.label_status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 621);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(856, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label_status
            // 
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(98, 17);
            this.label_status.Text = "Welcome XXXXX!";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_name.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label_name.Location = new System.Drawing.Point(63, 28);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(350, 45);
            this.label_name.TabIndex = 14;
            this.label_name.Text = "FULLNAME FULLNAME";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // group_tasks
            // 
            this.group_tasks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.group_tasks.Controls.Add(this.table_tasks);
            this.group_tasks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.group_tasks.Location = new System.Drawing.Point(12, 79);
            this.group_tasks.Name = "group_tasks";
            this.group_tasks.Size = new System.Drawing.Size(832, 100);
            this.group_tasks.TabIndex = 16;
            this.group_tasks.TabStop = false;
            this.group_tasks.Text = "Perform Tasks:";
            // 
            // table_tasks
            // 
            this.table_tasks.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.table_tasks.ColumnCount = 4;
            this.table_tasks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.table_tasks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.table_tasks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.table_tasks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.table_tasks.Controls.Add(this.button_counsellor, 3, 0);
            this.table_tasks.Controls.Add(this.button_mentor, 2, 0);
            this.table_tasks.Controls.Add(this.button_trainer, 1, 0);
            this.table_tasks.Controls.Add(this.button_report, 0, 0);
            this.table_tasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_tasks.Location = new System.Drawing.Point(3, 25);
            this.table_tasks.Name = "table_tasks";
            this.table_tasks.RowCount = 1;
            this.table_tasks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table_tasks.Size = new System.Drawing.Size(826, 72);
            this.table_tasks.TabIndex = 0;
            // 
            // button_counsellor
            // 
            this.button_counsellor.AutoEllipsis = true;
            this.button_counsellor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_counsellor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_counsellor.Location = new System.Drawing.Point(621, 3);
            this.button_counsellor.Name = "button_counsellor";
            this.button_counsellor.Size = new System.Drawing.Size(202, 66);
            this.button_counsellor.TabIndex = 20;
            this.button_counsellor.Text = "Consult Counsellor";
            this.button_counsellor.UseVisualStyleBackColor = true;
            // 
            // button_mentor
            // 
            this.button_mentor.AutoEllipsis = true;
            this.button_mentor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_mentor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_mentor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_mentor.Location = new System.Drawing.Point(415, 3);
            this.button_mentor.Name = "button_mentor";
            this.button_mentor.Size = new System.Drawing.Size(200, 66);
            this.button_mentor.TabIndex = 19;
            this.button_mentor.Text = "Consult Mentor";
            this.button_mentor.UseVisualStyleBackColor = true;
            // 
            // button_trainer
            // 
            this.button_trainer.AutoEllipsis = true;
            this.button_trainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_trainer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_trainer.Location = new System.Drawing.Point(209, 3);
            this.button_trainer.Name = "button_trainer";
            this.button_trainer.Size = new System.Drawing.Size(200, 66);
            this.button_trainer.TabIndex = 18;
            this.button_trainer.Text = "Request Trainer";
            this.button_trainer.UseVisualStyleBackColor = true;
            // 
            // button_report
            // 
            this.button_report.AutoEllipsis = true;
            this.button_report.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_report.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_report.Location = new System.Drawing.Point(3, 3);
            this.button_report.Name = "button_report";
            this.button_report.Size = new System.Drawing.Size(200, 66);
            this.button_report.TabIndex = 17;
            this.button_report.Text = "Write Report";
            this.button_report.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage_current);
            this.tabControl.Controls.Add(this.tabPage_previous);
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabControl.Location = new System.Drawing.Point(12, 185);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(832, 433);
            this.tabControl.TabIndex = 19;
            // 
            // tabPage_current
            // 
            this.tabPage_current.Controls.Add(this.dataGrid_courses_current);
            this.tabPage_current.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage_current.Location = new System.Drawing.Point(4, 30);
            this.tabPage_current.Name = "tabPage_current";
            this.tabPage_current.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_current.Size = new System.Drawing.Size(824, 399);
            this.tabPage_current.TabIndex = 0;
            this.tabPage_current.Text = "Current Courses";
            this.tabPage_current.UseVisualStyleBackColor = true;
            // 
            // dataGrid_courses_current
            // 
            this.dataGrid_courses_current.AllowUserToOrderColumns = true;
            this.dataGrid_courses_current.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_courses_current.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid_courses_current.Location = new System.Drawing.Point(3, 3);
            this.dataGrid_courses_current.Name = "dataGrid_courses_current";
            this.dataGrid_courses_current.RowTemplate.Height = 25;
            this.dataGrid_courses_current.Size = new System.Drawing.Size(818, 393);
            this.dataGrid_courses_current.TabIndex = 1;
            // 
            // tabPage_previous
            // 
            this.tabPage_previous.Controls.Add(this.group_counselling);
            this.tabPage_previous.Controls.Add(this.group_mentoring);
            this.tabPage_previous.Controls.Add(this.group_courses_previous);
            this.tabPage_previous.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage_previous.Location = new System.Drawing.Point(4, 30);
            this.tabPage_previous.Name = "tabPage_previous";
            this.tabPage_previous.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_previous.Size = new System.Drawing.Size(824, 399);
            this.tabPage_previous.TabIndex = 1;
            this.tabPage_previous.Text = "Previous Progress";
            this.tabPage_previous.UseVisualStyleBackColor = true;
            // 
            // group_counselling
            // 
            this.group_counselling.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.group_counselling.Controls.Add(this.dataGrid_counselling);
            this.group_counselling.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.group_counselling.Location = new System.Drawing.Point(13, 262);
            this.group_counselling.Name = "group_counselling";
            this.group_counselling.Size = new System.Drawing.Size(805, 124);
            this.group_counselling.TabIndex = 23;
            this.group_counselling.TabStop = false;
            this.group_counselling.Text = "Counselling Sessions:";
            // 
            // dataGrid_counselling
            // 
            this.dataGrid_counselling.AllowUserToOrderColumns = true;
            this.dataGrid_counselling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_counselling.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid_counselling.Location = new System.Drawing.Point(3, 19);
            this.dataGrid_counselling.Name = "dataGrid_counselling";
            this.dataGrid_counselling.RowTemplate.Height = 25;
            this.dataGrid_counselling.Size = new System.Drawing.Size(799, 102);
            this.dataGrid_counselling.TabIndex = 0;
            // 
            // group_mentoring
            // 
            this.group_mentoring.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.group_mentoring.Controls.Add(this.dataGrid_mentorship);
            this.group_mentoring.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.group_mentoring.Location = new System.Drawing.Point(13, 139);
            this.group_mentoring.Name = "group_mentoring";
            this.group_mentoring.Size = new System.Drawing.Size(805, 120);
            this.group_mentoring.TabIndex = 22;
            this.group_mentoring.TabStop = false;
            this.group_mentoring.Text = "Mentorship Sessions:";
            // 
            // dataGrid_mentorship
            // 
            this.dataGrid_mentorship.AllowUserToOrderColumns = true;
            this.dataGrid_mentorship.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_mentorship.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid_mentorship.Location = new System.Drawing.Point(3, 19);
            this.dataGrid_mentorship.Name = "dataGrid_mentorship";
            this.dataGrid_mentorship.RowTemplate.Height = 25;
            this.dataGrid_mentorship.Size = new System.Drawing.Size(799, 98);
            this.dataGrid_mentorship.TabIndex = 0;
            // 
            // group_courses_previous
            // 
            this.group_courses_previous.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.group_courses_previous.Controls.Add(this.dataGrid_courses_previous);
            this.group_courses_previous.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.group_courses_previous.Location = new System.Drawing.Point(13, 16);
            this.group_courses_previous.Name = "group_courses_previous";
            this.group_courses_previous.Size = new System.Drawing.Size(805, 120);
            this.group_courses_previous.TabIndex = 21;
            this.group_courses_previous.TabStop = false;
            this.group_courses_previous.Text = "Courses:";
            // 
            // dataGrid_courses_previous
            // 
            this.dataGrid_courses_previous.AllowUserToOrderColumns = true;
            this.dataGrid_courses_previous.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_courses_previous.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid_courses_previous.Location = new System.Drawing.Point(3, 19);
            this.dataGrid_courses_previous.Name = "dataGrid_courses_previous";
            this.dataGrid_courses_previous.RowTemplate.Height = 25;
            this.dataGrid_courses_previous.Size = new System.Drawing.Size(799, 98);
            this.dataGrid_courses_previous.TabIndex = 0;
            // 
            // Scholar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 643);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.group_tasks);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Scholar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Scholar Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.scholar_FormClosing);
            this.Load += new System.EventHandler(this.scholar_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.group_tasks.ResumeLayout(false);
            this.table_tasks.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage_current.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_courses_current)).EndInit();
            this.tabPage_previous.ResumeLayout(false);
            this.group_counselling.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_counselling)).EndInit();
            this.group_mentoring.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_mentorship)).EndInit();
            this.group_courses_previous.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_courses_previous)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel label_status;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Label label_name;
        private PictureBox pictureBox1;
        private GroupBox group_tasks;
        private Button button_report;
        private TableLayoutPanel table_tasks;
        private Button button_counsellor;
        private Button button_mentor;
        private Button button_trainer;
        private TabControl tabControl;
        private TabPage tabPage_current;
        private TabPage tabPage_previous;
        private DataGridView dataGrid_courses_current;
        private GroupBox group_counselling;
        private DataGridView dataGrid_counselling;
        private GroupBox group_mentoring;
        private DataGridView dataGrid_mentorship;
        private GroupBox group_courses_previous;
        private DataGridView dataGrid_courses_previous;
    }
}