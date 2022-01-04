function deger(x) {
    return x;
}
function deger2(x) {
    return x;
}
var sayi = deger(10);
console.log(sayi);
var sehir = deger2("Ankara");
console.log(sehir);
function deger3(x) {
    return x;
}
var sayi3 = deger3(2);
var sehir3 = deger3("İzmir");
console.log(sayi3);
console.log(sehir3);
var GenericClass = /** @class */ (function () {
    function GenericClass() {
    }
    GenericClass.prototype["function"] = function (parametre) {
        return parametre;
    };
    return GenericClass;
}());
var sinif = new GenericClass();
sinif["function"](3);
var sinifS = new GenericClass();
sinifS["function"]("İzmir");
