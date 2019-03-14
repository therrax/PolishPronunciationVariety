# PolishPronunciationVariety

## O paczce

Na potrzeby własnego projektu stworzyłem paczkę, którą chce się z Wami podzielić. Dzięki tej paczce odmienisz nazwę polskiej miejscowości na miejscownik (z mianownika), w moim przypadku przydała mi się do pozycjonowania serwisu.
Zachęcam również do rozbudowy paczki :)

## Instalacja

[Link strony paczki ](https://www.nuget.org/packages/PolishPronunciationVariety/)

```
dotnet add package PolishPronunciationVariety --version 1.0.1
```

## Metody rozszerzające

Metoda  |   Parametry   |   Opis    |   Zwracany typ
--- | --- | ---
GetLocative() |  | Zamienia mianownik na miejscownik  | string
GetLocative() | GrammaticalCase case  | Zamienia mianownik na wskazany przypadek (dziala tylko miejscownik)  | GrammaticalResult

##### Przykład użycia
```
var city = "Kołobrzeg";
var wordVariety = city.GetLocative();
Console.WriteLine(wordVariety);
//Rezultat:  "Kołobrzegu"
```

## GrammaticalCase
##### Mianownik
```
Nominative = 0,
```
##### Dopełniacz
```
Genitive = 1,
```
##### Celownik
```
Dative = 2,
```
##### Biernik
```
Accusative = 3,
```
##### Nadrzędnik
```
Instrumental = 4,
```
##### Miejscownik
```
Locative = 5,
```
##### Wołacz
```
Vocative = 6
```

## Zgłaszanie błędów i brakujących nazw

Proszę o zgłaszanie błędów i nazw miejscowości, które nie zostały rozpoznane.
Razem możemy więcej :)

## Done

- [x] Testy jednostkowe

## ToDo

- [ ] Kolejne przypadki

## Zmiany

v1.0.1 - Rule builder - miejsce do tworzenia nowych zasad, metody rozpoznające dwa słowa, dodane nowe zasady, uporządkowany kod, usunięcie metody GetCityLocative(), dodany GrammaticalResult, dzięki któremu dowiesz się czy końcówka została rozpoznana - flaga IsUpdated będzie równa true.
v1.0.1 - Świeża wersja, dużo do poprawki