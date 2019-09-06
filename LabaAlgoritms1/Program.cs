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
            Console.WriteLine("");
        }
    }
  
    struct Personal
    {
        public string name, surname, sursurname;       
    }
  
    struct Person
    {
        Personal pers;
        bool sex;
        public Person(string a, string b, string c, bool d)
        {
            pers.name = a;
            pers.surname = b;
            pers.sursurname = c;
            sex = d;
        }
        public void AddPerson(params Person[] persons)
        {
            for (int i = 0; i < persons.Length; i++)
            {
                
            }
        }
        public void DeletePerson()
        {

        }
        public void EditPerson()
        {

        }
    }
}
