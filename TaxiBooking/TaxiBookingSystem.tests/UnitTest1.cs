using System;
using Xunit;

namespace TaxiBookingSystem.tests
{
    public class TaxiTest
    {
        [Fact]
        public void TaxiObjectType()
        {
            ConfigurationManager configurationManager = new ConfigurationManager("Ola", 30, 5);
            ITaxi taxi = configurationManager.TaxiType();
            Assert.Equal(taxi.GetType(), typeof(Ola));
        }

        [Fact]
        public void CostGreaterThanMinimumCost()
        {
            CostCalculator costCalculator = new CostCalculator(30, 5);
            DistanceTravelled distanceTravelled = new DistanceTravelled(7);
            Assert.Equal(35, costCalculator.CalculatingCost(distanceTravelled));
        }

        [Fact]
        public void CostLessThanMinimumCost()
        {
            CostCalculator costCalculator = new CostCalculator(30, 5);
            DistanceTravelled distanceTravelled = new DistanceTravelled(5);
            Assert.Equal(30, costCalculator.CalculatingCost(distanceTravelled));
        }

    }
}
