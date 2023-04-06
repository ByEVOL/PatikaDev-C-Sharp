// Dizi Tanımlama
string[] renkler = new string[5];
string[] hayvanlar = { "Kedi", "Köpek", "Kuş", "Maymun" };
int[] dizi;
dizi = new int[5];

// Dizilere Değer Atama ve Erişim
renkler[0] = "Mavi";
dizi[3] = 10;

Console.WriteLine(hayvanlar[1]);
Console.WriteLine(dizi[3]);
Console.WriteLine(renkler[0]);

// Döngülerle Dizi Kullanımı
// Klavyeden girilen n tane sayının ortalamasını hesaplayan program
Console.Write("Lütfen dizinin eleman sayisini giriniz: ");
int diziUzunlugu = int.Parse(Console.ReadLine());
int[] sayiDizisi = new int[diziUzunlugu];

for (int i = 0; i < diziUzunlugu; i++)
{
    Console.Write("Lütfen {0}. sayısı giriniz: ", i + 1);
    sayiDizisi[i] = int.Parse(Console.ReadLine());
}

int toplam = 0;
foreach (var sayi in sayiDizisi)
    toplam += sayi;

Console.WriteLine("Ortalama : " + toplam / diziUzunlugu);











// Hacker rank çözümü

int diziUzunlugu1 = int.Parse(Console.ReadLine());
int[] sayiDizisi1 = new int[diziUzunlugu1];

for (int i = 0; i < diziUzunlugu1; i++)
{
      sayiDizisi1[i] = int.Parse(Console.ReadLine());
}
   
            var positiveNumbers = 0;
            var negativeNumbers = 0;
            var zeroNumbers = 0;
            int arraylength = sayiDizisi1.Count();

            for (int i = 0; i < sayiDizisi1.Count(); i++)
            {
                if (sayiDizisi1[i] > 0)
                    positiveNumbers++;
                else if (sayiDizisi1[i] < 0)
                    negativeNumbers++;
                else
                    zeroNumbers++;
            }
           
            Console.WriteLine(Math.Round((double)positiveNumbers / arraylength, 6));
            Console.WriteLine(Math.Round((double)negativeNumbers / arraylength,6));
            Console.WriteLine(Math.Round((double)zeroNumbers / arraylength, 6 ));
    