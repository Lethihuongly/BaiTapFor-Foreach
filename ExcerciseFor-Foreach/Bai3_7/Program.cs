// Tính tổng các số nguyên tố nhỏ hơn N
using System;

namespace TongSoNguyenTo
{
    class ChuongTrinh
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao mot so nguyen duong N:");
            int N;

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out N) && N > 1)
                {
                    break;
                }
                Console.WriteLine("Vui long nhap mot so nguyen duong lon hon 1:");
            }

            int tong = TinhTongSoNguyenToNhoHonN(N);

            Console.WriteLine("Tong cac so nguyen to nho hon " + N + " la: " + tong);
            Console.ReadLine();
        }

        public static int TinhTongSoNguyenToNhoHonN(int N)
        {
            int tong = 0;

            for (int i = 2; i < N; i++)
            {
                if (KiemTraSoNguyenTo(i))
                {
                    tong += i;
                }
            }

            return tong;
        }

        public static bool KiemTraSoNguyenTo(int n)
        {
            if (n <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}

