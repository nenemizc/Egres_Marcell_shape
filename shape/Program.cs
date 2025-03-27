namespace shape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(false, "red", 1, 2);

            Shape[] shapes = { rectangle, new Square(true, "blue", 1, 1), new Circle(false, "yellow", 5) };

            Square square = new Square(false, "red", 5, 5);

            Rectangle rect = square;
            Shape shape = square;
        }

        public Shape RectVagySqr(int width, int height)
        {
            if (width == height)
            {
                return new Square(false, "blue", width, height);
            }
            else
            {
                return new Rectangle(false, "blue", width, height);
            }
        }

        public Shape MaxArea(Shape[] shapes)
        {
            double max = shapes[0].Area();
            int maxInd = 0;

            foreach (var item in shapes)
            {
                if (item.Area() > max)
                {
                    max = item.Area();
                    maxInd = Array.IndexOf(shapes, item);
                }
            }

            return shapes[maxInd];
        }
    }
}
