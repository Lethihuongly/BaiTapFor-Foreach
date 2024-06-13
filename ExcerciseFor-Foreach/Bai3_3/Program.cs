// Viết hàm tách chuỗi gốc thành chuỗi khác
//VD: chuỗi gốc S = “Bai Tap Mon Lap Trinh Python”, chuỗi sau khi tách là
//“Bai
//Tap
//Mon
//Lap
//Trinh
//Python”
using System;

namespace Bai3_3
{
    class ChuongTrinh
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao chuoi goc:");
            string chuoiGoc = Console.ReadLine();

            string chuoiDaTach = TachChuoi(chuoiGoc);

            Console.WriteLine("Chuoi sau khi tach la:");
            Console.WriteLine(chuoiDaTach);
            Console.ReadLine();
        }

        public static string TachChuoi(string s)
        {
            // Tách chuỗi thành các từ bằng cách sử dụng khoảng trắng làm dấu phân cách
            string[] tu = s.Split(' ');

            // Ghép các từ thành một chuỗi mới, mỗi từ trên một dòng mới
            string ketQua = string.Join(Environment.NewLine, tu);

            return ketQua;
        }
    }
}
