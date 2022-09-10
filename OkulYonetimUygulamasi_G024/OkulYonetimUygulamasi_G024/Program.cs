using System;
using System.Collections.Generic;
using System.Linq;

namespace OkulYonetimUygulamasi_G024
{

    class Program
    {
        static Okul Okul = new Okul();
        static void Main(string[] args)
        {
            SahteVeriGir();
            Menü();
            Secim();
        }
        static void Menü()
        {
            Console.WriteLine("------  Öğrenci Yönetim Sistemi  -----");
            Console.WriteLine("1-Öğrenci Ekle"); //
            Console.WriteLine("2-Not Gir"); //
            Console.WriteLine("3-Öğrencinin ortalamasını gör"); //
            Console.WriteLine("4-Öğrencinin adresini gir"); //
            Console.WriteLine("5-Bütün Öğrencileri Listele"); //
            Console.WriteLine("6-Şubeye Göre Öğrencileri Listele"); //
            Console.WriteLine("7-Öğrencinin notlarını görüntüle"); //
            Console.WriteLine("8-Sınıfın Not Ortalamasını Gör"); //
            Console.WriteLine("9-Cinsiyetine göre öğrenci listele"); //
            Console.WriteLine("10-Şu tarihten sonra doğan öğrencileri listele"); //
            Console.WriteLine("11-Tüm öğrencileri semtlerine göre sıralayarak listele");
            Console.WriteLine("12-Okuldaki En başarılı 5 öğrenciyi listele"); //
            Console.WriteLine("13-Okuldaki En başarısız 3 öğrenciyi listele"); //
            Console.WriteLine("14-Sınıftaki En başarılı 5 öğrenciyi listele"); //
            Console.WriteLine("15-Sınıftaki En başarısız 3 öğrenciyi listele"); //
            Console.WriteLine("16-Öğrenci için açıklama gir"); //
            Console.WriteLine("17-Öğrencinin açıklamasını gör"); //
            Console.WriteLine("18-Öğrencinin okuduğu kitabı gir"); //
            Console.WriteLine("19-Öğrencinin okuduğu kitapları listele"); //
            Console.WriteLine("20-Öğrencinin okuduğu son kitabı görüntüle"); //
            Console.WriteLine("21-Öğrenci sil"); //
            Console.WriteLine("22-Öğrenci güncelle"); //
            Console.WriteLine("-----------------------------------------------"); //
            Console.WriteLine("Çıkış yapmak için “çıkış” yazıp “enter”a basın."); //

        }
        static void Secim()
        {
            while (true)
            {
                string giris = Araclar.SecimAl("Yapmak istediğiniz işlemi seçiniz: ");
                switch (giris)
                {
                    case "1":
                        OgrenciEkle(); 
                        break;
                    case "2":
                        NotGir(); 
                        break;
                    case "3":
                        OgrenciOrtalamaGor();
                        break;
                    case "4":
                        AdresGir();
                        break;
                    case "5":
                        OgrencileriListele(giris);
                        break;
                    case "6":
                        OgrencileriListele(giris);
                        break;
                    case "7":
                        OgrenciNotGoruntule();
                        break;
                    case "8":
                        SinifinOrtalamaGor();
                        break;
                    case "9":
                        OgrencileriListele(giris);
                        break;                  
                    case "10":                  
                        OgrencileriListele(giris);
                        break;                  
                    case "11":                  
                        OgrencileriListele(giris);
                        break;                  
                    case "12":                  
                        OgrencileriListele(giris);
                        break;                  
                    case "13":                  
                        OgrencileriListele(giris);
                        break;                  
                    case "14":                  
                        OgrencileriListele(giris);
                        break;                  
                    case "15":                  
                        OgrencileriListele(giris);
                        break;                  
                    case "16":                  
                        AciklamaGir();     
                        break;                  
                    case "17":                  
                        AciklamaGor();     
                        break;                  
                    case "18":                  
                        KitapGir();        
                        break;                  
                    case "19":                  
                        OgrencileriListele(giris);
                        break;                  
                    case "20":                  
                        OgrencileriListele(giris);
                        break;
                    case "21":
                        OgrenciSil();
                        break;
                    case "22":
                        OgrenciGuncelle();
                        break;
                    case "cikis":
                    case "çıkış":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Hatalı işlem gerçekleştirildi. Tekrar deneyin.");
                        break;
                }
            }
        }       
        static void OgrenciEkle()
        {
            Console.WriteLine("---------Öğrenci Ekle---------");
            int no = Araclar.SayiAl("Öğrencinin numarası: ");
            int num = no + 1;
            string ad = Araclar.StringMi("Öğrencinin adı: ");
            string soyad = Araclar.StringMi("Öğrencinin soyadı: ");
            DateTime dtarihi = Araclar.TarihAl("Öğrencinin Doğum tarihi: ");
            CINSIYET cins;
            while (true)
            {
                Console.Write("Öğrencinin Cinsiyeti(K/E): ");
                cins = Araclar.CinsiyetBul(Console.ReadLine().ToUpper());
                if (cins <= 0)
                    Console.WriteLine("Hatalı giriş yapıldı. Tekrar deneyin.");
                else
                    break;
            }
            SUBE sube;
            while (true)
            {
                Console.Write("Öğrencinin şubesi(A/B/C): ");
                sube = Araclar.SubeBul(Console.ReadLine().ToUpper());
                if (sube <= 0)
                    Console.WriteLine("Hatalı giriş yapıldı. Tekrar deneyin.");
                else
                    break;
            }
            foreach (Ogrenci x in Okul.Ogrenciler)
            {
                
                if (x.No == no)
                {
                    Console.WriteLine(num.ToString() + " numaralı öğrenci sisteme başarılı bir şekilde eklenmiştir.");
                    Console.WriteLine("Sistemde " + no.ToString() + " numaralı öğrenci olduğu için verdiğiniz öğrenci no " + num.ToString() + " olarak değiştirildi.");
                    no = num;
                    break;
                }
            }
            if (num != no)
            {
                Console.WriteLine(no.ToString() + " numaralı öğrenci sisteme başarılı bir şekilde eklenmiştir.");
                Okul.Ogrenciler.Add(new Ogrenci(no, ad, soyad, dtarihi, cins, sube));
            }
        }
        static void NotGir()
        {
            Console.WriteLine("------------Not Ekle----------");

            while (true)
            {
                int no = Araclar.SayiAl("Öğrenci No: ");
                if (NoKontrol(no) == true)
                {
                    string ders = Araclar.StringMi("Eklemek istediğiniz ders adı: ");
                    int adet = Araclar.SayiAl("Eklemek istediğiniz not adedi:");

                    for (int i = 1; i <= adet; i++)
                    {

                        int not = Araclar.SayiAl(i + ". notu giriniz: ");
                        if (not > 100 || not < 0)
                        {
                            Console.WriteLine("Girdiğiniz değer 0 ve 100 arasında olmalıdır.");
                            i--;
                            continue;
                        }
                        else
                        {
                            
                            Okul.NotEkle(no, ders, not);
                        }
                        
                    }
                    Console.WriteLine("Notlar Kaydedilmiştir.");
                    break;
                }
                else
                {
                    Console.WriteLine("Böyle bir öğrenci bulunamadı. Tekrar Deneyin.");
                    continue;
                }
            }



        }
        static void OgrenciOrtalamaGor()
        {
            Console.WriteLine("--------Öğrencinin not ortalamasını gör -------");
            Console.WriteLine("Öğrencinin not ortalaması: " + OgrencGetir(OgrenciKontrol()).NotOrtalamasi.ToString());
        }
        static void AdresGir()
        {
            Console.WriteLine("-----------Öğrencinin adresini gir-----------");
            Ogrenci ogr = OgrencGetir(OgrenciKontrol());
            string il = Araclar.StringMi("İl: ");
            string ilce = Araclar.StringMi("İlçe: ");
            string mahalle = Araclar.StringMi("Mahalle: ");
            ogr.Adresi.Il = Araclar.IlkHarfBuyut(il);
            ogr.Adresi.Ilce = Araclar.IlkHarfBuyut(ilce);
            ogr.Adresi.Mahalle = Araclar.IlkHarfBuyut(mahalle);
            Console.WriteLine("Adres Kaydedilmiştir.");




        }
        static void OgrencileriListele(string giris)
        {
            if (giris == "5")
            {
                Console.WriteLine("----------------------------Bütün Öğrencileri Listele--------------------------");
                Listele(Okul.Ogrenciler);
            }
            else if (giris == "6")
            {
                Console.WriteLine("-------------------------Şubeye Göre Öğrencileri Listele--------------------------");
                
                string sube = Araclar.SecimAl("Listelemek istediğiniz şubeyi girin(A / B / C): ");
                Console.WriteLine("-------------------------------------------------------------------------------");
                switch (sube.ToUpper())
                {
                    case "A":
                        Okul.ListeleSube(sube);
                        break;
                    case "B":
                        Okul.ListeleSube(sube);
                        break;
                    case "C":
                        Okul.ListeleSube(sube);
                        break;
                    default:
                        Console.WriteLine("Hatalı Tuşladınız.");
                        break;
                }
            }
            else if (giris == "9")
            {
                Console.WriteLine("-----------------------Cinsiyetlerine Göre Öğrencileri Listele------------------------");
                string cins = Araclar.SecimAl("Listelemek istediğiniz cinsiyeti giriniz(K/E): ");
                switch (cins.ToUpper())
                {
                    case "K":
                        Okul.ListeleCins(cins);
                        break;
                    case "E":
                        Okul.ListeleCins(cins);
                        break;
                    default:
                        Console.WriteLine("Hatalı Tuşladınız.");
                        break;
                }


            }
            else if (giris == "10")
            {
                Console.WriteLine("-------------------Doğum Tarihine Göre Öğrencileri Listele---------------------");
                DateTime dt = Araclar.TarihAl("Hangi Tarihten sonraki öğrencileri listemek istersiniz: ");
                List<Ogrenci> liste = Okul.Ogrenciler.Where(a => a.DogumTarihi > dt).ToList();
                Console.WriteLine("-------------------------------------------------------------------------------");
                Console.WriteLine("Şube".PadRight(10) + "No".PadRight(10) + "Adı Soyadı".PadRight(25) + "Not Ort.".PadRight(15) + "Okuduğu Kitap Say.".PadRight(20));
                foreach (Ogrenci x in liste)
                {

                    Console.WriteLine(x.sube.ToString().PadRight(10) + x.No.ToString().PadRight(10) + (x.Ad + " " + x.Soyad).PadRight(25) + x.NotOrtalamasi.ToString().PadRight(15) + x.OkuduguKitaplar.Count.ToString().PadRight(20));
                    Console.WriteLine("-------------------------------------------------------------------------------");
                }
            }
            else if (giris == "11")
            {
                Console.WriteLine("-------------------Adreslerine Göre Öğrencileri Listele---------------------");
                List<Ogrenci> liste2 = Okul.Ogrenciler.OrderBy(a => a.Adresi.Il).ThenBy(a => a.Adresi.Ilce).ToList();
                
                Console.WriteLine("-------------------------------------------------------------------------------");
                Console.WriteLine("Şube".PadRight(10) + "No".PadRight(10) + "Adı Soyadı".PadRight(25) + "Şehir".PadRight(15) + "Semt".PadRight(15));
                Console.WriteLine("-------------------------------------------------------------------------------");
                if (liste2.Count > 0)
                {
                    foreach (Ogrenci ogrenci in liste2)
                        Console.WriteLine(ogrenci.sube.ToString().PadRight(10) + ogrenci.No.ToString().PadRight(10) + (ogrenci.Ad + " " + ogrenci.Soyad).PadRight(25) + ogrenci.Adresi.Il.ToString().PadRight(15) + ogrenci.Adresi.Ilce.ToString().PadRight(15));
                }
                else
                    Console.WriteLine("Listelenecek öğrenci bulunamadı.");
            }
            else if (giris == "12")
            {
                Console.WriteLine("-------------------Okuldaki en başarılı 5 öğrenciyi Listele---------------------");
                List<Ogrenci> liste3 = Okul.Ogrenciler.OrderByDescending(t => t.NotOrtalamasi).Take(5).ToList();
                Console.WriteLine("-------------------------------------------------------------------------------");
                Console.WriteLine("Şube".PadRight(10) + "No".PadRight(10) + "Adı Soyadı".PadRight(25) + "Not Ort.".PadRight(15) + "Okuduğu Kitap Say.".PadRight(20));
                Console.WriteLine("-------------------------------------------------------------------------------");
                foreach (Ogrenci x in liste3)
                {
                    Console.WriteLine(x.sube.ToString().PadRight(10) + x.No.ToString().PadRight(10) + (x.Ad + " " + x.Soyad).PadRight(25) + x.NotOrtalamasi.ToString().PadRight(15) + x.OkuduguKitaplar.Count.ToString().PadRight(20));
                    Console.WriteLine("-------------------------------------------------------------------------------");
                }
            }
            else if (giris == "13")
            {
                Console.WriteLine("-------------------Okuldaki en başarısız 3 öğrenciyi Listele---------------------");
                List<Ogrenci> liste4 = Okul.Ogrenciler.OrderBy(t => t.NotOrtalamasi).Take(3).ToList(); Console.WriteLine("-------------------------------------------------------------------------------");
                Console.WriteLine("Şube".PadRight(10) + "No".PadRight(10) + "Adı Soyadı".PadRight(25) + "Not Ort.".PadRight(15) + "Okuduğu Kitap Say.".PadRight(20));
                Console.WriteLine("-------------------------------------------------------------------------------");
                foreach (Ogrenci x in liste4)
                {
                    Console.WriteLine(x.sube.ToString().PadRight(10) + x.No.ToString().PadRight(10) + (x.Ad + " " + x.Soyad).PadRight(25) + x.NotOrtalamasi.ToString().PadRight(15) + x.OkuduguKitaplar.Count.ToString().PadRight(20));
                    Console.WriteLine("-------------------------------------------------------------------------------");
                }
            }
            else if (giris == "14")
            {
                Console.WriteLine("-------------------Sınıftaki en başarılı 5 öğrenciyi Listele---------------------");
                string sube = Araclar.SecimAl("Listelenecek olan şubeyi seçin(A/B/C): ");
                switch (sube.ToUpper())
                {
                    case "A":
                        List<Ogrenci> liste5 = Okul.Ogrenciler.Where(t => t.sube == SUBE.A).OrderByDescending(t => t.NotOrtalamasi).Take(5).ToList();
                        Console.WriteLine("Şube".PadRight(10) + "No".PadRight(10) + "Adı Soyadı".PadRight(25) + "Not Ort.".PadRight(15) + "Okuduğu Kitap Say.".PadRight(20));
                        Console.WriteLine("-------------------------------------------------------------------------------");
                        foreach (Ogrenci x in liste5)
                        {
                            Console.WriteLine(x.sube.ToString().PadRight(10) + x.No.ToString().PadRight(10) + (x.Ad + " " + x.Soyad).PadRight(25) + x.NotOrtalamasi.ToString().PadRight(15) + x.OkuduguKitaplar.Count.ToString().PadRight(20));
                            Console.WriteLine("-------------------------------------------------------------------------------");
                        }
                        break;
                    case "B":
                        List<Ogrenci> liste6 = Okul.Ogrenciler.Where(t => t.sube == SUBE.B).OrderByDescending(t => t.NotOrtalamasi).Take(5).ToList();
                        Console.WriteLine("Şube".PadRight(10) + "No".PadRight(10) + "Adı Soyadı".PadRight(25) + "Not Ort.".PadRight(15) + "Okuduğu Kitap Say.".PadRight(20));
                        Console.WriteLine("-------------------------------------------------------------------------------");
                        foreach (Ogrenci x in liste6)
                        {
                            Console.WriteLine(x.sube.ToString().PadRight(10) + x.No.ToString().PadRight(10) + (x.Ad + " " + x.Soyad).PadRight(25) + x.NotOrtalamasi.ToString().PadRight(15) + x.OkuduguKitaplar.Count.ToString().PadRight(20));
                            Console.WriteLine("-------------------------------------------------------------------------------");
                        }
                        break;
                    case "C":
                        List<Ogrenci> liste7 = Okul.Ogrenciler.Where(t => t.sube == SUBE.C).OrderByDescending((t => t.NotOrtalamasi)).Take(5).ToList();
                        Console.WriteLine("Şube".PadRight(10) + "No".PadRight(10) + "Adı Soyadı".PadRight(25) + "Not Ort.".PadRight(15) + "Okuduğu Kitap Say.".PadRight(20));
                        Console.WriteLine("-------------------------------------------------------------------------------");
                        foreach (Ogrenci x in liste7)
                        {
                            Console.WriteLine(x.sube.ToString().PadRight(10) + x.No.ToString().PadRight(10) + (x.Ad + " " + x.Soyad).PadRight(25) + x.NotOrtalamasi.ToString().PadRight(15) + x.OkuduguKitaplar.Count.ToString().PadRight(20));
                            Console.WriteLine("-------------------------------------------------------------------------------");
                        }
                        break;
                    default:
                        Console.WriteLine("Hatalı tuşladınız.");
                        break;
                }
            }
            else if (giris == "15")
            {
                Console.WriteLine("-------------------Sınıftaki en başarısız 3 öğrenciyi Listele---------------------");
                string sube = Araclar.SecimAl("Listelenecek olan şubeyi seçin(A/B/C): ");
                switch (sube.ToUpper())
                {
                    case "A":
                        List<Ogrenci> liste8 = Okul.Ogrenciler.Where<Ogrenci>((Func<Ogrenci, bool>)(t => t.sube == SUBE.A)).OrderBy<Ogrenci, double>((Func<Ogrenci, double>)(t => t.NotOrtalamasi)).Take<Ogrenci>(3).ToList<Ogrenci>();
                        Console.WriteLine("Şube".PadRight(10) + "No".PadRight(10) + "Adı Soyadı".PadRight(25) + "Not Ort.".PadRight(15) + "Okuduğu Kitap Say.".PadRight(20));
                        Console.WriteLine("-------------------------------------------------------------------------------");
                        foreach (Ogrenci x in liste8)
                        {
                            Console.WriteLine(x.sube.ToString().PadRight(10) + x.No.ToString().PadRight(10) + (x.Ad + " " + x.Soyad).PadRight(25) + x.NotOrtalamasi.ToString().PadRight(15) + x.OkuduguKitaplar.Count.ToString().PadRight(20));
                            Console.WriteLine("-------------------------------------------------------------------------------");
                        }
                        break;
                    case "B":
                        List<Ogrenci> liste9 = Okul.Ogrenciler.Where<Ogrenci>((Func<Ogrenci, bool>)(t => t.sube == SUBE.B)).OrderBy<Ogrenci, double>((Func<Ogrenci, double>)(t => t.NotOrtalamasi)).Take<Ogrenci>(3).ToList<Ogrenci>();
                        Console.WriteLine("Şube".PadRight(10) + "No".PadRight(10) + "Adı Soyadı".PadRight(25) + "Not Ort.".PadRight(15) + "Okuduğu Kitap Say.".PadRight(20));
                        Console.WriteLine("-------------------------------------------------------------------------------");
                        foreach (Ogrenci x in liste9)
                        {
                            Console.WriteLine(x.sube.ToString().PadRight(10) + x.No.ToString().PadRight(10) + (x.Ad + " " + x.Soyad).PadRight(25) + x.NotOrtalamasi.ToString().PadRight(15) + x.OkuduguKitaplar.Count.ToString().PadRight(20));
                            Console.WriteLine("-------------------------------------------------------------------------------");
                        }
                        break;
                    case "C":
                        List<Ogrenci> liste10 = Okul.Ogrenciler.Where<Ogrenci>((Func<Ogrenci, bool>)(t => t.sube == SUBE.C)).OrderBy<Ogrenci, double>((Func<Ogrenci, double>)(t => t.NotOrtalamasi)).Take<Ogrenci>(3).ToList<Ogrenci>();
                        Console.WriteLine("Şube".PadRight(10) + "No".PadRight(10) + "Adı Soyadı".PadRight(25) + "Not Ort.".PadRight(15) + "Okuduğu Kitap Say.".PadRight(20));
                        Console.WriteLine("-------------------------------------------------------------------------------");
                        foreach (Ogrenci x in liste10)
                        {
                            Console.WriteLine(x.sube.ToString().PadRight(10) + x.No.ToString().PadRight(10) + (x.Ad + " " + x.Soyad).PadRight(25) + x.NotOrtalamasi.ToString().PadRight(15) + x.OkuduguKitaplar.Count.ToString().PadRight(20));
                            Console.WriteLine("-------------------------------------------------------------------------------");
                        }
                        break;
                    default:
                        Console.WriteLine("Hatalı tuşladınız.");
                        break;
                }

            }
            else if (giris == "19")
            {
                Console.WriteLine("------------------Öğrencinin okuduğu kitapları listele---------------------");
                Okul.KitapListele(OgrenciKontrol(), giris);

            }
            else if (giris == "20")
            {
                Console.WriteLine("------------------Öğrencinin okuduğu son kitabı listele---------------------");
                Okul.KitapListele(OgrenciKontrol(), giris);

            }


        }
        static void OgrenciNotGoruntule()
        {
            Console.WriteLine("---------------Öğrencinin notlarını görüntüle--------------");
            Ogrenci ogr = OgrencGetir(OgrenciKontrol());
            Console.WriteLine("Dersin Adı".PadRight(15) + "Notu".PadRight(5));
            Console.WriteLine("--------------------------------------------");
            foreach (DersNotu dersNotu in ogr.Notlar)
            {
                Console.WriteLine(dersNotu.DersAdi.ToString().PadRight(15) + dersNotu.Not.ToString().PadRight(5));
                Console.WriteLine("--------------------------------------------");
            }


        }
        static void SinifinOrtalamaGor()
        {
            Console.WriteLine("-----------Sinifin not ortalamasını gör---------------");
            string sube = Araclar.SecimAl("Şube seçiniz(A/B/C): ");
            switch (sube.ToUpper())
            {
                case "A":
                    List<Ogrenci> notlar = Okul.Ogrenciler.Where(a => a.sube == SUBE.A).ToList();
                    Console.WriteLine(sube + " sınıfının not ortalaması: " + Math.Round(notlar.Count == 0 ? 0.0 : notlar.Average((x => x.NotOrtalamasi)), 2).ToString());
                    break;
                case "B":
                    List<Ogrenci> notlar1 = Okul.Ogrenciler.Where(a => a.sube == SUBE.B).ToList();
                    Console.WriteLine(sube + " sınıfının not ortalaması: " + Math.Round(notlar1.Count == 0 ? 0.0 : notlar1.Average((x => x.NotOrtalamasi)), 2).ToString());
                    break;
                case "C":
                    List<Ogrenci> notlar2 = Okul.Ogrenciler.Where(a => a.sube == SUBE.C).ToList();
                    Console.WriteLine(sube + " sınıfının not ortalaması: " + Math.Round(notlar2.Count == 0 ? 0.0 : notlar2.Average((x => x.NotOrtalamasi)), 2).ToString());
                    break;
                default:
                    Console.WriteLine("Hatalı tuşladınız.");
                    break;
            }
            
        }
        static void AciklamaGir()
        {
            Console.WriteLine("-----------------Öğrenci için açıklama gir-----------------");
            Ogrenci ogr1 = OgrencGetir(OgrenciKontrol());
            Console.Write("Açıklama: ");
            string text = Console.ReadLine();
            Console.WriteLine("--------------------------------------");
            Ogrenci ogr2 = ogr1;
            ogr2.Aciklama = ogr2.Aciklama + Araclar.IlkHarfBuyut(text);
            Console.WriteLine("Bilgiler sisteme girilmiştir.");
        }
        static void AciklamaGor()
        {
            Console.WriteLine("-----------------Öğrencinin açıklamasını gör-----------------");
            Ogrenci ogr1 = OgrencGetir(OgrenciKontrol());
            if (ogr1.Aciklama != null)
            {
                Console.Write("Açıklama: ");
                Console.WriteLine(ogr1.Aciklama);
                Console.WriteLine("--------------------------------------");
            }
            else
            {
                Console.WriteLine("Bu öğrenciye ait açıklama bulunmamaktadır.");
                Console.WriteLine("--------------------------------------");
            }
                                  
        }
        static void KitapGir()
        {
            Console.WriteLine("-----------------Öğrencinin okuduğu kitabı gir-----------------");
            Ogrenci ogr1 = OgrencGetir(OgrenciKontrol());
            Console.Write("Eklenecek Kitap İsmi: ");
            string kitap = Araclar.IlkHarfBuyut(Console.ReadLine());
            Console.WriteLine("--------------------------------------");
            ogr1.OkuduguKitaplar.Add(kitap);
            Console.WriteLine("Bilgiler sisteme girilmiştir.");
            Console.WriteLine("--------------------------------------");
        }
        static void OgrenciSil()
        {
            Console.WriteLine("-----------------Öğrenci SİL-----------------");
            if (Okul.Ogrenciler.Count == 0)
            {
                Console.WriteLine("Listede silinecek öğrenci yoktur.");
            }
            else
            {
                Ogrenci ogr = OgrencGetir(OgrenciKontrol());
                Console.Write("Öğrenciyi silmek istediğinize emin misiniz(E/H)?");
                string secim = Console.ReadLine();
                switch (secim.ToUpper())
                {
                    case "E":
                        Console.WriteLine("---------------------------------");
                        Okul.Ogrenciler.Remove(ogr);
                        Console.WriteLine("Öğrenci başarılı şekilde silindi.");
                        Console.WriteLine("---------------------------------");
                        break;
                    case "H":
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine("İşlem iptal edildi.");
                        break;
                    default:
                        Console.WriteLine("Hatalı tuşladınız.");
                        break;
                }
            }
        }
        static void OgrenciGuncelle()
        {
            Console.WriteLine("-----------------Öğrencinin Güncelle-----------------");
            Console.WriteLine("Öğrencin değiştirmek istediğini bilgilerini giriniz.");
            Console.WriteLine("Değiştirmek istemediklerinizi boş bırakın.");
            Console.WriteLine("----------------------------------------------------");
            Ogrenci ogr = OgrencGetir(OgrenciKontrol());
            Console.Write("Öğrencinin Adı: ");
            string ad = Araclar.IlkHarfBuyut(Console.ReadLine());
            if (ad.Length > 0) ogr.Ad = ad;
            Console.Write("Soyadı: ");
            string soyad = Araclar.IlkHarfBuyut(Console.ReadLine());
            if (soyad.Length > 0) ogr.Soyad = soyad;
            Console.Write("Öğrencinin doğum tarihi: ");
            string dt = Console.ReadLine();
            if(dt.Length > 0)
            {
                DateTime sonuc;
                if(DateTime.TryParse(dt, out sonuc) == true)
                {
                    ogr.DogumTarihi = sonuc;
                }
            }
            string cins = Araclar.SecimAl("Öğrencinin cinsiyeti(K/E): ");
            switch (cins.ToUpper())
            {
                case "E":
                    ogr.Cinsiyet = CINSIYET.Erkek;
                    break;
                case "K":
                    ogr.Cinsiyet = CINSIYET.Kiz;
                    break;
                case "  ":
                case " ":
                case "":
                    break;
                default:
                    Console.WriteLine("Hatalı tuşladınız. Cinsiyet Kaydedilemedi.");
                    break;
            }
            string sube = Araclar.SecimAl("Öğrencinin şubesi(A/B/C): ");
            switch (sube.ToUpper())
            {
                case "A":
                    ogr.sube = SUBE.A;
                    break;
                case "B":
                    ogr.sube = SUBE.B;
                    break;
                case "C":
                    ogr.sube = SUBE.C;
                    break;
                case "  ":
                case " ":
                case "":
                    break;
                default:
                    Console.WriteLine("Hatalı tuşladınız. Şube Kaydedilemedi.");
                    break;
            }
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Öğrenci güncellendi.");
            Console.WriteLine("----------------------------------------------------");
        }     
        static void SahteVeriGir()
        {


            Ogrenci ogrenci1 = new Ogrenci(56, "Naz", "Şimşek", new DateTime(2000,6,9), CINSIYET.Kiz, SUBE.B);
            Ogrenci ogrenci2 = new Ogrenci(77, "Selin", "Akkız", new DateTime(1998,4,1), CINSIYET.Kiz, SUBE.B);
            Ogrenci ogrenci3 = new Ogrenci(88, "Papatya", "Yüzbaşı", new DateTime(1991,8,19), CINSIYET.Kiz, SUBE.B);
            Ogrenci ogrenci4 = new Ogrenci(99, "Sinan", "Batı", new DateTime(1993,12,19), CINSIYET.Erkek, SUBE.B);
            Ogrenci ogrenci5 = new Ogrenci(154, "Aişe", "Sevilen", new DateTime(1990, 6, 5), CINSIYET.Kiz, SUBE.A);
            Ogrenci ogrenci6 = new Ogrenci(482, "Ümit", "Türkmen", new DateTime(1996, 12, 9), CINSIYET.Erkek, SUBE.B);
            Ogrenci ogrenci7 = new Ogrenci(1132, "Oğuzhan", "Türkmen", new DateTime(1999, 5, 5), CINSIYET.Erkek, SUBE.C);
            Ogrenci ogrenci8 = new Ogrenci(1363, "Ahmet", "Türkmen", new DateTime(1970, 3, 20), CINSIYET.Erkek, SUBE.A);
            Ogrenci ogrenci9 = new Ogrenci(452, "Mavera", "Seher", new DateTime(2000, 12, 17), CINSIYET.Kiz, SUBE.B);
            Okul.Ogrenciler.Add(ogrenci1);
            Okul.Ogrenciler.Add(ogrenci2);
            Okul.Ogrenciler.Add(ogrenci3);
            Okul.Ogrenciler.Add(ogrenci4);
            Okul.Ogrenciler.Add(ogrenci5);
            Okul.Ogrenciler.Add(ogrenci6);
            Okul.Ogrenciler.Add(ogrenci7);
            Okul.Ogrenciler.Add(ogrenci8);
            Okul.Ogrenciler.Add(ogrenci9);
            ogrenci1.Adresi.Il = "Ankara";
            ogrenci1.Adresi.Ilce = "Çankaya";
            ogrenci1.Adresi.Mahalle = "Meclis";
            ogrenci2.Adresi.Il = "İzmir";
            ogrenci2.Adresi.Ilce = "Alsancak";
            ogrenci2.Adresi.Mahalle = "Laleli";
            ogrenci3.Adresi.Il = "İstanbul";
            ogrenci3.Adresi.Ilce = "Kartal";
            ogrenci3.Adresi.Mahalle = "Kurfalı";
            ogrenci4.Adresi.Il = "Ordu";
            ogrenci4.Adresi.Ilce = "Keçiören";
            ogrenci4.Adresi.Mahalle = "Sakızlı";
            ogrenci5.Adresi.Il = "İstanbul";
            ogrenci5.Adresi.Ilce = "Pendik";
            ogrenci5.Adresi.Mahalle = "Şeyhli";
            ogrenci6.Adresi.Il = "İstanbul";
            ogrenci6.Adresi.Ilce = "Pendik";
            ogrenci6.Adresi.Mahalle = "Kurtköy";
            ogrenci7.Adresi.Il = "Erzincan";
            ogrenci7.Adresi.Ilce = "Silivri";
            ogrenci7.Adresi.Mahalle = "Demirboğan";
            ogrenci8.Adresi.Il = "Trabzon";
            ogrenci8.Adresi.Ilce = "Of";
            ogrenci8.Adresi.Mahalle = "Çaleli";
            ogrenci9.Adresi.Il = "Ankara";
            ogrenci9.Adresi.Ilce = "Mamak";
            ogrenci9.Adresi.Mahalle = "Kekoland";
            ogrenci1.OkuduguKitaplar.Add("Kalemimin Sapını Gülle Donattım");
            ogrenci1.OkuduguKitaplar.Add("Bir Çift Yürek");
            ogrenci2.OkuduguKitaplar.Add("Kırmızı Saçlı Kadın");
            ogrenci2.OkuduguKitaplar.Add("Kürk Mantolu Madonna");
            ogrenci2.OkuduguKitaplar.Add("Genç Werther'in Acıları");
            ogrenci3.OkuduguKitaplar.Add("1984");
            ogrenci3.OkuduguKitaplar.Add("Hayvanlar Çiftliği");
            ogrenci4.OkuduguKitaplar.Add("Sapiens");
            ogrenci5.OkuduguKitaplar.Add("Kalemimin Sapını Gülle Donattım");
            ogrenci6.OkuduguKitaplar.Add("Bir Çift Yürek");
            ogrenci7.OkuduguKitaplar.Add("Kırmızı Saçlı Kadın");
            ogrenci8.OkuduguKitaplar.Add("Kürk Mantolu Madonna");
            ogrenci9.OkuduguKitaplar.Add("Genç Werther'in Acıları");
            ogrenci6.OkuduguKitaplar.Add("1984");
            ogrenci6.OkuduguKitaplar.Add("Hayvanlar Çiftliği");
            ogrenci6.OkuduguKitaplar.Add("Sapiens");



        }
        public static Ogrenci NumaraKontrol()
        {
            int no = Araclar.SayiAl("Öğrencinin numarası: ");
            return Okul.Ogrenciler.Where<Ogrenci>((Func<Ogrenci, bool>)(t => t.No == no)).FirstOrDefault<Ogrenci>();
            
        }    
        public static Ogrenci OgrenciKontrol()
        {
            Ogrenci ogrenci;
            while (true)
            {
                ogrenci = NumaraKontrol();
                if (ogrenci == null)
                {
                    Console.WriteLine("Böyle bir öğrenci yok. Tekrar deneyin.");
                }
                else
                {
                    break;
                }
            }
            return ogrenci;
        }        
        public static bool NoKontrol(int y)
        {
            bool b = false;
            foreach (Ogrenci x in Okul.Ogrenciler)
            {
                if (x.No == y)
                {
                    b = true;
                }
            }
            return b;
        }
        public static Ogrenci OgrencGetir(Ogrenci ogr)
        {

            Console.WriteLine("Öğrencninin Adı Soyadı: " + ogr.Ad + " " + ogr.Soyad);
            Console.WriteLine("Öğrencinin Şubesi: " + ogr.sube.ToString());
            return ogr;
        }
        static void Listele(List<Ogrenci> ogrenciler)
        {
            Console.WriteLine("Şube".PadRight(10) + "No".PadRight(10) + "Adı Soyadı".PadRight(25) + "Not Ort.".PadRight(15) + "Okuduğu Kitap Say.".PadRight(20));
            Console.WriteLine("-------------------------------------------------------------------------------");
            foreach (Ogrenci x in Okul.Ogrenciler)
            {
                Console.WriteLine(x.sube.ToString().PadRight(10) + x.No.ToString().PadRight(10) + (x.Ad + " " + x.Soyad).PadRight(25) + x.NotOrtalamasi.ToString().PadRight(15) + x.OkuduguKitaplar.Count.ToString().PadRight(20));
                Console.WriteLine("-------------------------------------------------------------------------------");
            }
        }
        public static void Listele2(List<Ogrenci> ogrenciler)
        {
            if (Okul.Ogrenciler.Count > 0)
            {
                Console.WriteLine("Şube".PadRight(10) + "No".PadRight(10) + "Adı Soyadı".PadRight(25) + "Not Ort.".PadRight(15) + "Okuduğu Kitap Say.".PadRight(20));
                Console.WriteLine("-------------------------------------------------------------------------------");
                foreach (Ogrenci ogrenci in Okul.Ogrenciler)
                {
                    string[] strArray = new string[5]
                    {
                    ogrenci.sube.ToString().PadRight(10),
                    null,
                    null,
                    null,
                    null
                    };
                    int num = ogrenci.No;
                    strArray[1] = num.ToString().PadRight(10);
                    strArray[2] = (ogrenci.Ad + " " + ogrenci.Soyad).PadRight(25);
                    strArray[3] = ogrenci.NotOrtalamasi.ToString().PadRight(15);
                    num = ogrenci.OkuduguKitaplar.Count;
                    strArray[4] = num.ToString().PadRight(20);
                    Console.WriteLine(string.Concat(strArray));
                    Console.WriteLine("-------------------------------------------------------------------------------");
                }
            }
            else
                Console.WriteLine("Listelenecek öğrenci bulunamadı.");
        }    
    }
}
