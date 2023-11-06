using LINQExample.Extentions;
using LINQExample.Models;
using LINQ;
using LINQ.Exercise;

namespace LINQExample
{
    internal class Program
    {


        static void Main(string[] args)
        {
            MonkeyList Monkeys = new MonkeyList();
            Console.WriteLine(Monkeys);
            Console.WriteLine(Monkeys.SortByLocattionAndName());
        }
    }
}