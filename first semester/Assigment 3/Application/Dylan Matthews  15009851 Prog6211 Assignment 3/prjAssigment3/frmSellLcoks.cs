﻿/* this is the sell locks screen
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
    public partial class frmSellLcoks : Form
    {
        string[,] locks;
        public frmSellLcoks()
        {
            InitializeComponent();
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public int start()
        {
            int cn = 0;
            try
            {

                StreamReader sr = new StreamReader("locks.txt");
                int cnt = 0;
                string line = sr.ReadLine();
                while (line != null)
                {
                    cnt++; //counts to see how big to make array
                    line = sr.ReadLine();
                }
                sr.Close();
                locks = new string[cnt, 3];
                StreamReader s = new StreamReader("locks.txt");
                string lin = s.ReadLine();
                while (lin != null)
                {
                    string[] temp = lin.Split(',');
                    locks[cn, 0] = temp[0];
                    locks[cn, 1] = temp[1];
                    locks[cn, 2] = temp[2];
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
        private void btnSubmit_Click(object sender, EventArgs e) //submits locks
        {
            if (!(txtLockName.Text.Equals("")))
            {
                try
                {
                    int sub = Convert.ToInt32(txtQuan.Text);
                    bool found = false;
                    int cn = start();
                    for (int i = 0; i <= cn - 1; i++)
                    {

                        if (txtLockName.Text.Equals(locks[i, 0]))
                        {
                            MessageBox.Show("Found Name");
                            found = true;
                            int pos = i;


                            if ((Convert.ToInt32(locks[pos, 1]) - sub) >= 0)
                            {
                                int tot = Convert.ToInt32(locks[pos, 1]) - sub;
                                locks[pos, 1] = tot.ToString();
                                using (StreamWriter writer = File.CreateText("locks.txt"))
                                {
                                    for (int y = 0; y < cn; y++)
                                    {
                                        writer.WriteLine(locks[y, 0] + "," + locks[y, 1] + "," + locks[y, 2]);
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
                MessageBox.Show("You didnt insert a lock name");
            }
           
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnBack_Click(object sender, EventArgs e) //goes back to prevoius screen
        {
            this.Hide();
            frmMenu mn = new frmMenu();
            mn.Show();
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnClear_Click(object sender, EventArgs e) //clears txt
        {
            txtLockName.Text = "";
            txtQuan.Text = "";
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnShow_Click(object sender, EventArgs e) //shows locks
        {
            int cn = start();

            for (int i = 0; i <= cn - 1; i++)
            {
                string tt = locks[i, 0];
                lstLocks.Items.Add(tt);
            }
            
        }
    }
}
