using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.OleDb;

namespace readFromExcelFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private string GetConnectionString(string fileName)
        //{
        //    Dictionary<string, string> props = new Dictionary<string, string>();

        //    // XLSX - Excel 2007, 2010, 2012, 2013
        //    props["Provider"] = "Microsoft.ACE.OLEDB.12.0;";
        //    props["Extended Properties"] = "Excel 12.0 XML";
        //    props["Data Source"] = fileName;

        //    // XLS - Excel 2003 and Older
        //    //props["Provider"] = "Microsoft.Jet.OLEDB.4.0";
        //    //props["Extended Properties"] = "Excel 8.0";
        //    //props["Data Source"] = "C:\\MyExcel.xls";

        //    StringBuilder sb = new StringBuilder();

        //    foreach (KeyValuePair<string, string> prop in props)
        //    {
        //        sb.Append(prop.Key);
        //        sb.Append('=');
        //        sb.Append(prop.Value);
        //        sb.Append(';');
        //    }

        //    return sb.ToString();
        //}
        //private void displayOnGridFromOle(string fileName)
        //{
        //    DataSet ds = new DataSet();

        //    string connectionString = GetConnectionString(fileName);

        //    using (OleDbConnection conn = new OleDbConnection(connectionString))
        //    {
        //        conn.Open();
        //        OleDbCommand cmd = new OleDbCommand();
        //        cmd.Connection = conn;

        //        // Get all Sheets in Excel File
        //        DataTable dtSheet = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

        //        // Loop through all Sheets to get data
        //        int i = 0;
        //        foreach (DataRow dr in dtSheet.Rows)
        //        {
        //            string sheetName = dr["TABLE_NAME"].ToString();
        //            tabControl1.TabPages[i].Text = sheetName;

        //            /*if (!sheetName.EndsWith("$"))
        //                continue;*/

        //            // Get all rows from the Sheet
        //            cmd.CommandText = "SELECT * FROM [" + sheetName + "]";

        //            DataTable dt = new DataTable();
        //            dt.TableName = sheetName;
        //            //tabControl
        //            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
        //            dt = GenerateTransposedTable(dt);
        //            da.Fill(dt);

        //            ds.Tables.Add(dt);
        //            switch (i)
        //            {
        //                case 0:
        //                    dataGridView1.DataSource = dt;
        //                    break;
        //                case 1:
        //                    dataGridView2.DataSource = dt;
        //                    break;
        //                case 2:
        //                    dataGridView3.DataSource = dt;
        //                    break;

        //                case 3:
        //                    dataGridView4.DataSource = dt;
        //                    break;
        //                default:
        //                    break;
        //            }

        //            i++;
        //        }
        //        //dataGridView1.DataSource=

        //        cmd = null;
        //        conn.Close();
        //    }

        //    //return ds;
        //}
        private void displayOnGrid(string fileName)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            Excel.Range range;
            DataGridView dataGridView;
            string str;
            int rw = 0;
            int cl = 0;
            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open(fileName, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            if (xlWorkBook.Worksheets.Count > 4)
            {
                MessageBox.Show(null,"Le Fichier excel chargé contient plus que 4 feuilles!","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            
            int j = 0;
            foreach (Excel.Worksheet xlWorkSheet_Elt  in xlWorkBook.Worksheets)
            {
                xlWorkSheet = xlWorkSheet_Elt;
                range = xlWorkSheet_Elt.UsedRange;
                rw = range.Columns.Count;
                cl = range.Rows.Count;
                tabControl1.TabPages[j].Text = xlWorkSheet.Name;
                tabControl1.TabPages[j].Controls.Add(new DataGridView()
                {
                    Name = "dataGridView" + j,
                    Dock = DockStyle.Fill
                });
                dataGridView = (DataGridView) tabControl1.TabPages[j].Controls["dataGridView" + j];
                dataGridView.ColumnCount = cl;
                dataGridView.RowCount = rw;
                toolStripStatusLabel2.Text = "Number of lines = " + cl;
                for (int c = 1; c < cl; c++)
                {
                    str = (string)(range.Cells[c, 1] as Excel.Range).Value2;
                    dataGridView.Columns[c - 1].HeaderText = str;
                }
                bool isDouble=false,isDate=false;
                double d=0;
                DateTime date;

                dataGridView.Rows[0].HeaderCell.Value = "1";
                for (int i = 1; i <= cl; i++)
                {
                    try
                    {
                        str = (range.Cells[i, 2] as Excel.Range).Value2.ToString();
                        if (str.Equals("NULL")) continue;
                        if (dataGridView.Columns[i - 1].HeaderText.Contains("DATE"))
                        {
                            isDate = true;
                        }
                        else
                        {
                            isDouble = Double.TryParse(str, out d);
                        }
                        if (isDouble)
                        {
                            dataGridView.Rows[0].Cells[i - 1].Value = "" + d;
                            isDouble = false;
                        }
                        else if (isDate)
                        {
                            Double.TryParse(str, out d);
                            date = DateTime.FromOADate(d);
                            dataGridView.Rows[0].Cells[i-1].Value = "" + date.Day + "/" + date.Month + "/" + date.Year; //date.ToShortDateString();//
                            isDate = false;
                        }
                        else
                        {
                            dataGridView.Rows[0].Cells[i - 1].Value = str;
                        }
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                }
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                Marshal.ReleaseComObject(xlWorkSheet);
                j++;
            }

            xlWorkBook.Close(true, null, null);
            xlApp.Quit();

            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);
        }
       
        private void chargerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.Filter = "Excel Files 2007 (.xlsx)|*.xlsx|Excel Files (.xls)|*.xls";

            if (!(openFileDialog1.ShowDialog() == DialogResult.OK))
            {
                MessageBox.Show("Aucun fichier choisi", "Choisir un fichier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            toolStripStatusLabel1.Text = openFileDialog1.FileName;
            displayOnGrid(openFileDialog1.FileName);
            //displayOnGridFromOle(openFileDialog1.FileName);
        }
        private void loadDataToDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //int i=0;
            //foreach (TabPage tab in tabControl1.TabPages)
            //{
            TabPage tab = tabControl1.TabPages[0];
            DataGridView data = (DataGridView) tab.Controls["dataGridView0"];
            DataTable dt = new DataTable(tab.Text);//nom de la table
            bool isDate = false, isDouble = false;
            double d;
            for (int j = 0; j < data.Columns.Count; j++)
            {
                //
                string header= data.Columns[j].HeaderText;
                //
                string content = (string)data.Rows[0].Cells[j].Value;
                //
                if (content.Equals("NULL")) continue;
                //
                if (header.Contains("DATE"))
                {
                    isDate = true;
                }
                else
                {
                    isDouble = Double.TryParse(content, out d);
                }

            }
            //    i++;
            //    //MessageBox.Show(""+dt.Columns.Count);
            //}
        }

        private void connectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            connectionTest ct = new connectionTest();
            ct.Show();
        }
    }

}
