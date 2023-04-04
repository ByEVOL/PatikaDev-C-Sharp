//while 
// 1 den başlayarak console den girilen sayıya kadar (sayı dahil) ortalama hesaplayıp console a yazdıran program
Console.Write("Lütfen bir sayi giriniz: ");
int sayi = int.Parse(Console.ReadLine());
int sayac = 1;
int toplam = 0;
while (sayac <= sayi)
{
    toplam+=sayac;
    sayac++;
}
Console.WriteLine(toplam/sayi);



// 'a' dan 'z' ye kadar tüm harfleri console a yazdır
char character = 'a';
while (character <= 'z')
{
    Console.WriteLine(character);
    character++;
}



// foreach ile dizidekileri yazdırma
Console.Write("**** Forech ****");
string[] arabalar = {"BMV","Ford","Toyota","Nissan"};
foreach (var araba in arabalar)
{
    Console.WriteLine(araba);
}
