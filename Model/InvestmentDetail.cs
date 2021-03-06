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
    
    public partial class InvestmentDetail
    {
        public int Id { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public Nullable<int> SchemeID { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<decimal> Interest { get; set; }
        public Nullable<System.DateTime> MaturityDate { get; set; }
        public Nullable<int> SecondHolderID { get; set; }
        public Nullable<int> ThirdHolderID { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Customer Customer1 { get; set; }
        public virtual Customer Customer2 { get; set; }
        public virtual Scheme Scheme { get; set; }
    }
}
