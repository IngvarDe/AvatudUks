using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        while (true)
        {
            Console.Clear();

            Console.WriteLine("=== KOODI PURUSTAMINE ===");
            Console.WriteLine("Vali tase:");
            Console.WriteLine("1 - Caesar Cipher");
            Console.WriteLine("2 - Sõnum tagurpidi");
            Console.WriteLine("3 - ASCII koodid");
            Console.WriteLine("4 - Parooli kontroll");
            Console.WriteLine("0 - Välju");

            string valik = Console.ReadLine();

            switch (valik)
            {
                case "1":
                    CaesarCipher();
                    break;

                case "2":
                    ReverseMessage();
                    break;

                case "3":
                    AsciiCodes();
                    break;

                case "4":
                    PasswordCheck();
                    break;

                case "0":
                    Console.WriteLine("Head aega!");
                    return;

                default:
                    Console.WriteLine("Vale valik!");
                    break;
            }

            Console.WriteLine("\nVajuta suvalist klahvi, et minna tagasi menüüsse...");
            Console.ReadKey();
        }
    }

    //Caesar Cipher (Eesti tähestikuga)
    static void CaesarCipher()
    {
        Console.Clear();

        string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZÕÄÖÜ";

        Console.WriteLine("=== CAESAR CIPHER ===");
        Console.WriteLine("Sisesta sõnum:");
        string input = Console.ReadLine().ToUpper();

        Console.WriteLine("Sisesta nihke suurus:");
        int shift = int.Parse(Console.ReadLine());

        string result = "";

        foreach (char c in input)
        {
            if (alphabet.Contains(c))
            {
                int index = alphabet.IndexOf(c);
                int newIndex = (index - shift) % alphabet.Length;

                if (newIndex < 0)
                    newIndex += alphabet.Length;

                result += alphabet[newIndex];
            }
            else
            {
                result += c;
            }
        }

        Console.WriteLine("Tulemus: " + result);
    }

    //Sõnum tagurpidi
    static void ReverseMessage()
    {
        Console.Clear();

        Console.WriteLine("=== TAGURPIDI SÕNUM ===");
        Console.WriteLine("Sisesta sõnum:");
        string input = Console.ReadLine();

        char[] array = input.ToCharArray();
        Array.Reverse(array);

        Console.WriteLine("Tagurpidi: " + new string(array));
    }

    //ASCII koodid
    static void AsciiCodes()
    {
        Console.Clear();

        Console.WriteLine("=== ASCII KOODID ===");
        Console.WriteLine("Sisesta sõnum:");
        string input = Console.ReadLine();

        Console.WriteLine("ASCII koodid:");

        foreach (char c in input)
        {
            Console.Write((int)c + " ");
        }

        Console.WriteLine();
    }

    //Parooli kontroll
    static void PasswordCheck()
    {
        Console.Clear();

        string secret = "KOOL123";

        Console.WriteLine("=== PAROOL ===");
        Console.WriteLine("Sisesta parool:");
        
        string guess = Console.ReadLine();

        if (guess == secret)
        {
            Console.WriteLine("Õige parool! Uks avaneb 🚪");
        }
        else
        {
            Console.WriteLine("Vale parool!");
            Console.WriteLine("Otsi koodist parool ülesse.");
        }
    }
}
