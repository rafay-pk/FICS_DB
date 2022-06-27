using System.Data;
using System.Data.SqlClient;
namespace FICS_DB
{
    public partial class Scholar : Form
    {
        HomePage homepage;
        int scholar_id;
        public Scholar(HomePage homepage)
        {
            InitializeComponent();
            this.homepage = homepage;
            scholar_id = homepage.person_id;
        }

        private void scholar_Load(object sender, EventArgs e)
        {
            label_name.Text = Program.ExecuteQuerySingleValue(
                "select p.fullname " + "from person p where p.id = " + scholar_id.ToString());
            string courseQuery_part1 = @"select 
	                                        d.name as Category,
	                                        cd.title as Skill_Level, 
	                                        w.name as Website, 
	                                        w.url as Website_Link, 
	                                        sc.date_enrolled as Date_Enrolled, 
	                                        sc.date_completion as ";
            string courseQuery_part2 = @"from 
	                                        scholar_courses sc 
	                                        join course c on sc.course_id = c.id 
	                                        join domain d on c.domain_id = d.id
	                                        join website w on c.website_id = w.id
	                                        join course_difficulity cd on c.difficulity_id = cd.id 
                                        where 
	                                        sc.scholar_id=" + scholar_id.ToString();
            string courseQuery_part3 = "order by sc.date_completion";
            Program.ExecuteTableQuery(ref dataGrid_courses_current, 
                courseQuery_part1 + "Date_to_Complete " + courseQuery_part2 +
                " and sc.date_enrolled < sc.date_completion " + courseQuery_part3);
            Program.ExecuteTableQuery(ref dataGrid_courses_previous,
                courseQuery_part1 + "Date_Completed " + courseQuery_part2 +
                " and sc.date_enrolled >= sc.date_completion " + courseQuery_part3);
            Program.ExecuteTableQuery(ref dataGrid_mentorship,
                @"select
	                 p.fullname as Mentor_Name,
	                 ms.date_and_time as Date_and_Time,
	                 ms.meeting_link as Meeting_Link, 
	                 ms.notes as Notes
                 from mentor_session ms join person p on ms.mentor_id = p.id
                 where ms.date_and_time < getdate()");
            Program.ExecuteTableQuery(ref dataGrid_counselling,
                @"select
	                 p.fullname as Counsellor_Name,
	                 cs.date_and_time as Date_and_Time,
	                 cs.meeting_link as Meeting_Link, 
	                 cs.advice as Advice_Received
                 from counsellor_session cs join person p on cs.counsellor_id = p.id
                 where cs.date_and_time < getdate()");
            Utility.Success(ref label_status, "Welcome " + Program.ExecuteQuerySingleValue(
                "select p.name " + "from person p where p.id = " + scholar_id.ToString()) + "!");
        }

        private void scholar_FormClosing(object sender, FormClosingEventArgs e) => homepage.Show();
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e) => Close();
        private void quitToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();

    }
}
