﻿using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.Persistent.Base;
namespace Nhom4QuanLyBanThucPham.Module.BusinessObjects.ORMDataModel1
{
    [DefaultClassOptions]
    [NavigationItem("Hệ Thống")]
    public partial class Chitietdonhang
    {
        public Chitietdonhang(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
