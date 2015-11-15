using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.IO;
using System.Runtime.Serialization.Json;
using DemoWebService.RawObjects;
using System.Text;
using Newtonsoft.Json;

namespace DemoWebService.Retrievers
{
    public static class BillApiClient
    {
        public static RawCustomerBill GetCustomerBill()
        {
            var customerBillApiUrl = "http://safe-plains-5453.herokuapp.com/bill.json";
            var syncClient = new WebClient();
            var content = syncClient.DownloadString(customerBillApiUrl);

            RawCustomerBill returnedBillData = JsonConvert.DeserializeObject<RawCustomerBill>(content);
            
            return returnedBillData;
        }
    }
}