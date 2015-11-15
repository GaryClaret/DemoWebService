using System;
using System.Collections.Generic;
using DemoWebService.RawObjects.RawCustomerBillJsonTypes;
using System.Runtime.Serialization;

namespace DemoWebService.RawObjects.RawCustomerBillJsonTypes
{
    [Serializable]
    [DataContract]
    public class BuyAndKeep
    {
        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public double Cost { get; set; }
    }

}
