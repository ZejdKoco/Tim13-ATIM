## Tim13-ATIM

### **MEDICA**
Clanovi Tima:

  1. Koco Zejd        
  2. Karsic Amila        
  3. Japalak Amila


##**Opis teme**

Cilj projekta je napraviti sistem za apoteku koji ce omogucavati mu�terijama da, pored klasicne kupovine lijekova kod prodavaca, mogu narucivati lijekove s racuna koji su otvorili u samoj apoteci. Ovo narucivanje se vr�i online, te je moguca i sama dostava lijekova. Do ove potrebe je do�lo nakon zakljucka da dosta osoba nerijetko koristi proizvode apoteke, te je namjera da se olak�a interakcija mu�terije (korisnika) i prodavaca. Takoder ovaj sistem ce olak�ati mnogim osobama iz razloga �to je moguca dostava na kucnu adresu. Sistem omogucava i uno�enje, a�uriranje  i brisanje proizvoda, tako da je u svakom trenutku moguc uvid da li je neki lijek na stanju ili nije, te ako nije mogucnost da se naznaci potreba istog. 

##**Procesi**

#Registracija korisnika

Osobe koje nemaju account i racun, registraciju mogu izvr�iti popunjavanjem formulara s najva�nijim podacima. Identifikacijski broj se dobija tek nakon �to se izvr�i uplata odredene svote novca na racun, u suprotnom nije moguce narucivanje proizvoda preko sistema. 

#Prijava korisnika u sistem i a�iriranje

Proces pocinje klikom na dugme prijava. Osobe koje imaju account se mogu logovati unoseci korisnicko ime i lozinku. Nakon �to je korisnik pristupio sistemu, mo�e izvr�iti a�uriranje nekih svojih podataka, kao npr. trenutnu adresu boravi�ta.

#Prijava prodavaca, menad�era i dostavljaca u sistem

Prijava istih se vr�i samo uno�enjem odredenog identifikacijskog broja, nakon cega se vr�i provjera postojanja istog. Ukoliko postoji, otvara se jedna od tri moguce stranice, u zavisnosti od uloge koju osoba obavlja.

#Narucivanje proizvoda

Nakon uspje�nog logovanja u sistem, korisnik ima mogucnost narucivanja artikla koji �eli. Korisnik takoder ima mogucnost da vidi da li je artikal na stanju, te ukoliko jeste, mo�e naruciti isti. Nakon toga se vr�i provjera da li mu�terija na racunu ima dovoljnu svotu, te se obavje�tava ili da je proizvod uspije�no narucen ili da nema dovoljno novca. Ukoliko proizvod nije na stanju, moguce je zahtijevanje njegove nabavke.

#Kupovina proizvoda

Postoji i standardni nacin kupovine proizvoda, na �alteru, gdje prodavac bilje�i koji je artikl prodan te vr�i predaju istog. Nakon �to se prodavac loguje u sistem ima mogucnost uvida koliko ima zaliha nekog proizvoda i obracunavanje popusta (uz recept).

#Dodavanje, a�uriranje i brisanje proizvoda

Ove procese mogu izvr�iti jedino osobe sa statusom menad�era. Nakon izvr�avanja nekog od ovih procesa, promjene ostaju trajno zabilje�ene.

#Dodavanje, a�uriranje i brisanje uposlenika

Ove procese, takoder, mogu izvr�iti jedino osobe sa statusom menad�era. Ukoliko se izvr�i brisanje uposlenika, taj uposlenik vi�e ne mo�e pristupiti sistemu s ulogom uposlenika.

#Dostava proizvoda

Nakon �to korisnik u sistemu naruci neki proizvod, moguca je dostava na kucnu adresu. Dostavljac, pristupanjem svom sistemu, ima sve potrebne podatke (ime mu�terije, naziv proizvoda, kolicina, adresa i sl.) za mogucnost uspje�nog dostavljanja proizvoda.

#Poni�tavanje narud�be

Nakon izvr�ene narud�be proizvoda, moguce je i poni�tavanje narud�be sve dok dostavljac ne zabilje�i da je izvr�io dostavu proizvoda.

##**Funkcionalnosti**

* Unos, a�uriranje i brisanje proizvoda
* Unos, a�uriranje i brisanje uposlenika
* Unos i a�uriranje korisnika
* Mogucnost dostave proizvoda
* Mogucnost obracuna popusta uz recept
* Mogucnost uvida u stanje robe
* Mogucnost poni�tavanja narud�be

##**Akteri**

*Mu�terija - Osoba koja popunjava narud�be i narucuje proizvode. Mora imati account i broj racuna i taj novac koristi za placanje narucenih proizvoda. Mu�terija mo�e poni�titi narud�bu sve dok dostavljac ne izvr�i dostavu. Ima mogucnost da mu se dostavi
lijek ili da ga on sam preuzme. Ima mogucnost a�uriranja vlastitih podataka.
*Prodavac - Prodaje proizvode. Mo�e ih prodavati ljudima s karticom (tj. mu�terijama koje imaju accounte), a mo�e i osobama bez accounta. Popust uz recept se mo�e izvr�iti samo kod prodavaca.
*Menad�er - Ima mogucnost unosa, brisanja i a�uriranja proizvoda, radnika, te vr�i unos korisnika u sistem.
*Dostavljac - osoba koja prima proizvode koje treba dostaviti, sa svim potrebnim specifikacijama (tipa gdje treba dostaviti) te bilje�i dostavljene proizvode.