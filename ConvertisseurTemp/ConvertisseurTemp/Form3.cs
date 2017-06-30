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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string strconn = @"Server=192.168.0.2;Database=meteo;User Id=sa;Password=123;";
            using (SqlConnection conn = new SqlConnection(strconn))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    try
                    {

                        command.Connection = conn;
                        command.CommandType = CommandType.Text;
                        command.CommandText = "select jour from temperaturejournaliere";
                        conn.Open();
                        SqlDataReader sdr = command.ExecuteReader();

                        while (sdr.Read())
                        {

                            comboBox1.Items.Add(sdr.GetDateTime(0));

                        }
                        conn.Close();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }

                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strconn = @"Server=192.168.0.2;Database=meteo;User Id=sa;Password=123;";
            using (SqlConnection conn = new SqlConnection(strconn))
            {
                using (SqlCommand command = new SqlCommand("getMeteoByDay", conn))
                {
                    decimal value = 0;
                    try
                    {

                        command.Connection = conn;
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("@day", SqlDbType.DateTime);
                        command.Parameters["@day"].Direction = ParameterDirection.Input;
                        command.Parameters["@day"].Value = Convert.ToDateTime(comboBox1.Text);
                        conn.Open();
                        SqlDataReader sdr = command.ExecuteReader();

                        while (sdr.Read())
                        {

                            value = sdr.GetDecimal(0);

                        }
                        label2.Text = "" + value*100;
                        conn.Close();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }

                }
            }
        }
    }
}
