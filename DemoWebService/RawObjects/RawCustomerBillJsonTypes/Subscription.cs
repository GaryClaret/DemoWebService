using System;
using System.Collections.Generic;
using DemoWebService.RawObjects.RawCustomerBillJsonTypes;
using System.Runtime.Serialization;

namespace DemoWebService.RawObjects.RawCustomerBillJsonTypes
{
    [Serializable]
    [DataContract]
    public class Subscription
    {
        [DataMember]
        public string Type { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public double Cost { get; set; }
    }

}
