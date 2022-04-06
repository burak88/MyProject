using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductCountOfCategoryError = "En fazla 10 ürün eklenebilir";
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInValid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda ";
        public static string ProductListed = " Ürünler Listelendi";
        public  static string ProdcutNameAlreadyExists ="Bu isimde bir ürün mevcut";
        public  static string CategoryLimitExceded= "Kategori limiti aşıldığı için yeni ürün eklenemiyor.";
    }
}
