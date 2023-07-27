
namespace RecentConsole
{
    internal class Ship
    {
        public Ship(string nickname, string cordinateval, int number) 
        {
            this.nickname = nickname;
            coordinatvalue = cordinateval;
            cordinatenumber = number;
        }
        internal string nickname;
        internal string coordinatvalue;
        internal int cordinatenumber;
        internal bool isDead = false;
    }
}
