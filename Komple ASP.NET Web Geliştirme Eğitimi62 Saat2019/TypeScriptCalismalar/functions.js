function topla(x, y) {
    return x + y;
}
function topla2(x, y) {
    return x + y;
}
var topla3 = function (x, y) {
    return x + y;
};
console.log(topla(2, 3));
console.log(topla("Ankara", 2));
console.log(topla2(2, 4));
console.log(topla3(4, 8));
function topla4(x, y) {
    if (y === void 0) { y = 4; }
    return x + y;
}
console.log(topla4(3));
function topla5(x, y) {
    if (y) {
        return x + y;
    }
    return x;
}
console.log(topla5(3, 40));
function davetEt() {
    var digerleri = [];
    for (var _i = 0; _i < arguments.length; _i++) {
        digerleri[_i] = arguments[_i];
    }
    return digerleri.join(" ");
}
console.log(davetEt("Engin", "Derin", "Salih", "Ahmet"));
