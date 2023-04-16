using System.Collections;
using System.Collections.Generic;

// Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)
// -Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
// -Negatif ve numeric olmayan girişleri engelleyin.
// -Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.

int n = 20;
ArrayList asal = new ArrayList();
ArrayList asalDegil = new ArrayList();
ArrayList sayilar = new ArrayList();

int num;
try
{
    for (int i = 0; i < n; i++)
    {
        Console.Write((i + 1) + ". Sayiyi Giriniz: ");
        num = int.Parse(Console.ReadLine());
        if (num < 0)
            throw new InvalidDataException("Lutfen pozitif bir sayi giriniz.");
        else
            sayilar.Add(num);

    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message.ToString());
}

int flag;
foreach (var item in sayilar)
{
    flag = 0;
    int number = Convert.ToInt32(item);
    if (number == 1)
        flag = 1;
    for (int i = 2; i < number; i++)
    {
        if (number == 2)
            break;
        if (number % i == 0)
        {
            flag = 1;
            break;
        }
    }
    if (flag == 1)
        asalDegil.Add(number);
    else
        asal.Add(number);
}

asal.Sort();
asalDegil.Sort();

float asalToplam = 0;
float asalOlmayanToplam = 0;
Console.WriteLine("Asal olanlar: ");
foreach (var item in asal)
{
    Console.Write(item + ",");
    asalToplam += Convert.ToInt32(item);
}

Console.WriteLine("Asal olmayanlar: ");
foreach (var item in asalDegil)
{
    Console.Write(item + ",");
    asalOlmayanToplam += Convert.ToInt32(item);
}

Console.WriteLine("Asal olan sayi: " + asal.Count);
Console.WriteLine("Asal olan toplam: " + asalToplam);
Console.WriteLine("Asal olan ortalama: " + (asalToplam / asal.Count));

Console.WriteLine("Asal olmayan sayi: " + asalDegil.Count);
Console.WriteLine("Asal olmayan toplam: " + asalOlmayanToplam);
Console.WriteLine("Asal olmayan ortalama: " + (asalOlmayanToplam / asalDegil.Count));
