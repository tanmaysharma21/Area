using System;
using System.Collections.Generic;
using System.Text;

namespace TaxiBookingSystem
{
    public class TaxiBooker
    {
        ITaxi taxi;
        ConfigurationManager configurationManager;
        DistanceTravelled distanceTravelled;
        CostCalculator costCalculator;

        public TaxiBooker()
        {
            configurationManager = new ConfigurationManager("Ola", 30, 5);
            taxi = configurationManager.TaxiType();
            distanceTravelled = new DistanceTravelled(6);
            costCalculator = configurationManager.GetCostCalculator();
        }

        public int CostCalculation()
        {
            return costCalculator.CalculatingCost(distanceTravelled);
        }
        

    }
}
