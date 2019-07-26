using System;
using System.Collections.Generic;
using System.Text;

namespace TaxiBookingSystem
{
    public class CostCalculator
    {
        int minimumCost;
        int perKilometerCost;

        public CostCalculator(int minimumCost, int perKilometerCost)
        {
            this.minimumCost = minimumCost;
            this.perKilometerCost = perKilometerCost;
        }

        public int CalculatingCost(DistanceTravelled distanceTravelled)
        {
            int cost = distanceTravelled.distanceInKilometer * perKilometerCost;
            if (cost < minimumCost)
                return minimumCost;
            return cost;
        }


    }
}
