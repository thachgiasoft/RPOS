//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RedaPOS.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserMessage
    {
        public int UserID { get; set; }
        public int MessageTypeID { get; set; }
        public Nullable<bool> EnableMessage { get; set; }
    
        public virtual MessageType MessageType { get; set; }
        public virtual User User { get; set; }
    }
}
