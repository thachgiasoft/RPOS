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
    
    public partial class ItemBarcode
    {
        public int ID { get; set; }
        public int ItemID { get; set; }
        public string BarcodeText { get; set; }
        public bool SystemBarcode { get; set; }
    
        public virtual Item Item { get; set; }
    }
}
