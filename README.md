# OWB Algoritma Çerçevesi (OWB Algorithm Framework)

OWB Algorithm, kullanıcı yanıtlarını ve profil verilerini belirlenen kriterlere göre değerlendirerek skorlar ve profil eşleştirme sonuçları üreten, C# tabanlı modüler bir algoritma projesidir. Anket değerlendirmeleri, psikometrik ölçümler ve veri odaklı karar destek sistemleri gibi farklı senaryolara uyarlanabilecek esnek bir altyapı sunar.

## Temel Bileşenler

- **Profile Services (`IProfileService`, `ProfileManager`):** Kullanıcı ve profil verilerinin yönetilmesi.
- **Answer Services (`IAnswerService`, `AnswerManager`):** Yanıtların alınması ve değerlendirmeye hazırlanması.
- **Evaluation Services (`IEvaluationService`, `EvaluationManager`):** Yanıtların belirlenen kurallara göre analiz edilmesi ve değerlendirme sonuçlarının üretilmesi.

Modüler ve arayüz tabanlı yapı, iş mantığının ayrıştırılmasını ve yeni değerlendirme yöntemlerinin sisteme entegre edilmesini kolaylaştırır.

## Teknolojiler

- **Framework:** .NET 9.0
- **Programlama Dili:** C# 13
- **Mimari:** Modüler servis mimarisi
- **Tasarım:** Interface tabanlı geliştirme ve Dependency Injection uyumluluğu

## Kurulum

### 1. Depoyu klonlayın

```bash
git clone https://github.com/onuraydi/OWBAlgorithm.git
cd OWBAlgorithm
```

### 2. Bağımlılıkları yükleyin

```bash
dotnet restore
```

### 3. Release modunda derleyin

```bash
dotnet build -c Release
```
