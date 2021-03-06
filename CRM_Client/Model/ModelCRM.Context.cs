﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DatabaseCRMEntities : DbContext
    {
        public DatabaseCRMEntities()
            : base("name=DatabaseCRMEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Area> Area { get; set; }
        public virtual DbSet<CardClient> CardClient { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<ConditionDeal> ConditionDeal { get; set; }
        public virtual DbSet<ConditionTask> ConditionTask { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Deal> Deal { get; set; }
        public virtual DbSet<EmailPeople> EmailPeople { get; set; }
        public virtual DbSet<EmailStaff> EmailStaff { get; set; }
        public virtual DbSet<Goods> Goods { get; set; }
        public virtual DbSet<GoodsInDeal> GoodsInDeal { get; set; }
        public virtual DbSet<People> People { get; set; }
        public virtual DbSet<PhonePeople> PhonePeople { get; set; }
        public virtual DbSet<PhoneStaff> PhoneStaff { get; set; }
        public virtual DbSet<PostPeople> PostPeople { get; set; }
        public virtual DbSet<Reminder> Reminder { get; set; }
        public virtual DbSet<Staff> Staff { get; set; }
        public virtual DbSet<TaskBD> TaskBD { get; set; }
        public virtual DbSet<TypeEmail> TypeEmail { get; set; }
        public virtual DbSet<TypeGoods> TypeGoods { get; set; }
        public virtual DbSet<TypePhone> TypePhone { get; set; }
    
        public virtual ObjectResult<Top5CustomersSummaDeal_Result> Top5CustomersSummaDeal(Nullable<System.DateTime> dateFrom, Nullable<System.DateTime> dateTo)
        {
            var dateFromParameter = dateFrom.HasValue ?
                new ObjectParameter("DateFrom", dateFrom) :
                new ObjectParameter("DateFrom", typeof(System.DateTime));
    
            var dateToParameter = dateTo.HasValue ?
                new ObjectParameter("DateTo", dateTo) :
                new ObjectParameter("DateTo", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Top5CustomersSummaDeal_Result>("Top5CustomersSummaDeal", dateFromParameter, dateToParameter);
        }
    }
}
