//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1
{
    using System;
    using System.Collections.Generic;
    
    public partial class data_pacient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public data_pacient()
        {
            this.blood = new HashSet<blood>();
        }
    
        public int id { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string family { get; set; }
        public string patronymic { get; set; }
        public Nullable<System.DateTime> bithdate { get; set; }
        public Nullable<long> seriya { get; set; }
        public Nullable<long> nomer { get; set; }
        public Nullable<long> phone { get; set; }
        public string email { get; set; }
        public Nullable<int> type_polus { get; set; }
        public Nullable<int> number_polus { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<blood> blood { get; set; }
        public virtual strah_company strah_company { get; set; }
    }
}
