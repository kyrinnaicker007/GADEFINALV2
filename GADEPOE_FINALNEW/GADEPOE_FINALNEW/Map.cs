using System;

namespace GADEPOE_FINALNEW
{
    class Map
    {
        //map array created for game to be parametered around
        public string[,] mapArray = new string[20, 20];
        //unit array created to stroe the amount of units 
        public Unit[] arrUnits = new Unit[10];
        //string name array created to store the different units from different teams
        string[] Names = new string[]{
            "Ragnor","Bravo","Kaylee","Sondheim","Loki","Slika","Hela","Asger","Grobble","Egil","Steve","Hagen","Jumanji"
            ,"Rakitic","Dyablo","Jerrik","Halvar","Igor"
        };
        //building array created to store the amount of buildings placed on the map
        public Building[] build = new Building[8];

        //random created to randomise the units place and buildings place
        Random r = new Random();

        public Map()
        {

        }

        //this method places the units within the map
        public void UnitPlacing()
        {
            for (int k = 0; k < arrUnits.Length; k++)
            {
                int unitSelection;
                int Team;
                int name = r.Next(0, Names.Length);

                string placeTeam = "";
                string placeSymbol = "";

                int x = r.Next(1, 20);
                int y = r.Next(1, 20);

                unitSelection = r.Next(1, 3);

                switch (unitSelection)
                {
                    case 1://meleee unit of the rogues who are the villains
                        Team = r.Next(1, 3);
                        switch (Team)
                        {
                            case 1:
                                placeTeam = "Rogue Team 1";
                                placeSymbol = "M";
                                break;

                            case 2:
                                placeTeam = "Rogue Team 2";
                                placeSymbol = "m";
                                break;
                        }
                        arrUnits[k] = new MeleeUnit(x, y, placeTeam, placeSymbol, Names[name]);
                        break;

                    case 2://ranged unit of the vikings who are the heroes
                        Team = r.Next(1, 3);
                        switch (Team)
                        {
                            case 1:
                                placeTeam = "Hero Team 1";
                                placeSymbol = "R";
                                break;

                            case 2:
                                placeTeam = "Hero Team 2";
                                placeSymbol = "r";
                                break;
                        }
                        arrUnits[k] = new RangedUnit(x, y, placeTeam, placeSymbol, Names[name]);
                        break;
                }
                mapArray[arrUnits[k].YPosition, arrUnits[k].XPosition] = arrUnits[k].Symbol;


            }
        }

        

        public void Battlefield()
        {
            //populates the map and fills it with the array size of 20 x 20 fullstops
            for(int k =0; k < 20; k++)
            {
                for(int j =0; j <20; j++)
                {
                    mapArray[k, j] = ".";
                }
            }
        }

        public void FillMap()
        {
            UnitPlacing();
            BuildPlacing();

            for(int k =0; k < arrUnits.Length;k++)
            {
                Console.WriteLine(arrUnits[k].ToString());
            }
            for(int k =0; k < build.Length;k++)
            {
                Console.WriteLine(build[k].ToString());
            }
        }

        //this method adds buildings to the map
        public void BuildPlacing()
        {
            int i = 0;
            int Team;

            string placeTeam = "";
            string placeSymbol = "";

            //assigned factory buildings to the first to teams
            build[i] = new FactoryBuilding(0, 0, "Rogue team 1", "O");
            mapArray[build[i].XPosition, build[i].YPosition] = build[i].Symbol;
            i++;
            build[i] = new FactoryBuilding(19, 19, "Hero team 1", "o");
            mapArray[build[i].XPosition, build[i].YPosition] = build[i].Symbol;

            //resource buiidings assigned to secong two teams
            for(int g = 2; g < build.Length;g++)
            {
                Team = r.Next(1, 3);
                int x = r.Next(1, 20);
                int y = r.Next(1, 20);

                switch(Team)
                {
                    case 1:
                        placeTeam = "Rogue team 2";
                        placeSymbol = "V";
                        break;
                    case 2:
                        placeTeam = "Hero team 2";
                        placeSymbol = "v";
                        break;
                }

                build[g] = new ResourceBuilding(x, y, placeTeam, placeSymbol);
                mapArray[build[g].XPosition, build[g].YPosition] = build[g].Symbol;

            }

        }
    }
}
