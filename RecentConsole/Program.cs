namespace RecentConsole
{
    internal class Program
    {
        //точка входу в программу
        static void Main(string[] args)
        {
            //Створювали гру через метод ініціалізації даних
            Game game = InitData();
            //виводить ім'я переможця на консоль
            Console.WriteLine($"Player win {game.Start()}");

        }

        //метод ініціалізації даних
        static Game InitData() 
        {
            //Ініціалізаця даних для першого гравця
            Ship[] shipsplayer1 = new Ship[5];
            for (int i = 0; i < 5; i++) 
            {
                Console.WriteLine("Player first input number");
                int x=int.Parse(Console.ReadLine());
                Console.WriteLine("Input symbol");
                string s=Console.ReadLine();
                shipsplayer1[i] = new Ship($"ship {i}", s, x);
            }
            //Ініціалізаця даних для другого гравця
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