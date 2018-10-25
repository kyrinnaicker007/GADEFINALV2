using System;

namespace GADEPOE_FINALNEW
{
    class RangedUnit:Unit
    {
        Random r = new Random();

        public RangedUnit(int Xposition, int Yposition, string team, string symbol, string name):base(Xposition,Yposition,team,symbol,name)
        {
            this.XPosition = Xposition;
            this.YPosition = YPosition;
            this.hp = 100;
            this.attack = 3;
            this.range = 1;
            this.team = team;
            this.symbol = symbol;
            this.name = name;
            this.maxHP = MaxHP = 100;
            this.isAttacking = IsAttacking = false;
        }

        public override string ToString()
        {
            string[] unitSelection = GetType().ToString().Split('.');
            string mySelection = unitSelection[unitSelection.Length - 1];

            return Team + "," + Name + "," + mySelection + "," + (XPosition + 1) + "," + (YPosition + 1) + "," + hp;
        }

        public override Unit closestUnit(Unit[] units)
        {
            int tDistance = 500;
            int Distance = tDistance;
            Unit feedBackUnit = null;

            for (int k = 0; k < units.Length; k++)
            {
                if (units[k] != null && units[k] != this && units[k].Hp > 0 && units[k].Team != this.team)
                    Distance = ((this.XPosition - units[k].XPosition) ^ 2 + (this.YPosition - units[k].YPosition) ^ 2) ^ 1 / 2;
                if (Distance < 0)
                {
                    tDistance = Distance;
                    feedBackUnit = units[k];
                }
            }
            return feedBackUnit;
        }

        public override void Combat(Unit enemy)
        {
            if (enemy != null)
            {
                int DX = (enemy.XPosition - XPosition);
                int DY = (enemy.YPosition - YPosition);
                if (Math.Abs(DX) < Math.Abs(DY))
                {
                    if (DX < 0)
                        XPosition--;
                    else if (DX > 0)
                        XPosition++;
                }
                else if (Math.Abs(DY) < Math.Abs(DX))
                {
                    if (DY < 0)
                        YPosition--;
                    else if (DY > 0)
                        YPosition++;
                }
            }
        }

        public override bool withinRange(Unit enemy)
        {
            int D = 500;
            if (enemy != null)
                D = ((XPosition - enemy.XPosition) ^ 2 + (YPosition - enemy.YPosition) ^ 2) ^ 1 / 2;
            if (D <= this.range)
                return true;
            else
                return false;
        }

        public override void NewPos()
        {
            bool valid = false;
            int move = 0;
            while (valid == false)
            {
                move = r.Next(1, 5);
                if (YPosition == 0 && move == 1)
                    valid = false;
                else if (XPosition == 19 && move == 2)
                    valid = false;
                else if (YPosition == 19 && move == 3)
                    valid = false;
                else if (XPosition == 0 && move == 4)
                    valid = false;
                else
                    valid = true;
            }

            switch (move)
            {
                case 1:
                    YPosition--;
                    break;
                case 2:
                    XPosition++;
                    break;
                case 3:
                    YPosition++;
                    break;
                case 4:
                    XPosition--;
                    break;
            }
        }

        public override int Atk()
        {
            return this.Attack;
        }
    }
}
