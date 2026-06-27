using _1.Linq.Models;
using System.Collections;

namespace _2.Discard;

// Discard => syntax _



public class Program
{
    public static (int number, string name) Foo() => (20, "Xayyam");
    public static int Boo() => 20;
    public static Student GetInfo() => new Student
    {
        Id = 1,
        Name = "Xayyam",
        Surname = "Qasimov",
        Age = 19,
        Score = 10
    };


    static void Main(string[] args)
    {
        (int number, string name) data = Foo();
        (int number, string name) data2 = Foo();

        // Console.WriteLine(data.number);
        // _ = data2.name;

        int number = 15;

        _ = 50;
        _ = "50";
        _ = new Student();

        _ = new int[] { 1, 2, 3, 4, 5 };

        number += 10;

        _ = Foo();

        // _ += 10;
        // Console.WriteLine(_);

        (int _, string name) data3 = Foo();

        _ = Boo();

        var studentInfo = GetInfo();

        Console.WriteLine(studentInfo);

        // Boxing, UnBoxing

        // int number5 = 5;
        // 
        // object number6 = 6; // Boxing => GC yukleyirem
        // 
        // int data6 = (int)number6; // UnBoxing
        // Console.WriteLine(data6);
        // 
        // 
        // // Heap => CLR, Gabage Collector 

        





    }
}
