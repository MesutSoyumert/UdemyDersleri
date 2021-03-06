using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün başarı ile sisteme kaydedildi";
        public static string ProductUpdated = "Ürün başarı ile güncellendi";
        public static string ProductDeleted = "Ürün başarı ile sistemden silindi";

        public static string CategoryAdded = "Kategori başarı ile sisteme kaydedildi";
        public static string CategoryUpdated = "Kategori başarı ile güncellendi";
        public static string CategoryDeleted = "Kategori başarı ile sistemden silindi";

        public static string UserNotFound = "Girdiğiniz e-posta adresine ait kullanıcı sistemde kayıtlı değil";
        public static string UserPasswordWrong = "Girdiğiniz parola hatalı";
        public static string UserLoginSuccessfull = "Kullanıcı sisteme girişi başarı ile gerçekleşmiştir";
        public static string UserAlreadyExists = "Girdiğiniz e-posta sistemde kayıtlı, başka bir e-posta giriniz";
        public static string UserRegisteredSuccessfully = "Kullanıcı kayıt olma işlemi başarıyla gerçekleştirilmiştir";
        public static string UserLoginAccessTokenCreatedSuccessfully = "Kullanıcı sistem girişi tokenları oluşturma işlemi başarıyla gerçekleştirilmiştir";

    }
}
