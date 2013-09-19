using System.Data.Entity.ModelConfiguration;

namespace PHCServiceConnector.Model.DbModel.IFModel.Mapping
{
    public class OpcoesTerminaisMap : EntityTypeConfiguration<OpcoesTerminais>
    {
        public OpcoesTerminaisMap()
        {
            // Primary Key
            HasKey(t => t.ID);

            // Properties
            Property(t => t.PhcNomeFiltroClientes)
                .IsRequired()
                .HasMaxLength(150);

            Property(t => t.PhcNomeFiltroArtigos)
                .IsRequired()
                .HasMaxLength(150);

            Property(t => t.PhcNomeDossierInterno)
                .IsRequired()
                .HasMaxLength(25);

            Property(t => t.TipoRetencaoEncomendas)
                .IsRequired()
                .HasMaxLength(2);

            Property(t => t.IniciaisUs)
                .IsRequired()
                .HasMaxLength(3);

            Property(t => t.NomeVendedor)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("TbOpcoesTerminal");
            Property(t => t.ID).HasColumnName("ID");
            Property(t => t.PhcNomeFiltroClientes).HasColumnName("PHCNomeFiltroClientes");
            Property(t => t.NumMaxDescontos).HasColumnName("NumMaxDescontos");
            Property(t => t.PhcNomeFiltroArtigos).HasColumnName("PHCNomeFiltroArtigos");
            Property(t => t.ArmazemEnvio).HasColumnName("ArmazemEnvio");
            Property(t => t.ArmazemRegisto).HasColumnName("ArmazemRegisto");
            Property(t => t.PhcNumDossierInterno).HasColumnName("PHCNumDossierInterno");
            Property(t => t.PhcNomeDossierInterno).HasColumnName("PHCNomeDossierInterno");
            Property(t => t.TipoRetencaoEncomendas).HasColumnName("TipoRetencaoEncomendas");
            Property(t => t.NumeroEncomendasRetidas).HasColumnName("NumeroEncomendasRetidas");
            Property(t => t.NumeroInicioClientes).HasColumnName("NumeroInicioClientes");
            Property(t => t.NumeroFimClientes).HasColumnName("NumeroFimClientes");
            Property(t => t.NumeroInicioEncomendas).HasColumnName("NumeroInicioEncomendas");
            Property(t => t.NumeroFimEncomendas).HasColumnName("NumeroFimEncomendas");
            Property(t => t.EliminarEncomendas).HasColumnName("EliminarEncomendas");
            Property(t => t.AlterarPrecoVenda).HasColumnName("AlterarPrecoVenda");
            Property(t => t.IntroduzComponentes).HasColumnName("IntroduzComponentes");
            Property(t => t.MostrarDataLinhas).HasColumnName("MostrarDataLinhas");
            Property(t => t.CriaLinhaEncomenda).HasColumnName("CriaLinhaEncomenda");
            Property(t => t.UsaPreco1).HasColumnName("UsaPreco1");
            Property(t => t.UsaPreco2).HasColumnName("UsaPreco2");
            Property(t => t.UsaPreco3).HasColumnName("UsaPreco3");
            Property(t => t.UsaPreco4).HasColumnName("UsaPreco4");
            Property(t => t.UsaPreco5).HasColumnName("UsaPreco5");
            Property(t => t.IniciaisUs).HasColumnName("IniciaisUS");
            Property(t => t.NumVendedor).HasColumnName("NumVendedor");
            Property(t => t.NomeVendedor).HasColumnName("NomeVendedor");
            Property(t => t.SincronizaCcNaoRegula).HasColumnName("SincronizaCCNaoRegula");
        }
    }
}