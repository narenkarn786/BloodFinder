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
    
    public partial class REPCAT__EXTENSION
    {
        public REPCAT__EXTENSION()
        {
            this.REPCAT__SITES_NEW = new HashSet<REPCAT__SITES_NEW>();
        }
    
        public System.Guid EXTENSION_ID { get; set; }
        public Nullable<decimal> EXTENSION_CODE { get; set; }
        public string MASTERDEF { get; set; }
        public string EXPORT_REQUIRED { get; set; }
        public Nullable<decimal> REPCATLOG_ID { get; set; }
        public Nullable<decimal> EXTENSION_STATUS { get; set; }
        public Nullable<decimal> FLASHBACK_SCN { get; set; }
        public string PUSH_TO_MDEF { get; set; }
        public string PUSH_TO_NEW { get; set; }
        public Nullable<decimal> PERCENTAGE_FOR_CATCHUP_MDEF { get; set; }
        public Nullable<decimal> CYCLE_SECONDS_MDEF { get; set; }
        public Nullable<decimal> PERCENTAGE_FOR_CATCHUP_NEW { get; set; }
        public Nullable<decimal> CYCLE_SECONDS_NEW { get; set; }
    
        public virtual ICollection<REPCAT__SITES_NEW> REPCAT__SITES_NEW { get; set; }
    }
}
