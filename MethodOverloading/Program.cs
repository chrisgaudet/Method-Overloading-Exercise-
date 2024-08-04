using System.Security.Cryptography.X509Certificates;

namespace MethodOverloading
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var answer = Methods.Add(1,0,true);
            Console.WriteLine(answer);
        }

    }

    
}
