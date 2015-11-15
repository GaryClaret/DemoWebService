using System;
using System.Collections.Generic;
using DemoWebService.RawObjects.RawCustomerBillJsonTypes;
using System.Runtime.Serialization;

namespace DemoWebService.RawObjects
{
    [Serializable]
    [DataContract]
    public class RawCustomerBill
    {
        [DataMember]
        public Statement Statement { get; set; }

        [DataMember]
        public double Total { get; set; }

        [DataMember]
        public Package Package { get; set; }

        [DataMember]
        public CallCharges CallCharges { get; set; }

        [DataMember]
        public SkyStore SkyStore { get; set; }
    }

}
