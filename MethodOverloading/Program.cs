using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace MethodOverloading
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Methods.Add(1,0,true));
            Console.WriteLine();

            Console.WriteLine(Methods.Add(2,5,true));
            Console.WriteLine();

            Console.WriteLine(Methods.Add(-3,6,true));
            Console.WriteLine();

        }

    }

    
}
