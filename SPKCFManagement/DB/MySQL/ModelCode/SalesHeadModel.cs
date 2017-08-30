using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace SPKCFManagement.DB.MySQL.spkcms
{

    public partial class SalesHeadModel
    {
        public SalesHeadModel(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
