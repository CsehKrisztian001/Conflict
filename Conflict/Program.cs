namespace Conflict
{
    internal class Program
    {
        private static void First()
        {
            Second("Hello, World!");
        }

        private static void Second(string message)
        {
            Console.WriteLine("Hello, World!");
        }

        static void Main(string[] args)
        {
            First();
        }
    }
}
