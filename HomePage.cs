using System.Data;
using System.Data.SqlClient;

namespace FICS_DB
{
    public partial class HomePage : Form
    {
        #region Cache_Values
        public string email;
        public string password;
        public int person_id;
        #endregion

        public HomePage() => InitializeComponent();

        private void button_login_Click(object sender, EventArgs e)
        {
            email = textbox_email.Text;
            password = textbox_password.Text;
            string output = Program.ExecuteQuerySingleValue(
                "select case when exists(select 1 from person p where p.mail = " +
                "'" + email + "' and p.password = '" + password +
                "') then cast(1 as bit) else cast(0 as bit) end");
            if(Convert.ToBoolean(output))
            {
                Utility.Success(ref label_status, "Logged In Successfully.");
                button_dashboard.Visible = true;
                button_dashboard.Select();
            }
            else
            {
                Utility.Error(ref label_status, "Wrong Email or Password.");
                button_dashboard.Visible = false;
            }
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            registerForm.Show();
        }

        private void button_dashboard_Click(object sender, EventArgs e)
        {
            person_id = Convert.ToInt32(Program.ExecuteQuerySingleValue(
                "select p.id from person p where p.mail = '" + email + 
                "' and p.password = '" + password + "'"));
            switch(Program.ExecuteQuerySingleValue(
                "select p.persontype from person p where p.id = " + person_id))
            {
                case "S": Scholar scholar = new Scholar(this); scholar.Show(); break;
                case "T": Trainer trainer = new Trainer(this); trainer.Show(); break;
                case "M": Teacher mentor = new Teacher(this, 'M'); mentor.Show(); break;
                case "C": Teacher counsellor = new Teacher(this, 'C'); counsellor.Show(); break;
            }
            Hide();
        }

        private void HomePage_VisibleChanged(object sender, EventArgs e)
        {
            //textbox_email.Text = String.Empty;
            //textbox_password.Text = String.Empty;
            //textbox_email.Select();
            button_dashboard.Visible = false;
            button_login.Select();
            Utility.General(ref label_status, "Welcome to the FICS Database Application.");
        }
    }

}
