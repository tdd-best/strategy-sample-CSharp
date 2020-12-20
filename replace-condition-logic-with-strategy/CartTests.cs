#region

using NUnit.Framework;

#endregion

namespace replace_condition_logic_with_strategy
{
    [TestFixture]
    public class CartTests
    {
        private readonly string blackCat = "black cat";
        private readonly Cart cart = new Cart();
        private readonly string hsinchu = "hsinchu";
        private readonly string postOffice = "post office";

        [Test]
        public void black_cat_with_light_weight()
        {
            double shippingFee = cart.ShippingFee(blackCat, 30, 20, 10, 5);
            feeShouldBe(150, shippingFee);
        }

        [Test]
        public void black_cat_with_heavy_weight()
        {
            double shippingFee = cart.ShippingFee(blackCat, 30, 20, 10, 50);
            feeShouldBe(500, shippingFee);
        }

        [Test]
        public void hsinchu_with_small_size()
        {
            double shippingFee = cart.ShippingFee(hsinchu, 30, 20, 10, 50);
            feeShouldBe(144, shippingFee);
        }

        [Test]
        public void hsinchu_with_huge_size()
        {
            double shippingFee = cart.ShippingFee(hsinchu, 100, 20, 10, 50);
            feeShouldBe(480, shippingFee);
        }

        [Test]
        public void post_office_by_weight()
        {
            double shippingFee = cart.ShippingFee(postOffice, 100, 20, 10, 3);
            feeShouldBe(110, shippingFee);
        }

        [Test]
        public void post_office_by_size()
        {
            double shippingFee = cart.ShippingFee(postOffice, 100, 20, 10, 300);
            feeShouldBe(440, shippingFee);
        }

        private void feeShouldBe(double expected, double shippingFee)
        {
            Assert.AreEqual(expected, shippingFee);
        }
    }
}