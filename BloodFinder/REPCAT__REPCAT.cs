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
    
    public partial class REPCAT__REPCAT
    {
        public REPCAT__REPCAT()
        {
            this.REPCAT__FLAVOR_OBJECTS = new HashSet<REPCAT__FLAVOR_OBJECTS>();
            this.REPCAT__FLAVORS = new HashSet<REPCAT__FLAVORS>();
            this.REPCAT__REPGROUP_PRIVS = new HashSet<REPCAT__REPGROUP_PRIVS>();
            this.REPCAT__REPOBJECT = new HashSet<REPCAT__REPOBJECT>();
            this.REPCAT__REPSCHEMA = new HashSet<REPCAT__REPSCHEMA>();
            this.REPCAT__SITES_NEW = new HashSet<REPCAT__SITES_NEW>();
        }
    
        public string GOWNER { get; set; }
        public string SNAME { get; set; }
        public string MASTER { get; set; }
        public Nullable<decimal> STATUS { get; set; }
        public string SCHEMA_COMMENT { get; set; }
        public Nullable<decimal> FLAVOR_ID { get; set; }
        public byte[] FLAG { get; set; }
    
        public virtual ICollection<REPCAT__FLAVOR_OBJECTS> REPCAT__FLAVOR_OBJECTS { get; set; }
        public virtual ICollection<REPCAT__FLAVORS> REPCAT__FLAVORS { get; set; }
        public virtual ICollection<REPCAT__REPGROUP_PRIVS> REPCAT__REPGROUP_PRIVS { get; set; }
        public virtual ICollection<REPCAT__REPOBJECT> REPCAT__REPOBJECT { get; set; }
        public virtual ICollection<REPCAT__REPSCHEMA> REPCAT__REPSCHEMA { get; set; }
        public virtual ICollection<REPCAT__SITES_NEW> REPCAT__SITES_NEW { get; set; }
    }
}
