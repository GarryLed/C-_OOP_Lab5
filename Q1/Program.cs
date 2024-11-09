namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // 3. Object initializer 
            ComputerGame cg1 = new ComputerGame("Sonic", 29.99m, new DateTime(1990, 3, 15), "U");

            ComputerGame cg2 = new ComputerGame("Mario", 24.99m, new DateTime(1995, 11, 17), "7");

            

            Console.WriteLine(cg1);

            cg1.UpdatePrice(.1m);

            DisplayGame(cg1);


        } // End of main method 
        static void DisplayGame(Game game)
        {
            Console.WriteLine(game);
        }
    }
}