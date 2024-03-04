namespace throwing;


class Program
{
    public void add(int x,int y)
    {
        int result = (x+y);
        Console.WriteLine("first" +result);
    }

    public void sub(int a,int b)
    {
            int answer = (a-b);
        Console.WriteLine("second" + answer);
    }

    public void divd(int m,int n)
    {
            int res = (m/n);
        Console.WriteLine("third" +res);
    }


    static void Main(string[] args)
    {
        try{
                int c = Convert.ToInt32(Console.ReadLine());
                int d = Convert.ToInt32(Console.ReadLine());

                add(c,d);
                sub(c,d);
                divd(c,d);

        }

        catch(Exception e)
        {
            Console.WriteLine("Error occur : " +e);
        }

        Console.WriteLine("hello earth! ,Last line" +c+ " and " +d);
    }
}
