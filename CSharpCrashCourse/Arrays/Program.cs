namespace Arrays;

class Program
{
    static void Main(string[] args)
    {
        string[] students = {"Ante", "Mate", "Ivana", "Mare"};

        Console.WriteLine($"Number of students is { students.Length }");
        Console.WriteLine($"First student is: { students[0] }");
        Console.WriteLine($"Last student is: { students[students.Length - 1] }");

        // Looping through all students using for-loop
        for (int i = 0; i < students.Length; i++)
        {
            Console.WriteLine($"Hello, student {students[i]}");
        }

        // Looping through all students using foreach-loop
        foreach (var student in students)
        {
            Console.WriteLine($"Hello again, {student}");
        }
    }
}
