﻿/*
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
            Random rand = new Random();
            int x = rnd.Next(45, 225);
            int y;
            if (x < 100)
            {
                y = rand.Next(0, 75);
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
