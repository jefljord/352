/*
 * Author: Jeffrey Jordan
 * Date: 10/3/2019
 * File: randShade.cs
 * Description: The file holding the function that generates the numbers that change the shade. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    public class randShade : absFact
    {
        public int shader() // creates one random int. Will need to be converted to bytes
        {
            Random rnd = new Random();
            int x = rnd.Next(0, 255);
            
            return x;
        }
    }
}
