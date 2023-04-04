int month = DateTime.Now.Month;

switch (month)
{
    // tek tek case belirleme
    case 12:
        Console.WriteLine("Aralık Ayındasınız!");
        break;
    case 1:
        Console.WriteLine("Ocak Ayındasınız!");
        break;
    case 3:
        Console.WriteLine("Mart Ayındasınız!");
        break;
    case 2:
        Console.WriteLine("Şubat Ayındasınız!");
        break;

    default:
        Console.WriteLine("Yanlış Veri Girişi!");
        break;
}

switch (month)
{
    case 12:
    case 1:
    case 2:
        Console.WriteLine("Kış Ayındasınız");
        break;

    case 3:
    case 4:
    case 5:
        Console.WriteLine("İlk Bahardasınız!");
        break;

    default:
        break;
}