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
    
    public partial class SaleInvoiceDetail
    {
        public int ID { get; set; }
        public int SaleInvoiceID { get; set; }
        public int InventoryID { get; set; }
        public int Quanitity { get; set; }
        public decimal UnitPrice { get; set; }
        public string Remarks { get; set; }
        public int ItemID { get; set; }
        public Nullable<int> PurchaseQuantity { get; set; }
        public Nullable<int> CurrentQuanitity { get; set; }
    
        public virtual Inventory Inventory { get; set; }
        public virtual SaleInvoice SaleInvoice { get; set; }
        public virtual Item Item { get; set; }
    }
}
