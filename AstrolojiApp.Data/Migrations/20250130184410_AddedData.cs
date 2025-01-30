using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AstrolojiApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AppSettings",
                columns: new[] { "Id", "AboutText", "BrandName", "Email", "HoroscopeName", "ImageUrl", "PhoneNumber", "Title", "WorkingHours" },
                values: new object[] { 1, "Burç yorumları, astrolojik analizler ve kişisel harita rehberliğiyle hayatınızı daha iyi anlayın. Günlük, haftalık ve aylık burç yorumlarınızı hemen öğrenin. Astrolojiye dair her şey burada! Günlük burç yorumları, gezegen konumları, yükselen burçlar ve kişisel astroloji analiziyle hayatınızı yönlendirin. Burçlarınızı ve gezegen hareketlerini keşfedin. Günlük yorumlarla hayatınızda ne gibi değişiklikler olabileceğini öğrenin ve astrolojik rehberlikle geleceğinizi şekillendirin.", "Bir Başka Yol", "gokyuzunebakiyoruz@org.com", "Koç, Boğa, İkizler, Yengeç, Aslan, Başak, Terazi, Akrep, Yay, Oğlak, Kova, Balık", "/Ui/assets/img/photoast.jpg", "0212 000 0000", "Yıldızlarınız Söylesin, Hayatınızı Keşfedin!", "Çalışma Saatleri: Salı - Ctesi: 10.00 - 19.00 | Pazar - Ptesi: Tatil" });

            migrationBuilder.InsertData(
                table: "AstrologComments",
                columns: new[] { "Id", "Image", "Name", "Text" },
                values: new object[,]
                {
                    { 1, "/Ui/assets/img/aylin.jpg", "Aylin Yıldız", "2024 yılı, gökyüzünde birçok önemli gezegen hareketi ve tutulmalar ile dikkat çekiyor. Özellikle Yengeç ve Koç burçları için önemli bir yıl olacak. Yengeçler, ailevi ilişkilerde önemli dönüşümler yaşayacak, Koçlar ise iş ve kariyer alanında büyük atılımlar yapabilirler. Venüs’ün Balık burcundaki hareketi, romantik ilişkilerde duygusal derinliği artırırken, Uranüs’ün Boğa burcunda ilerlemesi finansal anlamda yenilikçi yaklaşımlara açık bir yılı işaret ediyor. Bu yıl, kendinize güvenin ve karşınıza çıkan fırsatları değerlendirmekten çekinmeyin." },
                    { 2, "/Ui/assets/img/burak.jpg", "Burak Demir", "2024 yılı, değişim ve yenilik yılı olacak. Özellikle burçlar arasında Boğa, Akrep ve Kova burçları, Uranüsün etkisiyle kendilerini yeniden şekillendirecekler. Boğalar, mali anlamda radikal kararlar alabilirken, Akrepler ise psikolojik ve duygusal yenilenmeye adım atacaklar. Kova burçları için ise toplumsal bağlamda önemli değişiklikler ve sosyal projeler devreye girebilir. Bu yıl, eski kalıpları kırmak ve kendi yolunuzu çizmek için harika bir fırsat sunuyor. Hayatınızda yeni başlangıçlar yapma zamanı geldi." },
                    { 3, "/Ui/assets/img/cetin.jpg", "Çetin Aydın", "2024 yılı, iş ve kariyer anlamında önemli adımlar atmak için çok uygun bir zaman dilimi. Özellikle Aslan, Oğlak ve Terazi burçları için bu yıl, profesyonel hayatlarında hızlı yükselme ve önemli fırsatlar barındırıyor. Aslanlar liderlik yeteneklerini daha da pekiştirirken, Oğlaklar uzun vadeli planlarını hayata geçirebilir. Teraziler ise işbirlikleri ve ortaklıklar konusunda dikkatli olmalılar, çünkü bu yıl doğru partnerlerle güçlü bağlantılar kurmak, başarılı olmanızda anahtar rol oynayacak. Finansal anlamda ise dikkatli yatırım yapmanın tam zamanı." }
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "Address", "Icon", "Map", "PhoneNumber" },
                values: new object[] { 1, "Kadıköy", "bi bi-geo-alt-fill", "", "02120003131" });

            migrationBuilder.InsertData(
                table: "DailyNews",
                columns: new[] { "Id", "Text", "Title" },
                values: new object[] { 1, "Geçmiş deneyimlerden ders çıkarma  ve iletişimle ilgili önemli bir dönemdeyiz. Bu dönemde geleceğe yönelik planlar yapmak ve projeler geliştirmek için uygun bir zaman olabilir. Kararlarınızı, fikirlerinizi değiştirecek insanlar, kitaplar, eğitimlerle karşılaşabilir, sohbetler edebilirsiniz. Yeni fikirler, düşünceler ve bilgilerle karşılaşabiliriz ki bu da bizi hayat amaçlarımza uyumlu bir yola yönlendirebilir. Daha önce göz ardı ettiğimiz veya farkında olmadığımız konulara ilgi duymaya başlayabiliriz.", "Merkür ile Kuzey Ay Düğümü arasında kavuşum açısı olacak. Etki süresi 2 gün!!" });

            migrationBuilder.InsertData(
                table: "HoroscopeGroups",
                columns: new[] { "Id", "HoroscopeNames", "Image", "Name" },
                values: new object[,]
                {
                    { 1, "Koç,Aslan,Yay", "/Ui/assets/img/AtesGrubu.jpg", "Ateş Grubu" },
                    { 2, "Boğa,Başak,Oğlak", "/Ui/assets/img/ToprakGrubu.jpg", "Toprak Grubu" },
                    { 3, "İkizler,Terazi,Kova", "/Ui/assets/img/HavaGrubu.jpg", "Hava Grubu" },
                    { 4, "Yengeç,Akrep,Balık", "/Ui/assets/img/SuGrubu.jpg", "Su Grubu" }
                });

            migrationBuilder.InsertData(
                table: "Horoscopes",
                columns: new[] { "Id", "DateRange", "Image", "Name" },
                values: new object[,]
                {
                    { 1, "21 Mart - 20 Nisan", "/images/horoscopes/aries.png", "Koç" },
                    { 2, "21 Nisan - 20 Mayıs", "/images/horoscopes/taurus.png", "Boğa" },
                    { 3, "21 Mayıs - 21 Haziran", "/images/horoscopes/gemini.png", "İkizler" },
                    { 4, "22 Haziran - 22 Temmuz", "/images/horoscopes/cancer.png", "Yengeç" },
                    { 5, "23 Temmuz - 22 Ağustos", "/images/horoscopes/leo.png", "Aslan" },
                    { 6, "23 Ağustos - 22 Eylül", "/images/horoscopes/virgo.png", "Başak" },
                    { 7, "23 Eylül - 22 Ekim", "/images/horoscopes/libra.png", "Terazi" },
                    { 8, "23 Ekim - 21 Kasım", "/images/horoscopes/scorpio.png", "Akrep" },
                    { 9, "22 Kasım - 21 Aralık", "/images/horoscopes/sagittarius.png", "Yay" },
                    { 10, "22 Aralık - 19 Ocak", "/images/horoscopes/capricorn.png", "Oğlak" },
                    { 11, "20 Ocak - 18 Şubat", "/images/horoscopes/aquarius.png", "Kova" },
                    { 12, "19 Şubat - 20 Mart", "/images/horoscopes/pisces.png", "Balık" }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Name", "Title" },
                values: new object[,]
                {
                    { 1, "AstroMap Workshop", "AstroMap Workshop, katilimcilara dogum haritalarini derinlemesine analiz etmeyi ve hayatlarindaki potansiyel yollari kesfetmeyi ögretir. Kendi astrolojik haritanizi çözerek, kisisel gelisiminiz için güçlü bir rehber olusturabilirsiniz." },
                    { 2, "Tarot Workshop", "Tarot Workshop, kartlar aracılığıyla kendinizle ve evrenle daha derin bir bağlantı kurmanızı sağlar. Tarot^un sembollerini öğrenerek, hayatınızdaki sorulara rehberlik edecek anlamlı okumalar yapmayı öğrenebilirsiniz." },
                    { 3, "Reiki Workshop", "Reiki Workshop, katilimcilara bedensel, zihinsel ve duygusal dengeyi saglamak için Reiki enerjisini nasil kullanacaklarini ögretir. Enerji çalismalari ile kendinizi iyilestirmenin ve çevrenizdeki insanlara sifa vermenin yollarini kesfedin." },
                    { 4, "Evren Workshop", "Evren Workshop, kişisel yaşam alanlarınıza enerjiyi nasıl yönlendirebileceğinizi ve mekanlarınızda dengeyi nasıl sağlayacağınızı öğretir. Feng Shui tekniklerini kullanarak, evinizde huzur ve olumlu enerji akışını sağlamak mümkün." }
                });

            migrationBuilder.InsertData(
                table: "SocialMedias",
                columns: new[] { "Id", "Icon", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "fab fa-instagram", "Instagram", "https://instagram.com/astromistik" },
                    { 2, "fab fa-facebook", "Facebook", "https://facebook.com/astromistik" },
                    { 3, "fab fa-twitter", "Twitter", "https://twitter.com/astromistik" },
                    { 4, "fab fa-youtube", "YouTube", "https://youtube.com/astromistik" }
                });

            migrationBuilder.InsertData(
                table: "HoroscopeComments",
                columns: new[] { "Id", "Annual", "Daily", "HoroscopeId", "Monthly", "Name" },
                values: new object[,]
                {
                    { 1, "2024 yılı sizin için yeni başlangıçların yılı olacak. Mars'ın etkisiyle hedeflerinize ulaşmak için güçlü bir motivasyona sahip olacaksınız.", "Bugün enerjiniz yüksek olacak. İş hayatınızda yeni fırsatlar karşınıza çıkabilir. Spor yapmak için uygun bir gün.", 1, "Bu ay kariyer hayatınızda önemli gelişmeler yaşanabilir. Finansal konularda temkinli olun.", "Koç Burcu" },
                    { 2, "2024, özellikle kariyer ve eğitim alanlarında başarılı olacağınız bir yıl. Venüs desteğiyle aşk hayatınız canlanacak.", "Maddi konularda şanslı bir gündesiniz. Venüs'ün etkisiyle aşk hayatınızda güzel gelişmeler olabilir.", 2, "Mayıs ayı boyunca finansal konularda şanslı olacaksınız. Yeni yatırım fırsatları değerlendirebilirsiniz.", "Boğa Burcu" },
                    { 3, "2024'te eğitim ve seyahat konularında şanslı olacaksınız. İkili ilişkilerinizde önemli kararlar alabilirsiniz.", "İletişim yetenekleriniz üst düzeyde. Sosyal ilişkilerinizde başarılı olacaksınız.", 3, "Merkür'ün etkisiyle iletişim alanında başarılı olacağınız bir ay. Yeni projeler başlatabilirsiniz.", "İkizler Burcu" },
                    { 4, "2024 yılı, özellikle aile ve ev yaşamınızda önemli değişimlerin yaşanacağı bir dönem olacak.", "Duygusal konularda hassas bir gün. Ailenizle ilgili güzel gelişmeler yaşayabilirsiniz.", 4, "Ay'ın etkisiyle duygusal konularda derin düşüneceğiniz bir ay. Ev ve aile konularında önemli kararlar alabilirsiniz.", "Yengeç Burcu" },
                    { 5, "2024'te kariyerinizde yükseliş var. Güneş'in desteğiyle başarıdan başarıya koşacaksınız.", "Güneş'in etkisiyle kariyerinizde parlayacağınız bir gün. Liderlik özellikleriniz ön planda.", 5, "Temmuz ayı sizin için oldukça verimli geçecek. Yaratıcı projeleriniz için destek bulabilirsiniz.", "Aslan Burcu" },
                    { 6, "2024, sağlık ve iş hayatınızda olumlu gelişmelerin yaşanacağı bir yıl olacak.", "Detaylara olan hakimiyetiniz işinizde başarı getirecek. Sağlık konularına dikkat.", 6, "Merkür retrosu sizi olumlu etkileyecek. İş hayatınızda yeni düzenlemeler yapabilirsiniz.", "Başak Burcu" },
                    { 7, "2024, özellikle ilişkiler ve ortaklıklar açısından önemli bir yıl olacak.", "İlişkilerinizde denge kurmakta başarılı olacaksınız. Estetik konularda şanslı bir gün.", 7, "Venüs'ün etkisiyle aşk hayatınızda güzel gelişmeler olacak. Sanat ve güzellik alanlarında başarılı olacaksınız.", "Terazi Burcu" },
                    { 8, "2024'te özellikle finansal konularda şanslı olacaksınız. Plüton'un desteğiyle büyük değişimler yaşayabilirsiniz.", "Sezgileriniz güçlü. Finansal konularda önemli kararlar alabilirsiniz.", 8, "Mars'ın etkisiyle enerjiniz yüksek olacak. Gizli kalmış konular aydınlanabilir.", "Akrep Burcu" },
                    { 9, "2024, özellikle eğitim ve yurtdışı konularında şanslı olacağınız bir yıl.", "Jüpiter'in etkisiyle şansınız açık. Yeni öğrenme fırsatları karşınıza çıkabilir.", 9, "Seyahat ve eğitim konularında şanslı bir ay. Yurtdışı bağlantılı işler gündeme gelebilir.", "Yay Burcu" },
                    { 10, "2024, kariyer hedeflerinize ulaşacağınız bir yıl olacak. İş hayatınızda yükseliş var.", "Kariyer konularında önemli gelişmeler yaşanabilir. Disiplininiz başarı getirecek.", 10, "Satürn'ün etkisiyle iş hayatınızda önemli sorumluluklar alabilirsiniz.", "Oğlak Burcu" },
                    { 11, "2024, teknoloji ve bilim alanlarında başarılı olacağınız bir yıl. Sosyal çevreniz genişleyecek.", "Yenilikçi fikirleriniz dikkat çekecek. Teknoloji ile ilgili konularda şanslısınız.", 11, "Uranüs'ün etkisiyle beklenmedik fırsatlar karşınıza çıkabilir. Sosyal çevreniz genişleyecek.", "Kova Burcu" },
                    { 12, "2024, spirituel konularda gelişim göstereceğiniz bir yıl. Yaratıcılığınız zirve yapacak.", "Sanatsal yetenekleriniz ön planda. Ruhsal konularda hassas bir gün.", 12, "Neptün'ün etkisiyle sezgileriniz güçlenecek. Sanatsal projeler için uygun bir ay.", "Balık Burcu" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppSettings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AstrologComments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AstrologComments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AstrologComments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DailyNews",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "HoroscopeComments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "HoroscopeComments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "HoroscopeComments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "HoroscopeComments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "HoroscopeComments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "HoroscopeComments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "HoroscopeComments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "HoroscopeComments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "HoroscopeComments",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "HoroscopeComments",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "HoroscopeComments",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "HoroscopeComments",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "HoroscopeGroups",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "HoroscopeGroups",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "HoroscopeGroups",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "HoroscopeGroups",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Horoscopes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Horoscopes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Horoscopes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Horoscopes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Horoscopes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Horoscopes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Horoscopes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Horoscopes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Horoscopes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Horoscopes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Horoscopes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Horoscopes",
                keyColumn: "Id",
                keyValue: 12);
        }
    }
}
