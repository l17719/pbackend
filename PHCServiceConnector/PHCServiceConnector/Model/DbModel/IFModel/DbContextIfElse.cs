using System.Data.Entity;
using PHCServiceConnector.Model.DbModel.IFModel.Mapping;

namespace PHCServiceConnector.Model.DbModel.IFModel
{
    public class DbContextIfElse:DbContext
    {

        public DbSet<Terminais> DadosTerminais { get; set; }
        public DbSet<OpcoesTerminais> DadosOpcoesTerminais { get; set; }
        
        public DbContextIfElse(string value):base(value)
        {
            Database.SetInitializer<DbContextIfElse>(null);
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new TerminalMap());
            modelBuilder.Configurations.Add(new OpcoesTerminaisMap());
        }
    }
}