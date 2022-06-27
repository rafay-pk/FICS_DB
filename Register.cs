namespace FICS_DB
{
    public partial class Register : Form
    {
        public Register() => InitializeComponent();

        private void button_register_Click(object sender, EventArgs e)
        {
            foreach (TextBox textBox in Controls.OfType<TextBox>())
            {
                if (textBox.Text == string.Empty)
                {
                    Utility.Error(ref label_status, "Missing Field(s).");
                    return;
                }
            }
            if (!textbox_email.Text.Contains('@'))
            {
                Utility.Error(ref label_status, "Invalid Email.");
                return;
            }
            char person_type = radioButton_scholar.Checked ? 'S'
                : radioButton_trainer.Checked ? 'T'
                : radioButton_mentor.Checked ? 'M'
                : radioButton_counsellor.Checked ? 'C' : '\0';
            if (person_type == '\0')
            {
                Utility.Error(ref label_status, "You have to select your registration type.");
                return;
            }
            Program.ExecuteDataInsertion("insert into person values ('" +
                textbox_name.Text + "', '" +
                textbox_fullname.Text + "', '" +
                textbox_email.Text + "', '" +
                textbox_password.Text + "', '" + 
                person_type + "')",
                ref label_status,
                "Registered Successfully");
        }

        private void button_close_window_Click(object sender, EventArgs e) => Close();
    }
}
