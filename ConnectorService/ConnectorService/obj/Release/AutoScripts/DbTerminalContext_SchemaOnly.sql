SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TbOpcoesTerminal](
	[ID] [uniqueidentifier] NOT NULL,
	[PHCNomeFiltroClientes] [varchar](150) COLLATE Latin1_General_CI_AS NOT NULL,
	[NumMaxDescontos] [int] NOT NULL,
	[PHCNomeFiltroArtigos] [varchar](150) COLLATE Latin1_General_CI_AS NOT NULL,
	[ArmazemEnvio] [numeric](18, 2) NOT NULL,
	[ArmazemRegisto] [numeric](18, 2) NOT NULL,
	[PHCNumDossierInterno] [numeric](18, 2) NOT NULL,
	[PHCNomeDossierInterno] [varchar](25) COLLATE Latin1_General_CI_AS NOT NULL,
	[TipoRetencaoEncomendas] [varchar](2) COLLATE Latin1_General_CI_AS NOT NULL,
	[NumeroEncomendasRetidas] [int] NOT NULL,
	[NumeroInicioClientes] [int] NOT NULL,
	[NumeroFimClientes] [int] NOT NULL,
	[NumeroInicioEncomendas] [int] NOT NULL,
	[NumeroFimEncomendas] [int] NOT NULL,
	[EliminarEncomendas] [bit] NOT NULL,
	[AlterarPrecoVenda] [bit] NOT NULL,
	[IntroduzComponentes] [bit] NOT NULL,
	[MostrarDataLinhas] [bit] NOT NULL,
	[CriaLinhaEncomenda] [bit] NOT NULL,
	[UsaPreco1] [bit] NOT NULL,
	[UsaPreco2] [bit] NOT NULL,
	[UsaPreco3] [bit] NOT NULL,
	[UsaPreco4] [bit] NOT NULL,
	[UsaPreco5] [bit] NOT NULL,
	[IniciaisUS] [varchar](3) COLLATE Latin1_General_CI_AS NOT NULL,
	[NumVendedor] [int] NOT NULL,
	[NomeVendedor] [varchar](50) COLLATE Latin1_General_CI_AS NOT NULL,
	[SincronizaCCNaoRegula] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EdmMetadata](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ModelHash] [nvarchar](max) COLLATE Latin1_General_CI_AS NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TbTerminal](
	[IDTerminal] [uniqueidentifier] NOT NULL,
	[FkIDOT] [uniqueidentifier] NOT NULL,
	[NumPda] [varchar](40) COLLATE Latin1_General_CI_AS NOT NULL,
	[MacAddress3G] [varchar](50) COLLATE Latin1_General_CI_AS NOT NULL,
	[MacAddressWireless] [varchar](50) COLLATE Latin1_General_CI_AS NOT NULL,
	[TerminalAccessKey] [uniqueidentifier] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDTerminal] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)

GO
ALTER TABLE [dbo].[TbTerminal]  WITH CHECK ADD  CONSTRAINT [TbTerminal_OpcoesTerminal] FOREIGN KEY([FkIDOT])
REFERENCES [dbo].[TbOpcoesTerminal] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TbTerminal] CHECK CONSTRAINT [TbTerminal_OpcoesTerminal]
GO
