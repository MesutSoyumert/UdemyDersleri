var selamFonksiyonu = function selam() {
  console.log("Merhaba");
};

selamFonksiyonu();

const selamFonksiyonu2 = () => {
  console.log("Merhaba 2");
  console.log("Bir şey");
};
selamFonksiyonu2();

const selamFonksiyonu3 = (mesaj, mesaj2) => {
  console.log(mesaj);
  console.log(mesaj2);
};

selamFonksiyonu3("Mesaj 3 gönderilen", "mesaj 4 gönderilen");

var topla = (sayi1, sayi2) => {
  return sayi1 + sayi2;
};

let toplam = topla(3, 4);

console.log(toplam);
