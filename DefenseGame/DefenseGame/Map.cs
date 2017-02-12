namespace DefenseGame
{
    public class Map
    {
        private const string EXCEPTION_MESSAGE = "Map must be at least 1x1";
        public readonly int Width;
        public readonly int Height;

        public Map(int width, int height)
        {
            if (width < 1 || height < 1)
            {
                throw new System.ArgumentOutOfRangeException(EXCEPTION_MESSAGE);
            }

            Width = width;
            Height = height;
        }

        public bool OnMap(Point point)
        {
            return point.X >= 0 && point.X < Width &&
                   point.Y >= 0 && point.Y < Height;
        }
    }
}
