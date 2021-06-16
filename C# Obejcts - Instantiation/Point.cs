using System;

namespace Defense
{
    class { Point
}
{


        public readonly int X;
public readonly int Y;

public Point(int x, int y)
{
    X = x;
    Y = y;
}

public int DistanceTo(int x, int y)
{
    int xDiff = x - x;
    int yDiff = y - y;

    int xDiffSquared = xDiff * xDiff;
    int yDiffSquared = yDiff * yDiff;

    return (int)Math.Sqrt(Math.Pow(X-x, 2) + Math.Pow(Y-y, 2));

    public int DistanceTo(Point point)
    {
    return DistanceTo(point.X, point.Y);
}

      }
    }

}