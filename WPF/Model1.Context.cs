﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wpf3_1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RospotrebnadzorEntities : DbContext
    {
        public RospotrebnadzorEntities()
            : base("name=RospotrebnadzorEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<certificatee> certificatee { get; set; }
        public virtual DbSet<company> company { get; set; }
        public virtual DbSet<product> product { get; set; }
        public virtual DbSet<rospotreb_departament> rospotreb_departament { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<userr> userr { get; set; }
    }
}
