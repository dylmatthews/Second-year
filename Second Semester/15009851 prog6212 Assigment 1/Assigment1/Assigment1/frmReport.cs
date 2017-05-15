using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Assigment1
{
    public partial class frmReport : Form
    {
        string[,] report;
        public frmReport()
        {
            InitializeComponent();
            
        }
        /// <summary>
        /// //////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>

        private void btnMakeReport_Click(object sender, EventArgs e)
        {
            start();
            openFile();
            saveFile();
        }
        /// <summary>
        /// //////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        public void saveFile()
        {
            SaveFileDialog svd = new SaveFileDialog();

            svd.Filter = "txt files (*.txt) | *.txt | All files (*.*)|";
            svd.FilterIndex = 2;
            svd.RestoreDirectory = true;
          
            if(svd.ShowDialog()==DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(svd.FileName);
                MessageBox.Show("before for");
                
                    for (int i = 0; i < report.GetLength(0);i++ )
                    {
                        MessageBox.Show("  " + i);
                        if (report[i,0].Length<8)
                        {   //alligns text
                            if (report[i,1].Length<8)
                            {
                                sw.WriteLine(report[i, 0] + "\t\t" + report[i, 1] + "\t\t" + report[i, 2]);
                            }
                            else
                            {
                                sw.WriteLine(report[i, 0] + "\t\t" + report[i, 1] + "\t" + report[i, 2]);
                            }
                        }
                        else
                        {
                            if (report[i, 1].Length <8)
                            {
                                 sw.WriteLine(report[i, 0] + "\t" + report[i, 1] + "\t" + report[i, 2]);
                            }
                           
                            else
                            {
                                sw.WriteLine(report[i, 0] + "\t" + report[i, 1] + "\t" + report[i, 2]);
                            }
                        }
                       
                    }

                    sw.Close();
            }
           
        }

        /// <summary>
        /// //////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        public void start()
        {
            StreamReader sr = new StreamReader("patientDetails.txt");
            int cnt = 0;
            string line = sr.ReadLine();
            while (line != null)
            {
                cnt++; //counts to see how big to make array
                line = sr.ReadLine();
            }
            sr.Close();
            report = new string[cnt, 3];
        }

        /// <summary>
        /// //////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// 
        public void openFile()
        {
            StreamReader s = new StreamReader("patientDetails.txt");
            int cn = 0;
            string lin = s.ReadLine();
            while (lin != null)
            {
                string[] temp = lin.Split('#');
                report[cn, 0] = temp[0];
                report[cn, 1] = temp[1];
                report[cn, 2] = temp[2];
                lin = s.ReadLine();
                cn++;

            }
            s.Close();
        }
        /// <summary>
        /// //////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>

        private void btnshowReport_Click(object sender, EventArgs e)
        {
            OpenFileDialog dial = new OpenFileDialog();
            dial.Title = "Open Text File";
            dial.Filter = "TXT Files|*.txt";
            dial.InitialDirectory = @"C:\";
            
            if (dial.ShowDialog()==DialogResult.OK)
            {
                StreamReader sr = new StreamReader(dial.FileName); //gets name of file
                string line = sr.ReadLine();
                int cnt = 0;

                while (line!=null)
                {
                    txtReport.AppendText(line);
                    txtReport.AppendText(Environment.NewLine);
                    cnt++;
                    line = sr.ReadLine();
                }
                txtReport.AppendText("There are " + cnt + " patients");
                sr.Close();
            }

        }

        /// <summary>
        /// //////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        /// <summary>
        /// //////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReceptionsit rec = new frmReceptionsit();
            this.Hide();
            rec.Show();
        }

        
    }
}
