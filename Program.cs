using System;
using System.Collections.Generic;

namespace classPractice
{
    class Program
    {
        static public void Main()
        {
            Console.WriteLine("Hello World!");
            Dog dog1 = new Dog(3,"Fido",25.6f);
            Console.WriteLine(dog1.getName());
            Console.WriteLine(dog1.getAge());
            dog1.gainYears(2);
            Console.WriteLine(dog1.getAge());

            Dog dog2 = new Dog(4,"Mookie",44.1f);
            Console.WriteLine(dog2.getName());

            List<string> band1Members = new List<string>();
            band1Members.Add("Jimmy Smith");

            Band band1 = new Band(band1Members, "Xanzatras", 1999, "Doom Metal");
            
            Console.WriteLine(band1.getMembers());
        }
    }

    class Dog 
    {
        private int _age;
        private string _name;
        private float _weight;
        public Dog(int a, string n, float w) {
            _age = a;
            _name = n;
            _weight = w;
        }
        public string getName() {
            return _name;
        }
        public int getAge() {
            return _age;
        }
        public void gainYears(int n) {
            _age+=n;
        }
    }

    class Band {
        
        private List<string> _members;
        private string _name;
        private int _yearStarted;
        private string _genre;
        public string getMembers() {
            return _members[0];
        }
        

        public Band(List<string> m, string n, int yS, string g) 
        {
            _members = m;
            _name = n;
            _yearStarted = yS;
            _genre = g;
        }
        
    }
}

