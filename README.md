*Adrian Kokot 3D - Zadanie bazodanowe*
# Karta projektu
**Projekt do wykonania:**
Aplikacja bazodanowa, obsługująca format JSON, używająca minimum 5 zapytań dzielących się na: wyświetlające, generujące raport i edytujące dane w bazie.

**Tematyka:** rozkład jazdy pociągów.

**Krótki opis:**
Aplikacja jest podzielona na dwie części:
* *Część "kliencka"* - aplikacja o nazwie RozkladJazdyPociagow-AplikacjaBazodanowa, która zajmuje się wyświetlaniem informacji z bazy,
* *Część "zarządzająca"* – aplikacja o nazwie RJP-EdytorBazyDanych, która zajmuje się edycją informacji w bazie.

**Wykonane zapytania:**
* *Wyszukaj połączenia* – wyświetla połączenia komunikacyjne między podanymi stacjami w danym dniu od podanej godziny,
  * *Generuj raport* - tworzy raport w pliku tekstowym w wyznaczonym miejscu
* *Przebieg pociągu*– wyświetla stacje na podanej trasie danego pociągu,
* *Pociągi na stacji* – wyświetla pociągi na podanej stacji,
* *Pociągi przewoźników* – wyświetla pociągi podanego przewoźnika,
* *Udogodnienia pociągów* – wyświetla udogodnienia w podanym pociąguEdytuj stacje – umożliwia zmianę nazwy podanej stacji,
* *Edytuj pociąg* – umożliwia zmianę nazwy podanego pociągu,
* *Dodaj przejazd* – umożliwia dodanie trasy podanemu pociągowi.

**Struktura bazy danych** – pliki o formacie JSON (.JSON lub .TXT):
* *Companies* – przewoźnicy 
* *Facilities* – udogodnienia w pociągach
* *Stations* – stacje
* *Timetables* – rozkład jazdy – połączenie pociągu ze stacjami 
* *Trainpaths* – stacje ustawione w trasy pociągów
* *Trains* – pociągi
