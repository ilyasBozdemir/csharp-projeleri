using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voting_Uygulamasi
{
    public class Categories
    {
        public List<Dictionary<string, int>> categoriList { get;  set; }
        //List'in static olmasına gerek yok

        private Dictionary<string, int> filmVoting, sporVoting, techStackVoting;

        public Dictionary<string, int> FilmVoting
        {
            get => filmVoting;
            private set => filmVoting = value;
        }
        public Dictionary<string, int> SporVoting
        {
            get => sporVoting;
            private set => sporVoting = value;
        }
        public Dictionary<string, int> TechStackVoting
        {
            get => techStackVoting;
            private set => techStackVoting = value;
        }

        public Categories()
        {
            filmVoting = new Dictionary<string, int>();
            sporVoting = new Dictionary<string, int>();
            techStackVoting = new Dictionary<string, int>();

            filmVoting.Add("The Suicide Squad: İntihar Timi", 0);
            filmVoting.Add("Dune", 0);
            filmVoting.Add("Gerçek Kahraman", 0);

            sporVoting.Add("Hokey", 0);
            sporVoting.Add("Eskrim", 0);
            sporVoting.Add("Futbol", 0);

            techStackVoting.Add("Pinterest", 0);
            techStackVoting.Add("Uber Technologies", 0);
            techStackVoting.Add("LaunchDarkly", 0);

            categoriList = new List<Dictionary<string, int>>();
            categoriList.Add(filmVoting);
            categoriList.Add(sporVoting);
            categoriList.Add(techStackVoting);

        }
    }

}
