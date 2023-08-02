

namespace RecentConsole
{
    //клас описує ігрове поле кожного гравця
    internal class GameField
    {
        //конструктор який задає ім'я поля та кораблі розташовані на ньому
        public GameField(string name, Ship[] shipsplayer) 
        {
            this.name = name;
            this.shipsplayer = shipsplayer;
        }
        //зміна зберігає ім'я поля
        internal string name;
        //зміна яка зберігає висоту поля
        internal const int HEITH = 10;
        //зміна яка зберігає ширину поля
        internal const int WIDTH = 10;
        //зміна яка зберігає масив кораблів на полі
        internal Ship[] shipsplayer = new Ship[Game.COUNSHIP];
       
    }
}
