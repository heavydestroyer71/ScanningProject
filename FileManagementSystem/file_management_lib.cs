using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace FileManagementSystem
{
    public enum region
    {
        AIR,
        BAR,
        BOG,
        CTG,
        COM,
        FAR,
        DHK,
        DHKN,
        DHKS,
        KHL,
        MYM,
        RAJ,
        SYL

    }
    public class batch_create
    {

    }


    public class challan_info_vm
    {
        public int challan_id { get; set; }
        public string challan_name { get; set; }
        public string region { get; set; }
        public string challan_box_no { get; set; }
    }
    public class utility
    {
        public static string convertStringtoDate(string dateString)
        {
            string[] dmy = dateString.Split('.');
            string date = dmy[2] + "-" + dmy[1] + "-" + dmy[0];
            return date;
        }


        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                {
                    using (var stream = client.OpenRead("http://www.google.com"))
                    {
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }
    }

}
