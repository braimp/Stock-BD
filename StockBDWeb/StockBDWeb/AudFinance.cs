//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StockBDWeb
{
    using System;
    using System.Collections.Generic;
    
    public partial class AudFinance
    {
        public long id { get; set; }
        public Nullable<long> cID { get; set; }
        public Nullable<System.DateTime> Year { get; set; }
        public Nullable<decimal> EPS_Orig { get; set; }
        public Nullable<decimal> EPS_Restated { get; set; }
        public Nullable<decimal> PE_Orig { get; set; }
        public Nullable<decimal> PE_Diluted { get; set; }
        public Nullable<decimal> BonusCash { get; set; }
        public Nullable<decimal> BonusStock { get; set; }
        public Nullable<decimal> Yield { get; set; }
        public Nullable<decimal> NAV_Orig { get; set; }
        public Nullable<decimal> NAV_Restated { get; set; }
        public string ShareCat { get; set; }
        public Nullable<decimal> LoanShortTerm { get; set; }
        public Nullable<decimal> LoanLongTerm { get; set; }
    
        public virtual ShareCat ShareCat1 { get; set; }
        public virtual Company Company { get; set; }
    }
}
