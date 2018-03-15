using DataModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
   public  class DataContext :DbContext
    {


        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        { }

        // here define DbSet's

        public DbSet<Entity> Entities { get; set; }

        public DbSet<Vendor> Vendors { get; set; }

        public DbSet<User> Users { get; set; }

    }
}
