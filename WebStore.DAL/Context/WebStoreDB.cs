using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.EntityFrameworkCore;
using WebStore.Domain.Entities;
using WebStore.DomainNew.Entities;

namespace WebStore.DAL.Context
{
    public class WebStoreDB : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Customer> Customers { get; set; }
        //public DbSet<User> Users { get; set; }
        public WebStoreDB(DbContextOptions options) : base(options)
        {
            
        }
    }
}
