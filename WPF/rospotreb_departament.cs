//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wpf3_1
{
    using System;
    using System.Collections.Generic;
    
    public partial class rospotreb_departament
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public rospotreb_departament()
        {
            this.certificatee = new HashSet<certificatee>();
        }
    
        public decimal inn_departamen { get; set; }
        public string name_departament { get; set; }
        public string street_departament { get; set; }
        public int home_departament { get; set; }
        public string town_departament { get; set; }
        public decimal phone_departament { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<certificatee> certificatee { get; set; }
    }
}
