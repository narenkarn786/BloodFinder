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
    
    public partial class REPCAT__RESOLUTION
    {
        public REPCAT__RESOLUTION()
        {
            this.REPCAT__PARAMETER_COLUMN = new HashSet<REPCAT__PARAMETER_COLUMN>();
        }
    
        public string SNAME { get; set; }
        public string ONAME { get; set; }
        public decimal CONFLICT_TYPE_ID { get; set; }
        public string REFERENCE_NAME { get; set; }
        public decimal SEQUENCE_NO { get; set; }
        public string METHOD_NAME { get; set; }
        public string FUNCTION_NAME { get; set; }
        public string PRIORITY_GROUP { get; set; }
        public string RESOLUTION_COMMENT { get; set; }
    
        public virtual REPCAT__CONFLICT REPCAT__CONFLICT { get; set; }
        public virtual ICollection<REPCAT__PARAMETER_COLUMN> REPCAT__PARAMETER_COLUMN { get; set; }
        public virtual REPCAT__RESOLUTION_METHOD REPCAT__RESOLUTION_METHOD { get; set; }
    }
}
