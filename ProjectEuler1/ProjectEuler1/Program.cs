﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler1
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam=0;
            for (int i = 1; i < 1000; i++)
            {
                if ((i%3)==0||(i%5)==0)
                {
                    toplam += i;
                }
            }
            Console.WriteLine(toplam);
            Console.ReadLine();
        }
    }
}
