//using System;

//namespace AstrolojiApp;

//public class Sql
//{

//    CREATE DATABASE AstrologyDb

//    use AstrologyDb

//    CREATE TABLE AppSetting(
//        Id INT PRIMARY KEY identity,
//        WorkingHours VARCHAR(255) NULL,
//     BrandName VARCHAR(255) NULL,
//     ImageUrl VARCHAR(255) NULL,
//     Title VARCHAR(255) NULL,
//     AboutText TEXT NULL,
//     HoroscopeName VARCHAR(255) NULL,
//     PhoneNumber VARCHAR(50) NULL,
//     Email VARCHAR(255) NULL
// );
// go

// insert into AppSetting(WorkingHours, BrandName, ImageUrl, Title, AboutText, HoroscopeName, PhoneNumber, Email)
// VALUES(
//     'Çalışma Saatleri: Salı - Ctesi: 10.00 - 19.00 | Pazar - Ptesi: Tatil',
//     'gezegen',
//     'http://localhost:5100/Ui/assets/img/spacePhoto.jpg',
//     '"Yıldızlarınız Söylesin, Hayatınızı Keşfedin!"',
//     'Burç yorumları, astrolojik analizler ve kişisel harita rehberliğiyle hayatınızı daha iyi anlayın. Günlük, haftalık ve aylık burç yorumlarınızı hemen öğrenin. Astrolojiye dair her şey burada! Günlük burç yorumları, gezegen konumları, yükselen burçlar ve kişisel astroloji analiziyle hayatınızı yönlendirin. Burçlarınızı ve gezegen hareketlerini keşfedin. Günlük yorumlarla hayatınızda ne gibi değişiklikler olabileceğini öğrenin ve astrolojik rehberlikle geleceğinizi şekillendirin.',
//     'Koç, Boğa, İkizler, Yengeç, Aslan, Başak, Terazi, Akrep, Yay, Oğlak, Kova, Balık',
//     '0212 000 0000',
//     'gokyuzunebakiyoruz@org.com'
// )


// CREATE TABLE AstrologComment(
//     Id INT PRIMARY KEY identity,
//     Name VARCHAR(255) NULL,
//     Text TEXT NULL,
//     Image VARCHAR(255) NULL
// );

// go


// INSERT INTO AstrologComment(Name, Text, Image)
// VALUES(
//     'John Doe',
//     'This is a very insightful horoscope. It helped me a lot today!',
//     'https://example.com/images/johndoe.jpg'
// );

//    go

//    CREATE TABLE DailyNews(
//        Id INT PRIMARY KEY identity,
//        Title VARCHAR(255) NULL,
//     Text NVARCHAR(200) NOT NULL
// );

//    go

//    INSERT INTO DailyNews(Title, Text)
// VALUES(

//     'Daily Horoscope for Today',
//     'Today’s horoscope brings positive energy and optimism. Great opportunities ahead!'
// );
//    go

//    CREATE TABLE HoroscopeGroups(
//        Id INT PRIMARY KEY identity,
//        Name VARCHAR(255) NULL,
//     Image VARCHAR(255) NULL,
//     HoroscopeNames NVARCHAR( 200) not NULL
// );

//    go

//    INSERT INTO HoroscopeGroups(Name, Image, HoroscopeNames)

// VALUES
//     ('Ateş Grubu',  'http://localhost:5100/Ui/assets/img/atesGrubu.jpg', 'Koç,Aslan,Yay'),
//     ('Toprak Grubu',  'http://localhost:5100/Ui/assets/img/toprakGrubu.jpg', 'Boğa,Başak,Oğlak'),
//     ('Hava Grubu',  'http://localhost:5100/Ui/assets/img/havaGrubu.jpg', 'İkizler,Terazi,Kova'),
//     ('Su Grubu',  'http://localhost:5100/Ui/assets/img/suGrubu.jpg', 'Yengeç,Akrep,Balık')

// go

// CREATE TABLE Horoscopes(
//     Id INT PRIMARY KEY identity,
//     Name VARCHAR(255) NULL,
//     Image VARCHAR(255) NULL,
//     DateRange VARCHAR(50) NULL
// );

// go

// INSERT INTO Horoscopes(Name, Image, DateRange)

// VALUES
//     ('Koç', 'http://localhost:5100/Ui/assets/img/koc.jpg', '21 Mart - 19 Nisan'),
//     ('Boğa', 'http://localhost:5100/Ui/assets/img/boga.jpg', '20 Nisan - 20 Mayıs'),
//     ('İkizler', 'http://localhost:5100/Ui/assets/img/ikizler.jpg', '21 Mayıs - 20 Haziran'),
//     ('Yengeç', 'http://localhost:5100/Ui/assets/img/yengec.jpg', '21 Haziran - 22 Temmuz'),
//     ('Aslan', 'http://localhost:5100/Ui/assets/img/aslan.jpg', '23 Temmuz - 22 Ağustos'),
//     ('Başak', 'http://localhost:5100/Ui/assets/img/basak.jpg', '23 Ağustos - 22 Eylül'),
//     ('Terazi', 'http://localhost:5100/Ui/assets/img/terazi.jpg', '23 Eylül - 22 Ekim'),
//     ('Akrep', 'http://localhost:5100/Ui/assets/img/akrep.jpg', '23 Ekim - 21 Kasım'),
//     ('Yay', 'http://localhost:5100/Ui/assets/img/yay.jpg', '22 Kasım - 21 Aralık'),
//     ('Oğlak', 'http://localhost:5100/Ui/assets/img/oglak.jpg', '22 Aralık - 19 Ocak'),
//     ('Kova', 'http://localhost:5100/Ui/assets/img/kova.jpg', '20 Ocak - 18 Şubat'),
//     ('Balık', 'http://localhost:5100/Ui/assets/img/balık.jpg', '19 Şubat - 20 Mart')

// go

// CREATE TABLE Services(
//     Id INT PRIMARY KEY identity,
//     Name VARCHAR(255) not NULL,
//     Title NVARCHAR(100) not NULL
// );

//    INSERT INTO Services(Name, Title)

// VALUES
//     ('AstroMap Workshop'),
//     ('Reiki Workshop'),
//     ('Tarot Workshop'),
//     ('Space Workshop')

// go


//}
