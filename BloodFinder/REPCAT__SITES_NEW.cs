//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BloodFinder
{
    using System;
    using System.Collections.Generic;
    
    public partial class REPCAT__SITES_NEW
    {
        public System.Guid EXTENSION_ID { get; set; }
        public string GOWNER { get; set; }
        public string GNAME { get; set; }
        public string DBLINK { get; set; }
        public string FULL_INSTANTIATION { get; set; }
        public Nullable<decimal> MASTER_STATUS { get; set; }
    
        public virtual REPCAT__EXTENSION REPCAT__EXTENSION { get; set; }
        public virtual REPCAT__REPCAT REPCAT__REPCAT { get; set; }
    }
}