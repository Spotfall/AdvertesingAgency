//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdvertesingAgency
{
    using System;
    using System.Collections.Generic;
    
    public partial class list_purpose
    {
        public int id_purpose { get; set; }
        public int id_contract { get; set; }
        public int id_service { get; set; }
        public int id_dept { get; set; }
        public int id_status_service { get; set; }
    
        public virtual Dept Dept { get; set; }
        public virtual Service Service { get; set; }
        public virtual Status_service Status_service { get; set; }
        public virtual Contract Contract { get; set; }
    }
}