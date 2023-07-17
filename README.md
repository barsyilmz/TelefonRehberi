# Telefon Rehberi Uygulaması

Bu proje, C# dilinde konsol tabanlı bir telefon rehberi uygulamasını içermektedir.

## Telefon Numarası Kaydet

Yeni bir telefon numarası kaydetmek için aşağıdaki adımları izleyin:

1. Kullanıcıdan kişinin adını ve telefon numarasını alın.
2. `Kisi` sınıfından bir örnek oluşturun ve alınan adı ve telefon numarasını parametre olarak geçirin.
3. Oluşturulan kişi örneğini `rehber` listesine ekleyin.
4. "Kişi rehbere kaydedildi." mesajını ekrana yazdırın.

## Telefon Numarası Sil

Bir telefon numarasını silmek için aşağıdaki adımları izleyin:

1. Kullanıcıdan silmek istediği kişinin adını alın.
2. `rehber.Find` metodunu kullanarak kişiyi rehberde bulun.
3. Eğer kişi bulunursa:
    - Kişiyi `rehber` listesinden kaldırın.
    - "Kişi rehberden silindi." mesajını ekrana yazdırın.
4. Eğer kişi bulunamazsa:
    - "Kişi bulunamadı!" mesajını ekrana yazdırın.

## Telefon Numarası Güncelle

Bir telefon numarasını güncellemek için aşağıdaki adımları izleyin:

1. Kullanıcıdan güncellemek istediği kişinin adını alın.
2. `rehber.Find` metodunu kullanarak kişiyi rehberde bulun.
3. Eğer kişi bulunursa:
    - Kullanıcıdan yeni telefon numarasını alın.
    - Kişinin `Telefon` özelliğini yeni numara ile güncelleyin.
    - "Kişinin telefon numarası güncellendi." mesajını ekrana yazdırın.
4. Eğer kişi bulunamazsa:
    - "Kişi bulunamadı!" mesajını ekrana yazdırın.
## Rehberde Ara

Rehberde bir kişi aramak için aşağıdaki adımları takip edin:

1. Kullanıcıdan aranacak kişinin adını alın.
2. `rehber.FindAll` metodunu kullanarak rehberdeki kişileri adına göre filtreleyin.
3. Bulunan kişileri `bulunanlar` adlı bir liste değişkenine atayın.
4. Eğer `bulunanlar` listenin eleman sayısı 0'dan büyük ise:
    - `bulunanlar` listesindeki kişileri döngü kullanarak ekrana yazdırın.
    - Her bir kişi için `kisi.Ad` ve `kisi.Telefon` özelliklerini ekrana yazdırın.
5. Eğer `bulunanlar` listenin eleman sayısı 0 ise:
    - "Kişi bulunamadı!" mesajını ekrana yazdırın.
