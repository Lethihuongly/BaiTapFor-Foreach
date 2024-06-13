// Viết chương trình kiểm tra số nhập vào có phải là số nguyên tố hay không
using System;

namespace KiemTraSoNguyenTo
{
    class ChuongTrinh
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao mot so nguyen:");
            int soNguyen;

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out soNguyen))
                {
                    break;
                }
                Console.WriteLine("Vui long nhap so nguyen hop le:");
            }

            bool laSoNguyenTo = KiemTraSoNguyenTo(soNguyen);

            if (laSoNguyenTo)
            {
                Console.WriteLine(soNguyen + " la so nguyen to.");
            }
            else
            {
                Console.WriteLine(soNguyen + " khong phai la so nguyen to.");
            }

            Console.ReadLine();
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
