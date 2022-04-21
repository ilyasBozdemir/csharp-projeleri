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

        public void WriteConsole(Dictionary<string, int> Voting,string categoryName)
        {
            byte sayac = 0, secim = 0;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
            Console.WriteLine($"Aşağıdaki {categoryName} birisini seçin");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var item in Voting)
            {
                sayac++;
                Console.WriteLine($"{item.Key} için {sayac} tuşlayın");
                //categories.FilmVoting[item.Key] = 1;
            }
        }

        public void GetVotingResult()
        {
          
        }
    }
}
