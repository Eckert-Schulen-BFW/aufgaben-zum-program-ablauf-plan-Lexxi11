// ============================================================
//  Aufgabe: Programmablaufplan – BMI-Rechner
//  Fach:    C# Grundlagen
//  Name:    [DEIN NAME HIER]
//  Datum:   [DATUM HIER]
// ============================================================
//
// AUFGABE 1 – Beantworte folgende Fragen hier als Kommentar:
//
// Frage 1: Wie viele Entscheidungsknoten (Rauten) hat der PAP?
// Antwort: 6 Entscheidungsknoten (Rauten)
//
// Frage 2: Unter welchen Bedingungen endet das Programm frühzeitig?
// Antwort: Das Programm endet frühzeitig, wenn die Eingabe für Gewicht oder Größe ungültig ist (z.B. kein gültiger Double-Wert) oder wenn die eingegebene Größe kleiner oder gleich 0 ist. In diesen Fällen wird eine Fehlermeldung ausgegeben und das Programm mit "return" beendet.
//
// Frage 3: Warum wird TryParse statt Convert.ToDouble() verwendet?
// Antwort: Weil TryParse eine sichere Methode ist, um Benutzereingaben in Zahlen umzuwandeln. Es gibt keine Ausnahme (Exception) aus, wenn die Eingabe ungültig ist, sondern liefert einfach "false" zurück. Dadurch können wir die Eingabe validieren und bei ungültigen Daten eine Fehlermeldung ausgeben, ohne dass das Programm abstürzt. Im Gegensatz dazu würde Convert.ToDouble() eine Ausnahme werfen, wenn die Eingabe nicht in eine Zahl umgewandelt werden kann, was zu einem unerwarteten Programmabsturz führen könnte.
//
// Frage 4: Welchen Datentyp sollen gewicht und groesse haben, und warum?
// Antwort: Double, weil Gewicht und Größe Dezimalzahlen sein können (z.B. 70.5 kg oder 1.75 m). Der Double-Datentyp ermöglicht die Speicherung von Fließkommazahlen mit ausreichender Genauigkeit für diese Werte.
//
// ============================================================

// TODO: Schreibe dein Programm unterhalb dieser Zeile.
//       Orientiere dich dabei am PAP in der README.md.
//       Jeder Schritt im PAP sollte einer Zeile / einem Block in deinem Code entsprechen.

// ── Schritt 1: Programmtitel ausgeben ───────────────────────
// Tipp: Nutze Console.WriteLine() für die Titelbox.
// TODO: Ausgabe der Titelzeile (wie im Beispiel in der README)


// ── Schritt 2: Eingabe – Name ────────────────────────────────
// TODO: Benutzernamen einlesen (string, kein TryParse nötig)


// ── Schritt 3: Eingabe – Gewicht mit Validierung ─────────────
// TODO: Gewicht als Text einlesen
// TODO: Mit double.TryParse() in eine Zahl umwandeln
// TODO: Falls ungültig → Fehlermeldung ausgeben und Programm beenden (return)


// ── Schritt 4: Eingabe – Größe mit Validierung ───────────────
// TODO: Körpergröße als Text einlesen
// TODO: Mit double.TryParse() in eine Zahl umwandeln
// TODO: Falls ungültig → Fehlermeldung ausgeben und Programm beenden (return)
// TODO: Zusätzlich prüfen: Ist die Größe größer als 0?
//       Falls nicht → eigene Fehlermeldung und Programm beenden (return)


// ── Schritt 5: BMI berechnen ─────────────────────────────────
// Formel: BMI = Gewicht / (Größe * Größe)
// TODO: BMI berechnen und in einer Variablen speichern


// ── Schritt 6: Kategorie bestimmen ───────────────────────────
// TODO: Erstelle eine string-Variable "kategorie"
// TODO: Bestimme die Kategorie über eine if-else-if-Kette:
//       BMI < 18.5        → "Untergewicht"
//       BMI < 25.0        → "Normalgewicht"
//       BMI < 30.0        → "Übergewicht"
//       sonst (else)      → "Starkes Übergewicht"
//
// 💭 Denkfrage: Warum reicht bei "Normalgewicht" die Bedingung BMI < 25.0 aus,
//               obwohl laut WHO-Tabelle auch BMI >= 18.5 gelten muss?


// ── Schritt 7: Ergebnis ausgeben ─────────────────────────────
// TODO: Gib Name, BMI (auf 2 Dezimalstellen) und Kategorie formatiert aus
// Tipp: Nutze z.B. $"{bmi:F2}" für 2 Nachkommastellen

using System;
class Program
{
    static void Main(string[] args)
    {

Console.WriteLine("BMI-Rechner v1.0");
Console.WriteLine();

Console.WriteLine("Bitte gib deinen Namen ein: ");
string name = Console.ReadLine();

Console.WriteLine("Bitte gib dein Gewicht in KG ein: ");
string gewichtText = Console.ReadLine();
if (!double.TryParse(gewichtText, out double gewicht))
{
    Console.WriteLine("Ungültige Eingabe für Gewicht. Bitte eine Zahl eingeben.");
    return;
}
Console.WriteLine("Bitte gib deine Körpergröße in Metern ein: ");
string groesseText = Console.ReadLine();
if (!double.TryParse(groesseText, out double groesse))
{
    Console.WriteLine("Ungültige Eingabe für Körpergröße. Bitte eine Zahl eingeben.");
    return;
}
if (groesse <=0)
{
    Console.WriteLine("Ungültige Eingabe für Körpergröße. Die Größe muss größer als 0 sein.");
    return;
}
double bmi = gewicht / (groesse * groesse);
string kategorie;
if (bmi < 18.5)
{
    kategorie = "Untergewicht";
}
else if (bmi < 25.0)
{
    kategorie = "Normalgewicht";
}
else if (bmi < 30.0)
{
    kategorie = "Übergewicht";
}
else
{
    kategorie = "Starkes Übergewicht";
}
Console.WriteLine();
Console.WriteLine($"Ergebnis für {name}");
Console.WriteLine($"BMI: {bmi:F2}");
Console.WriteLine($"Kategore: {kategorie}");
        }
}



