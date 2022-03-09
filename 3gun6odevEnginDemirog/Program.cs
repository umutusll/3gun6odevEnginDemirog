using System;

namespace _3gun6odevEnginDemirog
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.UrunAdi = "Samsung Telefon";
            urun1.UrunTuru = "Elektronik ihtiyaç";
            urun1.Fiyati = 5600;

            Product urun2 = new Product();
            urun2.UrunAdi = "Under Armour Eşofman Altı";
            urun2.UrunTuru = "Giyim";
            urun2.Fiyati = 560;

            Product urun3 = new Product();
            urun3.UrunAdi = "RTX 3060 Tİ";
            urun3.UrunTuru = "Bilgisayar donanımı";
            urun3.Fiyati = 6200;

            Product urun4 = new Product();
            urun4.UrunAdi = "Apple tablet";
            urun4.UrunTuru = "Elektronik ihtiyaç";
            urun4.Fiyati = 7800;

            Product urun5 = new Product();
            urun5.UrunAdi = "Cem Karaca Kaset";
            urun5.UrunTuru = "Muzik";
            urun5.Fiyati = 265;


            //for döngüsü başladı
            Product[] urunler = new Product[] { urun1, urun2, urun3, urun4, urun5 };
            //for (int i = 0; i < urunler.Length; i++)
            //{
            //    Console.WriteLine("Ürün Adı:" + urunler[i].UrunAdi +" ---- "+"Ürün Türü:"+ urunler[i].UrunTuru + "----" +"Ürün Fiyatı;"+urunler[i].Fiyati);
            //}
            //foreach döngüsü başladı 
            //foreach(var urun in urunler)
            //{
            //    Console.WriteLine(urun.UrunAdi + "    " + urun.UrunTuru + "    " + urun.Fiyati);
            //}
            //int j = 0;
            //while (j<urunler.Length)
            //{
            //    Console.WriteLine(urunler[j].UrunAdi+"      "+ urunler[j].UrunTuru+"      "+ urunler[j].Fiyati);
            //    j++;
            //}
        }
    }
}
