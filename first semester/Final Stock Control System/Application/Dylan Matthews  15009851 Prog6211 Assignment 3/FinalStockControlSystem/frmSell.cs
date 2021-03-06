﻿/* This is the sell stock form for everything
 * I changed it from assigment 3 because there were to many forms
 * 14/06/16
 */
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

namespace FinalStockControlSystem
{
    public partial class frmSell : Form
    {
        string[,] batteries;
        string[,] keys;
        string[,] locks;
        string[,] remotes;
        string[,] repairs;
        string[,] shop;
        public frmSell()
        {
            InitializeComponent();
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public int startBatteries()
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
            }
            catch
            {

            }
            return cn;
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnShowBatteries_Click(object sender, EventArgs e)
        {
            int cn = startBatteries();
            lstBat.Items.Clear();
            for (int i = 0; i <= cn - 1; i++)
            {
                string tt = batteries[i, 0];
                lstBat.Items.Add(tt);
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnSubmitBatteries_Click(object sender, EventArgs e)
        {
            if (!(txtBatName.Text.Equals("")))
            {
                try
                {
                    int sub = Convert.ToInt32(txtBatQuan.Text);
                    bool found = false;
                    int cn = startBatteries();
                    for (int i = 0; i <= cn - 1; i++)
                    {

                        if (txtBatName.Text.Equals(batteries[i, 0]))
                        {
                            MessageBox.Show("Found Name");
                            found = true;
                            int pos = i;
                            
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
                                    clearBatteries();
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
                MessageBox.Show("You didnt insert a battery name");
            }

        }


        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btnClearBatteries_Click(object sender, EventArgs e)
        {
            clearBatteries();
        }
        public void clearBatteries()
        {
            txtBatName.Text = "";
            txtBatQuan.Text = "";
        }


        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        //keys section
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnShowKeys_Click(object sender, EventArgs e)
        {
            int cn = startKeys();
            lstKeys.Items.Clear();
            for (int i = 0; i <= cn - 1; i++)
            {

                string tt = keys[i, 0];
                lstKeys.Items.Add(tt);
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public int startKeys()
        {
            int cn = 0;
            try
            {

                StreamReader sr = new StreamReader("keys.txt");
                int cnt = 0;
                string line = sr.ReadLine();
                while (line != null)
                {
                    cnt++; //counts to see how big to make array
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

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnSubmitKey_Click(object sender, EventArgs e)
        {
            if (!(txtKeyName.Text.Equals("")))
            {
                try
                {
                    int sub = Convert.ToInt32(txtKeyQuan.Text);
                    bool found = false;
                    int cn = startKeys();
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
                                    clearKey();
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
        private void btnClearKey_Click(object sender, EventArgs e)
        {
            clearKey();
        }

        public void clearKey()
        {
            txtKeyName.Text = "";
            txtKeyQuan.Text = "";
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //Locks section

        public int startLocks()
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
        private void btnSubmitLocks_Click(object sender, EventArgs e)
        {
            if (!(txtLockName.Text.Equals("")))
            {
                try
                {
                    int sub = Convert.ToInt32(txtLockQuan.Text);
                    bool found = false;
                    int cn = startLocks();
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
                                    clearLocks();
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
        private void btnShowLocks_Click(object sender, EventArgs e)
        {
            int cn = startLocks();
            lstLocks.Items.Clear();
            for (int i = 0; i <= cn - 1; i++)
            {
                string tt = locks[i, 0];
                lstLocks.Items.Add(tt);
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnClearLocks_Click(object sender, EventArgs e)
        {
            clearLocks();
        }

        public void clearLocks()
        {
            txtLockName.Text = "";
            txtLockQuan.Text = "";
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //Remotes section
        public int startRemotes()
        {
            int cn = 0;
            try
            {

                StreamReader sr = new StreamReader("remotes.txt");
                int cnt = 0;
                string line = sr.ReadLine();
                while (line != null)
                {
                    cnt++; //counts to see how big to make array
                    line = sr.ReadLine();
                }
                sr.Close();
                remotes = new string[cnt, 3];
                StreamReader s = new StreamReader("remotes.txt");
                string lin = s.ReadLine();
                while (lin != null)
                {
                    string[] temp = lin.Split(',');
                    remotes[cn, 0] = temp[0];
                    remotes[cn, 1] = temp[1];
                    remotes[cn, 2] = temp[2];
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
        private void btnShowRemotes_Click(object sender, EventArgs e)
        {
            int cn = startRemotes();
            ltbRemotes.Items.Clear();

            for (int i = 0; i <= cn - 1; i++)
            {
                string tt = remotes[i, 0];
                ltbRemotes.Items.Add(tt);
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btnSubmitRemotes_Click(object sender, EventArgs e)
        {
            if (!(txtRemoteName.Text.Equals("")))
            {
                try
                {
                    int sub = Convert.ToInt32(txtRemoteQuan.Text);
                    bool found = false;
                    int cn = startRemotes();
                    for (int i = 0; i <= cn - 1; i++)
                    {

                        if (txtRemoteName.Text.Equals(remotes[i, 0]))
                        {
                            MessageBox.Show("Found Name");
                            found = true;
                            int pos = i;


                            if ((Convert.ToInt32(remotes[pos, 1]) - sub) >= 0)
                            {
                                int tot = Convert.ToInt32(remotes[pos, 1]) - sub;
                                remotes[pos, 1] = tot.ToString();
                                using (StreamWriter writer = File.CreateText("remotes.txt"))
                                {
                                    for (int y = 0; y < cn; y++)
                                    {
                                        writer.WriteLine(remotes[y, 0] + "," + remotes[y, 1] + "," + remotes[y, 2]);
                                    }
                                    writer.Close();
                                    clearRemotes();
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
                MessageBox.Show("You didnt insert a remote name");
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
 
        private void btnClearRemotes_Click(object sender, EventArgs e)
        {
            clearRemotes(); 
        }
        public void clearRemotes()
        {
            txtRemoteName.Text = "";
            txtRemoteQuan.Text = "";
        }
              

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        //Repairs section
        public int startRepairs()
        {
            int cn = 0;
            try
            {

                StreamReader sr = new StreamReader("repairs.txt");
                int cnt = 0;
                string line = sr.ReadLine();
                while (line != null)
                {
                    cnt++; //counts to see how biug to make array
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

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnShowRepairs_Click(object sender, EventArgs e)
        {
            int cn = startRepairs();
            lstRepairs.Items.Clear();

            for (int i = 0; i <= cn - 1; i++)
            {
                // MessageBox.Show(batteries[i, 0]);
                string tt = repairs[i, 0];
                lstRepairs.Items.Add(tt);
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnSubmitRepairs_Click(object sender, EventArgs e)
        {
            if (!(txtRepairName.Text.Equals("")))
            {
                try
                {
                    int sub = Convert.ToInt32(txtRepairsQuan.Text);
                    bool found = false;
                    int cn = startRepairs();
                    for (int i = 0; i <= cn - 1; i++)
                    {

                        if (txtRepairName.Text.Equals(repairs[i, 0]))
                        {
                            MessageBox.Show("Found Name");
                            found = true;
                            int pos = i;

                            if ((Convert.ToInt32(repairs[pos, 1]) - sub) >= 0)
                            {
                                int tot = Convert.ToInt32(repairs[pos, 1]) - sub;
                                repairs[pos, 1] = tot.ToString();
                                using (StreamWriter writer = File.CreateText("repairs.txt"))
                                {
                                    for (int y = 0; y < cn; y++)
                                    {
                                        writer.WriteLine(repairs[y, 0] + "," + repairs[y, 1] + "," + repairs[y, 2]);
                                    }
                                    writer.Close();
                                    clearRepairs();
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

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnClearRepairs_Click(object sender, EventArgs e)
        {
            clearRepairs();
        }

        public void clearRepairs()
        {
            txtRepairName.Text = "";
            txtRepairsQuan.Text = "";
        }
        
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //Shop Section

        public int startShop()
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

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btnShowShop_Click(object sender, EventArgs e)
        {
            int cn = startShop();
            lstShop.Items.Clear();

            for (int i = 0; i <= cn - 1; i++)
            {
                string tt = shop[i, 0];
                lstShop.Items.Add(tt);
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnShopSubmit_Click(object sender, EventArgs e)
        {
            if (!(txtShopName.Text.Equals("")))
            {
                try
                {
                    int sub = Convert.ToInt32(txtShopQuan.Text);
                    bool found = false;
                    int cn = startShop();
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
                                using (StreamWriter writer = File.CreateText("shop.txt"))
                                {
                                    for (int y = 0; y < cn; y++)
                                    {
                                        writer.WriteLine(shop[y, 0] + "," + shop[y, 1] + "," + shop[y, 2]);
                                    }
                                    writer.Close();
                                    clearShop();
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
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btnShopClear_Click(object sender, EventArgs e)
        {
            clearShop();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public void clearShop()
        {
            txtShopName.Text = "";
            txtShopQuan.Text = "";
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        private void backToLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin log = new frmLogin();
            this.Hide();
            log.Show();
        }
    }
}
