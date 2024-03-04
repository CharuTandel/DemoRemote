namespace UseridPassword;

class Program
{
    static void Main(string[] args)
    {
         for(int i=1; i<=3 ;i++)
                {
                     Console.WriteLine(Environment.NewLine+ "Input a username : ");
                      Console.ReadLine();
                    

                     Console.WriteLine(Environment.NewLine+ "Input a Password: ");
                    Console.ReadLine();

                    Console.WriteLine(Environment.NewLine+ "Invalid username or your password");
                    
                }
            Console.WriteLine(Environment.NewLine+ "Login attempt more than three times .Try later !");

    
    }
}
