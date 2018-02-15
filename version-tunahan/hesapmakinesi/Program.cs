using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hesapmakinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            double sayi1, sayi2, sonuc;
            char islem;

            try
            {
                Console.Write("1. sayıyı giriniz :");
                sayi1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("2. sayıyı giriniz :");
                sayi2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("\nToplama(+), Çıkarma(-), Çarpma(*), Bölme(/), Mod Alma(%)\n");
                Console.Write("İşlemi giriniz :");
                islem = Convert.ToChar(Console.ReadLine());

                ///////////////

                if (islem == '+')
                {
                    sonuc = sayi1 + sayi2;
                    Console.WriteLine(sonuc);
                }

                else if (islem == '-')
                {
                    sonuc = sayi1 - sayi2;
                    Console.WriteLine(sonuc);
                }

                else if (islem == '*')
                {
                    sonuc = sayi1 * sayi2;
                    Console.WriteLine(sonuc);
                }

                else if (islem == '/')
                {
                    if (sayi2 != 0)
                    {
                        sonuc = sayi1 / sayi2;
                        Console.WriteLine(sonuc);
                    }
                    else
                        Console.WriteLine("Bölme işlemlerinde payda '0' olamaz!");
                }

                else if (islem == '%')
                {
                    sonuc = sayi1 % sayi2;
                    Console.WriteLine(sonuc);
                }
            }

            catch (Exception)
            {
                Console.WriteLine("Hatalı giriş!");
            }
        }
    }
}