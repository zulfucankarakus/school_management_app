using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYonetimUygulamasi_G024
{
    class Okul
    {

        public List<Ogrenci> Ogrenciler = new List<Ogrenci>();
        public void NotEkle(int no, string dersAdi, int not)
        {
            Ogrenci o = this.Ogrenciler.Where(a => a.No == no).FirstOrDefault();

            if (o != null)
            {
                DersNotu dn = new DersNotu(dersAdi,not);                
                o.Notlar.Add(dn);
            }
            else
            {
                Console.WriteLine("Hatalı giriş yaptınız....");
            }
        }
        public void ListeleSube(string sube)
        {
            Console.WriteLine("Şube".PadRight(10) + "No".PadRight(10) + "Adı Soyadı".PadRight(25) + "Not Ort.".PadRight(15) + "Okuduğu Kitap Say.".PadRight(20));
            Console.WriteLine("-------------------------------------------------------------------------------");
            if (sube.ToUpper() == "A")
            {
                foreach (Ogrenci x in Ogrenciler)
                {
                    if (x.sube == SUBE.A)
                    {
                        Console.WriteLine(x.sube.ToString().PadRight(10) + x.No.ToString().PadRight(10) + (x.Ad + " " + x.Soyad).PadRight(25) + x.NotOrtalamasi.ToString().PadRight(15) + x.OkuduguKitaplar.Count.ToString().PadRight(20));
                        Console.WriteLine("-------------------------------------------------------------------------------");
                    }
                }
            }
            else if (sube.ToUpper() == "B")
            {
                foreach (Ogrenci x in Ogrenciler)
                {
                    if (x.sube == SUBE.B)
                    {
                        Console.WriteLine(x.sube.ToString().PadRight(10) + x.No.ToString().PadRight(10) + (x.Ad + " " + x.Soyad).PadRight(25) + x.NotOrtalamasi.ToString().PadRight(15) + x.OkuduguKitaplar.Count.ToString().PadRight(20));
                        Console.WriteLine("-------------------------------------------------------------------------------");
                    }
                }
            }
            else if (sube.ToUpper() == "C")
            {
                foreach (Ogrenci x in Ogrenciler)
                {
                    if (x.sube == SUBE.C)
                    {
                        Console.WriteLine(x.sube.ToString().PadRight(10) + x.No.ToString().PadRight(10) + (x.Ad + " " + x.Soyad).PadRight(25) + x.NotOrtalamasi.ToString().PadRight(15) + x.OkuduguKitaplar.Count.ToString().PadRight(20));
                        Console.WriteLine("-------------------------------------------------------------------------------");
                    }
                }
            }

        }
        public void ListeleCins(string cins)
        {
            Console.WriteLine("Şube".PadRight(10) + "No".PadRight(10) + "Adı Soyadı".PadRight(25) + "Not Ort.".PadRight(15) + "Okuduğu Kitap Say.".PadRight(20));
            Console.WriteLine("-------------------------------------------------------------------------------");
            if (cins.ToUpper() == "K")
            {
                
                foreach (Ogrenci x in Ogrenciler)
                {
                    if (x.Cinsiyet == CINSIYET.Kiz)
                    {
                        Console.WriteLine(x.sube.ToString().PadRight(10) + x.No.ToString().PadRight(10) + (x.Ad + " " + x.Soyad).PadRight(25) + x.NotOrtalamasi.ToString().PadRight(15) + x.OkuduguKitaplar.Count.ToString().PadRight(20));
                        Console.WriteLine("-------------------------------------------------------------------------------");
                    }
                }
            }
            else if (cins.ToUpper() == "E")
            {
                
                foreach (Ogrenci x in Ogrenciler)
                {
                    if (x.Cinsiyet == CINSIYET.Erkek)
                    {
                        Console.WriteLine(x.sube.ToString().PadRight(10) + x.No.ToString().PadRight(10) + (x.Ad + " " + x.Soyad).PadRight(25) + x.NotOrtalamasi.ToString().PadRight(15) + x.OkuduguKitaplar.Count.ToString().PadRight(20));
                        Console.WriteLine("-------------------------------------------------------------------------------");
                    }
                }
            }

        }
        public void KitapListele(Ogrenci ogr, string giris)
        {
            if (ogr != null)
            {
                if (ogr.OkuduguKitaplar.Count > 0)
                {
                    if (giris == "19")
                    {
                        Program.OgrencGetir(ogr);
                        Console.WriteLine("Okuduğu Kitaplar".PadRight(20));
                        Console.WriteLine("----------------------------------------------");
                        foreach (string x in ogr.OkuduguKitaplar)
                        {
                            Console.WriteLine(x);
                        }
                        Console.WriteLine("----------------------------------------------");
                    }
                    else if (giris == "20")
                    {
                        Program.OgrencGetir(ogr);
                        Console.WriteLine("Okuduğu Son Kitap".PadRight(20));
                        Console.WriteLine("-----------------------------");
                        Console.WriteLine(ogr.OkuduguKitaplar[ogr.OkuduguKitaplar.Count - 1]);
                        Console.WriteLine("----------------------------------------------");
                    }
                }
                else
                {
                    Console.WriteLine("Okuduğu kitap yoktur.");
                }
            }
            else
            {
                Console.WriteLine("Böyle bir öğrenci yoktur.");
            }
        }
    }
}
