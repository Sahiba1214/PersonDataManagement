using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonDataManagement
{
    public class DataManagement
    {
        public void AddRecords(List<Person> listPersonsInCity)
        {
            listPersonsInCity.Add(new Person("173012021", "Sahiba", "Fatma, Manali", 21));
            listPersonsInCity.Add(new Person("173022021", "Mantasha", "Fatma, Shamil", 20));
            listPersonsInCity.Add(new Person("173032021", "Kashish", "Fatma, Patna", 65));
            listPersonsInCity.Add(new Person("173042021", "Enayat", "Abbas, Pune", 27));
            listPersonsInCity.Add(new Person("173052021", "Ayat", "Tatheer, Muzaffarpur", 80));
            listPersonsInCity.Add(new Person("173062021", "Yasin", "Ilyas, Gujarat", 40));
            listPersonsInCity.Add(new Person("173072021", "Batool", "Ilyas, Nasik", 21));
            listPersonsInCity.Add(new Person("173082021", "Fatma", "Bintey, Mumbai", 69));
            listPersonsInCity.Add(new Person("173092021", "Minu", "Fatma, Delhi", 24));
            listPersonsInCity.Add(new Person("173102021", "Rizwana", "Fatma, Varanasi", 44));
        }
        public void RetreivingTopTwoRecords_ForAgeIs_LessThanSixty(List<Person> listPersonsInCity)
        {
            Console.WriteLine("The Top 2 persons whose age less than 60 are : ");
            foreach (Person person in listPersonsInCity.FindAll(x => (x.Age < 60)).Take(2).ToList())
            {
                Console.WriteLine("Name : " + person.Name + "\t\tAge : " + person.Age);
            }
        }
        public void CheckingForTeenagerPerson(List<Person> listPersonsInCity)
        {
            Console.WriteLine("The Teenagers Persons in the list are : ");
            foreach (Person person in listPersonsInCity.FindAll(x => (x.Age >= 13 && x.Age < 19)).ToList())
            {
                Console.WriteLine("Name : " + person.Name + "\t\tAge : " + person.Age);
            }
        }
        public void RetrieveAverageAge(List<Person> listPersonsInCity)
        {
            double averageAge = listPersonsInCity.Average(x => x.Age);
            Console.WriteLine("The Average age of all Persons in the list are : " + averageAge);
        }
        public void CheckingForSpecificName(List<Person> listPersonsInCity)
        {
            Console.WriteLine("Enter the name you want to check in the list : ");
            string search = Console.ReadLine();
            if (listPersonsInCity.Exists(e => e.Name == search))
            {
                Console.WriteLine("Yes, The Name {0} is Present in the list", search);
            }
            else
            {
                Console.WriteLine("No, The Name {0} is not Present in the list", search);
            }
        }
    }
}

