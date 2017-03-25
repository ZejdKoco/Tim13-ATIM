## Tim13-ATIM

### **MEDICA**
Clanovi Tima:

  1. Koco Zejd        
  2. Karsic Amila        
  3. Japalak Amila


## **Opis teme**

Cilj projekta je napraviti sistem za apoteku koji će omogućavati mušterijama da, pored klasične kupovine lijekova kod prodavača, mogu naručivati lijekove s računa koji su otvorili u samoj apoteci. Ovo naručivanje se vrši online, te je moguća i sama dostava lijekova. Do ove potrebe je došlo nakon zaključka da dosta osoba nerijetko koristi proizvode apoteke, te je namjera da se olakša interakcija mušterije (korisnika) i prodavača. Također, ovaj sistem će olakšati mnogim osobama iz razloga što je moguća dostava na kućnu adresu. Sistem omogućava i unošenje, ažuriranje  i brisanje proizvoda, tako da je u svakom trenutku moguć uvid da li je neki lijek na stanju ili nije, te ako nije, mogućnost da se naznači potreba istog.

--- 

## **Procesi**

**Registracija korisnika**

Osobe koje nemaju account i račun, registraciju mogu izvršiti popunjavanjem formulara s najvažnijim podacima. Identifikacijski broj se dobija tek nakon što se izvrši uplata određene svote novca na račun, u suprotnom nije moguće naručivanje proizvoda preko sistema. 

**Prijava korisnika u sistem i ažiriranje**

Proces počinje klikom na dugme prijava. Osobe koje imaju account se mogu logovati unoseći korisničko ime i lozinku. Nakon što je korisnik pristupio sistemu, može izvršiti ažuriranje nekih svojih podataka, kao npr. trenutnu adresu boravišta.

**Prijava prodavača, menadžera i dostavljača u sistem**

Prijava istih se vrši samo unošenjem odredenog identifikacijskog broja, nakon čega se vrši provjera postojanja istog. Ukoliko postoji, otvara se jedna od tri moguće stranice (forme), u zavisnosti od uloge koju osoba obavlja.

**Naručivanje proizvoda**

Nakon uspješnog logovanja u sistem, korisnik ima mogućnost naručivanja artikla koji želi. Vrše se provjere da li je proizvod na stanju i da li mušterija na računu ima dovoljnu svotu, te se obavještava ili da je proizvod uspiješno naručen ili da nema dovoljno novca. 

**Kupovina proizvoda**

Postoji i standardni način kupovine proizvoda, na šalteru, gdje prodavač bilježi koji je artikl prodan te vrši predaju istog. Nakon što se prodavač loguje u sistem ima mogućnost uvida koliko ima zaliha nekog proizvoda i obračunavanje popusta (uz recept).

**Dodavanje, ažuriranje i brisanje proizvoda**

Ove procese mogu izvršiti jedino osobe sa statusom menadžera. Nakon izvršavanja nekog od ovih procesa, promjene ostaju trajno zabilježene.

**Dodavanje, ažuriranje i brisanje uposlenika**

Ove procese, također, mogu izvršiti jedino osobe sa statusom menadžera. Ukoliko se izvrši brisanje uposlenika, taj uposlenik više ne može pristupiti sistemu s ulogom uposlenika.

**Dostava proizvoda**

Nakon što korisnik u sistemu naruči neki proizvod, moguća je dostava na kućnu adresu. Dostavljač, pristupanjem svom sistemu, ima sve potrebne podatke (ime mušterije, naziv proizvoda, količina, adresa i sl.) za mogućnost uspješnog dostavljanja proizvoda.

**Poništavanje narudžbe**

Nakon izvršene narudžbe proizvoda, moguće je i poništavanje narudžbe sve dok dostavljač ne zabilježi da je izvršio dostavu proizvoda.

---

## **Funkcionalnosti**

* Unos, ažuriranje i brisanje proizvoda
* Unos, ažuriranje i brisanje uposlenika
* Unos i ažuriranje korisnika
* Mogućnost dostave proizvoda
* Mogućnost obračuna popusta uz recept
* Mogućnost uvida u stanje robe
* Mogućnost poništavanja narudžbe

---

## **Akteri**

**Mušterija** - Osoba koja popunjava narudžbe i naručuje proizvode. Mora imati account i broj računa i taj novac koristi za plačanje naručenih proizvoda. Mušterija može poništiti narudžbu sve dok dostavljač ne izvrši dostavu. Ima mogućnost da mu se dostavi lijek ili da ga on sam preuzme. Ima mogućnost ažuriranja vlastitih podataka.

**Prodavač** - Prodaje proizvode. Može ih prodavati ljudima s karticom (tj. mušterijama koje imaju accounte), a može i osobama bez accounta. Popust uz recept se može izvršiti samo kod prodavača.

**Menadžer** - Ima mogućnost unosa, brisanja i ažuriranja proizvoda, radnika, te vrši unos korisnika u sistem.

**Dostavljač** - Osoba koja prima proizvode koje treba dostaviti, sa svim potrebnim specifikacijama (tipa gdje treba dostaviti) te bilježi dostavljene proizvode.
