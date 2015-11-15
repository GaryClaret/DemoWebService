using DemoWebService.RawObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace DemoWebService
{
    [ServiceContract]
    public interface ICustomerDataWebService
    {
        [OperationContract]
        RawCustomerBill GetCustomerBill();
    }
}
