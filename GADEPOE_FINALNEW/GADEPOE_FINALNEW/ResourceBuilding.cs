namespace GADEPOE_FINALNEW
{
    class ResourceBuilding:Building
    {
        //resourcebuilding inherits buildings variables
        public ResourceBuilding(int Xposition, int Yposition, string team, string symbol):base(Xposition,Yposition,team,symbol)
        {
            //each variable is assigned to value or a accessor
            this.hp = 70;
            this.XPosition = XPosition;
            this.YPosition = YPosition;
            this.team = team;
            this.symbol = symbol;
        }

        //to string method handles the output of each unit so that the location on the map is shown
        public override string ToString()
        {
            string[] unitSelection = GetType().ToString().Split('.');
            string mySelection = unitSelection[unitSelection.Length - 1];

            return Team + ","  + mySelection + "," + (XPosition + 1) + "," + (YPosition + 1) + "," + Hp;
        }
    }
}
