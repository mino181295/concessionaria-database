USE [master]
GO
/****** Object:  Database [ProgettoDB16]    Script Date: 11/04/2017 14:57:50 ******/
CREATE DATABASE [ProgettoDB16]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ProgettoDB16', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\ProgettoDB16.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ProgettoDB16_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\ProgettoDB16_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [ProgettoDB16] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ProgettoDB16].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ProgettoDB16] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ProgettoDB16] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ProgettoDB16] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ProgettoDB16] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ProgettoDB16] SET ARITHABORT OFF 
GO
ALTER DATABASE [ProgettoDB16] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ProgettoDB16] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ProgettoDB16] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ProgettoDB16] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ProgettoDB16] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ProgettoDB16] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ProgettoDB16] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ProgettoDB16] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ProgettoDB16] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ProgettoDB16] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ProgettoDB16] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ProgettoDB16] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ProgettoDB16] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ProgettoDB16] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ProgettoDB16] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ProgettoDB16] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ProgettoDB16] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ProgettoDB16] SET RECOVERY FULL 
GO
ALTER DATABASE [ProgettoDB16] SET  MULTI_USER 
GO
ALTER DATABASE [ProgettoDB16] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ProgettoDB16] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ProgettoDB16] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ProgettoDB16] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ProgettoDB16] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'ProgettoDB16', N'ON'
GO
ALTER DATABASE [ProgettoDB16] SET QUERY_STORE = OFF
GO
USE [ProgettoDB16]
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [ProgettoDB16]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 11/04/2017 14:57:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[PartitaIVA_CodiceFiscale] [char](11) NOT NULL,
	[Recapito_1] [varchar](12) NOT NULL,
	[Recapito_2] [varchar](12) NULL,
	[Recapito_3] [varchar](12) NULL,
	[Citta] [varchar](25) NOT NULL,
	[Indirizzo] [varchar](30) NOT NULL,
	[Provincia] [varchar](30) NOT NULL,
	[CAP] [char](5) NOT NULL,
	[Tipo_Cliente] [char](1) NOT NULL,
	[Ragione_sociale] [varchar](25) NULL,
	[Indirizzo_e_mail_1] [varchar](30) NULL,
	[Indirizzo_e_mail_2] [varchar](30) NULL,
	[Nome] [varchar](20) NULL,
	[Cognome] [varchar](20) NULL,
	[Data_nascita] [date] NULL,
	[Citta_nascita] [varchar](30) NULL,
	[Provincia_nascita] [varchar](30) NULL,
 CONSTRAINT [ID_Cliente_ID] PRIMARY KEY CLUSTERED 
(
	[PartitaIVA_CodiceFiscale] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Contratto_di_vendita]    Script Date: 11/04/2017 14:57:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contratto_di_vendita](
	[Numero] [int] NOT NULL,
	[Data] [date] NOT NULL,
	[Importo_complessivo] [real] NOT NULL,
	[Nostre_Mod_Da] [real] NOT NULL,
	[Cliente_PartitaIVA_CodiceFiscale] [char](11) NOT NULL,
 CONSTRAINT [ID_Contratto_di_vendita_ID] PRIMARY KEY CLUSTERED 
(
	[Numero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Corriere]    Script Date: 11/04/2017 14:57:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Corriere](
	[Partita_IVA] [char](11) NOT NULL,
	[Ragione_sociale] [varchar](30) NOT NULL,
	[Citta] [varchar](25) NOT NULL,
	[Provincia] [varchar](30) NOT NULL,
	[Indirizzo] [varchar](30) NOT NULL,
	[CAP] [char](5) NOT NULL,
	[Recapito_1] [varchar](12) NOT NULL,
	[Recapito_2] [varchar](12) NULL,
	[Indirizzo_e_mail_1] [varchar](30) NOT NULL,
	[Indirizzo_e_mail_2] [varchar](30) NULL,
 CONSTRAINT [ID_Corriere_ID] PRIMARY KEY CLUSTERED 
(
	[Partita_IVA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[di]    Script Date: 11/04/2017 14:57:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[di](
	[Ordine_ID_ordine] [char](6) NOT NULL,
	[Ricambio_Codice] [char](5) NOT NULL,
	[quantita] [int] NOT NULL,
 CONSTRAINT [ID_di_ID] PRIMARY KEY CLUSTERED 
(
	[Ordine_ID_ordine] ASC,
	[Ricambio_Codice] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Fattura_di_acquisto]    Script Date: 11/04/2017 14:57:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fattura_di_acquisto](
	[Fornitore_Partita_IVA] [char](11) NOT NULL,
	[Numero] [int] NOT NULL,
	[Data] [date] NOT NULL,
	[Importo_complessivo] [real] NOT NULL,
	[Mod_Pagamento_Partita_IVA] [char](11) NOT NULL,
	[Mod_Pagamento_Da] [real] NOT NULL,
 CONSTRAINT [ID_Fattura_di_acquisto_ID] PRIMARY KEY CLUSTERED 
(
	[Fornitore_Partita_IVA] ASC,
	[Numero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Fornitore]    Script Date: 11/04/2017 14:57:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fornitore](
	[Partita_IVA] [char](11) NOT NULL,
	[Ragione_Sociale] [varchar](30) NOT NULL,
	[Recapito_1] [varchar](12) NOT NULL,
	[Recapito_2] [varchar](12) NULL,
	[Recapito_3] [varchar](12) NULL,
	[Indirizzo_e_mail_1] [varchar](25) NOT NULL,
	[Indirizzo_e_mail_2] [varchar](25) NULL,
	[Tipo_Ricambi] [char](1) NOT NULL,
	[Tipo_CasaProduttrice] [char](1) NOT NULL,
	[Citta] [varchar](25) NOT NULL,
	[Provincia] [varchar](30) NOT NULL,
	[Indirizzo] [varchar](30) NOT NULL,
	[CAP] [char](4) NOT NULL,
 CONSTRAINT [ID_Fornitore_ID] PRIMARY KEY CLUSTERED 
(
	[Partita_IVA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Giacenza]    Script Date: 11/04/2017 14:57:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Giacenza](
	[Ricambio_Codice] [char](5) NOT NULL,
	[Numero] [int] NOT NULL,
	[Data] [date] NOT NULL,
	[Quantita] [int] NOT NULL,
	[Causale] [varchar](40) NULL,
 CONSTRAINT [ID_Giacenza_ID] PRIMARY KEY CLUSTERED 
(
	[Ricambio_Codice] ASC,
	[Numero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Modalita_di_pagamento]    Script Date: 11/04/2017 14:57:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Modalita_di_pagamento](
	[Fornitore_Partita_IVA] [char](11) NOT NULL,
	[Da] [real] NOT NULL,
	[A] [real] NOT NULL,
	[Periodicita] [varchar](10) NOT NULL,
	[Tasso_interesse] [real] NOT NULL,
	[Numero_rate] [int] NOT NULL,
 CONSTRAINT [ID_Modalita_di_pagamento_ID] PRIMARY KEY CLUSTERED 
(
	[Fornitore_Partita_IVA] ASC,
	[Da] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Modello_veicolo]    Script Date: 11/04/2017 14:57:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Modello_veicolo](
	[Nome] [varchar](20) NOT NULL,
	[Anno] [date] NOT NULL,
	[Fornitore_Partita_IVA] [char](11) NOT NULL,
 CONSTRAINT [ID_Modello_veicolo_ID] PRIMARY KEY CLUSTERED 
(
	[Fornitore_Partita_IVA] ASC,
	[Nome] ASC,
	[Anno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Nostre_modalita_di_pagamento]    Script Date: 11/04/2017 14:57:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nostre_modalita_di_pagamento](
	[Da] [real] NOT NULL,
	[A] [real] NOT NULL,
	[Periodicita] [varchar](10) NOT NULL,
	[Tasso_interesse] [real] NOT NULL,
	[Numero_rate] [int] NOT NULL,
 CONSTRAINT [ID_Nostre_modalita_di_pagamento_ID] PRIMARY KEY CLUSTERED 
(
	[Da] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Optional]    Script Date: 11/04/2017 14:57:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Optional](
	[Codice] [char](5) NOT NULL,
	[Nome] [varchar](20) NOT NULL,
	[Descrizione] [varchar](200) NOT NULL,
	[Prezzo] [real] NOT NULL,
 CONSTRAINT [ID_Optional_ID] PRIMARY KEY CLUSTERED 
(
	[Codice] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ordine]    Script Date: 11/04/2017 14:57:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ordine](
	[ID_ordine] [char](6) NOT NULL,
	[Fattura_Partita_IVA] [char](11) NOT NULL,
	[Numero] [int] NOT NULL,
	[Data_ordine] [date] NOT NULL,
	[Data_spedizione] [date] NOT NULL,
	[Data_consegna_1] [date] NULL,
	[Data_consegna_2] [date] NULL,
	[Tipo_Ordine] [char](1) NOT NULL,
 CONSTRAINT [ID_Ordine_ID] PRIMARY KEY CLUSTERED 
(
	[ID_ordine] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Pagamento_cAcquisto]    Script Date: 11/04/2017 14:57:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pagamento_cAcquisto](
	[Fattura_Partita_IVA] [char](11) NOT NULL,
	[Fattura_Numero] [int] NOT NULL,
	[Data] [date] NOT NULL,
	[Importo] [real] NOT NULL,
 CONSTRAINT [ID_Pagamento_cAcquisto_ID] PRIMARY KEY CLUSTERED 
(
	[Fattura_Partita_IVA] ASC,
	[Fattura_Numero] ASC,
	[Data] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Pagamento_cVendita]    Script Date: 11/04/2017 14:57:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pagamento_cVendita](
	[Contratto_Numero] [int] NOT NULL,
	[Data] [date] NOT NULL,
	[Importo] [real] NOT NULL,
 CONSTRAINT [ID_Pagamento_cVendita_ID] PRIMARY KEY CLUSTERED 
(
	[Contratto_Numero] ASC,
	[Data] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[per2]    Script Date: 11/04/2017 14:57:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[per2](
	[Veicolo_Codice] [char](5) NOT NULL,
	[Ordine_ID_ordine] [char](6) NOT NULL,
	[quantita] [int] NOT NULL,
 CONSTRAINT [ID_per2_ID] PRIMARY KEY CLUSTERED 
(
	[Veicolo_Codice] ASC,
	[Ordine_ID_ordine] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[possesso]    Script Date: 11/04/2017 14:57:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[possesso](
	[Veicolo_Numero_telaio] [char](17) NOT NULL,
	[Optional_Codice] [char](5) NOT NULL,
 CONSTRAINT [ID_possesso_ID] PRIMARY KEY CLUSTERED 
(
	[Veicolo_Numero_telaio] ASC,
	[Optional_Codice] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[referenza2]    Script Date: 11/04/2017 14:57:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[referenza2](
	[Veicolo_Codice] [char](5) NOT NULL,
	[Ricambio_Codice] [char](5) NOT NULL,
 CONSTRAINT [ID_referenza2_ID] PRIMARY KEY CLUSTERED 
(
	[Veicolo_Codice] ASC,
	[Ricambio_Codice] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Revisione]    Script Date: 11/04/2017 14:57:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Revisione](
	[Veicolo_Numero_telaio] [char](17) NOT NULL,
	[Numero] [int] NOT NULL,
	[Scadenza] [date] NOT NULL,
	[Data_esecuzione] [date] NULL,
 CONSTRAINT [ID_Revisione_ID] PRIMARY KEY CLUSTERED 
(
	[Veicolo_Numero_telaio] ASC,
	[Numero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ricambio]    Script Date: 11/04/2017 14:57:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ricambio](
	[Codice] [char](5) NOT NULL,
	[Nome] [varchar](25) NOT NULL,
	[Descrizione] [varchar](100) NOT NULL,
	[Prezzo_di_acquisto] [real] NOT NULL,
	[Prezzo_uRiparazione] [real] NOT NULL,
	[Tipo_Ricambio] [char](1) NOT NULL,
	[Fornitore_Partita_IVA] [char](11) NOT NULL,
 CONSTRAINT [ID_Ricambio_ID] PRIMARY KEY CLUSTERED 
(
	[Codice] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Riparazione]    Script Date: 11/04/2017 14:57:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Riparazione](
	[Veicolo_Numero_telaio] [char](17) NOT NULL,
	[Numero] [int] NOT NULL,
	[Data] [date] NOT NULL,
	[Importo_complessivo] [real] NOT NULL,
 CONSTRAINT [ID_Riparazione_ID] PRIMARY KEY CLUSTERED 
(
	[Veicolo_Numero_telaio] ASC,
	[Numero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[supporto]    Script Date: 11/04/2017 14:57:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[supporto](
	[Veicolo_Codice] [char](5) NOT NULL,
	[Optional_Codice] [char](5) NOT NULL,
 CONSTRAINT [ID_supporto_ID] PRIMARY KEY CLUSTERED 
(
	[Veicolo_Codice] ASC,
	[Optional_Codice] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Trasporto]    Script Date: 11/04/2017 14:57:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Trasporto](
	[Codice] [char](5) NOT NULL,
	[Contratto_Numero] [int] NOT NULL,
	[Costo] [real] NOT NULL,
	[Data_consegna_1] [date] NOT NULL,
	[Data_consegna_2] [date] NULL,
	[Indirizzo] [varchar](30) NOT NULL,
	[Citta] [varchar](25) NOT NULL,
	[Provincia] [varchar](25) NOT NULL,
	[CAP] [char](5) NOT NULL,
	[Corriere_Partita_IVA] [char](11) NOT NULL,
 CONSTRAINT [ID_Trasporto_ID] PRIMARY KEY CLUSTERED 
(
	[Codice] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[utilizzo]    Script Date: 11/04/2017 14:57:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[utilizzo](
	[Veicolo_Numero_telaio] [char](17) NOT NULL,
	[Riparazione_Numero] [int] NOT NULL,
	[Ricambio_Codice] [char](5) NOT NULL,
	[quantita] [int] NULL,
 CONSTRAINT [ID_utilizzo_ID] PRIMARY KEY CLUSTERED 
(
	[Veicolo_Numero_telaio] ASC,
	[Riparazione_Numero] ASC,
	[Ricambio_Codice] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Veicolo_in_catalogo]    Script Date: 11/04/2017 14:57:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Veicolo_in_catalogo](
	[Codice] [char](5) NOT NULL,
	[Prezzo_base] [real] NOT NULL,
	[Potenza] [real] NOT NULL,
	[No_posti] [int] NOT NULL,
	[Consumi] [real] NOT NULL,
	[Omologazione] [varchar](10) NOT NULL,
	[Capacita_serbatorio] [real] NOT NULL,
	[Tipo_alimentazione] [varchar](20) NOT NULL,
	[Cilindrata] [real] NOT NULL,
	[Trazione] [varchar](20) NOT NULL,
	[Cambio] [varchar](20) NULL,
	[Capienza_bagagliaio] [real] NOT NULL,
	[No_porte] [int] NOT NULL,
	[Modello_Partita_IVA] [char](11) NOT NULL,
	[Modello_Nome] [varchar](20) NOT NULL,
	[Modello_Anno] [date] NOT NULL,
 CONSTRAINT [ID_Veicolo_in_catalogo_ID] PRIMARY KEY CLUSTERED 
(
	[Codice] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Veicolo_venduto]    Script Date: 11/04/2017 14:57:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Veicolo_venduto](
	[Numero_telaio] [char](17) NOT NULL,
	[Contratto_Numero] [int] NOT NULL,
	[Ordine_ID_ordine] [char](6) NOT NULL,
	[Veicolo_Codice] [char](5) NOT NULL,
 CONSTRAINT [ID_Veicolo_venduto_ID] PRIMARY KEY CLUSTERED 
(
	[Numero_telaio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Cliente] ([PartitaIVA_CodiceFiscale], [Recapito_1], [Recapito_2], [Recapito_3], [Citta], [Indirizzo], [Provincia], [CAP], [Tipo_Cliente], [Ragione_sociale], [Indirizzo_e_mail_1], [Indirizzo_e_mail_2], [Nome], [Cognome], [Data_nascita], [Citta_nascita], [Provincia_nascita]) VALUES (N'vntpla0595 ', N'054483327', N'', N'', N'alfonsine', N'e. morelli 3', N'ravenna', N'48011', N'p', NULL, NULL, NULL, N'paolo', N'venturi', CAST(N'1995-01-05' AS Date), N'lugo', N'ravenna')
INSERT [dbo].[Contratto_di_vendita] ([Numero], [Data], [Importo_complessivo], [Nostre_Mod_Da], [Cliente_PartitaIVA_CodiceFiscale]) VALUES (1, CAST(N'2016-09-08' AS Date), 200050, 10000, N'vntpla0595 ')
INSERT [dbo].[Contratto_di_vendita] ([Numero], [Data], [Importo_complessivo], [Nostre_Mod_Da], [Cliente_PartitaIVA_CodiceFiscale]) VALUES (2, CAST(N'2016-09-08' AS Date), 2000050, 10000, N'vntpla0595 ')
INSERT [dbo].[Contratto_di_vendita] ([Numero], [Data], [Importo_complessivo], [Nostre_Mod_Da], [Cliente_PartitaIVA_CodiceFiscale]) VALUES (3, CAST(N'2016-09-08' AS Date), 90050, 10000, N'vntpla0595 ')
INSERT [dbo].[Contratto_di_vendita] ([Numero], [Data], [Importo_complessivo], [Nostre_Mod_Da], [Cliente_PartitaIVA_CodiceFiscale]) VALUES (4, CAST(N'2016-09-08' AS Date), 20000.5, 10000, N'vntpla0595 ')
INSERT [dbo].[Contratto_di_vendita] ([Numero], [Data], [Importo_complessivo], [Nostre_Mod_Da], [Cliente_PartitaIVA_CodiceFiscale]) VALUES (5, CAST(N'2016-09-08' AS Date), 1E+10, 10000, N'vntpla0595 ')
INSERT [dbo].[Corriere] ([Partita_IVA], [Ragione_sociale], [Citta], [Provincia], [Indirizzo], [CAP], [Recapito_1], [Recapito_2], [Indirizzo_e_mail_1], [Indirizzo_e_mail_2]) VALUES (N'00000      ', N'Primo nel suo genere', N'0', N'0', N'0', N'0    ', N'00', N'0', N'0', N'0')
INSERT [dbo].[Fattura_di_acquisto] ([Fornitore_Partita_IVA], [Numero], [Data], [Importo_complessivo], [Mod_Pagamento_Partita_IVA], [Mod_Pagamento_Da]) VALUES (N'0          ', 1, CAST(N'2016-09-13' AS Date), 12, N'0          ', 1)
INSERT [dbo].[Fattura_di_acquisto] ([Fornitore_Partita_IVA], [Numero], [Data], [Importo_complessivo], [Mod_Pagamento_Partita_IVA], [Mod_Pagamento_Da]) VALUES (N'098765432  ', 1, CAST(N'2016-09-08' AS Date), 1000, N'098765432  ', 0)
INSERT [dbo].[Fattura_di_acquisto] ([Fornitore_Partita_IVA], [Numero], [Data], [Importo_complessivo], [Mod_Pagamento_Partita_IVA], [Mod_Pagamento_Da]) VALUES (N'098765432  ', 2, CAST(N'2016-09-08' AS Date), 100000, N'098765432  ', 0)
INSERT [dbo].[Fattura_di_acquisto] ([Fornitore_Partita_IVA], [Numero], [Data], [Importo_complessivo], [Mod_Pagamento_Partita_IVA], [Mod_Pagamento_Da]) VALUES (N'1          ', 1, CAST(N'2016-09-13' AS Date), 12, N'1          ', 1)
INSERT [dbo].[Fattura_di_acquisto] ([Fornitore_Partita_IVA], [Numero], [Data], [Importo_complessivo], [Mod_Pagamento_Partita_IVA], [Mod_Pagamento_Da]) VALUES (N'10         ', 1, CAST(N'2016-09-13' AS Date), 122, N'10         ', 10)
INSERT [dbo].[Fornitore] ([Partita_IVA], [Ragione_Sociale], [Recapito_1], [Recapito_2], [Recapito_3], [Indirizzo_e_mail_1], [Indirizzo_e_mail_2], [Tipo_Ricambi], [Tipo_CasaProduttrice], [Citta], [Provincia], [Indirizzo], [CAP]) VALUES (N'           ', N'', N'', N'', N'', N'', N'', N' ', N' ', N'', N'', N'', N'    ')
INSERT [dbo].[Fornitore] ([Partita_IVA], [Ragione_Sociale], [Recapito_1], [Recapito_2], [Recapito_3], [Indirizzo_e_mail_1], [Indirizzo_e_mail_2], [Tipo_Ricambi], [Tipo_CasaProduttrice], [Citta], [Provincia], [Indirizzo], [CAP]) VALUES (N'0          ', N'0', N'0', N'0', N'0', N'0', NULL, N' ', N' ', N'0', N'0', N'0', N'0   ')
INSERT [dbo].[Fornitore] ([Partita_IVA], [Ragione_Sociale], [Recapito_1], [Recapito_2], [Recapito_3], [Indirizzo_e_mail_1], [Indirizzo_e_mail_2], [Tipo_Ricambi], [Tipo_CasaProduttrice], [Citta], [Provincia], [Indirizzo], [CAP]) VALUES (N'0123456    ', N'pincopallo', N'', N'', N'', N'', N'', N' ', N' ', N'', N'', N'', N'    ')
INSERT [dbo].[Fornitore] ([Partita_IVA], [Ragione_Sociale], [Recapito_1], [Recapito_2], [Recapito_3], [Indirizzo_e_mail_1], [Indirizzo_e_mail_2], [Tipo_Ricambi], [Tipo_CasaProduttrice], [Citta], [Provincia], [Indirizzo], [CAP]) VALUES (N'098765432  ', N'0', N'0', N'0', N'0', N'0', N'0', N' ', N' ', N'0', N'0', N'0', N'0   ')
INSERT [dbo].[Fornitore] ([Partita_IVA], [Ragione_Sociale], [Recapito_1], [Recapito_2], [Recapito_3], [Indirizzo_e_mail_1], [Indirizzo_e_mail_2], [Tipo_Ricambi], [Tipo_CasaProduttrice], [Citta], [Provincia], [Indirizzo], [CAP]) VALUES (N'1          ', N'1', N'1', N'1', N'1', N'Q', NULL, N' ', N'r', N'1', N'1', N'1', N'1   ')
INSERT [dbo].[Fornitore] ([Partita_IVA], [Ragione_Sociale], [Recapito_1], [Recapito_2], [Recapito_3], [Indirizzo_e_mail_1], [Indirizzo_e_mail_2], [Tipo_Ricambi], [Tipo_CasaProduttrice], [Citta], [Provincia], [Indirizzo], [CAP]) VALUES (N'10         ', N'0', N'0', N'0', N'0', N'0', N'0', N'r', N'v', N'0', N'0', N'0', N'0   ')
INSERT [dbo].[Fornitore] ([Partita_IVA], [Ragione_Sociale], [Recapito_1], [Recapito_2], [Recapito_3], [Indirizzo_e_mail_1], [Indirizzo_e_mail_2], [Tipo_Ricambi], [Tipo_CasaProduttrice], [Citta], [Provincia], [Indirizzo], [CAP]) VALUES (N'111111     ', N'GIANOTTI', N'0', N'0', N'0', N'0', N'0', N' ', N' ', N'0', N'0', N'0', N'0   ')
INSERT [dbo].[Fornitore] ([Partita_IVA], [Ragione_Sociale], [Recapito_1], [Recapito_2], [Recapito_3], [Indirizzo_e_mail_1], [Indirizzo_e_mail_2], [Tipo_Ricambi], [Tipo_CasaProduttrice], [Citta], [Provincia], [Indirizzo], [CAP]) VALUES (N'112        ', N'0', N'0', N'0', N'0', N'0', N'0', N' ', N' ', N'0', N'0', N'0', N'0   ')
INSERT [dbo].[Fornitore] ([Partita_IVA], [Ragione_Sociale], [Recapito_1], [Recapito_2], [Recapito_3], [Indirizzo_e_mail_1], [Indirizzo_e_mail_2], [Tipo_Ricambi], [Tipo_CasaProduttrice], [Citta], [Provincia], [Indirizzo], [CAP]) VALUES (N'3          ', N'7', N'7', N'7', N'7', N'7', N'7', N' ', N'v', N'7', N'7', N'7', N'7   ')
INSERT [dbo].[Fornitore] ([Partita_IVA], [Ragione_Sociale], [Recapito_1], [Recapito_2], [Recapito_3], [Indirizzo_e_mail_1], [Indirizzo_e_mail_2], [Tipo_Ricambi], [Tipo_CasaProduttrice], [Citta], [Provincia], [Indirizzo], [CAP]) VALUES (N'5          ', N'5', N'5', N'5', N'5', N'5', N'5', N' ', N' ', N'5', N'5', N'5', N'5   ')
INSERT [dbo].[Fornitore] ([Partita_IVA], [Ragione_Sociale], [Recapito_1], [Recapito_2], [Recapito_3], [Indirizzo_e_mail_1], [Indirizzo_e_mail_2], [Tipo_Ricambi], [Tipo_CasaProduttrice], [Citta], [Provincia], [Indirizzo], [CAP]) VALUES (N'8          ', N'8', N'8', N'8', N'8', N'8', N'8', N'r', N'v', N'8', N'8', N'8', N'8   ')
INSERT [dbo].[Fornitore] ([Partita_IVA], [Ragione_Sociale], [Recapito_1], [Recapito_2], [Recapito_3], [Indirizzo_e_mail_1], [Indirizzo_e_mail_2], [Tipo_Ricambi], [Tipo_CasaProduttrice], [Citta], [Provincia], [Indirizzo], [CAP]) VALUES (N'8481498    ', N'i', N'i', N'i', N'i', N'i', N'i', N' ', N' ', N'i', N'i', N'i', N'i   ')
INSERT [dbo].[Fornitore] ([Partita_IVA], [Ragione_Sociale], [Recapito_1], [Recapito_2], [Recapito_3], [Indirizzo_e_mail_1], [Indirizzo_e_mail_2], [Tipo_Ricambi], [Tipo_CasaProduttrice], [Citta], [Provincia], [Indirizzo], [CAP]) VALUES (N'9          ', N'9', N'9', N'9', N'9', N'9', N'9', N'r', N'v', N'9', N'9', N'9', N'9   ')
INSERT [dbo].[Fornitore] ([Partita_IVA], [Ragione_Sociale], [Recapito_1], [Recapito_2], [Recapito_3], [Indirizzo_e_mail_1], [Indirizzo_e_mail_2], [Tipo_Ricambi], [Tipo_CasaProduttrice], [Citta], [Provincia], [Indirizzo], [CAP]) VALUES (N'pincopallo ', N'o', N'o', N'o', N'o', N'o', N'o', N'r', N'r', N'o', N'o', N'o', N'o   ')
INSERT [dbo].[Fornitore] ([Partita_IVA], [Ragione_Sociale], [Recapito_1], [Recapito_2], [Recapito_3], [Indirizzo_e_mail_1], [Indirizzo_e_mail_2], [Tipo_Ricambi], [Tipo_CasaProduttrice], [Citta], [Provincia], [Indirizzo], [CAP]) VALUES (N't          ', N't', N't', N't', N't', N't', NULL, N' ', N'r', N't', N't', N't', N't   ')
INSERT [dbo].[Modalita_di_pagamento] ([Fornitore_Partita_IVA], [Da], [A], [Periodicita], [Tasso_interesse], [Numero_rate]) VALUES (N'0          ', 1, 2, N'Bimestrali', 1, 1)
INSERT [dbo].[Modalita_di_pagamento] ([Fornitore_Partita_IVA], [Da], [A], [Periodicita], [Tasso_interesse], [Numero_rate]) VALUES (N'098765432  ', 0, 10000, N'Mensili', 4, 5)
INSERT [dbo].[Modalita_di_pagamento] ([Fornitore_Partita_IVA], [Da], [A], [Periodicita], [Tasso_interesse], [Numero_rate]) VALUES (N'1          ', 1, 1, N'Mensili', 1, 1)
INSERT [dbo].[Modalita_di_pagamento] ([Fornitore_Partita_IVA], [Da], [A], [Periodicita], [Tasso_interesse], [Numero_rate]) VALUES (N'10         ', 10, 100, N'Mensili', 1, 1)
INSERT [dbo].[Modello_veicolo] ([Nome], [Anno], [Fornitore_Partita_IVA]) VALUES (N'agila', CAST(N'2016-09-12' AS Date), N'0          ')
INSERT [dbo].[Modello_veicolo] ([Nome], [Anno], [Fornitore_Partita_IVA]) VALUES (N'punto', CAST(N'2016-09-12' AS Date), N'8          ')
INSERT [dbo].[Nostre_modalita_di_pagamento] ([Da], [A], [Periodicita], [Tasso_interesse], [Numero_rate]) VALUES (10000, 50000, N'Bimestrali', 2, 10)
INSERT [dbo].[Optional] ([Codice], [Nome], [Descrizione], [Prezzo]) VALUES (N'1    ', N'primo', N'e', 4)
INSERT [dbo].[Optional] ([Codice], [Nome], [Descrizione], [Prezzo]) VALUES (N'2    ', N'secondo', N'0', 0)
INSERT [dbo].[Ordine] ([ID_ordine], [Fattura_Partita_IVA], [Numero], [Data_ordine], [Data_spedizione], [Data_consegna_1], [Data_consegna_2], [Tipo_Ordine]) VALUES (N'1     ', N'098765432  ', 1, CAST(N'2016-09-12' AS Date), CAST(N'2016-09-12' AS Date), CAST(N'2016-09-12' AS Date), CAST(N'2016-09-13' AS Date), N'v')
INSERT [dbo].[Ordine] ([ID_ordine], [Fattura_Partita_IVA], [Numero], [Data_ordine], [Data_spedizione], [Data_consegna_1], [Data_consegna_2], [Tipo_Ordine]) VALUES (N'12    ', N'10         ', 1, CAST(N'2016-09-13' AS Date), CAST(N'2016-09-13' AS Date), CAST(N'2016-09-13' AS Date), NULL, N'v')
INSERT [dbo].[Ordine] ([ID_ordine], [Fattura_Partita_IVA], [Numero], [Data_ordine], [Data_spedizione], [Data_consegna_1], [Data_consegna_2], [Tipo_Ordine]) VALUES (N'2     ', N'098765432  ', 2, CAST(N'2016-09-12' AS Date), CAST(N'2016-09-12' AS Date), CAST(N'2016-09-12' AS Date), NULL, N'r')
INSERT [dbo].[Ordine] ([ID_ordine], [Fattura_Partita_IVA], [Numero], [Data_ordine], [Data_spedizione], [Data_consegna_1], [Data_consegna_2], [Tipo_Ordine]) VALUES (N'4     ', N'1          ', 1, CAST(N'2016-09-14' AS Date), CAST(N'2016-09-14' AS Date), CAST(N'2016-09-14' AS Date), NULL, N'r')
INSERT [dbo].[Pagamento_cAcquisto] ([Fattura_Partita_IVA], [Fattura_Numero], [Data], [Importo]) VALUES (N'098765432  ', 1, CAST(N'2016-09-08' AS Date), 100)
INSERT [dbo].[Pagamento_cAcquisto] ([Fattura_Partita_IVA], [Fattura_Numero], [Data], [Importo]) VALUES (N'098765432  ', 1, CAST(N'2016-09-13' AS Date), 1)
INSERT [dbo].[Pagamento_cAcquisto] ([Fattura_Partita_IVA], [Fattura_Numero], [Data], [Importo]) VALUES (N'098765432  ', 2, CAST(N'2016-09-08' AS Date), 1000)
INSERT [dbo].[Pagamento_cVendita] ([Contratto_Numero], [Data], [Importo]) VALUES (1, CAST(N'2016-09-08' AS Date), 1200)
INSERT [dbo].[per2] ([Veicolo_Codice], [Ordine_ID_ordine], [quantita]) VALUES (N'1    ', N'1     ', 2)
INSERT [dbo].[per2] ([Veicolo_Codice], [Ordine_ID_ordine], [quantita]) VALUES (N'2    ', N'1     ', 1)
INSERT [dbo].[per2] ([Veicolo_Codice], [Ordine_ID_ordine], [quantita]) VALUES (N'2    ', N'12    ', 1)
INSERT [dbo].[possesso] ([Veicolo_Numero_telaio], [Optional_Codice]) VALUES (N'123456           ', N'1    ')
INSERT [dbo].[possesso] ([Veicolo_Numero_telaio], [Optional_Codice]) VALUES (N'2                ', N'1    ')
INSERT [dbo].[referenza2] ([Veicolo_Codice], [Ricambio_Codice]) VALUES (N'1    ', N'1    ')
INSERT [dbo].[referenza2] ([Veicolo_Codice], [Ricambio_Codice]) VALUES (N'2    ', N'2    ')
INSERT [dbo].[Revisione] ([Veicolo_Numero_telaio], [Numero], [Scadenza], [Data_esecuzione]) VALUES (N'0987             ', 1, CAST(N'0001-01-01' AS Date), CAST(N'2016-09-13' AS Date))
INSERT [dbo].[Revisione] ([Veicolo_Numero_telaio], [Numero], [Scadenza], [Data_esecuzione]) VALUES (N'0987             ', 2, CAST(N'0001-01-01' AS Date), CAST(N'2016-09-13' AS Date))
INSERT [dbo].[Revisione] ([Veicolo_Numero_telaio], [Numero], [Scadenza], [Data_esecuzione]) VALUES (N'123456           ', 1, CAST(N'2016-09-14' AS Date), CAST(N'2016-09-14' AS Date))
INSERT [dbo].[Ricambio] ([Codice], [Nome], [Descrizione], [Prezzo_di_acquisto], [Prezzo_uRiparazione], [Tipo_Ricambio], [Fornitore_Partita_IVA]) VALUES (N'1    ', N'1', N'ciao
', 1, 1, N'g', N'1          ')
INSERT [dbo].[Ricambio] ([Codice], [Nome], [Descrizione], [Prezzo_di_acquisto], [Prezzo_uRiparazione], [Tipo_Ricambio], [Fornitore_Partita_IVA]) VALUES (N'2    ', N'secondo', N'mondo', 9, 9, N'g', N'pincopallo ')
INSERT [dbo].[Riparazione] ([Veicolo_Numero_telaio], [Numero], [Data], [Importo_complessivo]) VALUES (N'0987             ', 1, CAST(N'2016-09-14' AS Date), 12)
INSERT [dbo].[Riparazione] ([Veicolo_Numero_telaio], [Numero], [Data], [Importo_complessivo]) VALUES (N'0987             ', 2, CAST(N'2016-09-14' AS Date), 2)
INSERT [dbo].[Riparazione] ([Veicolo_Numero_telaio], [Numero], [Data], [Importo_complessivo]) VALUES (N'123456           ', 1, CAST(N'2016-09-14' AS Date), 12)
INSERT [dbo].[supporto] ([Veicolo_Codice], [Optional_Codice]) VALUES (N'1    ', N'1    ')
INSERT [dbo].[supporto] ([Veicolo_Codice], [Optional_Codice]) VALUES (N'2    ', N'1    ')
INSERT [dbo].[supporto] ([Veicolo_Codice], [Optional_Codice]) VALUES (N'2    ', N'2    ')
INSERT [dbo].[utilizzo] ([Veicolo_Numero_telaio], [Riparazione_Numero], [Ricambio_Codice], [quantita]) VALUES (N'123456           ', 1, N'1    ', 2)
INSERT [dbo].[Veicolo_in_catalogo] ([Codice], [Prezzo_base], [Potenza], [No_posti], [Consumi], [Omologazione], [Capacita_serbatorio], [Tipo_alimentazione], [Cilindrata], [Trazione], [Cambio], [Capienza_bagagliaio], [No_porte], [Modello_Partita_IVA], [Modello_Nome], [Modello_Anno]) VALUES (N'1    ', 9, 9, 9, 9, N'9', 9, N'9', 9, N'9', N'9', 9, 9, N'0          ', N'agila', CAST(N'2016-09-12' AS Date))
INSERT [dbo].[Veicolo_in_catalogo] ([Codice], [Prezzo_base], [Potenza], [No_posti], [Consumi], [Omologazione], [Capacita_serbatorio], [Tipo_alimentazione], [Cilindrata], [Trazione], [Cambio], [Capienza_bagagliaio], [No_porte], [Modello_Partita_IVA], [Modello_Nome], [Modello_Anno]) VALUES (N'2    ', 9, 9, 9, 9, N'9', 9, N'9', 9, N'9', N'9', 9, 9, N'0          ', N'agila', CAST(N'2016-09-12' AS Date))
INSERT [dbo].[Veicolo_in_catalogo] ([Codice], [Prezzo_base], [Potenza], [No_posti], [Consumi], [Omologazione], [Capacita_serbatorio], [Tipo_alimentazione], [Cilindrata], [Trazione], [Cambio], [Capienza_bagagliaio], [No_porte], [Modello_Partita_IVA], [Modello_Nome], [Modello_Anno]) VALUES (N'4    ', 9, 9, 9, 9, N'9', 9, N'9', 9, N'9', N'9', 9, 9, N'8          ', N'punto', CAST(N'2016-09-12' AS Date))
INSERT [dbo].[Veicolo_venduto] ([Numero_telaio], [Contratto_Numero], [Ordine_ID_ordine], [Veicolo_Codice]) VALUES (N'0987             ', 1, N'1     ', N'2    ')
INSERT [dbo].[Veicolo_venduto] ([Numero_telaio], [Contratto_Numero], [Ordine_ID_ordine], [Veicolo_Codice]) VALUES (N'123456           ', 1, N'1     ', N'1    ')
INSERT [dbo].[Veicolo_venduto] ([Numero_telaio], [Contratto_Numero], [Ordine_ID_ordine], [Veicolo_Codice]) VALUES (N'2                ', 1, N'1     ', N'1    ')
SET ANSI_PADDING ON

GO
/****** Object:  Index [ID_Cliente_IND]    Script Date: 11/04/2017 14:57:51 ******/
CREATE UNIQUE NONCLUSTERED INDEX [ID_Cliente_IND] ON [dbo].[Cliente]
(
	[PartitaIVA_CodiceFiscale] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [EQU_Contr_Clien_IND]    Script Date: 11/04/2017 14:57:51 ******/
CREATE NONCLUSTERED INDEX [EQU_Contr_Clien_IND] ON [dbo].[Contratto_di_vendita]
(
	[Cliente_PartitaIVA_CodiceFiscale] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [ID_Contratto_di_vendita_IND]    Script Date: 11/04/2017 14:57:51 ******/
CREATE UNIQUE NONCLUSTERED INDEX [ID_Contratto_di_vendita_IND] ON [dbo].[Contratto_di_vendita]
(
	[Numero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [REF_Contr_Nostr_IND]    Script Date: 11/04/2017 14:57:51 ******/
CREATE NONCLUSTERED INDEX [REF_Contr_Nostr_IND] ON [dbo].[Contratto_di_vendita]
(
	[Nostre_Mod_Da] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [ID_Corriere_IND]    Script Date: 11/04/2017 14:57:51 ******/
CREATE UNIQUE NONCLUSTERED INDEX [ID_Corriere_IND] ON [dbo].[Corriere]
(
	[Partita_IVA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [ID_di_IND]    Script Date: 11/04/2017 14:57:51 ******/
CREATE UNIQUE NONCLUSTERED INDEX [ID_di_IND] ON [dbo].[di]
(
	[Ordine_ID_ordine] ASC,
	[Ricambio_Codice] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [REF_di_Ricam_IND]    Script Date: 11/04/2017 14:57:51 ******/
CREATE NONCLUSTERED INDEX [REF_di_Ricam_IND] ON [dbo].[di]
(
	[Ricambio_Codice] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [ID_Fattura_di_acquisto_IND]    Script Date: 11/04/2017 14:57:51 ******/
CREATE UNIQUE NONCLUSTERED INDEX [ID_Fattura_di_acquisto_IND] ON [dbo].[Fattura_di_acquisto]
(
	[Fornitore_Partita_IVA] ASC,
	[Numero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [REF_Fattu_Modal_IND]    Script Date: 11/04/2017 14:57:51 ******/
CREATE NONCLUSTERED INDEX [REF_Fattu_Modal_IND] ON [dbo].[Fattura_di_acquisto]
(
	[Mod_Pagamento_Partita_IVA] ASC,
	[Mod_Pagamento_Da] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [ID_Fornitore_IND]    Script Date: 11/04/2017 14:57:51 ******/
CREATE UNIQUE NONCLUSTERED INDEX [ID_Fornitore_IND] ON [dbo].[Fornitore]
(
	[Partita_IVA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [ID_Giacenza_IND]    Script Date: 11/04/2017 14:57:51 ******/
CREATE UNIQUE NONCLUSTERED INDEX [ID_Giacenza_IND] ON [dbo].[Giacenza]
(
	[Ricambio_Codice] ASC,
	[Numero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [ID_Modalita_di_pagamento_IND]    Script Date: 11/04/2017 14:57:51 ******/
CREATE UNIQUE NONCLUSTERED INDEX [ID_Modalita_di_pagamento_IND] ON [dbo].[Modalita_di_pagamento]
(
	[Fornitore_Partita_IVA] ASC,
	[Da] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [ID_Modello_veicolo_IND]    Script Date: 11/04/2017 14:57:51 ******/
CREATE UNIQUE NONCLUSTERED INDEX [ID_Modello_veicolo_IND] ON [dbo].[Modello_veicolo]
(
	[Fornitore_Partita_IVA] ASC,
	[Nome] ASC,
	[Anno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [ID_Nostre_modalita_di_pagamento_IND]    Script Date: 11/04/2017 14:57:51 ******/
CREATE UNIQUE NONCLUSTERED INDEX [ID_Nostre_modalita_di_pagamento_IND] ON [dbo].[Nostre_modalita_di_pagamento]
(
	[Da] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [ID_Optional_IND]    Script Date: 11/04/2017 14:57:51 ******/
CREATE UNIQUE NONCLUSTERED INDEX [ID_Optional_IND] ON [dbo].[Optional]
(
	[Codice] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [SID_Ordin_Fattu_ID]    Script Date: 11/04/2017 14:57:51 ******/
ALTER TABLE [dbo].[Ordine] ADD  CONSTRAINT [SID_Ordin_Fattu_ID] UNIQUE NONCLUSTERED 
(
	[Fattura_Partita_IVA] ASC,
	[Numero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [ID_Ordine_IND]    Script Date: 11/04/2017 14:57:51 ******/
CREATE UNIQUE NONCLUSTERED INDEX [ID_Ordine_IND] ON [dbo].[Ordine]
(
	[ID_ordine] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [SID_Ordin_Fattu_IND]    Script Date: 11/04/2017 14:57:51 ******/
CREATE UNIQUE NONCLUSTERED INDEX [SID_Ordin_Fattu_IND] ON [dbo].[Ordine]
(
	[Fattura_Partita_IVA] ASC,
	[Numero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [ID_Pagamento_cAcquisto_IND]    Script Date: 11/04/2017 14:57:51 ******/
CREATE UNIQUE NONCLUSTERED INDEX [ID_Pagamento_cAcquisto_IND] ON [dbo].[Pagamento_cAcquisto]
(
	[Fattura_Partita_IVA] ASC,
	[Fattura_Numero] ASC,
	[Data] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [ID_Pagamento_cVendita_IND]    Script Date: 11/04/2017 14:57:51 ******/
CREATE UNIQUE NONCLUSTERED INDEX [ID_Pagamento_cVendita_IND] ON [dbo].[Pagamento_cVendita]
(
	[Contratto_Numero] ASC,
	[Data] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [EQU_per2_Ordin_IND]    Script Date: 11/04/2017 14:57:51 ******/
CREATE NONCLUSTERED INDEX [EQU_per2_Ordin_IND] ON [dbo].[per2]
(
	[Ordine_ID_ordine] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [ID_per2_IND]    Script Date: 11/04/2017 14:57:51 ******/
CREATE UNIQUE NONCLUSTERED INDEX [ID_per2_IND] ON [dbo].[per2]
(
	[Veicolo_Codice] ASC,
	[Ordine_ID_ordine] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [ID_possesso_IND]    Script Date: 11/04/2017 14:57:51 ******/
CREATE UNIQUE NONCLUSTERED INDEX [ID_possesso_IND] ON [dbo].[possesso]
(
	[Veicolo_Numero_telaio] ASC,
	[Optional_Codice] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [REF_posse_Optio_IND]    Script Date: 11/04/2017 14:57:51 ******/
CREATE NONCLUSTERED INDEX [REF_posse_Optio_IND] ON [dbo].[possesso]
(
	[Optional_Codice] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [EQU_refer_Ricam_IND]    Script Date: 11/04/2017 14:57:51 ******/
CREATE NONCLUSTERED INDEX [EQU_refer_Ricam_IND] ON [dbo].[referenza2]
(
	[Ricambio_Codice] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [ID_referenza2_IND]    Script Date: 11/04/2017 14:57:51 ******/
CREATE UNIQUE NONCLUSTERED INDEX [ID_referenza2_IND] ON [dbo].[referenza2]
(
	[Veicolo_Codice] ASC,
	[Ricambio_Codice] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [ID_Revisione_IND]    Script Date: 11/04/2017 14:57:51 ******/
CREATE UNIQUE NONCLUSTERED INDEX [ID_Revisione_IND] ON [dbo].[Revisione]
(
	[Veicolo_Numero_telaio] ASC,
	[Numero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [EQU_Ricam_Forni_IND]    Script Date: 11/04/2017 14:57:51 ******/
CREATE NONCLUSTERED INDEX [EQU_Ricam_Forni_IND] ON [dbo].[Ricambio]
(
	[Fornitore_Partita_IVA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [ID_Ricambio_IND]    Script Date: 11/04/2017 14:57:51 ******/
CREATE UNIQUE NONCLUSTERED INDEX [ID_Ricambio_IND] ON [dbo].[Ricambio]
(
	[Codice] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [ID_Riparazione_IND]    Script Date: 11/04/2017 14:57:51 ******/
CREATE UNIQUE NONCLUSTERED INDEX [ID_Riparazione_IND] ON [dbo].[Riparazione]
(
	[Veicolo_Numero_telaio] ASC,
	[Numero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [ID_supporto_IND]    Script Date: 11/04/2017 14:57:51 ******/
CREATE UNIQUE NONCLUSTERED INDEX [ID_supporto_IND] ON [dbo].[supporto]
(
	[Veicolo_Codice] ASC,
	[Optional_Codice] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [REF_suppo_Optio_IND]    Script Date: 11/04/2017 14:57:51 ******/
CREATE NONCLUSTERED INDEX [REF_suppo_Optio_IND] ON [dbo].[supporto]
(
	[Optional_Codice] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [SID_Trasp_Contr_ID]    Script Date: 11/04/2017 14:57:51 ******/
ALTER TABLE [dbo].[Trasporto] ADD  CONSTRAINT [SID_Trasp_Contr_ID] UNIQUE NONCLUSTERED 
(
	[Contratto_Numero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [ID_Trasporto_IND]    Script Date: 11/04/2017 14:57:51 ******/
CREATE UNIQUE NONCLUSTERED INDEX [ID_Trasporto_IND] ON [dbo].[Trasporto]
(
	[Codice] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [REF_Trasp_Corri_IND]    Script Date: 11/04/2017 14:57:51 ******/
CREATE NONCLUSTERED INDEX [REF_Trasp_Corri_IND] ON [dbo].[Trasporto]
(
	[Corriere_Partita_IVA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [SID_Trasp_Contr_IND]    Script Date: 11/04/2017 14:57:51 ******/
CREATE UNIQUE NONCLUSTERED INDEX [SID_Trasp_Contr_IND] ON [dbo].[Trasporto]
(
	[Contratto_Numero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [ID_utilizzo_IND]    Script Date: 11/04/2017 14:57:51 ******/
CREATE UNIQUE NONCLUSTERED INDEX [ID_utilizzo_IND] ON [dbo].[utilizzo]
(
	[Veicolo_Numero_telaio] ASC,
	[Riparazione_Numero] ASC,
	[Ricambio_Codice] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [REF_utili_Ricam_IND]    Script Date: 11/04/2017 14:57:51 ******/
CREATE NONCLUSTERED INDEX [REF_utili_Ricam_IND] ON [dbo].[utilizzo]
(
	[Ricambio_Codice] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [EQU_Veico_Model_IND]    Script Date: 11/04/2017 14:57:51 ******/
CREATE NONCLUSTERED INDEX [EQU_Veico_Model_IND] ON [dbo].[Veicolo_in_catalogo]
(
	[Modello_Partita_IVA] ASC,
	[Modello_Nome] ASC,
	[Modello_Anno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [ID_Veicolo_in_catalogo_IND]    Script Date: 11/04/2017 14:57:51 ******/
CREATE UNIQUE NONCLUSTERED INDEX [ID_Veicolo_in_catalogo_IND] ON [dbo].[Veicolo_in_catalogo]
(
	[Codice] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [EQU_Veico_Contr_IND]    Script Date: 11/04/2017 14:57:51 ******/
CREATE NONCLUSTERED INDEX [EQU_Veico_Contr_IND] ON [dbo].[Veicolo_venduto]
(
	[Contratto_Numero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [EQU_Veico_Ordin_IND]    Script Date: 11/04/2017 14:57:51 ******/
CREATE NONCLUSTERED INDEX [EQU_Veico_Ordin_IND] ON [dbo].[Veicolo_venduto]
(
	[Ordine_ID_ordine] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [ID_Veicolo_venduto_IND]    Script Date: 11/04/2017 14:57:51 ******/
CREATE UNIQUE NONCLUSTERED INDEX [ID_Veicolo_venduto_IND] ON [dbo].[Veicolo_venduto]
(
	[Numero_telaio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [REF_Veico_Veico_IND]    Script Date: 11/04/2017 14:57:51 ******/
CREATE NONCLUSTERED INDEX [REF_Veico_Veico_IND] ON [dbo].[Veicolo_venduto]
(
	[Veicolo_Codice] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Contratto_di_vendita]  WITH CHECK ADD  CONSTRAINT [EQU_Contr_Clien_FK] FOREIGN KEY([Cliente_PartitaIVA_CodiceFiscale])
REFERENCES [dbo].[Cliente] ([PartitaIVA_CodiceFiscale])
GO
ALTER TABLE [dbo].[Contratto_di_vendita] CHECK CONSTRAINT [EQU_Contr_Clien_FK]
GO
ALTER TABLE [dbo].[Contratto_di_vendita]  WITH CHECK ADD  CONSTRAINT [REF_Contr_Nostr_FK] FOREIGN KEY([Nostre_Mod_Da])
REFERENCES [dbo].[Nostre_modalita_di_pagamento] ([Da])
GO
ALTER TABLE [dbo].[Contratto_di_vendita] CHECK CONSTRAINT [REF_Contr_Nostr_FK]
GO
ALTER TABLE [dbo].[di]  WITH CHECK ADD  CONSTRAINT [EQU_di_Ordin] FOREIGN KEY([Ordine_ID_ordine])
REFERENCES [dbo].[Ordine] ([ID_ordine])
GO
ALTER TABLE [dbo].[di] CHECK CONSTRAINT [EQU_di_Ordin]
GO
ALTER TABLE [dbo].[di]  WITH CHECK ADD  CONSTRAINT [REF_di_Ricam_FK] FOREIGN KEY([Ricambio_Codice])
REFERENCES [dbo].[Ricambio] ([Codice])
GO
ALTER TABLE [dbo].[di] CHECK CONSTRAINT [REF_di_Ricam_FK]
GO
ALTER TABLE [dbo].[Fattura_di_acquisto]  WITH CHECK ADD  CONSTRAINT [REF_Fattu_Forni] FOREIGN KEY([Fornitore_Partita_IVA])
REFERENCES [dbo].[Fornitore] ([Partita_IVA])
GO
ALTER TABLE [dbo].[Fattura_di_acquisto] CHECK CONSTRAINT [REF_Fattu_Forni]
GO
ALTER TABLE [dbo].[Fattura_di_acquisto]  WITH CHECK ADD  CONSTRAINT [REF_Fattu_Modal_FK] FOREIGN KEY([Mod_Pagamento_Partita_IVA], [Mod_Pagamento_Da])
REFERENCES [dbo].[Modalita_di_pagamento] ([Fornitore_Partita_IVA], [Da])
GO
ALTER TABLE [dbo].[Fattura_di_acquisto] CHECK CONSTRAINT [REF_Fattu_Modal_FK]
GO
ALTER TABLE [dbo].[Giacenza]  WITH CHECK ADD  CONSTRAINT [EQU_Giace_Ricam] FOREIGN KEY([Ricambio_Codice])
REFERENCES [dbo].[Ricambio] ([Codice])
GO
ALTER TABLE [dbo].[Giacenza] CHECK CONSTRAINT [EQU_Giace_Ricam]
GO
ALTER TABLE [dbo].[Modalita_di_pagamento]  WITH CHECK ADD  CONSTRAINT [EQU_Modal_Forni] FOREIGN KEY([Fornitore_Partita_IVA])
REFERENCES [dbo].[Fornitore] ([Partita_IVA])
GO
ALTER TABLE [dbo].[Modalita_di_pagamento] CHECK CONSTRAINT [EQU_Modal_Forni]
GO
ALTER TABLE [dbo].[Modello_veicolo]  WITH CHECK ADD  CONSTRAINT [EQU_Model_Forni] FOREIGN KEY([Fornitore_Partita_IVA])
REFERENCES [dbo].[Fornitore] ([Partita_IVA])
GO
ALTER TABLE [dbo].[Modello_veicolo] CHECK CONSTRAINT [EQU_Model_Forni]
GO
ALTER TABLE [dbo].[Ordine]  WITH CHECK ADD  CONSTRAINT [SID_Ordin_Fattu_FK] FOREIGN KEY([Fattura_Partita_IVA], [Numero])
REFERENCES [dbo].[Fattura_di_acquisto] ([Fornitore_Partita_IVA], [Numero])
GO
ALTER TABLE [dbo].[Ordine] CHECK CONSTRAINT [SID_Ordin_Fattu_FK]
GO
ALTER TABLE [dbo].[Pagamento_cAcquisto]  WITH CHECK ADD  CONSTRAINT [EQU_Pagam_Fattu] FOREIGN KEY([Fattura_Partita_IVA], [Fattura_Numero])
REFERENCES [dbo].[Fattura_di_acquisto] ([Fornitore_Partita_IVA], [Numero])
GO
ALTER TABLE [dbo].[Pagamento_cAcquisto] CHECK CONSTRAINT [EQU_Pagam_Fattu]
GO
ALTER TABLE [dbo].[Pagamento_cVendita]  WITH CHECK ADD  CONSTRAINT [EQU_Pagam_Contr] FOREIGN KEY([Contratto_Numero])
REFERENCES [dbo].[Contratto_di_vendita] ([Numero])
GO
ALTER TABLE [dbo].[Pagamento_cVendita] CHECK CONSTRAINT [EQU_Pagam_Contr]
GO
ALTER TABLE [dbo].[per2]  WITH CHECK ADD  CONSTRAINT [EQU_per2_Ordin_FK] FOREIGN KEY([Ordine_ID_ordine])
REFERENCES [dbo].[Ordine] ([ID_ordine])
GO
ALTER TABLE [dbo].[per2] CHECK CONSTRAINT [EQU_per2_Ordin_FK]
GO
ALTER TABLE [dbo].[per2]  WITH CHECK ADD  CONSTRAINT [REF_per2_Veico] FOREIGN KEY([Veicolo_Codice])
REFERENCES [dbo].[Veicolo_in_catalogo] ([Codice])
GO
ALTER TABLE [dbo].[per2] CHECK CONSTRAINT [REF_per2_Veico]
GO
ALTER TABLE [dbo].[possesso]  WITH CHECK ADD  CONSTRAINT [REF_posse_Optio_FK] FOREIGN KEY([Optional_Codice])
REFERENCES [dbo].[Optional] ([Codice])
GO
ALTER TABLE [dbo].[possesso] CHECK CONSTRAINT [REF_posse_Optio_FK]
GO
ALTER TABLE [dbo].[possesso]  WITH CHECK ADD  CONSTRAINT [REF_posse_Veico] FOREIGN KEY([Veicolo_Numero_telaio])
REFERENCES [dbo].[Veicolo_venduto] ([Numero_telaio])
GO
ALTER TABLE [dbo].[possesso] CHECK CONSTRAINT [REF_posse_Veico]
GO
ALTER TABLE [dbo].[referenza2]  WITH CHECK ADD  CONSTRAINT [EQU_refer_Ricam_FK] FOREIGN KEY([Ricambio_Codice])
REFERENCES [dbo].[Ricambio] ([Codice])
GO
ALTER TABLE [dbo].[referenza2] CHECK CONSTRAINT [EQU_refer_Ricam_FK]
GO
ALTER TABLE [dbo].[referenza2]  WITH CHECK ADD  CONSTRAINT [EQU_refer_Veico] FOREIGN KEY([Veicolo_Codice])
REFERENCES [dbo].[Veicolo_in_catalogo] ([Codice])
GO
ALTER TABLE [dbo].[referenza2] CHECK CONSTRAINT [EQU_refer_Veico]
GO
ALTER TABLE [dbo].[Revisione]  WITH CHECK ADD  CONSTRAINT [REF_Revis_Veico] FOREIGN KEY([Veicolo_Numero_telaio])
REFERENCES [dbo].[Veicolo_venduto] ([Numero_telaio])
GO
ALTER TABLE [dbo].[Revisione] CHECK CONSTRAINT [REF_Revis_Veico]
GO
ALTER TABLE [dbo].[Ricambio]  WITH CHECK ADD  CONSTRAINT [EQU_Ricam_Forni_FK] FOREIGN KEY([Fornitore_Partita_IVA])
REFERENCES [dbo].[Fornitore] ([Partita_IVA])
GO
ALTER TABLE [dbo].[Ricambio] CHECK CONSTRAINT [EQU_Ricam_Forni_FK]
GO
ALTER TABLE [dbo].[Riparazione]  WITH CHECK ADD  CONSTRAINT [REF_Ripar_Veico] FOREIGN KEY([Veicolo_Numero_telaio])
REFERENCES [dbo].[Veicolo_venduto] ([Numero_telaio])
GO
ALTER TABLE [dbo].[Riparazione] CHECK CONSTRAINT [REF_Ripar_Veico]
GO
ALTER TABLE [dbo].[supporto]  WITH CHECK ADD  CONSTRAINT [REF_suppo_Optio_FK] FOREIGN KEY([Optional_Codice])
REFERENCES [dbo].[Optional] ([Codice])
GO
ALTER TABLE [dbo].[supporto] CHECK CONSTRAINT [REF_suppo_Optio_FK]
GO
ALTER TABLE [dbo].[supporto]  WITH CHECK ADD  CONSTRAINT [REF_suppo_Veico] FOREIGN KEY([Veicolo_Codice])
REFERENCES [dbo].[Veicolo_in_catalogo] ([Codice])
GO
ALTER TABLE [dbo].[supporto] CHECK CONSTRAINT [REF_suppo_Veico]
GO
ALTER TABLE [dbo].[Trasporto]  WITH CHECK ADD  CONSTRAINT [REF_Trasp_Corri_FK] FOREIGN KEY([Corriere_Partita_IVA])
REFERENCES [dbo].[Corriere] ([Partita_IVA])
GO
ALTER TABLE [dbo].[Trasporto] CHECK CONSTRAINT [REF_Trasp_Corri_FK]
GO
ALTER TABLE [dbo].[Trasporto]  WITH CHECK ADD  CONSTRAINT [SID_Trasp_Contr_FK] FOREIGN KEY([Contratto_Numero])
REFERENCES [dbo].[Contratto_di_vendita] ([Numero])
GO
ALTER TABLE [dbo].[Trasporto] CHECK CONSTRAINT [SID_Trasp_Contr_FK]
GO
ALTER TABLE [dbo].[utilizzo]  WITH CHECK ADD  CONSTRAINT [EQU_utili_Ripar] FOREIGN KEY([Veicolo_Numero_telaio], [Riparazione_Numero])
REFERENCES [dbo].[Riparazione] ([Veicolo_Numero_telaio], [Numero])
GO
ALTER TABLE [dbo].[utilizzo] CHECK CONSTRAINT [EQU_utili_Ripar]
GO
ALTER TABLE [dbo].[utilizzo]  WITH CHECK ADD  CONSTRAINT [REF_utili_Ricam_FK] FOREIGN KEY([Ricambio_Codice])
REFERENCES [dbo].[Ricambio] ([Codice])
GO
ALTER TABLE [dbo].[utilizzo] CHECK CONSTRAINT [REF_utili_Ricam_FK]
GO
ALTER TABLE [dbo].[Veicolo_in_catalogo]  WITH CHECK ADD  CONSTRAINT [EQU_Veico_Model_FK] FOREIGN KEY([Modello_Partita_IVA], [Modello_Nome], [Modello_Anno])
REFERENCES [dbo].[Modello_veicolo] ([Fornitore_Partita_IVA], [Nome], [Anno])
GO
ALTER TABLE [dbo].[Veicolo_in_catalogo] CHECK CONSTRAINT [EQU_Veico_Model_FK]
GO
ALTER TABLE [dbo].[Veicolo_venduto]  WITH CHECK ADD  CONSTRAINT [EQU_Veico_Contr_FK] FOREIGN KEY([Contratto_Numero])
REFERENCES [dbo].[Contratto_di_vendita] ([Numero])
GO
ALTER TABLE [dbo].[Veicolo_venduto] CHECK CONSTRAINT [EQU_Veico_Contr_FK]
GO
ALTER TABLE [dbo].[Veicolo_venduto]  WITH CHECK ADD  CONSTRAINT [EQU_Veico_Ordin_FK] FOREIGN KEY([Ordine_ID_ordine])
REFERENCES [dbo].[Ordine] ([ID_ordine])
GO
ALTER TABLE [dbo].[Veicolo_venduto] CHECK CONSTRAINT [EQU_Veico_Ordin_FK]
GO
ALTER TABLE [dbo].[Veicolo_venduto]  WITH CHECK ADD  CONSTRAINT [REF_Veico_Veico_FK] FOREIGN KEY([Veicolo_Codice])
REFERENCES [dbo].[Veicolo_in_catalogo] ([Codice])
GO
ALTER TABLE [dbo].[Veicolo_venduto] CHECK CONSTRAINT [REF_Veico_Veico_FK]
GO
USE [master]
GO
ALTER DATABASE [ProgettoDB16] SET  READ_WRITE 
GO
