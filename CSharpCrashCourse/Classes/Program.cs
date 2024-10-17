namespace Classes;

class Student
{
    // Private student fields - not accessible from outside of class
    private string name;
    private string surname;
    private double grade;

    // Constructor
    public Student(string name, string surname, double grade)
    {
        this.name = name;
        this.surname = surname;
        this.grade = grade;
    }

    // Public functions - accessible from outside
    public double GetGrade()
    {
        return grade;
    }

    public void Greet()
    {
        Console.WriteLine($"Hello, {name} {surname}.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student("Ivana", "Ivanovic", 4.8);
        student1.Greet();

        double grade = student1.GetGrade();
        Console.WriteLine($"Student has grade: {grade}");
    }
}
