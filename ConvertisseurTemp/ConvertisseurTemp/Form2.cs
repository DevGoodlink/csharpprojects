using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertisseurTemp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
            
        {
            string strconn = @"Server=192.168.0.2;Database=meteo;User Id=sa;Password=123;";
            using (SqlConnection conn = new SqlConnection(strconn) )
            {
                using (SqlCommand command = new SqlCommand())
                {
                    string qual;
                    if (soleil.Checked)
                    {
                        qual = "soleil";
                    }
                    else
                    {
                        qual = "nuageux";
                    }
                    try
                    {
                        conn.Open();
                        command.Connection = conn;
                        command.CommandType = CommandType.Text;
                        command.CommandText = "insert into temperaturejournaliere values('" + Convert.ToDateTime(jour.Text) + "',(0." + Convert.ToDouble(temperature.Text) + "),'" + qual + "')";
                        command.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Température enregistrée avec succés","Enregistrement",MessageBoxButtons.OK,MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                    
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
