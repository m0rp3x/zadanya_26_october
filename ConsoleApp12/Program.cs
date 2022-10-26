namespace ConsoleApp12
{
    internal class Bebra
    {
        public static void Main(string[] args)
        {
            // Console.WriteLine(sum(1,2));
            // var seconde = (int minute) => Console.WriteLine(minute * 60);
            // seconde(5);
            // // Console.WriteLine(getFirstValue(new[] {-500, 0, 50}));
            // var get = (int[] aboba) => Console.WriteLine(aboba.First());
            // get(new int[] {80, 5, 100});
            Console.WriteLine(floor(80,3));
        }
        public static int sum(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int GetFirstValue(int[] aboba)
        {
            return aboba.First();
        }

        public static int floor(int aboba1, int aboba2)
        {
            
            return (int) (aboba1 / Math.Pow(2,aboba2));
        }
    }
}
