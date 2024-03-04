namespace Triangle;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter  a digit :");
         int print = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("enter  a width :");
         int num = Convert.ToInt32(Console.ReadLine());

            
            for(int i= 0; i<=num; i++)
                {
                    for(int j= 1; j<=(num -i); j++)
                    {
                    Console.Write(print +" ");
                    }
                
            Console.WriteLine(" ");
                }
        Console.WriteLine("Hello, World!");
    }
}
