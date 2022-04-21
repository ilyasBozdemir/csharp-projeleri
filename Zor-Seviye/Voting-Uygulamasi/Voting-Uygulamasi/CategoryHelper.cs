using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voting_Uygulamasi
{
    public class CategoryHelper
    {
        private Categories _categories;
        public CategoryHelper(Categories categories)
        {
            this._categories = categories;
        }

        public void WriteConsole(Dictionary<string, int> Voting, string categoryName)
        {
basla:
            byte sayac = 0, secim = 0;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
            Console.WriteLine($"Aşağıdaki {categoryName} birisini seçin");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var item in Voting)
            {
                sayac++;
                Console.WriteLine($"\"{item.Key}\" için {sayac} tuşlayın");
                //categories.FilmVoting[item.Key] = 1;
            }
            Console.WriteLine($"Yukarıda ki {categoryName} kategorilerinden birisini seçin: ");
            secim = byte.Parse(Console.ReadLine());
            if (secim > 0 && secim <= sayac)
            {
                byte i = 0;
                //Console.WriteLine($"{secim} - {sayac}");
                foreach (var item in Voting)
                {
                    i++;
                    if (secim == i)
                    {
                        Voting[item.Key] += 1;
                        Console.WriteLine($"Oy Verildi : {item.Key}");
                    }
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Lütfen Listeden Seçim Yapın.");
                goto basla;
            }
        }
        public void GetVotingResult()
        {
            Console.WriteLine();
            Console.WriteLine("---Sonuçlar---");
            Console.WriteLine();
            int ToplamOy = toplamOyGetir(_categories.FilmVoting);
            foreach (var item in _categories.FilmVoting)
            {
                string key = item.Key;
                int value = item.Value;
                string data = $"{key} için toplam oy sayısı : {value}";
                double yuzdelik = (value * 100 / ToplamOy);
                Console.WriteLine(data + $" %{yuzdelik}");
            }
            Console.WriteLine();
            ToplamOy = toplamOyGetir(_categories.SporVoting);
            foreach (var item in _categories.SporVoting)
            {
                string key = item.Key;
                int value = item.Value;
                string data = $"{key} için toplam oy sayısı : {value}";
                double yuzdelik = (value * 100 / ToplamOy);
                Console.WriteLine(data + $" %{yuzdelik}");
            }
            Console.WriteLine();
            ToplamOy = toplamOyGetir(_categories.TechStackVoting);
            foreach (var item in _categories.TechStackVoting)
            {
                string key = item.Key;
                int value = item.Value;
                string data = $"{key} için toplam oy sayısı : {value}";
                double yuzdelik = (value * 100 / ToplamOy);
                Console.WriteLine(data + $" %{yuzdelik}");
            }
        }

        private int toplamOyGetir(Dictionary<string, int> Voting)
        {
            int sayi = 0;
            foreach (var item in Voting)
            {
                sayi += item.Value;
            }
            return sayi;
        }
    }
}
