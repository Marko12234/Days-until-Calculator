# Days-until-Calculator

A C# console app that tells you how many days are left until a date 
you enter — or until your next birthday.

## How it works

Run it and pick from the menu:

```
=== Days Until Calculator ===

1 - Tage bis zu einem Datum
2 - Tage bis zum nächsten Geburtstag
0 - Beenden
```

Enter a date in `dd.MM.yyyy` format and it calculates the days left. 
For birthdays, it automatically rolls over to next year if your 
birthday already passed this year.

## Requirements

.NET 8.0

## Run it

```bash
git clone https://github.com/Marko12234/Days-until-Calculator.git
cd Days-until-Calculator
dotnet run
```
