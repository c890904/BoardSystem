﻿using BoardSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoardSystem.DataContext
{
    public class BoardSystemContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Board> Boards { get; set; }

        public DbSet<Comment> Comments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=localhost;Database=BoardSystemDb;User Id=sa;Password=a1234;");
            optionsBuilder.UseSqlServer(@"Server=127.0.0.1, 12708;Database=BoardSystemDb;Integrated Security=SSPI;");
        }
    }
}
