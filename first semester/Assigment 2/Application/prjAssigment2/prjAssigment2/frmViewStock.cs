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
    public partial class frmViewStock : Form
    {
        public frmViewStock()
        {
            InitializeComponent();

        }

        private void btnGetStock_Click(object sender, EventArgs e)
        {
            bat();
            key();
            loc();
            rem();
            rep();
            sho();

        }

        public void sho()
        {
            string[,] shop = new string[0, 0];
            int cn = 0;
            try
            {


                StreamReader sr = new StreamReader("shop.txt");
                int cnt = 0;
                string line = sr.ReadLine();
                while (line != null)
                {
                    cnt++;
                    line = sr.ReadLine();
                }
                sr.Close();
                shop = new string[cnt, 3];
                StreamReader s = new StreamReader("shop.txt");
                string lin = s.ReadLine();
                while (lin != null)
                {
                    string[] temp = lin.Split(',');
                    shop[cn, 0] = temp[0];
                    shop[cn, 1] = temp[1];
                    shop[cn, 2] = temp[2];
                    lin = s.ReadLine();
                    cn++;

                }
                s.Close();
            }
            catch
            {

            }
            txtShop.Clear();
            txtShop.AppendText("Name\t\tStock\n");

           
            for (int i = 0; i <= cn - 1; i++)
            {
                txtShop.AppendText(shop[i, 0] + "\t\t" + shop[i, 1] + "\n");

            }

        }

        public void rep()
        {
            string[,] re = new string[0, 0];
            int cn = 0;
            try
            {


                StreamReader sr = new StreamReader("repairs.txt");
                int cnt = 0;
                string line = sr.ReadLine();
                while (line != null)
                {
                    cnt++;
                    line = sr.ReadLine();
                }
                sr.Close();
                re = new string[cnt, 3];
                StreamReader s = new StreamReader("repairs.txt");
                string lin = s.ReadLine();
                while (lin != null)
                {
                    string[] temp = lin.Split(',');
                    re[cn, 0] = temp[0];
                    re[cn, 1] = temp[1];
                    re[cn, 2] = temp[2];
                    lin = s.ReadLine();
                    cn++;

                }
                s.Close();
            }
            catch
            {

            }
            txtRepairs.Clear();
            txtRepairs.AppendText("Name\tStock\n");

            
            for (int i = 0; i <= cn - 1; i++)
            {
                txtRepairs.AppendText(re[i, 0] + "\t" + re[i, 1] + "\n");

            }

        }

        public void rem()
        {
            string[,] rem = new string[0, 0];
            int cn = 0;
            try
            {


                StreamReader sr = new StreamReader("remotes.txt");
                int cnt = 0;
                string line = sr.ReadLine();
                while (line != null)
                {
                    cnt++;
                    line = sr.ReadLine();
                }
                sr.Close();
                rem= new string[cnt, 3];
                StreamReader s = new StreamReader("remotes.txt");
                string lin = s.ReadLine();
                while (lin != null)
                {
                    string[] temp = lin.Split(',');
                    rem[cn, 0] = temp[0];
                    rem[cn, 1] = temp[1];
                    rem[cn, 2] = temp[2];
                    lin = s.ReadLine();
                    cn++;

                }
                s.Close();
            }
            catch
            {

            }
            txtRemotes.Clear();
            txtRemotes.AppendText("Name\tStock\n");

            
            for (int i = 0; i <= cn - 1; i++)
            {
                txtRemotes.AppendText(rem[i, 0] + "\t" + rem[i, 1] + "\n");

            }
        }

        public void loc()
        {
            string[,] l = new string[0, 0];
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
                l = new string[cnt, 3];
                StreamReader s = new StreamReader("locks.txt");
                string lin = s.ReadLine();
                while (lin != null)
                {
                    string[] temp = lin.Split(',');
                    l[cn, 0] = temp[0];
                    l[cn, 1] = temp[1];
                    l[cn, 2] = temp[2];
                    lin = s.ReadLine();
                    cn++;

                }
                s.Close();
            }
            catch
            {

            }
            txtLocks.Clear();
            txtLocks.AppendText("Name\tStock\n");

           
            for (int i = 0; i <= cn - 1; i++)
            {
                txtLocks.AppendText(l[i, 0] + "\t\t" + l[i, 1] + "\n");

            }


            
            
         
        }

        public void key()
        {
              string[,] keys = new string[0,0] ;
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
             }catch 
             {

             }
             txtKeys.Clear();
            txtKeys.AppendText("Name\tStock\n");
             
            
            for (int i=0;i <= cn-1;i++)
            {
                txtKeys.AppendText(keys[i, 0] + "\t" + keys[i, 1] + "\n");
                
            }


            
            
         
        }
    
        
        public void bat()
        {
            string[,] batteries = new string[0,0] ;
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
             }catch 
             {

             }
             txtBat.Clear();
            txtBat.AppendText("Name\tStock\n");
             
            
            for (int i=0;i <= cn-1;i++)
            {
                txtBat.AppendText(batteries[i, 0] + "\t" + batteries[i, 1] + "\n");
                
            }


            
            
         
        }

        private void txtShop_TextChanged(object sender, EventArgs e)
        {

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdmin ad = new frmAdmin();
            this.Hide();
            ad.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }




    }
}
