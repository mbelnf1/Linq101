using System;
using System.Collections.Generic;
using LinqLibrary;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq101
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = ListManager.LoadSampleData();

            //people = people.OrderByDescending(x => x.LastName).ThenBy(x => x.YearsExperience).ToList();
            people = people.Where(x => x.YearsExperience > 9).ToList();
            foreach (var person in people)
            {
                Console.WriteLine($"{ person.FirstName } {person.LastName } ({ person.Birthday.ToShortDateString() }): Experience { person.YearsExperience }");
            }

            Console.ReadLine();
        }
    }
}
