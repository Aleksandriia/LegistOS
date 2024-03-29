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
    
    public partial class DDocument
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DDocument()
        {
            this.DIzbrannoes = new HashSet<DIzbrannoe>();
        }
    
        public int idDocumenta { get; set; }
        public string Nomer { get; set; }
        public string Nazvanie { get; set; }
        public Nullable<System.DateTime> DataNach { get; set; }
        public Nullable<System.DateTime> DataKon { get; set; }
        public string Opisanie { get; set; }
        public string KratOpisanie { get; set; }
        public Nullable<int> IzdavOrgan { get; set; }
        public Nullable<int> VidDoc { get; set; }
        public Nullable<int> PravovayaBaza { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> Region { get; set; }
        public Nullable<int> NPA { get; set; }
        public Nullable<int> Teg { get; set; }
        public string PytFaila { get; set; }
    
        public virtual DIzdavOrgan DIzdavOrgan { get; set; }
        public virtual DNPA DNPA { get; set; }
        public virtual DPravovayaBaza DPravovayaBaza { get; set; }
        public virtual DRegion DRegion { get; set; }
        public virtual DStatu DStatu { get; set; }
        public virtual DTeg DTeg { get; set; }
        public virtual DVid DVid { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIzbrannoe> DIzbrannoes { get; set; }
    }
}
