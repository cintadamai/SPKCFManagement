﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace SPKCFManagement.DB.MySQL.spkcms
{

    [Persistent(@"sales")]
    public partial class SalesModel : XPLiteObject
    {
        int fkode_sales;
        [Key]
        public int kode_sales
        {
            get { return fkode_sales; }
            set { SetPropertyValue<int>("kode_sales", ref fkode_sales, value); }
        }
        string fnama_sales;
        [Size(255)]
        public string nama_sales
        {
            get { return fnama_sales; }
            set { SetPropertyValue<string>("nama_sales", ref fnama_sales, value); }
        }
        int fkode_sh;
        public int kode_sh
        {
            get { return fkode_sh; }
            set { SetPropertyValue<int>("kode_sh", ref fkode_sh, value); }
        }
        int fbranchid;
        public int branchid
        {
            get { return fbranchid; }
            set { SetPropertyValue<int>("branchid", ref fbranchid, value); }
        }
    }

}