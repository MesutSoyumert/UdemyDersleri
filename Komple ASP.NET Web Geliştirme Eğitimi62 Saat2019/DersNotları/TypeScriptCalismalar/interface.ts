interface Product {
    id: number
    name: string
    unitPrice: number


}

function save(product: Product) {
    console.log(product.name + " kaydedildi")
}


class Product2 {
    id: number
    name: string
    unitPrice: number
}

function save2(product: Product2) {
    console.log(product.name + " kaydedildi")
}
save({ id: 1, name: "Laptop", unitPrice: 5000 })

let mouse = new Product2()
mouse.name = "ATech"
save2(mouse)

interface IPersonService {
    save();
}

class CustomerService implements IPersonService {
    save() {
        throw new Error("Method not implemented.")
    }
}