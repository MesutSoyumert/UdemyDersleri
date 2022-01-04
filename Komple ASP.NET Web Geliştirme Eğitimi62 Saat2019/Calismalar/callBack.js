function fonk1(mesaj,callBack){
    console.log("Fonk1 bitti : " + mesaj);
    callBack();
}

function fonk2(){
    console.log("Fonk2 bitti");
}

const asenkron = function(sayi,callBack){
    sayi = sayi + 2;
    callBack(sayi)
}

asenkron(3,function(deger){
   console.log(deger)
})

const promiseFonk = (sayi)=>{
    return new Promise((resolve,reject)=>{
        if(sayi<=100){
            resolve(sayi)
        }else{
            reject("OLMAZ!")
        }
    })
}

promiseFonk(101).then(data=>{
    console.log(data)
    return data + 10;
}).then(data=>{
    console.log(data)
    data = data + 100;
    return data;
}).then(data=>{
    console.log(data)
    data = data + 1000;
    return data;
}).catch(error=>{
    console.log(error)
})

fonk1("Merhaba",fonk2)
