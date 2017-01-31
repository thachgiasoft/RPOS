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
    
    public partial class PurchaseInvoiceDetail
    {
        public PurchaseInvoiceDetail()
        {
            this.Inventories = new HashSet<Inventory>();
        }
    
        public int ID { get; set; }
        public int PurchaseInvoiceID { get; set; }
        public int ItemID { get; set; }
        public int Quantity { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }
        public decimal DiscountPrice { get; set; }
        public string Remarks { get; set; }
    
        public virtual PurchaseInvoice PurchaseInvoice { get; set; }
        public virtual ICollection<Inventory> Inventories { get; set; }
        public virtual Item Item { get; set; }
    }
}