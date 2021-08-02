
namespace Denfense
{
    class MapLocation : Point

    {
        public MapLocation(int x, int y, Map map) : base(5, 5);
        { 
        if (!map.OnMap(this))
            {
            throw new OutOfBoundsException(x + "," + y + " is outside the boundaries of the map.");
        }
        }
    }
}