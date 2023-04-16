// List<T> class
// System.Collections.Generic;
// T-> object türündedir

List<int> sayiListesi = new List<int>();
sayiListesi.Add(23);
sayiListesi.Add(10);
sayiListesi.Add(4);
sayiListesi.Add(5);
sayiListesi.Add(92);
sayiListesi.Add(34);

List<string> renkListesi = new List<string>();
renkListesi.Add("Kırmızı");
renkListesi.Add("Mavi");
renkListesi.Add("Turuncu");
renkListesi.Add("Sarı");
renkListesi.Add("Yeşil");

// Count
Console.WriteLine(renkListesi.Count);
Console.WriteLine(sayiListesi.Count);

// Foreach ve List.ForEach ile elemanara erişim
foreach (var sayi in sayiListesi)
    Console.WriteLine(sayi);
foreach (var renk in renkListesi)
    Console.WriteLine(renk);

sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
renkListesi.ForEach(renk => Console.WriteLine(renk));

// Listeden eleman çıkarma
sayiListesi.Remove(4);
renkListesi.Remove("Yeşil");

sayiListesi.RemoveAt(0);
renkListesi.RemoveAt(1);

sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
renkListesi.ForEach(renk => Console.WriteLine(renk));

// Liste içerisinde arama
if (sayiListesi.Contains(10))
    Console.WriteLine("10 Liste içerisinde bulundu");

// Eleman ile index e erişme
Console.WriteLine(renkListesi.BinarySearch("Sarı"));

// Diziyi List'e çevirme
string[] hayvanlar = { "Kedi", "Köpek", "Kuş" };
List<string> hayvanListesi = new List<string>(hayvanlar);

// Listeyi nasıl temizleriz
hayvanListesi.Clear();

// List çevirisinde nesne tutmak
List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();
Kullanicilar kullanici1 = new Kullanicilar();
kullanici1.Isim = "Emre";
kullanici1.Soyisim = "İLHAN";
kullanici1.Yas = 31;

Kullanicilar kullanici2 = new Kullanicilar();
kullanici2.Isim = "Didem";
kullanici2.Soyisim = "Altıner";
kullanici2.Yas = 26;

kullaniciListesi.Add(kullanici1);
kullaniciListesi.Add(kullanici2);

List<Kullanicilar> yeniListe = new List<Kullanicilar>();

yeniListe.Add(new Kullanicilar()
{
    Isim = "Deniz",
    Soyisim = "Arda",
    Yas = 24
});

foreach (var kulanici in kullaniciListesi)
{
    Console.WriteLine("Kullanıcı Adı:" + kulanici.Isim);
    Console.WriteLine("Kullanıcı Soyadı:" + kulanici.Soyisim);
    Console.WriteLine("Kullanıcı Yas:" + kulanici.Yas);
}

yeniListe.Clear();


public class Kullanicilar
{
    private string isim;
    private string soyisim;
    private int yas;

    public string Isim { get => isim; set => isim = value; }
    public string Soyisim { get => soyisim; set => soyisim = value; }
    public int Yas { get => yas; set => yas = value; }
}
