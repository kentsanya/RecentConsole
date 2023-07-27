using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecentConsole
{
    internal class Gamer
    {
        internal Gamer(string name, GameField gameField)
        {
            this.name = name;
            field = gameField;
        }
        internal string name;
        internal GameField field;
        internal int countship=5;

        public void Step(int x, string y) 
        {
            for (int i = 0; i < field.shipsplayer.Length; i++) 
            {
                if (field.shipsplayer[i].cordinatenumber == x && field.shipsplayer[i].coordinatvalue == y && field.shipsplayer[i].isDead==false) 
                {
                    field.shipsplayer[i].isDead = true;
                    countship--;
                }
            }
          
        }
    }
    
}
