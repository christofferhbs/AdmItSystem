<h1 align="center" id="title">AdmItSystem</h1>

<p align="center">
  <img src="https://github.com/user-attachments/assets/5ecd4804-02ae-42bc-ad2f-3114d8ee9d0d" alt="project-screenshot">
</p>

<p id="description">Et administrativt IT-system til en ejendomsmæglerkæde. Jeg udviklede dette på 1. semester af datamatikeruddannelsen.</p>

## Sammenspillet mellem UI, BL, DB

### 1. AdmItSystem.WinForms
DashboardForm: Håndterer dashboard-grænsefladen og interaktioner.
### 2. AdmItSystem.Logic
DashboardManager: Håndterer logikken og fungerer som en mellemmand mellem UI og datalag.
### 3. AdmItSystem.DataAccess
DbHandler: Håndterer databaseoperationer.
### 4. AdmItSystem.Models
Forskellige datamodeller som BoligInfo, KundeInfo, osv.
![image](https://github.com/user-attachments/assets/9003baa8-eaa5-454f-9874-b3a997f89f12)


## Kode forklaring
### DashboardForm
DashboardManager instans: Håndterer interaktioner mellem UI og logiklaget.
Form Load Event: Initialiserer og udfylder comboBoxAfdeling.
![image](https://github.com/user-attachments/assets/808b94fe-e2d2-49b5-be9d-0650ef3108da)


### DashboardForm
LoadDashboardForms: Tilføjer forskellige formularer til dashboard-panelet.
FillComboBoxAfdeling: Udfylder comboBox med afdelingsdata.
LoadFormsWithAfdeling: Opretter instanser af formularer baseret på den valgte afdeling.
![image](https://github.com/user-attachments/assets/779daa25-0458-4cc5-8c92-fe63e3b82f13)


### DashboardManager
Håndterer logikken for dashboardet og fungerer som mellemmand mellem UI og DB.
DbHandler instans: Opretter forbindelse til databasen.
GetAfdelinger: Henter afdelingsdata fra databasen.
![image](https://github.com/user-attachments/assets/7838696e-cdbf-4e7f-9a1d-f5b868f0cb4f)



### OversigtForm
OversigtForm klassen, viser en oversigt over boliginfo.
OversigtManager instans: Håndterer dataindtastning og logik for oversigten.
LoadBoligInfo: Indlæser boliginformation for den valgte afdeling.
![image](https://github.com/user-attachments/assets/68cfabcf-2972-4828-aa08-6de3e1116bd6)


### OversigtManager
TilpasDataGridView: Filtrerer boliginfo baseret på valgt afdeling.
![image](https://github.com/user-attachments/assets/76de7775-172c-4666-af04-ca4501179b6f)

### DbHandler
Håndterer databaseoperationer.
GetBoligInfo: Henter boliginformation fra databasen
![image](https://github.com/user-attachments/assets/ca193359-c033-4d40-b667-7c3764b25ee8)


## Klassediagram
![image](https://github.com/user-attachments/assets/5e24e316-6866-4c09-9e30-ab192fd75c9f)

## Use Cases

Use casene nedenfor definerer de forskellige funktionaliteter, som systemet skal kunne håndtere. I denne sammenhæng er ejendomsmæglere de primære brugere af systemet. Sælgere og købere betragtes som sekundære aktører, da de kun indirekte interagerer med systemet ved at levere oplysninger til ejendomsmæglerne, som derefter bruger systemet til at håndtere oplysningerne.

### A1: Tilgå afdeling
- Ejendomsmægler skal kunne tilgå den specifikke afdeling i systemet, hvor denne skal gøre brug af systemets tjenester.

### A2: Tilpas til afdeling
- Ejendomsmægler skal kunne se visningen og beregningerne i systemet, der passer til den specifikke afdeling, hvor denne hører til.

### M1: Opret medarbejder
- Ejendomsmægler skal kunne oprette en ny medarbejder med relevante oplysninger.

### M2: Find medarbejder
- Ejendomsmægler skal kunne finde en eksisterende medarbejder.

### M3: Opdater medarbejder
- Ejendomsmægler skal kunne ændre en eksisterende medarbejders oplysninger.

### M4: Slet medarbejder
- Ejendomsmægler skal kunne slette en eksisterende medarbejder.

### K1: Opret kunde
- Ejendomsmægler skal kunne oprette en ny kunde med relevante oplysninger.

### K2: Find kunde
- Ejendomsmægler skal kunne finde en eksisterende kunde.

### K3: Opdater kunde
- Ejendomsmægler skal kunne ændre en eksisterende kundes oplysninger.

### K4: Slet kunde
- Ejendomsmægler skal kunne slette en eksisterende kunde.

### B1: Opret bolig
- Ejendomsmægler skal kunne oprette en ny bolig med relevante boligdetaljer.

### B2: Find bolig
- Ejendomsmægler skal kunne finde en eksisterende bolig.

### B3: Tilknyt sælger til bolig
- Ejendomsmægler skal kunne tilknytte en sælger til en eksisterende bolig til salg.

### B4: Tilknyt ejendomsmægler til bolig
- Ejendomsmægler skal kunne tilknytte en primær ejendomsmægler til en eksisterende bolig til salg.

### B5: Opdater salgspris på bolig
- Ejendomsmægler skal kunne ændre salgsprisen på en eksisterende bolig til salg.

### B6: Marker bolig til salg som solgt
- Ejendomsmægler skal kunne markere en eksisterende bolig til salg som solgt til en køber, med en aktuel handelspris, på en bestemt handelsdato.

### B7: Slet bolig
- Ejendomsmægler skal kunne slette en eksisterende bolig.

### E1: Eksporter sorteret liste over boliger til salg
- Ejendomsmægler skal kunne trække en liste i CSV-format med alle boliger til salg i sorteret rækkefølge.

### E2: Eksporter liste over alle boliger i et bestemt område
- Ejendomsmægler skal kunne trække en liste i CSV-format med alle boliger fra et bestemt område, inklusiv sælger med kontaktoplysninger.

### L1: Vis sammenligningsliste for solgte boliger
- Ejendomsmægler skal kunne få vist en dynamisk liste med sammenlignelige solgte boliger med en beregnet gennemsnitlig m2 pris ud fra de valgte afgrænsninger i postnummer, m2 interval (+/- 15 m2) og boligtype.

### O1: Vis oversigt
- Ejendomsmægler skal kunne få vist en sorterbar oversigt over alle boliger i kartoteket.

### O2: Sorter efter stigende salgspris
- Ejendomsmægler skal kunne sortere i oversigten ud fra en boligs salgspris i stigende rækkefølge.

### O3: Sorter efter faldende salgspris
- Ejendomsmægler skal kunne sortere i oversigten ud fra en boligs salgspris i faldende rækkefølge.

### O4: Filtrer solgte boliger fra
- Ejendomsmægler skal kunne fjerne solgte boliger fra oversigten.

### O5: Filtrer boliger til salg fra
- Ejendomsmægler skal kunne fjerne ikke solgte boliger fra oversigten.

### O6: Filtrer boliger til salg efter prisinterval
- Ejendomsmægler skal kunne finde boliger til salg indenfor et prisinterval.

## Use Case Diagram

UCD´et hjælper med at give et billede af, hvordan ejendomsmægleren interagerer med systemet og de forskellige funktioner, han skal bruge. Det hjælper med at forstå, hvordan systemet er designet til at understøtte ejendomsmæglerens behov.

Diagrammet er opdelt i 7 hovedkategorier: Håndtering af kundeoplysninger, medarbejderoplysninger, boligoplysninger og eksport-, oversigt-, markedsanalyse- og afdelingskategori. Hver kategori indeholder specifikke funktioner, som ejendomsmægleren kan gøre brug af, og som er nødvendige for at imødekomme hans behov.

<p align="center">
  <img src="https://i.postimg.cc/rwXsKwB3/UCD-v1.jpg" alt="project-screenshot">
</p>

## Domænemodel

I domænemodellen illustrerer jeg de vigtigste entiteter og deres relationer. Det hjælper med at
få et overblik over strukturen, og de forskellige enheders forhold til hinanden.

![DM v1](https://github.com/user-attachments/assets/cba32263-3560-4328-8a8f-35b44fb0f5a1)


## Systemsekvensdiagram

SSD´et viser interaktionen mellem ejendomsmægleren og systemet, og hvordan forskellige funktioner udføres gennem beskeder, der sendes frem og tilbage.

På venstre side har vi ejendomsmægleren, som sender forespørgsler til systemet, der er placeret på højre side. Hver handling, ejendomsmægleren udfører, sendes som en besked til systemet, og systemet svarer tilbage med en bekræftelse eller de ønskede data.

![SSD](https://github.com/user-attachments/assets/4c78ef6e-2b71-4759-b868-3c5fccaef4e9)

## EERD
![EERD v1](https://github.com/user-attachments/assets/09451405-cabd-45e0-a73a-1b1e03f85ff3)

## Mapning
![image](https://github.com/user-attachments/assets/b0e7b4db-7585-4866-8612-5f040bb47fc0)
