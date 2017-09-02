GUIDA ALL'USO


Contenuto
All'interno della dir DBProject saranno contenuti tutti i file relativi all'applicazione realizzata, tra cui: i sorgenti (\DBProject), il file di database (\database) e la solution VisualStudio DBProject.sln.

Esecuzione
Premesso che l'esecuzione dell'applicazione non è stata testata in laboratorio e che all'atto della discussione la presentazione delle stessa avverrà per mezzo di un proprio pc, l'applicazione si potrà semplicemente lanciare attraverso l'eseguibile
-> DBProject\DBProject\bin\Release\DBProject.exe.
L'applicativo dovrebbe richiedere, in genere, qualche istante per il lancio.
Nel caso l'applicativo non risulti lanciato dopo qualche minuto (in genere bastano una decina di secondi al massimo per accorgersene) occorrerà allora avviare il tutto da solution.
Siccome si utilizza una connessione ad un file di database (locato nella dir \database) che necessita di un'apposita istanza di Microsoft SQL Server (anche SQL Express), per la corretta esecuzione dell'applicativo è quindi necessario che sull'host di destinazione sia presente il suddetto motore di databasse.
A tal proposito, si provi quindi a lanciare l'applicazione a partire dalla solution in VisualStudio e si verifichino eventuali problemi circa la connessione all'istanza SQL Server e, se necessario, eseguire le operazioni di configurazione proposte da VisualStudio in caso di errori.