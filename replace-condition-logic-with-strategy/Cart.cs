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

        public double Size()
        {
            return Length * Width * Height;
        }
    }

    public class Cart
    {
        public double ShippingFee(string shipper, Product product)
        {
            if (shipper.Equals("black cat"))
            {
                return CalculateFeeByBlackCat(product);
            }
            else if (shipper.Equals("hsinchu"))
            {
                return CalculateFeeByHsinchu(product);
            }
            else if (shipper.Equals("post office"))
            {
                var feeByWeight = 80 + product.Weight * 10;
                var size = product.Length * product.Width * product.Height;
                var feeBySize = size * 0.00002 * 1100;
                return Math.Min(feeByWeight, feeBySize);
            }
            else
            {
                throw new ArgumentException("shipper not exist");
            }
        }

        private static double CalculateFeeByHsinchu(Product product)
        {
            if (product.Length > 100 || product.Width > 100 || product.Height > 100)
            {
                return product.Size() * 0.00002 * 1100 + 500;
            }
            else
            {
                return product.Size() * 0.00002 * 1200;
            }
        }

        private static double CalculateFeeByBlackCat(Product product)
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
    }
}