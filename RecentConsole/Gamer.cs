

namespace RecentConsole
{
    //клас, для опису гравця
    internal class Gamer
    {
        //конструктор класу, який задає ім'я та ігрове поле
        internal Gamer(string name, GameField gameField)
        {
            this.name = name;
            field = gameField;
        }

        //Поле яке зберігає ім'я
        internal string name;
        //Поле яке зберігає ігрове поле
        internal GameField field;
        //поле яке задає кількість кораблів
        internal int countship=Game.COUNSHIP;


        //Метод який реалізовує 1 крок для гри морскьйи бій
        public void Step(int x, string y) 
        {
            //цикл перебору кораблів гравця
            for (int i = 0; i < field.shipsplayer.Length; i++) 
            {
                //перевіряє чи на заданих координатх є корабель
                if (field.shipsplayer[i].cordinatenumber == x && field.shipsplayer[i].coordinatvalue == y && field.shipsplayer[i].isDead==false) 
                {
                    //коробель потонув
                    field.shipsplayer[i].isDead = true;

                    //зменшення кількості кораблів поточного гравця
                    countship--;
                }
            }
          
        }
    }
    
}
