// Viết chương trình nhập vào M và N, xuất ra các hình sau: (dùng cấu trúc lặp)
//a.
/*
 
*
* *
* * *
* * * *
* * * * *
* * * * * *
* * * * * * *
b
* * * * * * *
* * * * * * *
* * * * * * *
* * * * * * *
* * * * * * *
* * * * * * *
* * * * * * *
c.
*
* * *
* * * * *
* * * * * * *
* * * * * * * * *
* * * * * * * * * * *
* * * * * * * * * * * * *
* * * * * * * * * * * * * * *
* * * * * * * * * * * * * * * * *
* * * * * * * * * * * * * * * * * * *
d.
*
* * *
* * * * *
* * * * * * *
* * * * * * * * *
* * * * * * * * * * *
* * * * * * * * * * * * *
* * * * * * * * * * * * * * *
* * * * * * * * * * * * * * * * *
* * * * * * * * * * * * * * * * * * *

*/
using System;

namespace XuatCacHinh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao M (so dong) va N (so cot) cua cac hinh:");
            int M, N;

            while (true)
            {
                Console.Write("Nhap M: ");
                if (int.TryParse(Console.ReadLine(), out M) && M > 0)
                {
                    break;
                }
                Console.WriteLine("Vui long nhap mot so nguyen duong.");
            }

            while (true)
            {
                Console.Write("Nhap N: ");
                if (int.TryParse(Console.ReadLine(), out N) && N > 0)
                {
                    break;
                }
                Console.WriteLine("Vui long nhap mot so nguyen duong.");
            }

            Console.WriteLine("\na. Hinh sao *:");
            XuatHinhA(M);

            Console.WriteLine("\nb. Hinh vuong sao *:");
            XuatHinhB(M, N);

            Console.WriteLine("\nc. Hinh tam giac sao *:");
            XuatHinhC(M);

            Console.WriteLine("\nd. Hinh tam giac vuong nguoc sao *:");
            XuatHinhD(M);

            Console.ReadLine();
        }

        // Xuất hình a. Hình sao *
        static void XuatHinhA(int M)
        {
            for (int i = 1; i <= M; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        // Xuất hình b. Hình vuông sao *
        static void XuatHinhB(int M, int N)
        {
            for (int i = 1; i <= M; i++)
            {
                for (int j = 1; j <= N; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        // Xuất hình c. Hình tam giác sao *
        static void XuatHinhC(int M)
        {
            for (int i = 1; i <= M; i++)
            {
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        // Xuất hình d. Hình tam giác vuông ngược sao *
        static void XuatHinhD(int M)
        {
            for (int i = M; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
