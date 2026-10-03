namespace UniversityMembersPolymorphismFriend;

public class Person
{
    public string Name { get; private set; }

    public Person(string name)
    {
        Name = name;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Person: {Name}");
    }
}

public class Student : Person
{
    public string StudentId { get; private set; }

    public Student(string name, string studentId) : base(name)
    {
        StudentId = studentId;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Student: {Name} | ID: {StudentId}");
    }
}

public class Employee : Person
{
    public decimal Salary { get; private set; }

    public Employee(string name, decimal salary) : base(name)
    {
        Salary = salary;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Employee: {Name} | Salary: {Salary:C}");
    }
}

public class Teacher : Person
{
    public string CourseName { get; private set; }

    public Teacher(string name, string courseName) : base(name)
    {
        CourseName = courseName;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Teacher: {Name} | Course: {CourseName}");
    }
}

internal class Program
{
    private static void PrintInfo(Person person)
    {
        person.DisplayInfo();
    }

    private static void Main()
    {
        List<Person> people = new List<Person>
        {
            new Person("Rami Saleh"),
            new Student("Dana Ibrahim", "U-5872"),
            new Employee("Huda Faris", 10800m),
            new Teacher("Majed Yasin", "Software Engineering")
        };

        foreach (Person person in people)
        {
            Console.WriteLine("Object type: " + person.GetType().Name);
            person.DisplayInfo();
            Console.WriteLine();
        }

        Console.WriteLine("Using the method that receives a Person:");
        PrintInfo(people[1]);
    }
}
