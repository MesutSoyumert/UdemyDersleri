function selamVer(isim: string) {
    return "Merhaba " + isim;
}

let mesaj = selamVer("Mesut");

console.log(mesaj)

let sayi: number = 12
sayi = 10
sayi = 10.4
// sayi = "Ankara" atama yapılamaz

let sehir: string = "Adana"
sehir = "Ankara"
sehir = "İstanbul"
// sehir = 10 atama yapılamaz

let dogruMu: boolean = true
dogruMu = true
dogruMu = false

let sayilar: number[] = [1, 2, 3]

let sayilar2: Array<number> = [1, 2, 3]

let dizi: [number, string] = [2, "Ankara"]
let sayiNumeric: number = dizi[0]
let charString: string = dizi[1]

enum Renk { Kırmızı = 1, Siyah, Mavi }
let renk: Renk = Renk.Kırmızı

let deger: any = "Ankara"
deger = 2
deger = {}

let deger2: void = undefined

function selamVer2(): void {
    console.log("Merhaba void")
}
selamVer2()


// undefined null
let yas : number
yas = 10

