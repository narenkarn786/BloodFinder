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
    
    public partial class REPCAT__USER_PARM_VALUES
    {
        public decimal USER_PARAMETER_ID { get; set; }
        public decimal TEMPLATE_PARAMETER_ID { get; set; }
        public decimal USER_ID { get; set; }
        public string PARM_VALUE { get; set; }
    
        public virtual REPCAT__TEMPLATE_PARMS REPCAT__TEMPLATE_PARMS { get; set; }
    }
}