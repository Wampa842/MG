using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Person : IEquatable<Person>, IComparable<Person>
    {
        public enum GenderType { Male, Female, AttackHelicopter, Undefined };
        public string Name { get; set; }
        public int Age { get; set; }
        public GenderType Gender { get; set; }

        public Person()
        {
            this.Name = "Na'onac";
            this.Age = 5000;
            this.Gender = GenderType.AttackHelicopter;
        }

        public Person(string name, int age, GenderType gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public override string ToString() => $"{Name} ({Age}, {Gender})";

        public bool Equals(Person other)
        {
            if (other == null)
                return false;
            if (this == other)
                return true;
            if (this.Name != other.Name)
                return false;
            if (this.Age != other.Age)
                return false;
            if (this.Gender != other.Gender)
                return false;
            return true;
        }

        public int CompareTo(Person other)
        {
            if (this.Name != other.Name)
                return string.Compare(this.Name, other.Name);
            return this.Age - other.Age;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Person p1 = new Person();
            Person p2 = new Person("Teal'c", 80, Person.GenderType.Male);
            Person p3 = new Person("Na'onac", 5000, Person.GenderType.AttackHelicopter);
            Console.WriteLine(p1);
            Console.WriteLine(p3);
            Console.WriteLine(p1.Equals(p3));
        }
    }
}