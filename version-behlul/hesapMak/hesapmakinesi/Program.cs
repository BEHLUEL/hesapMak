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
            char kullaniciCevap = 'e';

            while (kullaniciCevap == 'e' || kullaniciCevap == 'E')
            {
                try
                {
                    Console.Write("işlemi giriniz : + , - , * , / :: ");
                    islem = Convert.ToChar(Console.ReadLine());


                    Console.Write("1. sayıyı giriniz :");
                    sayi1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("2. sayıyı giriniz :");
                    sayi2 = Convert.ToDouble(Console.ReadLine());






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

                    else
                    {
                        if (sayi2 != 0)
                        {
                            sonuc = sayi1 / sayi2;
                            Console.WriteLine(sonuc);
                        }
                        else
                            Console.WriteLine("bölme işlemlerinde payda '0' olamaz !!!");

                    }

                }
                catch (Exception)
                {

                    Console.WriteLine("hatalı giriş");
                }
                Console.WriteLine("Tekrar işlem yapmak ister misiniz (e/h)");
                kullaniciCevap = Convert.ToChar(Console.ReadLine());
            }

        }
    }
}