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
    public partial class frmSearch : Form
    {
        string[,] patient;
        bool found = false;
        public frmSearch()
        {
            InitializeComponent();
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnSearch_Click(object sender, EventArgs e)
        {
            start();
            openFile();
            if (rdbNumber.Checked)
            {
                searchNumber();
            }
            else if (rdbSurname.Checked)
            {
                searchSurname();
            }
            else
            {
                MessageBox.Show("You didn't select an option to search by");
            }

            if(found==false)
            {
                MessageBox.Show("User name not found");
            }

            found = false;
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public void searchNumber()
        {
          
                for (int i = 0; i < patient.GetLength(0) && found==false; i++)
                {
                    if (patient[i, 2].Equals(txtSearch.Text))
                    {
                        found = true;
                        txtName.Text = patient[i, 0];
                        txtSurname.Text = patient[i, 1];
                        txtCellphone.Text = patient[i, 2];
                       
                    }
                }
            
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public void searchSurname()
        {
            for (int i = 0; i < patient.GetLength(0) && found == false; i++)
            {
                if (patient[i, 1].Equals(txtSearch.Text))
                {
                    found = true;
                    txtName.Text = patient[i, 0];
                    txtSurname.Text = patient[i, 1];
                    txtCellphone.Text = patient[i, 2];
                       
                }
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
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
            patient = new string[cnt, 3];
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public void openFile()
        {
            StreamReader s = new StreamReader("patientDetails.txt");
            int cn = 0;
            string lin = s.ReadLine();
            while (lin != null)
            {
                string[] temp = lin.Split('#');
                patient[cn, 0] = temp[0];
                patient[cn, 1] = temp[1];
                patient[cn, 2] = temp[2];
                lin = s.ReadLine();
                cn++;

            }
            s.Close();
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCellphone.Text = "";
            txtName.Text = "";
            txtSearch.Text = "";
            txtSurname.Text = "";
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    

       
    }
}
