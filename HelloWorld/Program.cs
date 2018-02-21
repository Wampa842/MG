using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HelloWorld.University;

namespace HelloWorld
{
    namespace University
    {
        class Student : Person
        {
            public Student() : base()
            {
                this.Neptun = "000000";
                this.Year = 1970;
            }

            public Student(string name, int age, GenderType gender, string neptun, int year) : base(name, age, gender)
            {
                Neptun = neptun;
                Year = year;
            }

            public string Neptun { get; set; }
            public int Year { get; set; }



            public override bool Equals(object obj)
            {
                return base.Equals(obj);
            }

            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            public override string ToString()
            {
                return $"{base.Name} {this.Neptun}";
            }

            public override void Introduce()
            {
                Console.WriteLine("I am a student");
            }
        }
    }

    internal class Person : IEquatable<Person>, IComparable<Person>
    {
        public static bool operator ==(Person a, Person b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(Person a, Person b)
        {
            return !(a.Equals(b));
        }

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

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public virtual void Introduce()
        {
            Console.WriteLine("I am a person");
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Person p1 = new Person();
            Person p2 = new Person("Teal'c", 80, Person.GenderType.Male);
            Person p3 = new Person("Na'onac", 5000, Person.GenderType.AttackHelicopter);

            Student s1 = new Student();
            Person sp1 = new Student();

            Console.WriteLine(p1);
            Console.WriteLine(p3);
            Console.WriteLine(p1.Equals(p3));
        }
    }
}