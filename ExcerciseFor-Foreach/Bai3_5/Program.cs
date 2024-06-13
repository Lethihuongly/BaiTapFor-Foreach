// Viết chương trình tìm USCLN của 2 số nhập vào
using System;

namespace TimUSCLN
{
    class ChuongTrinh
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao so nguyen thu nhat:");
            int soThuNhat;

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out soThuNhat))
                {
                    break;
                }
                Console.WriteLine("Vui long nhap so nguyen hop le:");
            }

            Console.WriteLine("Nhap vao so nguyen thu hai:");
            int soThuHai;

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out soThuHai))
                {
                    break;
                }
                Console.WriteLine("Vui long nhap so nguyen hop le:");
            }

            int uscln = TimUSCLN(soThuNhat, soThuHai);

            Console.WriteLine("USCLN cua " + soThuNhat + " va " + soThuHai + " la: " + uscln);
            Console.ReadLine();
        }

        public static int TimUSCLN(int a, int b)
        {
            // Đảm bảo a và b là số dương
            a = Math.Abs(a);
            b = Math.Abs(b);

            // Tìm USCLN bằng cách sử dụng vòng lặp for
            int uscln = 1;
            int min = a < b ? a : b; // Lấy giá trị nhỏ hơn giữa a và b

            for (int i = 1; i <= min; i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    uscln = i;
                }
            }

            return uscln;
        }
    }
}

