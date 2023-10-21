using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21Ekim
{
    internal class Metodlar
    {
        public double ToplamaIslemi(double s1,double s2)
        {
            double toplam = s1 + s2;
            return toplam;
        }

        public void ToplaVeyaz(double sayi1, double sayi2)
        {
            Console.WriteLine("Sayıların toplamı");
            Console.WriteLine("iki adet doubl değer toplandı");
            Console.WriteLine("Toplanan değerler {0} ve {1}",sayi1,sayi2);
            Console.WriteLine("Toplam = "+(sayi1+sayi2));
        }
    }
}
