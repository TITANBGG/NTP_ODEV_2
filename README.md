# 📚 Kütüphane Takip Sistemi – C# Windows Forms Uygulaması
Youtube Link : https://youtu.be/cGQKJvf636w
Bu proje, bir üniversite ödevi kapsamında geliştirilen ve nesne tabanlı programlama (OOP) ilkeleriyle tasarlanmış bir **Kütüphane Takip Uygulamasıdır**. C# programlama dili ve Windows Forms kullanılarak masaüstü ortamda geliştirilmiştir. Proje, kitap yönetimi, ödünç işlemleri ve gecikme kontrolü gibi temel işlevleri başarılı şekilde gerçekleştirecek şekilde planlanmıştır.

---

## 🎯 Projenin Amacı

Bu uygulamanın temel amacı, kütüphanedeki kitapların dijital olarak takip edilmesini sağlamaktır. Geleneksel defter veya Excel gibi araçlar yerine:

- **Kitap bilgileri** dijital olarak girilir.
- **Kitaplar ödünç verilip** iade edilebilir.
- **Geciken kitaplar** otomatik tespit edilir.
- Tüm veriler kalıcı olarak saklanır (JSON dosyasında).

Bu sayede, hem öğrenci projelerinde gerçek dünya problemlerine çözüm yaklaşımı geliştirilmiş olur, hem de OOP becerileri pekiştirilir.

---

## 🔧 Kullanılan Teknolojiler

| Teknoloji             | Açıklama                                  |
|----------------------|-------------------------------------------|
| C# (.NET Framework)  | Uygulama programlama dili                 |
| Windows Forms        | Kullanıcı arayüzü                        |
| System.Text.Json     | JSON işlemleri (veri kaydı/yükleme)      |
| DataGridView         | Kitapların ve gecikmelerin listelenmesi  |
| List<T>              | Verilerin bellekte tutulması             |

---

## 🧱 Uygulama Özellikleri

### 📌 1. Kitap Ekleme
- ISBN, Ad ve Yazar bilgileri girilerek kitap sisteme eklenir.
- Eklenen kitaplar `kitaplar.json` adlı bir dosyada kalıcı olarak saklanır.

### 📌 2. Kitap Listeleme
- Tüm kitaplar `DataGridView` içinde listelenir.
- Duruma göre ödünçte olanlar veya olmayanlar filtrelenebilir.

### 📌 3. Ödünç Alma
- Kullanıcı, ödünç alınabilir kitapları ComboBox'tan seçer.
- Seçilen kitap, `OduncDurumu = true` olarak işaretlenir.
- İade tarihi, kullanıcı tarafından belirlenir ve sistemde saklanır.

### 📌 4. Kitap İadesi
- Ödünçte olan kitaplar farklı bir ComboBox içinde gösterilir.
- Kullanıcı seçip iade eder; kitap tekrar ödünç alınabilir hale gelir.

### 📌 5. Geciken Kitapları Listeleme
- `IadeTarihi` geçmiş fakat hâlâ iade edilmemiş kitaplar listelenir.
- Bu liste ayrı bir `DataGridView` ile kullanıcıya sunulur.

---

## 🧩 Nesne Tabanlı Yapı

### 🔹 Kitap.cs
```csharp
public class Kitap
{
    public string ISBN { get; set; }
    public string Ad { get; set; }
    public string Yazar { get; set; }
    public bool OduncDurumu { get; set; }
    public DateTime? IadeTarihi { get; set; }

    public override string ToString()
    {
        return $"{Ad} - {Yazar}";
    }
}

# 🚧 Uygulama Akışı ve Teknik Detaylar

## 🔄 Uygulama Akışı

1. **Form1_Load():**
   - Uygulama başlatıldığında `kitaplar.json` dosyası okunur.
   - Kitap listesi yüklenir, ComboBox’lar uygun şekilde doldurulur.

2. **btnKitapEkle_Click():**
   - Kullanıcı tarafından girilen kitap bilgileri listeye eklenir.
   - JSON dosyasına otomatik olarak kaydedilir.

3. **btnOduncAl_Click():**
   - Seçilen kitap ödünç verilir.
   - `OduncDurumu = true` olur ve `IadeTarihi` atanır.

4. **btnIadeEt_Click():**
   - Seçilen ödünç kitap iade edilir.
   - `OduncDurumu = false` yapılır, `IadeTarihi` sıfırlanabilir.

5. **btnGecikenleriListele_Click():**
   - Sistemde `IadeTarihi` geçmiş ancak hâlâ iade edilmemiş kitaplar ayrı listelenir.

---

## 📦 JSON ile Kalıcı Veri Yönetimi

Bu projede küçük ölçekli uygulamalarda sıkça tercih edilen `JSON` formatı kullanılmıştır. Bunun nedeni:

- **Hızlı ve hafif** bir format olması
- Küçük projelerde veritabanı ihtiyacı duymadan çalışabilmesi
- `System.Text.Json` kütüphanesi ile kolayca serialize/deserialize işlemlerinin yapılabilmesi

### 📁 kitaplar.json Örneği:

```json
[
  {
    "ISBN": "9781234567890",
    "Ad": "Sefiller",
    "Yazar": "Victor Hugo",
    "OduncDurumu": true,
    "IadeTarihi": "2025-06-20T00:00:00"
  }
]
