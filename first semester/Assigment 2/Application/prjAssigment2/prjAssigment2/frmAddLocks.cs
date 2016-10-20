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
    public partial class frmAddLocks : Form
    {
        string[,] locks;
        public frmAddLocks()
        {
            InitializeComponent();
        }

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
                    cnt++;
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

        private void btnShow_Click(object sender, EventArgs e)
        {
            int cn = start();

            for (int i = 0; i <= cn - 1; i++)
            {
                string tt = locks[i, 0];
                lstLocks.Items.Add(tt);
            }
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!(txtLockName.Text.Equals("")))
            {
                try
                {
                    int add = Convert.ToInt32(txtQuan.Text);
                    bool found = false;
                    int cn = start();
                    for (int i = 0; i <= cn - 1; i++)
                    {

                        if (txtLockName.Text.Equals(locks[i, 0]))
                        {
                            MessageBox.Show("Found Name");
                            found = true;
                            int pos = i;


                            if (add > 0)
                            {
                                int tot = Convert.ToInt32(locks[pos, 1]) + add;
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLockName.Text = "";
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
