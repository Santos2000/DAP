//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projeto_DAplicacoes
{
    using System;
    using System.Collections.Generic;
    
    public partial class Consumo
    {
        public int QuantidadeMedia { get; set; }
        public int StockMateriaisId { get; set; }
        public int Arranjo_Id { get; set; }
    
        public virtual StockMateriais StockMateriais { get; set; }
        public virtual Arranjo Arranjo { get; set; }
    }
}
