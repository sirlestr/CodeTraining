using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstEFCoreProject
{
    internal class FirstDbContext : DbContext
    {
        public DbSet<Author> Authors  { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=FirstEFCoreProject;Trusted_Connection=True;");
            optionsBuilder.LogTo(text => System.Diagnostics.Debug.WriteLine(text),LogLevel.Information);
        }
    }
}
