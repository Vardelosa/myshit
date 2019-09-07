
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaAlgoritms1
{

    struct Person
    {
        public string name, surname, sursurname;
        public string adres;
        public long tnumber;
        public string sex;
        public Person(string name, string surn, string sursurn, string sex, string ad, long tn)
        {
            this.name = name;
            surname = surn;
            sursurname = sursurn;
            this.sex = sex;
            adres = ad;
            tnumber = tn;
        }
        public static Person GenPeop(int i)
        {
            return new Person(i.ToString(), i.ToString(), i.ToString(), i.ToString(), i.ToString(), i);
        }
    }
    struct PersonList
    {
        public Person[] People { get; set; }
        public PersonList(params Person[] people)
        {
            People = people;
        }
        public void AddPerson(params Person[] people)
        {
            Person[] newPeople = new Person[People.Length + people.Length];
            for (int i = 0; i < People.Length; i++)
                newPeople[i] = People[i];
            for (int i = 0; i < people.Length; i++)
                newPeople[People.Length + i] = people[i];
            People = newPeople;
        }
        public void FindPerson(string surname)
        {
            Person pp = new Person();
            bool isPersonFounded = false;
            for(int i=0; i<People.Length;++i)
            {
                if(People[i].surname.ToLower() == surname.ToLower())
                {
                    pp = People[i];
                    isPersonFounded = true;
                    break;
                }
            }
            if(isPersonFounded)
            {
                Console.WriteLine($"Telephone number of {pp.surname} is {pp.tnumber}\n");
            }
            else
            {
                Console.WriteLine($"None person founded with surname {surname}");
            }
        }
        public Person[] DeletePerson(int n)
        {
            Person[] newPeople = new Person[People.Length-1];
            int ii = 0;
            for(int i=0 ; i<People.Length;i++)
            {
                if(i==n)
                {
                    continue;
                }
                newPeople[ii] = People[i];
                ii++;
            }
            return newPeople;
        }
        public int Count()
        {
            int n = 0;
            n++;
            return n;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PersonList peoplelist = InitPeopList();
            Console.WriteLine("People DataBase: \n\n");
            ConsoleKey button = ConsoleKey.P;
            do
            {
                Console.WriteLine("Choose what do you want to do:\n" +
                    "Press A: to add a person\n" +
                    "Press B: to find a person\n" +
                    "Press C: to show the list\n" +
                    "Press D: to delete a person\n"+
                    "Press E: to exit\n" +"\n\n");
                button = Console.ReadKey().Key;
                switch(button)
                {
                    case ConsoleKey.A:
                    AddPerson(ref peoplelist);
                    break;
                    case ConsoleKey.B:
                    FindPerson(ref peoplelist);
                    break;
                    case ConsoleKey.E:
                    break;
                    case ConsoleKey.C:
                        ShowTheList(ref peoplelist);
                        break;
                    case ConsoleKey.D:
                        DeletePerson(ref peoplelist);
                        break;

                }
            }
            while (button != ConsoleKey.E);
        }
        static void AddPerson(ref PersonList peoplelist)
        {
                Person p1 = new Person();
                Console.Clear();
                Console.WriteLine("Please, follow the instructions and fill gaps. Enter the name: ");
                p1.name = Console.ReadLine(); 
                Console.WriteLine("Surname: ");
                p1.surname = Console.ReadLine(); 
                Console.WriteLine("SurSurName: ");
                p1.sursurname = Console.ReadLine(); 
                Console.WriteLine("Sex: ");
                p1.sex = Console.ReadLine(); 
                Console.WriteLine("Adres: ");
                p1.adres = Console.ReadLine(); 
                Console.WriteLine("Telephone number: ");
                string telephone = Console.ReadLine();
                long number;
                bool success = Int64.TryParse(telephone, out number);
            if (success)
            {
                p1.tnumber=number;
                peoplelist.AddPerson(p1);
                peoplelist.Count();
                Console.WriteLine("Person is added to Database\n");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid telephone number! Try again.");
            }             
                
        }
        static void FindPerson(ref PersonList peoplelist)
        {
            Console.Clear();
            Console.WriteLine("Please enter surname of the person that you want to find:");
            string find = Console.ReadLine();
            peoplelist.FindPerson(find);
        }
        static void DeletePerson(ref PersonList personList)
        {
            Console.Clear();
            ShowTheList(ref personList);
            Console.WriteLine("Please, enter index of person that you want to delete:");
            string n = Console.ReadLine();
            int index;
            bool success = Int32.TryParse(n, out index);
            if(success)
            {
                if (index > personList.Count())
                {
                    Console.WriteLine("There is no person with such index.\n");
                }
                else
                {
                    personList.DeletePerson(index + 4);
                    Console.Clear();
                    Console.WriteLine("Person is deleted.\n");

                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid index! Try again.");
            }

        }
        static PersonList InitPeopList()
        {
            Person[] pl = new Person[5];
            for(int i=0; i<pl.Length;++i)
            {
                pl[i] = Person.GenPeop(i+1);
            }
            PersonList ps = new PersonList(pl);
            return ps;
        }
        static void ShowTheList(ref PersonList peoplelist)
        {
            Console.Clear();
            Console.WriteLine("List of people:");
            if (peoplelist.People.Length > 5)
            {
                for (int i = 0; i < peoplelist.People.Length; ++i)
                {
                    if (i > 4)
                    {
                        Console.WriteLine(i-4 + ")" + peoplelist.People[i].surname);
                    }
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("No people was added.\n");
            }
        }
    }
}
