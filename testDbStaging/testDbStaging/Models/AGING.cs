//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace testDbStaging.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AGING
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AGING()
        {
            this.FACT_MFI = new HashSet<FACT_MFI>();
        }
    
        public int AGING_ID { get; set; }
        public string AGING_DESCRIPTION { get; set; }
        public Nullable<System.DateTime> LAST_UPDATE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACT_MFI> FACT_MFI { get; set; }
    }
}
