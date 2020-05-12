using ConsoleModels.Models;
using ConsoleModels.Models.EntityConfigurations;
using ConsoleModels.Models.References;
using Microsoft.EntityFrameworkCore;
using System;

namespace ConsoleModels
{
   


    public class ApplicationContext : DbContext
    {
        //// References
        public DbSet<Storeges> Storeges { get; set; }
        public DbSet<Contragents> Contragents { get; set; }
        public DbSet<RcordOfGoodConsist> RcordOfGoodConsist { get; set; }
        public DbSet<Goods> Goods { get; set; }
        ////// Docs


        public ApplicationContext()
        {
            //Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-VOAK5LV\\SQLEXPRESS;Database=SimpleModels;User Id=sa; Password=1;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            //// References
            modelBuilder.ApplyConfiguration(new StoregesConfiguration());
            modelBuilder.ApplyConfiguration(new ContragentsConfiguration());
            modelBuilder.ApplyConfiguration(new RecordOfGoodConsistsConfiguration());
            modelBuilder.ApplyConfiguration(new GoodsConfiguration());
            //// Docs

        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            using (ApplicationContext db = new ApplicationContext()) { }



        }
    }
}
