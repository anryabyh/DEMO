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
    
    public partial class userr
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public userr()
        {
            this.certificatee = new HashSet<certificatee>();
            this.company = new HashSet<company>();
        }
    
        public string loginn { get; set; }
        public string passwordd { get; set; }
        public string surname { get; set; }
        public string namee { get; set; }
        public string patronymic { get; set; }
        public decimal phone_user { get; set; }
        public bool businessman { get; set; }
        public decimal passport_series { get; set; }
        public decimal numb_passport { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<certificatee> certificatee { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<company> company { get; set; }
    }
}
