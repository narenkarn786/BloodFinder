﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities1 : DbContext
    {
        public Entities1()
            : base("name=Entities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<AQ__INTERNET_AGENTS> AQ__INTERNET_AGENTS { get; set; }
        public DbSet<AQ__QUEUE_TABLES> AQ__QUEUE_TABLES { get; set; }
        public DbSet<AQ__QUEUES> AQ__QUEUES { get; set; }
        public DbSet<AQ__SCHEDULES> AQ__SCHEDULES { get; set; }
        public DbSet<BLOODDONOR> BLOODDONORs { get; set; }
        public DbSet<BLOODREQUESTOR> BLOODREQUESTORs { get; set; }
        public DbSet<DEF__AQCALL> DEF__AQCALL { get; set; }
        public DbSet<DEF__AQERROR> DEF__AQERROR { get; set; }
        public DbSet<DEF__CALLDEST> DEF__CALLDEST { get; set; }
        public DbSet<DEF__DEFAULTDEST> DEF__DEFAULTDEST { get; set; }
        public DbSet<DEF__DESTINATION> DEF__DESTINATION { get; set; }
        public DbSet<DEF__ERROR> DEF__ERROR { get; set; }
        public DbSet<DEF__LOB> DEF__LOB { get; set; }
        public DbSet<DEF__PROPAGATOR> DEF__PROPAGATOR { get; set; }
        public DbSet<DEF__PUSHED_TRANSACTIONS> DEF__PUSHED_TRANSACTIONS { get; set; }
        public DbSet<HELP> HELPs { get; set; }
        public DbSet<LOGIN> LOGINs { get; set; }
        public DbSet<LOGMNR_AGE_SPILL_> LOGMNR_AGE_SPILL_ { get; set; }
        public DbSet<LOGMNR_ATTRCOL_> LOGMNR_ATTRCOL_ { get; set; }
        public DbSet<LOGMNR_ATTRIBUTE_> LOGMNR_ATTRIBUTE_ { get; set; }
        public DbSet<LOGMNR_CCOL_> LOGMNR_CCOL_ { get; set; }
        public DbSet<LOGMNR_CDEF_> LOGMNR_CDEF_ { get; set; }
        public DbSet<LOGMNR_COL_> LOGMNR_COL_ { get; set; }
        public DbSet<LOGMNR_COLTYPE_> LOGMNR_COLTYPE_ { get; set; }
        public DbSet<LOGMNR_DICTIONARY_> LOGMNR_DICTIONARY_ { get; set; }
        public DbSet<LOGMNR_DICTSTATE_> LOGMNR_DICTSTATE_ { get; set; }
        public DbSet<LOGMNR_ENC_> LOGMNR_ENC_ { get; set; }
        public DbSet<LOGMNR_ICOL_> LOGMNR_ICOL_ { get; set; }
        public DbSet<LOGMNR_IND_> LOGMNR_IND_ { get; set; }
        public DbSet<LOGMNR_INDCOMPART_> LOGMNR_INDCOMPART_ { get; set; }
        public DbSet<LOGMNR_INDPART_> LOGMNR_INDPART_ { get; set; }
        public DbSet<LOGMNR_INDSUBPART_> LOGMNR_INDSUBPART_ { get; set; }
        public DbSet<LOGMNR_KOPM_> LOGMNR_KOPM_ { get; set; }
        public DbSet<LOGMNR_LOB_> LOGMNR_LOB_ { get; set; }
        public DbSet<LOGMNR_LOBFRAG_> LOGMNR_LOBFRAG_ { get; set; }
        public DbSet<LOGMNR_LOG_> LOGMNR_LOG_ { get; set; }
        public DbSet<LOGMNR_LOGMNR_BUILDLOG> LOGMNR_LOGMNR_BUILDLOG { get; set; }
        public DbSet<LOGMNR_NTAB_> LOGMNR_NTAB_ { get; set; }
        public DbSet<LOGMNR_OBJ_> LOGMNR_OBJ_ { get; set; }
        public DbSet<LOGMNR_OPQTYPE_> LOGMNR_OPQTYPE_ { get; set; }
        public DbSet<LOGMNR_PARTOBJ_> LOGMNR_PARTOBJ_ { get; set; }
        public DbSet<LOGMNR_PROCESSED_LOG_> LOGMNR_PROCESSED_LOG_ { get; set; }
        public DbSet<LOGMNR_PROPS_> LOGMNR_PROPS_ { get; set; }
        public DbSet<LOGMNR_REFCON_> LOGMNR_REFCON_ { get; set; }
        public DbSet<LOGMNR_RESTART_CKPT_> LOGMNR_RESTART_CKPT_ { get; set; }
        public DbSet<LOGMNR_RESTART_CKPT_TXINFO_> LOGMNR_RESTART_CKPT_TXINFO_ { get; set; }
        public DbSet<LOGMNR_SEED_> LOGMNR_SEED_ { get; set; }
        public DbSet<LOGMNR_SESSION_> LOGMNR_SESSION_ { get; set; }
        public DbSet<LOGMNR_SESSION_ACTIONS_> LOGMNR_SESSION_ACTIONS_ { get; set; }
        public DbSet<LOGMNR_SESSION_EVOLVE_> LOGMNR_SESSION_EVOLVE_ { get; set; }
        public DbSet<LOGMNR_SPILL_> LOGMNR_SPILL_ { get; set; }
        public DbSet<LOGMNR_SUBCOLTYPE_> LOGMNR_SUBCOLTYPE_ { get; set; }
        public DbSet<LOGMNR_TAB_> LOGMNR_TAB_ { get; set; }
        public DbSet<LOGMNR_TABCOMPART_> LOGMNR_TABCOMPART_ { get; set; }
        public DbSet<LOGMNR_TABPART_> LOGMNR_TABPART_ { get; set; }
        public DbSet<LOGMNR_TABSUBPART_> LOGMNR_TABSUBPART_ { get; set; }
        public DbSet<LOGMNR_TS_> LOGMNR_TS_ { get; set; }
        public DbSet<LOGMNR_TYPE_> LOGMNR_TYPE_ { get; set; }
        public DbSet<LOGMNR_UID_> LOGMNR_UID_ { get; set; }
        public DbSet<LOGMNR_USER_> LOGMNR_USER_ { get; set; }
        public DbSet<LOGMNRC_DBNAME_UID_MAP> LOGMNRC_DBNAME_UID_MAP { get; set; }
        public DbSet<LOGMNRC_GSBA> LOGMNRC_GSBA { get; set; }
        public DbSet<LOGMNRC_GSII> LOGMNRC_GSII { get; set; }
        public DbSet<LOGMNRC_GTCS> LOGMNRC_GTCS { get; set; }
        public DbSet<LOGMNRC_GTLO> LOGMNRC_GTLO { get; set; }
        public DbSet<LOGMNRP_CTAS_PART_MAP> LOGMNRP_CTAS_PART_MAP { get; set; }
        public DbSet<LOGMNRT_MDDL_> LOGMNRT_MDDL_ { get; set; }
        public DbSet<LOGSTDBY_EDS_TABLES> LOGSTDBY_EDS_TABLES { get; set; }
        public DbSet<LOGSTDBY_FLASHBACK_SCN> LOGSTDBY_FLASHBACK_SCN { get; set; }
        public DbSet<MVIEW__ADV_AJG> MVIEW__ADV_AJG { get; set; }
        public DbSet<MVIEW__ADV_CLIQUE> MVIEW__ADV_CLIQUE { get; set; }
        public DbSet<MVIEW__ADV_ELIGIBLE> MVIEW__ADV_ELIGIBLE { get; set; }
        public DbSet<MVIEW__ADV_FILTER> MVIEW__ADV_FILTER { get; set; }
        public DbSet<MVIEW__ADV_FJG> MVIEW__ADV_FJG { get; set; }
        public DbSet<MVIEW__ADV_GC> MVIEW__ADV_GC { get; set; }
        public DbSet<MVIEW__ADV_INFO> MVIEW__ADV_INFO { get; set; }
        public DbSet<MVIEW__ADV_JOURNAL> MVIEW__ADV_JOURNAL { get; set; }
        public DbSet<MVIEW__ADV_LEVEL> MVIEW__ADV_LEVEL { get; set; }
        public DbSet<MVIEW__ADV_LOG> MVIEW__ADV_LOG { get; set; }
        public DbSet<MVIEW__ADV_OUTPUT> MVIEW__ADV_OUTPUT { get; set; }
        public DbSet<MVIEW__ADV_PARAMETERS> MVIEW__ADV_PARAMETERS { get; set; }
        public DbSet<MVIEW__ADV_ROLLUP> MVIEW__ADV_ROLLUP { get; set; }
        public DbSet<MVIEW__ADV_WORKLOAD> MVIEW__ADV_WORKLOAD { get; set; }
        public DbSet<REPCAT__AUDIT_ATTRIBUTE> REPCAT__AUDIT_ATTRIBUTE { get; set; }
        public DbSet<REPCAT__AUDIT_COLUMN> REPCAT__AUDIT_COLUMN { get; set; }
        public DbSet<REPCAT__COLUMN_GROUP> REPCAT__COLUMN_GROUP { get; set; }
        public DbSet<REPCAT__CONFLICT> REPCAT__CONFLICT { get; set; }
        public DbSet<REPCAT__EXCEPTIONS> REPCAT__EXCEPTIONS { get; set; }
        public DbSet<REPCAT__EXTENSION> REPCAT__EXTENSION { get; set; }
        public DbSet<REPCAT__FLAVOR_OBJECTS> REPCAT__FLAVOR_OBJECTS { get; set; }
        public DbSet<REPCAT__GENERATED> REPCAT__GENERATED { get; set; }
        public DbSet<REPCAT__GROUPED_COLUMN> REPCAT__GROUPED_COLUMN { get; set; }
        public DbSet<REPCAT__INSTANTIATION_DDL> REPCAT__INSTANTIATION_DDL { get; set; }
        public DbSet<REPCAT__KEY_COLUMNS> REPCAT__KEY_COLUMNS { get; set; }
        public DbSet<REPCAT__OBJECT_TYPES> REPCAT__OBJECT_TYPES { get; set; }
        public DbSet<REPCAT__PARAMETER_COLUMN> REPCAT__PARAMETER_COLUMN { get; set; }
        public DbSet<REPCAT__PRIORITY> REPCAT__PRIORITY { get; set; }
        public DbSet<REPCAT__PRIORITY_GROUP> REPCAT__PRIORITY_GROUP { get; set; }
        public DbSet<REPCAT__REFRESH_TEMPLATES> REPCAT__REFRESH_TEMPLATES { get; set; }
        public DbSet<REPCAT__REPCAT> REPCAT__REPCAT { get; set; }
        public DbSet<REPCAT__REPCATLOG> REPCAT__REPCATLOG { get; set; }
        public DbSet<REPCAT__REPCOLUMN> REPCAT__REPCOLUMN { get; set; }
        public DbSet<REPCAT__REPOBJECT> REPCAT__REPOBJECT { get; set; }
        public DbSet<REPCAT__REPPROP> REPCAT__REPPROP { get; set; }
        public DbSet<REPCAT__REPSCHEMA> REPCAT__REPSCHEMA { get; set; }
        public DbSet<REPCAT__RESOL_STATS_CONTROL> REPCAT__RESOL_STATS_CONTROL { get; set; }
        public DbSet<REPCAT__RESOLUTION> REPCAT__RESOLUTION { get; set; }
        public DbSet<REPCAT__RESOLUTION_METHOD> REPCAT__RESOLUTION_METHOD { get; set; }
        public DbSet<REPCAT__SITES_NEW> REPCAT__SITES_NEW { get; set; }
        public DbSet<REPCAT__TEMPLATE_OBJECTS> REPCAT__TEMPLATE_OBJECTS { get; set; }
        public DbSet<REPCAT__TEMPLATE_PARMS> REPCAT__TEMPLATE_PARMS { get; set; }
        public DbSet<REPCAT__TEMPLATE_REFGROUPS> REPCAT__TEMPLATE_REFGROUPS { get; set; }
        public DbSet<REPCAT__TEMPLATE_SITES> REPCAT__TEMPLATE_SITES { get; set; }
        public DbSet<REPCAT__TEMPLATE_STATUS> REPCAT__TEMPLATE_STATUS { get; set; }
        public DbSet<REPCAT__TEMPLATE_TARGETS> REPCAT__TEMPLATE_TARGETS { get; set; }
        public DbSet<REPCAT__TEMPLATE_TYPES> REPCAT__TEMPLATE_TYPES { get; set; }
        public DbSet<REPCAT__USER_AUTHORIZATIONS> REPCAT__USER_AUTHORIZATIONS { get; set; }
        public DbSet<REPCAT__USER_PARM_VALUES> REPCAT__USER_PARM_VALUES { get; set; }
        public DbSet<AQ__INTERNET_AGENT_PRIVS> AQ__INTERNET_AGENT_PRIVS { get; set; }
        public DbSet<LOGMNR_PARAMETER_> LOGMNR_PARAMETER_ { get; set; }
        public DbSet<LOGSTDBY_APPLY_MILESTONE> LOGSTDBY_APPLY_MILESTONE { get; set; }
        public DbSet<LOGSTDBY_EVENTS> LOGSTDBY_EVENTS { get; set; }
        public DbSet<LOGSTDBY_SKIP_SUPPORT> LOGSTDBY_SKIP_SUPPORT { get; set; }
        public DbSet<MVIEW__ADV_BASETABLE> MVIEW__ADV_BASETABLE { get; set; }
        public DbSet<MVIEW__ADV_FILTERINSTANCE> MVIEW__ADV_FILTERINSTANCE { get; set; }
        public DbSet<MVIEW__ADV_INDEX> MVIEW__ADV_INDEX { get; set; }
        public DbSet<MVIEW__ADV_PARTITION> MVIEW__ADV_PARTITION { get; set; }
        public DbSet<REPCAT__FLAVORS> REPCAT__FLAVORS { get; set; }
        public DbSet<REPCAT__REPGROUP_PRIVS> REPCAT__REPGROUP_PRIVS { get; set; }
        public DbSet<REPCAT__RESOLUTION_STATISTICS> REPCAT__RESOLUTION_STATISTICS { get; set; }
        public DbSet<REPCAT__SITE_OBJECTS> REPCAT__SITE_OBJECTS { get; set; }
        public DbSet<SQLPLUS_PRODUCT_PROFILE> SQLPLUS_PRODUCT_PROFILE { get; set; }
    }
}
