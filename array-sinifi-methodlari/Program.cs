int[] sayiDizisi = { 23, 12, 4, 86, 72, 3, 11, 17 };

Console.WriteLine("-------Sırasız Dizi------");
foreach (var item in sayiDizisi)
{
    Console.WriteLine(item);
}

Console.WriteLine("-------Sıralı Dizi------");
Array.Sort(sayiDizisi);

foreach (var item in sayiDizisi)
{
    Console.WriteLine(item);
}


//Clear
Console.WriteLine("-------Array Clear------");
// sayiDizisi elemanlarını kullanarak 4. indexten (5. eleman) itibaren 3 tane elemanı 0lar

Array.Clear(sayiDizisi, 4, 3);
foreach (var item in sayiDizisi)
{
    Console.WriteLine(item);
}

//Reverse
Console.WriteLine("-------Array Reverse------");
// dizinin sırasını değiştirir  başı sona sonu başa getirir
Array.Reverse(sayiDizisi);
foreach (var item in sayiDizisi)
{
    Console.WriteLine(item);
}


//İndexOf
Console.WriteLine("-------Array IndexOf------");
Console.WriteLine(Array.IndexOf(sayiDizisi, 23));


//Resize
Console.WriteLine("-------Array Resize------");
// sayiDizisi boyutu 12 elemana çıkarıldı
Array.Resize<int>(ref sayiDizisi, 12);
// sayiDizisi 9.cu elemanı 99 olarak atandı  boş elemanalar 0 olarak atandı
sayiDizisi[8] = 99;

foreach (var item in sayiDizisi)
{
    Console.WriteLine(item);
}