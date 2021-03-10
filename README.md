# DesignPatterns

## Singleton Design Pattern

Bu yapıda kullanıcıya kendi başına bir nesne yaratma izni verilmez.Kullanıcı bizden sadece nesne talep edebilir.Ve bizden nesne talep ettiğinde de biz ona her defasında bellekte var olan nesneyi veririz.Böylece kullanıcı sadece tek bir nesne ile çalışmak zorunda kalır.Yani kullanıcı bir iş için 50 tane farklı nesne üretemez.
Mesela SqlConnection nesnesini bazı durumlar da çok üretmek zorunda kalıyoruz.Birden fazla SqlConnection nesnesi üretip belleğe yük bindireceğimize var olan SqlConnection nesnesi üzerinden işlem yapmamız performans açısından olumlu olacaktır.

Peki bu işi nasıl yapacağız?

Öncelikle kullanıcıya nesne yarattırmamız gerektiği bariz ortada.
Bunu sağlayabilmek için Constructor private yapılarak, kullanıcın nesne yaratması engellenir.
Kullanıcı constructor kullanarak nesne yaratamayacağı için, nesneyi ona biz vermeliyiz.Bu da ancak o class tipinde bir nesne gönderen static bir metod ya da özellikle(property) mevcuttur.
Kullanıcıya bu metod ya da property her defasında aynı nesneyi göndermeli.
Bu yüzden metod ya da property içinde if kontrolüyle aynı nesneyi göndermeyi sağlayacağız.
