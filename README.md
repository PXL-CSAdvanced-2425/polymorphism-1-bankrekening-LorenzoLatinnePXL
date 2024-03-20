# Bankrekening

Een bank biedt de klanten 2 typen rekeningen aan: een gewone
zichtrekening en een spaarrekening. Deze twee typen rekeningen bieden
voor een deel dezelfde faciliteiten, maar er zijn ook verschillen. De
gemeenschappelijke faciliteiten zijn:

-   naam en adres vastleggen;

-   een rekening met een beginsaldo openen;

-   een overzicht van het huidige saldo bijhouden en laten zien;

-   methoden om een geldbedrag te storten en op te nemen.

De zichtrekening kan niet in het rood staan in tegenstelling tot de
spaarrekening. De rente voor een zichtrekening bedraagt 0,5% en voor een
spaarrekening 1,5%. Voor een spaarrekening wordt jaarlijks beheerskosten
van €100,00 aangerekend.

***Bankrekening***

![Afbeelding met tekst, schermopname, nummer, Lettertype Automatisch
gegenereerde
beschrijving](./media/image1.png)

-   *TxtBedrag*: bij een positief bedrag wordt het bedrag op beide
    rekeningen gestort, bij een negatief bedrag wordt het bedrag bij
    beide rekeningen afgenomen.

-   *BtnSaldo*: geeft het saldo weer van de zichtrekening en
    spaarrekening.

-   *BtnRente*: geeft de rente weer van de zichtrekening en
    spaarrekening.

-   *BtnSluiten*: sluit de toepassing.

Maak voor deze toepassing een ***abstracte klasse*** ***Bankrekening***
en 2 afgeleide klassen: ***Spaarrekening*** en ***Zichtrekening***.

![Afbeelding met tekst, schermopname, Lettertype, nummer Automatisch
gegenereerde
beschrijving](./media/image2.png)

-   De klasse ***Bankrekening*** bevat de volgende methoden:

    -   Constructor *Bankrekening*(double opening, string name, string
        address).

    -   *BerekenRente()* dat het over te erven method omschrijft.

    -   *CreditSaldo* bepaalt het saldo over nul en geeft het aan
        *HuidigSaldo*.

    -   *DebetSaldo* bepaalt het positief saldo en geeft het aan
        *HuidigSaldo*.

-   De klasse ***Spaarrekening*** bevat de methoden:

    -   *BerekenRente()* berekent de rente van de spaarrekening*.*

    -   *Constructor* Spaarrekening*.*

-   De klasse ***Zichtrekening*** bevat de methoden:

    -   *BerekenRente()* berekent de rente van de spaarrekening.

    -   *Constructor* Zichtrekening.

    -   *CreditSaldo()* test of het saldo ontoereikend is en genereert
        een exception van de klasse *BankException.*

-   De klasse ***BankException*** bevat de constructor.
