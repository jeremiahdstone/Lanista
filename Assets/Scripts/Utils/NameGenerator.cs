using UnityEngine;

// randomly creates a roman name using historically accurate roman names (they had 3, first, family, and nickname)
public static class NameGenerator
{
    //sets up the arrays of all the different types of names
    static string[] praenomina = new string[] {
        "Appius", "Aulus", "Caeso", "Caius", "Cnaeus", "Decimus", "Faustus", "Gaius", "Lucius",
        "Manius", "Marcus", "Nonus", "Publius", "Quintus", "Septimus",
        "Servius", "Sextus", "Spurius", "Tiberius", "Titus", "Tullus", "Agrippa"
    };

    static string[] nomina = new string[] {
        "Aelius", "Aemilius", "Antonius", "Atilius", "Aurelius", "Avilius", "Balbus", "Blasius",
        "Caecilius", "Caelinus", "Caelius", "Caesonius", "Calpurnius", "Cassius", "Claudius",
        "Cloelius", "Cornelius", "Domitius", "Duilius", "Egnatius", "Ennius", "Fabianus", "Fabius",
        "Fabricius", "Flaminius", "Flavius", "Fulvius", "Helvius", "Horatius", "Iulius", "Julius",
        "Lucilius", "Lucretius", "Manlius", "Marcius", "Marius", "Pompeius", "Quinctilius", "Quinctius",
        "Sergius", "Septimius", "Tullius", "Valerius", "Vergilius", "Verginius", "Vinicius"
    };

    static string[] cognomina = new string[] {
        "Aelianus", "Aemilianus", "Aetius", "Africanus", "Agrippa", "Ahenobarbus", "Albanus",
        "Albinus", "Albus", "Antoninus", "Aquila", "Aquilinus", "Augustinus", "Augustus",
        "Aurelianus", "Avitus", "Balbinus", "Blandinus", "Blandus", "Brutus", "Caesar",
        "Calvus", "Camillus", "Caracalla", "Cassianus", "Cato", "Celsus", "Cicero", "Crispinus",
        "Crispus", "Cyprianus", "Diadumenianus", "Diocletianus", "Domitianus", "Drusus", "Faustinus",
        "Faustus", "Felix", "Festus", "Flavianus", "Florianus", "Florus", "Germanicus", "Germanus",
        "Lepidus", "Longinus", "Lucianus", "Maximus", "Nero", "Rufus", "Scipio", "Seneca",
        "Tacitus", "Valens", "Valentinianus", "Valentinus", "Valerianus", "Vespasianus", "Vitus"
    };

    public static string generateName()
    {
        //randomly selects a first name, family name, and nickname from the arrays
        string firstName = praenomina[Random.Range(praenomina.Length)];
        string familyName = nomina[Random.Range(nomina.Length)];
        string nickname = cognomina[Random.Range(cognomina.Length)];

        //returns the full name
        return firstName + " " + familyName + " " + nickname;
    }

}
