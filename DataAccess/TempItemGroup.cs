//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class TempItemGroup
    {
        public TempItemGroup()
        {
            this.TempItems = new HashSet<TempItem>();
        }
    
        public int ID { get; set; }
        public string GroupName { get; set; }
        public Nullable<int> OrderID { get; set; }
    
        public virtual ICollection<TempItem> TempItems { get; set; }
    }
}