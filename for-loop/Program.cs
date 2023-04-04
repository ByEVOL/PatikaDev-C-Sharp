
// Ekrandan girilen sayıya kadar olan tek sayılarını ekrana yazdır.
Console.Write("Lütfen Bir Sayı Giriniz: ");
int sayac = int.Parse(Console.ReadLine());
for (int i = 1; i <= sayac; i++)
{
    if (i % 2 == 1)
        Console.WriteLine(i);
}

// 1 ile 1000 arasında tek ve çift sayıların kendi içlerindeki toplamını ekrana yazdırır
int tekToplam = 0;
int ciftToplam = 0;
for (int i = 1; i <= 1000; i++)
{
    if (i % 2 == 1)
        tekToplam += i; // tekToplam = tekToplam + i;
    else
        ciftToplam += i; // tekToplam = tekToplam + i;
}

Console.WriteLine("Tek Toplam: " + tekToplam);
Console.WriteLine("Çift Toplam: " + ciftToplam);


for (int i = 1; i < 10; i++)
{
    if (i == 4)
        break;
    Console.WriteLine(i);
}

for (int i = 1; 1 < 10; i++)
{
    if (i == 4)
        continue;
    Console.WriteLine(i);
}

