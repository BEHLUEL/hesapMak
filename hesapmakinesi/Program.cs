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

                Console.Write("işlemi giriniz :");
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
                        Console.WriteLine("bölme işlemlerinde payda '0' olamaz !!!");

                }
		else if (islem == '^')
		{
		    sonuc = 1;
		    for (int i = 0; i < sayi2; i++)
			    sonuc *= sayi1;

		    Console.WriteLine(sonuc);
		}
            }
            catch (Exception)
            {

                Console.WriteLine("hatalı giriş");
            }


            //if (islem == '+')
            //{
            //    sonuc = sayi1 + sayi2;
            //    Console.WriteLine("%d", sonuc);
            //}

            //else if (islem == '-')
            //{
            //    sonuc = sayi1 - sayi2;
            //    Console.WriteLine("%d", sonuc);
            //}

            //else if (islem == '*')
            //{
            //    sonuc = sayi1 * sayi2;
            //    Console.WriteLine("%d", sonuc);
            //}

            //else if (islem == '/')
            //{
            //    try
            //    {
            //        sonuc = sayi1 / sayi2;
            //        Console.WriteLine("%d", sonuc);
            //    }
            //    catch (Exception)
            //    {

            //        Console.WriteLine("hatalı giriş");
            //    }

            //}
        }
    }
}
