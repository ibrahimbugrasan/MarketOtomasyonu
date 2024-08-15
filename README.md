[ENGLISH]

# Market Automation System

## About the Project
- This project is a market automation system developed using C# and Windows Forms. It connects to SQL Server to manage product information, user information, and other functionalities. Additionally, it includes features such as sending emails to users who forget their passwords, accessing the camera, and reading barcodes. The project is structured using the MVC (Model-View-Controller) architecture.

## Features
- Product Management: Adding, updating, deleting, and retrieving product information.
- User Management: Managing cashier and admin user information. Specific functions for cashiers and admins.
- Camera Access: Reading barcodes using the camera.
- Calculator: Calculating the price of the scanned product.
- Password Recovery: Sending password reset links to users who have forgotten their passwords via email.
- SQL Server Integration: Using SQL Server for database operations.
- MVC Architecture: The project is developed using the Model-View-Controller architecture.

## Requirements
To run this project, the following requirements must be met:

- Visual Studio 2019 or later
- SQL Server 2016 or later
- .NET Framework 4.7.2
- AForge.NET Framework (for camera access)
- ZXing.Net (for barcode reading)
- System.Net.Mail (for sending password reset emails)

## Installation
1. Creating the Database on SQL Server:
- Use the code in the MarketOtomasyonu_DB_Tables_Create.sql file to create the database and its tables.
- Use the code in the SP_Create.sql file to create the stored procedures used in the project.
- Configure the database connection settings in the Repository layer of the project. You need to fill in the parameters of the SqlConnection object in the constructor of the Repository with your own SQL Server information (details are added as comments).
- After completing these steps, add data to the Products and loginPage tables in SQL Server. In the loginPage table, give the Permission column either the admin or cashier property. To ensure that emails are sent and received correctly, you can add a valid email address to the email column in the loginPage table.
- For the barcode codes in the Products table, you can create barcodes using an online barcode generator. For example, create a barcode for the code 2552441210 and then scan this barcode to access the product with the barcode code 2552441210.

2. Steps to be Taken for Sending Emails:
- First, you need to open the code section of the Password Change Form. Then, you need to give the parameters of the MailSender object (details are added as comments).
- As the last step, you need to give the email account that will send the emails and its password to the NetworkCredential object so that SMTP can authenticate (details are added as comments).

3. Running the Project:
- Open the project with Visual Studio.
- Use the NuGet package manager to install the required libraries: AForge, AForge.Video, AForge.Video.DirectShow, ZXing.Net
- Build and run the project.

## Usage
- **Login:**
Log in with your cashier or admin user information.

- **Password Reset:**
If you forget your password, a password reset link will be sent to your registered email address.

- **Product Management:**
Add, update, delete, or retrieve products.

- **User Management:**
Add, update, delete, or retrieve users.

- **Camera and Barcode Usage:**
Perform barcode reading using the camera. The price of the product with the scanned barcode code will be displayed on the calculator.

## Contributing
If you want to contribute, please submit a pull request or open an issue. Contributions are always welcome!

## License
This project is licensed under the MIT License. You can find the full license text here: https://opensource.org/licenses/MIT   


[TÜRKÇE]

# Market Otomasyonu

## Proje Hakkında
- Bu proje, bir market otomasyon sistemidir ve C# diliyle Windows Form kullanılarak geliştirilmiştir. Proje, ürün bilgileri, kullanıcı bilgileri gibi işlevleri yönetmek için SQL Server'a bağlanır. Ayrıca, şifresini unutan kullanıcılara e-posta gönderme, kameraya erişim ve barkod okuma gibi özellikleri de içerir. Proje, MVC (Model-View-Controller) mimarisi kullanılarak yapılandırılmıştır.

## Özellikler
- Ürün Yönetimi: Ürün çağırma, ekleme, güncelleme ve silme.
- Kullanıcı Yönetimi: Kasiyer ve admin kullanıcı bilgilerini yönetme. Kasiyere ve admine özel işlevler.
- Kamera Erişimi: Kamerayı kullanarak barkod okuma.
- Hesap Makinesi: Okutulan ürünün fiyatı yansıtılarak işlem yapılma.
- Şifre Kurtarma: Şifresini unutan kullanıcılara e-posta ile şifre sıfırlama bağlantısı gönderme.
- SQL Server Entegrasyonu: Veritabanı işlemleri için SQL Server kullanımı.
- MVC Mimarisi: Proje, Model-View-Controller mimarisi ile geliştirilmiştir.

## Gereksinimler
Bu projeyi çalıştırabilmek için aşağıdaki gereksinimlerin karşılanması gerekmektedir:

- Visual Studio 2019 veya üstü
- SQL Server 2016 veya üstü
- .NET Framework 4.7.2
- AForge.NET Framework (Kameraya erişim için)
- ZXing.Net (Barkod okuma için)
- System.Net.Mail (Şifre sıfırlama e-postaları için)

## Kurulum
1. SQL Server'da Veritabanını Oluşturma:
- MarketOtomasyonu_DB_Tables_Create.sql dosyasındaki kodları kullanarak veritabanını ve tablolarını oluşturun.
- SP_Create.sql dosyasındaki kodları kullanarak projenin içinde kullanılan Stored Procedure'leri oluşturun.
- Veritabanı bağlantı ayarlarını projenin içindeki Repository katmanında yapmalısınız. Yapmanız gerekenler: Repository'nin yapıcı methodunun içindeki SqlConnection nesnesinin parametrelerini kendi Sql Server bilgilerinizle doldurmak (Detayları yorum satırı olarak ekledim).
- Bu işlemleri hallettikten sonra Sql Server'dan Products ve loginPage tablolarına veriler ekleyin. loginPage de Permission kolonuna admin veya kasiyer özelliklerinden birini veriniz. Maillerin doğru bir şekilde gitmesi ve alınabilmesi için loginPage deki email kolonuna kullandığınız bir mail adresi ekleyebilirsiniz.
- Products tablosunda barkodkod kısmındaki barkodların kodlarını internetten bir barkod oluşturucuyla oluşturabilirsiniz. ÖRNEK: 2552441210 kodunu barkodkod'a ekleyip internetten bu koda sahip bir barkod oluşturun bu işlemden sonra 2552441210 barkod koduna sahip ürüne erişebilmek için oluşturmuş olduğunuz barkodu okutucaksınız.

2. Mail Gönderme İşlemi İçin Yapılması Gerekenler:
- Öncelikle Şifre Değiştirme Formunun kod kısmını açmanız gerekli. Ardından MailSender nesnesinin parametrelerini vermelisiniz (Detayları yorum satırı olarak ekledim).
- Son adım olarakta SMTP'nin kimlik bilgilerinizi doğrulayabilmesi için mailleri gönderecek olan mail hesabını ve şifresini NetworkCredential nesnesine parametre olarak vermelisiniz (Detayları yorum satırı olarak ekledim).

3. Projenin Çalıştırılması:
- Projeyi Visual Studio ile açın.
- Bağımlılıkları yüklemek için NuGet paket yöneticisini kullanın. Yüklemeniz gereken kütüphaneler: AForge, AForge.Video, AForge.Video.DirectShow, ZXing.Net
- Projeyi derleyin ve çalıştırın.

## Kullanım
- **Giriş Yapın:**
Kasiyer veya admin kullanıcı bilgileriyle giriş yapın.

- **Şifre Sıfırlama:**
Şifrenizi unuttuğunuzda, kayıtlı e-posta adresinize şifre sıfırlama bağlantısı gönderilecektir.

- **Ürün Yönetimi:**
Ürün çağırın,ekleyin, güncelleyin veya silin.

- **Kullanıcı Yönetimi:**
Kullanıcı çağırın,ekleyin, güncelleyin veya silin.

- **Kamera ve Barkod Kullanımı:**
Kamera üzerinden barkod okuma işlemini gerçekleştirin. Okuduğunuz barkod koduna sahip ürünün fiyatı hesap makinesine gelecektir.

## Katkıda Bulunma
Katkıda bulunmak isterseniz, lütfen bir pull request gönderin veya bir issue açın. Katkılarınız her zaman memnuniyetle karşılanır!

## Lisans
Bu proje, MIT Lisansı altında lisanslanmıştır. Lisans metnine buradan ulaşabilirsiniz: https://opensource.org/licenses/MIT










