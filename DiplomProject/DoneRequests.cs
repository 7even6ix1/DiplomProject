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
    
    public partial class DoneRequests
    {
        public int Id { get; set; }
        public int IdRequest { get; set; }
        public int IdWorks { get; set; }
    
        public virtual Works Works { get; set; }
        public virtual ClientRequests ClientRequests { get; set; }
    }
}
