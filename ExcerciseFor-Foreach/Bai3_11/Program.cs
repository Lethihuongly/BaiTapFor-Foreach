/*
Một người có 100 triệu VND và quyết định gửi tiết kiệm. Người đó gửi theo kỳ hạn từng 
6 tháng một, kết thúc kỳ hạn số tiền lãi được chuyển nhập vào gốc để gửi cho kỳ hạn tiếp. 
Lãi suất cho một kỳ hạn là 3%. Viết chương trình để in ra số tiền của người đó sau các kỳ
hạn từ 1 đến 10
*/
using System;

namespace TinhTienGuiTietKiem
{
    class Program
    {
        static void Main(string[] args)
        {
            const double laiSuat = 0.03; // Lãi suất 3% cho mỗi kỳ hạn
            double soTienGoc = 100000000; // Số tiền gốc ban đầu là 100 triệu VND

            Console.WriteLine("So tien sau cac ky han gui tiet kiem:");
            for (int kyHan = 1; kyHan <= 10; kyHan++)
            {
                // Tính số tiền lãi nhận được
                double tienLai = soTienGoc * laiSuat;

                // Cộng số tiền lãi vào số tiền gốc
                soTienGoc += tienLai;

                // In ra số tiền sau mỗi kỳ hạn
                Console.WriteLine($"Ky han {kyHan}: {soTienGoc:N0} VND");

                // Số tiền gốc cho kỳ hạn tiếp theo là số tiền gốc hiện tại
            }

            Console.ReadLine();
        }
    }
}

