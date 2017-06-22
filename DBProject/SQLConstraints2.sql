alter table Veicolo_in_catalogo add constraint ID_Veicolo_in_catalogo_CHK
     check(exists(select * from referenza2
                  where referenza2.Veicolo_Codice = Codice)); 

alter table Riparazione add constraint ID_Riparazione_CHK
     check(exists(select * from utilizzo
                  where utilizzo.Veicolo_Numero_telaio = Veicolo_Numero_telaio and utilizzo.Riparazione_Numero = Numero)); 

alter table Ricambio add constraint ID_Ricambio_CHK
     check(exists(select * from Giacenza
                  where Giacenza.Ricambio_Codice = Codice)); 

alter table Ricambio add constraint ID_Ricambio_CHK
     check(exists(select * from referenza2
                  where referenza2.Ricambio_Codice = Codice)); 

alter table Ordine add constraint ID_Ordine_CHK
     check(exists(select * from di
                  where di.Ordine_ID_ordine = ID_ordine)); 

alter table Ordine add constraint ID_Ordine_CHK
     check(exists(select * from per2
                  where per2.Ordine_ID_ordine = ID_ordine)); 

alter table Ordine add constraint ID_Ordine_CHK
     check(exists(select * from Veicolo_venduto
                  where Veicolo_venduto.Ordine_ID_ordine = ID_ordine));

alter table Modello_veicolo add constraint ID_Modello_veicolo_CHK
     check(exists(select * from Veicolo_in_catalogo
                  where Veicolo_in_catalogo.Modello_Partita_IVA = Fornitore_Partita_IVA and Veicolo_in_catalogo.Modello_Nome = Nome and Veicolo_in_catalogo.Modello_Anno = Anno)); 

alter table Fornitore add constraint ID_Fornitore_CHK
     check(exists(select * from Ricambio
                  where Ricambio.Fornitore_Partita_IVA = Partita_IVA)); 

alter table Fornitore add constraint ID_Fornitore_CHK
     check(exists(select * from Modello_veicolo
                  where Modello_veicolo.Fornitore_Partita_IVA = Partita_IVA)); 

alter table Fornitore add constraint ID_Fornitore_CHK
     check(exists(select * from Modalita_di_pagamento
                  where Modalita_di_pagamento.Fornitore_Partita_IVA = Partita_IVA));

alter table Fattura_di_acquisto add constraint ID_Fattura_di_acquisto_CHK
     check(exists(select * from Ordine
                  where Ordine.Fattura_Partita_IVA = Fornitore_Partita_IVA and Ordine.Numero = Numero)); 

alter table Fattura_di_acquisto add constraint ID_Fattura_di_acquisto_CHK
     check(exists(select * from Pagamento_cAcquisto
                  where Pagamento_cAcquisto.Fattura_Partita_IVA = Fornitore_Partita_IVA and Pagamento_cAcquisto.Fattura_Numero = Numero)); 

alter table Cliente add constraint ID_Cliente_CHK
     check(exists(select * from Contratto_di_vendita
                  where Contratto_di_vendita.Cliente_PartitaIVA_CodiceFiscale = PartitaIVA_CodiceFiscale)); 

alter table Contratto_di_vendita add constraint ID_Contratto_di_vendita_CHK
     check(exists(select * from Veicolo_venduto
                  where Veicolo_venduto.Contratto_Numero = Numero)); 

alter table Contratto_di_vendita add constraint ID_Contratto_di_vendita_CHK
     check(exists(select * from Pagamento_cVendita
                  where Pagamento_cVendita.Contratto_Numero = Numero)); 