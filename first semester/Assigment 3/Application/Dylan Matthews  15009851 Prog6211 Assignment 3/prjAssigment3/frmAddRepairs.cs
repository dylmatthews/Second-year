﻿/* this is the add repairs screen
 * Dylan Matthews
 * 01/06/2016
 * 
 * */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjAssigment3
{
    public partial class frmAddRepairs : Form
    {
        string[,] repairs;
        public frmAddRepairs()
        {
            InitializeComponent();
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public int start()
        {
            int cn = 0;
            try
            {

                StreamReader sr = new StreamReader("repairs.txt");
                int cnt = 0;
                string line = sr.ReadLine();
                while (line != null)
                {
                    cnt++; //counts to see how big to make array
                    line = sr.ReadLine();
                }
                sr.Close();
                repairs = new string[cnt, 3];
                StreamReader s = new StreamReader("repairs.txt");
                string lin = s.ReadLine();
                while (lin != null)
                {
                    string[] temp = lin.Split(',');
                    repairs[cn, 0] = temp[0];
                    repairs[cn, 1] = temp[1];
                    repairs[cn, 2] = temp[2];
                    lin = s.ReadLine();
                    cn++;

                }
                s.Close();
            }
            catch
            {

            }
            return cn;
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnShow_Click(object sender, EventArgs e) //shows repair itemns
        {
            int cn = start();

            for (int i = 0; i <= cn - 1; i++)
            {
                
                string tt = repairs[i, 0];
                lstRepairs.Items.Add(tt);
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnSubmit_Click(object sender, EventArgs e) //sumbits repair
        {
            if (!(txtRepairName.Text.Equals("")))
            {
                try
                {
                    int add = Convert.ToInt32(txtQuan.Text);
                    bool found = false;
                    int cn = start();
                    for (int i = 0; i <= cn - 1; i++)
                    {

                        if (txtRepairName.Text.Equals(repairs[i, 0]))
                        {
                            MessageBox.Show("Found Name");
                            found = true;
                            int pos = i;

                            if (add>=0)
                            {
                                int tot = Convert.ToInt32(repairs[pos, 1]) +add;
                                repairs[pos, 1] = tot.ToString();
                                using (StreamWriter writer = File.CreateText("repairs.txt"))
                                {
                                    for (int y = 0; y < cn; y++)
                                    {
                                        writer.WriteLine(repairs[y, 0] + "," + repairs[y, 1] + "," + repairs[y, 2]);
                                    }
                                    writer.Close();
                                    MessageBox.Show("Updated text file");

                                }
                            }
                            else
                            {
                                MessageBox.Show("We currently don't have that much stock");
                            }


                        }
                    }
                    if (found == false)
                    {
                        MessageBox.Show("No name found");
                    }
                }
                catch
                {
                    MessageBox.Show("You didnt insert a number for quantity");
                }

            }
            else
            {
                MessageBox.Show("You didnt insert a repairs name");
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnClear_Click(object sender, EventArgs e) //clears 
        {
            txtRepairName.Text = "";
            txtQuan.Text = "";
        }


        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        private void btnBack_Click(object sender, EventArgs e) //go bacj a screen
        {
            this.Hide();
            frmAdmin mn = new frmAdmin();
            mn.Show();
        }
    }
}
