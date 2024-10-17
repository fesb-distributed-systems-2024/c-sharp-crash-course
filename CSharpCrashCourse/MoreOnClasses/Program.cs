namespace MoreOnClasses;

class Student
{
    // Properties
    public string Name { get; set; }
    public double Grade {get; set;}

    // Constructor
    public Student(string name, double grade)
    {
        this.Name = name;
        this.Grade = grade;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an array of 3 students
        Student[] students = new Student[3];

        students[0] = new Student("Ana", 3.1);
        students[1] = new Student("Maja", 4.2);
        students[2] = new Student("Josip", 2.6);

        // Greet all students
        foreach(var student in students)
        {
            Console.WriteLine($"Hello, {student.Name}");
        }

        // Change first student's name and greet them again
        students[0].Name = "Anamarija";

        foreach(var student in students)
        {
            Console.WriteLine($"Hello again, {student.Name}");
        }

        // Calculate average grade
        double sum = 0.0;
        foreach (var student in students)
        {
            sum += student.Grade;
        }
        double average_grade = sum / students.Length;

        Console.WriteLine($"Average grade of all students is {average_grade}.");
    }
}
