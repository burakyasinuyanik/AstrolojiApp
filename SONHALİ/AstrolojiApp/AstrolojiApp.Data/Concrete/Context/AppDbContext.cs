using System;
using AstrolojiApp.Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace AstrolojiApp.Data.Concrete.Context;

public class AppDbContext : DbContext
{

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Horoscope> Horoscopes { get; set; }
    public DbSet<AppSetting> AppSettings { get; set; }
    public DbSet<AstrologComment> AstrologComments { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<DailyNew> DailyNews { get; set; }
    public DbSet<HoroscopeComment> HoroscopeComments { get; set; }
    public DbSet<HoroscopeGroup> HoroscopeGroups { get; set; }
    public DbSet<Service> Services { get; set; }
    public DbSet<SocialMedia> SocialMedias { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<AppSetting>(entity =>
        {
            entity.HasData(
                new AppSetting
                {
                    Id = 1,
                    WorkingHours = "Çalışma Saatleri: Salı - Ctesi: 10.00 - 19.00 | Pazar - Ptesi: Tatil",
                    BrandName = "Bir Başka Yol",
                    ImageUrl = "/Ui/assets/img/photoast.jpg",
                    Title = "Yıldızlarınız Söylesin, Hayatınızı Keşfedin!",
                    AboutText = "Burç yorumları, astrolojik analizler ve kişisel harita rehberliğiyle hayatınızı daha iyi anlayın. Günlük, haftalık ve aylık burç yorumlarınızı hemen öğrenin. Astrolojiye dair her şey burada! Günlük burç yorumları, gezegen konumları, yükselen burçlar ve kişisel astroloji analiziyle hayatınızı yönlendirin. Burçlarınızı ve gezegen hareketlerini keşfedin. Günlük yorumlarla hayatınızda ne gibi değişiklikler olabileceğini öğrenin ve astrolojik rehberlikle geleceğinizi şekillendirin.",
                    HoroscopeName = "Koç, Boğa, İkizler, Yengeç, Aslan, Başak, Terazi, Akrep, Yay, Oğlak, Kova, Balık",
                    PhoneNumber = "0212 000 0000",
                    Email = "gokyuzunebakiyoruz@org.com"
                }

            );

        });

        builder.Entity<AstrologComment>(entity =>
        {

            entity.HasData(
                new AstrologComment
                {
                    Id = 1,
                    Name = "Aylin Yıldız",
                    Text = "2024 yılı, gökyüzünde birçok önemli gezegen hareketi ve tutulmalar ile dikkat çekiyor. Özellikle Yengeç ve Koç burçları için önemli bir yıl olacak. Yengeçler, ailevi ilişkilerde önemli dönüşümler yaşayacak, Koçlar ise iş ve kariyer alanında büyük atılımlar yapabilirler. Venüs’ün Balık burcundaki hareketi, romantik ilişkilerde duygusal derinliği artırırken, Uranüs’ün Boğa burcunda ilerlemesi finansal anlamda yenilikçi yaklaşımlara açık bir yılı işaret ediyor. Bu yıl, kendinize güvenin ve karşınıza çıkan fırsatları değerlendirmekten çekinmeyin.",
                    Image = "/Ui/assets/img/aylin.jpg",

                },
                new AstrologComment
                {
                    Id = 2,
                    Name = "Burak Demir",
                    Text = "2024 yılı, değişim ve yenilik yılı olacak. Özellikle burçlar arasında Boğa, Akrep ve Kova burçları, Uranüsün etkisiyle kendilerini yeniden şekillendirecekler. Boğalar, mali anlamda radikal kararlar alabilirken, Akrepler ise psikolojik ve duygusal yenilenmeye adım atacaklar. Kova burçları için ise toplumsal bağlamda önemli değişiklikler ve sosyal projeler devreye girebilir. Bu yıl, eski kalıpları kırmak ve kendi yolunuzu çizmek için harika bir fırsat sunuyor. Hayatınızda yeni başlangıçlar yapma zamanı geldi.",
                    Image = "/Ui/assets/img/burak.jpg",

                },
                new AstrologComment
                {
                    Id = 3,
                    Name = "Çetin Aydın",
                    Text = "2024 yılı, iş ve kariyer anlamında önemli adımlar atmak için çok uygun bir zaman dilimi. Özellikle Aslan, Oğlak ve Terazi burçları için bu yıl, profesyonel hayatlarında hızlı yükselme ve önemli fırsatlar barındırıyor. Aslanlar liderlik yeteneklerini daha da pekiştirirken, Oğlaklar uzun vadeli planlarını hayata geçirebilir. Teraziler ise işbirlikleri ve ortaklıklar konusunda dikkatli olmalılar, çünkü bu yıl doğru partnerlerle güçlü bağlantılar kurmak, başarılı olmanızda anahtar rol oynayacak. Finansal anlamda ise dikkatli yatırım yapmanın tam zamanı.",
                    Image = "/Ui/assets/img/cetin.jpg",

                }


            );
        });

        builder.Entity<DailyNew>(entity =>
        {
            entity.HasData(
                 new DailyNew
                 {
                     Id = 1,
                     Title = "Merkür ile Kuzey Ay Düğümü arasında kavuşum açısı olacak. Etki süresi 2 gün!!",
                     Text = "Geçmiş deneyimlerden ders çıkarma  ve iletişimle ilgili önemli bir dönemdeyiz. Bu dönemde geleceğe yönelik planlar yapmak ve projeler geliştirmek için uygun bir zaman olabilir. Kararlarınızı, fikirlerinizi değiştirecek insanlar, kitaplar, eğitimlerle karşılaşabilir, sohbetler edebilirsiniz. Yeni fikirler, düşünceler ve bilgilerle karşılaşabiliriz ki bu da bizi hayat amaçlarımza uyumlu bir yola yönlendirebilir. Daha önce göz ardı ettiğimiz veya farkında olmadığımız konulara ilgi duymaya başlayabiliriz."
                 }
            );

        });

        builder.Entity<HoroscopeGroup>(entity =>
        {

            entity.HasData(
                new HoroscopeGroup
                {
                    Id = 1,
                    Name = "Ateş Grubu",
                    Image = "/Ui/assets/img/AtesGrubu.jpg",
                    HoroscopeNames = "Koç,Aslan,Yay"
                },
                 new HoroscopeGroup
                 {
                     Id = 2,
                     Name = "Toprak Grubu",
                     Image = "/Ui/assets/img/ToprakGrubu.jpg",
                     HoroscopeNames = "Boğa,Başak,Oğlak"
                 },
                  new HoroscopeGroup
                  {
                      Id = 3,
                      Name = "Hava Grubu",
                      Image = "/Ui/assets/img/HavaGrubu.jpg",
                      HoroscopeNames = "İkizler,Terazi,Kova"
                  },
                   new HoroscopeGroup
                   {
                       Id = 4,
                       Name = "Su Grubu",
                       Image = "/Ui/assets/img/SuGrubu.jpg",
                       HoroscopeNames = "Yengeç,Akrep,Balık"
                   }
            );
        });

        builder.Entity<Horoscope>(entity =>
        {

            entity.HasData(
                new Horoscope
                {
                    Id = 1,
                    Name = "Koç",
                    Image = "/Ui/assets/img//Koc.jpg",
                    DateRange = "21 Mart - 20 Nisan"
                },
        new Horoscope
        {
            Id = 2,
            Name = "Boğa",
            Image = "/Ui/assets/img//Boga.jpg",
            DateRange = "21 Nisan - 20 Mayıs"
        },
        new Horoscope
        {
            Id = 3,
            Name = "İkizler",
            Image = "/Ui/assets/img/ikizler.jpg",
            DateRange = "21 Mayıs - 21 Haziran"
        },
        new Horoscope
        {
            Id = 4,
            Name = "Yengeç",
            Image = "/Ui/assets/img/Yengec.jpg",
            DateRange = "22 Haziran - 22 Temmuz"
        },
        new Horoscope
        {
            Id = 5,
            Name = "Aslan",
            Image = "/Ui/assets/img/Aslan.jpg",
            DateRange = "23 Temmuz - 22 Ağustos"
        },
        new Horoscope
        {
            Id = 6,
            Name = "Başak",
            Image = "/Ui/assets/img/Basak.jpg",
            DateRange = "23 Ağustos - 22 Eylül"
        },
        new Horoscope
        {
            Id = 7,
            Name = "Terazi",
            Image = "/Ui/assets/img/Terazi.jpg",
            DateRange = "23 Eylül - 22 Ekim"
        },
        new Horoscope
        {
            Id = 8,
            Name = "Akrep",
            Image = "/Ui/assets/img/Akrep.jpg",
            DateRange = "23 Ekim - 21 Kasım"
        },
        new Horoscope
        {
            Id = 9,
            Name = "Yay",
            Image = "/Ui/assets/img/Yay.jpg",
            DateRange = "22 Kasım - 21 Aralık"
        },
        new Horoscope
        {
            Id = 10,
            Name = "Oğlak",
            Image = "/Ui/assets/img/Oglak.jpg",
            DateRange = "22 Aralık - 19 Ocak"
        },
        new Horoscope
        {
            Id = 11,
            Name = "Kova",
            Image = "/Ui/assets/img/Kova.jpg",
            DateRange = "20 Ocak - 18 Şubat"
        },
        new Horoscope
        {
            Id = 12,
            Name = "Balık",
            Image = "/Ui/assets/img/balik.jpg",
            DateRange = "19 Şubat - 20 Mart"
        }

            );
        });

        builder.Entity<Service>(entity =>
        {
            entity.HasData(
                new Service
                {
                    Id = 1,
                    Name = "AstroMap Workshop",
                    Title = "AstroMap Workshop, katilimcilara dogum haritalarini derinlemesine analiz etmeyi ve hayatlarindaki potansiyel yollari kesfetmeyi ögretir. Kendi astrolojik haritanizi çözerek, kisisel gelisiminiz için güçlü bir rehber olusturabilirsiniz.",

                },
                 new Service
                 {
                     Id = 2,
                     Name = "Tarot Workshop",
                     Title = "Tarot Workshop, kartlar aracılığıyla kendinizle ve evrenle daha derin bir bağlantı kurmanızı sağlar. Tarot^un sembollerini öğrenerek, hayatınızdaki sorulara rehberlik edecek anlamlı okumalar yapmayı öğrenebilirsiniz.",

                 },
                  new Service
                  {
                      Id = 3,
                      Name = "Reiki Workshop",
                      Title = "Reiki Workshop, katilimcilara bedensel, zihinsel ve duygusal dengeyi saglamak için Reiki enerjisini nasil kullanacaklarini ögretir. Enerji çalismalari ile kendinizi iyilestirmenin ve çevrenizdeki insanlara sifa vermenin yollarini kesfedin.",

                  },
                  new Service
                  {
                      Id = 4,
                      Name = "Evren Workshop",
                      Title = "Evren Workshop, kişisel yaşam alanlarınıza enerjiyi nasıl yönlendirebileceğinizi ve mekanlarınızda dengeyi nasıl sağlayacağınızı öğretir. Feng Shui tekniklerini kullanarak, evinizde huzur ve olumlu enerji akışını sağlamak mümkün.",

                  }
            );
        });

        builder.Entity<SocialMedia>(entity =>
        {
            entity.HasData(
                new SocialMedia
                {
                    Id = 1,
                    Name = "Instagram",
                    Url = "https://instagram.com/astromistik",
                    Icon = "fab fa-instagram"
                },
                new SocialMedia
                {
                    Id = 2,
                    Name = "Facebook",
                    Url = "https://facebook.com/astromistik",
                    Icon = "fab fa-facebook"
                },
                new SocialMedia
                {
                    Id = 3,
                    Name = "Twitter",
                    Url = "https://twitter.com/astromistik",
                    Icon = "fab fa-twitter"
                },
                new SocialMedia
                {
                    Id = 4,
                    Name = "YouTube",
                    Url = "https://youtube.com/astromistik",
                    Icon = "fab fa-youtube"
                }

            );
        });

        builder.Entity<Contact>(entity =>
        {

            entity.HasData(
                 new Contact
                 {
                     Id = 1,
                     Address = "Kadıköy",
                     PhoneNumber = "02120003131",
                     Icon = "bi bi-geo-alt-fill",
                     Map = ""

                 }
            );
        });


        builder.Entity<HoroscopeComment>(entity =>
        {
            entity.HasData(
                new HoroscopeComment
                {
                    Id = 1,
                    HoroscopeId = 1,
                    Name = "Koç Burcu",
                    Daily = "Bugün enerjiniz yüksek olacak. İş hayatınızda yeni fırsatlar karşınıza çıkabilir. Spor yapmak için uygun bir gün.",
                    Monthly = "Bu ay kariyer hayatınızda önemli gelişmeler yaşanabilir. Finansal konularda temkinli olun.",
                    Annual = "2024 yılı sizin için yeni başlangıçların yılı olacak. Mars'ın etkisiyle hedeflerinize ulaşmak için güçlü bir motivasyona sahip olacaksınız."
                },
            new HoroscopeComment
            {
                Id = 2,
                HoroscopeId = 2,
                Name = "Boğa Burcu",
                Daily = "Maddi konularda şanslı bir gündesiniz. Venüs'ün etkisiyle aşk hayatınızda güzel gelişmeler olabilir.",
                Monthly = "Mayıs ayı boyunca finansal konularda şanslı olacaksınız. Yeni yatırım fırsatları değerlendirebilirsiniz.",
                Annual = "2024, özellikle kariyer ve eğitim alanlarında başarılı olacağınız bir yıl. Venüs desteğiyle aşk hayatınız canlanacak."
            },
            new HoroscopeComment
            {
                Id = 3,
                HoroscopeId = 3,
                Name = "İkizler Burcu",
                Daily = "İletişim yetenekleriniz üst düzeyde. Sosyal ilişkilerinizde başarılı olacaksınız.",
                Monthly = "Merkür'ün etkisiyle iletişim alanında başarılı olacağınız bir ay. Yeni projeler başlatabilirsiniz.",
                Annual = "2024'te eğitim ve seyahat konularında şanslı olacaksınız. İkili ilişkilerinizde önemli kararlar alabilirsiniz."
            },
            new HoroscopeComment
            {
                Id = 4,
                HoroscopeId = 4,
                Name = "Yengeç Burcu",
                Daily = "Duygusal konularda hassas bir gün. Ailenizle ilgili güzel gelişmeler yaşayabilirsiniz.",
                Monthly = "Ay'ın etkisiyle duygusal konularda derin düşüneceğiniz bir ay. Ev ve aile konularında önemli kararlar alabilirsiniz.",
                Annual = "2024 yılı, özellikle aile ve ev yaşamınızda önemli değişimlerin yaşanacağı bir dönem olacak."
            },
            new HoroscopeComment
            {
                Id = 5,
                HoroscopeId = 5,
                Name = "Aslan Burcu",
                Daily = "Güneş'in etkisiyle kariyerinizde parlayacağınız bir gün. Liderlik özellikleriniz ön planda.",
                Monthly = "Temmuz ayı sizin için oldukça verimli geçecek. Yaratıcı projeleriniz için destek bulabilirsiniz.",
                Annual = "2024'te kariyerinizde yükseliş var. Güneş'in desteğiyle başarıdan başarıya koşacaksınız."
            },
            new HoroscopeComment
            {
                Id = 6,
                HoroscopeId = 6,
                Name = "Başak Burcu",
                Daily = "Detaylara olan hakimiyetiniz işinizde başarı getirecek. Sağlık konularına dikkat.",
                Monthly = "Merkür retrosu sizi olumlu etkileyecek. İş hayatınızda yeni düzenlemeler yapabilirsiniz.",
                Annual = "2024, sağlık ve iş hayatınızda olumlu gelişmelerin yaşanacağı bir yıl olacak."
            },
            new HoroscopeComment
            {
                Id = 7,
                HoroscopeId = 7,
                Name = "Terazi Burcu",
                Daily = "İlişkilerinizde denge kurmakta başarılı olacaksınız. Estetik konularda şanslı bir gün.",
                Monthly = "Venüs'ün etkisiyle aşk hayatınızda güzel gelişmeler olacak. Sanat ve güzellik alanlarında başarılı olacaksınız.",
                Annual = "2024, özellikle ilişkiler ve ortaklıklar açısından önemli bir yıl olacak."
            },
            new HoroscopeComment
            {
                Id = 8,
                HoroscopeId = 8,
                Name = "Akrep Burcu",
                Daily = "Sezgileriniz güçlü. Finansal konularda önemli kararlar alabilirsiniz.",
                Monthly = "Mars'ın etkisiyle enerjiniz yüksek olacak. Gizli kalmış konular aydınlanabilir.",
                Annual = "2024'te özellikle finansal konularda şanslı olacaksınız. Plüton'un desteğiyle büyük değişimler yaşayabilirsiniz."
            },
            new HoroscopeComment
            {
                Id = 9,
                HoroscopeId = 9,
                Name = "Yay Burcu",
                Daily = "Jüpiter'in etkisiyle şansınız açık. Yeni öğrenme fırsatları karşınıza çıkabilir.",
                Monthly = "Seyahat ve eğitim konularında şanslı bir ay. Yurtdışı bağlantılı işler gündeme gelebilir.",
                Annual = "2024, özellikle eğitim ve yurtdışı konularında şanslı olacağınız bir yıl."
            },
            new HoroscopeComment
            {
                Id = 10,
                HoroscopeId = 10,
                Name = "Oğlak Burcu",
                Daily = "Kariyer konularında önemli gelişmeler yaşanabilir. Disiplininiz başarı getirecek.",
                Monthly = "Satürn'ün etkisiyle iş hayatınızda önemli sorumluluklar alabilirsiniz.",
                Annual = "2024, kariyer hedeflerinize ulaşacağınız bir yıl olacak. İş hayatınızda yükseliş var."
            },
            new HoroscopeComment
            {
                Id = 11,
                HoroscopeId = 11,
                Name = "Kova Burcu",
                Daily = "Yenilikçi fikirleriniz dikkat çekecek. Teknoloji ile ilgili konularda şanslısınız.",
                Monthly = "Uranüs'ün etkisiyle beklenmedik fırsatlar karşınıza çıkabilir. Sosyal çevreniz genişleyecek.",
                Annual = "2024, teknoloji ve bilim alanlarında başarılı olacağınız bir yıl. Sosyal çevreniz genişleyecek."
            },
            new HoroscopeComment
            {
                Id = 12,
                HoroscopeId = 12,
                Name = "Balık Burcu",
                Daily = "Sanatsal yetenekleriniz ön planda. Ruhsal konularda hassas bir gün.",
                Monthly = "Neptün'ün etkisiyle sezgileriniz güçlenecek. Sanatsal projeler için uygun bir ay.",
                Annual = "2024, spirituel konularda gelişim göstereceğiniz bir yıl. Yaratıcılığınız zirve yapacak."
            }
            );
        });




        base.OnModelCreating(builder);
    }


}

