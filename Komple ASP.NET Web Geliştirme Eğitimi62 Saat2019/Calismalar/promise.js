
// var sinavNotu = 85;

// var telefonAlalimMi = new Promise(function(resolve,reject){
//  if(sinavNotu>80){
//     var telefon = {
//         marka :'Samsung',
//         model : 'S3'
//     }
//     resolve(telefon)
//  }
//  else{
//      var sonuc = new Error('Telefon almıyoruz')
//      reject(sonuc)
//  }
// })

// var arkadaslaraGoster = function(telefon){
//     var mesaj = 'Arkadaşlar işte yeni telefonum : ' + telefon.marka + ' ' +telefon.model 
//     return Promise.resolve(mesaj)
// }


// var sinavSonrasi = function(){
//     telefonAlalimMi.then(arkadaslaraGoster).then(function(data){
//         console.log(data)
//     }).catch(function(hata){
//         console.log(hata.message)
//     })
// }


const sinavNotu = 75;

const telefonAlalimMi = new Promise((resolve,reject)=>{
    if(sinavNotu>80){
        const telefon = {
            marka :'Samsung',
            model : 'S3'
        }
        resolve(telefon)
     }
     else{
        const sonuc = new Error('Telefon almıyoruz')
         reject(sonuc)
     }
})

const arkadaslaraGoster = (telefon)=>{
    const mesaj = 'Arkadaşlar işte yeni telefonum : ' + telefon.marka + ' ' +telefon.model 
    return Promise.resolve(mesaj)
}


const sinavSonrasi = ()=>{
    telefonAlalimMi.then(arkadaslaraGoster).then(function(data){
        console.log(data)
    }).catch(function(hata){
        console.log(hata.message)
    })
}
sinavSonrasi()