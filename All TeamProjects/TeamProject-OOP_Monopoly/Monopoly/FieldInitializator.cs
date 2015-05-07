namespace Monopoly
{
    using System.Collections.Generic;

    using Monopoly;

    public static class FieldInitializator
    {
        public static IList<Space> GetField()
        {
            List<Space> listOfSpaces = new List<Space>();

            //ChanceSpace ChanceSpaceObject=new ChanceSpace();
            CommunityChestSpace communityChestSpaceObject = new CommunityChestSpace();
            ChanceSpace chanceSpaceObject = new ChanceSpace();
            ParkingSpace parking = new ParkingSpace();

            listOfSpaces.Add(parking);
            PropertySpace oldKentRoad = new PropertySpace("Old Kent Road", 60, 30, 2, 10, 30, 90, 160, 250, Color.Brown);
            listOfSpaces.Add(oldKentRoad);
            listOfSpaces.Add(communityChestSpaceObject);
            PropertySpace whiteChappelRoad = new PropertySpace("White Chapel Road", 60, 30, 4, 20, 60, 180, 320, 450, Color.Brown);
            listOfSpaces.Add(whiteChappelRoad);
            Tax incomeTax = new Tax(200);
            listOfSpaces.Add(incomeTax);
            RailRoad kingsCrossStation = new RailRoad("Kings Cross Station", 200, 100, 25);
            listOfSpaces.Add(kingsCrossStation);
            PropertySpace theAngleIslington = new PropertySpace("The Angel Islington", 100, 50, 6, 30, 90, 270, 400, 550, Color.LightBlue);
            listOfSpaces.Add(theAngleIslington);
            listOfSpaces.Add(chanceSpaceObject);
            PropertySpace eustonRoad = new PropertySpace("Euston Road", 100, 50, 6, 30, 90, 270, 400, 550, Color.LightBlue);
            listOfSpaces.Add(eustonRoad);
            PropertySpace pentonvilleRoad = new PropertySpace("Pentonville Road", 120, 60, 8, 40, 100, 300, 450, 600, Color.LightBlue);
            listOfSpaces.Add(pentonvilleRoad);
            Jail jail = new Jail();
            listOfSpaces.Add(jail);
            PropertySpace pallMall = new PropertySpace("Pall Mall", 140, 70, 10, 50, 150, 450, 625, 750, Color.Pink);
            listOfSpaces.Add(pallMall);
            UtilitySpace electricCompany = new UtilitySpace("Electric Company", 150, 75, 30);
            listOfSpaces.Add(electricCompany);
            PropertySpace whitehall = new PropertySpace("Whitehall", 140, 70, 10, 50, 150, 450, 625, 750, Color.Pink);
            listOfSpaces.Add(whitehall);
            PropertySpace nortamberLandAvenue = new PropertySpace("Northumberland avenue", 160, 80, 12, 60, 180, 500, 700, 900, Color.Pink);
            listOfSpaces.Add(nortamberLandAvenue);
            RailRoad marylibone = new RailRoad("Marylibone station", 200, 100, 25);
            listOfSpaces.Add(marylibone);
            PropertySpace bawStreet = new PropertySpace("Bow Street", 180, 90, 14, 70, 200, 550, 750, 950, Color.Orange);
            listOfSpaces.Add(bawStreet);
            listOfSpaces.Add(communityChestSpaceObject);
            PropertySpace marlboroStreet = new PropertySpace("Marlborough Street", 180, 90, 14, 70, 200, 550, 750, 950, Color.Orange);
            listOfSpaces.Add(marlboroStreet);
            PropertySpace vineStreet = new PropertySpace("Vine Street", 200, 100, 16, 80, 220, 600, 800, 1000, Color.Orange);
            listOfSpaces.Add(vineStreet);
            listOfSpaces.Add(parking);
            PropertySpace strand = new PropertySpace("Strand", 200, 110, 18, 90, 250, 700, 875, 1050, Color.Red);
            listOfSpaces.Add(strand);
            listOfSpaces.Add(chanceSpaceObject);
            PropertySpace fleetStreet = new PropertySpace("Fleet Street", 220, 110, 18, 90, 250, 700, 875, 1050, Color.Red);
            listOfSpaces.Add(fleetStreet);
            PropertySpace trafalfarQuare = new PropertySpace("Trafalgar Square", 240, 120, 20, 100, 300, 750, 925, 1100, Color.Red);
            listOfSpaces.Add(trafalfarQuare);
            RailRoad fanchurchStation = new RailRoad("Fanchurch Station", 200, 100, 25);
            listOfSpaces.Add(fanchurchStation);
            PropertySpace leicesterSquare = new PropertySpace("Leicester square", 260, 130, 22, 110, 330, 800, 975, 1150, Color.Yellow);
            listOfSpaces.Add(leicesterSquare);
            PropertySpace coventryStreet = new PropertySpace("Coventry Street", 260, 130, 22, 110, 330, 800, 975, 1150, Color.Yellow);
            listOfSpaces.Add(coventryStreet);
            UtilitySpace waterCompany = new UtilitySpace("Water Company", 150, 75, 30);
            listOfSpaces.Add(waterCompany);
            PropertySpace piccadilly = new PropertySpace("Piccadilly", 280, 140, 22, 120, 360, 850, 1025, 1200, Color.Yellow);
            listOfSpaces.Add(piccadilly);
            GoToPrison gotoPrison = new GoToPrison();
            listOfSpaces.Add(gotoPrison);
            PropertySpace oxfordStreet = new PropertySpace("Oxford Street", 300, 150, 26, 130, 390, 900, 1100, 1275, Color.Green);
            listOfSpaces.Add(oxfordStreet);
            PropertySpace regentStreet = new PropertySpace("Regent Street", 300, 150, 26, 130, 390, 900, 1100, 1275, Color.Green);
            listOfSpaces.Add(regentStreet);
            listOfSpaces.Add(communityChestSpaceObject);
            PropertySpace bondStreet = new PropertySpace("Bond Street", 320, 160, 28, 150, 450, 1000, 1200, 1400, Color.Green);
            listOfSpaces.Add(bondStreet);
            RailRoad liverpoolStation = new RailRoad("Liverpool Station", 200, 100, 25);
            listOfSpaces.Add(liverpoolStation);
            listOfSpaces.Add(chanceSpaceObject);
            PropertySpace parkLane = new PropertySpace("Park Lane", 350, 175, 35, 175, 500, 1100, 1300, 1500, Color.DarkBlue);
            listOfSpaces.Add(parkLane);
            Tax superTax = new Tax(100);
            listOfSpaces.Add(superTax);
            PropertySpace mayfair = new PropertySpace("Mayfair", 400, 200, 50, 200, 600, 1400, 1700, 2000, Color.DarkBlue);
            listOfSpaces.Add(mayfair);

            return listOfSpaces;
        }
    }
}
