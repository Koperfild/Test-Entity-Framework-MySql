﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entity_Framework_Test___MySql
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Model1Container : DbContext
    {
        public Model1Container()
            : base("name=Model1Container")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<actor> actor { get; set; }
        public DbSet<address> address { get; set; }
        public DbSet<category> category { get; set; }
        public DbSet<city> city { get; set; }
        public DbSet<country> country { get; set; }
        public DbSet<customer> customer { get; set; }
        public DbSet<film> film { get; set; }
        public DbSet<film_actor> film_actor { get; set; }
        public DbSet<film_category> film_category { get; set; }
        public DbSet<film_text> film_text { get; set; }
        public DbSet<inventory> inventory { get; set; }
        public DbSet<language> language { get; set; }
        public DbSet<payment> payment { get; set; }
        public DbSet<rental> rental { get; set; }
        public DbSet<staff> staff { get; set; }
        public DbSet<store> store { get; set; }
        public DbSet<actor_info> actor_info { get; set; }
        public DbSet<customer_list> customer_list { get; set; }
        public DbSet<film_list> film_list { get; set; }
        public DbSet<nicer_but_slower_film_list> nicer_but_slower_film_list { get; set; }
        public DbSet<sales_by_film_category> sales_by_film_category { get; set; }
        public DbSet<staff_list> staff_list { get; set; }
    }
}
