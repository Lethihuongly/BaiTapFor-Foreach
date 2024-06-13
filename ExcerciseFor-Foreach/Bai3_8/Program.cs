// Tính tổng N số nguyên tố đầu tiên
using System;

namespace TongNSoNguyenToDauTien
{
    class ChuongTrinh
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao so luong N so nguyen to dau tien can tinh tong:");
            int N;

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out N) && N > 0)
                {
                    break;
                }
                Console.WriteLine("Vui long nhap mot so nguyen duong:");
            }

            int tong = TinhTongNSoNguyenToDauTien(N);

            Console.WriteLine("Tong cua " + N + " so nguyen to dau tien la: " + tong);
            Console.ReadLine();
        }

        public static int TinhTongNSoNguyenToDauTien(int N)
        {
            int tong = 0;
            int dem = 0;  // Đếm số lượng số nguyên tố đã tìm thấy
            int soHienTai = 2;  // Số hiện tại để kiểm tra nguyên tố

            while (dem < N)
            {
                if (KiemTraSoNguyenTo(soHienTai))
                {
                    tong += soHienTai;
                    dem++;
                }
                soHienTai++;
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

