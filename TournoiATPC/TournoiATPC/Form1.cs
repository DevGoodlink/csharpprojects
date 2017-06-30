using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TournoiATPC
{
    public partial class Form1 : Form
    {
        int player1 = 0;
        int player2 = 0;
        String connectionString = @"Data Source=POSTE20031;Initial Catalog=Tennis;Persist Security Info=True;User ID=sa; Password=123";
        public Form1()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    //conn.Open();
                    using (SqlCommand cmdPlayers = new SqlCommand("select nom from joueur", conn))
                    {
                        cmdPlayers.CommandType = CommandType.Text;
                        conn.Open();
                        SqlDataReader sdr = cmdPlayers.ExecuteReader();
                        while (sdr.Read())
                        {
                            comboBox1.Items.Add(sdr.GetString(0));
                            comboBox2.Items.Add(sdr.GetString(0));
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conn.Close();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    //conn.Open();
                    using (SqlCommand cmdheadtohead = new SqlCommand("sp_winner",conn))
                    {
                        cmdheadtohead.CommandType = CommandType.StoredProcedure;
                        cmdheadtohead.Parameters.Add("@player1", SqlDbType.NVarChar,20);
                        cmdheadtohead.Parameters["@player1"].Direction = ParameterDirection.Input;
                        cmdheadtohead.Parameters["@player1"].Value = comboBox1.Text;


                        cmdheadtohead.Parameters.Add("@player2", SqlDbType.NVarChar,20);
                        cmdheadtohead.Parameters["@player2"].Direction = ParameterDirection.Input;
                        cmdheadtohead.Parameters["@player2"].Value = comboBox2.Text;


                        conn.Open();
                        SqlDataReader sdr = cmdheadtohead.ExecuteReader();
                        
                        while (sdr.Read())
                        {

                           player1= sdr.GetInt32(0);
                            player2=sdr.GetInt32(1);
                        }
                        if (player1>player2)
                        {
                            label1.ForeColor = Color.DarkGreen;
                            label2.ForeColor = Color.Red;

                        }
                        else
                        {
                            label1.ForeColor = Color.Red;
                            label2.ForeColor = Color.DarkGreen;
                        }
                        label1.Text = "" + player1;
                        label2.Text = "" + player2;
                    }
                    conn.Close();


                }
                catch (Exception ex )
                {
                    MessageBox.Show(ex.Message);
                }

            }
    }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String picplayer1 = Application.StartupPath + "\\pics\\" + comboBox1.Text + ".png";
            //MessageBox.Show(pic);
            

            if (File.Exists(picplayer1))
            {
                Image i = Image.FromFile(picplayer1);

                pictureBox1.Image = i;
                pictureBox1.Height = i.Height;
                pictureBox1.Width = i.Width;

            }
            
            //MessageBox.Show();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            String picplayer2 = Application.StartupPath + "\\pics\\" + comboBox2.Text + ".png";
            //MessageBox.Show(pic);


            if (File.Exists(picplayer2))
            {
                Image i = Image.FromFile(picplayer2);

                pictureBox2.Image = i;
                pictureBox2.Height = i.Height;
                pictureBox2.Width = i.Width;

            }
        }
    }
}
