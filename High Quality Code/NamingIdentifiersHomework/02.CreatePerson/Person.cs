using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class People
{
    enum Gender { Male, Female };
    class Person
    {
        public Gender gender { get; set; }
        public string name { get; set; }
        public int age { get; set; }
    }
    public void CreatePerson(int age)
    {
        Person newPerson = new Person();
        newPerson.age = age;
        if (age % 2 == 0)
        {
            newPerson.name = "Батката";
            newPerson.gender = Gender.Male;
        }
        else
        {
            newPerson.name = "Мацето";
            newPerson.gender = Gender.Female;
        }
    }
}
