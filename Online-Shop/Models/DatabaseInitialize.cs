using System.Linq;

namespace Online_Shop.Models
{
    public class DatabaseInitialize
    {
        public static void Initialize(BookShopContext bookShopContext)
        {
            if (!bookShopContext.Books.Any())
            {
                bookShopContext.Books.AddRange(
                    new Book()
                    {
                        Name = "Над пропастью во ржи",
                        Author = "Сэлинджер",
                        Price = 350,
                        Image = "Image"
                    },
                new Book()
                    {
                        Name = "Коллекционер",
                        Author = "Фаулз",
                        Price = 250,
                        Image = "Image1"
                    },
                new Book()
                    {
                        Name = "1984",
                        Author = "Оруэл",
                        Price = 300,
                        Image = "Image1"
                    }
                );
            }

            bookShopContext.SaveChanges();
        }
    }
}
