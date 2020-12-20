using System;

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
    }

    public class Cart
    {
        public double ShippingFee(string shipper, Product product)
        {
            if (shipper.Equals("black cat"))
            {
                if (product.Weight > 20)
                {
                    return 500;
                }
                else
                {
                    return 100 + product.Weight * 10;
                }
            }
            else if (shipper.Equals("hsinchu"))
            {
                var size = Size(product);
                if (product.Length > 100 || product.Width > 100 || product.Height > 100)
                {
                    return size * 0.00002 * 1100 + 500;
                }
                else
                {
                    return size * 0.00002 * 1200;
                }
            }
            else if (shipper.Equals("post office"))
            {
                double feeByWeight = 80 + product.Weight * 10;
                double size = product.Length * product.Width * product.Height;
                double feeBySize = size * 0.00002 * 1100;
                return feeByWeight < feeBySize ? feeByWeight : feeBySize;
            }
            else
            {
                throw new ArgumentException("shipper not exist");
            }
        }

        private static double Size(Product product)
        {
            double size = product.Length * product.Width * product.Height;
            return size;
        }
    }
}