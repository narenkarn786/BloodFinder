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
    
    public partial class REPCAT__COLUMN_GROUP
    {
        public REPCAT__COLUMN_GROUP()
        {
            this.REPCAT__GROUPED_COLUMN = new HashSet<REPCAT__GROUPED_COLUMN>();
        }
    
        public string SNAME { get; set; }
        public string ONAME { get; set; }
        public string GROUP_NAME { get; set; }
        public string GROUP_COMMENT { get; set; }
    
        public virtual ICollection<REPCAT__GROUPED_COLUMN> REPCAT__GROUPED_COLUMN { get; set; }
    }
}
