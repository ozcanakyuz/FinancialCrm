# **FinancialCrm**

**FinancialCrm**, banka işlemleri, faturalar, kategoriler, harcamalar ve kullanıcı kimlik doğrulaması yönetimi için **Windows Forms** uygulamasıdır. Bu proje, **SQL veritabanı** ile entegre bir yapıya sahip olup finansal yönetim süreçlerini kolaylaştırır.

---

## 🚀 **Özellikler**

- **Banka Yönetimi**: Banka bilgilerini ve bakiye durumunu yönetin.
- **Fatura Yönetimi**: Faturalarınızı listeleyin, ekleyin, silin ve güncelleyin.
- **Harcamalar Yönetimi**: Harcamalarınızı kategorilere ayırarak takip edin.
- **Kategori Yönetimi**: Harcamalarınız için özel kategoriler oluşturun.
- **Kullanıcı Yönetimi**: Şifre değişikliği ve kullanıcı kimlik doğrulaması.
- **Raporlama**: Genel finansal durumu analiz edin ve işlem geçmişini görün.
- **Filtreleme Seçenekleri**: İşlemleri “Tümünü Göster,” “Maksimum Ücretli” ve “Minimum Ücretli” gibi kriterlere göre filtreleyin.

---

## 🖥 **Formlar**

### **FrmDashboard**
Uygulamanın ana kontrol panelidir. Bankalar, faturalar, harcamalar ve kategoriler gibi tüm modüllere buradan geçiş yapılır.

- **Ekran Görüntüsü:**
  ![FrmDashboard Screenshot](https://github.com/ozcanakyuz/FinancialCrm/raw/master/FinancialCrm/assets/dashboard.png)

---

### **FrmCategories**
Kategoriler formu yalnızca harcama kategorilerini yönetmek için kullanılır.

- **Kategori İşlemleri**:
  - Kategori ekleme
  - Kategori güncelleme
  - Kategori silme

- **Ekran Görüntüsü:**
  ![FrmCategories Screenshot](https://github.com/ozcanakyuz/FinancialCrm/raw/master/FinancialCrm/assets/kategoriler.png)

---

### **FrmBanks**
Banka kayıtlarını gösterir. Banka başlıkları, hesap numaraları ve hesap bakiyeleri görüntülenir.

- **Ekran Görüntüsü:**
  ![FrmBanks Screenshot](https://github.com/ozcanakyuz/FinancialCrm/raw/master/FinancialCrm/assets/banka.png)

---

### **FrmBilling**
Faturaların eklenmesi, düzenlenmesi ve silinmesi için kullanılır. Fatura başlığı, tutarı gibi bilgiler kaydedilebilir.

- **Ekran Görüntüsü:**
  ![FrmBilling Screenshot](https://github.com/ozcanakyuz/FinancialCrm/raw/master/FinancialCrm/assets/odeme.png)

---

### **FrmSpendings**
Bu form, harcamalarınızı yönetmek için tasarlanmıştır.

- **Harcama İşlemleri**:
  - Yeni harcama ekleme (Harcama adı, tutarı, tarihi ve kategorisi)
  - Harcama silme
  - Harcama güncelleme

- **Ekran Görüntüsü:**
  ![FrmSpendings Screenshot](https://github.com/ozcanakyuz/FinancialCrm/raw/master/FinancialCrm/assets/harcama.png)

---

### **FrmBankProcess**
Bu form, banka işlemlerini ve hareket geçmişini görüntüler.

- **Son 9 Banka Hareketi**: Bankalar arasındaki son 9 işlem listelenir.
- **Filtreleme Özellikleri**:
  - **Tümünü Göster**: Tüm işlemleri listeleyin.
  - **Maksimum Ücretli**: En yüksek işlem tutarlarını gösterir.
  - **Minimum Ücretli**: En düşük işlem tutarlarını gösterir.

- **Ekran Görüntüsü:**
  ![FrmBankProcess Screenshot](https://github.com/ozcanakyuz/FinancialCrm/raw/master/FinancialCrm/assets/bankahareketleri_filtre.png)
  ![FrmBankProcess Screenshot](https://github.com/ozcanakyuz/FinancialCrm/raw/master/FinancialCrm/assets/bankahareketleri_tümü.png)
  ![FrmBankProcess Screenshot](https://github.com/ozcanakyuz/FinancialCrm/raw/master/FinancialCrm/assets/bankahareketleri_max.png)
  ![FrmBankProcess Screenshot](https://github.com/ozcanakyuz/FinancialCrm/raw/master/FinancialCrm/assets/bankahareketleri_min.png)

---

### **FrmSettings**
Kullanıcıların şifrelerini değiştirmelerine olanak tanır.

- **Ekran Görüntüsü:**
  ![FrmSettings Screenshot](https://github.com/ozcanakyuz/FinancialCrm/raw/master/FinancialCrm/assets/ayarlar.png)

---

### **Çıkış Yap**
Kullanıcıların sistemden çıkış yapabilmesi için kullanılan butondur.

- **Ekran Görüntüsü:**
  ![CikisYap Screenshot](https://github.com/ozcanakyuz/FinancialCrm/raw/master/FinancialCrm/assets/cikisyap.png)

---

### **FrmKayitOl**
Yeni kullanıcıların sisteme kayıt olabilmesi için kullanılan formdur. Kullanıcı adı, şifre ve diğer bilgileri girerek sisteme kayıt olabilirsiniz.

- **Ekran Görüntüsü:**
  ![FrmKayitOl Screenshot](https://github.com/ozcanakyuz/FinancialCrm/raw/master/FinancialCrm/assets/kayitol.png)
  ![FrmKayitOl Screenshot](https://github.com/ozcanakyuz/FinancialCrm/raw/master/FinancialCrm/assets/kayitol_basarili.png)

---

### **FrmLogin**
Kullanıcıların sisteme giriş yapabilmesi için kullanılan formdur. Kullanıcı adı ve şifre girerek sisteme giriş yapılır.

- **Ekran Görüntüsü:**
  ![FrmLogin Screenshot](https://github.com/ozcanakyuz/FinancialCrm/raw/master/FinancialCrm/assets/login.png)
  ![FrmLogin Screenshot](https://github.com/ozcanakyuz/FinancialCrm/raw/master/FinancialCrm/assets/login_basarili.png)

---


## 🗄 **SQL Tabloları**

1. **dbo.Banks**: Banka bilgilerini içerir.
2. **dbo.BankProcess**: Banka hareket geçmişini tutar.
3. **dbo.Categories**: Harcama kategorilerini içerir.
4. **dbo.Spendings**: Harcama kayıtlarını saklar.
5. **dbo.Users**: Kullanıcı bilgilerini içerir.
6. **dbo.Bills**: Fatura bilgilerini tutar.

---

## ⚙️ **Başlangıç**

### Gereksinimler

- **Visual Studio 2022** veya daha güncel bir IDE
- **.NET Framework 4.8**
- **SQL Server**

### Kurulum

1. Projeyi klonlayın:
   ```bash
   git clone https://github.com/ozcanakyuz/FinancialCrm.git
   ```
2. SQL veritabanını oluşturun.
3. Bağlantı dizesini yapılandırın.
4. Projeyi çalıştırın.

---

## 📝 **Lisans**

Bu proje **MIT Lisansı** ile lisanslanmıştır. Daha fazla bilgi için [LICENSE](https://github.com/ozcanakyuz/FinancialCrm/blob/main/LICENSE) dosyasını inceleyebilirsiniz.

---

## 👏 **Teşekkürler**
Bu proje **Murat Yücedağ (C# Eğitim Kampı)** katkıları sayesinde geliştirilmiştir. Yardımlarınız ve katkılarınız için teşekkür ederim!

