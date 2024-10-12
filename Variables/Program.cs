namespace Variables;

class Program
{
    static void Main(string[] args)
    {
        // Variable declaration and initialization at the same time
        int final_grade = 5;
        double average_grade = 4.6;

        // Variable declaration then initialization
        string name;
        name = "Ivan";

        // String interpolation - combine strings
        string message = $"Hello, {name}! Your average grade was: {average_grade}. ";
        message += $"Your final grade is {final_grade}!";


        Console.WriteLine(message);

        // You can change value of each variable (unless it's `const` or `readonly`)
        name = "Marija";
        final_grade = 5;
        average_grade = 4.8;
        message = $"Hello, {name}! Your average grade was: {average_grade}. ";
        message += $"Your final grade is {final_grade}!";
        Console.WriteLine(message);
    }
}
