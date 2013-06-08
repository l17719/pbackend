using System.Data.Entity;
namespace ConnectorService.Model.IFModel
{
    public class DbContextIfElse : DbContext
    {
        public DbSet<TbTerminais> Terminais { get; set; }
        public DbSet<TbOpcoesTerminal> OpcoesTerminais { get; set; }

        public DbContextIfElse(string connection)
            : base(connection)
        {
            //Database.SetInitializer(new DbIfCustomInitializer());
            Database.SetInitializer<DbContextIfElse>(null);
           
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<TbTerminais>().ToTable("dbo.TbTerminal");
            modelBuilder.Entity<TbOpcoesTerminal>().ToTable("dbo.TbOpcoesTerminal");
           // 
            modelBuilder.Entity<TbTerminais>()
                .HasRequired(ot => ot.OpcoesTerminal)
                .WithMany(t => t.TbTerminals)
                .HasForeignKey(x => x.OpcoesTerminalId)
                .WillCascadeOnDelete(true);
        }
       
    }
}