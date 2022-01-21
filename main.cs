using System;
using System.Linq;
namespace exercises
{
    class Program{
    public static int operation(int n1 ,int n2, int n3,int n4){
        int sum =(n1 +n2);
        int mul=(n3 * n4);
        int sub=(n4-n3);
        int div=(n2/n1);
        int mod= (n3%2);
    }
    static void Main(string [] args){
        int num1,num2,num3,num4,sum,mul,sub,div,mod;
        Console.Write("Number 1: ");
        num1=Convert.ToInt32(Console.ReadLine());
        Console.Write("Number 2: ");
        num2=Convert.ToInt32(Console.ReadLine());
        Console.Write("Number 3: ");
        num3=Convert.ToInt32(Console.ReadLine());
        Console.Write("Number 4: ");
        num4=Convert.ToInt32(Console.ReadLine());
        sum=operation(n1,n2,n3,n4);
        Console.WriteLine("Sum is" +sum);
         mul=operation(n1,n2,n3,n4);
        Console.WriteLine("product is" +mul);
         sub=operation(n1,n2,n3,n4);
        Console.WriteLine("Subtracrion  is" +sub);
         div=operation(n1,n2,n3,n4);
        Console.WriteLine("Division is" +div);
         mod=operation(n1,n2,n3,n4);
        Console.WriteLine("Modulus is" +mod);
        
    }
}
}