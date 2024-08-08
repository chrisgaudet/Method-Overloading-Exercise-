namespace MethodOverloading
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine(Methods.Add(1, 7));
            Console.WriteLine();

            Console.WriteLine(Methods.Add(2, 5.6m));
            Console.WriteLine();

            Console.WriteLine(Methods.Add(-3, 6, true));
            Console.WriteLine();

        }

    }


}
