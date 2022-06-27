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
    public partial class Request : Form
    {
        ToolStripStatusLabel label_status;
        int scholar_id;
        public Request(int scholar_id, ref ToolStripStatusLabel label_status)
        {
            this.scholar_id = scholar_id;
            this.label_status = label_status;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.ExecuteDataInsertion("insert into scholar_request " +
                "(scholar_id, trainer_id, request) values (" +
                scholar_id + ", (select p.id from person p where p.name = 'Usama'), '"
                + richTextBox1.Text + "')", ref label_status,
                "Message Successfully Sent to Trainer.");
        }
    }
}
