using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieApi.Server.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Directors",
                columns: table => new
                {
                    DirectorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DirectorFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DirectorBornDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DirectorOverview = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DirectorImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DirectorBiography = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Directors", x => x.DirectorID);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OriginalTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReleaseYear = table.Column<int>(type: "int", nullable: false),
                    ReleaseDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MovieSecond = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MovieReview = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DirectorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MovieId);
                    table.ForeignKey(
                        name: "FK_Movies_Directors_DirectorId",
                        column: x => x.DirectorId,
                        principalTable: "Directors",
                        principalColumn: "DirectorID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    ActorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActorFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BornDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActorImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActorBiography = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MovieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.ActorId);
                    table.ForeignKey(
                        name: "FK_Actors_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MovieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                    table.ForeignKey(
                        name: "FK_Categories_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "DirectorID", "DirectorBiography", "DirectorBornDate", "DirectorFullName", "DirectorImage", "DirectorOverview" },
                values: new object[,]
                {
                    { 1, "Andrew Stanton, 3 Aralık 1965’te doğmuş Amerikalı yönetmen, senarist, yapımcı ve zaman zaman seslendirme sanatçısıdır. Özellikle Finding Nemo ve WALL-E gibi modern animasyon sinemasının en önemli yapımlarındaki çalışmalarıyla tanınır. Kariyerini büyük ölçüde Pixar Animation Studios bünyesinde şekillendiren Stanton, stüdyonun yaratıcı kimliğini oluşturan kilit isimlerden biri olmuştur.", "03 Aralık 1965", "Andrew Stanton", "https://cdn.sinemalar.com/images/afis_buyuk/a/andrew-stanton-1782130626.jpg", null },
                    { 2, "23 Kasım 1978 doğumlu Amerikalı yönetmen, senarist ve yapımcı Destin Daniel Cretton, sinema kariyerinde hem bağımsız dramalarla hem de büyük bütçeli stüdyo yapımlarıyla kendine yer buldu. Kariyerinin erken döneminde Short Term 12 ve I Am Not a Hipster gibi projelerde yönetmenliğin yanı sıra senaryo yazımı ve kurgu süreçlerini de üstlenen sanatçı, özellikle Short Term 12 ile sinema dünyasında geniş bir kesimin dikkatini çekti. Ardından Camdan Kale (The Glass Castle) ve gerçek bir hayat hikayesine dayanan Just Mercy gibi yapımların yönetmen koltuğuna oturarak derinlikli karakter analizlerine odaklanan işlereimza attı.", "23 Kasım 1978", "Destin Daniel Cretton", "https://cdn.sinemalar.com/images/afis_buyuk/d/destin-daniel-cretton-1786138090.jpg", null }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "DirectorId", "MovieReview", "MovieSecond", "MovieTitle", "OriginalTitle", "ReleaseDate", "ReleaseYear" },
                values: new object[,]
                {
                    { 1, 2, "Örümcek-Adam: Yepyeni Bir Gün, Peter Parker’ın (Tom Holland) kimliğinin unutulduğu bir dünyada yaşadığı zorlu süreci merkezine alıyor. Sevdiklerinin hayatlarına onsuz devam etmesine tanıklık eden Peter, tam zamanlı kahramanlık yapmanın getirdiği ağır baskı altında kontrolü güç bir değişim geçirmeye başlar. Yaşadığı bu içsel dönüşüm, şehre ve sevdiklerine yönelecek gizemli bir tehditle mücadele edebilmesi için tek anahtara dönüşür. Peter Parker, kimsenin varlığını fark edemediği bu güçlü düşmanı durdurmak için yeni haliyle yüzleşmek zorundadır.", "2 saat 20 dakika", "Örümcek-Adam: Yepyeni Bir Gün", "Spider-Man: Brand New Day", "31 Temmuz 2026", 2026 },
                    { 2, 1, "Örümcek-Adam: Yepyeni Bir Gün, Peter Parker’ın (Tom Holland) kimliğinin unutulduğu bir dünyada yaşadığı zorlu süreci merkezine alıyor. Sevdiklerinin hayatlarına onsuz devam etmesine tanıklık eden Peter, tam zamanlı kahramanlık yapmanın getirdiği ağır baskı altında kontrolü güç bir değişim geçirmeye başlar. Yaşadığı bu içsel dönüşüm, şehre ve sevdiklerine yönelecek gizemli bir tehditle mücadele edebilmesi için tek anahtara dönüşür. Peter Parker, kimsenin varlığını fark edemediği bu güçlü düşmanı durdurmak için yeni haliyle yüzleşmek zorundadır.", "2 saat 20 dakika", "Oyuncak Hikayesi 5", "Toy Story 5", "19 Haziran 2026", 2026 },
                    { 3, 1, "Homeros'un aynı adlı destanının bir uyarlaması olan film, Truva Savaşı'ndan sonra İthaka Kralı Odysseus'un evine dönüş yolculuğunu konu alıyor. Bu epik macerada, Odysseus'un (Matt Damon) Polyphemus (tek gözlü dev, Bill Irwin), Sirenler ve büyücü tanrıça Circe (Samantha Morton) gibi mitolojik figürlerle karşılaşmaları anlatılıyor. ", "2 saat 52 dakika", "Odyssey", "The Odyssey", "17 Temmuz 2026", 2026 },
                    { 4, 2, "Thunderbolts* filminde yaşanan olayların üzerinden 14 ay geçmiştir ve evren, şimdiye kadarki en büyük tehditlerinden biriyle karşı karşıyadır. Avengers ekibi, yaklaşan bu büyük tehlikeyi durdurabilmek için Wakandalılar, Fantastic Four, New Avengers ve orijinal X-Men üyeleriyle bir araya gelir. Kahramanların önündeki en büyük engel ise karanlık güçleriyletehdit saçan Doctor Doom’dur.", "2 saat 45 dakika", "Avengers: Doomsday", "Avengers: Doomsday", "18 Aralık 2026", 2026 }
                });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "ActorId", "ActorBiography", "ActorFullName", "ActorImage", "BornDate", "MovieId" },
                values: new object[,]
                {
                    { 1, "Thomas Stanley Holland, kısaca Tom Holland, İngiliz oyuncu, seslendirme sanatçısı ve dansçı. \"Spider-Man: Homecoming\" filmindeki Peter Parker rolüyle ünlenmiştir. 1996'da Londra'da doğdu. Annesi Nicola Elizabeth Frost fotoğrafçı, babası Dominic Holland ise yazar ve komedyendir. 1999'da doğan Sam ve Harry adlı ikiz kardeşlerinin yanında bir de 2004 doğumlu Patrick adında toplam 3 erkek kardeşi vardır. Wimbledon College ve ardından The BRIT School for Performing Arts and Technology'de eğitim gördü.", "Tom Holland", "https://cdn.sinemalar.com/images/afis_buyuk/t/tom-holland-1996-1785524509.jpg", "1 Haziran 1996", 1 },
                    { 2, "Zendaya Maree Stoermer Coleman, 1996 yılında Oakland'da dünyaya geldi. Sanat hayatına çocuk yaşlarda dans ve oyunculukla adım atan isim, Disney Channel yapımı Haydi Çalkala (Shake It Up) dizisinde canlandırdığı Raquel \"Rocky\" Blue karakteriyle geniş kitlelerce tanındı. Bu projedeki başarısının ardından yine bir Disney yapımı olan K.C. Undercover dizisinde liseli bir ajana hayat vererek televizyon dünyasındaki yerini sağlamlaştırdı. Spider-Man filmlerinde MJ karakterini canlandırdı. Kariyerinin ilk yıllarından itibaren disiplini ve yeteneğiyle dikkat çeken oyuncu, müzik ve oyunculuğu bir arada yürüterek genç yaşta önemli bir hayran kitlesine ulaştı.", "Zendaya", "https://cdn.sinemalar.com/images/afis_buyuk/z/zendaya-coleman-1785524072.jpg", "1 Eylül 1996", 1 },
                    { 3, "Jonathan Edward Bernthal, kısaca Jon Bernthal, Amerikalı aktör. The Walking Dead dizisindeki Shane Walsh rolüyle hatırlanmaktadır. Joan Lurie ve Rick Bernthal çiftinin çocuğu olarak Washington D.C.'de doğdu. Yahudi bir ailenin çocuğu olan Bernthal'ın Nicholas ve Thomas adlarında 2 erkek kardeşi vardır. Skidmore College'da eğitim alırken burayı bırakan Bernthal, oyunculuk eğitimi için Moskova'ya gitti. Harvard Üniversitesi'nin İleri Tiyatro Eğitimi Enstitüsü'nde eğitim alırken keşfedildi ve mezuniyetinin ardından çok sayıda tiyatro oyununda yer aldı. 2010 yılında başlayan The Walking Dead dizisinin ilk sezonundaki baş karakterlerden olan Shane'i canlandırmasının ardından çok daha büyük bir hayran kitlesine erişti. 2013'te Martin Scorsese'nin The Wolf of Wall Street filminde Brad Bodnick rolünde oynadı. Sicario, Hesaplaşma (The Accountant), Tam Gaz (Baby Driver) gibi filmlerde daha önemli roller aldı. Daredevil dizisinde Frank Castle, yani The Punisher rolüyle izleyicilerin beğenisini kazanan Bernthal, daha sonra karakterin kendi dizisi The Punisher'da aynı rolü canlandırdı.", "Jon Bernthal", "https://cdn.sinemalar.com/images/afis_buyuk/j/jon-bernthal-1785523878.jpg", "20 Eylül 1976", 1 },
                    { 4, "Mark Alan Ruffalo, Amerikalı aktör ve yapımcı. 1967'de Wisconsin'in Kenosha kentinde doğdu. İtalyan asıllı bir ailenin çocuğudur; babası inşaat boyacısı, annesi kuafördür. Oyunculuk eğitimini Stella Adler Conservatory'de aldı. Kariyerinde çıkışı \"You Can Count on Me\" filmiyle yaptı. Eternal Sunshine of the Spotless Mind, Zodiac, Foxcatcher, Spotlight ve Poor Things gibi yapımlarda yer aldı ve birçok kez Oscar'a aday gösterildi. The Avengers (2012) filminden itibaren Marvel Sinematik Evreni'nde Bruce Banner / Hulk karakterini canlandırmaktadır. Aynı zamanda çevre ve insan hakları konularındaki aktivizmiyle de tanınır.", "Mark Ruffalo", "https://cdn.sinemalar.com/images/afis_buyuk/m/mark-ruffalo-1785524233.jpg", "22 Kasım 1967", 1 },
                    { 5, "Jacob Batalon, Amerikalı aktör. 1996'da Hawaii'nin Honolulu kentinde doğdu. Filipin ve Hawaii kökenlidir. Oyunculuk kariyerine küçük rollerle başladı ve \"Spider-Man: Homecoming\" filminde Peter Parker'ın en yakın arkadaşı Ned Leeds rolüyle geniş kitlelerce tanındı. Aynı karakteri Spider-Man: Far From Home ve Spider-Man: No Way Home filmlerinde de canlandırdı. Let It Snow filminde ve Reginald the Vampire dizisinde başrol oynadı.", "Jacob Batalon", "https://cdn.sinemalar.com/images/afis_buyuk/j/jacob-batalon-1785661720.jpg", "9 Haziran 1996", 1 },
                    { 6, "Thomas Jeffrey Hanks, kısaca Tom Hanks, Amerikalı aktör, yapımcı ve yönetmen. 1956'da Kaliforniya'nın Concord kentinde doğdu. Forrest Gump, Philadelphia, Apollo 13, Cast Away ve Saving Private Ryan gibi yapımlardaki rolleriyle tanınır. Philadelphia ve Forrest Gump filmleriyle art arda iki kez en iyi erkek oyuncu Oscar'ını kazandı. 1995'te çıkan ilk Toy Story filminden bu yana Andy'nin kovboy oyuncağı Woody'yi seslendirmekte ve karakteri Toy Story 5'te de canlandırmaktadır.", "Tom Hanks", "https://cdn.sinemalar.com/images/person/25663/poster/tom-hanks-1654002859.jpg", "9 Temmuz 1956", 1 },
                    { 7, "Timothy Alan Dick, sahne adıyla Tim Allen, Amerikalı aktör ve komedyen. 1953'te Colorado'nun Denver kentinde doğdu. Stand-up komedisiyle başladığı kariyerinde Home Improvement dizisindeki Tim Taylor rolüyle geniş kitlelere ulaştı. The Santa Clause filmleri ve Galaxy Quest ile de tanınır. Toy Story serisinin tamamında Buzz Lightyear'ı seslendirmiştir ve Toy Story 5'te de aynı karaktere ses vermektedir.", "Tim Allen", "https://cdn.sinemalar.com/images/person/25663/poster/tom-hanks-1654002859.jpg", "13 Haziran 1953", 2 },
                    { 8, "Joan Cusack, Amerikalı aktris. 1962'de New York'ta doğdu. Aktör John Cusack'ın kız kardeşidir. Working Girl ve In & Out filmleriyle Oscar'a aday gösterildi. Toy Story 2'de tanıtılan, Bonnie'nin kovboy kız bez bebeği Jessie'yi seslendirmektedir ve karakter Toy Story 5'te oyuncakların yeni lideri olarak yer almaktadır.", "Joan Cusack", "https://cdn.sinemalar.com/images/person/28068/poster/joan-cusack-1530185352.jpg", "11 Ekim 1962", 2 },
                    { 9, "Greta Lee, Amerikalı aktris. 1983'te Los Angeles'ta doğdu. Past Lives filmindeki Nora rolüyle büyük beğeni topladı ve film en iyi film dalında Oscar'a aday gösterildi. Russian Doll ve The Morning Show dizilerindeki rolleriyle de tanınır. Toy Story 5'te Bonnie'ye gelen kurbağa şeklindeki akıllı tablet Lilypad (Lily) karakterini seslendirmektedir.", "Greta Lee", "https://cdn.sinemalar.com/images/person/467666/poster/greta-lee-1701162204.jpg", "7 Mart 1983", 2 },
                    { 10, "Conan Christopher O'Brien, Amerikalı televizyon sunucusu, komedyen, yazar ve yapımcı. 1963'te Massachusetts'in Brookline kentinde doğdu ve Harvard Üniversitesi'nde eğitim gördü. Saturday Night Live ve The Simpsons için senarist olarak çalıştıktan sonra Late Night with Conan O'Brien programıyla tanındı; ardından The Tonight Show ve TBS'te Conan programlarını sundu. Toy Story 5'te tuvalet eğitimi veren teknolojik oyuncak Smarty Pants'i seslendirmektedir.", "Conan O'Brien", "https://cdn.sinemalar.com/images/person/118146/poster/conan-obrien-1740985359.jpg", "18 Nisan 1963", 2 },
                    { 11, "Robert John Downey, Jr., BAFTA ve Altın Küre sahibi ABD'li oyuncu ve yapımcıdır. \"Sherlock Holmes\"ve \"Iron Man\" serilerinin yanısıra \"Chaplin\", \"Natural Born Killers\", \"Good Night and Good Luck\", \"Kiss Kiss Bang Bang\", \"Zodiac\", \"Tropic Thunder\" ve \"Yenilmezler\" gibi filmler ile de tanınmaktadır. 4 Nisan 1965'te New York'ta doğmuştur. Aktör, yazar, prodüktör ve yönetmen Robert Downey Sr.'nin oğlu olan Downey Jr., 1970 yılında babasının yönettiği \"Pound\" adlı filmde küçük bir rol alarak sinema kariyerine başlamıştır. Aynı zamanda iyi bir müzisyen de olan Robert Downey Jr., 80'lerin sonu ile 90’ların başında rol aldığı filmler ileüne kavuşmuştur. Ona ilk ün getiren rolü 1987 yapımlı \"Less Than Zero\" isimli filmde canlandırdığı uyuşturcu bağımlısı genç karakteridir. ", "Robert Downwey JR", "https://cdn.sinemalar.com/images/person/26076/poster/robert-downey-jr-1659014225.jpg", "04 Nisan 1985", 4 },
                    { 12, "Christopher Robert \"Chris\" Evans, Amerikalı oyuncu olarak sinema dünyasında kendine sağlam bir yer edindi. Sanatçı bir aileden gelen Evans, yönetmen bir anne ile diş hekimi bir babanın oğlu olarak dünyaya geldi. İtalyan ve İrlanda kökenlerine sahip olan oyuncu,kardeşleri Carly DuBray, Shanna ve Scott ile birlikte büyüdü. Kariyerinin ilk yıllarında gençlikyapımlarına yönelen Evans, 2001 yılındaki Not Another Teen Movie filminde canlandırdığı Jake Wyler karakteriyle ilk önemli çıkışını gerçekleştirdi.", "Chris Evans", "https://cdn.sinemalar.com/images/person/27912/poster/chris-evans-1674207537.jpg", "13 Haziran 1981", 4 },
                    { 13, "José Pedro Balmaceda Pascal, Şili kökenli ABD'li oyuncu. \"Game of Thrones\" dizisindeki Oberyn Martell ve \"Narcos\" dizisindeki Javier Peña rolleriyle hatırlanmaktadır.Pedro Pascal, 1975'te Şili'nin başkenti Santiago'da doğdu. Salvador Allende'nin devrilmesi ve Augusto Pinochet'nin yönetime gelmesiyle zor günler geçiren Allende destekçisi ailesi önce Danimarka'dan siyasi sığınma hakkı aldı, daha sonra Amerika Birleşik Devletleri'ne taşındılar. Pascal, Oranga County ve San Antonio'da büyüdü. Çocukluk yıllarında yüzmeyle ilgilendi, ancak sonra oyunculuğa döndü. New York'ta Tisch School of the Arts'ta eğitim gördü. \"Buffy the Vampire Slayer\", \"Without a Trace\", \"Law & Order\" gibi çok sayıda dizide bölüm oyuncusu olarak yer aldı.", "Pedro Pascal", "https://cdn.sinemalar.com/images/person/383637/poster/pedro-pascal-1678704056.jpg", "02 Nisan 1975", 4 },
                    { 14, "Vanessa Kirby, İngiliz aktris. Doktor bir baba ve gazeteci bir annenin çocuğu olarak dünyaya gelen Kirby, Wimbledon'da büyüdü. Lady Eleanor Holles School'da okudu. Bristol Old Vic Tiyatro Okulu tarafından kabul edilmeyince, 1 yıl boyunca dünyayı dolaştı. Sonrasında Exeter Üniversitesi'nde İngiliz Dili bölümüne kaydoldu. Yönetmen David Thacker'la tanışmasının ardından birçok tiyatro oyununda oynayarak kendini ispatladı. Televlziyon dünyasına geçişi de 2011'de oldu. 2013'te Zamanda Aşk (About Time) filminde Rachel McAdams'ın canlandırdığı karakterin en yakın arkadaşı rolünde oynadı. 2016'da başlayan The Crown dizisindeki Prenses Margaret rolüyle beğeni topladı. Yine 2016 yapımı Genius ve Senden Önce Ben gibi filmlerde oynayan Kirby, 2018 yapımı Görevimiz Tehlike 6 filminin de kadrosunda yer aldı.", "Vanessa Kirby", "https://cdn.sinemalar.com/images/person/557256/poster/vanessa-kirby-1698238705.jpg", "18 Nisan 1988", 4 },
                    { 15, "Ebon Moss-Bachrach, Renee Moss ve Eric Bachrach çiftinin çocuğu olarak Amherst, Massachusetts'te dünyaya geldi. Eğitim hayatını Amherst Bölgesel Lisesi ve Columbia Üniversitesi’nde tamamlayan oyuncu, kariyerinin ilk yıllarında çeşitli televizyon yapımlarında deneyim kazandı. Beyaz perdedeki asıl çıkışını Mona Lisa Gülüşü filminde canlandırdığı Charlie Stewart karakteriyle gerçekleştiren aktör, ardından Sandra Bullock ve Keanu Reeves gibi isimlerin yer aldığı Göl Evi (The Lake House) kadrosuna dahil oldu. Kariyerine Suburban Girl ve Evening gibi sinema filmleriyle devam eden Moss-Bachrach, geniş bir tür yelpazesinde farklı karakterlere hayat verdi.", "Ebon Moss-Bachrach", "https://cdn.sinemalar.com/images/person/54425/poster/ebon-moss-bachrach-1691583261.jpg", "17 Ağustos 1978", 4 },
                    { 16, "Matthew Paige Damon, Amerikalı oyuncu ve senaristtir. Borsacı bir babaya ve çocuk gelişimi profesörü bir anneye sahip olan Damon, Cambridge, Massachusetts'de doğmuştur. Annesi tarafından Fin ve İsveç kökeni, babası tarafından ise İngiliz ve İskoç kökeni vardır. 1988-1992 yılları arasında Harvard Üniversitesi'nde edebiyat okumuştur. 1997'de Ben Affleck ile yazdığı \"Can Dostum\" filmi ile \"En İyi Senaryo\" kategorisinde Altın Küre ve Oscar kazanmıştır. İlk kez 18 yaşında \"Mystic Pizza\" filminde bir satırlık bir rol oynamıştır. Son yıllarda \"Thor: Aşk ve Gök Gürültüsü\", \"Son Düello\" gibi filmlerde yer almıştır. En son Christopher Nolan'ın \"Oppenheimer\" filminde de yer aldı.", "Matt Damon", "https://cdn.sinemalar.com/images/person/26297/poster/matt-damon-1659013904.jpg", "08 Ekim 1970", 3 },
                    { 17, "Anne Hathaway 12 Kasım 1982 tarihinde Brooklyn, New York’ta doğmuş Amerikalı oyuncudur. Çocukluk yıllarını New Jersey’de geçiren Hathaway, oyunculuğa genç yaşta ilgi duymuş ve lise döneminde sahne performanslarıyla dikkat çekmiştir. Eğitimini oyunculuk üzerine alan sanatçı, kariyerine 1999 yılında “Get Real” dizisiyle başlamıştır.\r\n\r\nSinema kariyerindeki ilk büyük çıkışını 2001 yapımı “Acemi Prenses” filmiyle yapan Hathaway, bu rolle geniş kitlelerce tanınmıştır. Kariyerinin ilk döneminde “Nicholas Nickleby” ve “Ella: Sihirli Yolculuk” gibi daha çok aile ve gençlik odaklı yapımlarda yer almıştır. 2005 yılından itibaren ise daha olgun ve dramatik rollere yönelerek kariyerinde önemli bir dönüşüm yaşamıştır. “Brokeback Dağı” filmindeki performansı eleştirmenlerden olumlu yorumlar alırken, “Şeytan Marka Giyer” ile uluslararası çapta büyük bir tanınırlık kazanmıştır.", "Anne Hataway", "https://cdn.sinemalar.com/images/person/25721/poster/anne-hathaway-1692352269.jpg", "12 Kasım 1982", 3 },
                    { 18, "Robert Douglas Thomas Pattinson, İngiliz aktör. \"Alacakaranlık\" film serisindeki Edward Cullen rolüyle hatırlanmaktadır. Clare ve Richard Pattinson çiftinin tek erkek çocuğu olarak 1986'da Londra'da dünyaya geldi. Pattinson'ın Lizzy ve Victoria adında iki ablası vardır. Barnes Tiyatrosu'nun ve aynı zamanda Londralı bir müzik grubunun da üyesidir. 13 yaşında Tower House okulundan ayrıldıktan sonra Harrodian Özel Okulu'na girerek burada eğitimini başarıyla tamamladı.", "Robert Patinson", "https://cdn.sinemalar.com/images/afis_buyuk/r/robert-pattinson-1784406874.jpg", "13 Mayıs 1986", 3 },
                    { 19, "Charlize Theron, Güney Afrikalı aktris. Şeytanın Avukatı ve İtalyan İşi gibi birçok filmdeki rolleriyle ünlüdür. Theron Güney Afrika'nın Benoni şehrinde doğdu. Annesi Gerda Alman,babası Charles Theron ise Fransız asıllıdır. Annesi ve babası bir yol yapım şirketi işletiyordu. Theron 15 yaşında iken annesi bir tartışma sırasında babasını vurdu ve Theron'un babası hayatını kaybetti. Annesi kendini savunduğu gerekçesiyle ceza almadı. 6 yaşında bale dersleri almaya 16 yaşında modellik yapmaya başladı. Ancak bir süre sonra dizinden sakatlandı ve profesyonel olamadan balerinliğe noktayı koydu. Daha sonra modelliği bıraktı ve oyuncu olmaya karar verdi. 19 yaşında New York'a gitti. 1997'deki Şeytanın Avukatı filmiyle büyük dikkat çekti. 2001'de Kasımda Aşk Başkadır filminde yine Keanu Reeves ile başrolü paylaştı. 2003 yapımı Canavar (Monster) filmindeki Aileen Wuornos rolüyle En İyi Kadın Oyuncu dalında Oscar kazandı. 2005'te Æon Flux filminde oynadı. 2008'de Hancock ve Guillermo Arriaga'nın The Burning Plain filmlerinde başroldeydi. 2012 yapımı Pamuk Prenses ve Avcı filmindeki Ravena rolünü 2016'daki devam filmi Avcı: Kış Savaşı'nda da üstlendi. 2017'de Hızlı ve Öfkeli serisinin 8. filminde, Cipher rolünde oynadı. Aynı yıl başrolünde olduğu Sarışın Bomba (Atomic Blonde) filmindeki performansıyla büyük beğeni kazandı. 2001 yılından 2010'a dek İrlandalı aktör Stuart Townsend ile birlikte olan Theron, 2012'de Jackson adlı bir erkek, 2015'te August adlı bir kız çocuk evlat edindi. 2007 yılında Amerika vatandaşlığı aldı.", "Charlize Threon", "https://cdn.sinemalar.com/images/person/29884/poster/charlize-theron-1691414633.jpg", "07 Ağustos 1975", 3 }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "MovieId" },
                values: new object[,]
                {
                    { 1, "Bilim Kurgu", 1 },
                    { 2, "Aksiyon", 1 },
                    { 3, "Macera", 1 },
                    { 4, "Animasyon", 2 },
                    { 5, "Aile", 2 },
                    { 6, "Komedi", 2 },
                    { 7, "Fantastik", 3 },
                    { 8, "Tarih", 3 },
                    { 9, "Bilim Kurgu", 4 },
                    { 10, "Aksiyon", 4 },
                    { 11, "Macera", 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Actors_MovieId",
                table: "Actors",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_MovieId",
                table: "Categories",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_DirectorId",
                table: "Movies",
                column: "DirectorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Directors");
        }
    }
}
