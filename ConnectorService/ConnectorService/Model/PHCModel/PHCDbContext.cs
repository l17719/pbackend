using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq.Expressions;
using ConnectorService.Model.PHCModel.Mapping;
using System.Linq;
namespace ConnectorService.Model.PHCModel
{
    public class PhcDbContext:DbContext
    {
        //public DbSet<TbPClientes> Clientes { get; set; }
        //public DbSet<TbPBi> LinhasEncomendas { get; set; }
        //public DbSet<TbPBID> LinhasEncomendasDois { get; set; }
        //public DbSet<TbPContaCorrente> ContasCorrentes { get; set; }

        //public DbSet<TbPBO> CabecalhosEncomendas { get; set; }
        //public DbSet<TbPBOD> CabecalhosEncomendasDois { get; set; }
        ////public DbSet<TbRl> LinhasRecibos { get; set; }
        //public DbSet<TbStock> Stocks { get; set; }
        //public DbSet<TbTaxasiva> TaxasIva { get; set; }
        //public DbSet<PFiltrosClientes> FiltrosClientes { get; set; }
        //public DbSet<PFiltrosStocks> FiltrosStocks { get; set; } 


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
            //Database.SetInitializer(new PHCDBCustomInitializer());
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
            //DisableUnicodeForAllEntityStrings(modelBuilder);
        }


        #region NAOFUNCIONA
        private void DisableUnicodeForAllEntityStrings(DbModelBuilder modelBuilder)
        {
            var entityTypes = from property in GetType().GetProperties()
                              where property.PropertyType.IsGenericType
                                    && property.PropertyType.Name.StartsWith("DbSet")
                              let entityType = property.PropertyType.GetGenericArguments()[0]
                              select entityType;

            foreach (var item in entityTypes.Where(item => item.Name == "Stobs"))
            {
                DisableUnicodeForEntityStrings(modelBuilder, item);
            }
        }

        private static void DisableUnicodeForEntityStrings(DbModelBuilder modelBuilder, Type entityType)
        {
            // Get all string properties with setters
            var stringProperties = (from property in entityType.GetProperties()
                                   where property.PropertyType == typeof(string)
                                       && property.CanWrite
                                   select property);

            // Each table field must be varchar for now,
            // so take the string property & call IsNotUnicode.
            foreach (var propertyConfig in (from prop in stringProperties let exprType = typeof(Expression<>)
                                                                              .MakeGenericType(typeof(Func<,>)
                                                                                                   .MakeGenericType(prop.ReflectedType, typeof(string))) let obj = modelBuilder.GetType()
                                                                                                                                                             .GetMethod("Entity")
                                                                                                                                                             .MakeGenericMethod(prop.ReflectedType)
                                                                                                                                                             .Invoke(modelBuilder, null) let pe = Expression.Parameter(prop.ReflectedType, "p") let expression = Expression.Lambda(Expression.Property(pe, prop.Name), pe) select obj.GetType()
                                                                                                                                                                                                                                                                                                                               .GetMethod("Property", new[] { exprType })
                                                                                                                                                                                                                                                                                                                               .Invoke(obj, new[] { expression }) into p select p).OfType<StringPropertyConfiguration>())
            {
                propertyConfig.IsUnicode(false);
            }
        }

        #endregion
    }
}