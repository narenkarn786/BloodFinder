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
    
    public partial class REPCAT__FLAVOR_OBJECTS
    {
        public decimal FLAVOR_ID { get; set; }
        public string GOWNER { get; set; }
        public string GNAME { get; set; }
        public string SNAME { get; set; }
        public string ONAME { get; set; }
        public decimal TYPE { get; set; }
        public Nullable<decimal> VERSION_ { get; set; }
        public byte[] HASHCODE { get; set; }
        public byte[] COLUMNS_PRESENT { get; set; }
    
        public virtual REPCAT__REPCAT REPCAT__REPCAT { get; set; }
    }
}
