using System;
using System.IO;

namespace Sajat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Üdvözöllek a Szövegfájl Szerkesztőben!");

            string filePath = GetFilePath();

            if (!File.Exists(filePath))
            {
                Console.WriteLine("A fájl nem található. Új fájlt hozunk létre.");
                CreateNewFile(filePath);
            }

            while (true)
            {
                Console.WriteLine("Válassz egy műveletet:");
                Console.WriteLine("1. Fájl tartalmának megjelenítése");
                Console.WriteLine("2. Fájl szerkesztése");
                Console.WriteLine("3. Kilépés");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        DisplayFileContents(filePath);
                        break;
                    case 2:
                        EditFile(filePath);
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("Érvénytelen választás!");
                        break;
                }

                Console.WriteLine();
            }
        }

        static string GetFilePath()
        {
            Console.Write("Kérem adja meg a fájl elérési útvonalát és nevét: ");
            return Console.ReadLine();
        }

        static void CreateNewFile(string filePath)
        {
            using (StreamWriter writer = File.CreateText(filePath))
            {
                Console.WriteLine("Az új fájl létrehozva.");
            }
        }

        static void DisplayFileContents(string filePath)
        {
            using (StreamReader reader = File.OpenText(filePath))
            {
                Console.WriteLine("A fájl tartalma:");
                Console.WriteLine(reader.ReadToEnd());
            }
        }

        static void EditFile(string filePath)
        {
            Console.WriteLine("Kérem írja be a szerkesztendő szöveget. Nyomjon Entert a befejezéshez.");

            using (StreamWriter writer = File.AppendText(filePath))
            {
                string input = Console.ReadLine();

                while (!string.IsNullOrEmpty(input))
                {
                    writer.WriteLine(input);
                    input = Console.ReadLine();
                }
            }

            Console.WriteLine("A fájl sikeresen szerkesztve.");
        }
    }
}