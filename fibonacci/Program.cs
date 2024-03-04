namespace fibonacci;

class Program
{
    static void Main(string[] args)
    {
    
            const  string charu="abc";
            Console.WriteLine("please Enter ch   the digit to print Fibonacci series:");
            c
            int digit  = Convert.ToInt32(Console.ReadLine());
            int a =0, b =1,temporay, result;

             Console.WriteLine("Your Result is of Fibonacci series :");
             
               Console.WriteLine(a);
                Console.WriteLine(b);
            
            for(int i=0;i<(digit-2);i++)
            {
                result = a +b;
               
                Console.WriteLine( +result);

                temporay = a;
                 a = b;
                b = result;

        
            }
        }
    }


