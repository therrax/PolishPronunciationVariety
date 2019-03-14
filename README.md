# PolishPronunciationVariety

## Instalacja

[Link do nuget.org ](https://www.nuget.org/packages/PolishPronunciationVariety/)

```
dotnet add package PolishPronunciationVariety --version 1.0.0
```


## Metody rozszerzające

Metoda  |   Opis    |   Zwracany typ
--- | --- | ---
GetCityLocative() | Pobiera miejscownik miasta  | string


##### Przykład użycia
```
var city = "Kołobrzeg";
var wordVariety = city.GetCityLocative();
Console.WriteLine(wordVariety);
//Rezultat:  "Kołobrzegu"
```

## ToDo

- [] Testy jednostkowe