class Personel {
  constructor(ad, soyad) {
    this.ad = ad;
    this.soyad = soyad;
  }

  kaydet() {
    console.log(`Personel kaydedildi : ${this.ad}`);
  }
}

const personel = new Personel("Mesut", "Soyumert");

personel.kaydet();

// personel.adi = "Mesut"
// console.log(personel.ad + personel.soyad);
