

namespace RecentConsole
{
    internal class GameField
    {
        public GameField(string name, Ship[] shipsplayer) 
        {
            this.name = name;
            this.shipsplayer = shipsplayer;
        }

        internal string name;
        internal const int HEITH = 10;
        internal const int WIDTH = 10;
        internal Ship[] shipsplayer = new Ship[5];
       
    }
}
