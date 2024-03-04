namespace Type_Convert;


public class Explicitly_convert
{ 
     
    public void xyz()
    {
        double a = 34.765;
     int c = (int)a;

        Console.WriteLine("before converting :" + a);
        Console.WriteLine("After Explicit conversion :" + c);
    }

}

class Program
{
    static void Main(string[] args)
    {
       
        Explicitly_convert obj = new Explicitly_convert();
        obj.xyz();
        

    }
}
