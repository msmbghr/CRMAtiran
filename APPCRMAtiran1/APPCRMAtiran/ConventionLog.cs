//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace APPCRMAtiran
{
    using System;
    using System.Collections.Generic;
    
    public partial class ConventionLog
    {
        public int conventionLog1 { get; set; }
        public string fromRegDate { get; set; }
        public string toRegDate { get; set; }
        public string fromStartDate { get; set; }
        public string toStartDate { get; set; }
        public Nullable<int> fromCountOfSystem { get; set; }
        public Nullable<int> toCountOfSystem { get; set; }
        public string fromComment { get; set; }
        public string toComment { get; set; }
        public Nullable<decimal> fromPrice { get; set; }
        public Nullable<decimal> toPrice { get; set; }
    
        public virtual CUSTOMERS CUSTOMERS { get; set; }
        public virtual CUSTOMERS CUSTOMERS1 { get; set; }
        public virtual companyTask companyTask { get; set; }
        public virtual companyTask companyTask1 { get; set; }
        public virtual convention convention { get; set; }
        public virtual conventionDuration conventionDuration { get; set; }
        public virtual conventionDuration conventionDuration1 { get; set; }
        public virtual conventionType conventionType { get; set; }
        public virtual conventionType conventionType1 { get; set; }
        public virtual product product { get; set; }
        public virtual product product1 { get; set; }
        public virtual user user { get; set; }
        public virtual user user1 { get; set; }
        public virtual user user2 { get; set; }
    }
}
