# PolishPronunciationVariety

## O paczce

Na potrzeby własnego projektu, stworzyłem paczkę, którą chce się z Wami podzielić. Dzięki tej paczce odmienisz nazwę polskiej miejscowości, w moim przypadku przydała mi się do pozycjonowania serwisu.
Zachęcam również do rozbudowy paczki :)

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
## Zgłaszanie miejscowości lub
## ToDo

- [ ] Testy jednostkowe