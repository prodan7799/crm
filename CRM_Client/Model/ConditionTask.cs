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
    
    public partial class ConditionTask
    {
        public ConditionTask()
        {
            this.TaskBD = new HashSet<TaskBD>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<TaskBD> TaskBD { get; set; }
    }
}
