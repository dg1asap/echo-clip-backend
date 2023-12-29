using Microsoft.EntityFrameworkCore;

namespace EchoClip.Models;

public class DatabaseUserSeeder : IDatabaseSeeder
{
    public void seedData(ModelBuilder modlerBuilder)
    {
        modlerBuilder.Entity<User>().HasData(
            new User
            {
                UserId = Guid.Parse("26a3417b-651f-4f74-bda2-bac9a93012ef"),
                Username = "admin",
                Password = "admin",
                Email = "admin@echoclip.com",
                Name = "admin_name",
                Surname = "admin_surname"
            },
            new User
            {
                UserId = Guid.Parse("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983"),
                Username = "jskilbeckc",
                Password = "oiawakLJ86lmK",
                Email = "kmountstephen0@bandcamp.com",
                Name = "Karlyn",
                Surname = "Mountstephen"
            },
            new User
            {
                UserId = Guid.Parse("81e75865-2b69-4440-af1d-bcbd2817abbe"),
                Username = "tcreggd",
                Password = "vqdtyqMJ96I_Wnz",
                Email = "jkenward1@ucoz.com",
                Name = "Jorrie",
                Surname = "Kenward"
            },
            new User
            {
                UserId = Guid.Parse("70693fa5-9180-4f05-854d-5d86aa286535"),
                Username = "jpaxeforde",
                Password = "skbuusYM66~l&~~fg.b",
                Email = "dcampey2@prweb.com",
                Name = "Dennie",
                Surname = "Campey"
            },
            new User
            {
                UserId = Guid.Parse("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3"),
                Username = "spaulsf",
                Password = "pzrdqtAC87.*=OSEe",
                Email = "wweal3@umn.edu",
                Name = "Walton",
                Surname = "Weal"
            },
            new User
            {
                UserId = Guid.Parse("ebcc0f14-937b-4c82-a021-5ff55809dec3"),
                Username = "radshadg",
                Password = "dfffhfMD902/N&,",
                Email = "aackerley4@craigslist.org",
                Name = "Alic",
                Surname = "Ackerley"
            },
            new User
            {
                UserId = Guid.Parse("de1565eb-061b-4ffe-a1af-63a370bebaa7"),
                Username = "thirtheh",
                Password = "twbumeEG022X}9+.s",
                Email = "jhunn5@sakura.ne.jp",
                Name = "Jaime",
                Surname = "Hunn"
            },
            new User
            {
                UserId = Guid.Parse("1b6e43d2-3000-41ef-9aa8-24a5bb961f4c"),
                Username = "vyekeli",
                Password = "vbucwsUS01i}",
                Email = "drehme6@ning.com",
                Name = "Daryl",
                Surname = "Rehme"
            },
            new User
            {
                UserId = Guid.Parse("fc029e14-d132-4bf3-a958-490d18320df7"),
                Username = "orolfoj",
                Password = "fvaidgLM98cU{Oxj*d",
                Email = "stopling7@meetup.com",
                Name = "Shirline",
                Surname = "Topling"
            },
            new User
            {
                UserId = Guid.Parse("1b854f16-2261-42b1-a614-5f9106a03b63"),
                Username = "kblazyk",
                Password = "jgsunoAT85",
                Email = "gmaes8@mlb.com",
                Name = "Georgette",
                Surname = "Maes"
            },
            new User
            {
                UserId = Guid.Parse("c9772f81-2145-4338-ad2d-9504b4b3dc6a"),
                Username = "iguinnessl",
                Password = "fuhhrhMD95~5h",
                Email = "nelmhurst9@tiny.cc",
                Name = "Nataline",
                Surname = "Elmhurst"
            },
            new User
            {
                UserId = Guid.Parse("8bb3ec1e-07e9-4bad-ab1f-15691b291e9d"),
                Username = "asidebottonm",
                Password = "mjuwyyHZ56",
                Email = "rgrebnera@github.com",
                Name = "Rica",
                Surname = "Grebner"
            },
            new User
            {
                UserId = Guid.Parse("57692189-acbb-4aa2-b2c9-6a5291e611af"),
                Username = "egomesn",
                Password = "powexpAI30<@c",
                Email = "bstapellsb@utexas.edu",
                Name = "Betsey",
                Surname = "Stapells"
            },
            new User
            {
                UserId = Guid.Parse("8bc1ae99-62b1-4c3b-936a-ed89898adceb"),
                Username = "dcraineo",
                Password = "zmyhgvLQ71Y%''vVwL=a",
                Email = "jskilbeckc@nih.gov",
                Name = "Joell",
                Surname = "Skilbeck"
            },
            new User
            {
                UserId = Guid.Parse("85fd205e-86a0-419b-8d59-7dc80f5b734e"),
                Username = "wbrantlp",
                Password = "dtgalrGM70BoJM<xPmMA",
                Email = "tcreggd@phpbb.com",
                Name = "Tomasina",
                Surname = "Cregg"
            },
            new User
            {
                UserId = Guid.Parse("9b419875-e449-4d74-9dd7-7c9630374799"),
                Username = "wkalbq",
                Password = "bhakfiHB61",
                Email = "jpaxeforde@marriott.com",
                Name = "Jard",
                Surname = "Paxeford"
            },
            new User
            {
                UserId = Guid.Parse("cd61d42e-6981-480e-aaf5-4869d78b9b81"),
                Username = "cmunkleyr",
                Password = "oqnttoBT60Gr&,A",
                Email = "spaulsf@paginegialle.it",
                Name = "Sib",
                Surname = "Pauls"
            },
            new User
            {
                UserId = Guid.Parse("c8d49eba-1396-41f3-9414-8bfd2021b793"),
                Username = "zskinners",
                Password = "fxbxvfPO83_3whVg~fFy",
                Email = "radshadg@java.com",
                Name = "Rhodia",
                Surname = "Adshad"
            },
            new User
            {
                UserId = Guid.Parse("e22141d8-f3ce-49db-bcf9-cdd1961b48b5"),
                Username = "ghordlet",
                Password = "vsmuhzNP702giJF",
                Email = "thirtheh@acquirethisname.com",
                Name = "Temp",
                Surname = "Hirthe"
            },
            new User
            {
                UserId = Guid.Parse("99ba6920-55ac-4657-8712-c7241f23c9bf"),
                Username = "iantcliffu",
                Password = "dokmsoSF73@z{#>F$e_l",
                Email = "vyekeli@sourceforge.net",
                Name = "Verna",
                Surname = "Yekel"
            },
            new User
            {
                UserId = Guid.Parse("8cbc3199-5acc-4e26-8e4b-3e84c563dfca"),
                Username = "cgerrishv",
                Password = "lezbpqVC17vEQ#B",
                Email = "orolfoj@webmd.com",
                Name = "Ora",
                Surname = "Rolfo"
            },
            new User
            {
                UserId = Guid.Parse("213c170b-0b1c-499f-8e18-d35e5a7707ff"),
                Username = "edillawayw",
                Password = "asiiqsMS48){",
                Email = "kblazyk@trellian.com",
                Name = "Kristen",
                Surname = "Blazy"
            },
            new User
            {
                UserId = Guid.Parse("b2a250cb-9279-4c0a-b6ac-262e4d43225e"),
                Username = "gmouatx",
                Password = "kfdjqoCT89~2ziPf/",
                Email = "iguinnessl@weebly.com",
                Name = "Iggie",
                Surname = "Guinness"
            },
            new User
            {
                UserId = Guid.Parse("e41fa0bd-0a3e-45d6-89ec-b2c753a1ddb5"),
                Username = "nstenningsy",
                Password = "pelqgvYB43L#MhW&u''",
                Email = "asidebottonm@ocn.ne.jp",
                Name = "Alfonse",
                Surname = "Sidebotton"
            },
            new User
            {
                UserId = Guid.Parse("a7958e4c-1912-49c2-bc24-563f7a2c8d8c"),
                Username = "toretz",
                Password = "qekojkOS07PF$PBK12",
                Email = "egomesn@joomla.org",
                Name = "Ediva",
                Surname = "Gomes"
            }
        );
    }
}
