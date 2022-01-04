var __extends = (this && this.__extends) || (function () {
    var extendStatics = Object.setPrototypeOf ||
        ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
        function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var Ev = /** @class */ (function () {
    function Ev(odaSayisi, pencereSayisi, kat) {
        this.odaSayisi = odaSayisi;
        this.kat = kat;
        this.pencereSayisi = pencereSayisi;
    }
    Ev.prototype.yemekYe = function () {
        console.log(this.kat + "katlı evde " + "yemek yiyildi");
    };
    return Ev;
}());
var ev = new Ev(3, 4, 5);
ev.yemekYe();
console.log(ev.kat);
var Kisi = /** @class */ (function () {
    function Kisi() {
    }
    Object.defineProperty(Kisi.prototype, "isim", {
        get: function () {
            return "Sayın : " + this._isim;
        },
        set: function (ad) {
            this._isim = ad;
        },
        enumerable: true,
        configurable: true
    });
    Kisi.prototype.kaydet = function () {
        console.log("Kişi kaydedildi");
    };
    return Kisi;
}());
var Musteri = /** @class */ (function (_super) {
    __extends(Musteri, _super);
    function Musteri() {
        return _super !== null && _super.apply(this, arguments) || this;
    }
    Musteri.prototype.satisYap = function () {
        console.log("Satış yapıldı");
    };
    return Musteri;
}(Kisi));
var Personel = /** @class */ (function (_super) {
    __extends(Personel, _super);
    function Personel() {
        return _super !== null && _super.apply(this, arguments) || this;
    }
    Personel.prototype.maasOde = function () {
        console.log("Maaş ödendi");
    };
    return Personel;
}(Kisi));
var musteri = new Musteri();
musteri.isim = "Engin";
console.log(musteri.isim);
musteri.kaydet();
musteri.satisYap();
var personel = new Personel();
personel.kaydet();
personel.maasOde();
