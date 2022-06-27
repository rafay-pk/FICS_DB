namespace FICS_DB
{
    partial class Teacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teacher));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_name = new System.Windows.Forms.Label();
            this.group_sessions_upcoming = new System.Windows.Forms.GroupBox();
            this.dataGrid_sessions_upcoming = new System.Windows.Forms.DataGridView();
            this.group_sessions_previous = new System.Windows.Forms.GroupBox();
            this.dataGrid_sessions_previous = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.group_sessions_upcoming.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_sessions_upcoming)).BeginInit();
            this.group_sessions_previous.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_sessions_previous)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(726, 25);
            this.toolStrip1.TabIndex = 1;
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 357);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(726, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label_status
            // 
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(98, 17);
            this.label_status.Text = "Welcome XXXXX!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label_name.Location = new System.Drawing.Point(63, 28);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(350, 45);
            this.label_name.TabIndex = 18;
            this.label_name.Text = "FULLNAME FULLNAME";
            // 
            // group_sessions_upcoming
            // 
            this.group_sessions_upcoming.Controls.Add(this.dataGrid_sessions_upcoming);
            this.group_sessions_upcoming.Dock = System.Windows.Forms.DockStyle.Fill;
            this.group_sessions_upcoming.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.group_sessions_upcoming.Location = new System.Drawing.Point(3, 3);
            this.group_sessions_upcoming.Name = "group_sessions_upcoming";
            this.group_sessions_upcoming.Size = new System.Drawing.Size(720, 128);
            this.group_sessions_upcoming.TabIndex = 20;
            this.group_sessions_upcoming.TabStop = false;
            this.group_sessions_upcoming.Text = "Upcoming Sessions:";
            // 
            // dataGrid_sessions_upcoming
            // 
            this.dataGrid_sessions_upcoming.AllowUserToOrderColumns = true;
            this.dataGrid_sessions_upcoming.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_sessions_upcoming.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid_sessions_upcoming.Location = new System.Drawing.Point(3, 25);
            this.dataGrid_sessions_upcoming.Name = "dataGrid_sessions_upcoming";
            this.dataGrid_sessions_upcoming.RowTemplate.Height = 25;
            this.dataGrid_sessions_upcoming.Size = new System.Drawing.Size(714, 100);
            this.dataGrid_sessions_upcoming.TabIndex = 1;
            // 
            // group_sessions_previous
            // 
            this.group_sessions_previous.Controls.Add(this.dataGrid_sessions_previous);
            this.group_sessions_previous.Dock = System.Windows.Forms.DockStyle.Fill;
            this.group_sessions_previous.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.group_sessions_previous.Location = new System.Drawing.Point(3, 137);
            this.group_sessions_previous.Name = "group_sessions_previous";
            this.group_sessions_previous.Size = new System.Drawing.Size(720, 128);
            this.group_sessions_previous.TabIndex = 21;
            this.group_sessions_previous.TabStop = false;
            this.group_sessions_previous.Text = "Previous Sessions:";
            // 
            // dataGrid_sessions_previous
            // 
            this.dataGrid_sessions_previous.AllowUserToOrderColumns = true;
            this.dataGrid_sessions_previous.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_sessions_previous.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid_sessions_previous.Location = new System.Drawing.Point(3, 25);
            this.dataGrid_sessions_previous.Name = "dataGrid_sessions_previous";
            this.dataGrid_sessions_previous.RowTemplate.Height = 25;
            this.dataGrid_sessions_previous.Size = new System.Drawing.Size(714, 100);
            this.dataGrid_sessions_previous.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.group_sessions_upcoming, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.group_sessions_previous, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 89);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(726, 268);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 379);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Teacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.teacher_FormClosing);
            this.Load += new System.EventHandler(this.Teacher_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.group_sessions_upcoming.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_sessions_upcoming)).EndInit();
            this.group_sessions_previous.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_sessions_previous)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel label_status;
        private PictureBox pictureBox1;
        private Label label_name;
        private GroupBox group_sessions_upcoming;
        private DataGridView dataGrid_sessions_upcoming;
        private GroupBox group_sessions_previous;
        private DataGridView dataGrid_sessions_previous;
        private TableLayoutPanel tableLayoutPanel1;
    }
}