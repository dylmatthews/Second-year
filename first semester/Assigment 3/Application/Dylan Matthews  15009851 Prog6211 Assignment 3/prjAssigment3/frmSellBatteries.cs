/* this is the sell batteries screen
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
    public partial class frmSellBatteries : Form
    {
        string[,] batteries;

        public frmSellBatteries()
        {
            
            InitializeComponent();   
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public  int start()
        {
             int cn = 0;
             try
            {

                StreamReader sr = new StreamReader("batteries.txt");
                int cnt = 0;
                string line = sr.ReadLine();
                while (line != null)
                {
                    cnt++; //counts to see how big to make array
                    line = sr.ReadLine();
                }
                sr.Close();
                 batteries = new string[cnt, 3];
                   StreamReader s = new StreamReader("batteries.txt");
               string lin = s.ReadLine();
                while (lin != null)
                {
                    string[] temp = lin.Split(',');
                    batteries[cn, 0] = temp[0];
                    batteries[cn, 1] = temp[1];
                    batteries[cn, 2] = temp[2];
                    lin = s.ReadLine();
                    cn++;

                }
                s.Close();
             }catch
             {

             }
            return cn;
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnShow_Click(object sender, EventArgs e)
        {
           int cn = start();

                for (int i = 0; i <= cn-1; i++)
                {
                    string tt = batteries[i, 0];
                    lstBat.Items.Add(tt);
                }
            
            
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnSubmit_Click(object sender, EventArgs e) //submits
        {
               if (!(txtBatName.Text.Equals("")))
                {
                    try
                    {
                     int sub = Convert.ToInt32(txtQuan.Text);
                     bool found = false;
                int cn = start();
                double cost = 0;
                for (int i = 0; i <= cn - 1; i++)
                {

                    if (txtBatName.Text.Equals(batteries[i, 0]))
                    {
                        MessageBox.Show("Found Name");
                        found = true;
                        int pos = i;
                        cost = Convert.ToDouble(batteries[pos, 2]);
                     
                      
                        if ((Convert.ToInt32(batteries[pos, 1]) - sub) >= 0)
                        {
                            int tot = Convert.ToInt32(batteries[pos, 1]) - sub;
                            batteries[pos, 1] = tot.ToString();
                            using (StreamWriter writer = File.CreateText("batteries.txt"))
                            {
                                for (int y = 0; y < cn; y++)
                                {
                                    writer.WriteLine(batteries[y, 0] + "," + batteries[y, 1] + "," + batteries[y, 2]);
                                }
                                writer.Close();
                                MessageBox.Show("Updated text file");
                                MessageBox.Show("That will cost" + cost);
                            }
                        }
                        else
                        {
                            MessageBox.Show("We currently don't have that much stock");
                        }


                    }
                }
                        if (found==false)
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
                   MessageBox.Show("You didnt insert a battery name");
               }
               


        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnBack_Click(object sender, EventArgs e) //back t o prevoius screen
        {
            this.Hide();
            frmMenu mn = new frmMenu();
            mn.Show();
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnClear_Click(object sender, EventArgs e) //clears txt
        {
            txtBatName.Text = "";
            txtQuan.Text = "";
        }

        private void txtQuan_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblQuan_Click(object sender, EventArgs e)
        {

        }

        private void lblBatName_Click(object sender, EventArgs e)
        {

        }

        private void txtBatName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstBat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
            
    }
}
