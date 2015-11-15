using System;
using System.Collections.Generic;
using DemoWebService.RawObjects.RawCustomerBillJsonTypes;
using System.Runtime.Serialization;

namespace DemoWebService.RawObjects.RawCustomerBillJsonTypes
{
    [Serializable]
    [DataContract]
    public class Call
    {
        [DataMember]
        public string Called { get; set; }

        [DataMember]
        public string Duration { get; set; }

        [DataMember]
        public double Cost { get; set; }
    }

}
