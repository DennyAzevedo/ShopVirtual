//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShopVirtual.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class ItemVenda
    {
        public int ID_Venda { get; set; }
        public int ID_Produto { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal SubTotal { get; set; }
    
        public virtual Produto Produto { get; set; }
        public virtual Venda Venda { get; set; }
    }
}
