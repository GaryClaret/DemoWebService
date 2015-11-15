using System;
using System.Collections.Generic;
using DemoWebService.RawObjects.RawCustomerBillJsonTypes;
using System.Runtime.Serialization;

namespace DemoWebService.RawObjects.RawCustomerBillJsonTypes
{
    [Serializable]
    [DataContract]
    public class Package
    {
        [DataMember]
        public Subscription[] Subscriptions { get; set; }

        [DataMember]
        public double Total { get; set; }
    }

}
