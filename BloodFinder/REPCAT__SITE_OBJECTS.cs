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
    
    public partial class REPCAT__SITE_OBJECTS
    {
        public decimal TEMPLATE_SITE_ID { get; set; }
        public string SNAME { get; set; }
        public string ONAME { get; set; }
        public decimal OBJECT_TYPE_ID { get; set; }
    
        public virtual REPCAT__OBJECT_TYPES REPCAT__OBJECT_TYPES { get; set; }
        public virtual REPCAT__TEMPLATE_SITES REPCAT__TEMPLATE_SITES { get; set; }
    }
}
