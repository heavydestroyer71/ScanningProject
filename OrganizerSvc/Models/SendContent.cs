using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrganizerSvc.Models
{
    public class dataString
    {
        public string k { get; set; }
        public byte[] v { get; set; }
        public string c { get; set; }
        public string a { get; set; }
    }
    public class SendContent
    {
        public string userName { get; set; }
        public string challan_no { get; set; }
        public string box_no { get; set; }
        public string batch_no { get; set; }
        public byte[] image { get; set; }
        public string fileName { get; set; }
    }
}