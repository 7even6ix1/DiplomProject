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
    
    public partial class Deliviries
    {
        public int Id { get; set; }
        public int Detail { get; set; }
        public int Provider { get; set; }
        public int Count { get; set; }
        public System.DateTime Date { get; set; }
        public double Cost { get; set; }
        public int CarModel { get; set; }
    
        public virtual CarModels CarModels { get; set; }
        public virtual Details Details { get; set; }
        public virtual Provider Provider1 { get; set; }
    }
}