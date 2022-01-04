function selamVer(isim) {
    return "Merhaba " + isim;
}
var mesaj = selamVer("Mesut");
console.log(mesaj);
var sayi = 12;
sayi = 10;
sayi = 10.4;
// sayi = "Ankara" atama yapılamaz
var sehir = "Adana";
sehir = "Ankara";
sehir = "İstanbul";
// sehir = 10 atama yapılamaz
var dogruMu = true;
dogruMu = true;
dogruMu = false;
var sayilar = [1, 2, 3];
var sayilar2 = [1, 2, 3];
var dizi = [2, "Ankara"];
var sayiNumeric = dizi[0];
var charString = dizi[1];
var Renk;
(function (Renk) {
    Renk[Renk["K\u0131rm\u0131z\u0131"] = 1] = "K\u0131rm\u0131z\u0131";
    Renk[Renk["Siyah"] = 2] = "Siyah";
    Renk[Renk["Mavi"] = 3] = "Mavi";
})(Renk || (Renk = {}));
var renk = Renk.Kırmızı;
var deger = "Ankara";
deger = 2;
deger = {};
var deger2 = undefined;
function selamVer2() {
    console.log("Merhaba void");
}
selamVer2();
// undefined null
var yas;
yas = 10;
