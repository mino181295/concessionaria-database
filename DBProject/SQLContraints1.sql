	-- Constraints Section
-- ___________________ 


alter table Contratto_di_vendita add constraint REF_Contr_Nostr_FK
     foreign key (Nostre_Mod_Da)
     references Nostre_modalita_di_pagamento;

alter table Contratto_di_vendita add constraint EQU_Contr_Clien_FK
     foreign key (Cliente_PartitaIVA_CodiceFiscale)
     references Cliente;

alter table di add constraint REF_di_Ricam_FK
     foreign key (Ricambio_Codice)
     references Ricambio;

alter table di add constraint EQU_di_Ordin
     foreign key (Ordine_ID_ordine)
     references Ordine;

alter table Fattura_di_acquisto add constraint REF_Fattu_Forni
     foreign key (Fornitore_Partita_IVA)
     references Fornitore;

alter table Fattura_di_acquisto add constraint REF_Fattu_Modal_FK
     foreign key (Mod_Pagamento_Partita_IVA, Mod_Pagamento_Da)
     references Modalita_di_pagamento; 

alter table Giacenza add constraint EQU_Giace_Ricam
     foreign key (Ricambio_Codice)
     references Ricambio;

alter table Modalita_di_pagamento add constraint EQU_Modal_Forni
     foreign key (Fornitore_Partita_IVA)
     references Fornitore;

alter table Modello_veicolo add constraint EQU_Model_Forni
     foreign key (Fornitore_Partita_IVA)
     references Fornitore; 

alter table Ordine add constraint SID_Ordin_Fattu_FK
     foreign key (Fattura_Partita_IVA, Numero)
     references Fattura_di_acquisto;

alter table Pagamento_cAcquisto add constraint EQU_Pagam_Fattu
     foreign key (Fattura_Partita_IVA, Fattura_Numero)
     references Fattura_di_acquisto;

alter table Pagamento_cVendita add constraint EQU_Pagam_Contr
     foreign key (Contratto_Numero)
     references Contratto_di_vendita;

alter table per2 add constraint EQU_per2_Ordin_FK
     foreign key (Ordine_ID_ordine)
     references Ordine;

alter table per2 add constraint REF_per2_Veico
     foreign key (Veicolo_Codice)
     references Veicolo_in_catalogo;

alter table possesso add constraint REF_posse_Optio_FK
     foreign key (Optional_Codice)
     references Optional;

alter table possesso add constraint REF_posse_Veico
     foreign key (Veicolo_Numero_telaio)
     references Veicolo_venduto;

alter table referenza2 add constraint EQU_refer_Ricam_FK
     foreign key (Ricambio_Codice)
     references Ricambio;

alter table referenza2 add constraint EQU_refer_Veico
     foreign key (Veicolo_Codice)
     references Veicolo_in_catalogo;

alter table Revisione add constraint REF_Revis_Veico
     foreign key (Veticolo_Numero_telaio)
     references Veicolo_venduto;

alter table Ricambio add constraint EQU_Ricam_Forni_FK
     foreign key (Fornitore_Partita_IVA)
     references Fornitore;

alter table Riparazione add constraint REF_Ripar_Veico
     foreign key (Veicolo_Numero_telaio)
     references Veicolo_venduto;

alter table supporto add constraint REF_suppo_Optio_FK
     foreign key (Optional_Codice)
     references Optional;

alter table supporto add constraint REF_suppo_Veico
     foreign key (Veicolo_Codice)
     references Veicolo_in_catalogo;

alter table Trasporto add constraint REF_Trasp_Corri_FK
     foreign key (Corriere_Partita_IVA)
     references Corriere;

alter table Trasporto add constraint SID_Trasp_Contr_FK
     foreign key (Contratto_Numero)
     references Contratto_di_vendita;

alter table utilizzo add constraint REF_utili_Ricam_FK
     foreign key (Ricambio_Codice)
     references Ricambio;

alter table utilizzo add constraint EQU_utili_Ripar
     foreign key (Veicolo_Numero_telaio, Riparazione_Numero)
     references Riparazione;

alter table Veicolo_in_catalogo add constraint EQU_Veico_Model_FK
     foreign key (Modello_Partita_IVA, Modello_Nome, Modello_Anno)
     references Modello_veicolo;

alter table Veicolo_venduto add constraint EQU_Veico_Contr_FK
     foreign key (Contratto_Numero)
     references Contratto_di_vendita;

alter table Veicolo_venduto add constraint EQU_Veico_Ordin_FK
     foreign key (Ordine_ID_ordine)
     references Ordine;

alter table Veicolo_venduto add constraint REF_Veico_Veico_FK
     foreign key (Veicolo_Codice)
     references Veicolo_in_catalogo;
