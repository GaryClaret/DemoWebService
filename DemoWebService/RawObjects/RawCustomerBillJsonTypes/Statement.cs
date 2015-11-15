using System;
using System.Collections.Generic;
using DemoWebService.RawObjects.RawCustomerBillJsonTypes;
using System.Runtime.Serialization;

namespace DemoWebService.RawObjects.RawCustomerBillJsonTypes
{
    [Serializable]
    [DataContract]
    public class Statement
    {
        [DataMember]
        public string Generated { get; set; }

        [DataMember]
        public string Due { get; set; }

        [DataMember]
        public Period Period { get; set; }
    }

}
