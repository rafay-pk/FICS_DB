using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FICS_DB
{
    public partial class Teacher : Form
    {
        HomePage homepage;
        int teacher_id;
        char mentor_or_counsellor;
        public Teacher(HomePage homepage, char mentor_or_counsellor)
        {
            InitializeComponent();
            this.homepage = homepage;
            this.mentor_or_counsellor = mentor_or_counsellor;
            teacher_id = homepage.person_id;
        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            label_name.Text = Program.ExecuteQuerySingleValue(
                "select p.fullname " + "from person p where p.id = " + teacher_id.ToString());
            Utility.Success(ref label_status, "Welcome " + Program.ExecuteQuerySingleValue(
                "select p.name " + "from person p where p.id = " + teacher_id.ToString()) + "!");
            this.Text = (mentor_or_counsellor == 'M' ? "Mentor" : "Counsellor") + " Dashboard";
        }
        private void teacher_FormClosing(object sender, FormClosingEventArgs e) => homepage.Show();
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e) => Close();
        private void quitToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();
    }
}
