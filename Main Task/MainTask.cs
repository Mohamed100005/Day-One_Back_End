namespace MainTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Price per small room: $25\nPrice per large room: $35 ");
            Console.Write("Number of small rooms:");
            int sRooms = int.Parse(Console.ReadLine());
            Console.Write("Number of large rooms:");
            int lRooms = int.Parse(Console.ReadLine());
            int total = sRooms * 25 + lRooms * 35;
            Console.WriteLine($"Cost : {total:C}");
            double tax = total * 0.06;
            Console.WriteLine($"Tax : {tax:C}");
            Console.WriteLine($"Total estimate: {total + tax:C}");
            Console.WriteLine("This estimate is valid for 30 days");
        }
    }
}
