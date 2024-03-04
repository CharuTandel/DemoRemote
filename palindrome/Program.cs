using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace palindrome;

class Program
{
   static void Divide(int x,int y)   
    {
      int result;
       
        if(y == 0)
        {
          
              result = (x/y);
          Console.WriteLine( result);
        
          
          }
        

        else{
                result =(x/y);
              Console.WriteLine("SHOW " +result);
        }
    }
    static void Main(string[] args)
     {
        try{
      int  a = Convert.ToInt32(Console.ReadLine());
      int  b = Convert.ToInt32(Console.ReadLine());


    Divide( a, b);
        }

         catch(Exception e)
          {
            Console.WriteLine("exception check "+Environment.NewLine+ e);
          }
        Console.WriteLine("after division  " );

     }
}


















      //   StringBuilder obj = new StringBuilder();

      //   for(int i =1; i<5; i++)
      //   {
      //      obj = obj.Append(" data");
      //      Console.WriteLine("H" +obj);
      //   }
       
        
      //   string c = "";
		  
		  // for(int i=1; i<5; i++)
		  // {
		  //   c = c + "  charu";
		  //   Console.WriteLine("value" +c);
		  // }
        
        // int a =2 ,b =7, c=3;


        // if((a>b) && (a>c))
        // {
        //     Console.WriteLine("first Greatest value  " +a);

        // }
        // else if( (b>c) && (b>a))
        // {
        //     Console.WriteLine("second Greatest value  " +b);
        // }
        // else
        // {
        //     Console.WriteLine("Third Greatest value  " +c);
        // }

    