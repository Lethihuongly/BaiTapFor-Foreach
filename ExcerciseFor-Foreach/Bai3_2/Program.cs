// Viết hàm để đếm số lượng ký tự là số có trong chuỗi s. Chuỗi s được nhập từ bàn
// phím.Dùng mã ASCII để kiểm tra ký tự có phải là số hay không
using System;

namespace Bai3_2
{
    class ChuongTrinh
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao mot chuoi:");
            string s = Console.ReadLine();

            int soLuongKyTuSo = DemKyTuSo(s);

            Console.WriteLine("So luong ky tu la so trong chuoi la: " + soLuongKyTuSo);
            Console.ReadLine();
        }

        public static int DemKyTuSo(string s)
        {
            int count = 0;

            foreach (char c in s)
            {
                if (c >= '0' && c <= '9') // Kiểm tra ký tự có phải là số không bằng mã ASCII
                {
                    count++;
                }
            }

            return count;
        }
    }
}
