﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTOMAT
{
    class Program
    {
        static void Main(string[] args)
        {
            Algorithm A = new Algorithm();
            A.NFAToDFA();

            Console.ReadLine();
        }
    }
}
