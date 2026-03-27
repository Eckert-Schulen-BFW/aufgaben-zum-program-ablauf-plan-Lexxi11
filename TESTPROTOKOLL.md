# 🧪 Testprotokoll – BMI-Rechner

**Name:** [DEIN NAME]  
**Datum:** [DATUM]  

---

## Testfälle

Führe alle Testfälle aus und notiere die tatsächliche Ausgabe deines Programms.

### TC-01 – Normalgewicht

| | |
|---|---|
| **Eingabe Name** | Max Mustermann |
| **Eingabe Gewicht** | 70 |
| **Eingabe Größe** | 1.75 |
| **Erwartete Kategorie** | Normalgewicht |
| **Tatsächliche Ausgabe** | *(hier einfügen)* |
| **✅ Bestanden?** | Ja / Nein |

---

### TC-02 – Untergewicht

| | |
|---|---|
| **Eingabe Name** | Lisa Beispiel |
| **Eingabe Gewicht** | 50 |
| **Eingabe Größe** | 1.70 |
| **Erwartete Kategorie** | Untergewicht |
| **Tatsächliche Ausgabe** | *(hier einfügen)* |
| **✅ Bestanden?** | Ja / Nein |

---

### TC-03 – Übergewicht

| | |
|---|---|
| **Eingabe Name** | Tom Tester |
| **Eingabe Gewicht** | 95 |
| **Eingabe Größe** | 1.75 |
| **Erwartete Kategorie** | Übergewicht |
| **Tatsächliche Ausgabe** | *(hier einfügen)* |
| **✅ Bestanden?** | Ja / Nein |

---

### TC-04 – Starkes Übergewicht

| | |
|---|---|
| **Eingabe Name** | Anna Admin |
| **Eingabe Gewicht** | 120 |
| **Eingabe Größe** | 1.75 |
| **Erwartete Kategorie** | Starkes Übergewicht |
| **Tatsächliche Ausgabe** | *(hier einfügen)* |
| **✅ Bestanden?** | Ja / Nein |

---

### TC-05 – Fehlerfall: Ungültiges Gewicht

| | |
|---|---|
| **Eingabe Name** | Fehler-Test |
| **Eingabe Gewicht** | `abc` |
| **Eingabe Größe** | (entfällt) |
| **Erwartet** | Fehlermeldung, Programm endet |
| **Tatsächliche Ausgabe** | *(hier einfügen)* |
| **✅ Bestanden?** | Ja / Nein |

---

### TC-06 – Fehlerfall: Negative Größe

| | |
|---|---|
| **Eingabe Name** | Fehler-Test |
| **Eingabe Gewicht** | 70 |
| **Eingabe Größe** | -1 |
| **Erwartet** | Fehlermeldung (Größe ungültig), Programm endet |
| **Tatsächliche Ausgabe** | *(hier einfügen)* |
| **✅ Bestanden?** | Ja / Nein |

---

## 💭 Reflexionsfragen (Aufgabe 4)

### Frage 1
> Was passiert, wenn jemand `1,75` statt `1.75` als Größe eingibt? Teste es! Wie könnte man das Problem lösen?

**Beobachtung beim Test:**  
*(hier einfügen)*

**Mögliche Lösung:**  
*(hier einfügen)*

---

### Frage 2
> Warum ist die Reihenfolge der `if-else-if`-Bedingungen wichtig? Was würde passieren, wenn du mit `BMI < 30` anfängst?

**Antwort:**  
*(hier einfügen)*

---

### Frage 3
> Der PAP zeigt, dass `groesse > 0` **nach** TryParse geprüft wird. Warum macht diese Reihenfolge Sinn?

**Antwort:**  
*(hier einfügen)*

---

## Zusammenfassung

| Testfall | Bestanden? |
|----------|-----------|
| TC-01 | ⬜ |
| TC-02 | ⬜ |
| TC-03 | ⬜ |
| TC-04 | ⬜ |
| TC-05 | ⬜ |
| TC-06 | ⬜ |

**Bestandene Tests:** ___ / 6
