
CREATE DATABASE AstrologyDb

use AstrologyDb

CREATE TABLE AppSettings
(
    Id INT PRIMARY KEY identity,
    WorkingHours VARCHAR(255) NULL,
    BrandName VARCHAR(255) NULL,
    ImageUrl VARCHAR(1000) NULL,
    Title VARCHAR(255) NULL,
    AboutText TEXT NULL,
    HoroscopeName VARCHAR(255) NULL,
    PhoneNumber VARCHAR(50) NULL,
    Email VARCHAR(255) NULL
);
go

insert into AppSettings
    (WorkingHours, BrandName,ImageUrl,Title, AboutText,HoroscopeName, PhoneNumber,Email)
VALUES
    (
        'Çalışma Saatleri: Salı - Ctesi: 10.00 - 19.00 | Pazar - Ptesi: Tatil',
        'Bir Başka Yol',
        'http://localhost:5100/Ui/assets/img/photoast.jpg',
        '"Yıldızlarınız Söylesin, Hayatınızı Keşfedin!"',
        'Burç yorumları, astrolojik analizler ve kişisel harita rehberliğiyle hayatınızı daha iyi anlayın. Günlük, haftalık ve aylık burç yorumlarınızı hemen öğrenin. Astrolojiye dair her şey burada! Günlük burç yorumları, gezegen konumları, yükselen burçlar ve kişisel astroloji analiziyle hayatınızı yönlendirin. Burçlarınızı ve gezegen hareketlerini keşfedin. Günlük yorumlarla hayatınızda ne gibi değişiklikler olabileceğini öğrenin ve astrolojik rehberlikle geleceğinizi şekillendirin.',
        'Koç, Boğa, İkizler, Yengeç, Aslan, Başak, Terazi, Akrep, Yay, Oğlak, Kova, Balık',
        '0212 000 0000',
        'gokyuzunebakiyoruz@org.com'
);
GO

CREATE TABLE AstrologComments
(
    Id INT PRIMARY KEY identity,
    Name VARCHAR(255) not NULL,
    Text TEXT not  null ,
    Image VARCHAR(1000) not NULL
);

go


INSERT INTO AstrologComments
    (Name, Text, Image)
VALUES
    ('Aylin Yıldız', '2024 yılı, gökyüzünde birçok önemli gezegen hareketi ve tutulmalar ile dikkat çekiyor. Özellikle Yengeç ve Koç burçları için önemli bir yıl olacak. Yengeçler, ailevi ilişkilerde önemli dönüşümler yaşayacak, Koçlar ise iş ve kariyer alanında büyük atılımlar yapabilirler. Venüs’ün Balık burcundaki hareketi, romantik ilişkilerde duygusal derinliği artırırken, Uranüs’ün Boğa burcunda ilerlemesi finansal anlamda yenilikçi yaklaşımlara açık bir yılı işaret ediyor. Bu yıl, kendinize güvenin ve karşınıza çıkan fırsatları değerlendirmekten çekinmeyin.', 'http://localhost:5100/Ui/assets/img/aylin.jpg'),

    ('Burak Demir', '2024 yılı, değişim ve yenilik yılı olacak. Özellikle burçlar arasında Boğa, Akrep ve Kova burçları, Uranüs"ün etkisiyle kendilerini yeniden şekillendirecekler. Boğalar, mali anlamda radikal kararlar alabilirken, Akrepler ise psikolojik ve duygusal yenilenmeye adım atacaklar. Kova burçları için ise toplumsal bağlamda önemli değişiklikler ve sosyal projeler devreye girebilir. Bu yıl, eski kalıpları kırmak ve kendi yolunuzu çizmek için harika bir fırsat sunuyor. Hayatınızda yeni başlangıçlar yapma zamanı geldi.', 'http://localhost:5100/Ui/assets/img/burak.jpg'),

    ('Çetin Aydın', '2024 yılı, iş ve kariyer anlamında önemli adımlar atmak için çok uygun bir zaman dilimi. Özellikle Aslan, Oğlak ve Terazi burçları için bu yıl, profesyonel hayatlarında hızlı yükselme ve önemli fırsatlar barındırıyor. Aslanlar liderlik yeteneklerini daha da pekiştirirken, Oğlaklar uzun vadeli planlarını hayata geçirebilir. Teraziler ise işbirlikleri ve ortaklıklar konusunda dikkatli olmalılar, çünkü bu yıl doğru partnerlerle güçlü bağlantılar kurmak, başarılı olmanızda anahtar rol oynayacak. Finansal anlamda ise dikkatli yatırım yapmanın tam zamanı.', 'http://localhost:5100/Ui/assets/img/cetin.jpg')

go

CREATE TABLE DailyNews
(
    Id INT PRIMARY KEY identity,
    Title VARCHAR(255) NULL,
    Text NVARCHAR(4000) NOT NULL
);

go

INSERT INTO DailyNews
    (Title, Text)
VALUES
    (

        'Merkür ile Kuzey Ay Düğümü arasında kavuşum açısı olacak. Etki süresi 2 gün!!',
        'Geçmiş deneyimlerden ders çıkarma  ve iletişimle ilgili önemli bir dönemdeyiz. Bu dönemde geleceğe yönelik planlar yapmak ve projeler geliştirmek için uygun bir zaman olabilir. Kararlarınızı, fikirlerinizi değiştirecek insanlar, kitaplar, eğitimlerle karşılaşabilir, sohbetler edebilirsiniz. Yeni fikirler, düşünceler ve bilgilerle karşılaşabiliriz ki bu da bizi hayat amaçlarımza uyumlu bir yola yönlendirebilir. Daha önce göz ardı ettiğimiz veya farkında olmadığımız konulara ilgi duymaya başlayabiliriz.'
);

go

CREATE TABLE HoroscopeGroups
(
    Id INT PRIMARY KEY identity,
    Name VARCHAR(255) not NULL,
    Image VARCHAR(1000) NULL,
    HoroscopeNames NVARCHAR( 200) not NULL
);

go

INSERT INTO HoroscopeGroups
    ( Name, Image, HoroscopeNames)

VALUES
    ('Ateş Grubu', 'http://localhost:5100/Ui/assets/img/atesGrubu.jpg', 'Koç,Aslan,Yay'),
    ('Toprak Grubu', 'http://localhost:5100/Ui/assets/img/toprakGrubu.jpg', 'Boğa,Başak,Oğlak'),
    ('Hava Grubu', 'http://localhost:5100/Ui/assets/img/havaGrubu1.jpg', 'İkizler,Terazi,Kova'),
    ('Su Grubu', 'http://localhost:5100/Ui/assets/img/suGrubu1.jpg', 'Yengeç,Akrep,Balık')

go

CREATE TABLE Horoscopes
(
    Id INT PRIMARY KEY identity,
    Name VARCHAR(255) not NULL,
    Image VARCHAR(1000) not NULL,
    DateRange VARCHAR(50) not NULL
);

go

INSERT INTO Horoscopes
    ( Name, Image, DateRange)

VALUES
    ('Koç', 'http://localhost:5100/Ui/assets/img/kocc.jpg', '21 Mart - 19 Nisan'),
    ('Boğa', 'http://localhost:5100/Ui/assets/img/bogaa.jpg', '20 Nisan - 20 Mayıs'),
    ('İkizler', 'http://localhost:5100/Ui/assets/img/ikizlerr.jpg', '21 Mayıs - 20 Haziran'),
    ('Yengeç', 'http://localhost:5100/Ui/assets/img/yengecc.jpg', '21 Haziran - 22 Temmuz'),
    ('Aslan', 'http://localhost:5100/Ui/assets/img/aslann.jpg', '23 Temmuz - 22 Ağustos'),
    ('Başak', 'http://localhost:5100/Ui/assets/img/basakk.jpg', '23 Ağustos - 22 Eylül'),
    ('Terazi', 'http://localhost:5100/Ui/assets/img/terazii.jpg', '23 Eylül - 22 Ekim'),
    ('Akrep', 'http://localhost:5100/Ui/assets/img/akrepp.jpg', '23 Ekim - 21 Kasım'),
    ('Yay', 'http://localhost:5100/Ui/assets/img/yayy.jpg', '22 Kasım - 21 Aralık'),
    ('Oğlak', 'http://localhost:5100/Ui/assets/img/oglakk.jpg', '22 Aralık - 19 Ocak'),
    ('Kova', 'http://localhost:5100/Ui/assets/img/kovaa.jpg', '20 Ocak - 18 Şubat'),
    ('Balık', 'http://localhost:5100/Ui/assets/img/balıkk.jpg', '19 Şubat - 20 Mart')

go

CREATE TABLE Services
(
    Id INT PRIMARY KEY identity,
    Name VARCHAR(255) not NULL,
    Title NVARCHAR(2000) not NULL

);
GO
INSERT INTO Services
    ( Name, Title)
VALUES
    ('AstroMap Workshop', 'AstroMap Workshop, katilimcilara dogum haritalarini derinlemesine analiz etmeyi ve hayatlarindaki potansiyel yollari kesfetmeyi ögretir. Kendi astrolojik haritanizi çözerek, kisisel gelisiminiz için güçlü bir rehber olusturabilirsiniz.'),
    ('Reiki Workshop', 'Reiki Workshop, katilimcilara bedensel, zihinsel ve duygusal dengeyi saglamak için Reiki enerjisini nasil kullanacaklarini ögretir. Enerji çalismalari ile kendinizi iyilestirmenin ve çevrenizdeki insanlara sifa vermenin yollarini kesfedin.'),
    ('Tarot Workshop', 'Tarot Workshop, kartlar aracılığıyla kendinizle ve evrenle daha derin bir bağlantı kurmanızı sağlar. Tarot^un sembollerini öğrenerek, hayatınızdaki sorulara rehberlik edecek anlamlı okumalar yapmayı öğrenebilirsiniz.'),
    ('Evren Workshop', 'Evren Workshop, kişisel yaşam alanlarınıza enerjiyi nasıl yönlendirebileceğinizi ve mekanlarınızda dengeyi nasıl sağlayacağınızı öğretir. Feng Shui tekniklerini kullanarak, evinizde huzur ve olumlu enerji akışını sağlamak mümkün.')

go

CREATE TABLE SocialMedias
(
    Id int PRIMARY KEY IDENTITY,
    Name NVARCHAR(400) NOT null,
    Url NVARCHAR(1000) NOT null,
    Icon NVARCHAR(1000) NOT null
);
GO

INSERT INTO SocialMedias
    (Name,Url,Icon)

VALUES
    ('Facebook', 'https://www.facebook.com', '<i class="bi bi-facebook"></i>'),
    ('Twitter', 'https://www.twitter.com', '<i class="bi bi-twitter-x"></i>'),
    ('Instagram', 'https://www.instagram.com', '<i class="bi bi-instagram"></i>'),
    ('TikTok', 'https://www.tiktok.com', '<i class="bi bi-tiktok"></i>')
    GO

CREATE TABLE Contacts
(
    Id int PRIMARY KEY IDENTITY,
    Address NVARCHAR(400) NOT null,
    PhoneNumber NVARCHAR(1000) NOT null,
    Icon NVARCHAR(1000) NOT null,
    Map NVARCHAR(1000) NOT null
)
GO

INSERT INTO Contacts
    (Address,PhoneNumber,Icon,Map)

VALUES
    ('Kadıköy', '02120003131', '<i class="bi bi-geo-alt-fill"></i>', '<iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3011.717235259264!2d29.0368903!3d40.9876722!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14cab870784d1389%3A0x2bf4921764859e70!2zw5xsa2VyIEZlbmVyYmFow6dlIMWew7xrcsO8IFNhcmFjb8SfbHUgU3RhZHl1bXU!5e0!3m2!1str!2str!4v1731415851676!5m2!1str!2str" width="600" height="450" style="border:0;" allowfullscreen="" loading="lazy" referrerpolicy="no-referrer-when-downgrade"></iframe>')
    GO


CREATE TABLE HoroscopeComments
(
    Id int PRIMARY KEY IDENTITY,
    HoroscopeId int ,
    Daily NVARCHAR(3000) not null,
    Monthly NVARCHAR(3000) not null,
    Annual NVARCHAR(3000) not null,
    FOREIGN KEY (HoroscopeId) REFERENCES Horoscopes (Id)
)

insert into HoroscopeComments
    (HoroscopeId, Daily,Monthly,Annual )

VALUES

    (1, 'Ruhunuzdaki zenginliği ve yaratıcılığı ortaya koyma zamanı, ilham perisi bugün sizin yanınızda olabilir. Ayrıca yardımsever, hayırsever yönlerinizi bugün daha çok gösterebilir, başkalarının iyiliği için çalışabilirsiniz.', 'Ruhunuzdaki zenginliği ve yaratıcılığı ortaya koyma zamanı, ilham perisi bugün sizin yanınızda olabilir. Ayrıca yardımsever, hayırsever yönlerinizi bugün daha çok gösterebilir, başkalarının iyiliği için çalışabilirsiniz.', 'Ruhunuzdaki zenginliği ve yaratıcılığı ortaya koyma zamanı, ilham perisi bugün sizin yanınızda olabilir. Ayrıca yardımsever, hayırsever yönlerinizi bugün daha çok gösterebilir, başkalarının iyiliği için çalışabilirsiniz.'),

    (2, 'Ruhunuzdaki zenginliği ve yaratıcılığı ortaya koyma zamanı, ilham perisi bugün sizin yanınızda olabilir. Ayrıca yardımsever, hayırsever yönlerinizi bugün daha çok gösterebilir, başkalarının iyiliği için çalışabilirsiniz.', 'Ruhunuzdaki zenginliği ve yaratıcılığı ortaya koyma zamanı, ilham perisi bugün sizin yanınızda olabilir. Ayrıca yardımsever, hayırsever yönlerinizi bugün daha çok gösterebilir, başkalarının iyiliği için çalışabilirsiniz.', 'Ruhunuzdaki zenginliği ve yaratıcılığı ortaya koyma zamanı, ilham perisi bugün sizin yanınızda olabilir. Ayrıca yardımsever, hayırsever yönlerinizi bugün daha çok gösterebilir, başkalarının iyiliği için çalışabilirsiniz.'),

    (3, 'Ruhunuzdaki zenginliği ve yaratıcılığı ortaya koyma zamanı, ilham perisi bugün sizin yanınızda olabilir. Ayrıca yardımsever, hayırsever yönlerinizi bugün daha çok gösterebilir, başkalarının iyiliği için çalışabilirsiniz.', 'Ruhunuzdaki zenginliği ve yaratıcılığı ortaya koyma zamanı, ilham perisi bugün sizin yanınızda olabilir. Ayrıca yardımsever, hayırsever yönlerinizi bugün daha çok gösterebilir, başkalarının iyiliği için çalışabilirsiniz.', 'Ruhunuzdaki zenginliği ve yaratıcılığı ortaya koyma zamanı, ilham perisi bugün sizin yanınızda olabilir. Ayrıca yardımsever, hayırsever yönlerinizi bugün daha çok gösterebilir, başkalarının iyiliği için çalışabilirsiniz.'),

    (4, 'Ruhunuzdaki zenginliği ve yaratıcılığı ortaya koyma zamanı, ilham perisi bugün sizin yanınızda olabilir. Ayrıca yardımsever, hayırsever yönlerinizi bugün daha çok gösterebilir, başkalarının iyiliği için çalışabilirsiniz.', 'Ruhunuzdaki zenginliği ve yaratıcılığı ortaya koyma zamanı, ilham perisi bugün sizin yanınızda olabilir. Ayrıca yardımsever, hayırsever yönlerinizi bugün daha çok gösterebilir, başkalarının iyiliği için çalışabilirsiniz.', 'Ruhunuzdaki zenginliği ve yaratıcılığı ortaya koyma zamanı, ilham perisi bugün sizin yanınızda olabilir. Ayrıca yardımsever, hayırsever yönlerinizi bugün daha çok gösterebilir, başkalarının iyiliği için çalışabilirsiniz.'),

    (5, 'Ruhunuzdaki zenginliği ve yaratıcılığı ortaya koyma zamanı, ilham perisi bugün sizin yanınızda olabilir. Ayrıca yardımsever, hayırsever yönlerinizi bugün daha çok gösterebilir, başkalarının iyiliği için çalışabilirsiniz.', 'Ruhunuzdaki zenginliği ve yaratıcılığı ortaya koyma zamanı, ilham perisi bugün sizin yanınızda olabilir. Ayrıca yardımsever, hayırsever yönlerinizi bugün daha çok gösterebilir, başkalarının iyiliği için çalışabilirsiniz.', 'Ruhunuzdaki zenginliği ve yaratıcılığı ortaya koyma zamanı, ilham perisi bugün sizin yanınızda olabilir. Ayrıca yardımsever, hayırsever yönlerinizi bugün daha çok gösterebilir, başkalarının iyiliği için çalışabilirsiniz.'),

    (6, 'Ruhunuzdaki zenginliği ve yaratıcılığı ortaya koyma zamanı, ilham perisi bugün sizin yanınızda olabilir. Ayrıca yardımsever, hayırsever yönlerinizi bugün daha çok gösterebilir, başkalarının iyiliği için çalışabilirsiniz.', 'Ruhunuzdaki zenginliği ve yaratıcılığı ortaya koyma zamanı, ilham perisi bugün sizin yanınızda olabilir. Ayrıca yardımsever, hayırsever yönlerinizi bugün daha çok gösterebilir, başkalarının iyiliği için çalışabilirsiniz.', 'Ruhunuzdaki zenginliği ve yaratıcılığı ortaya koyma zamanı, ilham perisi bugün sizin yanınızda olabilir. Ayrıca yardımsever, hayırsever yönlerinizi bugün daha çok gösterebilir, başkalarının iyiliği için çalışabilirsiniz.'),

    (7, 'Ruhunuzdaki zenginliği ve yaratıcılığı ortaya koyma zamanı, ilham perisi bugün sizin yanınızda olabilir. Ayrıca yardımsever, hayırsever yönlerinizi bugün daha çok gösterebilir, başkalarının iyiliği için çalışabilirsiniz.', 'Ruhunuzdaki zenginliği ve yaratıcılığı ortaya koyma zamanı, ilham perisi bugün sizin yanınızda olabilir. Ayrıca yardımsever, hayırsever yönlerinizi bugün daha çok gösterebilir, başkalarının iyiliği için çalışabilirsiniz.', 'Ruhunuzdaki zenginliği ve yaratıcılığı ortaya koyma zamanı, ilham perisi bugün sizin yanınızda olabilir. Ayrıca yardımsever, hayırsever yönlerinizi bugün daha çok gösterebilir, başkalarının iyiliği için çalışabilirsiniz.'),

    (8, 'Ruhunuzdaki zenginliği ve yaratıcılığı ortaya koyma zamanı, ilham perisi bugün sizin yanınızda olabilir. Ayrıca yardımsever, hayırsever yönlerinizi bugün daha çok gösterebilir, başkalarının iyiliği için çalışabilirsiniz.', 'Ruhunuzdaki zenginliği ve yaratıcılığı ortaya koyma zamanı, ilham perisi bugün sizin yanınızda olabilir. Ayrıca yardımsever, hayırsever yönlerinizi bugün daha çok gösterebilir, başkalarının iyiliği için çalışabilirsiniz.', 'Ruhunuzdaki zenginliği ve yaratıcılığı ortaya koyma zamanı, ilham perisi bugün sizin yanınızda olabilir. Ayrıca yardımsever, hayırsever yönlerinizi bugün daha çok gösterebilir, başkalarının iyiliği için çalışabilirsiniz.'),

    (9, 'Ruhunuzdaki zenginliği ve yaratıcılığı ortaya koyma zamanı, ilham perisi bugün sizin yanınızda olabilir. Ayrıca yardımsever, hayırsever yönlerinizi bugün daha çok gösterebilir, başkalarının iyiliği için çalışabilirsiniz.', 'Ruhunuzdaki zenginliği ve yaratıcılığı ortaya koyma zamanı, ilham perisi bugün sizin yanınızda olabilir. Ayrıca yardımsever, hayırsever yönlerinizi bugün daha çok gösterebilir, başkalarının iyiliği için çalışabilirsiniz.', 'Ruhunuzdaki zenginliği ve yaratıcılığı ortaya koyma zamanı, ilham perisi bugün sizin yanınızda olabilir. Ayrıca yardımsever, hayırsever yönlerinizi bugün daha çok gösterebilir, başkalarının iyiliği için çalışabilirsiniz.'),

    (10, 'Ruhunuzdaki zenginliği ve yaratıcılığı ortaya koyma zamanı, ilham perisi bugün sizin yanınızda olabilir. Ayrıca yardımsever, hayırsever yönlerinizi bugün daha çok gösterebilir, başkalarının iyiliği için çalışabilirsiniz.', 'Ruhunuzdaki zenginliği ve yaratıcılığı ortaya koyma zamanı, ilham perisi bugün sizin yanınızda olabilir. Ayrıca yardımsever, hayırsever yönlerinizi bugün daha çok gösterebilir, başkalarının iyiliği için çalışabilirsiniz.', 'Ruhunuzdaki zenginliği ve yaratıcılığı ortaya koyma zamanı, ilham perisi bugün sizin yanınızda olabilir. Ayrıca yardımsever, hayırsever yönlerinizi bugün daha çok gösterebilir, başkalarının iyiliği için çalışabilirsiniz.'),

    (11, 'Ruhunuzdaki zenginliği ve yaratıcılığı ortaya koyma zamanı, ilham perisi bugün sizin yanınızda olabilir. Ayrıca yardımsever, hayırsever yönlerinizi bugün daha çok gösterebilir, başkalarının iyiliği için çalışabilirsiniz.', 'Ruhunuzdaki zenginliği ve yaratıcılığı ortaya koyma zamanı, ilham perisi bugün sizin yanınızda olabilir. Ayrıca yardımsever, hayırsever yönlerinizi bugün daha çok gösterebilir, başkalarının iyiliği için çalışabilirsiniz.', 'Ruhunuzdaki zenginliği ve yaratıcılığı ortaya koyma zamanı, ilham perisi bugün sizin yanınızda olabilir. Ayrıca yardımsever, hayırsever yönlerinizi bugün daha çok gösterebilir, başkalarının iyiliği için çalışabilirsiniz.'),

    (12, 'Ruhunuzdaki zenginliği ve yaratıcılığı ortaya koyma zamanı, ilham perisi bugün sizin yanınızda olabilir. Ayrıca yardımsever, hayırsever yönlerinizi bugün daha çok gösterebilir, başkalarının iyiliği için çalışabilirsiniz.', 'Ruhunuzdaki zenginliği ve yaratıcılığı ortaya koyma zamanı, ilham perisi bugün sizin yanınızda olabilir. Ayrıca yardımsever, hayırsever yönlerinizi bugün daha çok gösterebilir, başkalarının iyiliği için çalışabilirsiniz.', 'Ruhunuzdaki zenginliği ve yaratıcılığı ortaya koyma zamanı, ilham perisi bugün sizin yanınızda olabilir. Ayrıca yardımsever, hayırsever yönlerinizi bugün daha çok gösterebilir, başkalarının iyiliği için çalışabilirsiniz.')

