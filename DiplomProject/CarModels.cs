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
    
    public partial class CarModels
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CarModels()
        {
            this.AvailableDetails = new HashSet<AvailableDetails>();
            this.ClientCars = new HashSet<ClientCars>();
            this.Deliviries = new HashSet<Deliviries>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public int CarStamp { get; set; }
        public int TechInfo { get; set; }
        public int Colour { get; set; }
        public int ReleaseYear { get; set; }
        public int ManufCountry { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AvailableDetails> AvailableDetails { get; set; }
        public virtual CarStamps CarStamps { get; set; }
        public virtual Colours Colours { get; set; }
        public virtual ManufacturerCountry ManufacturerCountry { get; set; }
        public virtual TechnicalInformation TechnicalInformation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientCars> ClientCars { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Deliviries> Deliviries { get; set; }
    }
}