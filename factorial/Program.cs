namespace factorial;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter digit");
        int num = Convert.ToInt32(Console.ReadLine());
         int result = 1;

            for(int i=1;i<=num ;i++)
            {
                result = (result*i) ;
            }
            Console.WriteLine(" " +result);
    }
        
    }

