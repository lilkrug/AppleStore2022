using KursovoiProject2kurs.MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovoiProject2kurs.DataModel
{
    public static class DataWorker
    {
        public static List<Good> GetAllGoods()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var result = db.Goods.ToList();
                return result;
            }
        }
        public static List<Order> GetAllUserOrders(int UserId)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var result = db.Orders.Where(o => o.UserId == UserId).ToList();
                return result;
            }
        }
        public static List<User> GetAllUsers()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var result = db.Users.ToList();
                return result;
            }
        }
        public static List<Order> GetAllOrders()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var result = db.Orders.ToList();
                return result;
            }
        }
        public static List<Image> GetAllImages()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var result = db.Images.ToList();
                return result;
            }
        }
        public static string CreateGoods(int id, string name, string category, int price, string country, string description, Image image)
        {
            string result = "Уже существует";
            using (ApplicationContext db = new ApplicationContext())
            {
                //проверяем существует ли телефон
                bool checkIsExist = db.Goods.Any(el => el.Name == name && el.Category == category && el.Price == price && el.Country == country && el.Description == description);
                if (!checkIsExist)
                {
                    Good newTelephone = new Good
                    {
                        Id = id,
                        Name = name,
                        Country = country,
                        Price = price,
                        Description = description,
                        Category = category,
                        IPhoneImage = image
                    };
                    db.Goods.Add(newTelephone);
                    db.SaveChanges();
                    result = "Сделано";
                }
                return result;
            }
        }
        public static int FindIdByLogin(string Login)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var result = db.Users.FirstOrDefault(p => p.Login == Login);
                return result.Id;
            }
        }
        public static string RegisterUser(string login, string password)
        {
            string result = "Уже существует";
            using (ApplicationContext db = new ApplicationContext())
            {
                //проверяем существует ли пользователь
                bool checkIsExist = db.Users.Any(el => el.Login == login);
                if (!checkIsExist)
                {
                    User newUser = new User
                    {
                        Id = 0,
                        Login = login,
                        Password = password,
                        Orders = null,
                    };
                    db.Users.Add(newUser);
                    db.SaveChanges();
                    result = "Сделано";
                }
                return result;
            }  
        } 
        public static string LoginUser(string login, string password)
        {
            DataManageVM.Login = login;
            DataManageVM.Password = password;
            DataManageVM.Id = FindIdByLogin(login);
            return "День добры " + login;
        }
        public static string CheckUserData(string login, string password)
        {
            string result = "Отлично";
            using (ApplicationContext db = new ApplicationContext())
            {
                //проверяем существует ли пользователь
                bool checkIsLoginExist = db.Users.Any(el => el.Login == login);
                bool checkIsPasswordCorrect = db.Users.Any(el => el.Login == login && el.Password == password);
                if (checkIsLoginExist)
                {
                    if (checkIsPasswordCorrect)
                    {
                        result = "Отлично";
                    }
                    else
                    {
                        result = "Введен неверный пароль";
                    }
                }
                else
                {
                    result = "Данного пользователя не существует";
                }
                return result;
            }
        }
        public static bool GetLogins(string login)
        {
            bool result = false;
            using (ApplicationContext db = new ApplicationContext())
            {
                result = db.Users.Any(el => el.Login == login);
            }
            return result;
        }
        public static string CreateOrder(Good good, int userId)
        {
            string result = "Не получилось";
            using (ApplicationContext db = new ApplicationContext())
            {
                Order newOrder = new Order
                {
                    Id = 0,
                    GoodId = good.Id,
                    UserId = userId
                };
                db.Orders.Add(newOrder);
                db.SaveChanges();
                result = "Сделано";
                return result;
            }
        }
        public static string CreateImage(int imageid, byte[] picture, string path)
        {
            string result = "no";
            using (ApplicationContext db = new ApplicationContext())
            {
                Image newImage = new Image
                {
                    ImageId = imageid,
                    Picture = picture,
                    Path = path
                };
                db.Images.Add(newImage);
                db.SaveChanges();
                result = "Сделано";
                return result;
            }
        }
        public static string DeleteGoods(Good good)
        {
            string result = "Такого товара не существует";
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Goods.Remove(good);
                db.SaveChanges();
                DeleteImage(GetImageById(good.ImageId));
                result = "Сделано! Товар " + good.Name + " удален из меню";
            }
            return result;
        }
        public static void DeleteImage(Image image)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Images.Remove(image);
                db.SaveChanges();
            }
        }
        public static string DeleteOrder(Order order)
        {
            string result = "Такого товара не существует";
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Orders.Remove(order);
                db.SaveChanges();
                result = "Сделано! Заказ " + order.Id + "отменён";
            }
            return result;
        }

        public static string EditGoods(Good oldGood, string newCountry, int newPrice, string newCategory,
            string newDescription)
        {
            string result = "Такого Товара не существует";
            using (ApplicationContext db = new ApplicationContext())
            {
                Good good = db.Goods.FirstOrDefault(d => d.Id == oldGood.Id);
                good.Country = newCountry;
                good.Price = newPrice;
                good.Description = newDescription;
                good.Category = newCategory;
                db.SaveChanges();
                result = "Сделано! Товар " + good.Name + " изменен";
            }
            return result;
        }
        public static string CreateSupport(string email, string subject, string message)
        {
            string result = "Not ok";
            using (ApplicationContext db = new ApplicationContext())
            {
                Support newSupport = new Support
                {
                    Email = email,
                    Subject = subject,
                    Message = message
                };
                db.Supports.Add(newSupport);
                db.SaveChanges();
                result = "Сделано";
                return result;
            }
        }

        //получение картинки по id
        public static Image GetImageById(int id)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                Image im = db.Images.FirstOrDefault(p => p.ImageId == id);
                return im;
            }
        }
        public static string GetLoginById(int id)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                User user = db.Users.FirstOrDefault(p => p.Id == id);
                return user.Login;
            }
        }
        public static Good GetGoodById(int id)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                Good good = db.Goods.FirstOrDefault(p => p.Id == id);
                return good;
            }
        }
    }
}
