String degisken = "Dersimiz CSharp, Hoşgeldiniz!";
string degisken2 = "dersimiz CSharp, Hoşgeldiniz!";

// Length -karakter sayısını verir
Console.WriteLine(degisken.Length);

// ToUpper, ToLower -karakterleri büyük yada küçük yazar
Console.WriteLine(degisken.ToUpper());
Console.WriteLine(degisken.ToLower());

// Concat -birleştirme
Console.WriteLine(String.Concat(degisken," Merhaba"));

// Compara, CompareTo -karakter karşılaştırma
Console.WriteLine(degisken.CompareTo(degisken2)); // Doğru ise 1, yanlış ise 0 eksik ise -1 döndürür
Console.WriteLine(string.Compare(degisken,degisken2,true)); // büyük küçük harf duyarlı
Console.WriteLine(string.Compare(degisken,degisken2,false)); // büyük küçük harf duyarsız

// Constains -kelimelerin içindekileri arar
Console.WriteLine(degisken.Contains(degisken2));
Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!"));
Console.WriteLine(degisken.StartsWith("Merhaba!"));

// indexOf -kelimelerin harf olarak arar
Console.WriteLine(degisken.IndexOf("CS"));
Console.WriteLine(degisken.IndexOf("Ziktirye"));
Console.WriteLine(degisken.LastIndexOf("i"));

// insert -indesk ile kelimelere ekleme yapabilir
Console.WriteLine(degisken.Insert(0,"Merhaba! "));

// Padleft, Padright -kelimenin sonuna yada başına belirtilen karakterleri ekleme
Console.WriteLine(degisken + degisken2.PadLeft(30));
Console.WriteLine(degisken + degisken2.PadLeft(30, '*'));
Console.WriteLine(degisken.PadRight(50) + degisken2);
Console.WriteLine(degisken.PadRight(50,'-') + degisken2);

// Remove -silme işlemi
Console.WriteLine(degisken.Remove(10));
Console.WriteLine(degisken.Remove(5,3)); //5. indesk sonrası 3 tane sil
Console.WriteLine(degisken.Remove(0,1));

// Replace -değiştirme
Console.WriteLine(degisken.Replace("CSharp","C#"));
Console.WriteLine(degisken.Replace(" ","*"));

// Split -kelimeleri bölük dizi oluşturma
Console.WriteLine(degisken.Split(' ')[1]);

// Substring -istediğin indeksten başlatıp yazdırma
Console.WriteLine(degisken.Substring(4));
Console.WriteLine(degisken.Substring(4,6));