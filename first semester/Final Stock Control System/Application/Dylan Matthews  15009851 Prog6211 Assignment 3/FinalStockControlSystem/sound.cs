/* this is the sound
 * Dylan Matthews
 * 01/06/2016
 * 
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace FinalStockControlSystem
{
    class sound
    {
        SoundPlayer simpleSound= new SoundPlayer();

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public sound(string a) //summit by skrillex No Copy rights inteded :)
        {
            simpleSound = new SoundPlayer("07 Summit (feat. Ellie Goulding).wav");
            simpleSound.Play();
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public sound (int a) //bangarang by skrillex No Copy rights intended :)
        {           
            simpleSound = new SoundPlayer("02 Bangarang (feat. Sirah).wav");
            simpleSound.Play();
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public sound (double e) //stop music
        {
            simpleSound.Stop();
        }
    }

   
}
