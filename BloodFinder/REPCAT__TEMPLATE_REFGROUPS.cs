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
    
    public partial class REPCAT__TEMPLATE_REFGROUPS
    {
        public decimal REFRESH_GROUP_ID { get; set; }
        public string REFRESH_GROUP_NAME { get; set; }
        public decimal REFRESH_TEMPLATE_ID { get; set; }
        public string ROLLBACK_SEG { get; set; }
        public string START_DATE { get; set; }
        public string INTERVAL { get; set; }
    
        public virtual REPCAT__REFRESH_TEMPLATES REPCAT__REFRESH_TEMPLATES { get; set; }
    }
}
