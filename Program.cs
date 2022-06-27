using System.Data;
using System.Data.SqlClient;
namespace FICS_DB
{
    internal static class Program
    {
        static SqlConnection connection = new SqlConnection();
        static SqlCommand command = new SqlCommand();
        [STAThread] static void Main()
        {
            try
            {
                connection.ConnectionString = "Data Source=FLAGYL\\SQLEXPRESS;" +
                    "Initial Catalog=FICS_DBPROJECT;Integrated Security=True;" +
                    "Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;" +
                    "ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                command.Connection = connection;
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
            ApplicationConfiguration.Initialize();
            Application.Run(new HomePage());
        }
        public static string ExecuteQuerySingleValue(string sqlText)
        {
            try
            {
                command.CommandText = sqlText;
                connection.Open();
                string temp = command.ExecuteScalar().ToString();
                connection.Close();
                return temp;
            }
            catch (Exception e) { MessageBox.Show(e.Message); return String.Empty; }
        }
        public static void ExecuteDataInsertion(string sqlText, ref ToolStripStatusLabel label_status, string success_message)
        {
            string exception = string.Empty;
            try
            {
                command.CommandText = sqlText;
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch(Exception excp) { exception = excp.Message; }
            if (exception == string.Empty)
                Utility.Success(ref label_status, success_message);
            else Utility.Error(ref label_status, exception);
            connection.Close();
        }
        public static void ExecuteTableQuery(ref DataGridView dataGridView, string sqlText)
        {
            try
            {
                DataSet ds = new DataSet();
                new SqlDataAdapter(sqlText, connection).Fill(ds);
                dataGridView.ReadOnly = true;
                dataGridView.DataSource = ds.Tables[0];
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }
        public static (SqlConnection, SqlDataReader) ExecuteQueryReader(string sqlText)
        {
            command.CommandText = sqlText;
            connection.Open();
            return (connection, command.ExecuteReader());
        }
        
    }
    public static class Utility
    {
        public static void General(ref ToolStripStatusLabel label_status, string new_string)
        {
            label_status.ForeColor = Color.Black;
            label_status.Text = new_string;
        }
        public static void Success(ref ToolStripStatusLabel label_status, string new_string)
        {
            label_status.ForeColor = Color.Green;
            label_status.Text = new_string;
        }
        public static void Error(ref ToolStripStatusLabel label_status, string new_string)
        {
            label_status.ForeColor = Color.Red;
            label_status.Text = new_string;
        }
    }
}