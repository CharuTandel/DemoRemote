namespace Equal;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("input first number :");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("input second number :");
        int b = Convert.ToInt32(Console.ReadLine());

        if(a == b)
        {
            Console.WriteLine($"value of a :{a} is equal to value of b :{b}");
        }
        else
        {
            Console.WriteLine("not equal");
        }

        
    }
}
