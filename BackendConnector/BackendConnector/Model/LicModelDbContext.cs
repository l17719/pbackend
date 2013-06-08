using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using BackendConnector.Model.Mapping;

namespace BackendConnector.Model
{
    public class LicModelDbContext:DbContext
    {
        public DbSet<Licenca> DadosLicenca { get; set; }

        public LicModelDbContext(string connection):base(connection)
        {
            Database.SetInitializer<LicModelDbContext>(new CreateDatabaseIfNotExists<LicModelDbContext>());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new LicencaMapping());
            modelBuilder.Conventions.Remove<IncludeMetadataConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}