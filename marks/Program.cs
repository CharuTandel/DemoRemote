namespace marks;

class Program
{
    static void Main(string[] args)
    {

            int total = 300;
            
            Console.Write("Input Roll :");
            int roll = Convert.ToInt32(Console.ReadLine());
            
             Console.Write("Name of student :");
               string? name = Console.ReadLine();

             Console.Write("Marks of physics :");
            int  physics = Convert.ToInt32(Console.ReadLine());
            
             Console.Write("Marks of chemistry :");
            int chemistry = Convert.ToInt32(Console.ReadLine());

             Console.Write("Marks of computer application :");
            int computer = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Environment.NewLine +"roll No :" +roll);
            Console.WriteLine("Name of Student :" +name);
            Console.WriteLine("marks in physics :" +physics);
            Console.WriteLine("marks in chemistry :" +chemistry);
            Console.WriteLine("marks of computer application :"+computer);

            double Marks_Obtain = (physics + chemistry + computer);
            Console.WriteLine(Environment.NewLine +"Total marks obtained :" +Marks_Obtain);

            double percentage = ((Marks_Obtain/total)) * 100;
            Console.WriteLine(Environment.NewLine+ "percentage calculated :" +percentage + " %" +Environment.NewLine );

            if((percentage >= 50) && (percentage <=59 ))
            {
                Console.WriteLine("Second class");
           
            }
            else if(percentage >= 60 && (percentage <=69 ))
            {
                Console.WriteLine("First class");
            }
            else if(percentage >= 70)
            {
                Console.WriteLine("Distinction ");
            }
            else if ((percentage <= 50) && (percentage >= 35))
            {
                Console.WriteLine("Pass class");

            }
            else
            {
                Console.WriteLine("Failed , better Luck next time !");
            }
            
            
        
    }
}
