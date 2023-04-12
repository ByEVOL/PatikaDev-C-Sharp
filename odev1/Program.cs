// 1. Sorunun Çözümü
// Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

Console.Write("Girmek istediğiniz Sayı Adetini Giriniz: ");

int sayiAdeti = int.Parse(Console.ReadLine());
int[] sayiDizisi = new int[sayiAdeti];
for (int i=0; i<sayiAdeti; i++)
{
    Console.Write("Lütfen {0}. Sayısı Giriniz: ", i + 1);
    sayiDizisi[i] = int.Parse(Console.ReadLine());
}

Console.Write("Girmiş Olduğunuz Çift Sayılar: ");
int bolonebilenSayi = 0;
for (int i=0; i<sayiAdeti; i++)
{
    if (sayiDizisi[i]%2==0)
    {
        bolonebilenSayi++;
        Console.Write(sayiDizisi[i] + " ");
    }
}



// 2. Sorunun Çözümü
// Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

Console.Write("Hangi Sayının Bölünmesini İstersiniz: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Kaç Adet Sayı Girmek İstersiniz: ");
int sayiAdeti = int.Parse(Console.ReadLine());
int[] sayiDizisi = new int[sayiAdeti];
for (int i=0; i<sayiAdeti; i++)
{
    Console.Write("Lütfen {0}. Sayısı Giriniz: ", i + 1);
    sayiDizisi[i] = int.Parse(Console.ReadLine());
}

Console.Write("Girmiş Olduğunuz Çift Sayılar: ");
int bolonebilenSayi = 0;
for (int i=0; i<sayiAdeti; i++)
{
    if (sayiDizisi[i] % m == 0 || sayiDizisi[i] == m)
    {
        bolonebilenSayi++;
        Console.Write(sayiDizisi[i] + " ");
    }
}



// 3. Sorunun Çözümü
// Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

Console.Write("Kaç Adet Kelime Girmek İstersiniz: ");
int sayiAdeti = int.Parse(Console.ReadLine());
String[] sayiDizisi = new String[sayiAdeti];
for (int i=0; i<sayiAdeti; i++)
{
    Console.Write("Lütfen {0}. Kelimeyi Giriniz: ", i + 1);
    sayiDizisi[i] = (Console.ReadLine());
}


Array.Reverse(sayiDizisi);
Console.Write("Girmiş Olduğunuz Kelimeler: ");
for (int i=0; i<sayiAdeti; i++)
{
        Console.Write(sayiDizisi[i] + " ");
    
}




// 4. Sorunun Çözümü
// Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

Console.Write("Bir Cümle Yazınız: ");
String sayiDizisi = Console.ReadLine();

int harf = sayiDizisi.Length;
string[] bos = sayiDizisi.Split(' ');
int bosluksuzharf = harf - (bos.Length - 1);
Console.WriteLine("Toplam Kelime: " + bos.Length + " Toplam Harf: " + bosluksuzharf);