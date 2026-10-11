using Microsoft.EntityFrameworkCore;
using MovieApi.Server.EntityLayer.Entities;

namespace MovieApi.Server.DataAccessLayer.Context
{
    public class MovieContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=MovieApiDataBase;Integrated Security=True;TrustServerCertificate=True");
        }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Actor>().HasData(
               new Actor
               {
                   ActorId = 1,
                   ActorFullName = "Tom Holland",
                   BornDate = "1 Haziran 1996",
                   ActorBiography = "Thomas Stanley Holland, kısaca Tom Holland, İngiliz oyuncu, seslendirme sanatçısı " +
                    "ve dansçı. \"Spider-Man: Homecoming\" filmindeki Peter Parker rolüyle ünlenmiştir. 1996'da " +
                    "Londra'da doğdu. Annesi Nicola Elizabeth Frost fotoğrafçı, babası Dominic Holland ise " +
                    "yazar ve komedyendir. 1999'da doğan Sam ve Harry adlı ikiz kardeşlerinin yanında bir de " +
                    "2004 doğumlu Patrick adında toplam 3 erkek kardeşi vardır. Wimbledon College ve " +
                    "ardından The BRIT School for Performing Arts and Technology'de eğitim gördü.",
                   ActorImage = "https://cdn.sinemalar.com/images/afis_buyuk/t/tom-holland-1996-1785524509.jpg",
                   MovieId = 1
               },
                new Actor
                {
                    ActorId = 2,
                    ActorFullName = "Zendaya",
                    BornDate = "1 Eylül 1996",
                    ActorBiography = "Zendaya Maree Stoermer Coleman, 1996 yılında Oakland'da dünyaya geldi. Sanat hayatına " +
                    "çocuk yaşlarda dans ve oyunculukla adım atan isim, Disney Channel yapımı Haydi Çalkala " +
                    "(Shake It Up) dizisinde canlandırdığı Raquel \"Rocky\" Blue karakteriyle geniş kitlelerce " +
                    "tanındı. Bu projedeki başarısının ardından yine bir Disney yapımı olan K.C. Undercover " +
                    "dizisinde liseli bir ajana hayat vererek televizyon dünyasındaki yerini sağlamlaştırdı. " +
                    "Spider-Man filmlerinde MJ karakterini canlandırdı. Kariyerinin ilk yıllarından itibaren " +
                    "disiplini ve yeteneğiyle dikkat çeken oyuncu, müzik ve oyunculuğu bir arada yürüterek " +
                    "genç yaşta önemli bir hayran kitlesine ulaştı.",
                    ActorImage = "https://cdn.sinemalar.com/images/afis_buyuk/z/zendaya-coleman-1785524072.jpg",
                    MovieId = 1
                },
                new Actor
                {
                    ActorId = 3,
                    ActorFullName = "Jon Bernthal",
                    BornDate = "20 Eylül 1976",
                    ActorBiography = "Jonathan Edward Bernthal, kısaca Jon Bernthal, Amerikalı aktör. The Walking Dead " +
                    "dizisindeki Shane Walsh rolüyle hatırlanmaktadır. Joan Lurie ve Rick Bernthal çiftinin " +
                    "çocuğu olarak Washington D.C.'de doğdu. Yahudi bir ailenin çocuğu olan Bernthal'ın " +
                    "Nicholas ve Thomas adlarında 2 erkek kardeşi vardır. Skidmore College'da eğitim alırken " +
                    "burayı bırakan Bernthal, oyunculuk eğitimi için Moskova'ya gitti. Harvard Üniversitesi'nin " +
                    "İleri Tiyatro Eğitimi Enstitüsü'nde eğitim alırken keşfedildi ve mezuniyetinin ardından çok " +
                    "sayıda tiyatro oyununda yer aldı. 2010 yılında başlayan The Walking Dead dizisinin ilk " +
                    "sezonundaki baş karakterlerden olan Shane'i canlandırmasının ardından çok daha büyük bir " +
                    "hayran kitlesine erişti. 2013'te Martin Scorsese'nin The Wolf of Wall Street filminde " +
                    "Brad Bodnick rolünde oynadı. Sicario, Hesaplaşma (The Accountant), Tam Gaz (Baby Driver) " +
                    "gibi filmlerde daha önemli roller aldı. Daredevil dizisinde Frank Castle, yani The Punisher " +
                    "rolüyle izleyicilerin beğenisini kazanan Bernthal, daha sonra karakterin kendi dizisi " +
                    "The Punisher'da aynı rolü canlandırdı.",
                    ActorImage = "https://cdn.sinemalar.com/images/afis_buyuk/j/jon-bernthal-1785523878.jpg",
                    MovieId = 1
                },
                new Actor
                {
                    ActorId = 4,
                    ActorFullName = "Mark Ruffalo",
                    BornDate = "22 Kasım 1967",
                    ActorBiography = "Mark Alan Ruffalo, Amerikalı aktör ve yapımcı. 1967'de Wisconsin'in Kenosha " +
                    "kentinde doğdu. İtalyan asıllı bir ailenin çocuğudur; babası inşaat boyacısı, annesi " +
                    "kuafördür. Oyunculuk eğitimini Stella Adler Conservatory'de aldı. Kariyerinde çıkışı " +
                    "\"You Can Count on Me\" filmiyle yaptı. Eternal Sunshine of the Spotless Mind, Zodiac, " +
                    "Foxcatcher, Spotlight ve Poor Things gibi yapımlarda yer aldı ve birçok kez Oscar'a " +
                    "aday gösterildi. The Avengers (2012) filminden itibaren Marvel Sinematik Evreni'nde " +
                    "Bruce Banner / Hulk karakterini canlandırmaktadır. Aynı zamanda çevre ve insan hakları " +
                    "konularındaki aktivizmiyle de tanınır.",
                    ActorImage = "https://cdn.sinemalar.com/images/afis_buyuk/m/mark-ruffalo-1785524233.jpg",
                    MovieId = 1
                },
                new Actor
                {
                    ActorId = 5,
                    ActorFullName = "Jacob Batalon",
                    BornDate = "9 Haziran 1996",
                    ActorBiography = "Jacob Batalon, Amerikalı aktör. 1996'da Hawaii'nin Honolulu kentinde doğdu. " +
                    "Filipin ve Hawaii kökenlidir. Oyunculuk kariyerine küçük rollerle başladı ve " +
                    "\"Spider-Man: Homecoming\" filminde Peter Parker'ın en yakın arkadaşı Ned Leeds " +
                    "rolüyle geniş kitlelerce tanındı. Aynı karakteri Spider-Man: Far From Home ve " +
                    "Spider-Man: No Way Home filmlerinde de canlandırdı. Let It Snow filminde ve " +
                    "Reginald the Vampire dizisinde başrol oynadı.",
                    ActorImage = "https://cdn.sinemalar.com/images/afis_buyuk/j/jacob-batalon-1785661720.jpg", 
                    MovieId = 1
                },
                new Actor
                {
                    ActorId = 6,
                    ActorFullName = "Tom Hanks",
                    BornDate = "9 Temmuz 1956",
                    ActorBiography = "Thomas Jeffrey Hanks, kısaca Tom Hanks, Amerikalı aktör, yapımcı ve yönetmen. " +
                    "1956'da Kaliforniya'nın Concord kentinde doğdu. Forrest Gump, Philadelphia, Apollo 13, " +
                    "Cast Away ve Saving Private Ryan gibi yapımlardaki rolleriyle tanınır. Philadelphia ve " +
                    "Forrest Gump filmleriyle art arda iki kez en iyi erkek oyuncu Oscar'ını kazandı. " +
                    "1995'te çıkan ilk Toy Story filminden bu yana Andy'nin kovboy oyuncağı Woody'yi " +
                    "seslendirmekte ve karakteri Toy Story 5'te de canlandırmaktadır.",
                    ActorImage = "https://cdn.sinemalar.com/images/person/25663/poster/tom-hanks-1654002859.jpg",
                    MovieId = 1
                },
                new Actor
                {
                    ActorId = 7,
                    ActorFullName = "Tim Allen",
                    BornDate = "13 Haziran 1953",
                    ActorBiography = "Timothy Alan Dick, sahne adıyla Tim Allen, Amerikalı aktör ve komedyen. " +
                    "1953'te Colorado'nun Denver kentinde doğdu. Stand-up komedisiyle başladığı kariyerinde " +
                    "Home Improvement dizisindeki Tim Taylor rolüyle geniş kitlelere ulaştı. The Santa Clause " +
                    "filmleri ve Galaxy Quest ile de tanınır. Toy Story serisinin tamamında Buzz Lightyear'ı " +
                    "seslendirmiştir ve Toy Story 5'te de aynı karaktere ses vermektedir.",
                    ActorImage = "https://cdn.sinemalar.com/images/person/25663/poster/tom-hanks-1654002859.jpg",
                    MovieId = 2
                },
                new Actor
                {
                    ActorId = 8,
                    ActorFullName = "Joan Cusack",
                    BornDate = "11 Ekim 1962",
                    ActorBiography = "Joan Cusack, Amerikalı aktris. 1962'de New York'ta doğdu. Aktör John Cusack'ın " +
                    "kız kardeşidir. Working Girl ve In & Out filmleriyle Oscar'a aday gösterildi. " +
                    "Toy Story 2'de tanıtılan, Bonnie'nin kovboy kız bez bebeği Jessie'yi seslendirmektedir " +
                    "ve karakter Toy Story 5'te oyuncakların yeni lideri olarak yer almaktadır.",
                    ActorImage = "https://cdn.sinemalar.com/images/person/28068/poster/joan-cusack-1530185352.jpg",
                    MovieId = 2
                },
                new Actor
                {
                    ActorId = 9,
                    ActorFullName = "Greta Lee",
                    BornDate = "7 Mart 1983",
                    ActorBiography = "Greta Lee, Amerikalı aktris. 1983'te Los Angeles'ta doğdu. Past Lives filmindeki " +
                    "Nora rolüyle büyük beğeni topladı ve film en iyi film dalında Oscar'a aday gösterildi. " +
                    "Russian Doll ve The Morning Show dizilerindeki rolleriyle de tanınır. " +
                    "Toy Story 5'te Bonnie'ye gelen kurbağa şeklindeki akıllı tablet Lilypad (Lily) karakterini seslendirmektedir.",
                    ActorImage = "https://cdn.sinemalar.com/images/person/467666/poster/greta-lee-1701162204.jpg",
                    MovieId = 2
                },
                new Actor
                {
                    ActorId = 10,
                    ActorFullName = "Conan O'Brien",
                    BornDate = "18 Nisan 1963",
                    ActorBiography = "Conan Christopher O'Brien, Amerikalı televizyon sunucusu, komedyen, yazar ve yapımcı. " +
                    "1963'te Massachusetts'in Brookline kentinde doğdu ve Harvard Üniversitesi'nde eğitim gördü. " +
                    "Saturday Night Live ve The Simpsons için senarist olarak çalıştıktan sonra Late Night with " +
                    "Conan O'Brien programıyla tanındı; ardından The Tonight Show ve TBS'te Conan programlarını sundu. " +
                    "Toy Story 5'te tuvalet eğitimi veren teknolojik oyuncak Smarty Pants'i seslendirmektedir.",
                    ActorImage = "https://cdn.sinemalar.com/images/person/118146/poster/conan-obrien-1740985359.jpg",
                    MovieId = 2
                },
                new Actor
                {
                    ActorId = 11,
                    ActorFullName = "Robert Downwey JR",
                    BornDate = "04 Nisan 1985",
                    ActorBiography = "Robert John Downey, Jr., BAFTA ve Altın Küre sahibi ABD'li oyuncu ve yapımcıdır. \"Sherlock " +
                    "Holmes\"ve \"Iron Man\" serilerinin yanısıra \"Chaplin\", \"Natural Born Killers\", \"Good Night and " +
                    "Good Luck\", \"Kiss Kiss Bang Bang\", \"Zodiac\", \"Tropic Thunder\" ve \"Yenilmezler\" gibi filmler " +
                    "ile de tanınmaktadır. 4 Nisan 1965'te New York'ta doğmuştur. Aktör, yazar, prodüktör ve " +
                    "yönetmen Robert Downey Sr.'nin oğlu olan Downey Jr., 1970 yılında babasının yönettiği " +
                    "\"Pound\" adlı filmde küçük bir rol alarak sinema kariyerine başlamıştır. Aynı zamanda iyi bir " +
                    "müzisyen de olan Robert Downey Jr., 80'lerin sonu ile 90’ların başında rol aldığı filmler ile" +
                    "üne kavuşmuştur. Ona ilk ün getiren rolü 1987 yapımlı \"Less Than Zero\" isimli filmde " +
                    "canlandırdığı uyuşturcu bağımlısı genç karakteridir. ",
                    ActorImage = "https://cdn.sinemalar.com/images/person/26076/poster/robert-downey-jr-1659014225.jpg",
                    MovieId = 4
                },
                new Actor
                {
                    ActorId = 12,
                    ActorFullName = "Chris Evans",
                    BornDate = "13 Haziran 1981",
                    ActorBiography = "Christopher Robert \"Chris\" Evans, Amerikalı oyuncu olarak sinema dünyasında kendine " +
                    "sağlam bir yer edindi. Sanatçı bir aileden gelen Evans, yönetmen bir anne ile diş hekimi bir " +
                    "babanın oğlu olarak dünyaya geldi. İtalyan ve İrlanda kökenlerine sahip olan oyuncu," +
                    "kardeşleri Carly DuBray, Shanna ve Scott ile birlikte büyüdü. Kariyerinin ilk yıllarında gençlik" +
                    "yapımlarına yönelen Evans, 2001 yılındaki Not Another Teen Movie filminde canlandırdığı " +
                    "Jake Wyler karakteriyle ilk önemli çıkışını gerçekleştirdi.",
                    ActorImage = "https://cdn.sinemalar.com/images/person/27912/poster/chris-evans-1674207537.jpg",
                    MovieId = 4
                },
                new Actor
                {
                    ActorId = 13,
                    ActorFullName = "Pedro Pascal",
                    BornDate = "02 Nisan 1975",
                    ActorBiography = "José Pedro Balmaceda Pascal, Şili kökenli ABD'li oyuncu. \"Game of Thrones\" dizisindeki " +
                    "Oberyn Martell ve \"Narcos\" dizisindeki Javier Peña rolleriyle hatırlanmaktadır." +
                    "Pedro Pascal, 1975'te Şili'nin başkenti Santiago'da doğdu. Salvador Allende'nin devrilmesi " +
                    "ve Augusto Pinochet'nin yönetime gelmesiyle zor günler geçiren Allende destekçisi ailesi " +
                    "önce Danimarka'dan siyasi sığınma hakkı aldı, daha sonra Amerika Birleşik Devletleri'ne " +
                    "taşındılar. Pascal, Oranga County ve San Antonio'da büyüdü. Çocukluk yıllarında yüzmeyle " +
                    "ilgilendi, ancak sonra oyunculuğa döndü. New York'ta Tisch School of the Arts'ta eğitim " +
                    "gördü. \"Buffy the Vampire Slayer\", \"Without a Trace\", \"Law & Order\" gibi çok sayıda dizide " +
                    "bölüm oyuncusu olarak yer aldı.",
                    ActorImage = "https://cdn.sinemalar.com/images/person/383637/poster/pedro-pascal-1678704056.jpg",
                    MovieId = 4
                },
                new Actor
                {
                    ActorId = 14,
                    ActorFullName = "Vanessa Kirby",
                    BornDate = "18 Nisan 1988",
                    ActorBiography = "Vanessa Kirby, İngiliz aktris. Doktor bir baba ve gazeteci bir annenin çocuğu olarak " +
                    "dünyaya gelen Kirby, Wimbledon'da büyüdü. Lady Eleanor Holles School'da okudu. Bristol " +
                    "Old Vic Tiyatro Okulu tarafından kabul edilmeyince, 1 yıl boyunca dünyayı dolaştı. " +
                    "Sonrasında Exeter Üniversitesi'nde İngiliz Dili bölümüne kaydoldu. Yönetmen David " +
                    "Thacker'la tanışmasının ardından birçok tiyatro oyununda oynayarak kendini ispatladı. " +
                    "Televlziyon dünyasına geçişi de 2011'de oldu. 2013'te Zamanda Aşk (About Time) filminde " +
                    "Rachel McAdams'ın canlandırdığı karakterin en yakın arkadaşı rolünde oynadı. 2016'da " +
                    "başlayan The Crown dizisindeki Prenses Margaret rolüyle beğeni topladı. Yine 2016 yapımı " +
                    "Genius ve Senden Önce Ben gibi filmlerde oynayan Kirby, 2018 yapımı Görevimiz Tehlike 6 " +
                    "filminin de kadrosunda yer aldı.",
                    ActorImage = "https://cdn.sinemalar.com/images/person/557256/poster/vanessa-kirby-1698238705.jpg",
                    MovieId = 4
                },
                new Actor
                {
                    ActorId = 15,
                    ActorFullName = "Ebon Moss-Bachrach",
                    BornDate = "17 Ağustos 1978",
                    ActorBiography = "Ebon Moss-Bachrach, Renee Moss ve Eric Bachrach çiftinin çocuğu olarak Amherst, " +
                    "Massachusetts'te dünyaya geldi. Eğitim hayatını Amherst Bölgesel Lisesi ve Columbia " +
                    "Üniversitesi’nde tamamlayan oyuncu, kariyerinin ilk yıllarında çeşitli televizyon " +
                    "yapımlarında deneyim kazandı. Beyaz perdedeki asıl çıkışını Mona Lisa Gülüşü filminde " +
                    "canlandırdığı Charlie Stewart karakteriyle gerçekleştiren aktör, ardından Sandra Bullock ve " +
                    "Keanu Reeves gibi isimlerin yer aldığı Göl Evi (The Lake House) kadrosuna dahil oldu. " +
                    "Kariyerine Suburban Girl ve Evening gibi sinema filmleriyle devam eden Moss-Bachrach, " +
                    "geniş bir tür yelpazesinde farklı karakterlere hayat verdi.",
                    ActorImage = "https://cdn.sinemalar.com/images/person/54425/poster/ebon-moss-bachrach-1691583261.jpg",
                    MovieId = 4
                },
                new Actor
                {
                    ActorId = 16,
                    ActorFullName = "Matt Damon",
                    BornDate = "08 Ekim 1970",
                    ActorBiography = "Matthew Paige Damon, Amerikalı oyuncu ve senaristtir. Borsacı bir babaya ve çocuk " +
                    "gelişimi profesörü bir anneye sahip olan Damon, Cambridge, Massachusetts'de " +
                    "doğmuştur. Annesi tarafından Fin ve İsveç kökeni, babası tarafından ise İngiliz ve İskoç " +
                    "kökeni vardır. 1988-1992 yılları arasında Harvard Üniversitesi'nde edebiyat okumuştur. " +
                    "1997'de Ben Affleck ile yazdığı \"Can Dostum\" filmi ile \"En İyi Senaryo\" kategorisinde " +
                    "Altın Küre ve Oscar kazanmıştır. İlk kez 18 yaşında \"Mystic Pizza\" filminde bir satırlık bir rol " +
                    "oynamıştır. Son yıllarda \"Thor: Aşk ve Gök Gürültüsü\", \"Son Düello\" gibi filmlerde yer " +
                    "almıştır. En son Christopher Nolan'ın \"Oppenheimer\" filminde de yer aldı.",
                    ActorImage = "https://cdn.sinemalar.com/images/person/26297/poster/matt-damon-1659013904.jpg",
                    MovieId = 3
                },
                new Actor
                {
                    ActorId = 17,
                    ActorFullName = "Anne Hataway",
                    BornDate = "12 Kasım 1982",
                    ActorBiography = "Anne Hathaway 12 Kasım 1982 tarihinde Brooklyn, New York’ta doğmuş Amerikalı " +
                    "oyuncudur. Çocukluk yıllarını New Jersey’de geçiren Hathaway, oyunculuğa genç yaşta ilgi " +
                    "duymuş ve lise döneminde sahne performanslarıyla dikkat çekmiştir. Eğitimini oyunculuk " +
                    "üzerine alan sanatçı, kariyerine 1999 yılında “Get Real” dizisiyle başlamıştır." +
                    "\r\n\r\nSinema kariyerindeki ilk büyük çıkışını 2001 yapımı “Acemi Prenses” filmiyle yapan " +
                    "Hathaway, bu rolle geniş kitlelerce tanınmıştır. Kariyerinin ilk döneminde “Nicholas " +
                    "Nickleby” ve “Ella: Sihirli Yolculuk” gibi daha çok aile ve gençlik odaklı yapımlarda yer " +
                    "almıştır. 2005 yılından itibaren ise daha olgun ve dramatik rollere yönelerek kariyerinde " +
                    "önemli bir dönüşüm yaşamıştır. “Brokeback Dağı” filmindeki performansı eleştirmenlerden " +
                    "olumlu yorumlar alırken, “Şeytan Marka Giyer” ile uluslararası çapta büyük bir tanınırlık " +
                    "kazanmıştır.",
                    ActorImage = "https://cdn.sinemalar.com/images/person/25721/poster/anne-hathaway-1692352269.jpg",
                    MovieId = 3
                },
                new Actor
                {
                    ActorId = 18,
                    ActorFullName = "Robert Patinson",
                    BornDate = "13 Mayıs 1986",
                    ActorBiography = "Robert Douglas Thomas Pattinson, İngiliz aktör. \"Alacakaranlık\" film serisindeki Edward " +
                    "Cullen rolüyle hatırlanmaktadır. Clare ve Richard Pattinson çiftinin tek erkek çocuğu olarak " +
                    "1986'da Londra'da dünyaya geldi. Pattinson'ın Lizzy ve Victoria adında iki ablası vardır. " +
                    "Barnes Tiyatrosu'nun ve aynı zamanda Londralı bir müzik grubunun da üyesidir. 13 yaşında " +
                    "Tower House okulundan ayrıldıktan sonra Harrodian Özel Okulu'na girerek burada eğitimini " +
                    "başarıyla tamamladı.",
                    ActorImage = "https://cdn.sinemalar.com/images/afis_buyuk/r/robert-pattinson-1784406874.jpg",
                    MovieId = 3
                },
                new Actor
                {
                    ActorId = 19,
                    ActorFullName = "Charlize Threon",
                    BornDate = "07 Ağustos 1975",
                    ActorBiography = "Charlize Theron, Güney Afrikalı aktris. Şeytanın Avukatı ve İtalyan İşi gibi birçok filmdeki " +
                    "rolleriyle ünlüdür. Theron Güney Afrika'nın Benoni şehrinde doğdu. Annesi Gerda Alman," +
                    "babası Charles Theron ise Fransız asıllıdır. Annesi ve babası bir yol yapım şirketi işletiyordu. " +
                    "Theron 15 yaşında iken annesi bir tartışma sırasında babasını vurdu ve Theron'un babası " +
                    "hayatını kaybetti. Annesi kendini savunduğu gerekçesiyle ceza almadı. 6 yaşında bale " +
                    "dersleri almaya 16 yaşında modellik yapmaya başladı. Ancak bir süre sonra dizinden " +
                    "sakatlandı ve profesyonel olamadan balerinliğe noktayı koydu. Daha sonra modelliği bıraktı " +
                    "ve oyuncu olmaya karar verdi. 19 yaşında New York'a gitti. 1997'deki Şeytanın Avukatı " +
                    "filmiyle büyük dikkat çekti. 2001'de Kasımda Aşk Başkadır filminde yine Keanu Reeves " +
                    "ile başrolü paylaştı. 2003 yapımı Canavar (Monster) filmindeki Aileen Wuornos rolüyle En İyi " +
                    "Kadın Oyuncu dalında Oscar kazandı. 2005'te Æon Flux filminde oynadı. 2008'de Hancock " +
                    "ve Guillermo Arriaga'nın The Burning Plain filmlerinde başroldeydi. 2012 yapımı Pamuk " +
                    "Prenses ve Avcı filmindeki Ravena rolünü 2016'daki devam filmi Avcı: Kış Savaşı'nda da " +
                    "üstlendi. 2017'de Hızlı ve Öfkeli serisinin 8. filminde, Cipher rolünde oynadı. Aynı yıl " +
                    "başrolünde olduğu Sarışın Bomba (Atomic Blonde) filmindeki performansıyla büyük beğeni " +
                    "kazandı. 2001 yılından 2010'a dek İrlandalı aktör Stuart Townsend ile birlikte olan Theron, " +
                    "2012'de Jackson adlı bir erkek, 2015'te August adlı bir kız çocuk evlat edindi. 2007 yılında " +
                    "Amerika vatandaşlığı aldı.",
                    ActorImage = "https://cdn.sinemalar.com/images/person/29884/poster/charlize-theron-1691414633.jpg",
                    MovieId = 3
                }
            );

            modelBuilder.Entity<Movie>().HasData(
                new Movie
                {
                    MovieId=1,
                    MovieTitle = "Örümcek-Adam: Yepyeni Bir Gün",
                    OriginalTitle = "Spider-Man: Brand New Day",
                    ReleaseYear = 2026,
                    ReleaseDate = "31 Temmuz 2026",
                    MovieSecond = "2 saat 20 dakika",
                    MovieReview = "Örümcek-Adam: Yepyeni Bir Gün, Peter Parker’ın (Tom Holland) kimliğinin unutulduğu " +
                    "bir dünyada yaşadığı zorlu süreci merkezine alıyor. Sevdiklerinin hayatlarına onsuz devam " +
                    "etmesine tanıklık eden Peter, tam zamanlı kahramanlık yapmanın getirdiği ağır baskı " +
                    "altında kontrolü güç bir değişim geçirmeye başlar. Yaşadığı bu içsel dönüşüm, şehre ve " +
                    "sevdiklerine yönelecek gizemli bir tehditle mücadele edebilmesi için tek anahtara dönüşür. " +
                    "Peter Parker, kimsenin varlığını fark edemediği bu güçlü düşmanı durdurmak için yeni " +
                    "haliyle yüzleşmek zorundadır.",
                    DirectorId = 2,
                  },
                  new Movie
                  {
                      MovieId =2,
                      MovieTitle = "Oyuncak Hikayesi 5",
                      OriginalTitle = "Toy Story 5",
                      ReleaseYear = 2026,
                      ReleaseDate = "19 Haziran 2026",
                      MovieSecond = "2 saat 20 dakika",
                      MovieReview = "Örümcek-Adam: Yepyeni Bir Gün, Peter Parker’ın (Tom Holland) kimliğinin unutulduğu " +
                    "bir dünyada yaşadığı zorlu süreci merkezine alıyor. Sevdiklerinin hayatlarına onsuz devam " +
                    "etmesine tanıklık eden Peter, tam zamanlı kahramanlık yapmanın getirdiği ağır baskı " +
                    "altında kontrolü güç bir değişim geçirmeye başlar. Yaşadığı bu içsel dönüşüm, şehre ve " +
                    "sevdiklerine yönelecek gizemli bir tehditle mücadele edebilmesi için tek anahtara dönüşür. " +
                    "Peter Parker, kimsenin varlığını fark edemediği bu güçlü düşmanı durdurmak için yeni " +
                    "haliyle yüzleşmek zorundadır.",
                      DirectorId = 1,
    
                  },
                  new Movie
                   {
                       MovieId =3,
                       MovieTitle = "Odyssey",
                       OriginalTitle = "The Odyssey",
                       ReleaseYear = 2026,
                       ReleaseDate = "17 Temmuz 2026",
                       MovieSecond = "2 saat 52 dakika",
                       MovieReview = "Homeros'un aynı adlı destanının bir uyarlaması olan film, Truva Savaşı'ndan sonra İthaka " +
                       "Kralı Odysseus'un evine dönüş yolculuğunu konu alıyor. Bu epik macerada, Odysseus'un " +
                       "(Matt Damon) Polyphemus (tek gözlü dev, Bill Irwin), Sirenler ve büyücü tanrıça Circe " +
                       "(Samantha Morton) gibi mitolojik figürlerle karşılaşmaları anlatılıyor. ",
                       DirectorId = 1
          
                  },
                  new Movie
                  {
                      MovieId =4,
                      MovieTitle = "Avengers: Doomsday",
                      OriginalTitle = "Avengers: Doomsday",
                      ReleaseYear = 2026,
                      ReleaseDate = "18 Aralık 2026",
                      MovieSecond = "2 saat 45 dakika",
                      MovieReview = "Thunderbolts* filminde yaşanan olayların üzerinden 14 ay geçmiştir ve evren, şimdiye " +
                      "kadarki en büyük tehditlerinden biriyle karşı karşıyadır. Avengers ekibi, yaklaşan bu büyük " +
                      "tehlikeyi durdurabilmek için Wakandalılar, Fantastic Four, New Avengers ve orijinal X-Men " +
                      "üyeleriyle bir araya gelir. Kahramanların önündeki en büyük engel ise karanlık güçleriyle" +
                      "tehdit saçan Doctor Doom’dur.",
                      DirectorId = 2
                  }

            );
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    CategoryId = 1,
                    CategoryName = "Bilim Kurgu",
                    MovieId = 1
                },
                new Category
                {
                    CategoryId = 2,
                    CategoryName = "Aksiyon",
                    MovieId = 1
                },
                new Category
                {
                    CategoryId = 3,
                    CategoryName = "Macera",
                    MovieId = 1
                },
                new Category
                {
                    CategoryId= 4,
                    CategoryName = "Animasyon",
                    MovieId = 2
                },
                new Category
                {
                    CategoryId = 5,
                    CategoryName = "Aile",
                    MovieId = 2
                },
                new Category
                {
                    CategoryId = 6,
                    CategoryName = "Komedi",
                    MovieId = 2
                },
                new Category
                {
                    CategoryId = 7,
                    CategoryName = "Fantastik",
                    MovieId = 3
                },
                new Category
                {
                    CategoryId = 8,
                    CategoryName = "Tarih",
                    MovieId = 3
                },
                new Category
                {
                    CategoryId = 9,
                    CategoryName = "Bilim Kurgu", 
                    MovieId = 4
                },
                new Category
                {
                    CategoryId = 10,
                    CategoryName = "Aksiyon",
                    MovieId = 4
                },
                new Category
                {
                    CategoryId = 11,
                    CategoryName = "Macera",
                    MovieId = 4
                }
            );

            modelBuilder.Entity<Director>().HasData(
                new Director
                {
                    DirectorID = 1,
                    DirectorFullName = "Andrew Stanton",
                    DirectorBornDate = "03 Aralık 1965",
                    DirectorBiography = "Andrew Stanton, 3 Aralık 1965’te doğmuş Amerikalı yönetmen, senarist, yapımcı ve zaman zaman " +
                    "seslendirme sanatçısıdır. Özellikle Finding Nemo ve WALL-E gibi modern " +
                    "animasyon sinemasının en önemli yapımlarındaki çalışmalarıyla tanınır. Kariyerini büyük " +
                    "ölçüde Pixar Animation Studios bünyesinde şekillendiren Stanton, stüdyonun yaratıcı " +
                    "kimliğini oluşturan kilit isimlerden biri olmuştur.",
                    DirectorImage = "https://cdn.sinemalar.com/images/afis_buyuk/a/andrew-stanton-1782130626.jpg"
                },
                new Director
                {
                    DirectorID = 2,
                    DirectorFullName = "Destin Daniel Cretton",
                    DirectorBornDate = "23 Kasım 1978",
                    DirectorBiography = "23 Kasım 1978 doğumlu Amerikalı yönetmen, senarist ve yapımcı Destin Daniel Cretton, " +
                    "sinema kariyerinde hem bağımsız dramalarla hem de büyük bütçeli stüdyo yapımlarıyla " +
                    "kendine yer buldu. Kariyerinin erken döneminde Short Term 12 ve I Am Not a Hipster gibi " +
                    "projelerde yönetmenliğin yanı sıra senaryo yazımı ve kurgu süreçlerini de üstlenen sanatçı, " +
                    "özellikle Short Term 12 ile sinema dünyasında geniş bir kesimin dikkatini çekti. Ardından " +
                    "Camdan Kale (The Glass Castle) ve gerçek bir hayat hikayesine dayanan Just Mercy gibi " +
                    "yapımların yönetmen koltuğuna oturarak derinlikli karakter analizlerine odaklanan işlere" +
                    "imza attı.",
                    DirectorImage = "https://cdn.sinemalar.com/images/afis_buyuk/d/destin-daniel-cretton-1786138090.jpg"
                }
            );

        }
    }
}
