
using Microsoft.EntityFrameworkCore;
using myfinance_web_netcore.Domain;


namespace myfinance_web_netcore.infrastructure
{
    public class MyFinanceDBContext : DbContext
    {
       public DbSet <PlanoConta> PlanoConta {get; set; }
       public DbSet <Transacao> Transacao {get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = @"Server";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}