using System;
using System.Collections.Generic;
using System.Text;

namespace TaxiBookingSystem
{
    public class TaxiFactory
    {
        public ITaxi GetTaxi(string taxiName)
        {
            switch (taxiName.ToLowerInvariant())
            {
                case "ola":
                    return new Ola();
                case "uber":
                    return new Uber();
                default :
                    throw new NotImplementedException();
            }
        }
    }
}
