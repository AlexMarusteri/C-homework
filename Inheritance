using System;

class Exercise19
{
    public class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"Name: {Name}";
        }
    }

    public class Student : Person
    {
        public Student(string name) : base(name) { }

        public void Study()
        {
            Console.WriteLine("Study");
        }
    }

    public class Teacher : Person
    {
        public Teacher(string name) : base(name) { }

        public void Explain()
        {
            Console.WriteLine("Explain");
        }
    }

    static void Main()
    {
        Console.Write("Enter Teacher name: ");
        string name1 = Console.ReadLine();

        Console.Write("Enter Student1 name: ");
        string name2 = Console.ReadLine();

        Console.Write("Enter Student2 name: ");
        string name3 = Console.ReadLine();

        Person[] people = new Person[3];
        people[0] = new Teacher(name1);
        people[1] = new Student(name2);
        people[2] = new Student(name3);

        foreach (Person p in people)
        {
            if (p is Teacher teacher)
                teacher.Explain();
            else if (p is Student student)
                student.Study();
        }
    }
}
