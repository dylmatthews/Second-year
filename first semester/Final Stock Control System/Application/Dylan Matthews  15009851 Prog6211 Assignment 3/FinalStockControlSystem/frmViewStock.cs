/* this is the view stock screen
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

namespace FinalStockControlSystem
{
    public partial class frmViewStock : Form
    {
        public frmViewStock()
        {
            InitializeComponent();

        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnGetStock_Click(object sender, EventArgs e)
        {
            bat();//bateries method
            key();
            loc();
            rem();
            rep();
            sho();

        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public void sho()  //shop method
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
                if (shop[i, 0].Length > 8)
                {
                    txtShop.AppendText(shop[i, 0] + "\t" + shop[i, 1] + "\n");
                }
                else
                {
                    txtShop.AppendText(shop[i, 0] + "\t\t" + shop[i, 1] + "\n");
                }

            }

        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public void rep() //repairs method
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
                    cnt++; //counts to see how big array must be
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

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void rem() //remotes method
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
                    cnt++; //counts how big the text file is to make the array a certian size
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

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public void loc() //lock method
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
                    cnt++; //counts how big the text file is to make the array a certian size
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
            txtLocks.AppendText("Name\t\tStock\n");

           
            for (int i = 0; i <= cn - 1; i++)
            {
                if (l[i,0].Length>8)
                {
                    txtLocks.AppendText(l[i, 0] + "  \t" + l[i, 1] + "\n");
                }
                else
                {
                    txtLocks.AppendText(l[i, 0] + "\t\t" + l[i, 1] + "\n");
                }
               

            }


            
            
         
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public void key() //key method
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
                    cnt++; //counts how big the text file is to make the array a certian size
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

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public void bat() //battery method
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
                    cnt++; //counts how big the text file is to make the array a certian size
                    line = sr.ReadLine();
                }
                sr.Close();
                 batteries = new string[cnt, 3];
                   StreamReader s = new StreamReader("batteries.txt"); //opens text file
               string lin = s.ReadLine();
                while (lin != null)
                {
                    string[] temp = lin.Split(',');
                    batteries[cn, 0] = temp[0]; //name
                    batteries[cn, 1] = temp[1]; //quatitiy
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
                txtBat.AppendText(batteries[i, 0] + "\t" + batteries[i, 1] + "\n"); //writes to text box
                
            }


            
            
         
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void backToolStripMenuItem_Click(object sender, EventArgs e) //go back to prevoir screen
        {
            frmAdmin ad = new frmAdmin();
            this.Hide();
            ad.Show();
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void exitToolStripMenuItem_Click(object sender, EventArgs e) //exits program
        {
            Application.Exit();
        }

    }
}
