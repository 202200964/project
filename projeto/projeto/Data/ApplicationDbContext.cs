﻿using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using projeto.Models;

namespace projeto.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<projeto.Models.LoginModel> LoginModel { get; set; } = default!;
        public DbSet<projeto.Models.Utilizador> Utilizador { get; set; } = default!;
        public DbSet<LogUtilizador> LogUtilizadores { get; set; } = default!;

    }
}
