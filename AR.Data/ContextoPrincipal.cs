﻿using Microsoft.EntityFrameworkCore;
using AR.Domain;

namespace AR.Data
{
    public class ContextoPrincipal : DbContext
    {
        public ContextoPrincipal(DbContextOptions options)
            : base(options)
        {
        }
        public DbSet<Cliente>Cliente { get; set; }
    }
}
