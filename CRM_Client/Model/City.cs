//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRM_Client.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class City
    {
        public City()
        {
            this.CardClient = new HashSet<CardClient>();
            this.Staff = new HashSet<Staff>();
        }
    
        public int ID { get; set; }
        public int ID_Area { get; set; }
        public string Name { get; set; }
    
        public virtual Area Area { get; set; }
        public virtual ICollection<CardClient> CardClient { get; set; }
        public virtual ICollection<Staff> Staff { get; set; }
    }
}
