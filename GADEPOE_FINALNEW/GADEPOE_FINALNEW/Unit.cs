namespace GADEPOE_FINALNEW
{
    public abstract class Unit
    {
        //variables created for meleeunit and rangedunit to inherit from
        protected int xPosition;
        protected int yPosition;
        protected int hp;
        protected int attack;
        protected int range;
        protected string team;
        protected string symbol;
        protected string name;
        protected int maxHP;
        protected bool isAttacking;

        //accessors created for methods to handle
        public int XPosition { get => xPosition; set => xPosition = value; }
        public int YPosition { get => yPosition; set => yPosition = value; }
        public int Hp { get => hp; set => hp = value; }
        public int Attack { get => attack; set => attack = value; }
        public int Range { get => range; set => range = value; }
        public string Team { get => team; set => team = value; }
        public string Symbol { get => symbol; set => symbol = value; }
        public string Name { get => name; set => name = value; }
        public int MaxHP { get => maxHP; set => maxHP = value; }
        public bool IsAttacking { get => isAttacking; set => isAttacking = value; }

        public Unit(int Xposition, int Yposition, string team, string symbol, string name)
        {
        }

        //checks position of another unit closest to a certain unit
        public abstract Unit closestUnit(Unit[] units);

        //checks to see if one unit is within attack range of the other unit
        public abstract bool withinRange(Unit enemy);

        //batlle between meleeunit and rangedunit
        public abstract void Combat(Unit enemy);//move to enemy

        //moves units to a new position
        public abstract void NewPos();

        public abstract int Atk();

        
    }
}
