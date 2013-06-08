using System.Data.Entity;
using BackEndAplication.Models.TerminalDBModel.Mapping;

namespace BackEndAplication.Models.TerminalDBModel
{
    public class DbTerminalContext : DbContext
    {
        public DbTerminalContext(string valueConnection)
            : base(valueConnection)
        {
            Database.SetInitializer(new DbTerminalCustomInitializer());
        }

        public DbSet<TbTerminal> Terminais { get; set; }
        public DbSet<TbOpcoesTerminal> OpcoesTerminais { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new TbTerminalMap());
            modelBuilder.Configurations.Add(new TbOpcoesTerminalMap());
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<TbTerminal>().ToTable("dbo.TbTerminal");
            //modelBuilder.Entity<TbOpcoesTerminal>().ToTable("dbo.TbOpcoesTerminal");
           
            //modelBuilder.Entity<TbTerminal>()
            //    .HasRequired(ot => ot.OpcoesTerminal)
            //    .WithMany(t => t.TbTerminals)
            //    .HasForeignKey(x => x.OpcoesTerminalId)
            //    .WillCascadeOnDelete(true);
        }
    }
}