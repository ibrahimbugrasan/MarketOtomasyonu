using MarketOtomasyonu.Enum;
using MarketOtomasyonu.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketOtomasyonu.Dao
{      
    public class Repository
    {      
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        int returnvalue;
        List<LoginTable> ltList;


        /*
          [ENGLISH]
          Data Source = Server Name
          Enter the name of your SQL Server here. Make sure to end with a semicolon.
          Initial Catalog = Database Name
          Enter the name of the database you will be working with here. Make sure to end with a semicolon.
          User ID = Login
          Enter the login name you use to connect with SQL here. Make sure to end with a semicolon.
          Password = Password
          Enter the password you use to connect with SQL here.

          By completing these steps, you will have connected to the SQL Server using C#.
                    
          [TÜRKÇE]
          Data Source = Server Name      Buraya SQL serverınızın adını giriniz. Sonunda noktalı virgül olduğundan emin olunuz.
          Initial Catalog = Database Name      Buraya hangi database de çalışıcaksanız o database'in adını girin. Sonunda noktalı virgül olduğundan emin olunuz.
          User ID = Login     Buraya SQL ile bağlantı kurarken girdiğiniz login adını girin. Sonunda noktalı virgül olduğundan emin olunuz.
          password = Password        Buraya SQL ile bağlantı kurarken girdiğiniz şifrenizi giriniz.
          
          Bu işlemler sonucunda SQL Serverı C# ile bağlamış oluyoruz.
        */
        public Repository()
        {
            con = new SqlConnection("Data Source= Server Name;Initial Catalog=Database Name;User ID=Login;password=Password");
        }

        public void BaglantiAyarla()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            else
            {
                con.Close();
            }
        }

        

        public User login(string username, string password)
        {
            con.Open();

            cmd = new SqlCommand("select * from loginPage where username=@username and password=@password", con);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            dr = cmd.ExecuteReader();


            if (dr.Read())
            {
                User user = new User();
                user.id = int.Parse(dr["id"].ToString());
                user.username = dr["username"].ToString();
                user.password = dr["password"].ToString();
                user.permission = dr["permission"].ToString();
                user.email = dr["email"].ToString();
                user.securityQuestion = dr["securityQuestion"].ToString();
                user.securityAnswer = dr["securityAnswer"].ToString();
                user.status = LoginStatus.basarili;
                con.Close();
                return user;


            }
            else
            {
                User user = new User();
                user.status = LoginStatus.basarisiz;
                con.Close();
                return user;
            }
            



        }

        public List<LoginTable> getLoginTable()
        {
            ltList = new List<LoginTable>();
            BaglantiAyarla();

            cmd = new SqlCommand("guvenlikSorusuGetir_sp", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            dr = cmd.ExecuteReader();

            try
            {
                while (dr.Read())
                {
                    LoginTable loginTable = new LoginTable();
                    loginTable.id = int.Parse(dr["id"].ToString());
                    loginTable.username = dr["username"].ToString();
                    loginTable.password = dr["password"].ToString();
                    loginTable.email = dr["email"].ToString();
                    loginTable.permission = dr["permission"].ToString();
                    loginTable.securityQuestion = dr["securityQuestion"].ToString();
                    loginTable.securityAnswer = dr["securityAnswer"].ToString();

                    ltList.Add(loginTable);


                }
                BaglantiAyarla();

                return ltList;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public LoginStatus doAuthentication(string username, string securityQuestion, string securityAnswer)
        {
            BaglantiAyarla();
            cmd = new SqlCommand("select count(*) from loginPage where username=@username and securityQuestion=@securityQuestion and securityAnswer=@securityAnswer", con);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@securityQuestion", securityQuestion);
            cmd.Parameters.AddWithValue("@securityAnswer", securityAnswer);
            returnvalue = (int)cmd.ExecuteScalar();
            BaglantiAyarla();

            if (returnvalue == 1)
            {
                return LoginStatus.basarili;
            }
            else
            {
                return LoginStatus.basarisiz;
            }
        }

        public LoginStatus updatePassword(string email, string password)
        {
            con.Open();
            cmd = new SqlCommand("changePassword_sp", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@password", password);
            returnvalue = cmd.ExecuteNonQuery();
            con.Close();

            if (returnvalue == 1)
            {
                return LoginStatus.basarili;
            }
            else
            {
                return LoginStatus.basarisiz;
            }

        }

        public Products barcodeReader(string barkod)
        {
            BaglantiAyarla();
            cmd = new SqlCommand("select * from Products where barkodkod = @kod", con);
            cmd.Parameters.AddWithValue("@kod", barkod);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Products products = new Products();
                products.id = dr["id"].ToString();
                products.qrkod = dr["qrkod"].ToString();
                products.barkodkod = dr["barkodkod"].ToString();
                products.olusturulma_Tarih = DateTime.Parse(dr["olusturulma_Tarih"].ToString());

                products.urunIsim = dr["urunIsim"].ToString();
                products.kilo = int.Parse(dr["kilo"].ToString());

                products.fiyat = int.Parse(dr["fiyat"].ToString());
                products.status = LoginStatus.basarili;

                return products;
            }
            BaglantiAyarla();
            return null;

        }

        public List<User> usersSelect()
        {
            List<User> users = new List<User>();

            BaglantiAyarla();
            cmd = new SqlCommand("select * from loginPage", con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                User user = new User();
                user.id = int.Parse(dr["id"].ToString());
                user.username = dr["username"].ToString();
                user.password = dr["password"].ToString();
                user.area = dr["area"].ToString();
                user.email = dr["email"].ToString();
                user.permission = dr["permission"].ToString();
                user.securityQuestion = dr["securityQuestion"].ToString();
                user.securityAnswer = dr["securityAnswer"].ToString();

                users.Add(user);
            }
            BaglantiAyarla();
            return users;

        }

        public LoginStatus usersInsert(User user)
        {
            BaglantiAyarla();
            cmd = new SqlCommand("sp_InsertUsers", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", user.username);
            cmd.Parameters.AddWithValue("@password", user.password);
            cmd.Parameters.AddWithValue("@area", user.area);
            cmd.Parameters.AddWithValue("@email", user.email);
            cmd.Parameters.AddWithValue("@permission", user.permission);
            cmd.Parameters.AddWithValue("@securityQuestion", user.securityQuestion);
            cmd.Parameters.AddWithValue("@securityAnswer", user.securityAnswer);

            returnvalue = cmd.ExecuteNonQuery();

            BaglantiAyarla();
            if (returnvalue == 1)
            {
                return LoginStatus.basarili;
            }
            else
            {
                return LoginStatus.basarisiz;
            }

        }

        public LoginStatus usersUpdate(User user)
        {
            BaglantiAyarla();
            cmd = new SqlCommand("sp_updateUser", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", user.id);
            cmd.Parameters.AddWithValue("@username", user.username);
            cmd.Parameters.AddWithValue("@password", user.password);
            cmd.Parameters.AddWithValue("@email", user.email);
            cmd.Parameters.AddWithValue("@permission", user.permission);
            cmd.Parameters.AddWithValue("@area", user.area);
            cmd.Parameters.AddWithValue("@securityQuestion", user.securityQuestion);
            cmd.Parameters.AddWithValue("@securityAnswer", user.securityAnswer);

            returnvalue = cmd.ExecuteNonQuery();
            BaglantiAyarla();

            if (returnvalue == 1)
            {
                return LoginStatus.basarili;
            }
            else
            {
                return LoginStatus.basarisiz;
            }

        }

        public LoginStatus usersDelete(User user)
        {
            BaglantiAyarla();
            cmd = new SqlCommand("delete from loginPage where id=@id", con);
            cmd.Parameters.AddWithValue("@id", user.id);

            returnvalue = cmd.ExecuteNonQuery();
            BaglantiAyarla();

            if (returnvalue == 1)
            {
                return LoginStatus.basarili;
            }
            else
            {
                return LoginStatus.basarisiz;
            }
        }





        public List<Products> productsSelect()
        {
            List<Products> productsList = new List<Products>();
            BaglantiAyarla();
            cmd = new SqlCommand("select * from Products", con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Products products = new Products();
                products.id = dr["id"].ToString();
                products.qrkod = dr["qrkod"].ToString();
                products.barkodkod = dr["barkodkod"].ToString();

                string olusturulmaTarihValue = dr["olusturulma_Tarih"].ToString();
                if (!string.IsNullOrEmpty(olusturulmaTarihValue) && DateTime.TryParse(olusturulmaTarihValue, out DateTime olusturulmaTarih))
                {
                    products.olusturulma_Tarih = olusturulmaTarih;
                }
                else
                {
                    products.olusturulma_Tarih = DateTime.MinValue;
                }


                string guncellemeTarihValue = dr["guncelleme_Tarih"].ToString();
                if (!string.IsNullOrEmpty(guncellemeTarihValue) && DateTime.TryParse(guncellemeTarihValue, out DateTime guncellemeTarih))
                {
                    products.guncelleme_Tarih = guncellemeTarih;
                }
                else
                {
                    products.guncelleme_Tarih = DateTime.MinValue;
                }


                products.urunIsim = dr["urunIsim"].ToString();
                products.kilo = float.Parse(dr["kilo"].ToString());
                products.fiyat = int.Parse(dr["fiyat"].ToString());


                string ciro = dr["ciro"].ToString();
                if (!string.IsNullOrEmpty(ciro) && int.TryParse(ciro, out int ciroSayı))
                {
                    products.ciro = ciroSayı;
                }
                else
                {
                    products.ciro = 0;
                }



                productsList.Add(products);

            }
            BaglantiAyarla();
            return productsList;
        }

        public LoginStatus productsInsert(Products products)
        {
            BaglantiAyarla();
            cmd = new SqlCommand("sp_insertProducts", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", products.id);
            cmd.Parameters.AddWithValue("@ciro", products.ciro);
            cmd.Parameters.AddWithValue("@guncelleme_Tarih", products.guncelleme_Tarih);
            cmd.Parameters.AddWithValue("@olusturulma_Tarih", products.olusturulma_Tarih);
            cmd.Parameters.AddWithValue("@fiyat", products.fiyat);
            cmd.Parameters.AddWithValue("@kilo", products.kilo);
            cmd.Parameters.AddWithValue("@barkodkod", products.barkodkod);
            cmd.Parameters.AddWithValue("@urunIsim", products.urunIsim);


            returnvalue = cmd.ExecuteNonQuery();
            BaglantiAyarla();

            if (returnvalue == 1)
            {
                return LoginStatus.basarili;
            }
            else
            {
                return LoginStatus.basarisiz;
            }
        }

        public LoginStatus productsDelete(Products products)
        {
            BaglantiAyarla();
            cmd = new SqlCommand("delete from Products where id=@id", con);
            cmd.Parameters.AddWithValue("@id", products.id);
            returnvalue = cmd.ExecuteNonQuery();
            BaglantiAyarla();

            if (returnvalue == 1)
            {
                return LoginStatus.basarili;
            }
            else
            {
                return LoginStatus.basarisiz;
            }
        }

        public LoginStatus productsUpdate(Products products)
        {
            BaglantiAyarla();
            cmd = new SqlCommand("sp_productsUpdate", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("id", products.id);
            cmd.Parameters.AddWithValue("barkodkod", products.barkodkod);
            cmd.Parameters.AddWithValue("olusturulma_Tarih", products.olusturulma_Tarih);
            cmd.Parameters.AddWithValue("guncelleme_Tarih", products.guncelleme_Tarih);
            cmd.Parameters.AddWithValue("urunIsim", products.urunIsim);
            cmd.Parameters.AddWithValue("kilo", products.kilo);
            cmd.Parameters.AddWithValue("fiyat", products.fiyat);
            cmd.Parameters.AddWithValue("ciro", products.ciro);

            returnvalue = cmd.ExecuteNonQuery();
            BaglantiAyarla();

            if (returnvalue == 1)
            {
                return LoginStatus.basarili;
            }
            else
            {
                return LoginStatus.basarisiz;
            }

        }

        public User userSearchId(string id)
        {
            BaglantiAyarla();
           
            cmd = new SqlCommand("select * from loginPage where id = @id", con);
            cmd.Parameters.AddWithValue("@id", id);
            dr = cmd.ExecuteReader();


            if (dr.Read())
            {
                User user = new User();

                user.id = int.Parse(dr["id"].ToString());
                user.username = dr["username"].ToString();
                user.password = dr["password"].ToString();
                user.area = dr["area"].ToString();
                user.email = dr["email"].ToString();
                user.permission = dr["permission"].ToString();
                user.securityQuestion = dr["securityQuestion"].ToString();
                user.securityAnswer = dr["securityAnswer"].ToString();

                BaglantiAyarla();
                return user;
                

            }
            

            else
            {
                User user2 = new User();
                user2.status = LoginStatus.eksikParametre;
                BaglantiAyarla();
                return user2;
            }

            



        }


        public Products productSearchId(string id)
        {
            BaglantiAyarla();
            cmd = new SqlCommand("select * from Products where id = @id", con);
            cmd.Parameters.AddWithValue("@id", id);
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                Products product = new Products();

                product.id = dr["id"].ToString();
                product.barkodkod = dr["barkodkod"].ToString();

                string oT = dr["olusturulma_Tarih"].ToString();
                if (!string.IsNullOrEmpty(oT) && DateTime.TryParse(oT, out DateTime tarih))
                {
                    product.olusturulma_Tarih = tarih;
                }
                else
                {
                    product.olusturulma_Tarih = DateTime.MinValue;
                }

                string gT = dr["guncelleme_Tarih"].ToString();
                if (!string.IsNullOrEmpty(gT) && DateTime.TryParse(gT, out DateTime tarih2))
                {
                    product.guncelleme_Tarih = tarih2;
                }
                else
                {
                    product.guncelleme_Tarih = DateTime.MinValue;
                }

                product.urunIsim = dr["urunIsim"].ToString();

                string k = dr["kilo"].ToString();
                if (!string.IsNullOrEmpty(k) && float.TryParse(k, out float i))
                {
                    product.kilo = i;
                }
                else
                {
                    product.kilo = 0;
                }

                string f = dr["fiyat"].ToString();
                if (!string.IsNullOrEmpty(f) && int.TryParse(f, out int u))
                {
                    product.fiyat = u;
                }
                else
                {
                    product.fiyat = 0;
                }

                string c = dr["ciro"].ToString();
                if (!string.IsNullOrEmpty(c) && int.TryParse(c, out int g))
                {
                    product.ciro = g;
                }
                else
                {
                    product.ciro = 0;
                }

                BaglantiAyarla();
                return product;

            }

            else
            {
                return null;
            }
        }
    }
}
