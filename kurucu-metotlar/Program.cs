Console.WriteLine("******* Çalışan 1 *******");
Calisan calisan1 = new Calisan("Ayşe","Kara",235656464,"İnsan Kaynakları");
calisan1.CalisanBilgileri();

Console.WriteLine("******* Çalışan 2 *******");
Calisan calisan2 = new Calisan("Emre","İLHAN",45456565,"Bilgi İşlem");
calisan2.CalisanBilgileri();


class Calisan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;

public Calisan(string ad,string soyad, int no, string departman)
{
    this.Ad = ad;
    this.Soyad = soyad;
    this.No = no;
    this.Departman = departman;
}

    public void CalisanBilgileri()
    {
        Console.WriteLine("Çalışanın Adı:{0}", Ad);
        Console.WriteLine("Çalışanın Soyadı:{0}", Soyad);
        Console.WriteLine("Çalışanın Numarası:{0}", No);
        Console.WriteLine("Çalışanın Departmanı:{0}", Departman);
    }
}