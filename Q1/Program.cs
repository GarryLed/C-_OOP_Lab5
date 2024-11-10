namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // 3. Object initializer 
            //Game g1 = new Game("Monopoly", 19.99m, DateTime(1970, 10,  31));
            // Game g2 = new Game() {price = 10.99m, releasedate = new DateTime(2000, 6, 15)};

            ComputerGame cg1 = new ComputerGame("Sonic", 29.99m, new DateTime(1990, 3, 15), " U");

            ComputerGame cg2 = new ComputerGame("Mario", 24.99m, new DateTime(1995, 11, 17), " 7");



            DisplayGame(cg1);
            DisplayGame(cg2);

            cg1.UpdatePrice(.1m);

            DisplayGame(cg1);
            DisplayGame(cg2);


        } // End of main method 
        static void DisplayGame(Game game)
        {
            Console.WriteLine(game);
        }
    }
}