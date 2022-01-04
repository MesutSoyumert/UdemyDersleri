function save(product) {
    console.log(product.name + " kaydedildi");
}
var Product2 = /** @class */ (function () {
    function Product2() {
    }
    return Product2;
}());
function save2(product) {
    console.log(product.name + " kaydedildi");
}
save({ id: 1, name: "Laptop", unitPrice: 5000 });
var mouse = new Product2();
mouse.name = "ATech";
save2(mouse);
var CustomerService = /** @class */ (function () {
    function CustomerService() {
    }
    CustomerService.prototype.save = function () {
        throw new Error("Method not implemented.");
    };
    return CustomerService;
}());
