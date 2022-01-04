abstract class KrediBase {
    constructor() {

    }

    kaydet(): void {
        console.log("Kaydedildi")
    }

    abstract hesapla(): void
}

class TuketiciKredi extends KrediBase {
    constructor() {
        super()
    }

    hesapla(): void {
        console.log("Tüketici kredisine göre hesap yapıldı")
    }
}

class MortgageKredi extends KrediBase {
    constructor() {
        super()
    }

    hesapla(): void {
        console.log("Mortgage kredisine göre hesap yapıldı")
    }

    mortgageKredisineOzel(): void {
        console.log("Mortgage kredisine ozel")
    }
}

let tuketiciKredisi = new TuketiciKredi()
tuketiciKredisi.hesapla()
tuketiciKredisi.kaydet()

let mortgageKredisi = new MortgageKredi()
mortgageKredisi.hesapla()
mortgageKredisi.kaydet()
mortgageKredisi.mortgageKredisineOzel()

let kredi : KrediBase
kredi = new TuketiciKredi()
kredi = new MortgageKredi()

