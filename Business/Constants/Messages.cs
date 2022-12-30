using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    //Static verince sürekli new'lemekten kurtuluyoruz.
    public static class Messages
    {
        

        //Product Messages
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string ProductsListed = "Ürünler Listelendi";
        public static string ProductDeleted = "Ürün Silindi";
        public static string ProductUpdated = "Ürün Bilgileri Güncellendi";

        //Person
        public static string PersonAdded = "Kişi Eklendi";
        public static string PersonListed = "Kişi Listelendi";
        public static string PersonDeleted = "Kişi Silindi";
        public static string PersonUpdated = "Kişi Bilgileri Güncellendi";

        //Employee Messages
        public static string EmployeeAdded = "Çalışan Eklendi";
        public static string EmployeesListed = "Çalışanlar Listelendi";
        public static string EmployeeDeleted = "Çalışan Silindi";
        public static string EmployeeUpdated = "Çalışan Bilgileri Güncellendi";

        //Category Messages
        public static string CategoryListed = "Kategoriler Listelendi";

        //Other Messages
        public static string MaintenanceTime = "Bakım zamanı";
        public static string UnknownError = "Bilinmeyen bir hata ile karşılaşıldı";


        //--------------------------------------------FORM

        //Login Messages
        public static string Username = "Username";
        public static string Password = "Password";


        //Text Messages
        public static string Category = "Kategoriler";
        public static string ProductName = "Ürün Adı";
        public static string UnitsInStock = "Ürün Adedi";
        public static string ProductCode = "Ürün Kodu";
        public static string ProductBarcode = "Ürün Barkod";
        public static string ProductDesc = "Ürün Açıklaması";
        public static string Space = "";//Boşluk bırak

        //Button Messages
        public static string Add = "EKLE";
        public static string Update = "Güncelle";
    }
}
