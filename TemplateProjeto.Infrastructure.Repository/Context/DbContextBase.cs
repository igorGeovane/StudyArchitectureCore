using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TemplateProjeto.Domain.Models;

namespace TemplateProjeto.Infrastructure.Repository.Context
{
    public abstract class DbContextBase : DbContext
    {
        public string EntityTypeConfigurationPath { get; set; }
        private readonly string _connectionString;
        private readonly static LoggerFactory _dbLoggerFactory = new LoggerFactory(new[]
        {
            new ConsoleLoggerProvider((category, level) => category == DbLoggerCategory.Database.Command.Name && level == LogLevel.Information, true)
        });

        public DbContextBase(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
            optionsBuilder.UseLoggerFactory(_dbLoggerFactory);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var allConfiguration = AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes())
                .Where(type => typeof(IEntityTypeConfiguration<Entity>).IsAssignableFrom(type) && 
                               type.Namespace.ToUpper().Contains(EntityTypeConfigurationPath.ToUpper()) && 
                               !type.IsInterface && 
                               !type.IsAbstract)
                .ToList();

            foreach (Type configuration in allConfiguration)
            {
                var instanceConfiguration = (IEntityTypeConfiguration<Entity>)Activator.CreateInstance(configuration);
                modelBuilder.ApplyConfiguration(instanceConfiguration);
            }
        }
    }
}
