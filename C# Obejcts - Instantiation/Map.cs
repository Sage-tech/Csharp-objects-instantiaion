namespace Defense

{
    class Map
    {
        public readonly int Width;
        public readonly int Height;

        public Map(int width, int height)
        {
            Width = width;
            Height = height;
        }
        public bool OnMap(Point point)
        {
            return point.X >= 0 && point.X < Width &&
                point.Y >= 0 && point.Y < Height;
            // bool outBounds = !(point.X < 0 || point.X >= Width || point.Y >= Height;)

        }

    }

}23e4rw5dc2 f