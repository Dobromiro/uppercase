using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppercase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sciezka = Directory.GetCurrentDirectory();

            try
            {
                string[] pliki = Directory.GetFiles(sciezka);

                foreach (string plik in pliki)
                {
                    string nazwaPliku = Path.GetFileName(plik);
                    string nowaNazwa = nazwaPliku.ToUpper();
                    string nowaSciezka = Path.Combine(Path.GetDirectoryName(plik), nowaNazwa);
                    File.Move(plik, nowaSciezka);
                    Console.WriteLine($"Zmieniono nazwę pliku: {plik} na {nowaNazwa}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Wystąpił błąd: {ex.Message}");
            }
            Console.ReadLine();
        }
    }

}
