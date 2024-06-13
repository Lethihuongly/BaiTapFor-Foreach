// Viết chương trình tính tổng N số nguyên.
using System;

namespace TongNSoNguyen
{
    class ChuongTrinh
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao so luong N so nguyen can tinh tong:");
            int N;

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out N) && N > 0)
                {
                    break;
                }
                Console.WriteLine("Vui long nhap mot so nguyen duong:");
            }

            int tong = TinhTongNSoNguyen(N);

            Console.WriteLine("Tong cua " + N + " so nguyen la: " + tong);
            Console.ReadLine();
        }

        public static int TinhTongNSoNguyen(int N)
        {
            int tong = 0;

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("Nhap vao so nguyen thu " + i + ":");
                int soNguyen;

                while (true)
                {
                    if (int.TryParse(Console.ReadLine(), out soNguyen))
                    {
                        break;
                    }
                    Console.WriteLine("Vui long nhap mot so nguyen hop le:");
                }

                tong += soNguyen;
            }

            return tong;
        }
    }
}

