using System;
namespace OkulYonetimUygulamasi_G024
{
    public class Araclar
    {
        public static int SayiAl(string mesaj)
        {
            int result;
            while (true)
            {
                Console.Write(mesaj);
                if (!int.TryParse(Console.ReadLine(), out result) || result < 0)
                    Console.WriteLine("Hatali giris yapildi. Tekrar deneyin");
                else
                    break;
            }
            return result;
        }
        public static string SecimAl(string text)
        {
            
            Console.Write(text);
            string giris = Console.ReadLine();
            Console.WriteLine();
            return giris;
        }
        public static string StringMi(string mesaj)
        {
            string str1 = "";
            bool flag = true;
            int num = 1;
            while (flag)
            {
                Console.Write(mesaj);
                str1 = IlkHarfBuyut(Console.ReadLine());
                string str2 = "1234567890!^+-*/?*.,#%&:;()={}[]-_\"<>'\\~@|";
                foreach (char ch in str1)
                {
                    if (str2.Contains(ch))
                    {
                        Console.WriteLine("Hatalı işlem tekrar girin.");
                        break;
                    }
                    if (str1.Length == num)
                    {
                        flag = false;
                        break;
                    }
                    ++num;
                }
            }
            return str1;
        }
        public static string IlkHarfBuyut(string veri)
        {
            if (veri.Length > 0)
            {
                veri = veri.Substring(0, 1).ToUpper() + veri.Substring(1).ToLower();
                return veri;
            }
            return veri;
            
        }
        public static DateTime TarihAl(string mesaj)
        {
            DateTime result;
            while (true)
            {
                Console.Write(mesaj);
                if (!DateTime.TryParse(Console.ReadLine(), out result))
                    Console.WriteLine("Hatali giris yapildi. Tekrar deneyin");
                else
                    break;
            }
            return result;
        }
        public static CINSIYET CinsiyetBul(string veri)
        {
            CINSIYET cinsiyet = CINSIYET.Empty;
            if (veri.ToUpper() == "K")
                cinsiyet = CINSIYET.Kiz;
            else if (veri.ToUpper() == "E")
                cinsiyet = CINSIYET.Erkek;
            return cinsiyet;
        }
        public static SUBE SubeBul(string veri)
        {
            SUBE sube = SUBE.Empty;
            if (veri.ToUpper() == "A")
            {
                sube = SUBE.A;
            }
            else if (veri.ToUpper() == "B")
            {
                sube = SUBE.B;
            }
            else if (veri.ToUpper() == "C")
            {
                sube = SUBE.C;
            }
            return sube;
        }
       
    }
}
