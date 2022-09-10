using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYonetimUygulamasi_G024
{
    
    class Ogrenci
    {
        
        public int No;
        public string Ad;
        public string Soyad;
        public DateTime DogumTarihi;
        public Adres Adresi { get; set; }
        public List<DersNotu> Notlar = new List<DersNotu>();
        public double NotOrtalamasi => Math.Round(Notlar.Count == 0 ? 0.0 : Notlar.Average(x => x.Not),2);
        public CINSIYET Cinsiyet { get; set; }
        public List<string> OkuduguKitaplar = new List<string>();
        public string Aciklama;
        public SUBE sube { get; set; }

        

        public Ogrenci(int no, string ad, string soyad, DateTime dtarihi, CINSIYET cins, SUBE sube)
        {
            this.Adresi = new Adres();
            this.Notlar = new List<DersNotu>();
            this.OkuduguKitaplar = new List<string>();
            this.No = no;
            this.Ad = ad;
            this.Soyad = soyad;
            this.DogumTarihi = dtarihi;
            this.Cinsiyet = cins;
            this.sube = sube;
        }
    }


    public enum CINSIYET
    {
        Empty,
        Kiz,
        Erkek
    }

    public enum SUBE
    {
        Empty, A, B, C
    }
    public enum ADRES
    {
        Empty, Il, Ilce , Mahalle
    }
}
