using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace С_seminars
{
    public class Class1
    {
        public static void Main(string[] args)
        {
            FamilyMembers GrandFatherOne = new FamilyMembers()
            {
                FullName = "Salo Nikolay",
                Age = 68,
                Gender = Gender.male
            };
            FamilyMembers GrandFatherSecond = new FamilyMembers()
            {
                FullName = "Viznuk Vladimir",
                Age = 65,
                Gender = Gender.male
            };
            FamilyMembers GrandMotherOne = new FamilyMembers()
            {
                FullName = "Salo Elizaveta",
                Age = 64,
                Gender = Gender.female
            };
            FamilyMembers GrandMotherSecond = new FamilyMembers()
            {
                FullName = "Viznuk Tatiana",
                Age = 62,
                Gender = Gender.female
            };
            
            FamilyMembers Mother = new FamilyMembers()
            {
                FullName = "Salo Elena",
                Age = 47,
                Gender = Gender.female,
                Father = GrandFatherSecond,
                Mother = GrandMotherSecond
            };
            FamilyMembers Father = new FamilyMembers()
            {
                FullName = "Salo Maksim",
                Age = 50,
                Gender = Gender.male,
                Father = GrandFatherOne,
                Mother = GrandMotherOne
            };
            FamilyMembers Son = new FamilyMembers()
            {
                FullName = "Salo Daniil",
                Age = 23,
                Gender = Gender.male,
                Mother = Mother,
                Father = Father
            };

             var GrandMothers = Son.GetGrandMother();


            Console.WriteLine($"Мать {Mother.FullName} для {Son.FullName}");
            Console.WriteLine($"Отец {Father.FullName} для {Son.FullName}");

        }
    }
}
