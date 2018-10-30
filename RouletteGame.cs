using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class RouletteGame
    {
       
        public int score, Spin_value;
        public static int r = 2;
        public static int shot = 0;

        public void try_again()
        {
            shot = 0;
        }

        public int Spin_Chamber()
        {
            Random rnd = new Random();
            Spin_value = rnd.Next(1,7);
            return Spin_value;
        }

        public int Fire_Bullet(int load, int Spin)
        {
          
                if (shot == 0 && load == Spin)
                {
                    shot = 3;
                    score =10;
                }
                else if (shot == 1 && load != Spin)
                {
                      score = 0;
                }

                else if (shot == 1 && load == Spin)
                {
                    shot = 3;
                    score = 5;
                }
               
                else
                {
                    shot++;
                    
                }
                
         
            // if (r == 0)
            // {
            //button4.Enabled = false;
            // }
            return score;
        }

       
    }
}
