/* this is the child login
 * Dylan Matthews
 * 01/06/2016
 * 
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalStockControlSystem
{
    sealed class ChildLogin : SuperLogin //sealed class
    {
        private string psw = "";
        private string status = "";

        public ChildLogin() //defaults constructor
        {

        }
        public ChildLogin(string us, string ps, string st) //constructor
        {
            psw = ps;
            usr = us;
            status = st;
        }

        public string password
        {
            get { return psw; } //returns password
            set { psw = value; }
        }



        public string Status
        {
            get { return status; } //returns employee status
            set { status = value;}
        }
        
        public sealed override string ToString() //sealed class polymorphism
        {
            return base.ToString() + User + password;
        }
        

    }

    
}
