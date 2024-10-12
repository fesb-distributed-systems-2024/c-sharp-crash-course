namespace Inheritance;

class Person
{
    public string Name { get; set;}
    public Person(string name)
    {
        this.Name = name;
    }

    // Virtual so that subclasses can override thsi function
    // to override = same function name, but different implementation
    virtual public void Greet()
    {
        Console.WriteLine($"Hi my name is {Name} and i'm just an ordinary person.");
    }
}

/*
 * The class Student inherits class Person
 *
 * This has two major implications:
 *
 *  1) Everywhere we can "put" an object of type Person,
 *      we can also "put" an object of type Student
 *
 *  2) We have acces to all non-private members and methods/functions
 *      of Person inside of Student class
 * 
 */


class Student : Person
{
    // Call "base(name)" so that Person object can be initialized
    // because Student *IS a Person
    public Student(string name) : base(name)
    {
    }

    // "override" means that this function exists "above"
    // i.e. in a base class and we want to redefine what it does.
    override public void Greet()
    {
        // We have access to "Name" because Student is a subclass of
        // Person and Person has a property/field "Name"
        Console.WriteLine($"Hi, i'm {Name} and i'm a student.");
    }
}

// All notes on Student class are also valid for the Professor class
class Professor : Person
{
    public Professor(string name) : base(name)
    {

    }

    override public void Greet()
    {
        Console.WriteLine($"Hi, i'm {Name} and i'm a professor.");
    }
}

class Janitor : Person
{
    public Janitor(string name) : base(name)
    {

    }

    override public void Greet()
    {
        Console.WriteLine($"Hi, i'm {Name} and i'm a janitor.");
    }
}

class JustGirl : Person
{
    public JustGirl(string name) : base(name)
    {

    }

    override public void Greet()
    {
        Console.WriteLine($"Hi, i'm {Name} and i'm just a girl.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an array in-place
        // Q: If the array is of type "Person", why can we have "Student",  "Janitor", etc. inside?
        // Answer is at the bottom
        Person[] personnel = new Person[] {
            new Person("Ante"),
            new Student("Marija"),
            new Professor("Petar"),
            new Janitor("Jozo"),
            new JustGirl("Josipa")
        };

        // Greet each person
        foreach (var person in personnel)
        {
            person.Greet();
        }
    }
}

// Answer to the question above
// A: Because all those classes (Student, Janitor, Professor, ...) are subclasses of Person
// so *EACH Student/Janitor/Professor/... IS A Person
// Wherever we can put a Person, we can put any of its subclasses i.e. Student, Professor...
// (see notes above Student class)
