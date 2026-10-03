namespace UniversityMembersFriend;

public class Person
{
    public string Name { get; }
    public string Email { get; }

    public Person(string name, string email)
    {
        Console.WriteLine("[Person] constructor started");
        Name = name;
        Email = email;
    }

    public void DisplayBasicInfo()
    {
        Console.WriteLine($"Person: {Name} ({Email})");
    }
}

public class Student : Person
{
    public string StudentId { get; }
    public double GPA { get; }

    public Student(string name, string email, string studentId, double gpa)
        : base(name, email)
    {
        Console.WriteLine("[Student] constructor started");
        StudentId = studentId;
        GPA = gpa;
    }

    public void ShowAcademicRecord()
    {
        Console.WriteLine($"Student ID: {StudentId} | GPA: {GPA:F2}");
    }
}

public class Employee : Person
{
    public string EmployeeId { get; }
    public decimal Salary { get; }

    public Employee(string name, string email, string employeeId, decimal salary)
        : base(name, email)
    {
        Console.WriteLine("[Employee] constructor started");
        EmployeeId = employeeId;
        Salary = salary;
    }

    public void ShowEmploymentDetails()
    {
        Console.WriteLine($"Employee ID: {EmployeeId} | Salary: {Salary:C}");
    }
}

public class Teacher : Employee
{
    public string CourseName { get; }

    public Teacher(string name, string email, string employeeId, decimal salary, string courseName)
        : base(name, email, employeeId, salary)
    {
        Console.WriteLine("[Teacher] constructor started");
        CourseName = courseName;
    }

    public void Teach()
    {
        Console.WriteLine($"{Name} teaches the course: {CourseName}");
    }
}

internal static class Program
{
    private static void Main()
    {
        Console.WriteLine("--- Student object: constructor order ---");
        Student student = new("Lina Hassan", "lina.hassan@campus.edu", "ST-2487", 3.62);

        Console.WriteLine("\n--- Teacher object: constructor order ---");
        Teacher teacher = new("Khalid Nasser", "k.nasser@campus.edu", "EMP-731", 14500m, "Database Systems");

        Console.WriteLine("\n--- Student methods ---");
        student.DisplayBasicInfo();
        student.ShowAcademicRecord();

        Console.WriteLine("\n--- Teacher methods ---");
        teacher.DisplayBasicInfo();
        teacher.ShowEmploymentDetails();
        teacher.Teach();
    }
}
