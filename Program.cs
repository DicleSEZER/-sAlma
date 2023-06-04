using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace üsAlma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen birinci sayıyı giriniz :");
            double sayi =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen ikinci sayıyı giriniz :");
            double sayi2 =Convert.ToInt32(Console.ReadLine());


            double  sonuc = 1;
            for(int i = 1;i<=sayi2;i++)
            {
                sonuc *= sayi;

            }

            Console.WriteLine("Sonuç :"+sonuc);
            Console.ReadLine(); 
           
        }
    }
}
