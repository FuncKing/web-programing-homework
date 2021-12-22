# FuncKing Web Programlama Ödevi
Dotnet Core, Entity Framework, PostgreSQL, BootStrap gibi teknolojiler kullanılarak geliştirilen, Sakarya Üniversitesi Bilgisayar Mühendisliği Web Programlama dersi ödevi çerçevesinde yapılan şirket satış yazılımıdır.

### Hazılayanlar
+ G191210018 [Mert Can YILMAZ](https://github.com/DEONSKY "GitHub hesabını görmek için tıklayın")
+ G191210057 [Alihan SARAÇ](https://github.com/saracalihan "GitHub hesabını görmek için tıklayın")

## İçindekiler
+ [Dosya Yapısı](#dosya-yapısı)
+ [Kurulum](#kurulum)
+ [Lisans](#lisans)

## Dosya Yapısı
```bash
.
├── README.md  # Proje Tanıtım Metni
├── LICENSE # Lisans
├── WebApplication2 # Kaynak kodlar
│   ├── appsettings.Development.json
│   ├── appsettings.json # Uygulama konfigrasyonları
│   ├── Areas
│   │   └── Identity
│   │       ├── IdentityHostingStartup.cs
│   │       └── Pages
│   │           ├── Account
│   │           │   ├── Login.cshtml
│   │           │   ├── Login.cshtml.cs
│   │           │   ├── Logout.cshtml
│   │           │   ├── Logout.cshtml.cs
│   │           │   ├── Register.cshtml
│   │           │   ├── Register.cshtml.cs
│   │           │   └── _ViewImports.cshtml
│   │           ├── _ValidationScriptsPartial.cshtml
│   │           ├── _ViewImports.cshtml
│   │           └── _ViewStart.cshtml
│   ├── bin/
│   ├── Controllers # Kontrolcüler "<Model>Controller.cs"
│   │   ├── FormController.cs
│   │   ├── HomeController.cs
│   │   ├── ProductsController.cs
│   │   ├── ProductSeriesAPIController.cs
│   │   ├── ProductSeriesController.cs
│   │   ├── SalesController.cs
│   │   └── SellersController.cs
│   ├── Migrations Migrasyonlar "<zamandamgasi>_<yaptigi-is>.cs"
│   │   ├── 20211215164028_initial.cs
│   │   ├── 20211215164028_initial.Designer.cs
│   │   ├── 20211218131627_identity.cs
│   │   ├── 20211218131627_identity.Designer.cs
│   │   ├── 20211218151737_product-image-path-add.cs
│   │   ├── 20211218151737_product-image-path-add.Designer.cs
│   │   ├── 20211218161324_hothix-default-user.cs
│   │   ├── 20211218161324_hothix-default-user.Designer.cs
│   │   ├── 20211219143633_product-desc-add-and-sale-price-delete.cs
│   │   ├── 20211219143633_product-desc-add-and-sale-price-delete.Designer.cs
│   │   └── ShopContextModelSnapshot.cs
│   ├── Models # Modeller
│   │   ├── ErrorMVC.cs
│   │   ├── ErrorViewModel.cs
│   │   ├── Product.cs
│   │   ├── ProductSeries.cs
│   │   ├── Role.cs
│   │   ├── Sale.cs
│   │   ├── Seller.cs
│   │   ├── ShopContext.cs
│   │   ├── StudentModel.cs
│   │   └── User.cs
│   ├── obj/
│   ├── Program.cs # Projenin başlangıç noktası
│   ├── Properties
│   │   └── launchSettings.json
│   ├── Startup.cs
│   ├── Views # Arayüz dosyalar "<controller>/<method>.cshtml"
│   │   ├── Form
│   │   │   ├── Index.cshtml
│   │   │   ├── Save.cshtml
│   │   │   └── SeeList.cshtml
│   │   ├── Home
│   │   │   ├── Buy.cshtml
│   │   │   ├── BuyForm.cshtml
│   │   │   ├── Index.cshtml
│   │   │   ├── LookSend.cshtml
│   │   │   └── Privacy.cshtml
│   │   ├── Products
│   │   │   ├── Create.cshtml
│   │   │   ├── Delete.cshtml
│   │   │   ├── Details.cshtml
│   │   │   ├── Edit.cshtml
│   │   │   └── Index.cshtml
│   │   ├── ProductSeries
│   │   │   ├── Create.cshtml
│   │   │   ├── Delete.cshtml
│   │   │   ├── Details.cshtml
│   │   │   ├── Edit.cshtml
│   │   │   └── Index.cshtml
│   │   ├── Sales
│   │   │   ├── Create.cshtml
│   │   │   ├── Delete.cshtml
│   │   │   ├── Details.cshtml
│   │   │   ├── Edit.cshtml
│   │   │   └── Index.cshtml
│   │   ├── Sellers
│   │   │   ├── Create.cshtml
│   │   │   ├── Delete.cshtml
│   │   │   ├── Details.cshtml
│   │   │   ├── Edit.cshtml
│   │   │   └── Index.cshtml
│   │   ├── Shared
│   │   │   ├── Error.cshtml
│   │   │   ├── _Layout.cshtml
│   │   │   ├── _LoginPartial.cshtml
│   │   │   └── _ValidationScriptsPartial.cshtml
│   │   ├── _ViewImports.cshtml
│   │   └── _ViewStart.cshtml
│   ├── WebApplication2.csproj
│   └── wwwroot # Public dosyalar
│       ├── css
│       │   └── site.css
│       ├── favicon.ico
│       ├── js
│       │   └── site.js
│       └── lib
│           ├── bootstrap/
│           ├── jquery/
│           ├── jquery-validation/
│           └── jquery-validation-unobtrusive/
└── WebApplication2.sln # Visual Studio proje dosyası

```

## Kurulum
### Projeyi İndirme
Projeyi lokalinize "**FuncKing-web-homework**" adıyla çekmek için:
```bash
git clone https://github.com/FuncKing/web-programing-homework.git FuncKing-web-homework
```
Projenin içine girmek için:
```bash
cd FuncKing-web-homework
```

> `.sln` dosyası sayesinde proje Visual Studio destekleyen ortamlarda çalıştırılabilir. Linux üzerindeyseniz `cd WebApplication2` komutu ile ana koda girmeniz ve ondan sonra aşağıdaki işlemleri yapmanız gerekmektedir.

PostgreSQL üzerinde `webdb` adında bir veritabanı oluşturun ve ardından `WebApplication2/appsettings.json` dosyasındaki `ConnectionStrings` key'i içindeki `DefaultConnection` key'inin değerinde bulunan `User ID` kısmına PostgreSQL kullanıcı isminizi ve `Password` kısmına şifrenizi yazınız.
### Veritabanı migrasyonu
Entity Framework'un kurulu olduğunu varsayarak tabloları oluşturmak için
```bash
# Terminalden çalıştırmak için
dotnet ef database update
```
```bash
# Package Manager'dan çalıştırmak için
Update-Database
```

### Ayağa kaldırma
```bash
dotnet run
```

### Geliştirme sırasında hotreloading kullanımı
Dosyalardaki her değişiklik sonrasında sunucu kendini tekrardan başlatır ve tarayıcıda açık sayfa varsa kendini otomatikmen yeniler 
```bash
dotnet watch run
```

## Lisans
Bu proje [GNU General Public License v3.0](./LICENSE) kullanılarak lisanslanmıştır.
