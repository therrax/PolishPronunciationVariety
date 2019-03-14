# PolishPronunciationVariety

## Instalacja

[Link do nuget.org ](https://www.nuget.org/packages/PolishPronunciationVariety/)

```
dotnet add package PolishPronunciationVariety --version 1.0.0
```


## Metody rozszerzające typ string:

Metoda  |   Opis    |   Zwracany typ
--- | --- | ---
GetCityLocative() | Pobiera miejscownik miasta  | string


##### Example
```
var city = "Kołobrzeg";
var wordVariety = city.GetCityLocative();
Console.WriteLine(wordVariety);
//Rezultat:  "Kołobrzegu"
```

## ToDo

- [x] Testy jednostkowe