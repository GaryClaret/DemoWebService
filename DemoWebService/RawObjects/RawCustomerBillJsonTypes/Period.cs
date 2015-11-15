using System;
using System.Collections.Generic;
using DemoWebService.RawObjects.RawCustomerBillJsonTypes;
using System.Runtime.Serialization;

namespace DemoWebService.RawObjects.RawCustomerBillJsonTypes
{
    [Serializable]
    [DataContract]
    public class Period
    {
        [DataMember]
        public string From { get; set; }

        [DataMember]
        public string To { get; set; }
    }

}
