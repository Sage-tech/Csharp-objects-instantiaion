using System;

namespace Defense
{
    class Game
    {
        public static void Main()
        {
            Map map = new Map(8, 5);
            try
            {
                MapLocation mapLocation = new MapLocation(20, 20, map);
            }
            catch (Exception)
            {
                Console.WriteLine("That map lcoation is not on the map");

                }

           //Point x = new MapLocation(4, 2);

           // Point p = x;

           // map.OnMap(new MapLocation(0, 0));

           // Console.WriteLine(x.DistanceTo(5, 5));

           // Console.WriteLine(x is MapLocation);
           // Console.WriteLine(x is Point);

           // Point point = new Point(0, 0);
           // Console.WriteLine(point is MapLocation);

        }
    }
}