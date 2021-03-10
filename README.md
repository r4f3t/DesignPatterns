# DesignPatterns

## Abstract Factory Pattern

Abstract Product

Üretilecek ürünlerin soyut sınıfıdır. Belirli ürünlerin içerisindeki tüm member yapılanmasını imza olarak taşımakta ve Concrete Product yapılarına implemente etmektedir.

Concrete Product

İstemcinin üretmek istediği ürün ailesinin gerçek somut sınıflarıdır.

Abstract Factory

Ürün ailesini oluşturacak olan fabrika sınıflarına arayüz sağlayan yapıdır.

Concrete Factory

Asıl ürün ailesini oluşturan fabrikalardır.
Burada dikkatinizi çekmek istediğim bir husus vardır ki o da Abstract Factory desenini uygularken size kolaylık sağlayacak bir mantıktan ibarettir. O mantık yukarıdaki aktörlerin sıralamasında gizlidir. Anlatmak istediğim Abstract Factory desenini uygularken inşa sürecinde oluşturma önceliği yukarıda olduğu gibi “Abstract Product” ile başlayarak sırasıyla “Concrete Product”, “Abstract Factory” ve son olarakta “Concrete Factory” şeklinde seyrederseniz deseni başarıyla uygulamış ve kurmuş olacaksınız.
Şimdi bir örnek senaryo üzerinden projemizi canlandıralım. Senaryomuzda; “Sql” ve “MySql” olmak üzere iki adet veritabanı söz konusudur. Bu veritabanları client tarafından talep edilirken; ilişkisel “Connection” ve “Command” nesneleri yani ürün aileleri oluşturulacaktır. Tabi bu işlemler yapılırken istemci sadece istediği veritabanıyla ilgilenecek, ürün ailesiyle olan tüm bağlar Abstract Factory ile soyutlanmış olacak ve üretimlerinden sorumlu olmayacaktır.

