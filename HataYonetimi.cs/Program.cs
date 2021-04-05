using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HataYonetimi.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int s1, s2, sonuc;
                Console.Write("Sayıyı giriniz:");
                s1 = Convert.ToInt16(Console.ReadLine());
                Console.Write("Sayıyı giriniz:");
                s2 = Convert.ToInt16(Console.ReadLine());
                sonuc = s1 * s2;
                Console.WriteLine(sonuc);
                
            }
            catch(FormatException)
            {

                Console.WriteLine("Lütfen sadece sayısal değer giriniz.");
            }
            catch(OverflowException)
            {
                Console.WriteLine("Lütfen aralık içinde değer giriniz.");
            }
            
            

            Console.Read();





        }

    }
}
