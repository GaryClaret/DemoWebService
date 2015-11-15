using System;
using System.Collections.Generic;
using DemoWebService.RawObjects.RawCustomerBillJsonTypes;
using System.Runtime.Serialization;

namespace DemoWebService.RawObjects.RawCustomerBillJsonTypes
{
    [Serializable]
    [DataContract]
    public class SkyStore
    {
        [DataMember]
        public Rental[] Rentals { get; set; }

        [DataMember]
        public BuyAndKeep[] BuyAndKeep { get; set; }

        [DataMember]
        public double Total { get; set; }
    }

}
