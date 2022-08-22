# Car Parts Marketplace API

---

Bu proje kullan�c�lar�n �r�nlerini direk yada teklif yoluyla satabilmeleri i�in geli�tirilmi� bir API servisidir.

---

## API Dok�mantasyonu

Projenin t�m endpointlerine ait detayl� bilgiye online dok�mantasyondan ula�mak i�in a�a��daki butona t�klay�n�z.

---

![Car Parts Marketplace API Docs (1).png](images/Car_Parts_Marketplace_API_Docs_(1).png)

## Live Demo

Projeyi test etmek i�in a�a��daki butona t�klay�n�z

---

![Car Parts Marketplace API Docs.png](images/Car_Parts_Marketplace_API_Docs.png)

## Database Design

---

![Untitled](images/Untitled.png)

## **Projede Kullan�lan Teknolojiler**

Proje N katmanl� mimari bak�� a��s�yla kodlanm��t�r. SOLID yaz�l�m geli�tirme prensiplerine uyularak geli�tirilmi�tir. Bu teknolojilere a�a��da ki listeden g�z atabilirsiniz.

- **.NET 6.0 WebAPI**
- **Entity Framework Core 6.0**
- **PostgreSQL**
- **Hangfire**
- **Json Web Token (JWT)**
- **Redis**
- **Autofac**
- **Castle Core**
- **Serilog Console & File Logger**
- **Swagger API Docs**
- **Fluent Validation**
- **Auto Mapper**
- **MailKit**
- **xUnit**
- **Moq**
- **Fluent Assertation**
- **Docker**
- **CircleCI**
- **Heroku**

## Kurulum

---

- Projeyi bilgisayar�n�za kurmak i�in ilk olarak repoyu klonlay�n�z.

```csharp
https://github.com/215-Protein-NET-Bootcamp/final-project-oguzcangenc.git
```

- Projeyi klonlad�ktan sonra `appSettings.json` i�erisinde veritaban� ba�lant�s�n� yap�n�z.

```csharp
"ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=5432;Database=CarPartsMarketplaceDb;User Id=postgres;Password=root;"
  },
```

- Burada gerekli d�zenlemeleri yapt�ktan sonra E-mail servisi i�in gerekli SMTP ayarlar�n� yap�n�z.

```csharp
"MailSettings": {
    "Mail": "mail@mail.com",
    "DisplayName": "Car Parts Marketplace",
    "Password": "123456789.*",
    "Host": "mail.mail.com",
    "Port": 465
  },
```

- Projede cache i�in Redis kullan�lmaktad�r. Redis ba�lant� ayarlar�n� kendinize g�re d�zenleyiniz.

```csharp
"Redis": {
    "Host": "localhost",
    "Password": "",
    "Port": "6379",
    "InstanceName": "redis"
  }
```

##