﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace IsNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            if (input >= 100 && input <= 200 || input == 0)
            {
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
