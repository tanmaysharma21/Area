using System;
using System.Collections.Generic;
using System.Text;

namespace TaxiBookingSystem
{
    public class ConfigurationManager
    {
        ITaxi taxi;
        CostCalculator costCalculator;

        public ConfigurationManager(string taxiName, int minimumPayment, int perKilometerCost)
        {
            TaxiFactory taxiFactory = new TaxiFactory();
            taxi = taxiFactory.GetTaxi(taxiName);
            costCalculator = new CostCalculator(minimumPayment, perKilometerCost);
        }

        public ITaxi TaxiType()
        {
            return taxi;
        }

        public CostCalculator GetCostCalculator()
        {
            return costCalculator;
        }

    }
}
