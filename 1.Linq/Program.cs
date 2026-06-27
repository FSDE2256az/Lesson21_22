using _1.Linq.DataAccess;
using _1.Linq.ExtentionMethods;

namespace _1.Linq;

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




    }
}
