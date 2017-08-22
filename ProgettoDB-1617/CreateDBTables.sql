create table Cliente (
	Id  numeric(6) not null,
	TipoCliente char not null,
	CodiceFiscale varchar(16),
	Nome varchar(20),
	Cognome varchar(20),
	DataNascita date,
	Citt‡Nascita varchar(30),
	ProvinciaNascita varchar(30),
	PartitaIVA char(11),
	RagioneSociale varchar(50),
	Recapito1 varchar(12) not null,
	Recapito2 char(1),
	IndirizzoEmail1 varchar(30),
	IndirizzoEmail2 char(1),
	Indirizzo varchar(50) not null,
	Citt‡ varchar(30) not null,
	Provincia varchar(30) not null,
	CAP char(4) not null,
	primary key (Id),
	unique (CodiceFiscale, PartitaIVA));

create table ContrattoVendita (
	Numero  numeric(6) not null,
	Trasporto char(5),
	Data date not null,
	ImportoComplessivo float(10) not null,
	Modalit‡Pagamento float(7) not null,
	Cliente numeric(6) not null,
	primary key (Numero),
	unique (Trasporto));

create table Corriere (
	PartitaIVA char(11) not null,
	RagioneSociale varchar(30) not null,
	Indirizzo varchar(50) not null,
	Citt‡ varchar(30) not null,
	Provincia varchar(30) not null,
	CAP char(5) not null,
	Recapito1 varchar(12) not null,
	Recapito2 varchar(12),
	IndirizzoEmail1 varchar(50) not null,
	IndirizzoEmail2 varchar(50),
	primary key (PartitaIVA));

create table Dotazione (
	Optional char(5) not null,
	Veicolo numeric(6) not null,
	primary key (Veicolo, Optional));

create table FatturaAcquisto (
	Fornitore char(11) not null,
	Numero numeric(6) not null,
	Ordine numeric(6) not null,
	Data date not null,
	ImportoComplessivo float(10) not null,
	ModPagamentoFornitore char(11) not null,
	ModPagamentoDa float(7) not null,
	primary key (Fornitore, Numero),
	unique (Ordine));

create table Fornitore (
	PartitaIVA char(11) not null,
	TipoFornitore char(1) not null,
	RagioneSociale varchar(50) not null,
	Recapito1 varchar(12) not null,
	Recapito2 varchar(12),
	IndirizzoEmail1 varchar(50) not null,
	IndirizzoEmail2 varchar(50),
	Indirizzo varchar(50) not null,
	Citt‡ varchar(30) not null,
	Provincia varchar(30) not null,
	CAP char(5) not null,
	primary key (PartitaIVA));

create table Giacenza (
	Ricambio char(5) not null,
	Numero  numeric(6) not null,
	Data date not null,
	Quantit‡ numeric(6) not null,
	Causale varchar(255) not null,
	primary key (Ricambio, Numero));

create table Modalit‡Pagamento (
	Fornitore char(11) not null,
	Da float(7) not null,
	A float(10) not null,
	Periodicit‡ varchar(10) not null,
	TassoInteresse float(5) not null,
	NumeroRate numeric(2) not null,
	primary key (Fornitore, Da));

create table ModelloVeicolo (
	Nome varchar(20) not null,
	Anno date not null,
	Fornitore char(11) not null,
	primary key (Nome, Anno));

create table NostreModalit‡Pagamento (
	Da float(7) not null,
	A float(10) not null,
	Periodicit‡ varchar(10) not null,
	TassoInteresse float(5) not null,
	NumerRate numeric(2) not null,
	primary key (Da));

create table Optional (
	Codice char(5) not null,
	Nome varchar(30) not null,
	Descrizione varchar(255) not null,
	Prezzo float(7) not null,
	primary key (Codice));

create table Ordine (
	Id numeric(6) not null,
	TipoOrdine char not null,
	DataOrdine date not null,
	DataConsegnaPrevista date not null,
	DataConsegna date,
	Fornitore char(11) not null,
	primary key (Id));

create table OrdineRicambio (
	Ordine numeric(6) not null,
	Ricambio char(5) not null,
	Quantit‡ numeric(6) not null,
	PrezzoUnitario float(7) not null,
	primary key (Ordine, Ricambio));

create table OrdineVeicolo (
	Veicolo numeric(6) not null,
	PrezzoFornitore float(10) not null,
	Ordine numeric(6) not null,
	primary key (Veicolo));

create table Rata (
	FornitoreFattura char(11) not null,
	NumeroFattura numeric(6) not null,
	Scadenza date not null,
	Importo float(10) not null,
	DataPagamento date,
	primary key (FornitoreFattura, NumeroFattura, Scadenza));

create table RataCliente (
	Contratto numeric(6) not null,
	Scadenza date not null,
	Importo float(10) not null,
	DataPagamento date,
	primary key (Contratto, Scadenza));

create table Referenza (
	VeicoloCatalogo char(5) not null,
	Ricambio char(5) not null,
	primary key (VeicoloCatalogo, Ricambio));

create table Revisione (
	VeicoloVenduto numeric(6) not null,
	Numero  numeric(6) not null,
	Scadenza date not null,
	DataEsecuzione date,
	primary key (VeicoloVenduto, Numero));

create table Ricambio (
	Codice char(5) not null,
	Nome varchar(30) not null,
	Descrizione varchar(255) not null,
	PrezzoUnitarioRiparazione float(7) not null,
	TipoRicambio char(1) not null,
	Fornitore char(11) not null,
	primary key (Codice));

create table Riparazione (
	Veicolo numeric(6) not null,
	Numero numeric(6)  not null,
	Data date not null,
	ImportoComplessivo float(7) not null,
	primary key (Veicolo, Numero));

create table Supporto (
	VeicoloCatalogo char(5) not null,
	Optional char(5) not null,
	primary key (Optional, VeicoloCatalogo));

create table Trasporto (
	Codice char(5) not null,
	Costo float(7),
	DataConsegnaPrevista date not null,
	DataConsegna date,
	IndirizzoConsegna varchar(50) not null,
	Citt‡Consegna varchar(30) not null,
	ProvinciaConsegna varchar(30) not null,
	Corriere char(11),
	primary key (Codice));

create table Utilizzo (
	Ricambio char(5) not null,
	Veicolo numeric(6) not null,
	Numero numeric(6) not null,
	Quantit‡ numeric(6) not null,
	primary key (Ricambio, Veicolo, Numero));

create table VeicoloCatalogo (
	Codice char(5) not null,
	PrezzoBase float(8) not null,
	Potenza float(4) not null,
	NumPosti numeric(1) not null,
	Consumi float(4) not null,
	Omologazione varchar(10) not null,
	Capacit‡Serbatorio float(5) not null,
	TipoAlimentazione varchar(20) not null,
	Cilindrata float(7) not null,
	Trazione varchar(20) not null,
	Cambio varchar(20) not null,
	CapienzaBagagliaio float(5) not null,
	NumPorte numeric(1) not null,
	NomeModello varchar(20) not null,
	AnnoModello date not null,
	primary key (Codice));

create table VeicoloVenduto (
	Id numeric(6) not null,
	Telaio char(17),
	Contratto numeric(6) not null,
	primary key (Id),
	unique (Telaio));


-- Constraints Section
-- ___________________

alter table ContrattoVendita add constraint FKdefinizione 
	foreign key (Modalit‡Pagamento)
	references NostreModalit‡Pagamento;

alter table ContrattoVendita add constraint FKstipulazione
	foreign key (Cliente)
	references Cliente;

alter table ContrattoVendita add constraint FKservizio
	foreign key (Trasporto)
	references Trasporto;

alter table Dotazione add constraint FKdot_Vei
	foreign key (Veicolo)
	references VeicoloVenduto;

alter table Dotazione add constraint FKdot_Opt
	foreign key (Optional)
	references Optional;

alter table FatturaAcquisto add constraint FKdocumentare
	foreign key (Ordine)
	references Ordine;

alter table FatturaAcquisto add constraint FKemissione
	foreign key (Fornitore)
	references Fornitore;

alter table FatturaAcquisto add constraint FKsoggezione
	foreign key (ModPagamentoFornitore, ModPagamentoDa)
	references Modalit‡Pagamento;

alter table Giacenza add constraint FKgiacenza
	foreign key (Ricambio)
	references Ricambio;

alter table Modalit‡Pagamento add constraint FKdefinizione2
	foreign key (Fornitore)
	references Fornitore;

alter table ModelloVeicolo add constraint FKproduzione
	foreign key (Fornitore)
	references Fornitore;

alter table Ordine add constraint FKrichiesta
	foreign key (Fornitore)
	references Fornitore;

alter table OrdineRicambio add constraint FKord_Ric
	foreign key (Ricambio)
	references Ricambio;

alter table OrdineRicambio add constraint FKord_Ord
	foreign key (Ordine)
	references Ordine;

alter table OrdineVeicolo add constraint FKord_Ord2
	foreign key (Ordine)
	references Ordine;

alter table OrdineVeicolo add constraint FKord_Vei
	foreign key (Veicolo)
	references VeicoloVenduto;

alter table Rata add constraint FKpagamento
	foreign key (FornitoreFattura, NumeroFattura)
	references FatturaAcquisto;

alter table RataCliente add constraint FKpagamento_cliente
	foreign key (Contratto)
	references ContrattoVendita;

alter table Referenza add constraint FKref_Ric
	foreign key (Ricambio)
	references Ricambio;

alter table Referenza add constraint FKref_Vei
	foreign key (VeicoloCatalogo)
	references VeicoloCatalogo;

alter table Revisione add constraint FKscadenza
	foreign key (VeicoloVenduto)
	references VeicoloVenduto;

alter table Ricambio add constraint FKfornitura
	foreign key (Fornitore)
	references Fornitore;

alter table Riparazione add constraint FKesecuzione
	foreign key (Veicolo)
	references VeicoloVenduto;

alter table Supporto add constraint FKsup_Opt
	foreign key (Optional)
	references Optional;

alter table Supporto add constraint FKsup_Vei
	foreign key (VeicoloCatalogo)
	references VeicoloCatalogo;

alter table Trasporto add constraint FKesecuzione2 
	foreign key (Corriere)
	references Corriere;

alter table Utilizzo add constraint FKuti_Rip
	foreign key (Veicolo, Numero)
	references Riparazione;

alter table Utilizzo add constraint FKuti_Ric
	foreign key (Ricambio)
	references Ricambio;

alter table VeicoloCatalogo add constraint FKappartenenza
	foreign key (NomeModello, AnnoModello)
	references ModelloVeicolo;

alter table VeicoloVenduto add constraint FKinclusione
	foreign key (Contratto)
	references ContrattoVendita;
