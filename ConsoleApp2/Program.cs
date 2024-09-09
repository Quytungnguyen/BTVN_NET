using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
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
                    if (a <= 0)
                    {
                        Console.WriteLine("chieu dai phai lon hon 0.");
                        return;
                    }

                    double chuvi = a *2 * Math.PI;
                    double dientich = 4 * Math.PI * a * a;
                    double thetich = (Math.PI * Math.Pow(a, 3) * 4 / 3);
                    Console.WriteLine("dien tich : " + chuvi);
                    Console.WriteLine("chu vi: " + dientich);
                    Console.WriteLine("the tich: " + thetich);
                }
                else
                {
                    Console.WriteLine("Gia tri khong hop le !.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
            Console.ReadLine();
        }
    }
}
