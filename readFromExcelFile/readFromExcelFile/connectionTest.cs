using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
namespace readFromExcelFile
{
    public partial class connectionTest : Form
    {
        public connectionTest()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            /*
            using (SqlConnection cx = new SqlConnection())
            {
                cx.ConnectionString = ConfigurationManager.ConnectionStrings["staging"].ConnectionString;

                string connectionString = @"Server = localhost; Database = db_stage;Trusted_Connection = True;";
                MessageBox.Show(ConfigurationManager.ConnectionStrings["staging"].ConnectionString);
                
            }
            Form.ActiveForm.Dispose();*/
        }

        private void connectionTest_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Helo");
            var profiles = (ConnectionStringsSection)ConfigurationManager.GetSection("connectionStrings");
            //var section = (ConnectionStringsSection) Configuration.GetSection("connectionStrings");
            List<string> names = new List<string>();
            for (int i =0;i<profiles.ConnectionStrings.Count;i++)
            {
                names.Add(profiles.ConnectionStrings[i].Name);
            }
            comboBox1.Items.AddRange(names.ToArray());
           //["MyConnectionString"].ConnectionString = "Data Source=...";
           // configuration.Save();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings[comboBox1.Text].ConnectionString;
            string[] csValues = connectionString.Split(';');
            string server = csValues[0].Split('=')[1].Trim();
            string db = csValues[1].Split('=')[1].Trim();
            string user = csValues[2].Split('=')[1].Trim();//Database = db_stage;Trusted_Connection = True;";
            string password = csValues[3].Split('=')[1].Trim();

            textBox1.Text = server;
            textBox2.Text = user;
            textBox3.Text = password;
            textBox4.Text = db;
        }
    }
}
