using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba Eklendi";
        public static string ColorAdded = "Renk Eklendi";
        public static string BrandAdded = "Marka Eklendi";
        public static string CustomerAdded = "Müşteri Eklendi";
        public static string UserAdded = "Kullanıcı Eklendi";
        public static string RentalAdded = "Kiralama Eklendi";

        public static string CarsListed = "Arabalar Listelendi";
        public static string ColorsListed = "Renkler Listelendi";
        public static string BrandsListed = "Markalar Listelendi";
        public static string CustomersListed = "Müşteriler Listelendi";
        public static string UsersListed = "Kullanıcılar Listelendi";
        public static string RentalsListed = "Kiralamalar Listelendi";

        public static string CarDeleted = "Araba Silindi";
        public static string ColorDeleted = "Renk Silindi";
        public static string BrandDeleted = "Marka Silindi";
        public static string CustomerDeleted = "Müşteri Silindi";
        public static string UserDeleted = "Kullanıcı Silindi";
        public static string RentalDeleted = "Kiralama Silindi";

        public static string CarUpdated = "Araba Güncellendi";
        public static string ColorUpdated = "Renk Güncellendi";
        public static string BrandUpdated = "Marka Güncellendi";
        public static string CustomerUpdated = "Müşteri Güncellendi";
        public static string UserUpdated = "Kullanıcı Güncellendi";
        public static string RentalUpdated = "Kiralama Güncellendi";

        public static string CarNameInvalid = "Araba İsmi Geçersiz";
        public static string DailyPriceInvalid = "Kiralama Fiyatı Geçersiz";
        public static string CarNotAvailable = "Kiralanmak İstenen Araba Müsait Değil";

        public static string CarImageAdded="Araba Resmi Eklendi";
        public static string CarImageUpdated="Araba Resmi Güncellendi";
        public static string CarImagesListed="Araba Resimleri Listelendi";
        public static string CarImageDeleted="Araba Resmi Silindi";
        public static string AuthorizationDenied = "Yetkiniz Yok";
        public static string UserRegistered = "Kullanıcı Başarıyla Kaydedildi";
        public static string UserNotFound = "Kullanıcı  Bulunamadı";
        public static string PasswordError = "Hatalı Şifre";
        public static string SuccessfulLogin = "Sisteme Giriş Başarılı";
        public static string UserAlreadyExists = "Kullanıcı Zaten Mevcut";
        public static string AccessTokenCreated = "Access Token Başarıyla Oluşturuldu";
        public static string CarImageLimitExceeded="Araba Resmi En Fazla 5 Tane Olabilir";
    }
}
