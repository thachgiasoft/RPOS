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
    
    public partial class UserLogin
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public System.DateTime LogIn { get; set; }
        public bool Type { get; set; }
        public int BranchID { get; set; }
        public Nullable<System.DateTime> LogOut { get; set; }
    
        public virtual Branch Branch { get; set; }
        public virtual User User { get; set; }
    }
}
