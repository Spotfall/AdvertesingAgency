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
    
    public partial class Contract
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Contract()
        {
            this.list_purpose = new HashSet<list_purpose>();
        }
    
        public int id_contract { get; set; }
        public int id_client { get; set; }
        public string date_preparation { get; set; }
        public string date_execution { get; set; }
        public int id_payment_status { get; set; }
        public string contract_details { get; set; }
        public int id_contract_status { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Contract_status Contract_status { get; set; }
        public virtual Payment_status Payment_status { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<list_purpose> list_purpose { get; set; }
    }
}