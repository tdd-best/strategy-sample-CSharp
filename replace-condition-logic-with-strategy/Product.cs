namespace replace_condition_logic_with_strategy
{
    public class Product
    {
        public Product(double length, double width, double height, double weight)
        {
            Length = length;
            Width = width;
            Height = height;
            Weight = weight;
        }

        public double Length { get; private set; }
        public double Width { get; private set; }
        public double Height { get; private set; }
        public double Weight { get; private set; }

        public double Size()
        {
            return Length * Width * Height;
        }
    }
}