using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using BackEndAplication.Models.PHCDBModel.Mapping;

namespace BackEndAplication.Models.PHCDBModel
{
    public class PdbContext : DbContext
    {
        public PdbContext(string valueConn) : base(valueConn)
        {
            Database.SetInitializer<PdbContext>(null);
        }

        public DbSet<Fltcl> FiltrosClientes { get; set; }
        public DbSet<Fltst> FiltrosStocks { get; set; }
        public DbSet<Bo> DossiersInternos { get; set; }
        public DbSet<Cl> DadosClientes { get; set; }
        public DbSet<Ts> DadosTs { get; set; }
        public DbSet<Us> DadosUs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new FltstMap());
            modelBuilder.Configurations.Add(new FltclMap());
            modelBuilder.Configurations.Add(new ClMap());
            modelBuilder.Configurations.Add(new TsMap());
            modelBuilder.Configurations.Add(new UsMap());
            //modelBuilder.Configurations.Add(new UtilizadoresMap());

            //teste
             modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //
            base.OnModelCreating(modelBuilder);
        }
    }
}