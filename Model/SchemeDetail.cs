//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PM.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class SchemeDetail
    {
        public int ID { get; set; }
        public int SchemeID { get; set; }
        public decimal InterestRate { get; set; }
        public System.DateTime EffectiveStartDate { get; set; }
        public Nullable<System.DateTime> EffectiveEndDate { get; set; }
    
        public virtual Scheme Scheme { get; set; }
    }
}
