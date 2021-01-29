using System;

namespace GelecegiYazanlarUnity
{
    class Program
    {
        static void Main(string[] args)
        {
            //Konsola yazı yazdırmak için:
            Console.WriteLine("Hello World!");

            //integer türünde değişken tanımlamak için:
            int oyuncuPuani = 100;
            Console.WriteLine(oyuncuPuani);
            int myAge = 27;
            Console.WriteLine(myAge);

            //string tanımlamak:
            string oyuncuAdi = "Player 1";
            Console.WriteLine(oyuncuAdi);
            string myName = "Meyra";
            Console.WriteLine(myName);

            //sabit değişken tanımlamak:
            const int maxHiz = 200;
            Console.WriteLine(maxHiz);

            //integer toplama
            int kazanilanPuan = 20;
            Console.WriteLine(oyuncuPuani + kazanilanPuan); //veya ;
            int finalPuan = oyuncuPuani + kazanilanPuan;
            Console.WriteLine(finalPuan); //veya;
            oyuncuPuani = oyuncuPuani + kazanilanPuan; //bunun kısa yolu = oyuncuPuani += kazanilanPuan 
            Console.WriteLine(oyuncuPuani);

            //integer çıkarma 
            int kaybedilenPuan = 30; 
            oyuncuPuani -= kaybedilenPuan;
            Console.WriteLine(oyuncuPuani);
            //bunları böyle uzun uzun tanımlayıp formüle edip işlem yapmak yerine sadece oyuncuPuani -=30; yazmak yeterli olur.

            //integer çarpma
            oyuncuPuani *= 3;
            Console.WriteLine(oyuncuPuani);

            //integer bölme
            oyuncuPuani /= 9;
            Console.WriteLine(oyuncuPuani);

            //string toplama işlemi
            Console.WriteLine("Player Name:  " + myName +"  " + "Player Score : " + oyuncuPuani );


            //Sabitlerde işlemler
            //maxHiz += 100; //hata verir, çünkü constant değiştirilemez.


            //ÖDEV
            int yearOfBirth = 1993;
            int currentYear = 2021;
            int myAge1 = currentYear -= yearOfBirth;
            Console.WriteLine("My age is: " + myAge1);

            +

            //dik üçgenin alanını hesaplayan formül
            int C = 23;
            int b = 21;
            float alan = C * b / 2f;
            Console.WriteLine(alan);



            // Toplam oynama süresi (saniye)
            int toplamSn = 750;
            Console.WriteLine("toplam saniye: " + toplamSn);

            // Toplam oynama süresi (dakika)
            float toplamDk = toplamSn / 60f;
            Console.WriteLine("toplam dakika: " + toplamDk);

            //Hesaplanan saniye
            float hesaplananSn = toplamDk * 60f;
            Console.WriteLine("hesaplanan saniye:" + hesaplananSn);

           
        }
    }
}
