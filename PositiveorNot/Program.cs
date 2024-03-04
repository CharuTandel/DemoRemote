namespace PositiveorNot;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("please enter a digit");
        int number  = Convert.ToInt32(Console.ReadLine());

        if(number == 0)
        {
                Console.WriteLine( number + " is not valid , enter other digit");
        }
        else if(number > 0)
        {
            Console.WriteLine(number + " is positive digit");
        }
        else
        {
            Console.WriteLine(number + " is negative digit");
        }
    }
}
