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
    
    public partial class Arranjo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Arranjo()
        {
            this.Consumo = new HashSet<Consumo>();
            this.PecaArranjo = new HashSet<PecaArranjo>();
        }
    
        public int Id { get; set; }
        public string TipoArranjo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Consumo> Consumo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PecaArranjo> PecaArranjo { get; set; }

        public override string ToString()
        {
            return string.Format("Id:{0} {1}", Id, TipoArranjo);
        }
    }
}