using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022.Other
{
    class CredentialsDbContext : DbContext
    {
        public DbSet<DataModels.EFModels.CredentialsSG> credentialsSG { get; set; } //trebuie sa fie exact numele tabelei din sql
        private string connectionString;

        //constructor default, use base constructor with options
        public CredentialsDbContext(DbContextOptions<CredentialsDbContext> options) : base(options)
        {
        }

        //Constructor with connection string
        public CredentialsDbContext(string connectionString)
        {
            this.connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
    }
}
