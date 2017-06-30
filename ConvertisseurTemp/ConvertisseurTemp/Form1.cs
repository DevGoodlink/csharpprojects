using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertisseurTemp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                double cel = Convert.ToDouble(textBox1.Text);
                string soleil;
                if (checkBox1.Checked)
                {
                    soleil = "soleil";
                }
                else
                {
                    soleil = "nuageux";
                }
                string chaine = "Il fait " + cel + "ºC ce qui est équivalent à " + conversionF(cel)+ "ºF et " + conversionK(cel)+ "ºK il fait donc " + qualificatif(cel)+" et "+soleil +".";
                MessageBox.Show(chaine);
            }
        }
        private double conversionK(double c)
        {
            return 237.5+c;
        }
        private double conversionF(double c)
        {
            return ((9 / 5.0)*c) + 32;
        }
        private string qualificatif(double c)
        {
            string q="";
            if (c<=-25)
            {
                q = "Très froid";
            }
            else if((c>-25) && (c<=0))
            {
                q = "Froid";
            }
            else if((c>0) && (c<=10))
            {
                q = "Frais";
            }
            else if((c>10) && (c<=20))
            {
                q = "Doux";
            }
            else if((c>20) && (c<=35))
            {
                q = "Chaud";
            }
            else if(c>35)
            {
                q = "Très chaud";
            }
            return q;
        }
    }
}
