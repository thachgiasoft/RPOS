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
    
    public partial class vw_ShiftUser
    {
        public int ShiftID { get; set; }
        public System.DateTime LogInTime { get; set; }
        public System.DateTime LogoutTime { get; set; }
        public int ID { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public int UserID { get; set; }
        public int Flag { get; set; }
        public decimal Duration { get; set; }
        public Nullable<decimal> HourRate { get; set; }
        public string PushoverID { get; set; }
        public int BranchID { get; set; }
    }
}
