using MarketOtomasyonu.Dao;
using MarketOtomasyonu.Enum;
using MarketOtomasyonu.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketOtomasyonu.Controller
{
    public class Controller
    {
        Repository repository;
        public Controller() 
        {
             repository = new Repository();
        }

        public User login(string username, string password)
        {
            username = username.ToLower();
            User result;


            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                result = repository.login(username, password);
                return result;
            }
            else
            {
                User user = new User();
                user.status = LoginStatus.eksikParametre;
                return user;
            }
            
        }

        public List<LoginTable> getLoginTable()
        {
            List<LoginTable> loginTableList = repository.getLoginTable();

            return loginTableList;
        }

        public LoginStatus doAuthentication(string username, string securityQuestion, string securityAnswer)
        {
            if(!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(securityQuestion) && !string.IsNullOrEmpty(securityAnswer)) 
            {
                 LoginStatus result = repository.doAuthentication(username, securityQuestion, securityAnswer);

                if(result == LoginStatus.basarili)
                {
                    return result;
                }
                else
                {
                    return LoginStatus.basarisiz;
                }
            }

            else
            {
                return LoginStatus.eksikParametre;
            }
        }

        public LoginStatus updatePassword(string email, string password)
        {
            if(!string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(email))
            {
                LoginStatus result = repository.updatePassword(email, password);
                if(result == LoginStatus.basarili)
                {
                    return LoginStatus.basarili;
                }
                else
                {
                    return LoginStatus.basarisiz;
                }
            }
            else
            {
                return LoginStatus.eksikParametre;
            }
        }

        public Products barcodeReader(string barkod)
        {
            if(!string.IsNullOrEmpty(barkod))
            {
                Products product = repository.barcodeReader(barkod);
                return product;
            }
            return null;
        }

        public List<User> usersSelect()
        {            
            return repository.usersSelect();
        }

        public LoginStatus usersInsert(User user)
        {
            if(!string.IsNullOrEmpty(user.username) && !string.IsNullOrEmpty(user.password) && !string.IsNullOrEmpty(user.email) && !string.IsNullOrEmpty(user.permission) && !string.IsNullOrEmpty(user.securityQuestion) && !string.IsNullOrEmpty(user.securityAnswer)) 
            {
                return repository.usersInsert(user);
            }
            else
            {
                return LoginStatus.eksikParametre;
            }
        }

        public LoginStatus usersUpdate(User user)
        {
            
            return repository.usersUpdate(user);
        }

        public LoginStatus usersDelete(User user)
        {
            
            return repository.usersDelete(user);
        }

        public List<Products> productsSelect()
        {
            return repository.productsSelect();
        }

        public LoginStatus productsInsert(Products products)
        {
            if (!string.IsNullOrEmpty(products.id) && !string.IsNullOrEmpty(products.barkodkod) && !string.IsNullOrEmpty(products.urunIsim) && !string.IsNullOrEmpty(products.olusturulma_Tarih.ToString()) && !string.IsNullOrEmpty(products.kilo.ToString()) && !string.IsNullOrEmpty(products.fiyat.ToString()))
            {
                return repository.productsInsert(products);
            }
            else
            {
               return LoginStatus.eksikParametre;
            }
        }

        public LoginStatus productsDelete(Products products)
        {
            return repository.productsDelete(products);
        }

        public LoginStatus productsUpdate(Products products)
        {
            if (!string.IsNullOrEmpty(products.id) && !string.IsNullOrEmpty(products.urunIsim) && !string.IsNullOrEmpty(products.barkodkod) && !string.IsNullOrEmpty(products.olusturulma_Tarih.ToString()) && !string.IsNullOrEmpty(products.kilo.ToString()) && !string.IsNullOrEmpty(products.fiyat.ToString()))
            {
                return repository.productsUpdate(products);
            }
            else
            {
                return LoginStatus.eksikParametre;
            }
        }


        public User userSearchId(string id)
        {
            string i = id;
            if(!string.IsNullOrEmpty(i) && int.TryParse(i,out int sayi))
            {
                return repository.userSearchId(sayi.ToString());
            }
            else
            {
                User user = new User();
                user.status = LoginStatus.basarisiz;
                return user;
            }
            
                       
        }

        public Products productSearchId(string id)
        {
            if (!string.IsNullOrEmpty(id))
            {
                return repository.productSearchId(id);
            }
            else
            {
                return null;
            }
        }
    }
}
