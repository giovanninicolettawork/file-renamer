# FileRenamer

Questo software consente di rinominare tutti i file in una cartella secondo regole definite dall'utente.

# Specifiche

Il codice è stato scritto utilizzando *Microsoft Windows Forms* del framework *.NET* e per tale ragione è possibile utilizzarlo al meglio in ambiente Windows.
Gli step da seguire sono i seguenti:
- inserire nel primo box il percorso della cartella contenente i file da rinominare
- inserire nel secondo box la stringa che si desidera utilizzare come input per la modifica
	- selezionare ***Aggiungi (prima)*** se si desidera utilizzare la stringa di input come prefisso per tutti i nomi file (es. impostando la stringa "*xxx_*"  il file  "*a.pdf*" verrebbe rinominato in "*xxx_a.pdf*")
	- selezionare ***Aggiungi (dopo)*** se si desidera utilizzare la stringa di input come suffisso per tutti i nomi file (es. impostando la stringa "*_v2*"  il file  "*a.pdf*" verrebbe rinominato in "*a_v2.pdf*")
	- selezionare ***Rimuovi*** se si desidera utilizzare rimuovere la stringa di input da tutti i nomi file (es. impostando la stringa "*bb*"  il file  "*abbc.pdf*" verrebbe rinominato in "*ac.pdf*")

## Installazione e utilizzo
Per caricare il codice su *Visual Studio* è sufficiente cliccare due volte sul file:

    RenameFileInFolder.sln
Per utilizzare il software è necessario dapprima compilare la soluzione e successivamente avviarla.
È anche possibile generare i file necessari all'installazione del software sul proprio PC utilizzando la funzionalità *Pubblica Soluzione* di  *Visual Studio*
## Stato del progetto
Si tratta di un software implementato al solo scopo di acquisire confidenza con la tecnologia *.NET*