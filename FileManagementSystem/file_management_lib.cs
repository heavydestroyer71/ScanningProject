﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
    public class utility
    {
        public static string convertStringtoDate(string dateString)
        {
            string[] dmy = dateString.Split('.');
            string date = dmy[2] + "-" + dmy[1] + "-" + dmy[0];
            return date;
        }
    }

}