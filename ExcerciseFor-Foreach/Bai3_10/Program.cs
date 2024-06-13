// Viết chương trình in ra bảng cửu chương.
using System;

namespace BangCuuChuong
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bang cuu chuong:");

            // Duyệt từ 1 đến 10 để in bảng cửu chương
            for (int i = 1; i <= 10; i++)
            {
                // Duyệt từ 1 đến 10 để in từng dòng của bảng cửu chương
                for (int j = 1; j <= 10; j++)
                {
                    // In phép nhân i * j và định dạng lại để cân đối cột
                    Console.Write($"{i} x {j} = {i * j}\t");
                }
                Console.WriteLine(); // Xuống dòng sau khi in xong một dòng bảng cửu chương
            }

            Console.ReadLine();
        }
    }
}
