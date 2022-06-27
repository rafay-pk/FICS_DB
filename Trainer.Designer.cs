namespace FICS_DB
{
    partial class Trainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trainer));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_name = new System.Windows.Forms.Label();
            this.group_students = new System.Windows.Forms.GroupBox();
            this.table_tasks = new System.Windows.Forms.TableLayoutPanel();
            this.button5 = new System.Windows.Forms.Button();
            this.button_requests = new System.Windows.Forms.Button();
            this.button_report = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGrid_students = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.group_students.SuspendLayout();
            this.table_tasks.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_students)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
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
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton2});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(784, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.toolStripDropDownButton2.Image = global::FICS_DB.Properties.Resources.categories;
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(97, 22);
            this.toolStripDropDownButton2.Text = "Application";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::FICS_DB.Properties.Resources.shutdown__1_;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.toolStripMenuItem1.Text = "Log Out";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = global::FICS_DB.Properties.Resources.failed;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(117, 22);
            this.toolStripMenuItem2.Text = "Exit";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label_name.Location = new System.Drawing.Point(63, 28);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(350, 45);
            this.label_name.TabIndex = 16;
            this.label_name.Text = "FULLNAME FULLNAME";
            // 
            // group_students
            // 
            this.group_students.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.group_students.Controls.Add(this.table_tasks);
            this.group_students.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.group_students.Location = new System.Drawing.Point(12, 79);
            this.group_students.Name = "group_students";
            this.group_students.Size = new System.Drawing.Size(760, 229);
            this.group_students.TabIndex = 18;
            this.group_students.TabStop = false;
            this.group_students.Text = "Students_Assigned";
            // 
            // table_tasks
            // 
            this.table_tasks.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.table_tasks.ColumnCount = 3;
            this.table_tasks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table_tasks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.table_tasks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.table_tasks.Controls.Add(this.button5, 2, 1);
            this.table_tasks.Controls.Add(this.button_requests, 2, 0);
            this.table_tasks.Controls.Add(this.button_report, 1, 0);
            this.table_tasks.Controls.Add(this.button1, 1, 1);
            this.table_tasks.Controls.Add(this.button2, 1, 2);
            this.table_tasks.Controls.Add(this.button3, 1, 3);
            this.table_tasks.Controls.Add(this.button4, 1, 4);
            this.table_tasks.Controls.Add(this.button6, 2, 2);
            this.table_tasks.Controls.Add(this.button7, 2, 3);
            this.table_tasks.Controls.Add(this.button8, 2, 4);
            this.table_tasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_tasks.Location = new System.Drawing.Point(3, 25);
            this.table_tasks.Name = "table_tasks";
            this.table_tasks.RowCount = 5;
            this.table_tasks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.table_tasks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.table_tasks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.table_tasks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.table_tasks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.table_tasks.Size = new System.Drawing.Size(754, 201);
            this.table_tasks.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.AutoEllipsis = true;
            this.button5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(607, 43);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(144, 34);
            this.button5.TabIndex = 20;
            this.button5.Text = "Check Requests";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button_requests
            // 
            this.button_requests.AutoEllipsis = true;
            this.button_requests.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_requests.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_requests.Location = new System.Drawing.Point(607, 3);
            this.button_requests.Name = "button_requests";
            this.button_requests.Size = new System.Drawing.Size(144, 34);
            this.button_requests.TabIndex = 19;
            this.button_requests.Text = "Check Requests";
            this.button_requests.UseVisualStyleBackColor = true;
            // 
            // button_report
            // 
            this.button_report.AutoEllipsis = true;
            this.button_report.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_report.Location = new System.Drawing.Point(457, 3);
            this.button_report.Name = "button_report";
            this.button_report.Size = new System.Drawing.Size(144, 34);
            this.button_report.TabIndex = 18;
            this.button_report.Text = "Check Report";
            this.button_report.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.AutoEllipsis = true;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(457, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 34);
            this.button1.TabIndex = 20;
            this.button1.Text = "Check Report";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.AutoEllipsis = true;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(457, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 34);
            this.button2.TabIndex = 21;
            this.button2.Text = "Check Report";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.AutoEllipsis = true;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(457, 123);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 34);
            this.button3.TabIndex = 22;
            this.button3.Text = "Check Report";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.AutoEllipsis = true;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(457, 163);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 34);
            this.button4.TabIndex = 23;
            this.button4.Text = "Check Report";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.AutoEllipsis = true;
            this.button6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(607, 83);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(144, 34);
            this.button6.TabIndex = 24;
            this.button6.Text = "Check Requests";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.AutoEllipsis = true;
            this.button7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button7.Location = new System.Drawing.Point(607, 123);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(144, 34);
            this.button7.TabIndex = 25;
            this.button7.Text = "Check Requests";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.AutoEllipsis = true;
            this.button8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button8.Location = new System.Drawing.Point(607, 163);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(144, 34);
            this.button8.TabIndex = 26;
            this.button8.Text = "Check Requests";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.label_status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 417);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label_status
            // 
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(98, 17);
            this.label_status.Text = "Welcome XXXXX!";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataGrid_students);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(15, 314);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(751, 90);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Students_Assigned";
            // 
            // dataGrid_students
            // 
            this.dataGrid_students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_students.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid_students.Location = new System.Drawing.Point(3, 25);
            this.dataGrid_students.Name = "dataGrid_students";
            this.dataGrid_students.RowTemplate.Height = 25;
            this.dataGrid_students.Size = new System.Drawing.Size(745, 62);
            this.dataGrid_students.TabIndex = 0;
            // 
            // Trainer
            // 
            this.ClientSize = new System.Drawing.Size(784, 439);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.group_students);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.toolStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Trainer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trainer Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.trainer_FormClosing);
            this.Load += new System.EventHandler(this.Trainer_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.group_students.ResumeLayout(false);
            this.table_tasks.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_students)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStrip toolStrip2;
        private ToolStripDropDownButton toolStripDropDownButton2;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private PictureBox pictureBox1;
        private Label label_name;
        private GroupBox group_students;
        private TableLayoutPanel table_tasks;
        private Button button_requests;
        private Button button_report;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button6;
        private Button button5;
        private Button button7;
        private Button button8;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel label_status;
        private GroupBox groupBox1;
        private DataGridView dataGrid_students;
    }
}