# C# LINQ Sözdizimi Karşılaştırması
## İki Yaklaşım: Query Syntax (SQL Benzeri) ve Method Syntax (Lambda)

Bu proje, C# dilindeki **Language Integrated Query (LINQ)** yapısını kullanarak aynı veri işleme görevini iki farklı sözdizimi ile gerçekleştirmeyi amaçlamaktadır. Proje, hem **LINQ Sorgu Sözdizimi** hem de **LINQ Metot Sözdizimi** arasındaki yapısal farkı ve çıktı tutarlılığını göstermektedir.

### Senaryo Detayları

Başlangıçta tanımlı olan `Student` (Öğrenci) listesi üzerinde aşağıdaki ardışık işlemler uygulanmıştır:

1.  **Filtreleme:** Yaşı **18'den kesinlikle büyük** olan öğrencileri seçmek (`Age > 18`).
2.  **Sıralama:** Filtrelenen öğrencileri **adlarına göre alfabetik** olarak sıralamak (`Name` alanına göre A-Z).
3.  **Çıktı:** Sonuç kümesini bir `List<Student>` tipine dönüştürmek.

### Dosya ve Yapı

* **`Program.cs`**: `Student` sınıfı tanımını, başlangıç öğrenci verilerini ve aynı senaryoyu uygulayan iki farklı LINQ sorgusunu içeren ana uygulama dosyasıdır.

### Çalıştırma Talimatları

Bu kod, bir **.NET Konsol Uygulaması** projesi içerisinde çalıştırılmak üzere tasarlanmıştır.

1.  Visual Studio'da yeni bir Konsol Uygulaması projesi oluşturun.
2.  Projenin ana kodu olan `Program.cs` dosyasının içeriğini bu depodaki kod ile tamamen değiştirin.
3.  Uygulamayı derlemek ve çalıştırmak için **F5** tuşuna basın.
4.  Konsol çıktısı, iki farklı sorgu tipinin de aynı sonuç kümesini ürettiğini gösterecektir.

Bu basit denemenin geliştirilmesine yönelik öneri veya katkılarınız varsa (farklı LINQ operatörleri, performans optimizasyonu vb.), lütfen bir Pull Request (Çekme İsteği) açmaktan çekinmeyin.

© [GitHub Kullanıcı Adınız]
