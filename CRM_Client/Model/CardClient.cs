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
    
    public partial class CardClient
    {
        public CardClient()
        {
            this.People = new HashSet<People>();
            this.Reminder = new HashSet<Reminder>();
            this.TaskBD = new HashSet<TaskBD>();
        }
    
        public int ID { get; set; }
        public string NameCompany { get; set; }
        public Nullable<int> ID_City { get; set; }
        public string Address { get; set; }
        public System.DateTime CreateCard { get; set; }
    
        public virtual City City { get; set; }
        public virtual ICollection<People> People { get; set; }
        public virtual ICollection<Reminder> Reminder { get; set; }
        public virtual ICollection<TaskBD> TaskBD { get; set; }
    }
}