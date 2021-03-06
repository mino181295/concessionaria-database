USE [DBProject1617]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 30/08/2017 14:37:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[Id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[TipoCliente] [char](1) NOT NULL,
	[CodiceFiscale] [varchar](16) NULL,
	[Nome] [varchar](20) NULL,
	[Cognome] [varchar](20) NULL,
	[DataNascita] [date] NULL,
	[CittàNascita] [varchar](30) NULL,
	[ProvinciaNascita] [varchar](30) NULL,
	[PartitaIVA] [char](11) NULL,
	[RagioneSociale] [varchar](50) NULL,
	[Recapito1] [varchar](12) NOT NULL,
	[Recapito2] [char](1) NULL,
	[IndirizzoEmail1] [varchar](30) NULL,
	[IndirizzoEmail2] [char](1) NULL,
	[Indirizzo] [varchar](50) NOT NULL,
	[Città] [varchar](30) NOT NULL,
	[Provincia] [varchar](30) NOT NULL,
	[CAP] [char](5) NOT NULL,
 CONSTRAINT [PK__Cliente__3214EC07955780D3] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ContrattoVendita]    Script Date: 30/08/2017 14:37:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContrattoVendita](
	[Numero] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Data] [date] NOT NULL,
	[ImportoComplessivo] [real] NOT NULL,
	[ModalitàPagamento] [real] NOT NULL,
	[Cliente] [numeric](18, 0) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Numero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Corriere]    Script Date: 30/08/2017 14:37:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Corriere](
	[PartitaIVA] [char](11) NOT NULL,
	[RagioneSociale] [varchar](30) NOT NULL,
	[Indirizzo] [varchar](50) NOT NULL,
	[Città] [varchar](30) NOT NULL,
	[Provincia] [varchar](30) NOT NULL,
	[CAP] [char](5) NOT NULL,
	[Recapito1] [varchar](12) NOT NULL,
	[Recapito2] [varchar](12) NULL,
	[IndirizzoEmail1] [varchar](50) NOT NULL,
	[IndirizzoEmail2] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[PartitaIVA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Dotazione]    Script Date: 30/08/2017 14:37:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dotazione](
	[Optional] [char](6) NOT NULL,
	[Veicolo] [numeric](18, 0) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Veicolo] ASC,
	[Optional] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[FatturaAcquisto]    Script Date: 30/08/2017 14:37:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FatturaAcquisto](
	[Fornitore] [char](11) NOT NULL,
	[Numero] [numeric](6, 0) NOT NULL,
	[Ordine] [numeric](18, 0) NOT NULL,
	[Data] [date] NOT NULL,
	[ImportoComplessivo] [real] NOT NULL,
	[ModPagamentoFornitore] [char](11) NOT NULL,
	[ModPagamentoDa] [real] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Fornitore] ASC,
	[Numero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Fornitore]    Script Date: 30/08/2017 14:37:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fornitore](
	[PartitaIVA] [char](11) NOT NULL,
	[CasaProduttrice] [char](1) NOT NULL,
	[FornitoreRicambi] [char](1) NOT NULL,
	[RagioneSociale] [varchar](50) NOT NULL,
	[Recapito1] [varchar](12) NOT NULL,
	[Recapito2] [varchar](12) NULL,
	[IndirizzoEmail1] [varchar](50) NOT NULL,
	[IndirizzoEmail2] [varchar](50) NULL,
	[Indirizzo] [varchar](50) NOT NULL,
	[Città] [varchar](30) NOT NULL,
	[Provincia] [varchar](30) NOT NULL,
	[CAP] [char](5) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PartitaIVA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Giacenza]    Script Date: 30/08/2017 14:37:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Giacenza](
	[Ricambio] [char](6) NOT NULL,
	[Numero] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Data] [date] NOT NULL,
	[Quantità] [numeric](6, 0) NOT NULL,
	[Causale] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Ricambio] ASC,
	[Numero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ModalitàPagamento]    Script Date: 30/08/2017 14:37:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ModalitàPagamento](
	[Fornitore] [char](11) NOT NULL,
	[Da] [real] NOT NULL,
	[A] [real] NOT NULL,
	[Periodicità] [varchar](10) NOT NULL,
	[TassoInteresse] [real] NOT NULL,
	[NumeroRate] [numeric](2, 0) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Fornitore] ASC,
	[Da] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ModelloVeicolo]    Script Date: 30/08/2017 14:37:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ModelloVeicolo](
	[Nome] [varchar](20) NOT NULL,
	[Anno] [numeric](4, 0) NOT NULL,
	[CasaProduttrice] [char](11) NOT NULL,
 CONSTRAINT [PK_ModelloVeicolo] PRIMARY KEY CLUSTERED 
(
	[Nome] ASC,
	[Anno] ASC,
	[CasaProduttrice] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NostreModalitàPagamento]    Script Date: 30/08/2017 14:37:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NostreModalitàPagamento](
	[Da] [real] NOT NULL,
	[A] [real] NOT NULL,
	[Periodicità] [varchar](10) NOT NULL,
	[TassoInteresse] [real] NOT NULL,
	[NumerRate] [numeric](2, 0) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Da] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Optional]    Script Date: 30/08/2017 14:37:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Optional](
	[Codice] [char](6) NOT NULL,
	[Nome] [varchar](30) NOT NULL,
	[Descrizione] [varchar](255) NOT NULL,
	[Prezzo] [real] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Codice] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ordine]    Script Date: 30/08/2017 14:37:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ordine](
	[Id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[TipoOrdine] [char](1) NOT NULL,
	[DataOrdine] [date] NOT NULL,
	[DataConsegnaPrevista] [date] NOT NULL,
	[DataConsegna] [date] NULL,
	[Fornitore] [char](11) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OrdineRicambio]    Script Date: 30/08/2017 14:37:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrdineRicambio](
	[Ordine] [numeric](18, 0) NOT NULL,
	[Ricambio] [char](6) NOT NULL,
	[Quantità] [numeric](6, 0) NOT NULL,
	[PrezzoUnitario] [real] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Ordine] ASC,
	[Ricambio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OrdineVeicolo]    Script Date: 30/08/2017 14:37:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrdineVeicolo](
	[Veicolo] [numeric](18, 0) NOT NULL,
	[PrezzoFornitore] [real] NOT NULL,
	[Ordine] [numeric](18, 0) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Veicolo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Rata]    Script Date: 30/08/2017 14:37:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rata](
	[FornitoreFattura] [char](11) NOT NULL,
	[NumeroFattura] [numeric](6, 0) NOT NULL,
	[Scadenza] [date] NOT NULL,
	[Importo] [real] NOT NULL,
	[DataPagamento] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[FornitoreFattura] ASC,
	[NumeroFattura] ASC,
	[Scadenza] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[RataCliente]    Script Date: 30/08/2017 14:37:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RataCliente](
	[Contratto] [numeric](18, 0) NOT NULL,
	[Scadenza] [date] NOT NULL,
	[Importo] [real] NOT NULL,
	[DataPagamento] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[Contratto] ASC,
	[Scadenza] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Referenza]    Script Date: 30/08/2017 14:37:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Referenza](
	[VeicoloCatalogo] [char](6) NOT NULL,
	[Ricambio] [char](6) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[VeicoloCatalogo] ASC,
	[Ricambio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Revisione]    Script Date: 30/08/2017 14:37:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Revisione](
	[VeicoloVenduto] [numeric](18, 0) NOT NULL,
	[Numero] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Scadenza] [date] NOT NULL,
	[DataEsecuzione] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[VeicoloVenduto] ASC,
	[Numero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ricambio]    Script Date: 30/08/2017 14:37:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ricambio](
	[Codice] [char](6) NOT NULL,
	[Nome] [varchar](30) NOT NULL,
	[Descrizione] [varchar](255) NOT NULL,
	[PrezzoUnitarioRiparazione] [real] NOT NULL,
	[TipoRicambio] [char](1) NOT NULL,
	[Fornitore] [char](11) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Codice] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Riparazione]    Script Date: 30/08/2017 14:37:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Riparazione](
	[Veicolo] [numeric](18, 0) NOT NULL,
	[Numero] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Data] [date] NOT NULL,
	[ImportoComplessivo] [real] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Veicolo] ASC,
	[Numero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Supporto]    Script Date: 30/08/2017 14:37:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supporto](
	[VeicoloCatalogo] [char](6) NOT NULL,
	[Optional] [char](6) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Optional] ASC,
	[VeicoloCatalogo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Trasporto]    Script Date: 30/08/2017 14:37:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Trasporto](
	[Codice] [char](6) NOT NULL,
	[Costo] [real] NULL,
	[DataConsegnaPrevista] [date] NOT NULL,
	[DataConsegna] [date] NULL,
	[IndirizzoConsegna] [varchar](50) NOT NULL,
	[CittàConsegna] [varchar](30) NOT NULL,
	[ProvinciaConsegna] [varchar](30) NOT NULL,
	[Corriere] [char](11) NULL,
	[ContrattoNumero] [numeric](18, 0) NOT NULL,
 CONSTRAINT [PK__Trasport__0636EC1C2BB60988] PRIMARY KEY CLUSTERED 
(
	[Codice] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Utilizzo]    Script Date: 30/08/2017 14:37:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Utilizzo](
	[Ricambio] [char](6) NOT NULL,
	[Veicolo] [numeric](18, 0) NOT NULL,
	[Numero] [numeric](18, 0) NOT NULL,
	[Quantità] [numeric](6, 0) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Ricambio] ASC,
	[Veicolo] ASC,
	[Numero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[VeicoloCatalogo]    Script Date: 30/08/2017 14:37:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VeicoloCatalogo](
	[Codice] [char](6) NOT NULL,
	[PrezzoBase] [real] NOT NULL,
	[Potenza] [real] NOT NULL,
	[NumPosti] [numeric](1, 0) NOT NULL,
	[Consumi] [real] NOT NULL,
	[Omologazione] [varchar](10) NOT NULL,
	[CapacitàSerbatorio] [real] NOT NULL,
	[TipoAlimentazione] [varchar](20) NOT NULL,
	[Cilindrata] [real] NOT NULL,
	[Trazione] [varchar](20) NOT NULL,
	[Cambio] [varchar](20) NOT NULL,
	[CapienzaBagagliaio] [real] NOT NULL,
	[NumPorte] [numeric](1, 0) NOT NULL,
	[NomeModello] [varchar](20) NOT NULL,
	[AnnoModello] [numeric](4, 0) NOT NULL,
	[CasaProduttrice] [char](11) NOT NULL,
 CONSTRAINT [PK__VeicoloC__0636EC1CE01AB3FA] PRIMARY KEY CLUSTERED 
(
	[Codice] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[VeicoloVenduto]    Script Date: 30/08/2017 14:37:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VeicoloVenduto](
	[Id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Telaio] [char](17) NULL,
	[Contratto] [numeric](18, 0) NOT NULL,
	[VeicoloCatalogo] [char](6) NOT NULL,
 CONSTRAINT [PK__VeicoloV__3214EC07D2CAC9BD] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Fornitore] ([PartitaIVA], [CasaProduttrice], [FornitoreRicambi], [RagioneSociale], [Recapito1], [Recapito2], [IndirizzoEmail1], [IndirizzoEmail2], [Indirizzo], [Città], [Provincia], [CAP]) VALUES (N'f1d258s79q4', N'y', N'y', N'Renault', N'7894561230', NULL, N'renaultitalia@prova.it', NULL, N'Via Tiburtina, 1155', N'Roma', N'RM', N'00156')
INSERT [dbo].[Fornitore] ([PartitaIVA], [CasaProduttrice], [FornitoreRicambi], [RagioneSociale], [Recapito1], [Recapito2], [IndirizzoEmail1], [IndirizzoEmail2], [Indirizzo], [Città], [Provincia], [CAP]) VALUES (N'poje58s79q4', N'n', N'y', N'Girotti.srl', N'6543219870', NULL, N'girotti_ricambi@prova.it', NULL, N'Via Ettorina, 55', N'Bologna', N'Bo', N'40121')
INSERT [dbo].[Fornitore] ([PartitaIVA], [CasaProduttrice], [FornitoreRicambi], [RagioneSociale], [Recapito1], [Recapito2], [IndirizzoEmail1], [IndirizzoEmail2], [Indirizzo], [Città], [Provincia], [CAP]) VALUES (N'qw789e4f567', N'y', N'y', N'Fiat', N'1234567890', NULL, N'fiatgroup@prova.it', NULL, N'via macchinaita 5', N'Torino', N'TO', N'12345')
INSERT [dbo].[ModelloVeicolo] ([Nome], [Anno], [CasaProduttrice]) VALUES (N'308', CAST(2013 AS Numeric(4, 0)), N'f1d258s79q4')
INSERT [dbo].[ModelloVeicolo] ([Nome], [Anno], [CasaProduttrice]) VALUES (N'500', CAST(2015 AS Numeric(4, 0)), N'qw789e4f567')
INSERT [dbo].[ModelloVeicolo] ([Nome], [Anno], [CasaProduttrice]) VALUES (N'Punto', CAST(2012 AS Numeric(4, 0)), N'qw789e4f567')
INSERT [dbo].[Optional] ([Codice], [Nome], [Descrizione], [Prezzo]) VALUES (N'4f557d', N'Clima', N'Climatizzatore', 50)
INSERT [dbo].[Optional] ([Codice], [Nome], [Descrizione], [Prezzo]) VALUES (N'5eg57d', N'Stereo', N'Impianto stereo integrato', 240)
INSERT [dbo].[Optional] ([Codice], [Nome], [Descrizione], [Prezzo]) VALUES (N'fag57d', N'Finestrini oscurati', N'Finestrini oscurati', 220)
INSERT [dbo].[Supporto] ([VeicoloCatalogo], [Optional]) VALUES (N'5f4a8e', N'4f557d')
INSERT [dbo].[Supporto] ([VeicoloCatalogo], [Optional]) VALUES (N'fap4a8', N'4f557d')
INSERT [dbo].[Supporto] ([VeicoloCatalogo], [Optional]) VALUES (N'5f4a8e', N'5eg57d')
INSERT [dbo].[Supporto] ([VeicoloCatalogo], [Optional]) VALUES (N'5f4a8e', N'fag57d')
INSERT [dbo].[Supporto] ([VeicoloCatalogo], [Optional]) VALUES (N'7f4a8e', N'fag57d')
INSERT [dbo].[Supporto] ([VeicoloCatalogo], [Optional]) VALUES (N'fap4a8', N'fag57d')
INSERT [dbo].[VeicoloCatalogo] ([Codice], [PrezzoBase], [Potenza], [NumPosti], [Consumi], [Omologazione], [CapacitàSerbatorio], [TipoAlimentazione], [Cilindrata], [Trazione], [Cambio], [CapienzaBagagliaio], [NumPorte], [NomeModello], [AnnoModello], [CasaProduttrice]) VALUES (N'5f4a8e', 15000, 75, CAST(5 AS Numeric(1, 0)), 12, N'Euro 4', 30, N'Benzina', 1200, N'Posteriore', N'Manuale', 50, CAST(5 AS Numeric(1, 0)), N'Punto', CAST(2012 AS Numeric(4, 0)), N'qw789e4f567')
INSERT [dbo].[VeicoloCatalogo] ([Codice], [PrezzoBase], [Potenza], [NumPosti], [Consumi], [Omologazione], [CapacitàSerbatorio], [TipoAlimentazione], [Cilindrata], [Trazione], [Cambio], [CapienzaBagagliaio], [NumPorte], [NomeModello], [AnnoModello], [CasaProduttrice]) VALUES (N'7f4a8e', 12500, 75, CAST(5 AS Numeric(1, 0)), 12, N'Euro 4', 30, N'Benzina', 1200, N'Posteriore', N'Manuale', 50, CAST(5 AS Numeric(1, 0)), N'308', CAST(2013 AS Numeric(4, 0)), N'f1d258s79q4')
INSERT [dbo].[VeicoloCatalogo] ([Codice], [PrezzoBase], [Potenza], [NumPosti], [Consumi], [Omologazione], [CapacitàSerbatorio], [TipoAlimentazione], [Cilindrata], [Trazione], [Cambio], [CapienzaBagagliaio], [NumPorte], [NomeModello], [AnnoModello], [CasaProduttrice]) VALUES (N'fap4a8', 12500, 75, CAST(5 AS Numeric(1, 0)), 12, N'Euro 4', 30, N'Benzina', 1200, N'Posteriore', N'Manuale', 50, CAST(3 AS Numeric(1, 0)), N'500', CAST(2015 AS Numeric(4, 0)), N'qw789e4f567')
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__Cliente__C3073E2704FDD5D2]    Script Date: 30/08/2017 14:37:51 ******/
ALTER TABLE [dbo].[Cliente] ADD  CONSTRAINT [UQ__Cliente__C3073E2704FDD5D2] UNIQUE NONCLUSTERED 
(
	[CodiceFiscale] ASC,
	[PartitaIVA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [UQ__FatturaA__498CBBDBDFB62D1C]    Script Date: 30/08/2017 14:37:51 ******/
ALTER TABLE [dbo].[FatturaAcquisto] ADD UNIQUE NONCLUSTERED 
(
	[Ordine] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [uniqueContract]    Script Date: 30/08/2017 14:37:51 ******/
ALTER TABLE [dbo].[Trasporto] ADD  CONSTRAINT [uniqueContract] UNIQUE NONCLUSTERED 
(
	[ContrattoNumero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ContrattoVendita]  WITH CHECK ADD  CONSTRAINT [FKdefinizione] FOREIGN KEY([ModalitàPagamento])
REFERENCES [dbo].[NostreModalitàPagamento] ([Da])
GO
ALTER TABLE [dbo].[ContrattoVendita] CHECK CONSTRAINT [FKdefinizione]
GO
ALTER TABLE [dbo].[ContrattoVendita]  WITH CHECK ADD  CONSTRAINT [FKstipulazione] FOREIGN KEY([Cliente])
REFERENCES [dbo].[Cliente] ([Id])
GO
ALTER TABLE [dbo].[ContrattoVendita] CHECK CONSTRAINT [FKstipulazione]
GO
ALTER TABLE [dbo].[Dotazione]  WITH CHECK ADD  CONSTRAINT [FKdot_Opt] FOREIGN KEY([Optional])
REFERENCES [dbo].[Optional] ([Codice])
GO
ALTER TABLE [dbo].[Dotazione] CHECK CONSTRAINT [FKdot_Opt]
GO
ALTER TABLE [dbo].[Dotazione]  WITH CHECK ADD  CONSTRAINT [FKdot_Vei] FOREIGN KEY([Veicolo])
REFERENCES [dbo].[VeicoloVenduto] ([Id])
GO
ALTER TABLE [dbo].[Dotazione] CHECK CONSTRAINT [FKdot_Vei]
GO
ALTER TABLE [dbo].[FatturaAcquisto]  WITH CHECK ADD  CONSTRAINT [FKdocumentare] FOREIGN KEY([Ordine])
REFERENCES [dbo].[Ordine] ([Id])
GO
ALTER TABLE [dbo].[FatturaAcquisto] CHECK CONSTRAINT [FKdocumentare]
GO
ALTER TABLE [dbo].[FatturaAcquisto]  WITH CHECK ADD  CONSTRAINT [FKemissione] FOREIGN KEY([Fornitore])
REFERENCES [dbo].[Fornitore] ([PartitaIVA])
GO
ALTER TABLE [dbo].[FatturaAcquisto] CHECK CONSTRAINT [FKemissione]
GO
ALTER TABLE [dbo].[FatturaAcquisto]  WITH CHECK ADD  CONSTRAINT [FKsoggezione] FOREIGN KEY([ModPagamentoFornitore], [ModPagamentoDa])
REFERENCES [dbo].[ModalitàPagamento] ([Fornitore], [Da])
GO
ALTER TABLE [dbo].[FatturaAcquisto] CHECK CONSTRAINT [FKsoggezione]
GO
ALTER TABLE [dbo].[Giacenza]  WITH CHECK ADD  CONSTRAINT [FKgiacenza] FOREIGN KEY([Ricambio])
REFERENCES [dbo].[Ricambio] ([Codice])
GO
ALTER TABLE [dbo].[Giacenza] CHECK CONSTRAINT [FKgiacenza]
GO
ALTER TABLE [dbo].[ModalitàPagamento]  WITH CHECK ADD  CONSTRAINT [FKdefinizione2] FOREIGN KEY([Fornitore])
REFERENCES [dbo].[Fornitore] ([PartitaIVA])
GO
ALTER TABLE [dbo].[ModalitàPagamento] CHECK CONSTRAINT [FKdefinizione2]
GO
ALTER TABLE [dbo].[ModelloVeicolo]  WITH CHECK ADD  CONSTRAINT [FK_ModelloVeicolo_Fornitore] FOREIGN KEY([CasaProduttrice])
REFERENCES [dbo].[Fornitore] ([PartitaIVA])
GO
ALTER TABLE [dbo].[ModelloVeicolo] CHECK CONSTRAINT [FK_ModelloVeicolo_Fornitore]
GO
ALTER TABLE [dbo].[Ordine]  WITH CHECK ADD  CONSTRAINT [FKrichiesta] FOREIGN KEY([Fornitore])
REFERENCES [dbo].[Fornitore] ([PartitaIVA])
GO
ALTER TABLE [dbo].[Ordine] CHECK CONSTRAINT [FKrichiesta]
GO
ALTER TABLE [dbo].[OrdineRicambio]  WITH CHECK ADD  CONSTRAINT [FKord_Ord] FOREIGN KEY([Ordine])
REFERENCES [dbo].[Ordine] ([Id])
GO
ALTER TABLE [dbo].[OrdineRicambio] CHECK CONSTRAINT [FKord_Ord]
GO
ALTER TABLE [dbo].[OrdineRicambio]  WITH CHECK ADD  CONSTRAINT [FKord_Ric] FOREIGN KEY([Ricambio])
REFERENCES [dbo].[Ricambio] ([Codice])
GO
ALTER TABLE [dbo].[OrdineRicambio] CHECK CONSTRAINT [FKord_Ric]
GO
ALTER TABLE [dbo].[OrdineVeicolo]  WITH CHECK ADD  CONSTRAINT [FKord_Ord2] FOREIGN KEY([Ordine])
REFERENCES [dbo].[Ordine] ([Id])
GO
ALTER TABLE [dbo].[OrdineVeicolo] CHECK CONSTRAINT [FKord_Ord2]
GO
ALTER TABLE [dbo].[OrdineVeicolo]  WITH CHECK ADD  CONSTRAINT [FKord_Vei] FOREIGN KEY([Veicolo])
REFERENCES [dbo].[VeicoloVenduto] ([Id])
GO
ALTER TABLE [dbo].[OrdineVeicolo] CHECK CONSTRAINT [FKord_Vei]
GO
ALTER TABLE [dbo].[Rata]  WITH CHECK ADD  CONSTRAINT [FKpagamento] FOREIGN KEY([FornitoreFattura], [NumeroFattura])
REFERENCES [dbo].[FatturaAcquisto] ([Fornitore], [Numero])
GO
ALTER TABLE [dbo].[Rata] CHECK CONSTRAINT [FKpagamento]
GO
ALTER TABLE [dbo].[RataCliente]  WITH CHECK ADD  CONSTRAINT [FKpagamento_cliente] FOREIGN KEY([Contratto])
REFERENCES [dbo].[ContrattoVendita] ([Numero])
GO
ALTER TABLE [dbo].[RataCliente] CHECK CONSTRAINT [FKpagamento_cliente]
GO
ALTER TABLE [dbo].[Referenza]  WITH CHECK ADD  CONSTRAINT [FKref_Ric] FOREIGN KEY([Ricambio])
REFERENCES [dbo].[Ricambio] ([Codice])
GO
ALTER TABLE [dbo].[Referenza] CHECK CONSTRAINT [FKref_Ric]
GO
ALTER TABLE [dbo].[Referenza]  WITH CHECK ADD  CONSTRAINT [FKref_Vei] FOREIGN KEY([VeicoloCatalogo])
REFERENCES [dbo].[VeicoloCatalogo] ([Codice])
GO
ALTER TABLE [dbo].[Referenza] CHECK CONSTRAINT [FKref_Vei]
GO
ALTER TABLE [dbo].[Revisione]  WITH CHECK ADD  CONSTRAINT [FKscadenza] FOREIGN KEY([VeicoloVenduto])
REFERENCES [dbo].[VeicoloVenduto] ([Id])
GO
ALTER TABLE [dbo].[Revisione] CHECK CONSTRAINT [FKscadenza]
GO
ALTER TABLE [dbo].[Ricambio]  WITH CHECK ADD  CONSTRAINT [FKfornitura] FOREIGN KEY([Fornitore])
REFERENCES [dbo].[Fornitore] ([PartitaIVA])
GO
ALTER TABLE [dbo].[Ricambio] CHECK CONSTRAINT [FKfornitura]
GO
ALTER TABLE [dbo].[Riparazione]  WITH CHECK ADD  CONSTRAINT [FKesecuzione] FOREIGN KEY([Veicolo])
REFERENCES [dbo].[VeicoloVenduto] ([Id])
GO
ALTER TABLE [dbo].[Riparazione] CHECK CONSTRAINT [FKesecuzione]
GO
ALTER TABLE [dbo].[Supporto]  WITH CHECK ADD  CONSTRAINT [FKsup_Opt] FOREIGN KEY([Optional])
REFERENCES [dbo].[Optional] ([Codice])
GO
ALTER TABLE [dbo].[Supporto] CHECK CONSTRAINT [FKsup_Opt]
GO
ALTER TABLE [dbo].[Supporto]  WITH CHECK ADD  CONSTRAINT [FKsup_Vei] FOREIGN KEY([VeicoloCatalogo])
REFERENCES [dbo].[VeicoloCatalogo] ([Codice])
GO
ALTER TABLE [dbo].[Supporto] CHECK CONSTRAINT [FKsup_Vei]
GO
ALTER TABLE [dbo].[Trasporto]  WITH CHECK ADD  CONSTRAINT [FK_Trasporto_ContrattoVendita] FOREIGN KEY([ContrattoNumero])
REFERENCES [dbo].[ContrattoVendita] ([Numero])
GO
ALTER TABLE [dbo].[Trasporto] CHECK CONSTRAINT [FK_Trasporto_ContrattoVendita]
GO
ALTER TABLE [dbo].[Trasporto]  WITH CHECK ADD  CONSTRAINT [FKesecuzione2] FOREIGN KEY([Corriere])
REFERENCES [dbo].[Corriere] ([PartitaIVA])
GO
ALTER TABLE [dbo].[Trasporto] CHECK CONSTRAINT [FKesecuzione2]
GO
ALTER TABLE [dbo].[Utilizzo]  WITH CHECK ADD  CONSTRAINT [FKuti_Ric] FOREIGN KEY([Ricambio])
REFERENCES [dbo].[Ricambio] ([Codice])
GO
ALTER TABLE [dbo].[Utilizzo] CHECK CONSTRAINT [FKuti_Ric]
GO
ALTER TABLE [dbo].[Utilizzo]  WITH CHECK ADD  CONSTRAINT [FKuti_Rip] FOREIGN KEY([Veicolo], [Numero])
REFERENCES [dbo].[Riparazione] ([Veicolo], [Numero])
GO
ALTER TABLE [dbo].[Utilizzo] CHECK CONSTRAINT [FKuti_Rip]
GO
ALTER TABLE [dbo].[VeicoloCatalogo]  WITH CHECK ADD  CONSTRAINT [FK_VeicoloCatalogo_Modello] FOREIGN KEY([NomeModello], [AnnoModello], [CasaProduttrice])
REFERENCES [dbo].[ModelloVeicolo] ([Nome], [Anno], [CasaProduttrice])
GO
ALTER TABLE [dbo].[VeicoloCatalogo] CHECK CONSTRAINT [FK_VeicoloCatalogo_Modello]
GO
ALTER TABLE [dbo].[VeicoloVenduto]  WITH CHECK ADD  CONSTRAINT [FKinclusione] FOREIGN KEY([Contratto])
REFERENCES [dbo].[ContrattoVendita] ([Numero])
GO
ALTER TABLE [dbo].[VeicoloVenduto] CHECK CONSTRAINT [FKinclusione]
GO
ALTER TABLE [dbo].[VeicoloVenduto]  WITH CHECK ADD  CONSTRAINT [FKvendita] FOREIGN KEY([VeicoloCatalogo])
REFERENCES [dbo].[VeicoloCatalogo] ([Codice])
GO
ALTER TABLE [dbo].[VeicoloVenduto] CHECK CONSTRAINT [FKvendita]
GO
