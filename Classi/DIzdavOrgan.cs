//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LegistOS.Classi
{
    using System;
    using System.Collections.Generic;
    
    public partial class DIzdavOrgan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIzdavOrgan()
        {
            this.DDocuments = new HashSet<DDocument>();
            this.DOrganUstarNazvs = new HashSet<DOrganUstarNazv>();
        }
    
        public int idIzdavOrgana { get; set; }
        public string NazvanieOrgana { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DDocument> DDocuments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DOrganUstarNazv> DOrganUstarNazvs { get; set; }
    }
}
