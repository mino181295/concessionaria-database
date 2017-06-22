USE [master]
GO

/****** Object:  Database [ProgettoDB16]    Script Date: 02/09/2016 15:29:07 ******/
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

ALTER DATABASE [ProgettoDB16] SET  READ_WRITE 
GO


-- *********************************************
-- * Standard SQL generation                   
-- *--------------------------------------------
-- * DB-MAIN version: 9.3.0              
-- * Generator date: Feb 16 2016              
-- * Generation date: Thu Sep 01 23:50:57 2016 
-- * LUN file: C:\Users\matteo.minardi\Google Drive\PROGETTO DB\SchemaE-R+Logico Temp Final.lun 
-- * Schema: Schema Logico/SQL 
-- ********************************************* 


-- Database Section
-- ________________ 



-- DBSpace Section
-- _______________


-- Tables Section
-- _____________ 

create table Cliente (
     PartitaIVA_CodiceFiscale char(11) not null,
     Recapito_1 varchar(12) not null,
     Recapito_2 varchar(12),
     Recapito_3 varchar(12),
     Citta varchar(25) not null,
     Indirizzo varchar(30) not null,
     Provincia varchar(30) not null,
     CAP char(5) not null,
     Tipo_Cliente char not null,
     Ragione_sociale varchar(25),
     Indirizzo_e_mail_1 varchar(30),
     Indirizzo_e_mail_2 varchar(30),
     Nome varchar(20),
     Cognome varchar(20),
     Data date,
     Citta_nascita char(1),
     Provincia_nascita char(1),
     constraint ID_Cliente_ID primary key (PartitaIVA_CodiceFiscale));

create table Contratto_di_vendita (
     Numero integer not null,
     Data date not null,
     Importo_complessivo float(10) not null,
     Nostre_Mod_Da float(7) not null,
     Cliente_PartitaIVA_CodiceFiscale char(11) not null,
     constraint ID_Contratto_di_vendita_ID primary key (Numero));

create table Corriere (
     Partita_IVA char(11) not null,
     Ragione_sociale varchar(30) not null,
     Citta varchar(25) not null,
     Provincia varchar(30) not null,
     Indirizzo varchar(30) not null,
     CAP char(5) not null,
     Recapito_1 varchar(12) not null,
     Recapito_2 char(1),
     Indirizzo_e_mail_1 varchar(30) not null,
     Indirizzo_e_mail_2 varchar(30),
     constraint ID_Corriere_ID primary key (Partita_IVA));

create table di (
     Ordine_ID_ordine char(6) not null,
     Ricambio_Codice char(5) not null,
     quantita integer not null,
     constraint ID_di_ID primary key (Ordine_ID_ordine, Ricambio_Codice));

create table Fattura_di_acquisto (
     Fornitore_Partita_IVA char(11) not null,
     Numero integer not null,
     Data date not null,
     Importo_complessivo float(10) not null,
     Mod_Pagamento_Partita_IVA char(11) not null,
     Mod_Pagamento_Da float(7) not null,
     constraint ID_Fattura_di_acquisto_ID primary key (Fornitore_Partita_IVA, Numero));

create table Fornitore (
     Partita_IVA char(11) not null,
     Ragione_Sociale varchar(30) not null,
     Recapito_1 varchar(12) not null,
     Recapito_2 varchar(12),
     Recapito_3 varchar(12),
     Indirizzo_e_mail_1 varchar(25) not null,
     Indirizzo_e_mail_2 char(1),
     Tipo_Ricambi char not null,
     Tipo_CasaProduttrice char not null,
     Citta varchar(25) not null,
     Provincia varchar(30) not null,
     Indirizzo varchar(30) not null,
     CAP char(4) not null,
     constraint ID_Fornitore_ID primary key (Partita_IVA));

create table Giacenza (
     Ricambio_Codice char(5) not null,
     Numero integer not null,
     Data date not null,
     Quantita integer not null,
     Causale varchar(15) not null,
     constraint ID_Giacenza_ID primary key (Ricambio_Codice, Numero));

create table Modalita_di_pagamento (
     Fornitore_Partita_IVA char(11) not null,
     Da float(7) not null,
     A float(10) not null,
     Periodicita varchar(10) not null,
     Tasso_interesse float(5) not null,
     Numero_rate integer not null,
     constraint ID_Modalita_di_pagamento_ID primary key (Fornitore_Partita_IVA, Da));

create table Modello_veicolo (
     Nome varchar(20) not null,
     Anno date not null,
     Fornitore_Partita_IVA char(11) not null,
     constraint ID_Modello_veicolo_ID primary key (Fornitore_Partita_IVA, Nome, Anno));

create table Nostre_modalita_di_pagamento (
     Da float(7) not null,
     A float(10) not null,
     Periodicita varchar(10) not null,
     Tasso_interesse float(5) not null,
     Numero_rate integer not null,
     constraint ID_Nostre_modalita_di_pagamento_ID primary key (Da));

create table Optional (
     Codice char(5) not null,
     Nome varchar(20) not null,
     Descrizione varchar(200) not null,
     Prezzo float(7) not null,
     constraint ID_Optional_ID primary key (Codice));

create table Ordine (
     ID_ordine char(6) not null,
     Fattura_Partita_IVA char(11) not null,
     Numero integer not null,
     Data_ordine date not null,
     Data_spedizione date not null,
     Data_consegna_1 char(1) not null,
     Data_consegna_2 char(1),
     Tipo_Ordine char not null,
     constraint ID_Ordine_ID primary key (ID_ordine),
     constraint SID_Ordin_Fattu_ID unique (Fattura_Partita_IVA, Numero));

create table Pagamento_cAcquisto (
     Fattura_Partita_IVA char(11) not null,
     Fattura_Numero integer not null,
     Data date not null,
     Importo float(10) not null,
     constraint ID_Pagamento_cAcquisto_ID primary key (Fattura_Partita_IVA, Fattura_Numero, Data));

create table Pagamento_cVendita (
     Contratto_Numero integer not null,
     Data date not null,
     Importo float(10) not null,
     constraint ID_Pagamento_cVendita_ID primary key (Contratto_Numero, Data));

create table per2 (
     Veicolo_Codice char(5) not null,
     Ordine_ID_ordine char(6) not null,
     quantita integer not null,
     constraint ID_per2_ID primary key (Veicolo_Codice, Ordine_ID_ordine));

create table possesso (
     Veicolo_Numero_telaio char(17) not null,
     Optional_Codice char(5) not null,
     constraint ID_possesso_ID primary key (Veicolo_Numero_telaio, Optional_Codice));

create table referenza2 (
     Veicolo_Codice char(5) not null,
     Ricambio_Codice char(5) not null,
     constraint ID_referenza2_ID primary key (Veicolo_Codice, Ricambio_Codice));

create table Revisione (
     Veticolo_Numero_telaio char(17) not null,
     Numero integer not null,
     Scadenza date not null,
     Data_esecuzione date,
     constraint ID_Revisione_ID primary key (Veticolo_Numero_telaio, Numero));

create table Ricambio (
     Codice char(5) not null,
     Nome varchar(25) not null,
     Descrizione varchar(100) not null,
     Prezzo_di_acquisto float(7) not null,
     Prezzo_uRiparazione float(7) not null,
     Tipo_Ricambio char not null,
     Fornitore_Partita_IVA char(11) not null,
     constraint ID_Ricambio_ID primary key (Codice));

create table Riparazione (
     Veicolo_Numero_telaio char(17) not null,
     Numero integer not null,
     Data date not null,
     Importo_complessivo float(7) not null,
     constraint ID_Riparazione_ID primary key (Veicolo_Numero_telaio, Numero));

create table supporto (
     Veicolo_Codice char(5) not null,
     Optional_Codice char(5) not null,
     constraint ID_supporto_ID primary key (Veicolo_Codice, Optional_Codice));

create table Trasporto (
     Codice char(5) not null,
     Contratto_Numero integer not null,
     Costo float(7) not null,
     Data_consegna_1 date not null,
     Data_consegna_2 date,
     Indirizzo varchar(30) not null,
     Citta varchar(25) not null,
     Provincia varchar(25) not null,
     CAP char(5) not null,
     Corriere_Partita_IVA char(11) not null,
     constraint ID_Trasporto_ID primary key (Codice),
     constraint SID_Trasp_Contr_ID unique (Contratto_Numero));

create table utilizzo (
     Veicolo_Numero_telaio char(17) not null,
     Riparazione_Numero integer not null,
     Ricambio_Codice char(5) not null,
     quantita char(1) not null,
     constraint ID_utilizzo_ID primary key (Veicolo_Numero_telaio, Riparazione_Numero, Ricambio_Codice));

create table Veicolo_in_catalogo (
     Codice char(5) not null,
     Prezzo_base float(8) not null,
     Potenza float(4) not null,
     No_posti integer not null,
     Consumi float(4) not null,
     Omologazione varchar(10) not null,
     Capacita_serbatorio float(5) not null,
     Tipo_alimentazione varchar(20) not null,
     Cilindrata float(7) not null,
     Trazione varchar(20) not null,
     Cambio char(1) not null,
     Capienza_bagagliaio float(5) not null,
     No_porte integer not null,
     Modello_Partita_IVA char(11) not null,
     Modello_Nome varchar(20) not null,
     Modello_Anno date not null,
     constraint ID_Veicolo_in_catalogo_ID primary key (Codice));

create table Veicolo_venduto (
     Numero_telaio char(17) not null,
     Contratto_Numero integer not null,
     Ordine_ID_ordine char(6) not null,
     Veicolo_Codice char(5) not null,
     constraint ID_Veicolo_venduto_ID primary key (Numero_telaio));



-- Index Section
-- _____________ 

create unique index ID_Cliente_IND
     on Cliente (PartitaIVA_CodiceFiscale);

create unique index ID_Contratto_di_vendita_IND
     on Contratto_di_vendita (Numero);

create index REF_Contr_Nostr_IND
     on Contratto_di_vendita (Nostre_Mod_Da);

create index EQU_Contr_Clien_IND
     on Contratto_di_vendita (Cliente_PartitaIVA_CodiceFiscale);

create unique index ID_Corriere_IND
     on Corriere (Partita_IVA);

create unique index ID_di_IND
     on di (Ordine_ID_ordine, Ricambio_Codice);

create index REF_di_Ricam_IND
     on di (Ricambio_Codice);

create unique index ID_Fattura_di_acquisto_IND
     on Fattura_di_acquisto (Fornitore_Partita_IVA, Numero);

create index REF_Fattu_Modal_IND
     on Fattura_di_acquisto (Mod_Pagamento_Partita_IVA, Mod_Pagamento_Da);

create unique index ID_Fornitore_IND
     on Fornitore (Partita_IVA);

create unique index ID_Giacenza_IND
     on Giacenza (Ricambio_Codice, Numero);

create unique index ID_Modalita_di_pagamento_IND
     on Modalita_di_pagamento (Fornitore_Partita_IVA, Da);

create unique index ID_Modello_veicolo_IND
     on Modello_veicolo (Fornitore_Partita_IVA, Nome, Anno);

create unique index ID_Nostre_modalita_di_pagamento_IND
     on Nostre_modalita_di_pagamento (Da);

create unique index ID_Optional_IND
     on Optional (Codice);

create unique index ID_Ordine_IND
     on Ordine (ID_ordine);

create unique index SID_Ordin_Fattu_IND
     on Ordine (Fattura_Partita_IVA, Numero);

create unique index ID_Pagamento_cAcquisto_IND
     on Pagamento_cAcquisto (Fattura_Partita_IVA, Fattura_Numero, Data);

create unique index ID_Pagamento_cVendita_IND
     on Pagamento_cVendita (Contratto_Numero, Data);

create unique index ID_per2_IND
     on per2 (Veicolo_Codice, Ordine_ID_ordine);

create index EQU_per2_Ordin_IND
     on per2 (Ordine_ID_ordine);

create unique index ID_possesso_IND
     on possesso (Veicolo_Numero_telaio, Optional_Codice);

create index REF_posse_Optio_IND
     on possesso (Optional_Codice);

create unique index ID_referenza2_IND
     on referenza2 (Veicolo_Codice, Ricambio_Codice);

create index EQU_refer_Ricam_IND
     on referenza2 (Ricambio_Codice);

create unique index ID_Revisione_IND
     on Revisione (Veticolo_Numero_telaio, Numero);

create unique index ID_Ricambio_IND
     on Ricambio (Codice);

create index EQU_Ricam_Forni_IND
     on Ricambio (Fornitore_Partita_IVA);

create unique index ID_Riparazione_IND
     on Riparazione (Veicolo_Numero_telaio, Numero);

create unique index ID_supporto_IND
     on supporto (Veicolo_Codice, Optional_Codice);

create index REF_suppo_Optio_IND
     on supporto (Optional_Codice);

create unique index ID_Trasporto_IND
     on Trasporto (Codice);

create index REF_Trasp_Corri_IND
     on Trasporto (Corriere_Partita_IVA);

create unique index SID_Trasp_Contr_IND
     on Trasporto (Contratto_Numero);

create unique index ID_utilizzo_IND
     on utilizzo (Veicolo_Numero_telaio, Riparazione_Numero, Ricambio_Codice);

create index REF_utili_Ricam_IND
     on utilizzo (Ricambio_Codice);

create unique index ID_Veicolo_in_catalogo_IND
     on Veicolo_in_catalogo (Codice);

create index EQU_Veico_Model_IND
     on Veicolo_in_catalogo (Modello_Partita_IVA, Modello_Nome, Modello_Anno);

create unique index ID_Veicolo_venduto_IND
     on Veicolo_venduto (Numero_telaio);

create index EQU_Veico_Contr_IND
     on Veicolo_venduto (Contratto_Numero);

create index EQU_Veico_Ordin_IND
     on Veicolo_venduto (Ordine_ID_ordine);

create index REF_Veico_Veico_IND
     on Veicolo_venduto (Veicolo_Codice);

