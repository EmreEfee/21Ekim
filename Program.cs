using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21Ekim
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //Class
            // Cleasslar OOP(Nesne Yönelimli Programlama)'nın en önemli yapı taşlarından biridir.
            //Class yapıları , gerçek dünya nesnelerini dijital dünyaya taşımamızı sağlayan , program içerisinide
            //bir masa veya öğrenci gibi nesneleri tanımladığımızda nasıl bilgiler barındırdığını bildiği bir yapıya sahiptir.
            // Field , Property, Method , Indexer vb. özellikleri barındırmaktadır.
            //Bu yapılar sayesinde sınıfımızı istediğimiz şekilde biçimlendiribiliri.
            //Class yapılarının içerisinde barınan tüm elemanların bir erişim düzenleyicisi olmak zorundadır.









            #endregion

            #region Field

            //Field lar 
            // Class içerisinde bir veri tipi , class veya koleksiyona bağlı olarak tanımlanandeğişkenlere denir.
            //Defaulr olarak erişim düzenleyicileri 'private' olarak tanımlanır

            //Başka bir class üzerinden bu değişkenlere erişilmek istenirse internal vaeya public olarak tanımlarız.

            #endregion
            /*
            Ogrenci o = new Ogrenci();

            o.Ad = "Ahmet";
            o.Soyad = "Veli";
            o.No = 456;
            o.Sınıf = 101;

            Ogrenci o2 = new Ogrenci();

            o2.Ad = "Ali";
            o2.Soyad = "Uysal";
            o2.No = 511;
            o2.Sınıf = 101;

            Console.WriteLine("Öğrencinin adı : "+o.Ad);
            Console.WriteLine("Öğrencinin soyad : "+o.Soyad);
            Console.WriteLine("Öğrencinin numarası : "+o.No);
            Console.WriteLine("Öğrencinin sınıfı: "+o.Sınıf);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Öğrencinin adı : " + o2.Ad);
            Console.WriteLine("Öğrencinin soyad : " + o2.Soyad);
            Console.WriteLine("Öğrencinin numarası : " + o2.No);
            Console.WriteLine("Öğrencinin sınıfı: " + o2.Sınıf);
            */




            // Bir ogrenci Class'ı oluşturalım. Ad, Sayoad,Not1, not2 bilgileri yer alsın
            //Öğrencinin bilgilerini kullanıcıdan isteyelim ve atama işlemlerini yapalım
            //Son olarak öğrencinin bilgilerini ve not ortalamasını ekrana yazdıralım

            /* benim yaptigim
             Ogrenci ogrenci = new Ogrenci();

             Console.WriteLine("Öğrencinin adı : ");
             ogrenci.Adi = Console.ReadLine();
             Console.WriteLine("Soyadi: ");
             ogrenci.Soyadi = Console.ReadLine();
             Console.WriteLine("İlk notu: ");
             ogrenci.not1 = int.Parse(Console.ReadLine());
             Console.WriteLine("İkinci notu: ");
             ogrenci.not2 = int.Parse(Console.ReadLine());

             double notortalamasi;
             notortalamasi = (double) (ogrenci.not1 + ogrenci.not2) / 2;
             Console.WriteLine("Ogrencinin adi: "+ogrenci.Adi);
             Console.WriteLine("Ogrencinin soyadi: "+ogrenci.Soyadi);
             Console.WriteLine("İlk notu: "+ogrenci.not1);
             Console.WriteLine("İkinci notu: "+ogrenci.not2);
             Console.WriteLine("Ogrencinin not ortalaması: "+notortalamasi);
             */

            /* HY
            Ogrenci x = new Ogrenci();
            Console.Write("Öğrencinin Adını Giriniz: ");
            x.Ad = Console.ReadLine();
            Console.Write("Öğrencinin Soyadını Giriniz: ");
            x.Soyad = Console.ReadLine();
            Console.Write("Öğrencinin 1. Notunu giriniz: ");
            x.N1 = int.Parse(Console.ReadLine());
            Console.Write("Öğrencinin 2. Notunu Giriniz: ");
            x.N2 = int.Parse(Console.ReadLine());

            x.ort = (double)(x.N1 + x.N2) / 2;

            Console.WriteLine("Öğrencinin Adı: "+x.Ad);
            Console.WriteLine("Öğrencinin Soyadı: " + x.Soyad);
            Console.WriteLine("Öğrencinin 1. Notu: " + x.N1);
            Console.WriteLine("Öğrencinin 2. Notu: " + x.N2);
            Console.WriteLine("Öğrencinin Not Ortalaması : " + x.ort);

            */


            // Araba Classı oluşturalım. Marka,Model, Km, PLaka, Yıl bilgileri olsun

            // Kullanıcıdan 2 adet farklı araba bilgilerini doldurmasını isteyelim

            // Son olarak aldığımız bilgileri ekrana yazdıralım.

            /*
            Araba ilkaraba = new Araba();
            Araba ikinciaraba = new Araba();

            Console.WriteLine("İlk arabanın markası: ");
            ilkaraba.Marka = Console.ReadLine();
            Console.WriteLine("İlk arabanın modeli: ");
            ilkaraba.Model = Console.ReadLine();
            Console.WriteLine(" İlk arabanın kmsi: ");
            ilkaraba.KM = int.Parse(Console.ReadLine());
            Console.WriteLine(" İlk arabanın plakası: ");
            ilkaraba.Plaka = Console.ReadLine();
            Console.WriteLine(" İlk arabanın yılı: ");
            ilkaraba.yil = int.Parse(Console.ReadLine());


            Console.WriteLine("İkinci arabanın markası: ");
            ikinciaraba.Marka = Console.ReadLine();
            Console.WriteLine("İkinci arabanın modeli: ");
            ikinciaraba.Model = Console.ReadLine();
            Console.WriteLine("İkinci arabanın kmsi: ");
            ikinciaraba.KM = int.Parse(Console.ReadLine());
            Console.WriteLine("İkinci arabanın plakası: ");
            ikinciaraba.Plaka = Console.ReadLine();
            Console.WriteLine("İkinci arabanın yılı: ");
            ikinciaraba.yil = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.Write("İlk arabanın markası: "+ilkaraba.Marka);
            Console.Write(" İlk arabanın modeli: " + ilkaraba.Model);
            Console.Write(" İlk arabanın kmsi: " + ilkaraba.KM);
            Console.Write(" İlk arabanın plakası: " + ilkaraba.Plaka);
            Console.WriteLine(" İlk arabanın yılı: " + ilkaraba.yil);

            Console.WriteLine("------------------------------------------------");

            Console.Write("İkinci arabanın markası: " + ikinciaraba.Marka);
            Console.Write(" İkinci arabanın modeli: " + ikinciaraba.Model);
            Console.Write(" İkinci arabanın kmsi: " + ikinciaraba.KM);
            Console.Write(" İkinci arabanın plakası: " + ikinciaraba.Plaka);
            Console.WriteLine(" İkinci arabanın yılı: " + ikinciaraba.yil);
            */
            /*
            Araba a1 = new Araba();

            Console.Write("Arabanın Markasını Giriniz: ");
            a1.Marka = Console.ReadLine();
            Console.Write("Arabanın Modelini Giriniz: ");
            a1.model = Console.ReadLine();
            Console.Write("Arabanın Plakasını Giriniz: ");
            a1.plaka = Console.ReadLine();
            Console.Write("Arabanın Kilometresini Giriniz: ");
            a1.km = int.Parse(Console.ReadLine());
            Console.Write("Arabanın Yılını Giriniz: ");
            a1.yıl = int.Parse(Console.ReadLine());

            Console.Clear();

            Araba a2 = new Araba();


            Console.Write("Arabanın Markasını Giriniz: ");
            a2.Marka = Console.ReadLine();
            Console.Write("Arabanın Modelini Giriniz: ");
            a2.model = Console.ReadLine();
            Console.Write("Arabanın Plakasını Giriniz: ");
            a2.plaka = Console.ReadLine();
            Console.Write("Arabanın Kilometresini Giriniz: ");
            a2.km = int.Parse(Console.ReadLine());
            Console.Write("Arabanın Yılını Giriniz: ");
            a2.yıl = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("--------------- 1. Arabanın Bilgileri ---------------");
            Console.WriteLine();
            Console.WriteLine("Arabanın Markası = "+a1.Marka);
            Console.WriteLine("Arabanın Modeli  = "+ a1.model);
            Console.WriteLine("Arabanın Plakası  = " + a1.plaka);
            Console.WriteLine("Arabanın KM'si  = " + a1.km);
            Console.WriteLine("Arabanın Yılı  = " + a1.yıl);
            Console.WriteLine();
            Console.WriteLine("Arabanın Markası = " + a2.Marka);
            Console.WriteLine("Arabanın Modeli  = " + a2.model);
            Console.WriteLine("Arabanın Plakası  = " + a2.plaka);
            Console.WriteLine("Arabanın KM'si  = " + a2.km);
            Console.WriteLine("Arabanın Yılı  = " + a2.yıl);
            */

            #region Metodlar

            // Metodlar (Fonksiyonlar)
            // Metodlar yapı itibari ile içerisinde bulunan kod bloklarını içerisinde istediğimiz yerde
            //çalıştırmamızı sağlayan yapılardır.
            //Programımız içerisinde aynı kod satırlarını birden fazla yerde uygulamak istersek
            // bu komut satırlarını bir paket haline getirebiliriz.Bu sayede program içerisinde kod yazma
            //hamallığından kurtulmuş oluruz.

            // Metodlar, Class(Sınıf) yapısı içerisinde yazılırlar ve diğer sınıflar ve metodlar içerisinde 
            //hiçbir engel olmaksızın kullanılabilirler.

            // Metod yazım kuralı 

            // <erişim düzenleyici><geri dönüş tipi><Metod Adı>(parametreler)
            //{
            //Komut satırları
            //Komut satırları
            //Komut satırları
            //}

            // Erişim düzenleyiciler

            //Erişim düzenleyicileri bir Class veya metod un başka bir proje veya başka bir sınıfı içerisinden
            //erişmemizi sağlayan yardımcı komutlardır.
            //Private = Belirtilen Class veya metodu gizli olarak tanımlar.Dışarıdan herhangi bir yapıdan erişim sağlanamaz.
            // sadece kendi yapısı içerisinde erişim sağlanabilir.

            //Public = Halka açık manasına gelir.Diğer sınıflar veya projeler içerisinden erişim sağlanabilir.

            // Internal = Diğer sınıflar içerisinden erişim sağlanabilir. Sadece başka projelerden erişim sağlanamaz.


            //Not: Bir sınıf veya bir metoda erişim düzenleyicisi yazılmadığı takdirde default olarak private kabul edilir.



            // Metodlarda geri dönüş tipleri.

            // Metodlar yapıları itibari ile çağrıldığında kensi içerisindeki kod bloklarını işleme alırlar.
            //Metodlardan bazı durumlarda geriye değer döndürülmesini isteyebiliriz.
            //Metod geriye bir değer döndürecek ise hangi türden değer döndürüyor ise o türü belirlememiz gerekir.
            //Metod içerisinde geriye dönecek olan komut satırlarının sonunda "return" komutu kullanırız.
            //Eğer bir değer döndürmesini istemiyor isek metodumuzu "vodi" olarak tanımlamamız gerekir.



            // Metodlarda parametreler

            // Metod içerisinde parametre tanımlamak zorunlu 'DEĞİLDİR'.
            // Eğer bir parametre alacak ise hangi türden değerler alıyor ise ;
            //(<tür><takmaAd>) şeklinde belirtmemiz gerekir.
            // Birden fazla parametre alması durumunda ,(virgül) ile diğer parametreleride yan yana ekleyebiliriz.

            #endregion

            Metodlar m = new Metodlar();
            Console.Write("Bir sayı giriniz: ");
            double sayi1 = int.Parse(Console.ReadLine());
            Console.Write("Bir sayı daha giriniz: ");
            double sayi2 = int.Parse(Console.ReadLine());

            // Console.WriteLine(m.ToplamaIslemi(sayi1,sayi2));
            // Console.WriteLine(m.ToplamaIslemi(5.4,6.3));
            m.ToplaVeyaz(sayi1, sayi2);


            Console.ReadKey();
        }
    }
}
