// Viết chương trình in ra bội số của 3 từ 300 đến 3.
using System;
using System.Collections.Generic;

namespace Bai3_1
{
    class ChuongTrinh
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Cac boi so cua 3 su dung vong lap for:");

            for (int i = 300; i >= 3; i -= 3)
            {
                Console.WriteLine(i);
            }

            List<int> boiSoCuaBa = new List<int>();

            for (int i = 300; i >= 3; i -= 3)
            {
                boiSoCuaBa.Add(i);
            }

            Console.WriteLine("Cac boi so cua 3 su dung vong lap foreach:");
            foreach (int boiSo in boiSoCuaBa)
            {
                Console.WriteLine(boiSo);
            }

            Console.ReadLine();
        }
    }
}


