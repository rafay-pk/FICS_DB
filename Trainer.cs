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
    public partial class Trainer : Form
    {
        HomePage homepage;
        int trainer_id;
        public Trainer(HomePage homepage)
        {
            InitializeComponent();
            this.homepage = homepage;
            trainer_id = homepage.person_id;
        }
        private void Trainer_Load(object sender, EventArgs e)
        {
            label_name.Text = Program.ExecuteQuerySingleValue(
                "select p.fullname " + "from person p where p.id = " + trainer_id.ToString());
            //Program.ExecuteTableQuery(ref dataGrid_students,
            //    "select p.fullname, from person p join trainer t on p.id = t.trainer_id where persontype = 'S' and t.id = " + trainer_id.ToString())
            Utility.Success(ref label_status, "Welcome " + Program.ExecuteQuerySingleValue(
                "select p.name " + "from person p where p.id = " + trainer_id.ToString()) + "!");
        }

        private void trainer_FormClosing(object sender, FormClosingEventArgs e) => homepage.Show();
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e) => Close();
        private void quitToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();

    }
}
