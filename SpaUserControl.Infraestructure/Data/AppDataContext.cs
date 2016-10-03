using SpaUserControl.Domain.Models;
using SpaUserControl.Infraestructure.Data.Map;
using System.Data.Entity;

namespace SpaUserControl.Infraestructure.Data
{
    public class AppDataContext : DbContext
    {
        public AppDataContext()
            : base("AppConnectionString")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false; //Não gerar proxy
        }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserMap());
        }
    }
}
