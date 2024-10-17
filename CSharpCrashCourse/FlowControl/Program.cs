namespace FlowControl;

class Program
{
    static void Main(string[] args)
    {
        int limit = 20;

        Console.WriteLine($"Counting from {limit} to 0");

        while(limit > 0)
        {
            Console.Write($"I'm at number {limit}");
            
            if(limit % 2 == 0)
            {
                Console.WriteLine(" - which is an even number");
            }
            else
            {
                Console.WriteLine(" - which is an odd number");
            }

            limit -= 1;
        }

        Console.WriteLine("Finished counting!");
    }
}
