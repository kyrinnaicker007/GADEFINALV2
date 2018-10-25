namespace GADEPOE_FINALNEW
{
    class GameEngine
    {
        public Map map = new Map();
        public ResourceBuilding res = new ResourceBuilding(0,0,"def","def");

        public GameEngine()
        {

        }

        private void SwitchUnitTurn()
        {
            //searches for a specific unit and selects their turn
            for (int k = 0; k < map.arrUnits.Length; k++)
            {
                if (map.arrUnits[k] != null)
                {
                    //this replaces the original position of with a open space, checks also if theres an empty space.
                    map.mapArray[map.arrUnits[k].YPosition, map.arrUnits[k].XPosition] = "";

                    //checks to see if a units alive
                    if (map.arrUnits[k].Hp > 0)
                    {
                        //if a specific unit drops below the hp of 25 it runs away
                        if ((map.arrUnits[k].Hp / map.arrUnits[k].MaxHP) * 100 <= 25 / 100)
                        {
                            //checks to see if an enemy is in range, a unit will attack within that range
                            map.arrUnits[k].NewPos();
                            if (map.arrUnits[k].withinRange(map.arrUnits[k].closestUnit(map.arrUnits)) == true)
                            {
                                for (int z = 0; z < map.arrUnits.Length; z++)
                                {
                                    if (map.arrUnits[z] == map.arrUnits[k].closestUnit(map.arrUnits) && map.arrUnits[z] != null) map.arrUnits[z].Hp -= map.arrUnits[k].Atk();
                                }
                            }

                        }
                        //this else checks to see if a unit is not running away
                        else
                        {
                            if (map.arrUnits[k].withinRange(map.arrUnits[k].closestUnit(map.arrUnits)) == true)
                            {
                                for (int z = 0; z < map.arrUnits.Length; z++)
                                {
                                    if (map.arrUnits[z] == map.arrUnits[k].closestUnit(map.arrUnits) && map.arrUnits[z] != null) map.arrUnits[z].Hp -= map.arrUnits[k].Atk();
                                }
                            }
                            else
                                map.arrUnits[k].Combat(map.arrUnits[k].closestUnit(map.arrUnits));

                        }
                        map.mapArray[map.arrUnits[k].YPosition, map.arrUnits[k].XPosition] = map.arrUnits[k].Symbol;

                    }
                    else
                    {
                        map.mapArray[map.arrUnits[k].YPosition, map.arrUnits[k].XPosition] = "*";
                        map.arrUnits[k] = null;
                    }
                }
            }
        }

        public void BeginGame()
        {
            SwitchUnitTurn();

            for(int k =0; k < map.build.Length;k++)
            {
                if (map.build[k] != null)
                    map.mapArray[map.build[k].YPosition, map.build[k].YPosition] = map.build[k].Symbol;
            }

        }
    }
}

