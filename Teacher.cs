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
            if (mentor_or_counsellor == 'M')
            {
                string sessionQuery_part1 = @"select 
	                                        p.fullname as Student_Name, 
	                                        ms.date_and_time as Date_and_Time, 
	                                        ms.meeting_link as Meeting_Link ";
                string sessionQuery_part2 = @"from mentor_session ms join person p
                                          on ms.scholar_id = p.id where ";
                Program.ExecuteTableQuery(ref dataGrid_sessions_upcoming,
                    sessionQuery_part1 + sessionQuery_part2 +
                                         "ms.date_and_time > getdate()");
                Program.ExecuteTableQuery(ref dataGrid_sessions_previous,
                    sessionQuery_part1 + ", ms.notes as Notes_Given " +
                    sessionQuery_part2 + "ms.date_and_time < getdate()");
            }
            else
            {
                string sessionQuery_part1 = @"select 
	                                        p.fullname as Student_Name, 
	                                        cs.date_and_time as Date_and_Time, 
	                                        cs.meeting_link as Meeting_Link ";
                string sessionQuery_part2 = @"from counsellor_session cs join person p
                                          on cs.scholar_id = p.id where ";
                Program.ExecuteTableQuery(ref dataGrid_sessions_upcoming,
                    sessionQuery_part1 + sessionQuery_part2 +
                                         "cs.date_and_time > getdate()");
                Program.ExecuteTableQuery(ref dataGrid_sessions_previous,
                    sessionQuery_part1 + ", cs.advice as Advice_Given " +
                    sessionQuery_part2 + "cs.date_and_time < getdate()");
            }
            this.Text = (mentor_or_counsellor == 'M' ? "Mentor" : "Counsellor") + " Dashboard";
            Utility.Success(ref label_status, "Welcome " + Program.ExecuteQuerySingleValue(
                "select p.name " + "from person p where p.id = " + teacher_id.ToString()) + "!");
        }
        private void teacher_FormClosing(object sender, FormClosingEventArgs e) => homepage.Show();
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e) => Close();
        private void quitToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();
    }
}
