using _1.Linq.DataAccess;
using _1.Linq.ExtentionMethods;

namespace _1.Linq;

using static Console;

// LINQ => Generic Extention methodlar toplusu




public class Program
{
    static void Main(string[] args)
    {

        IEnumerable<int> numbers = new List<int> { 1, 5, 65, 15, 45, 25, 5, 25 };
        List<int> numbers2 = new List<int> { 1, 5, 65, 15, 45, 25, 5, 25 };


        // Listim unique olsun

        // numbers = numbers.Distinct();
        // 
        // foreach (var item in numbers)
        // {
        //     Console.WriteLine(item);
        // }

        // Task: Print Method extention

        // numbers.Distinct().Print();

        // Console.WriteLine(numbers.Min());
        // Console.WriteLine(numbers.Max());
        // Console.WriteLine(numbers.Average());

        // numbers2.FindAll(x => x >= 45).Print();


        // Class ile islemek

        var students = DB.GetStudents();

        // students.PrintGeneric();


        // var students2 = students.AsReadOnly();

        // Score 10-dan yuxari olanlari alim. FindAll

        // students.FindAll(x => x.Score > 10).PrintGeneric();


        ////////////////////////////////////////////////
        // Select

        // students.Select(x => x.Score).PrintGeneric();

        // Task: Telebelerin Ad Soyadi geri qaytarmaq lazimdir

        // students.Select(x => (x.Name, x.Surname)).PrintGeneric();

        ////////////////////////////////////////////////

        // Aggregate Linq methodlar

        // Console.WriteLine(students.Min(x => x.Score));
        // Console.WriteLine(students.Max(x => x.Score));
        // Console.WriteLine(students.Average(x => x.Score));
        // Console.WriteLine(students.Sum(x => x.Score));

        ////////////////////////////////////////////////

        // FirstOrDefaul, SingleOrDefault

        // WriteLine(students.First(x => x.Score > 12));
        // WriteLine(students.FirstOrDefault(x => x.Score > 12));
        // WriteLine(students.Last());
        // WriteLine(students.LastOrDefault(x => x.Score > 12));

        // WriteLine(students.Single(x => x.Score == 11.5));
        // WriteLine(students.SingleOrDefault(x => x.Score > 12));
        //WriteLine(students.SingleOrDefault(x => x.Score == 11.5));

        ////////////////////////////////////////////////
        /// Where 

        // students
        //     .Where(x => x.Score > 8)
        //     .PrintGeneric();
        // 
        // 
        // WriteLine();
        // 
        // students
        //     .Where(x => x.Score > 8)
        //     .Skip(2)
        //     .Take(2)
        //     .PrintGeneric();


        students
            .Where(x => x.Score > 8)
            .OrderBy(x => x.Score)
            //.OrderByDescending(x => x.Score)
            .PrintGeneric();



    }
}
