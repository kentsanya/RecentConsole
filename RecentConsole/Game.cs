using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecentConsole
{

    //Клас гра, який буде включати в себе двох гравців
    internal class Game
    {
        //Конструктор класу гра
       public Game(Gamer gamer1, Gamer gamer2) 
       {
            gamerfirst = gamer1;
            gamersecond = gamer2;
       }
        //Клас першого гравця
       internal Gamer gamerfirst;
        //клас другого гравця
       internal Gamer gamersecond;
        //константа яка буде зберігати кількість кораблів для гриї
        internal const int COUNSHIP = 5; 

        //метод який розпочинає гру та повертає ім'я переможця
        internal string Start() 
        {
            int chek = 0;
            //Цикл в якому перевіряємо наявність живих короблів у гравців
            while (gamerfirst.countship > 0 && gamersecond.countship > 0)
            {
                //Умова яка реалізує почерговість ходів гравців
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
            //умова визначає переможця
            if (gamerfirst.countship > gamersecond.countship)
            {
                return gamerfirst.name;
            }
            else return gamersecond.name;
        }
    }
}
