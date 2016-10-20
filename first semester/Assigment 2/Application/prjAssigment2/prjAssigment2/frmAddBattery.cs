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

namespace prjAssigment2
{
    public partial class frmAddBattery : Form
    {
        string[,] batteries;
        public frmAddBattery()
        {
            InitializeComponent();
        }


        public int start()
        {
            int cn = 0;
            try
            {

                StreamReader sr = new StreamReader("batteries.txt");
                int cnt = 0;
                string line = sr.ReadLine();
                while (line != null)
                {
                    cnt++;
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
            }
            catch
            {

            }
            return cn;
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            int cn = start();

            for (int i = 0; i <= cn - 1; i++)
            {
                string tt = batteries[i, 0];
                lstBat.Items.Add(tt);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!(txtBatName.Text.Equals("")))
            {
                try
                {
                    int add = Convert.ToInt32(txtQuan.Text);
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


                            if (add >0)
                            {
                                int tot = Convert.ToInt32(batteries[pos, 1]) + add;
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
                MessageBox.Show("You didnt insert a battery name");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBatName.Text = "";
            txtQuan.Text = "";
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdmin ad = new frmAdmin();
            ad.Show();
        }
    }
}
