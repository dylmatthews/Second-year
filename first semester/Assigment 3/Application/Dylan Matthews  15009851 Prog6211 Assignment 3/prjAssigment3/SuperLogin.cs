/* this is the super login
 * Dylan Matthews
 * 01/06/2016
 * 
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjAssigment3
{
   abstract class SuperLogin
    {
        protected string usr = "";

        public SuperLogin()
        {

        }

        

        public string User
        {
            get { return usr; } //returns user name
            set { usr = value; }
        }
        

    }
}
