using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

namespace ConsoleApp1
{
    public class LinqFuncs
    {
        public List<Bukhgalter> InsertIntoBukhgalters()
        {
            List<Bukhgalter> bukhgalters = new List<Bukhgalter>()
            {
                new Bukhgalter { id = 1, name = "Abdulloh", age = 23, programmingLanguage_id = 1 },
                new Bukhgalter { id = 2, name = "Eldor", age = 18, programmingLanguage_id = 4 },
                new Bukhgalter { id = 3, name = "Jamshid", age = 31, programmingLanguage_id = 1 },
                new Bukhgalter { id = 4, name = "Sulton", age = 20, programmingLanguage_id = 2 },
                new Bukhgalter { id = 5, name = "Ilyos", age = 27, programmingLanguage_id = 2 },
                new Bukhgalter { id = 6, name = "Karim", age = 40, programmingLanguage_id = 2 },
                new Bukhgalter { id = 7, name = "Salim", age = 21, programmingLanguage_id = 3 },
                new Bukhgalter { id = 8, name = "Baxrom", age = 22, programmingLanguage_id = 4 },
                new Bukhgalter { id = 9, name = "Olim", age = 25, programmingLanguage_id = 1 },
                new Bukhgalter { id = 10, name = "Husan", age = 26, programmingLanguage_id = 3 },
            };

            return bukhgalters;
        }

        public List<ProgrammingLanguage> InsertIntoProgrammingLanguage()
        {
            List<ProgrammingLanguage> programmingLanguages = new List<ProgrammingLanguage>()
            {
                new ProgrammingLanguage {id = 1, programmingLanguage = "ThoseWhoDoNotKnow"},
                new ProgrammingLanguage {id = 2, programmingLanguage = "C#"},
                new ProgrammingLanguage {id = 3, programmingLanguage = "Java"},
                new ProgrammingLanguage {id = 4, programmingLanguage = "Python"},

            };

            return programmingLanguages;
        }
        public void FirstFunction()
        {
            var joinedData = InsertIntoBukhgalters()
                .Join(InsertIntoProgrammingLanguage(),
                b => b.programmingLanguage_id,
                pL => pL.id ,
                (b, pL) => new {b.name, pL.programmingLanguage})
                .Where(x => x.programmingLanguage == "C#");

            foreach (var item in joinedData)
            {
                Console.WriteLine($"{item.name} -> {item.programmingLanguage}");
            }
        }
    }
}
