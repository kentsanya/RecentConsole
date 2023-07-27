namespace RecentConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = InitData();
            Console.WriteLine($"Player win {game.Start()}");

        }

        static Game InitData() 
        {
            Ship[] shipsplayer1 = new Ship[5];
            for (int i = 0; i < 5; i++) 
            {
                Console.WriteLine("Player first input number");
                int x=int.Parse(Console.ReadLine());
                Console.WriteLine("Input symbol");
                string s=Console.ReadLine();
                shipsplayer1[i] = new Ship($"ship {i}", s, x);
            }

            Ship[] shipsplayer2 = new Ship[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Player second input number");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Input symbol");
                string s = Console.ReadLine();
                shipsplayer2[i] = new Ship($"ship {i}", s, x);
            }
            GameField gameFieldplayer1 = new GameField("game1", shipsplayer1);
            GameField gameFieldplayer2 = new GameField("game1", shipsplayer2);

            Gamer oneplayer = new Gamer("Oleksandr", gameFieldplayer1);
            Gamer sercondplayer = new Gamer("Ivan", gameFieldplayer2);
            return new Game(oneplayer, sercondplayer);
            
        }
    }
}