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
    
    public partial class REPCAT__TEMPLATE_OBJECTS
    {
        public REPCAT__TEMPLATE_OBJECTS()
        {
            this.REPCAT__TEMPLATE_PARMS = new HashSet<REPCAT__TEMPLATE_PARMS>();
        }
    
        public decimal TEMPLATE_OBJECT_ID { get; set; }
        public decimal REFRESH_TEMPLATE_ID { get; set; }
        public string OBJECT_NAME { get; set; }
        public decimal OBJECT_TYPE { get; set; }
        public Nullable<decimal> OBJECT_VERSION_ { get; set; }
        public string DDL_TEXT { get; set; }
        public string MASTER_ROLLBACK_SEG { get; set; }
        public string DERIVED_FROM_SNAME { get; set; }
        public string DERIVED_FROM_ONAME { get; set; }
        public Nullable<decimal> FLAVOR_ID { get; set; }
        public string SCHEMA_NAME { get; set; }
        public decimal DDL_NUM { get; set; }
        public decimal TEMPLATE_REFGROUP_ID { get; set; }
        public byte[] FLAGS { get; set; }
        public string SPARE1 { get; set; }
    
        public virtual REPCAT__OBJECT_TYPES REPCAT__OBJECT_TYPES { get; set; }
        public virtual REPCAT__REFRESH_TEMPLATES REPCAT__REFRESH_TEMPLATES { get; set; }
        public virtual ICollection<REPCAT__TEMPLATE_PARMS> REPCAT__TEMPLATE_PARMS { get; set; }
    }
}