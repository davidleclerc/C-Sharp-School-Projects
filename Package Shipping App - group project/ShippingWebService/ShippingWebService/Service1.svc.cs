using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ShippingWebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public decimal GetAdditionalCost(string service)
        {
            if (service == "UPS")
            {
                return 1.29m;
            }
            else if (service == "FEDEX")
            {
                return 0.99m;
            }
            else
            {
                return 1.98m;
            }
        }

        public decimal GetCostPerOunce(string service)
        {
            if (service == "UPS")
            {
                return 5.65m;
            } else if (service == "FEDEX")
            {
                return 4.90m;
            } else
            {
                return 6.17m;
            }
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public decimal GetFlatFee(string service)
        {
            if (service == "UPS")
            {
                return 2.50m;
            }
            else if (service == "FEDEX")
            {
                return 2.00m;
            }
            else
            {
                return 3.0m;
            }
        }
    }
}
