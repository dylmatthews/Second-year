/* this is the sell shop screen
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
     
    public partial class frmSellShop : Form
    {
        string[,] shop;
        public frmSellShop()
        {
            InitializeComponent();
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public int start() 
        {
            int cn = 0;
            try
            {
                StreamReader sr = new StreamReader("shop.txt");
                int cnt = 0;
                string line = sr.ReadLine();
                while (line != null)
                {
                    cnt++; //counts how big the text file is to make the array a certian size
                    line = sr.ReadLine();
                }
                sr.Close();
                shop = new string[cnt, 3];
                StreamReader s = new StreamReader("shop.txt");
                string lin = s.ReadLine();
                while (lin != null)
                {
                    string[] temp = lin.Split(',');
                    shop[cn, 0] = temp[0]; //name
                    shop[cn, 1] = temp[1]; //quantitiy
                    shop[cn, 2] = temp[2];
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
        private void btnShow_Click(object sender, EventArgs e) //shows shop items
        {
            int cn = start();

            for (int i = 0; i <= cn - 1; i++)
            {
                // MessageBox.Show(batteries[i, 0]);
                string tt = shop[i, 0];
                lstShop.Items.Add(tt);
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnSubmit_Click(object sender, EventArgs e) //submits shop item
        {
            if (!(txtShopName.Text.Equals("")))
            {
                try
                {
                    int sub = Convert.ToInt32(txtQuan.Text);
                    bool found = false;
                    int cn = start();
                    for (int i = 0; i <= cn - 1; i++)
                    {

                        if (txtShopName.Text.Equals(shop[i, 0]))
                        {
                            MessageBox.Show("Found Name");
                            found = true;
                            int pos = i;


                            if ((Convert.ToInt32(shop[pos, 1]) - sub) >= 0)
                            {
                                int tot = Convert.ToInt32(shop[pos, 1]) - sub;
                                shop[pos, 1] = tot.ToString();
                                using (StreamWriter writer = File.CreateText("keys.txt"))
                                {
                                    for (int y = 0; y < cn; y++)
                                    {
                                        writer.WriteLine(shop[y, 0] + "," + shop[y, 1] + "," + shop[y, 2]);
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
                MessageBox.Show("You didnt insert a key name");
            }
               




        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnClear_Click(object sender, EventArgs e) //clears
        {
            txtShopName.Text = "";
            txtQuan.Text = "";
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnBack_Click(object sender, EventArgs e) //changes screen
        {
            this.Hide();
            frmMenu mn = new frmMenu();
            mn.Show();
        }

    }
}
