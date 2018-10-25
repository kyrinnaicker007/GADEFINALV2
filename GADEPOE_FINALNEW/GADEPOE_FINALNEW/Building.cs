namespace GADEPOE_FINALNEW
{
    abstract class Building
    {
        //variables created for factory and resource to inherit from
        protected int xPosition;
        protected int yPosition;
        protected int hp;
        protected string team;
        protected string symbol;

        //accssesors created for methods to obtain
        public int XPosition { get => xPosition; set => xPosition = value; }
        public int YPosition { get => yPosition; set => yPosition = value; }
        public int Hp { get => hp; set => hp = value; }
        public string Team { get => team; set => team = value; }
        public string Symbol { get => symbol; set => symbol = value; }

        //constructor created for accsessing values
        public Building(int Xposition, int Yposition, string team, string symbol)
        {
        }
    }
}
