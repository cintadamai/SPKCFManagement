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

    [Persistent(@"user_has_branch")]
    public partial class UserHasBranchModel : XPLiteObject
    {
        int fid;
        [Key(true)]
        public int id
        {
            get { return fid; }
            set { SetPropertyValue<int>("id", ref fid, value); }
        }
        int fuserid;
        public int userid
        {
            get { return fuserid; }
            set { SetPropertyValue<int>("userid", ref fuserid, value); }
        }
        int fbranchid;
        public int branchid
        {
            get { return fbranchid; }
            set { SetPropertyValue<int>("branchid", ref fbranchid, value); }
        }
    }

}
