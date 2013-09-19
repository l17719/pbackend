using System.Data.Entity;
using ConnectorService.Model.PHCModel;
using ConnectorService.Model.PHCModel.Mapping;

namespace PHCServiceConnector.Model.DbModel.PHCMODEL
{
    public class PhcDbContext:DbContext
    {
       
        //classes mapeadas via reverse
        public DbSet<Bi> DadosLinhasEncomendas { get; set; }
        public DbSet<Bo> DadosCabecalhosEncomendas { get; set; }
        public DbSet<Cl> DadosClientes { get; set; }
        public DbSet<Cc> DadosContasCorrentes { get; set; }
        public DbSet<Bo2> DadosCabecalhosEncomendasExt { get; set; }
        public DbSet<Bi2> DadosLinhasEncomendasExt { get; set; }
        public DbSet<St> DadosStocks { get; set; }
        public DbSet<Taxasiva> DadosTaxasIva { get; set; }
        public DbSet<Fltst> DadosFiltrosStocks { get; set; }
        public DbSet<Fltcl> DadosFiltrosClientes { get; set; }
        public DbSet<FltCc> DadosFiltrosContas { get; set; }
       // public DbSet<Stobs> ObservacoesStocks { get; set; }
        public DbSet<Pn> ProdutosVendidos { get; set; } 
        //
        public PhcDbContext(string connection):base(connection)
        {
          
            Database.SetInitializer<PhcDbContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BiMap());
            modelBuilder.Configurations.Add(new BoMap());
            modelBuilder.Configurations.Add(new Bi2Map());
            modelBuilder.Configurations.Add(new Bo2Map());
            modelBuilder.Configurations.Add(new ClMap());
            modelBuilder.Configurations.Add(new CcMap());
            modelBuilder.Configurations.Add(new StMap());
            modelBuilder.Configurations.Add(new TaxasivaMap());
            modelBuilder.Configurations.Add(new FltclMap());
            modelBuilder.Configurations.Add(new FltstMap());
            modelBuilder.Configurations.Add(new FltccMap());
            //modelBuilder.Configurations.Add(new StobsMap());
            modelBuilder.Configurations.Add(new PnMap());
            
        }
    }
}