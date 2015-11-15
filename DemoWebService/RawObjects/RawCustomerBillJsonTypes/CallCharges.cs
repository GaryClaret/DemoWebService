using System;
using System.Collections.Generic;
using DemoWebService.RawObjects.RawCustomerBillJsonTypes;
using System.Runtime.Serialization;

namespace DemoWebService.RawObjects.RawCustomerBillJsonTypes
{
    [Serializable]
    [DataContract]
    public class CallCharges
    {
        [DataMember]
        public Call[] Calls { get; set; }

        [DataMember]
        public double Total { get; set; }
    }

}
