//struct Data
//{
//    public int day, month, year;
//    public Data(int dd, int mm, int yy)
//    {
//        day = dd;
//        month = mm;
//        year = yy;
//    }
//}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaAlgoritms1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person me = new Person("Vova", "Chakov", "Vladimirovich", "M", "dom16", 943255);
            Console.WriteLine("");
            Person[] person1 = new Person[0];
            Console.WriteLine(person1.);
            AddPerson(person1, me);
        }
        Person[] AddPerson(ref Person[] persons, Person newPerson)
        {
            int newLength = persons.Length + 1;
            Person[] result = new Person[newLength];
            for (int i = 0; i < persons.Length; i++)
            {
                result[i] = persons[i];
            }
            result[newLength - 1] = newPerson;
            return result;
        }
    }
  
    struct Personal
    {
        public string name, surname, sursurname;       
    }
    struct Info
    {
        public string adres;
        public int tnumber;
    }
    struct Person
    {
        Personal pers;
        string sex;
        Info info;
        public Person(string a, string b, string c, string d, string e, int g)
        {
            pers.name = a;
            pers.surname = b;
            pers.sursurname = c;
            sex = d;
            info.adres = e;
            info.tnumber = g;
        }
        //public Person[] AddPerson(Person[] persons, Person newPerson)
        //{
        //    int newLength = persons.Length + 1;
        //    Person[] result =new Person[newLength];
        //    for(int i=0;i<persons.Length;i++)
        //    {
        //        result[i] = persons[i];
        //    }
        //    result[newLength - 1] = newPerson;
        //    return result;
        //}
        public void DeletePerson()
        {

        }
        public void EditPerson()
        {

        }
        public string ToShortString()
        {
            string s = "Name: " + pers.name + "\r\n Surname: "
                + pers.surname + "\r\n SurSurName: " + pers.sursurname +
                "\r\n Sex: " + sex + "\r\n Adres: " + info.adres + "\r\n TNumber: " + info.tnumber;
            return s;
        }
    }
}
