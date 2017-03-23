## Tim13-ATIM

### **MEDICA**
Clanovi Tima:

  1. Koco Zejd        
  2. Karsic Amila        
  3. Japalak Amila


##**Opis teme**

Cilj projekta je napraviti sistem za apoteku koji ce omogucavati mušterijama da, pored klasicne kupovine lijekova kod prodavaca, mogu narucivati lijekove s racuna koji su otvorili u samoj apoteci. Ovo narucivanje se vrši online, te je moguca i sama dostava lijekova. Do ove potrebe je došlo nakon zakljucka da dosta osoba nerijetko koristi proizvode apoteke, te je namjera da se olakša interakcija mušterije (korisnika) i prodavaca. Takoder ovaj sistem ce olakšati mnogim osobama iz razloga što je moguca dostava na kucnu adresu. Sistem omogucava i unošenje, ažuriranje  i brisanje proizvoda, tako da je u svakom trenutku moguc uvid da li je neki lijek na stanju ili nije, te ako nije mogucnost da se naznaci potreba istog. 

##**Procesi**

#Registracija korisnika

Osobe koje nemaju account i racun, registraciju mogu izvršiti popunjavanjem formulara s najvažnijim podacima. Identifikacijski broj se dobija tek nakon što se izvrši uplata odredene svote novca na racun, u suprotnom nije moguce narucivanje proizvoda preko sistema. 

#Prijava korisnika u sistem i ažiriranje

Proces pocinje klikom na dugme prijava. Osobe koje imaju account se mogu logovati unoseci korisnicko ime i lozinku. Nakon što je korisnik pristupio sistemu, može izvršiti ažuriranje nekih svojih podataka, kao npr. trenutnu adresu boravišta.

#Prijava prodavaca, menadžera i dostavljaca u sistem

Prijava istih se vrši samo unošenjem odredenog identifikacijskog broja, nakon cega se vrši provjera postojanja istog. Ukoliko postoji, otvara se jedna od tri moguce stranice, u zavisnosti od uloge koju osoba obavlja.

#Narucivanje proizvoda

Nakon uspješnog logovanja u sistem, korisnik ima mogucnost narucivanja artikla koji želi. Korisnik takoder ima mogucnost da vidi da li je artikal na stanju, te ukoliko jeste, može naruciti isti. Nakon toga se vrši provjera da li mušterija na racunu ima dovoljnu svotu, te se obavještava ili da je proizvod uspiješno narucen ili da nema dovoljno novca. Ukoliko proizvod nije na stanju, moguce je zahtijevanje njegove nabavke.

#Kupovina proizvoda

Postoji i standardni nacin kupovine proizvoda, na šalteru, gdje prodavac bilježi koji je artikl prodan te vrši predaju istog. Nakon što se prodavac loguje u sistem ima mogucnost uvida koliko ima zaliha nekog proizvoda i obracunavanje popusta (uz recept).

#Dodavanje, ažuriranje i brisanje proizvoda

Ove procese mogu izvršiti jedino osobe sa statusom menadžera. Nakon izvršavanja nekog od ovih procesa, promjene ostaju trajno zabilježene.

#Dodavanje, ažuriranje i brisanje uposlenika

Ove procese, takoder, mogu izvršiti jedino osobe sa statusom menadžera. Ukoliko se izvrši brisanje uposlenika, taj uposlenik više ne može pristupiti sistemu s ulogom uposlenika.

#Dostava proizvoda

Nakon što korisnik u sistemu naruci neki proizvod, moguca je dostava na kucnu adresu. Dostavljac, pristupanjem svom sistemu, ima sve potrebne podatke (ime mušterije, naziv proizvoda, kolicina, adresa i sl.) za mogucnost uspješnog dostavljanja proizvoda.

#Poništavanje narudžbe

Nakon izvršene narudžbe proizvoda, moguce je i poništavanje narudžbe sve dok dostavljac ne zabilježi da je izvršio dostavu proizvoda.

##**Funkcionalnosti**

* Unos, ažuriranje i brisanje proizvoda
* Unos, ažuriranje i brisanje uposlenika
* Unos i ažuriranje korisnika
* Mogucnost dostave proizvoda
* Mogucnost obracuna popusta uz recept
* Mogucnost uvida u stanje robe
* Mogucnost poništavanja narudžbe

##**Akteri**

*Mušterija - Osoba koja popunjava narudžbe i narucuje proizvode. Mora imati account i broj racuna i taj novac koristi za placanje narucenih proizvoda. Mušterija može poništiti narudžbu sve dok dostavljac ne izvrši dostavu. Ima mogucnost da mu se dostavi
lijek ili da ga on sam preuzme. Ima mogucnost ažuriranja vlastitih podataka.
*Prodavac - Prodaje proizvode. Može ih prodavati ljudima s karticom (tj. mušterijama koje imaju accounte), a može i osobama bez accounta. Popust uz recept se može izvršiti samo kod prodavaca.
*Menadžer - Ima mogucnost unosa, brisanja i ažuriranja proizvoda, radnika, te vrši unos korisnika u sistem.
*Dostavljac - osoba koja prima proizvode koje treba dostaviti, sa svim potrebnim specifikacijama (tipa gdje treba dostaviti) te bilježi dostavljene proizvode.