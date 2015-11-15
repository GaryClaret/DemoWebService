using DemoWebService.RawObjects;
using DemoWebService.Retrievers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace DemoWebService
{
    public class CustomerDataWebService : ICustomerDataWebService
    {
        public RawCustomerBill GetCustomerBill()
        {
            return BillApiClient.GetCustomerBill();
        }
    }
}
