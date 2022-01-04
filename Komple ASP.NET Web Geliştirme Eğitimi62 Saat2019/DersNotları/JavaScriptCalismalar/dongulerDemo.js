var kullanicilar = [
    {email:"mesut@soyumert.com",parola:"12345"},
    {email:"deniz@soyumert.com",parola:"12345"},
    {email:"nazli@soyumert.com",parola:"12345"}
]

var tweets = [
    {email:"mesut@soyumert.com",tweet:"Bugün hava çok güzel"},
    {email:"deniz@soyumert.com",tweet:"Bugün Ablama gideceğim"},
    {email:"nazli@soyumert.com",tweet:"Bugün hava neden çok güzel"}
]

var email = prompt("email?")
var parola = prompt("parola?")


function kullaniciVarmi(email,parola){
    console.log(email)
    console.log(parola)
    for(i=0;i<kullanicilar.length;i++){
        if(kullanicilar[i].email==email && kullanicilar[i].parola==parola){
            return true;
        }
    }
    return false;
}
function giris(){
    if(kullaniciVarmi(email,parola)){
        console.log(tweets)
    }else{
        console.log("Kullanıcı adı veya parolası hatalı")
    }
}

giris(email,parola)