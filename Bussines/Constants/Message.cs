using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Constants
{
    public static class Message
    {
        public static string AuthorAdded = "Yazar eklendi";
        public static string AuthorListened = "Yazar listelendi";
        public static string BookAdded = "Kitap eklendi";
        public static string BookDeleted = "Kitap silindi";
        public static string BooksListed = "Kitaplar listelendi";
        public static string BooksDetailsListed = "Kitaplar detaylar listelendi";
        public static string GivenBookListened = "istenilen Kitap listelendi";
        public static string CategoryAdded = "Kategori eklendi";
        public static string CategoriesListened = "Kategoriler listelendi";
        public static string CategoriesUptated = "Kategoriler Güncellendi";
        public static string CustomerAdded = "Müşteri Eklendi";
        public static string CustomerDeleted = "Müşteri Silindi";
        public static string CustomerListened = "Müşteri Listelendi";
        public static string GivenCustomerListened = "İstenilen Müşteri Listelendi"; 
        public static string CustomerUpdated = "Müşteri Güncellendi";
        public static string CategoryListed = "Kategori Listelendi";
        public static string CategoryDeleted = "Kategori silindi";
    }
}
