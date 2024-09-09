using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary1;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Nhap gia tri ban kinh : ");
                string input = Console.ReadLine();

                if (double.TryParse(input, out double a))
                {
                    double chuvicau = Class1.chuvi(a);
                    double dientichcau = Class1.dientich(a);
                    double thetichcau = Class1.thetich(a);
                    Console.WriteLine("Chu vi hinh cau la: " + chuvicau);
                    Console.WriteLine("Dien tich hinh cau la: " + dientichcau);
                    Console.WriteLine("The tich hinh cau la: " + thetichcau);

                }
                else
                {
                    Console.WriteLine("Giá trị nhập vào không hợp lệ. Vui lòng nhập một số thực.");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
            Console.ReadLine();
        }
    }
}
