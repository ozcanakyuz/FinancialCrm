# **FinancialCrm**

**FinancialCrm**, banka işlemleri, faturalar, kategoriler, harcamalar ve kullanıcı kimlik doğrulaması yönetimi için **Windows Forms** uygulamasıdır. Bu proje, **SQL veritabanı** ile entegrasyon sağlayarak finansal verilerinizi kolayca yönetmenizi sağlar.

## 🚀 Özellikler

- **Banka Yönetimi**: Banka bilgilerini yönetir (banka başlıkları, bakiye bilgileri).
- **Fatura Sistemi**: Faturaları takip eder. Yeni fatura ekleyebilir, silebilir ve güncelleyebilirsiniz.
- **Harcamalar Yönetimi**: Harcamaları kategorilere ayırarak daha düzenli bir takip sağlar.
- **Kategoriler Yönetimi**: Harcamalarınızı belirli kategorilere ayırır.
- **Kullanıcı Kimlik Doğrulama**: Kullanıcıların sisteme kayıt olmalarını ve giriş yapmalarını sağlar.
- **Dashboard**: Genel finansal durumu ve önemli bilgileri görüntüler.

## 🖥 Formlar

Aşağıda uygulamanın temel bileşenleri olan formlar yer almaktadır:

### **FrmBanks**
Banka kayıtlarını yönetmek için kullanılan formdur. Banka başlıkları ve bakiye bilgilerini ekleyebilir, güncelleyebilir veya silebilirsiniz.

- **Ekran Görüntüsü:**
  ![FrmBanks Screenshot](https://i.hizliresim.com/acxa14u.png)  

---

### **FrmBilling**
Faturaların yönetildiği formdur. Faturaları listeleyebilir, yeni fatura ekleyebilir, mevcut faturaları güncelleyebilir veya silebilirsiniz.

- **Yeni Fatura Ekleme**: Kullanıcı, yeni fatura bilgilerini girerek sisteme fatura ekler.
- **Fatura Silme**: Mevcut faturalar silinebilir.
- **Fatura Güncelleme**: Var olan faturaların bilgileri güncellenebilir.
- **Fatura Listeleme**: Sistemdeki tüm faturalar listelenebilir.

- **Ekran Görüntüsü:**
  ![FrmBilling Screenshot](https://i.hizliresim.com/p6o6nr8.png)  

---

### **FrmDashboard**
Uygulamanın ana sayfasıdır. Bankalar, faturalar, harcamalar ve kullanıcılar gibi tüm önemli modülleri bir arada gösterir ve bu modüllere geçiş yapmanıza olanak tanır.

- **Ekran Görüntüsü:**
  ![FrmDashboard Screenshot](https://i.hizliresim.com/6po3f42.png) 

---

### **FrmKayitOl**
Yeni kullanıcıların sisteme kayıt olabilmesi için kullanılan formdur. Kullanıcı adı, şifre ve diğer bilgileri girerek sisteme kayıt olabilirsiniz.

- **Ekran Görüntüsü:**
  ![FrmKayitOl Screenshot](https://i.hizliresim.com/8lato1c.png) 

---

### **FrmLogin**
Kullanıcıların sisteme giriş yapabilmesi için kullanılan formdur. Kullanıcı adı ve şifre girerek sisteme giriş yapılır.

- **Ekran Görüntüsü:**
  ![FrmLogin Screenshot](https://i.hizliresim.com/ivym0ab.png)
  ![FrmLogin Screenshot](https://i.hizliresim.com/n0q91pn.png)

---

### **Çıkış Yap**
Kullanıcıların sistemden çıkış yapabilmesi için kullanılan butondur.

- **Ekran Görüntüsü:**
  ![CikisYap Screenshot](https://i.hizliresim.com/dtzaabb.png)
  
---

## 🗄 SQL Tabloları

Bu uygulama aşağıdaki SQL tablolarını kullanmaktadır:

- **dbo.BankProcess**: Banka işlemleriyle ilgili verileri saklar.
- **dbo.Banks**: Bankalarla ilgili bilgiler içerir.
- **dbo.Bills**: Fatura bilgilerini içerir.
- **dbo.Categories**: Harcama kategorilerini içerir.
- **dbo.Spendings**: Harcama kayıtlarını içerir.
- **dbo.Users**: Kullanıcı bilgilerini içerir.

## 📊 Veritabanı Şeması

Aşağıda, veritabanının temel şeması yer almaktadır:

### **dbo.Banks**
| **Sütun Adı**  | **Veri Tipi**     |
|----------------|-------------------|
| Id             | INT (Primary Key) |
| BankTitle      | NVARCHAR(100)     |
| BankBalance    | DECIMAL(18, 2)    |

---

### **dbo.Bills**
| **Sütun Adı**  | **Veri Tipi**     |
|----------------|-------------------|
| Id             | INT (Primary Key) |
| BillTitle      | NVARCHAR(100)     |
| BillAmount     | DECIMAL(18, 2)    |

---

### **dbo.Categories**
| **Sütun Adı**  | **Veri Tipi**     |
|----------------|-------------------|
| Id             | INT (Primary Key) |
| CategoryName   | NVARCHAR(100)     |

---

### **dbo.Spendings**
| **Sütun Adı**  | **Veri Tipi**     |
|----------------|-------------------|
| Id             | INT (Primary Key) |
| Amount         | DECIMAL(18, 2)    |
| CategoryId     | INT (Foreign Key) |
| Description    | NVARCHAR(255)     |

---

### **dbo.Users**
| **Sütun Adı**  | **Veri Tipi**     |
|----------------|-------------------|
| Id             | INT (Primary Key) |
| Username       | NVARCHAR(50)      |
| Password       | NVARCHAR(255)     |
| Email          | NVARCHAR(100)     |
| CreatedAt      | DATETIME          |

---

### **dbo.BankProcess**
| **Sütun Adı**  | **Veri Tipi**     |
|----------------|-------------------|
| Id             | INT (Primary Key) |
| BankId         | INT (Foreign Key) |
| ProcessType    | NVARCHAR(50)      |
| Amount         | DECIMAL(18, 2)    |
| ProcessDate    | DATETIME          |

## ⚙️ Başlangıç

### Gereksinimler

- **Visual Studio 2022** veya daha yeni bir sürüm
- **.NET Framework 4.8** veya daha yeni bir sürüm
- **SQL Server** veritabanı yönetimi

### Kurulum

1. Projeyi **GitHub**'dan bilgisayarınıza klonlayın:

   ```bash
   git clone https://github.com/ozcanakyuz/FinancialCrm.git
   ```

2. **Visual Studio**'da çözümü açın.

3. **SQL Veritabanı**'nı yukarıdaki şemaya göre oluşturun.

4. Bağlantı dizesini **SQL Server**'a göre yapılandırın.

5. Projeyi **derleyin** ve çalıştırın.

### Kullanım

1. Uygulamayı başlatın.
2. Giriş yapın veya yeni bir kullanıcı kaydettikten sonra giriş yapın.
3. Dashboard ekranında farklı modüllere geçiş yapın.
4. Banka kayıtları, faturalar, harcamalar ve kategorilerle ilgili işlemleri yapabilirsiniz.

### Geliştirilmesi Planlanan Özellikler

- **Şifre güvenliği** için şifrelerin hashlenmesi (geliştirilme aşamasında).
- Finansal özetler için **gelişmiş raporlama** özellikleri.

## 📝 Lisans

Bu proje **MIT Lisansı** ile lisanslanmıştır - daha fazla bilgi için [LICENSE](https://github.com/ozcanakyuz/FinancialCrm/blob/main/LICENSE) dosyasına göz atabilirsiniz.

## 👏 Teşekkürler MURAT YÜCEDAĞ
