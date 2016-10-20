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
    public partial class frmSellKeys : Form
    {
        string[,] keys;
        public frmSellKeys()
        {
            InitializeComponent();
        }

        public int start()
        {
            int cn = 0;
            try
            {

                StreamReader sr = new StreamReader("keys.txt");
                int cnt = 0;
                string line = sr.ReadLine();
                while (line != null)
                {
                    cnt++;
                    line = sr.ReadLine();
                }
                sr.Close();
                keys = new string[cnt, 3];
                StreamReader s = new StreamReader("keys.txt");
                string lin = s.ReadLine();
                while (lin != null)
                {
                    string[] temp = lin.Split(',');
                    keys[cn, 0] = temp[0];
                    keys[cn, 1] = temp[1];
                    keys[cn, 2] = temp[2];
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
                
                string tt = keys[i, 0];
                lstKeys.Items.Add(tt);
            }
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!(txtKeyName.Text.Equals("")))
            {
                try
                {
                    int sub = Convert.ToInt32(txtQuan.Text);
                    bool found = false;
                    int cn = start();
                    for (int i = 0; i <= cn - 1; i++)
                    {

                        if (txtKeyName.Text.Equals(keys[i, 0]))
                        {
                            MessageBox.Show("Found Name");
                            found = true;
                            int pos = i;


                            if ((Convert.ToInt32(keys[pos, 1]) - sub) >= 0)
                            {
                                int tot = Convert.ToInt32(keys[pos, 1]) - sub;
                                keys[pos, 1] = tot.ToString();
                                using (StreamWriter writer = File.CreateText("keys.txt"))
                                {
                                    for (int y = 0; y < cn; y++)
                                    {
                                        writer.WriteLine(keys[y, 0] + "," + keys[y, 1] + "," + keys[y, 2]);
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu mn = new frmMenu();
            mn.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtKeyName.Text = "";
            txtQuan.Text = "";
        }
    }
}
