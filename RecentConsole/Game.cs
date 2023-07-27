using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecentConsole
{
    internal class Game
    {
       public Game(Gamer gamer1, Gamer gamer2) 
       {
            gamerfirst = gamer1;
            gamersecond = gamer2;
       }
       internal Gamer gamerfirst;
       internal Gamer gamersecond;

        internal string Start() 
        {
            int chek = 0;
            while (gamerfirst.countship > 0 && gamersecond.countship > 0)
            {
                if (chek % 2 == 0) 
                {
                    Console.WriteLine($"{gamerfirst.name} Input coordinates of number");
                    int x = int.Parse(Console.ReadLine());
                    Console.WriteLine($"{gamerfirst.name} Input coordinates of symbol");
                    string s=Console.ReadLine();
                    gamersecond.Step(x, s);
                }
                else 
                {
                    Console.WriteLine($"{gamersecond.name} Input coordinates of number");
                    int x = int.Parse(Console.ReadLine());
                    Console.WriteLine($"{gamersecond.name} Input coordinates of symbol");
                    string s = Console.ReadLine();
                    gamerfirst.Step(x, s);
                }
            }
            if (gamerfirst.countship > gamersecond.countship)
            {
                return gamerfirst.name;
            }
            else return gamersecond.name;
        }
    }
}
