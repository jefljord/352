using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    public class redShade : absFact
    {
        public int shader() // creates one random int. Will need to be converted to bytes
        {
            Random rnd = new Random();
            Random rand = new Random();
            int x = rnd.Next(80, 195);
            int y;
            if (x < 100)
            {
                y = rand.Next(0, 30);
                x = x + y;
            }
            if (x > 100 && x < 200)
            {
                y = rand.Next(24, 49);
                x = x + y;
            }
            if (x > 200)
            {
                y = rand.Next(0, 100);
                x = x - y;
            }

            return x;
        }
    }
}