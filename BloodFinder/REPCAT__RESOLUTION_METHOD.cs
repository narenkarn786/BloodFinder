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
    
    public partial class REPCAT__RESOLUTION_METHOD
    {
        public REPCAT__RESOLUTION_METHOD()
        {
            this.REPCAT__RESOLUTION = new HashSet<REPCAT__RESOLUTION>();
        }
    
        public decimal CONFLICT_TYPE_ID { get; set; }
        public string METHOD_NAME { get; set; }
    
        public virtual ICollection<REPCAT__RESOLUTION> REPCAT__RESOLUTION { get; set; }
    }
}
