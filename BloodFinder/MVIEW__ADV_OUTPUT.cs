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
    
    public partial class MVIEW__ADV_OUTPUT
    {
        public decimal RUNID_ { get; set; }
        public decimal OUTPUT_TYPE { get; set; }
        public decimal RANK_ { get; set; }
        public string ACTION_TYPE { get; set; }
        public string SUMMARY_OWNER { get; set; }
        public string SUMMARY_NAME { get; set; }
        public string GROUP_BY_COLUMNS { get; set; }
        public string WHERE_CLAUSE { get; set; }
        public string FROM_CLAUSE { get; set; }
        public string MEASURES_LIST { get; set; }
        public string FACT_TABLES { get; set; }
        public string GROUPING_LEVELS { get; set; }
        public Nullable<decimal> QUERYLEN { get; set; }
        public string QUERY_TEXT { get; set; }
        public Nullable<decimal> STORAGE_IN_BYTES { get; set; }
        public Nullable<decimal> PCT_PERFORMANCE_GAIN { get; set; }
        public Nullable<decimal> FREQUENCY { get; set; }
        public Nullable<decimal> CUMULATIVE_BENEFIT { get; set; }
        public decimal BENEFIT_TO_COST_RATIO { get; set; }
        public Nullable<decimal> VALIDATED { get; set; }
    
        public virtual MVIEW__ADV_LOG MVIEW__ADV_LOG { get; set; }
    }
}
