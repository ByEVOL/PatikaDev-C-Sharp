Console.WriteLine(DateTime.Now); // şuan ki zamanı getirir
Console.WriteLine(DateTime.Now.Date);
Console.WriteLine(DateTime.Now.Day);
Console.WriteLine(DateTime.Now.Month);
Console.WriteLine(DateTime.Now.Year);
Console.WriteLine(DateTime.Now.Hour);
Console.WriteLine(DateTime.Now.Minute);
Console.WriteLine(DateTime.Now.Second);

Console.WriteLine(DateTime.Now.DayOfWeek); // bu haftanın kaçıncı günü
Console.WriteLine(DateTime.Now.DayOfYear); // bu yılın kaçıncı günü

Console.WriteLine(DateTime.Now.ToLongDateString);
Console.WriteLine(DateTime.Now.ToShortDateString);
Console.WriteLine(DateTime.Now.ToLongTimeString);
Console.WriteLine(DateTime.Now.ToShortTimeString);

// tarihlere ekleme yapma
Console.WriteLine(DateTime.Now.AddDays(2));
Console.WriteLine(DateTime.Now.AddHours(3));
Console.WriteLine(DateTime.Now.AddSeconds(30));
Console.WriteLine(DateTime.Now.AddMonths(5));
Console.WriteLine(DateTime.Now.AddYears(10));
Console.WriteLine(DateTime.Now.AddMilliseconds(50));

// tarih formatları
Console.WriteLine(DateTime.Now.ToString("dd")); // 24
Console.WriteLine(DateTime.Now.ToString("ddd")); // Sat
Console.WriteLine(DateTime.Now.ToString("dddd")); // Saturday

Console.WriteLine(DateTime.Now.ToString("MM")); // 04
Console.WriteLine(DateTime.Now.ToString("MMM")); // Apr
Console.WriteLine(DateTime.Now.ToString("MMMM")); // April

Console.WriteLine(DateTime.Now.ToString("yy")); // 21
Console.WriteLine(DateTime.Now.ToString("yyyy")); // 2021

// Math kütüphanesi
Console.WriteLine(Math.Abs(-25)); // 25;
Console.WriteLine(Math.Sin(10)); 
Console.WriteLine(Math.Cos(10)); 
Console.WriteLine(Math.Tan(10)); 

Console.WriteLine(Math.Ceiling(22.3)); // 23 yukarı yuvarlar
Console.WriteLine(Math.Round(22.3)); // 22 ortalamaya göre yuvarlar
Console.WriteLine(Math.Round(22.7)); // 23 ortalamaya göre yuvarlar
Console.WriteLine(Math.Floor(22.7)); // 22 aşağı yuvarlar

Console.WriteLine(Math.Max(2,6)); // 6 verir
Console.WriteLine(Math.Min(2,6)); // 2 verir

Console.WriteLine(Math.Pow(3,4)); // 3^4 ü verir 81 
Console.WriteLine(Math.Sqrt(9)); // karekök alır 3 
Console.WriteLine(Math.Log(9)); // 9 un e tabanındaki logoritmi karşılığını getirir
Console.WriteLine(Math.Exp(3)); // e üzeri 3 ü verir
Console.WriteLine(Math.Log10(10)); // 10 sayısının logatirma 10 tabanındaki karşılığı