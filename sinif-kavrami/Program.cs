

// Söz Dizimi

// class SinifAdi
// {
//     [Erişim Belirleyici] [Veri Tipi] OzellikAdi:
//     [Erişim Belirleyici] [Geri Dönüş Tipi] MetotAdi(Parametre Listesi)
//     {
//         Metot Komutlari
//     }
// }


// Erişim Belirleyiciler
// * Public - Her yerden erişilebilir.
// * Private - Sadece tanımlandığı sınıf içerisinden erişilebilir.
// * Internal - Sadece bulunduğu proje içerisinden erişilebilir.
// * Protected - Sadece tanımlandığı sınıfta ya da o sınıfı miras alan sınıflardan erişilebilir.


Calisan calisan1 = new Calisan();
calisan1.Ad = "Ayşe";
calisan1.Soyad = "Kara";
calisan1.No = 123454656;
calisan1.Departman = "İnsan Kaynakları";
calisan1.CalisanBilgileri();
Console.WriteLine("************");

Calisan calisan2 = new Calisan();
calisan2.Ad = "Deniz";
calisan2.Soyad = "Arda";
calisan2.No = 235748456;
calisan2.Departman = "Satın Alma";
calisan2.CalisanBilgileri();


class Calisan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;

    public void CalisanBilgileri()
    {
        Console.WriteLine("Çalışanın Adı:{0}", Ad);
        Console.WriteLine("Çalışanın Soyadı:{0}", Soyad);
        Console.WriteLine("Çalışanın Numarası:{0}", No);
        Console.WriteLine("Çalışanın Departmanı:{0}", Departman);
    }
}