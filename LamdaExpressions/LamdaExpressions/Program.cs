using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonDataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Person Data Management");
            DataManagement data = new DataManagement();
            List<Person> listPersonsInCity = new List<Person>();
            data.AddRecords(listPersonsInCity);
        }
    }
}