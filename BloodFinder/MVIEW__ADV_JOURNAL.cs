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
    
    public partial class MVIEW__ADV_JOURNAL
    {
        public decimal RUNID_ { get; set; }
        public decimal SEQ_ { get; set; }
        public System.DateTime TIMESTAMP { get; set; }
        public decimal FLAGS { get; set; }
        public Nullable<decimal> NUM { get; set; }
        public string TEXT { get; set; }
        public Nullable<decimal> TEXTLEN { get; set; }
    
        public virtual MVIEW__ADV_LOG MVIEW__ADV_LOG { get; set; }
    }
}
