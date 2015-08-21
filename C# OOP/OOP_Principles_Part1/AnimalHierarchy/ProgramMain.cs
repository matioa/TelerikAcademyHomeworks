using System;
using System.Collections.Generic;
using System.Linq;

namespace AnimalHierarchy
{
    class ProgramMain
    {
        static void Main()
        {
             Dog[] dogs = new Dog[] 
             { 
                 new Dog("Jaro", Animal.GenderValue.male,7), 
                 new Dog("Sharo", Animal.GenderValue.female, 3), 
                 new Dog("Doge", Animal.GenderValue.female,5), 
                 new Dog("Estel",Animal.GenderValue.male, 10) 
             }; 
 

             Frog[] frogs = new Frog[] 
             { 
                 new Frog("Kikirica",Animal.GenderValue.male, 13), 
                 new Frog("Jaba", Animal.GenderValue.female,15), 
                 new Frog("Froggy",Animal.GenderValue.male, 5), 
                 new Frog("Nikoleta Lozanova",Animal.GenderValue.female, 10) 
             }; 
 

             Cat[] cats = new Cat[]  
             { 
                 new Cat("Street Excellent",Animal.GenderValue.female, 3), 
                 new Cat("Home Excellent", Animal.GenderValue.female,5), 
                 new Cat("Persiiko", Animal.GenderValue.female,1), 
                 new Cat("Garfield",Animal.GenderValue.female,7) 
             }; 
 

             Kitten[] kittens = new Kitten[] 
             { 
                 new Kitten("Malcho", 1), 
                 new Kitten("Palcho", 2), 
                 new Kitten("Shalco", 1) 
              
             };


             TomCat[] tomcats = new TomCat[] 
             { 
                 new TomCat("Kotio", 5), 
                 new TomCat("Gosho", 4), 
                 new TomCat("Pesho", 8) 
             }; 
 

             double dogsAverageAge = Animal.AverageAge(dogs); 
             double frogsAverageAge = Animal.AverageAge(frogs); 
             double catsAverageAge = Animal.AverageAge(cats); 
             double kittensAverageAge = Animal.AverageAge(kittens); 
             double tomcatsAverageAge = Animal.AverageAge(tomcats); 
 

             Console.WriteLine("Average age of the dogs: {0:F2}", dogsAverageAge); 
             Console.WriteLine("Average age of the frogs: {0:F2}", frogsAverageAge); 
             Console.WriteLine("Average age of the cats: {0:F2}", catsAverageAge); 
             Console.WriteLine("Average age of the kittens: {0:F2}", kittensAverageAge); 
             Console.WriteLine("Average age of the tomcats: {0:F2}", tomcatsAverageAge); 
 
             Console.WriteLine(new string('-', 10)); 
 
             Console.WriteLine("Sounds: "); 
             cats[0].MakeSound(); 
             dogs[1].MakeSound(); 
             frogs[2].MakeSound(); 

        }
    }
}
