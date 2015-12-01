using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanStudentWorker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentsList = new List<Student>()
            {
                new Student("John", "Atanasov" , "F123124"),
                new Student("Peter", "Ivanov" , "G111114"),
                new Student("Alkun", "Wolfram" , "ZZ00031"),
                new Student("Richard", "Gloom" , "3216498"),
                new Student("Steven", "King" , "Q231234"),
                new Student("Ivan", "Rusev" , "RT1231235"),
                new Student("Georgi", "Markov" , "FF441122"),
                new Student("Rangel", "Valchanov" , "FV13123511"),
                new Student("Maria", "Gerova" , "B0999112"),
                new Student("Zlatka", "Iordanova" , "VV1111111"),
            };

            List<Worker> workersList = new List<Worker>()
            {
                new Worker("Johny", "Bravo", 180m, 6),
                new Worker("Ben", "Ridley", 250m, 10),
                new Worker("John", "Green", 151m, 6),
                new Worker("Robert", "Dawny", 60m, 4),
                new Worker("Matt", "Goof", 600m, 4),
                new Worker("Andrea ", "Popetscu", 444m, 8),
                new Worker("Irving ", "Black", 110m, 8),
                new Worker("Susan", "Jacobs", 500m, 6),
                new Worker("Brian", "Duncan", 200m, 4),
                new Worker("Sebastian", "Monre", 900m, 8),
            };

            var orderedStudents = studentsList.OrderBy(x => x.FacultyNumber);
            var orderedWorkers = workersList.OrderBy(x => x.MoneyPerHour());

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Students: ");
            Console.ResetColor();

            foreach (var var     in orderedStudents)
            {
                Console.WriteLine(var.FirstName + " " + var.LastName + " " + var.FacultyNumber);
            }

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Workers: ");
            Console.ResetColor();

            foreach (var var     in orderedWorkers)
            {
                Console.WriteLine(var.FirstName + " " + var.LastName + " - "+
                    " {0:f2} $ (money per hour)",var.MoneyPerHour());
            }

            Console.WriteLine();

            var humansList = new List<Human>().Concat(workersList).Concat(studentsList);

            IEnumerable<Human> orderedHumans = 
                humansList
                .OrderBy(x => x.FirstName)
                .ThenBy(y => y.LastName);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Humans: ");
            Console.ResetColor();

            foreach (var var in orderedHumans)
            {
                Console.WriteLine(var.FirstName + " " + var.LastName);
            }
        }
    }
}
