using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 1
        Console.WriteLine("Merhaba");
        Console.WriteLine("Nasılsın?");
        Console.WriteLine("İyiyim");
        Console.WriteLine("Sen nasılsın?");


        // 2
        string metin = "Merhaba";
        int sayi = 15;
        Console.WriteLine($"{metin} {sayi}");


        // 3
        Random rnd = new Random();
        Console.WriteLine(rnd.Next());


        // 4
        Console.WriteLine($"3'e bölümünden kalan: {rnd.Next() % 3}");


        // 5
        Console.Write("Yaşınızı Girin: ");
        int yas = int.Parse(Console.ReadLine());
        Console.WriteLine(yas > 18 ? "+" : "-");


        // 6
        for (int i = 0; i < 10; i++)
            Console.WriteLine("Sen Vodafone gibi anı yaşarken, ben Turkcell gibi seni her yerde çekemem.");


        // 7
        Console.Write("İlk ismi girin: ");
        string firstName = Console.ReadLine();
        Console.Write("İkinci ismi girin: ");
        string secondName = Console.ReadLine();
        (firstName, secondName) = (secondName, firstName);
        Console.WriteLine($"İlk isim: {firstName}\nİkinci isim: {secondName}");


        // 8
        static void BenDegerDondurmem()
        {
            Console.WriteLine("Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma");
        }
        BenDegerDondurmem();


        // 9

        Console.Write("Birinci sayıyı girin: ");
        int say1 = int.Parse(Console.ReadLine());
        Console.Write("İkinci sayıyı girin: ");
        int say2 = int.Parse(Console.ReadLine());
        Console.WriteLine($"Toplam: {Topla(say1, say2)}");
        static int Topla(int a, int b)
        {
            return a + b;
        }

        // 10
        Console.Write("True veya false girin: ");
        bool kg = bool.Parse(Console.ReadLine());
        Console.WriteLine(BooleanToString(kg));
        static string BooleanToString(bool value)
        {
            return value ? "Kullanıcı true değerini girdi." : "Kullanıcı false değerini girdi.";
        }

        // 11
        Console.Write("Birinci kişinin yaşını girin: ");
        int age1 = int.Parse(Console.ReadLine());
        Console.Write("İkinci kişinin yaşını girin: ");
        int age2 = int.Parse(Console.ReadLine());
        Console.Write("Üçüncü kişinin yaşını girin: ");
        int age3 = int.Parse(Console.ReadLine());
        Console.WriteLine($"En yaşlı kişinin yaşı: {FindOldestAge(age1, age2, age3)}");
        static int FindOldestAge(int age1, int age2, int age3)
        {
            return Math.Max(age1, Math.Max(age2, age3));
        }


        // 12
        List<int> numbers = new List<int>();
        Console.WriteLine("Sayıları girin (bitirmek için 'q' tuşuna basın):");
        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "q")
                break;

            if (int.TryParse(input, result: out int sayıa))
                numbers.Add(sayıa);
            else
                Console.WriteLine("Geçersiz giriş.");
        }
        Console.WriteLine(numbers.Count > 0 ? $"En büyük sayı: {FindMax(numbers)}" : "Hiç sayı girilmedi.");
        static int FindMax(List<int> numbers)
        {
            int max = numbers[0];
            foreach (int number in numbers)
                if (number > max)
                    max = number;
            return max;
        }

        // 13
        Console.Write("Birinci ismi girin: ");
        string name1 = Console.ReadLine();
        Console.Write("İkinci ismi girin: ");
        string name2 = Console.ReadLine();
        (name1, name2) = (name2, name1);
        Console.WriteLine($"Birinci isim: {name1}\nİkinci isim: {name2}");


        // 14
        Console.Write("Bir sayı girin: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(IsEven(number));
        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        // 15
        Console.Write("Hızı girin (km/s): ");
        double speed = double.Parse(Console.ReadLine());
        Console.Write("Zamanı girin (saat): ");
        double time = double.Parse(Console.ReadLine());
        Console.WriteLine($"Gidilen yol: {CalculateDistance(speed, time)} km");
        static double CalculateDistance(double speed, double time)
        {
            return speed * time;
        }

        // 16
        Console.Write("Yarıçapı girin: ");
        double radius = double.Parse(Console.ReadLine());
        Console.WriteLine($"Dairenin alanı: {CalculateArea(radius)}");
        static double CalculateArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        // 17
        string sentence = "Zaman bir GeRi SayIm";
        Console.WriteLine($"Büyük harflerle: {sentence.ToUpper()}\nKüçük harflerle: {sentence.ToLower()}");


        // 18
        string text = "    Selamlar   ";
        Console.WriteLine($"Düzenlenmiş metin: '{text.Trim()}'");

    }
}







