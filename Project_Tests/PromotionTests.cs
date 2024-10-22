﻿
using Project;

namespace Project_Tests
{
    public class PromotionTests
    {
        [Test]
        //Should create promotion
        public void PromotionCreation()
        {
            var promotion = new Promotion("Summer Sale", "20% off", 20);

            Assert.AreEqual("Summer Sale", promotion.Name);
            Assert.AreEqual("20% off", promotion.Description);
            Assert.AreEqual(20, promotion.DiscountPercentage);
        }

        [Test]
        //Should return correct promotion details
        public void ToString()
        {
            var promotion = new Promotion("Summer Sale", "20% off", 20);

            string result = promotion.ToString();

            Assert.IsTrue(result.Contains("Discount: 20"));
        }
    }
}