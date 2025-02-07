                                               Projektbeskrivning 

Målet med denna uppgift är att skapa och implementera en fullständig CI/CD-kedja för ett API-projekt i C# med fokus på kryptering och avkryptering. Projektet använder Git Flow och GitHub Actions för att säkerställa effektiv och automatisk hantering av kodändringar, tester och distribution.

Slutligen publiceras och distribueras API:et till AWS Elastic Beanstalk som en del av en kontinuerlig integrering och leverans (CI/CD)-process.
API

- API:et har två endpoints:

* Kryptera
Endpointen tar emot text och returnerar en krypterad version av den. Krypteringsmetoden som används är enkel och säkerheten är inte garanterad (exempel: Rövarspråket eller Caesar-chiffer).

* Avkryptera
Endpointen tar emot en krypterad text och returnerar den ursprungliga texten.

- Min kod genererar ett slumpat "lösenord" som man sedan kan decrypta. 

_______________________________________________________________________________
_______________________________________________________________________________

- Git och Github
  
Projektet använder Git Flow för att strukturera arbetsflödet och säkerställa en välorganiserad hantering av utvecklings- och produktionsgrenar. GitHub används för att hantera kodversionering och för att genomföra pull requests mellan olika grenar.
Branch-struktur:
Main: Produktionsklara versioner av API:et.
Development: Huvudgrenen för utveckling, där alla nya funktioner och bugfixar implementeras.
Feature Branches: Skapade för att arbeta med specifika funktioner eller ändringar, och merges tillbaka till development efter kodgranskning.

- GitHub Actions

Bygger och testar koden varje gång en ny kod pushas till development eller main genom GitHub Actions-pipelines.
CI-pipeline: Kompilerar koden, kör enhetstester och verifierar byggtillståndet.
CD-pipeline: Publiserar API:et till AWS Elastic Beanstalk när en push sker till main.

_______________________________________________________________________________
_______________________________________________________________________________

- Publicering och Distribution

API:et publiceras och distribueras till AWS Elastic Beanstalk genom GitHub Actions. Deployment sker automatiskt när koden mergas in i main-grenen.
Steg för publicering

Bygg och publicera API:et med hjälp av GitHub Actions.
Packa API:et i en .zip-fil.
Distribuera filen till AWS Elastic Beanstalk och starta om miljön.

_______________________________________________________________________________
_______________________________________________________________________________

- Enhetstester

Projektet inkluderar enhetstester för att säkerställa att API:et fungerar som förväntat. GitHub Actions kör automatiskt tester varje gång koden uppdateras, och testar kryptering och avkryptering av text.

För att köra tester lokalt skrivs följande kommando:
dotnet test

_______________________________________________________________________________
_______________________________________________________________________________


- CI/CD Process

För att uppnå en smidig CI/CD-process, används GitHub Actions för både byggning, testning och distribution till AWS. En FigJam-skiss har skapats för att visualisera CI/CD-kedjan för en fullstack-applikation, inklusive branch-struktur och de olika stegen
som utförs vid varje fas av processen.
Skissen beskriver bland annat när byggning, testning och deployment sker.


_______________________________________________________________________________
_______________________________________________________________________________



