using System;

namespace replace_condition_logic_with_strategy
{
    public class Cart
    {
        public double ShippingFee(string shipper, double length, double width, double height, double weight)
        {
            if (shipper.Equals("black cat"))
            {
                if (weight > 20)
                {
                    return 500;
                }
                else
                {
                    return 100 + weight * 10;
                }
            }
            else if (shipper.Equals("hsinchu"))
            {
                double size = length * width * height;
                if (length > 100 || width > 100 || height > 100)
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
                double feeByWeight = 80 + weight * 10;
                double size = length * width * height;
                double feeBySize = size * 0.00002 * 1100;
                return feeByWeight < feeBySize ? feeByWeight : feeBySize;
            }
            else
            {
                throw new ArgumentException("shipper not exist");
            }
        }
    }
}