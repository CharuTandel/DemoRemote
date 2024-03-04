using System.Security.Cryptography.X509Certificates;

class DelegatesFirst{

       public  delegate int Findel(int a,int b);


       public static int calcu(int x,int y)
       {
            if(x<y)
            {
                return ++x;
                
            }
            else
            {
                return ++y;
            }
       }

       public static int Show(int m,int n)
       {
           return (m+n);
        
       }
    public static void Main(String [] args)
    {
        Findel obj = new Findel(calcu);

         Findel ob2 = new Findel(Show);

       int i = obj(10,1);

       
       int g = ob2(23,65);

       Console.WriteLine(g+ " result : " +i);
       

    }
}
