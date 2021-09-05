using System;

namespace LINQProject
{
    class Program
    {
        /// <summary>
        /// main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LINQ Program");
            LinqExample.Demo();
            Console.WriteLine("------------------------");
            LinqExample.AddDataTable();
            Console.WriteLine("------------------------");
            LinqToEntities.Entities();
        }
    }
}
