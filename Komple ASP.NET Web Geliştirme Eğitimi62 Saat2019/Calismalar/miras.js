class Kisi {
  constructor(ad, soyad) {
    this.ad = ad;
    this.soyad = soyad;
  }

  kaydet() {
    console.log(`Kişi kaydedildi : ${this.ad}`);
  }
}

class Personel extends Kisi {
  maasOde() {
    console.log(`Maaş ödendi : ${this.ad}`);
  }
}

class Musteri extends Kisi {
  kuponGonder() {
    console.log(`Kupon gönderildi : ${this.ad}`);
  }
}

const kisi = new Kisi("Engin", "Demiroğ");
const personel = new Personel("Derin", "Demiroğ");
personel.kaydet();
personel.maasOde();
