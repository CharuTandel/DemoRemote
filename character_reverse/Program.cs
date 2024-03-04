namespace character_reverse;

class Program
{
    static void Main(string[] args)

    {
            
            Console.WriteLine("enter first letter :");

                string? first= Console.ReadLine();

                char a;

                bool store = char.TryParse(first,out a);

                if(store)
                {
                    Console.WriteLine(Environment.NewLine +"first input :" +a );
                }
                else
                {
                    Console.WriteLine("Not converted enter only one character");
                }


             Console.WriteLine(Environment.NewLine +"enter second letter :");

                string? second= Console.ReadLine();

                char b;

                bool store_sec = char.TryParse(second,out b);

                if(store_sec)
                {
                    Console.WriteLine(Environment.NewLine +"second input :" +b);
                }
                else
                {
                    Console.WriteLine("enter second character again");
                }
        

             Console.WriteLine(Environment.NewLine +"enter third letter :");

                string? third= Console.ReadLine();

                char c;

                bool store_third = char.TryParse(third,out c);

                if(store_third)
                {
                    Console.WriteLine(Environment.NewLine +"third input :" +c);
                }
                else
                {
                    Console.WriteLine("please enter third letter, not converted");
                }

                Console.WriteLine(Environment.NewLine +"reverse order :" +c+ " " +b+ " " +a);
        
            


            // Console.WriteLine("enter second letter :");
            // char b = Convert.ToChar(Console.ReadLine());

            // Console.WriteLine("enter third letter :");
            // char c = Convert.ToChar(Console.ReadLine());
            
            
            
        
    }
}
