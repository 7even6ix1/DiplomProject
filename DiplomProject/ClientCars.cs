//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DiplomProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class ClientCars
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ClientCars()
        {
            this.Works = new HashSet<Works>();
            this.ClientRequests = new HashSet<ClientRequests>();
        }
    
        public int Id { get; set; }
        public int CarModel { get; set; }
        public string VinNumber { get; set; }
        public string GosNumber { get; set; }
        public int Owner { get; set; }
    
        public virtual CarModels CarModels { get; set; }
        public virtual Clients Clients { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Works> Works { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientRequests> ClientRequests { get; set; }
    }
}
