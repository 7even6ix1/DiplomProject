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
    
    public partial class ServiceDetails
    {
        public int Id { get; set; }
        public int Service { get; set; }
        public Nullable<int> Detail { get; set; }
        public int Count { get; set; }
    
        public virtual Details Details { get; set; }
        public virtual Service Service1 { get; set; }
    }
}