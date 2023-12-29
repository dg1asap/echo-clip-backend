using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EchoClip.Models.Migrations
{
    /// <inheritdoc />
    public partial class iisafbhafd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    User_id = table.Column<Guid>(type: "uuid", nullable: false),
                    Username = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Surname = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.User_id);
                });

            migrationBuilder.CreateTable(
                name: "Chats",
                columns: table => new
                {
                    Chat_id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Owner_user_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chats", x => x.Chat_id);
                    table.ForeignKey(
                        name: "FK_Chats_Users_Owner_user_id",
                        column: x => x.Owner_user_id,
                        principalTable: "Users",
                        principalColumn: "User_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users_relationships",
                columns: table => new
                {
                    User_id = table.Column<Guid>(type: "uuid", nullable: false),
                    User_friend_id = table.Column<Guid>(type: "uuid", nullable: false),
                    Status = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users_relationships", x => new { x.User_id, x.User_friend_id });
                    table.CheckConstraint("CK_USER_STAT", "\"Status\" IN ('PENDING', 'ACCEPTED', 'REJECTED')");
                    table.ForeignKey(
                        name: "FK_Users_relationships_Users_User_friend_id",
                        column: x => x.User_friend_id,
                        principalTable: "Users",
                        principalColumn: "User_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_relationships_Users_User_id",
                        column: x => x.User_id,
                        principalTable: "Users",
                        principalColumn: "User_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Voice_recordings",
                columns: table => new
                {
                    Voice_recording_id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Owner_user_id = table.Column<Guid>(type: "uuid", nullable: false),
                    Audio_data_path = table.Column<string>(type: "text", nullable: false),
                    Upload_data_time = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voice_recordings", x => x.Voice_recording_id);
                    table.ForeignKey(
                        name: "FK_Voice_recordings_Users_Owner_user_id",
                        column: x => x.Owner_user_id,
                        principalTable: "Users",
                        principalColumn: "User_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users_who_joined_chats",
                columns: table => new
                {
                    User_id = table.Column<Guid>(type: "uuid", nullable: false),
                    Chat_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users_who_joined_chats", x => new { x.User_id, x.Chat_id });
                    table.ForeignKey(
                        name: "FK_Users_who_joined_chats_Chats_Chat_id",
                        column: x => x.Chat_id,
                        principalTable: "Chats",
                        principalColumn: "Chat_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_who_joined_chats_Users_User_id",
                        column: x => x.User_id,
                        principalTable: "Users",
                        principalColumn: "User_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Chats_voice_recordings",
                columns: table => new
                {
                    Chat_id = table.Column<Guid>(type: "uuid", nullable: false),
                    Voice_recording_id = table.Column<Guid>(type: "uuid", nullable: false),
                    Date_of_added = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chats_voice_recordings", x => new { x.Chat_id, x.Voice_recording_id });
                    table.ForeignKey(
                        name: "FK_Chats_voice_recordings_Chats_Chat_id",
                        column: x => x.Chat_id,
                        principalTable: "Chats",
                        principalColumn: "Chat_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Chats_voice_recordings_Voice_recordings_Voice_recording_id",
                        column: x => x.Voice_recording_id,
                        principalTable: "Voice_recordings",
                        principalColumn: "Voice_recording_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "User_id", "Email", "Name", "Password", "Surname", "Username" },
                values: new object[,]
                {
                    { new Guid("1b6e43d2-3000-41ef-9aa8-24a5bb961f4c"), "drehme6@ning.com", "Daryl", "vbucwsUS01i}", "Rehme", "vyekeli" },
                    { new Guid("1b854f16-2261-42b1-a614-5f9106a03b63"), "gmaes8@mlb.com", "Georgette", "jgsunoAT85", "Maes", "kblazyk" },
                    { new Guid("213c170b-0b1c-499f-8e18-d35e5a7707ff"), "kblazyk@trellian.com", "Kristen", "asiiqsMS48){", "Blazy", "edillawayw" },
                    { new Guid("26a3417b-651f-4f74-bda2-bac9a93012ef"), "admin@echoclip.com", "admin_name", "admin", "admin_surname", "admin" },
                    { new Guid("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983"), "kmountstephen0@bandcamp.com", "Karlyn", "oiawakLJ86lmK", "Mountstephen", "jskilbeckc" },
                    { new Guid("57692189-acbb-4aa2-b2c9-6a5291e611af"), "bstapellsb@utexas.edu", "Betsey", "powexpAI30<@c", "Stapells", "egomesn" },
                    { new Guid("70693fa5-9180-4f05-854d-5d86aa286535"), "dcampey2@prweb.com", "Dennie", "skbuusYM66~l&~~fg.b", "Campey", "jpaxeforde" },
                    { new Guid("81e75865-2b69-4440-af1d-bcbd2817abbe"), "jkenward1@ucoz.com", "Jorrie", "vqdtyqMJ96I_Wnz", "Kenward", "tcreggd" },
                    { new Guid("85fd205e-86a0-419b-8d59-7dc80f5b734e"), "tcreggd@phpbb.com", "Tomasina", "dtgalrGM70BoJM<xPmMA", "Cregg", "wbrantlp" },
                    { new Guid("8bb3ec1e-07e9-4bad-ab1f-15691b291e9d"), "rgrebnera@github.com", "Rica", "mjuwyyHZ56", "Grebner", "asidebottonm" },
                    { new Guid("8bc1ae99-62b1-4c3b-936a-ed89898adceb"), "jskilbeckc@nih.gov", "Joell", "zmyhgvLQ71Y%''vVwL=a", "Skilbeck", "dcraineo" },
                    { new Guid("8cbc3199-5acc-4e26-8e4b-3e84c563dfca"), "orolfoj@webmd.com", "Ora", "lezbpqVC17vEQ#B", "Rolfo", "cgerrishv" },
                    { new Guid("99ba6920-55ac-4657-8712-c7241f23c9bf"), "vyekeli@sourceforge.net", "Verna", "dokmsoSF73@z{#>F$e_l", "Yekel", "iantcliffu" },
                    { new Guid("9b419875-e449-4d74-9dd7-7c9630374799"), "jpaxeforde@marriott.com", "Jard", "bhakfiHB61", "Paxeford", "wkalbq" },
                    { new Guid("a7958e4c-1912-49c2-bc24-563f7a2c8d8c"), "egomesn@joomla.org", "Ediva", "qekojkOS07PF$PBK12", "Gomes", "toretz" },
                    { new Guid("b2a250cb-9279-4c0a-b6ac-262e4d43225e"), "iguinnessl@weebly.com", "Iggie", "kfdjqoCT89~2ziPf/", "Guinness", "gmouatx" },
                    { new Guid("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3"), "wweal3@umn.edu", "Walton", "pzrdqtAC87.*=OSEe", "Weal", "spaulsf" },
                    { new Guid("c8d49eba-1396-41f3-9414-8bfd2021b793"), "radshadg@java.com", "Rhodia", "fxbxvfPO83_3whVg~fFy", "Adshad", "zskinners" },
                    { new Guid("c9772f81-2145-4338-ad2d-9504b4b3dc6a"), "nelmhurst9@tiny.cc", "Nataline", "fuhhrhMD95~5h", "Elmhurst", "iguinnessl" },
                    { new Guid("cd61d42e-6981-480e-aaf5-4869d78b9b81"), "spaulsf@paginegialle.it", "Sib", "oqnttoBT60Gr&,A", "Pauls", "cmunkleyr" },
                    { new Guid("de1565eb-061b-4ffe-a1af-63a370bebaa7"), "jhunn5@sakura.ne.jp", "Jaime", "twbumeEG022X}9+.s", "Hunn", "thirtheh" },
                    { new Guid("e22141d8-f3ce-49db-bcf9-cdd1961b48b5"), "thirtheh@acquirethisname.com", "Temp", "vsmuhzNP702giJF", "Hirthe", "ghordlet" },
                    { new Guid("e41fa0bd-0a3e-45d6-89ec-b2c753a1ddb5"), "asidebottonm@ocn.ne.jp", "Alfonse", "pelqgvYB43L#MhW&u''", "Sidebotton", "nstenningsy" },
                    { new Guid("ebcc0f14-937b-4c82-a021-5ff55809dec3"), "aackerley4@craigslist.org", "Alic", "dfffhfMD902/N&,", "Ackerley", "radshadg" },
                    { new Guid("fc029e14-d132-4bf3-a958-490d18320df7"), "stopling7@meetup.com", "Shirline", "fvaidgLM98cU{Oxj*d", "Topling", "orolfoj" }
                });

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Chat_id", "Name", "Owner_user_id" },
                values: new object[,]
                {
                    { new Guid("3408c6f5-bcf0-467e-a068-b8b8bbb0689f"), "Alfa Golf", new Guid("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983") },
                    { new Guid("4189917d-7073-405b-8c47-a391f23fa31b"), "Delta Uniform", new Guid("ebcc0f14-937b-4c82-a021-5ff55809dec3") },
                    { new Guid("7999d70a-1a31-428e-9078-3c392dc1f4a8"), "Victor X-ray", new Guid("70693fa5-9180-4f05-854d-5d86aa286535") },
                    { new Guid("8b854df4-b93f-421b-8f52-76c7bf95fde9"), "Lima Sierra Bravo", new Guid("81e75865-2b69-4440-af1d-bcbd2817abbe") },
                    { new Guid("8c2c8480-978f-4a8f-89ac-a70a49bed05a"), "Tango Quebec", new Guid("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983") },
                    { new Guid("ec719221-7073-4694-897f-bfeabc02c22e"), "Yankee", new Guid("ebcc0f14-937b-4c82-a021-5ff55809dec3") },
                    { new Guid("ffda4624-660e-46a1-8a71-74e685fe6353"), "Papa Zulu", new Guid("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3") }
                });

            migrationBuilder.InsertData(
                table: "Users_relationships",
                columns: new[] { "User_friend_id", "User_id", "Status" },
                values: new object[,]
                {
                    { new Guid("1b854f16-2261-42b1-a614-5f9106a03b63"), new Guid("1b6e43d2-3000-41ef-9aa8-24a5bb961f4c"), "ACCEPTED" },
                    { new Guid("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983"), new Guid("1b6e43d2-3000-41ef-9aa8-24a5bb961f4c"), "ACCEPTED" },
                    { new Guid("57692189-acbb-4aa2-b2c9-6a5291e611af"), new Guid("1b6e43d2-3000-41ef-9aa8-24a5bb961f4c"), "PENDING" },
                    { new Guid("70693fa5-9180-4f05-854d-5d86aa286535"), new Guid("1b6e43d2-3000-41ef-9aa8-24a5bb961f4c"), "ACCEPTED" },
                    { new Guid("81e75865-2b69-4440-af1d-bcbd2817abbe"), new Guid("1b6e43d2-3000-41ef-9aa8-24a5bb961f4c"), "ACCEPTED" },
                    { new Guid("85fd205e-86a0-419b-8d59-7dc80f5b734e"), new Guid("1b6e43d2-3000-41ef-9aa8-24a5bb961f4c"), "ACCEPTED" },
                    { new Guid("8bb3ec1e-07e9-4bad-ab1f-15691b291e9d"), new Guid("1b6e43d2-3000-41ef-9aa8-24a5bb961f4c"), "ACCEPTED" },
                    { new Guid("8bc1ae99-62b1-4c3b-936a-ed89898adceb"), new Guid("1b6e43d2-3000-41ef-9aa8-24a5bb961f4c"), "ACCEPTED" },
                    { new Guid("9b419875-e449-4d74-9dd7-7c9630374799"), new Guid("1b6e43d2-3000-41ef-9aa8-24a5bb961f4c"), "ACCEPTED" },
                    { new Guid("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3"), new Guid("1b6e43d2-3000-41ef-9aa8-24a5bb961f4c"), "ACCEPTED" },
                    { new Guid("c9772f81-2145-4338-ad2d-9504b4b3dc6a"), new Guid("1b6e43d2-3000-41ef-9aa8-24a5bb961f4c"), "ACCEPTED" },
                    { new Guid("de1565eb-061b-4ffe-a1af-63a370bebaa7"), new Guid("1b6e43d2-3000-41ef-9aa8-24a5bb961f4c"), "REJECTED" },
                    { new Guid("ebcc0f14-937b-4c82-a021-5ff55809dec3"), new Guid("1b6e43d2-3000-41ef-9aa8-24a5bb961f4c"), "ACCEPTED" },
                    { new Guid("fc029e14-d132-4bf3-a958-490d18320df7"), new Guid("1b6e43d2-3000-41ef-9aa8-24a5bb961f4c"), "ACCEPTED" },
                    { new Guid("1b6e43d2-3000-41ef-9aa8-24a5bb961f4c"), new Guid("1b854f16-2261-42b1-a614-5f9106a03b63"), "ACCEPTED" },
                    { new Guid("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983"), new Guid("1b854f16-2261-42b1-a614-5f9106a03b63"), "ACCEPTED" },
                    { new Guid("57692189-acbb-4aa2-b2c9-6a5291e611af"), new Guid("1b854f16-2261-42b1-a614-5f9106a03b63"), "ACCEPTED" },
                    { new Guid("70693fa5-9180-4f05-854d-5d86aa286535"), new Guid("1b854f16-2261-42b1-a614-5f9106a03b63"), "ACCEPTED" },
                    { new Guid("81e75865-2b69-4440-af1d-bcbd2817abbe"), new Guid("1b854f16-2261-42b1-a614-5f9106a03b63"), "ACCEPTED" },
                    { new Guid("85fd205e-86a0-419b-8d59-7dc80f5b734e"), new Guid("1b854f16-2261-42b1-a614-5f9106a03b63"), "ACCEPTED" },
                    { new Guid("8bb3ec1e-07e9-4bad-ab1f-15691b291e9d"), new Guid("1b854f16-2261-42b1-a614-5f9106a03b63"), "ACCEPTED" },
                    { new Guid("8bc1ae99-62b1-4c3b-936a-ed89898adceb"), new Guid("1b854f16-2261-42b1-a614-5f9106a03b63"), "ACCEPTED" },
                    { new Guid("9b419875-e449-4d74-9dd7-7c9630374799"), new Guid("1b854f16-2261-42b1-a614-5f9106a03b63"), "ACCEPTED" },
                    { new Guid("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3"), new Guid("1b854f16-2261-42b1-a614-5f9106a03b63"), "REJECTED" },
                    { new Guid("c9772f81-2145-4338-ad2d-9504b4b3dc6a"), new Guid("1b854f16-2261-42b1-a614-5f9106a03b63"), "ACCEPTED" },
                    { new Guid("de1565eb-061b-4ffe-a1af-63a370bebaa7"), new Guid("1b854f16-2261-42b1-a614-5f9106a03b63"), "ACCEPTED" },
                    { new Guid("ebcc0f14-937b-4c82-a021-5ff55809dec3"), new Guid("1b854f16-2261-42b1-a614-5f9106a03b63"), "ACCEPTED" },
                    { new Guid("fc029e14-d132-4bf3-a958-490d18320df7"), new Guid("1b854f16-2261-42b1-a614-5f9106a03b63"), "PENDING" },
                    { new Guid("1b6e43d2-3000-41ef-9aa8-24a5bb961f4c"), new Guid("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983"), "ACCEPTED" },
                    { new Guid("1b854f16-2261-42b1-a614-5f9106a03b63"), new Guid("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983"), "REJECTED" },
                    { new Guid("57692189-acbb-4aa2-b2c9-6a5291e611af"), new Guid("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983"), "ACCEPTED" },
                    { new Guid("70693fa5-9180-4f05-854d-5d86aa286535"), new Guid("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983"), "ACCEPTED" },
                    { new Guid("81e75865-2b69-4440-af1d-bcbd2817abbe"), new Guid("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983"), "ACCEPTED" },
                    { new Guid("85fd205e-86a0-419b-8d59-7dc80f5b734e"), new Guid("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983"), "ACCEPTED" },
                    { new Guid("8bb3ec1e-07e9-4bad-ab1f-15691b291e9d"), new Guid("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983"), "ACCEPTED" },
                    { new Guid("8bc1ae99-62b1-4c3b-936a-ed89898adceb"), new Guid("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983"), "ACCEPTED" },
                    { new Guid("9b419875-e449-4d74-9dd7-7c9630374799"), new Guid("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983"), "REJECTED" },
                    { new Guid("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3"), new Guid("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983"), "ACCEPTED" },
                    { new Guid("c9772f81-2145-4338-ad2d-9504b4b3dc6a"), new Guid("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983"), "ACCEPTED" },
                    { new Guid("de1565eb-061b-4ffe-a1af-63a370bebaa7"), new Guid("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983"), "ACCEPTED" },
                    { new Guid("ebcc0f14-937b-4c82-a021-5ff55809dec3"), new Guid("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983"), "ACCEPTED" },
                    { new Guid("fc029e14-d132-4bf3-a958-490d18320df7"), new Guid("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983"), "PENDING" },
                    { new Guid("1b6e43d2-3000-41ef-9aa8-24a5bb961f4c"), new Guid("57692189-acbb-4aa2-b2c9-6a5291e611af"), "ACCEPTED" },
                    { new Guid("1b854f16-2261-42b1-a614-5f9106a03b63"), new Guid("57692189-acbb-4aa2-b2c9-6a5291e611af"), "REJECTED" },
                    { new Guid("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983"), new Guid("57692189-acbb-4aa2-b2c9-6a5291e611af"), "ACCEPTED" },
                    { new Guid("70693fa5-9180-4f05-854d-5d86aa286535"), new Guid("57692189-acbb-4aa2-b2c9-6a5291e611af"), "ACCEPTED" },
                    { new Guid("81e75865-2b69-4440-af1d-bcbd2817abbe"), new Guid("57692189-acbb-4aa2-b2c9-6a5291e611af"), "ACCEPTED" },
                    { new Guid("85fd205e-86a0-419b-8d59-7dc80f5b734e"), new Guid("57692189-acbb-4aa2-b2c9-6a5291e611af"), "ACCEPTED" },
                    { new Guid("8bb3ec1e-07e9-4bad-ab1f-15691b291e9d"), new Guid("57692189-acbb-4aa2-b2c9-6a5291e611af"), "ACCEPTED" },
                    { new Guid("8bc1ae99-62b1-4c3b-936a-ed89898adceb"), new Guid("57692189-acbb-4aa2-b2c9-6a5291e611af"), "PENDING" },
                    { new Guid("9b419875-e449-4d74-9dd7-7c9630374799"), new Guid("57692189-acbb-4aa2-b2c9-6a5291e611af"), "ACCEPTED" },
                    { new Guid("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3"), new Guid("57692189-acbb-4aa2-b2c9-6a5291e611af"), "PENDING" },
                    { new Guid("c9772f81-2145-4338-ad2d-9504b4b3dc6a"), new Guid("57692189-acbb-4aa2-b2c9-6a5291e611af"), "ACCEPTED" },
                    { new Guid("de1565eb-061b-4ffe-a1af-63a370bebaa7"), new Guid("57692189-acbb-4aa2-b2c9-6a5291e611af"), "ACCEPTED" },
                    { new Guid("ebcc0f14-937b-4c82-a021-5ff55809dec3"), new Guid("57692189-acbb-4aa2-b2c9-6a5291e611af"), "ACCEPTED" },
                    { new Guid("fc029e14-d132-4bf3-a958-490d18320df7"), new Guid("57692189-acbb-4aa2-b2c9-6a5291e611af"), "ACCEPTED" },
                    { new Guid("1b6e43d2-3000-41ef-9aa8-24a5bb961f4c"), new Guid("70693fa5-9180-4f05-854d-5d86aa286535"), "ACCEPTED" },
                    { new Guid("1b854f16-2261-42b1-a614-5f9106a03b63"), new Guid("70693fa5-9180-4f05-854d-5d86aa286535"), "ACCEPTED" },
                    { new Guid("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983"), new Guid("70693fa5-9180-4f05-854d-5d86aa286535"), "ACCEPTED" },
                    { new Guid("57692189-acbb-4aa2-b2c9-6a5291e611af"), new Guid("70693fa5-9180-4f05-854d-5d86aa286535"), "ACCEPTED" },
                    { new Guid("81e75865-2b69-4440-af1d-bcbd2817abbe"), new Guid("70693fa5-9180-4f05-854d-5d86aa286535"), "ACCEPTED" },
                    { new Guid("85fd205e-86a0-419b-8d59-7dc80f5b734e"), new Guid("70693fa5-9180-4f05-854d-5d86aa286535"), "ACCEPTED" },
                    { new Guid("8bb3ec1e-07e9-4bad-ab1f-15691b291e9d"), new Guid("70693fa5-9180-4f05-854d-5d86aa286535"), "ACCEPTED" },
                    { new Guid("8bc1ae99-62b1-4c3b-936a-ed89898adceb"), new Guid("70693fa5-9180-4f05-854d-5d86aa286535"), "ACCEPTED" },
                    { new Guid("9b419875-e449-4d74-9dd7-7c9630374799"), new Guid("70693fa5-9180-4f05-854d-5d86aa286535"), "PENDING" },
                    { new Guid("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3"), new Guid("70693fa5-9180-4f05-854d-5d86aa286535"), "ACCEPTED" },
                    { new Guid("c9772f81-2145-4338-ad2d-9504b4b3dc6a"), new Guid("70693fa5-9180-4f05-854d-5d86aa286535"), "ACCEPTED" },
                    { new Guid("de1565eb-061b-4ffe-a1af-63a370bebaa7"), new Guid("70693fa5-9180-4f05-854d-5d86aa286535"), "PENDING" },
                    { new Guid("ebcc0f14-937b-4c82-a021-5ff55809dec3"), new Guid("70693fa5-9180-4f05-854d-5d86aa286535"), "ACCEPTED" },
                    { new Guid("fc029e14-d132-4bf3-a958-490d18320df7"), new Guid("70693fa5-9180-4f05-854d-5d86aa286535"), "ACCEPTED" },
                    { new Guid("1b6e43d2-3000-41ef-9aa8-24a5bb961f4c"), new Guid("81e75865-2b69-4440-af1d-bcbd2817abbe"), "ACCEPTED" },
                    { new Guid("1b854f16-2261-42b1-a614-5f9106a03b63"), new Guid("81e75865-2b69-4440-af1d-bcbd2817abbe"), "ACCEPTED" },
                    { new Guid("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983"), new Guid("81e75865-2b69-4440-af1d-bcbd2817abbe"), "ACCEPTED" },
                    { new Guid("57692189-acbb-4aa2-b2c9-6a5291e611af"), new Guid("81e75865-2b69-4440-af1d-bcbd2817abbe"), "REJECTED" },
                    { new Guid("70693fa5-9180-4f05-854d-5d86aa286535"), new Guid("81e75865-2b69-4440-af1d-bcbd2817abbe"), "ACCEPTED" },
                    { new Guid("85fd205e-86a0-419b-8d59-7dc80f5b734e"), new Guid("81e75865-2b69-4440-af1d-bcbd2817abbe"), "PENDING" },
                    { new Guid("8bb3ec1e-07e9-4bad-ab1f-15691b291e9d"), new Guid("81e75865-2b69-4440-af1d-bcbd2817abbe"), "ACCEPTED" },
                    { new Guid("8bc1ae99-62b1-4c3b-936a-ed89898adceb"), new Guid("81e75865-2b69-4440-af1d-bcbd2817abbe"), "ACCEPTED" },
                    { new Guid("9b419875-e449-4d74-9dd7-7c9630374799"), new Guid("81e75865-2b69-4440-af1d-bcbd2817abbe"), "ACCEPTED" },
                    { new Guid("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3"), new Guid("81e75865-2b69-4440-af1d-bcbd2817abbe"), "PENDING" },
                    { new Guid("c9772f81-2145-4338-ad2d-9504b4b3dc6a"), new Guid("81e75865-2b69-4440-af1d-bcbd2817abbe"), "ACCEPTED" },
                    { new Guid("de1565eb-061b-4ffe-a1af-63a370bebaa7"), new Guid("81e75865-2b69-4440-af1d-bcbd2817abbe"), "ACCEPTED" },
                    { new Guid("ebcc0f14-937b-4c82-a021-5ff55809dec3"), new Guid("81e75865-2b69-4440-af1d-bcbd2817abbe"), "PENDING" },
                    { new Guid("fc029e14-d132-4bf3-a958-490d18320df7"), new Guid("81e75865-2b69-4440-af1d-bcbd2817abbe"), "ACCEPTED" },
                    { new Guid("1b6e43d2-3000-41ef-9aa8-24a5bb961f4c"), new Guid("8bb3ec1e-07e9-4bad-ab1f-15691b291e9d"), "ACCEPTED" },
                    { new Guid("1b854f16-2261-42b1-a614-5f9106a03b63"), new Guid("8bb3ec1e-07e9-4bad-ab1f-15691b291e9d"), "ACCEPTED" },
                    { new Guid("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983"), new Guid("8bb3ec1e-07e9-4bad-ab1f-15691b291e9d"), "ACCEPTED" },
                    { new Guid("57692189-acbb-4aa2-b2c9-6a5291e611af"), new Guid("8bb3ec1e-07e9-4bad-ab1f-15691b291e9d"), "REJECTED" },
                    { new Guid("70693fa5-9180-4f05-854d-5d86aa286535"), new Guid("8bb3ec1e-07e9-4bad-ab1f-15691b291e9d"), "ACCEPTED" },
                    { new Guid("81e75865-2b69-4440-af1d-bcbd2817abbe"), new Guid("8bb3ec1e-07e9-4bad-ab1f-15691b291e9d"), "ACCEPTED" },
                    { new Guid("85fd205e-86a0-419b-8d59-7dc80f5b734e"), new Guid("8bb3ec1e-07e9-4bad-ab1f-15691b291e9d"), "ACCEPTED" },
                    { new Guid("8bc1ae99-62b1-4c3b-936a-ed89898adceb"), new Guid("8bb3ec1e-07e9-4bad-ab1f-15691b291e9d"), "ACCEPTED" },
                    { new Guid("9b419875-e449-4d74-9dd7-7c9630374799"), new Guid("8bb3ec1e-07e9-4bad-ab1f-15691b291e9d"), "ACCEPTED" },
                    { new Guid("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3"), new Guid("8bb3ec1e-07e9-4bad-ab1f-15691b291e9d"), "ACCEPTED" },
                    { new Guid("c9772f81-2145-4338-ad2d-9504b4b3dc6a"), new Guid("8bb3ec1e-07e9-4bad-ab1f-15691b291e9d"), "ACCEPTED" },
                    { new Guid("de1565eb-061b-4ffe-a1af-63a370bebaa7"), new Guid("8bb3ec1e-07e9-4bad-ab1f-15691b291e9d"), "ACCEPTED" },
                    { new Guid("ebcc0f14-937b-4c82-a021-5ff55809dec3"), new Guid("8bb3ec1e-07e9-4bad-ab1f-15691b291e9d"), "ACCEPTED" },
                    { new Guid("fc029e14-d132-4bf3-a958-490d18320df7"), new Guid("8bb3ec1e-07e9-4bad-ab1f-15691b291e9d"), "PENDING" },
                    { new Guid("1b6e43d2-3000-41ef-9aa8-24a5bb961f4c"), new Guid("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3"), "ACCEPTED" },
                    { new Guid("1b854f16-2261-42b1-a614-5f9106a03b63"), new Guid("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3"), "ACCEPTED" },
                    { new Guid("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983"), new Guid("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3"), "ACCEPTED" },
                    { new Guid("57692189-acbb-4aa2-b2c9-6a5291e611af"), new Guid("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3"), "ACCEPTED" },
                    { new Guid("70693fa5-9180-4f05-854d-5d86aa286535"), new Guid("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3"), "ACCEPTED" },
                    { new Guid("81e75865-2b69-4440-af1d-bcbd2817abbe"), new Guid("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3"), "REJECTED" },
                    { new Guid("85fd205e-86a0-419b-8d59-7dc80f5b734e"), new Guid("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3"), "ACCEPTED" },
                    { new Guid("8bb3ec1e-07e9-4bad-ab1f-15691b291e9d"), new Guid("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3"), "ACCEPTED" },
                    { new Guid("8bc1ae99-62b1-4c3b-936a-ed89898adceb"), new Guid("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3"), "ACCEPTED" },
                    { new Guid("9b419875-e449-4d74-9dd7-7c9630374799"), new Guid("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3"), "REJECTED" },
                    { new Guid("c9772f81-2145-4338-ad2d-9504b4b3dc6a"), new Guid("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3"), "PENDING" },
                    { new Guid("de1565eb-061b-4ffe-a1af-63a370bebaa7"), new Guid("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3"), "ACCEPTED" },
                    { new Guid("ebcc0f14-937b-4c82-a021-5ff55809dec3"), new Guid("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3"), "ACCEPTED" },
                    { new Guid("fc029e14-d132-4bf3-a958-490d18320df7"), new Guid("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3"), "ACCEPTED" },
                    { new Guid("1b6e43d2-3000-41ef-9aa8-24a5bb961f4c"), new Guid("c9772f81-2145-4338-ad2d-9504b4b3dc6a"), "ACCEPTED" },
                    { new Guid("1b854f16-2261-42b1-a614-5f9106a03b63"), new Guid("c9772f81-2145-4338-ad2d-9504b4b3dc6a"), "REJECTED" },
                    { new Guid("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983"), new Guid("c9772f81-2145-4338-ad2d-9504b4b3dc6a"), "ACCEPTED" },
                    { new Guid("57692189-acbb-4aa2-b2c9-6a5291e611af"), new Guid("c9772f81-2145-4338-ad2d-9504b4b3dc6a"), "ACCEPTED" },
                    { new Guid("70693fa5-9180-4f05-854d-5d86aa286535"), new Guid("c9772f81-2145-4338-ad2d-9504b4b3dc6a"), "ACCEPTED" },
                    { new Guid("81e75865-2b69-4440-af1d-bcbd2817abbe"), new Guid("c9772f81-2145-4338-ad2d-9504b4b3dc6a"), "ACCEPTED" },
                    { new Guid("85fd205e-86a0-419b-8d59-7dc80f5b734e"), new Guid("c9772f81-2145-4338-ad2d-9504b4b3dc6a"), "ACCEPTED" },
                    { new Guid("8bb3ec1e-07e9-4bad-ab1f-15691b291e9d"), new Guid("c9772f81-2145-4338-ad2d-9504b4b3dc6a"), "PENDING" },
                    { new Guid("8bc1ae99-62b1-4c3b-936a-ed89898adceb"), new Guid("c9772f81-2145-4338-ad2d-9504b4b3dc6a"), "ACCEPTED" },
                    { new Guid("9b419875-e449-4d74-9dd7-7c9630374799"), new Guid("c9772f81-2145-4338-ad2d-9504b4b3dc6a"), "ACCEPTED" },
                    { new Guid("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3"), new Guid("c9772f81-2145-4338-ad2d-9504b4b3dc6a"), "ACCEPTED" },
                    { new Guid("de1565eb-061b-4ffe-a1af-63a370bebaa7"), new Guid("c9772f81-2145-4338-ad2d-9504b4b3dc6a"), "ACCEPTED" },
                    { new Guid("ebcc0f14-937b-4c82-a021-5ff55809dec3"), new Guid("c9772f81-2145-4338-ad2d-9504b4b3dc6a"), "ACCEPTED" },
                    { new Guid("fc029e14-d132-4bf3-a958-490d18320df7"), new Guid("c9772f81-2145-4338-ad2d-9504b4b3dc6a"), "ACCEPTED" },
                    { new Guid("1b6e43d2-3000-41ef-9aa8-24a5bb961f4c"), new Guid("de1565eb-061b-4ffe-a1af-63a370bebaa7"), "ACCEPTED" },
                    { new Guid("1b854f16-2261-42b1-a614-5f9106a03b63"), new Guid("de1565eb-061b-4ffe-a1af-63a370bebaa7"), "REJECTED" },
                    { new Guid("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983"), new Guid("de1565eb-061b-4ffe-a1af-63a370bebaa7"), "PENDING" },
                    { new Guid("57692189-acbb-4aa2-b2c9-6a5291e611af"), new Guid("de1565eb-061b-4ffe-a1af-63a370bebaa7"), "ACCEPTED" },
                    { new Guid("70693fa5-9180-4f05-854d-5d86aa286535"), new Guid("de1565eb-061b-4ffe-a1af-63a370bebaa7"), "ACCEPTED" },
                    { new Guid("81e75865-2b69-4440-af1d-bcbd2817abbe"), new Guid("de1565eb-061b-4ffe-a1af-63a370bebaa7"), "ACCEPTED" },
                    { new Guid("85fd205e-86a0-419b-8d59-7dc80f5b734e"), new Guid("de1565eb-061b-4ffe-a1af-63a370bebaa7"), "ACCEPTED" },
                    { new Guid("8bb3ec1e-07e9-4bad-ab1f-15691b291e9d"), new Guid("de1565eb-061b-4ffe-a1af-63a370bebaa7"), "ACCEPTED" },
                    { new Guid("8bc1ae99-62b1-4c3b-936a-ed89898adceb"), new Guid("de1565eb-061b-4ffe-a1af-63a370bebaa7"), "PENDING" },
                    { new Guid("9b419875-e449-4d74-9dd7-7c9630374799"), new Guid("de1565eb-061b-4ffe-a1af-63a370bebaa7"), "ACCEPTED" },
                    { new Guid("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3"), new Guid("de1565eb-061b-4ffe-a1af-63a370bebaa7"), "ACCEPTED" },
                    { new Guid("c9772f81-2145-4338-ad2d-9504b4b3dc6a"), new Guid("de1565eb-061b-4ffe-a1af-63a370bebaa7"), "ACCEPTED" },
                    { new Guid("ebcc0f14-937b-4c82-a021-5ff55809dec3"), new Guid("de1565eb-061b-4ffe-a1af-63a370bebaa7"), "ACCEPTED" },
                    { new Guid("fc029e14-d132-4bf3-a958-490d18320df7"), new Guid("de1565eb-061b-4ffe-a1af-63a370bebaa7"), "ACCEPTED" },
                    { new Guid("1b6e43d2-3000-41ef-9aa8-24a5bb961f4c"), new Guid("ebcc0f14-937b-4c82-a021-5ff55809dec3"), "ACCEPTED" },
                    { new Guid("1b854f16-2261-42b1-a614-5f9106a03b63"), new Guid("ebcc0f14-937b-4c82-a021-5ff55809dec3"), "ACCEPTED" },
                    { new Guid("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983"), new Guid("ebcc0f14-937b-4c82-a021-5ff55809dec3"), "ACCEPTED" },
                    { new Guid("57692189-acbb-4aa2-b2c9-6a5291e611af"), new Guid("ebcc0f14-937b-4c82-a021-5ff55809dec3"), "ACCEPTED" },
                    { new Guid("70693fa5-9180-4f05-854d-5d86aa286535"), new Guid("ebcc0f14-937b-4c82-a021-5ff55809dec3"), "PENDING" },
                    { new Guid("81e75865-2b69-4440-af1d-bcbd2817abbe"), new Guid("ebcc0f14-937b-4c82-a021-5ff55809dec3"), "ACCEPTED" },
                    { new Guid("85fd205e-86a0-419b-8d59-7dc80f5b734e"), new Guid("ebcc0f14-937b-4c82-a021-5ff55809dec3"), "ACCEPTED" },
                    { new Guid("8bb3ec1e-07e9-4bad-ab1f-15691b291e9d"), new Guid("ebcc0f14-937b-4c82-a021-5ff55809dec3"), "ACCEPTED" },
                    { new Guid("8bc1ae99-62b1-4c3b-936a-ed89898adceb"), new Guid("ebcc0f14-937b-4c82-a021-5ff55809dec3"), "ACCEPTED" },
                    { new Guid("9b419875-e449-4d74-9dd7-7c9630374799"), new Guid("ebcc0f14-937b-4c82-a021-5ff55809dec3"), "ACCEPTED" },
                    { new Guid("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3"), new Guid("ebcc0f14-937b-4c82-a021-5ff55809dec3"), "ACCEPTED" },
                    { new Guid("c9772f81-2145-4338-ad2d-9504b4b3dc6a"), new Guid("ebcc0f14-937b-4c82-a021-5ff55809dec3"), "REJECTED" },
                    { new Guid("de1565eb-061b-4ffe-a1af-63a370bebaa7"), new Guid("ebcc0f14-937b-4c82-a021-5ff55809dec3"), "ACCEPTED" },
                    { new Guid("fc029e14-d132-4bf3-a958-490d18320df7"), new Guid("ebcc0f14-937b-4c82-a021-5ff55809dec3"), "ACCEPTED" },
                    { new Guid("1b6e43d2-3000-41ef-9aa8-24a5bb961f4c"), new Guid("fc029e14-d132-4bf3-a958-490d18320df7"), "REJECTED" },
                    { new Guid("1b854f16-2261-42b1-a614-5f9106a03b63"), new Guid("fc029e14-d132-4bf3-a958-490d18320df7"), "PENDING" },
                    { new Guid("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983"), new Guid("fc029e14-d132-4bf3-a958-490d18320df7"), "ACCEPTED" },
                    { new Guid("57692189-acbb-4aa2-b2c9-6a5291e611af"), new Guid("fc029e14-d132-4bf3-a958-490d18320df7"), "ACCEPTED" },
                    { new Guid("70693fa5-9180-4f05-854d-5d86aa286535"), new Guid("fc029e14-d132-4bf3-a958-490d18320df7"), "ACCEPTED" },
                    { new Guid("81e75865-2b69-4440-af1d-bcbd2817abbe"), new Guid("fc029e14-d132-4bf3-a958-490d18320df7"), "ACCEPTED" },
                    { new Guid("85fd205e-86a0-419b-8d59-7dc80f5b734e"), new Guid("fc029e14-d132-4bf3-a958-490d18320df7"), "ACCEPTED" },
                    { new Guid("8bb3ec1e-07e9-4bad-ab1f-15691b291e9d"), new Guid("fc029e14-d132-4bf3-a958-490d18320df7"), "ACCEPTED" },
                    { new Guid("8bc1ae99-62b1-4c3b-936a-ed89898adceb"), new Guid("fc029e14-d132-4bf3-a958-490d18320df7"), "ACCEPTED" },
                    { new Guid("9b419875-e449-4d74-9dd7-7c9630374799"), new Guid("fc029e14-d132-4bf3-a958-490d18320df7"), "ACCEPTED" },
                    { new Guid("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3"), new Guid("fc029e14-d132-4bf3-a958-490d18320df7"), "ACCEPTED" },
                    { new Guid("c9772f81-2145-4338-ad2d-9504b4b3dc6a"), new Guid("fc029e14-d132-4bf3-a958-490d18320df7"), "ACCEPTED" },
                    { new Guid("de1565eb-061b-4ffe-a1af-63a370bebaa7"), new Guid("fc029e14-d132-4bf3-a958-490d18320df7"), "ACCEPTED" },
                    { new Guid("ebcc0f14-937b-4c82-a021-5ff55809dec3"), new Guid("fc029e14-d132-4bf3-a958-490d18320df7"), "ACCEPTED" }
                });

            migrationBuilder.InsertData(
                table: "Voice_recordings",
                columns: new[] { "Voice_recording_id", "Audio_data_path", "Name", "Owner_user_id", "Upload_data_time" },
                values: new object[,]
                {
                    { new Guid("059df751-ae7f-4e2e-9fad-8994ffb19cfd"), "epic-glitch-hit-logo-142960.mp3", "epic-glitch-hit-logo", new Guid("ebcc0f14-937b-4c82-a021-5ff55809dec3"), new DateTime(2024, 1, 2, 18, 20, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0cbf9c89-d97c-4f3d-a063-570d16f47808"), "crystal-logo-21091.mp3", "crystal-logo", new Guid("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3"), new DateTime(2024, 1, 1, 18, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("12195f99-9979-482a-ae86-c95b4165e221"), "finger-snap-179180.mp3", "finger-snap", new Guid("de1565eb-061b-4ffe-a1af-63a370bebaa7"), new DateTime(2024, 1, 3, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("131f8219-eccf-46ff-9bcf-bab4af4ca13e"), "record_scratch-108233.mp3", "record_scratch", new Guid("8bc1ae99-62b1-4c3b-936a-ed89898adceb"), new DateTime(2024, 1, 7, 14, 44, 10, 0, DateTimeKind.Unspecified) },
                    { new Guid("201545bc-8c7e-413a-8f9e-03a804370032"), "stingers-001-6294.mp3", "stingers-001-629", new Guid("b2a250cb-9279-4c0a-b6ac-262e4d43225e"), new DateTime(2024, 1, 11, 9, 58, 34, 0, DateTimeKind.Unspecified) },
                    { new Guid("27a642cc-f02d-4cc1-870e-8986eb8be384"), "simple-hi-tech-logo-13774.mp3", "simple-hi-tech-logo", new Guid("99ba6920-55ac-4657-8712-c7241f23c9bf"), new DateTime(2024, 1, 9, 21, 50, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2debf88b-ed60-4aca-83af-c1ae01a574e0"), "beautiful-piano-logo-143488.mp3", "beautiful-piano-logo", new Guid("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983"), new DateTime(2024, 1, 1, 16, 30, 10, 0, DateTimeKind.Unspecified) },
                    { new Guid("38aad1d5-c710-4be2-b478-2e5a27ad0a3b"), "modern-tech-logo-13492.mp3", "modern-tech-logo", new Guid("57692189-acbb-4aa2-b2c9-6a5291e611af"), new DateTime(2024, 1, 7, 12, 11, 20, 0, DateTimeKind.Unspecified) },
                    { new Guid("4114451e-08f6-4dd3-a22c-bf0a43b11b7c"), "short-whoosh-13x-14526.mp3", "short-whoosh-13x", new Guid("e22141d8-f3ce-49db-bcf9-cdd1961b48b5"), new DateTime(2024, 1, 9, 19, 23, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("454d5e28-f151-474e-bb08-1f2e89af65f3"), "suspense-intro-21472.mp3", "suspense-intro", new Guid("a7958e4c-1912-49c2-bc24-563f7a2c8d8c"), new DateTime(2024, 1, 11, 16, 53, 50, 0, DateTimeKind.Unspecified) },
                    { new Guid("4a207e32-be67-4f41-94c0-68b9d94aaf32"), "simple-clean-logo-13775.mp3", "simple-clean-logo", new Guid("e22141d8-f3ce-49db-bcf9-cdd1961b48b5"), new DateTime(2024, 1, 9, 20, 24, 44, 0, DateTimeKind.Unspecified) },
                    { new Guid("4ade1e67-4124-4c67-98be-74c5892b0929"), "teddy-short-comedy-audio-logo-happy-cartoony-intro-outro-music-145155.mp3", "teddy-short-comedy-audio-logo-happy-cartoony-intro-outro-music", new Guid("8cbc3199-5acc-4e26-8e4b-3e84c563dfca"), new DateTime(2024, 1, 12, 9, 41, 5, 0, DateTimeKind.Unspecified) },
                    { new Guid("535536bc-716f-47cf-82e5-6e8b281ea20f"), "summer-night-piano-solo-6885.mp3", "summer-night-piano-solo", new Guid("a7958e4c-1912-49c2-bc24-563f7a2c8d8c"), new DateTime(2024, 1, 11, 12, 22, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5fea97fc-c769-4ec5-84ed-ed427739267e"), "war-horn-blast-14760.mp3", "war-horn-blast", new Guid("cd61d42e-6981-480e-aaf5-4869d78b9b81"), new DateTime(2024, 1, 12, 13, 1, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6f9327c5-abe2-4407-85ff-cb77b5467f40"), "intro-music-black-box-brand-jingle-13222.mp3", "intro-music-black-box-brand-jingle", new Guid("57692189-acbb-4aa2-b2c9-6a5291e611af"), new DateTime(2024, 1, 6, 20, 20, 20, 0, DateTimeKind.Unspecified) },
                    { new Guid("72c94129-2cfb-47a7-9c94-4ff094671e14"), "reverse-logo-143857.mp3", "reverse-logo", new Guid("85fd205e-86a0-419b-8d59-7dc80f5b734e"), new DateTime(2024, 1, 7, 15, 12, 10, 0, DateTimeKind.Unspecified) },
                    { new Guid("7b6c81ba-aa1f-468d-8669-980fba398f2f"), "acoustic-guitar-short-intro-ish-live-recording-163329.mp3", "acoustic-guitar-short-intro-ish-live-recording", new Guid("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983"), new DateTime(2024, 1, 1, 16, 20, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("838a0d7a-4777-4999-b0ca-798962218c82"), "sport-rock-logo1-13776.mp3", "sport-rock-logo1-13", new Guid("213c170b-0b1c-499f-8e18-d35e5a7707ff"), new DateTime(2024, 1, 10, 23, 59, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8caee912-d7aa-4e63-80ec-63fc4d05f5e2"), "dramatic-reveal-21469.mp3", "dramatic-reveal", new Guid("ebcc0f14-937b-4c82-a021-5ff55809dec3"), new DateTime(2024, 1, 2, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8dac7bfa-1112-4744-85bc-db41d39399c2"), "suspense-sting-14028.mp3", "suspense-sting", new Guid("a7958e4c-1912-49c2-bc24-563f7a2c8d8c"), new DateTime(2024, 1, 11, 18, 42, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("94e1a1dc-70f6-4221-8e2c-853a7ca3ec36"), "christmas-ident-21090.mp3", "christmas-ident", new Guid("81e75865-2b69-4440-af1d-bcbd2817abbe"), new DateTime(2024, 1, 1, 16, 40, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9723d8f3-83cd-45c2-883b-d4f439bb9c10"), "038777_cinematic-sound-effect-for-short-film-previews-61011.mp3", "cinematic-sound-effect-for-short-film-previews", new Guid("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983"), new DateTime(2024, 1, 1, 16, 10, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9a231f48-4e1a-4bfb-bfbf-11b374bd1e53"), "click_effect-86995.mp3", "click_effect-86", new Guid("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3"), new DateTime(2024, 1, 1, 17, 20, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a70f4451-eaa1-456a-803b-428f3636ad08"), "christmas-vibes-windy-whoosh-magical-chimes-180863.mp3", "christmas-vibes-windy-whoosh-magical-chimes", new Guid("81e75865-2b69-4440-af1d-bcbd2817abbe"), new DateTime(2024, 1, 1, 16, 50, 20, 0, DateTimeKind.Unspecified) },
                    { new Guid("b2f9023f-6c16-43e8-a750-742e40885bb7"), "heroic-intro-21468.mp3", "heroic-intro", new Guid("c9772f81-2145-4338-ad2d-9504b4b3dc6a"), new DateTime(2024, 1, 5, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ba5dfee8-5de5-4965-b482-e84b0a80027c"), "impact-piano-logo-108961.mp3", "impact-piano-logo", new Guid("8bb3ec1e-07e9-4bad-ab1f-15691b291e9d"), new DateTime(2024, 1, 6, 10, 10, 10, 0, DateTimeKind.Unspecified) },
                    { new Guid("bac347b3-aca6-4e14-acb7-c9c7e91a2ea6"), "dark-engine-logo-141942.mp3", "dark-engine-logo", new Guid("ebcc0f14-937b-4c82-a021-5ff55809dec3"), new DateTime(2024, 1, 2, 1, 0, 30, 0, DateTimeKind.Unspecified) },
                    { new Guid("c43bc3d1-c4f0-43c3-9ee0-ee9dc0dd8926"), "winter-holiday-logo-14033.mp3", "winter-holiday-logo", new Guid("cd61d42e-6981-480e-aaf5-4869d78b9b81"), new DateTime(2024, 1, 12, 10, 1, 5, 0, DateTimeKind.Unspecified) },
                    { new Guid("c4439bcb-9ab7-4f75-b1e7-146018d1672c"), "epic-hybrid-logo-157092.mp3", "epic-hybrid-logo", new Guid("1b6e43d2-3000-41ef-9aa8-24a5bb961f4c"), new DateTime(2024, 1, 3, 14, 0, 10, 0, DateTimeKind.Unspecified) },
                    { new Guid("c72017a9-74c3-41af-a435-e78143ca258c"), "tv-background-intro-14030.mp3", "tv-background-intro", new Guid("8cbc3199-5acc-4e26-8e4b-3e84c563dfca"), new DateTime(2024, 1, 12, 10, 2, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c89acb7c-f3b9-4401-99de-9d4b33cbe399"), "short-logo-108964.mp3", "short-logo", new Guid("cd61d42e-6981-480e-aaf5-4869d78b9b81"), new DateTime(2024, 1, 8, 17, 35, 12, 0, DateTimeKind.Unspecified) },
                    { new Guid("cc048a44-ab17-4314-8a65-4a7b8848bd3e"), "sound-1-167181.mp3", "sound-1-16", new Guid("8cbc3199-5acc-4e26-8e4b-3e84c563dfca"), new DateTime(2024, 1, 10, 22, 59, 23, 0, DateTimeKind.Unspecified) },
                    { new Guid("ce35d5c4-c88e-40d3-ac87-3a1f405207ae"), "stomp-logo-4-13784.mp3", "stomp-logo", new Guid("e41fa0bd-0a3e-45d6-89ec-b2c753a1ddb5"), new DateTime(2024, 1, 11, 10, 57, 12, 0, DateTimeKind.Unspecified) },
                    { new Guid("d75c9d95-82ab-410b-ae61-66e963366428"), "friendly-melody-14015.mp3", "friendly-melody", new Guid("fc029e14-d132-4bf3-a958-490d18320df7"), new DateTime(2024, 1, 4, 16, 40, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("db8789bd-cd24-405a-8efa-9443de243db6"), "short-crowd-cheer-6713.mp3", "short-crowd-cheer", new Guid("9b419875-e449-4d74-9dd7-7c9630374799"), new DateTime(2024, 1, 8, 16, 25, 10, 0, DateTimeKind.Unspecified) },
                    { new Guid("deddda20-f1f0-4e03-a80d-19061f1fbd90"), "short-success-sound-glockenspiel-treasure-video-game-6346.mp3", "short-success-sound-glockenspiel-treasure-video-game", new Guid("c8d49eba-1396-41f3-9414-8bfd2021b793"), new DateTime(2024, 1, 8, 18, 38, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ecbc94d1-ab61-4bab-a914-72ed2b7546ab"), "funny-laughing-sound-180125.mp3", "funny-laughing-sound", new Guid("1b854f16-2261-42b1-a614-5f9106a03b63"), new DateTime(2024, 1, 5, 12, 15, 15, 0, DateTimeKind.Unspecified) },
                    { new Guid("fc5ddfd3-2496-4dab-9a67-33fdb1fac662"), "click-button-140881.mp3", "click-button-140", new Guid("70693fa5-9180-4f05-854d-5d86aa286535"), new DateTime(2024, 1, 1, 17, 10, 30, 0, DateTimeKind.Unspecified) },
                    { new Guid("fd062277-2258-4c28-ace0-010fcb7c8146"), "positive-orchestral-jingle-21444.mp3", "positive-orchestral-jingle", new Guid("57692189-acbb-4aa2-b2c9-6a5291e611af"), new DateTime(2024, 1, 7, 13, 22, 40, 0, DateTimeKind.Unspecified) },
                    { new Guid("fe27c13d-6023-4d38-a12a-6154ef14a9b8"), "click-124467.mp3", "click-124467", new Guid("70693fa5-9180-4f05-854d-5d86aa286535"), new DateTime(2024, 1, 1, 17, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Chats_voice_recordings",
                columns: new[] { "Chat_id", "Voice_recording_id", "Date_of_added" },
                values: new object[,]
                {
                    { new Guid("3408c6f5-bcf0-467e-a068-b8b8bbb0689f"), new Guid("131f8219-eccf-46ff-9bcf-bab4af4ca13e"), new DateTime(2024, 1, 13, 12, 40, 30, 0, DateTimeKind.Unspecified) },
                    { new Guid("3408c6f5-bcf0-467e-a068-b8b8bbb0689f"), new Guid("201545bc-8c7e-413a-8f9e-03a804370032"), new DateTime(2024, 1, 13, 23, 37, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3408c6f5-bcf0-467e-a068-b8b8bbb0689f"), new Guid("27a642cc-f02d-4cc1-870e-8986eb8be384"), new DateTime(2024, 1, 13, 17, 23, 10, 0, DateTimeKind.Unspecified) },
                    { new Guid("3408c6f5-bcf0-467e-a068-b8b8bbb0689f"), new Guid("38aad1d5-c710-4be2-b478-2e5a27ad0a3b"), new DateTime(2024, 1, 13, 11, 20, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3408c6f5-bcf0-467e-a068-b8b8bbb0689f"), new Guid("4114451e-08f6-4dd3-a22c-bf0a43b11b7c"), new DateTime(2024, 1, 13, 14, 6, 20, 0, DateTimeKind.Unspecified) },
                    { new Guid("3408c6f5-bcf0-467e-a068-b8b8bbb0689f"), new Guid("4a207e32-be67-4f41-94c0-68b9d94aaf32"), new DateTime(2024, 1, 13, 15, 9, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3408c6f5-bcf0-467e-a068-b8b8bbb0689f"), new Guid("6f9327c5-abe2-4407-85ff-cb77b5467f40"), new DateTime(2024, 1, 13, 10, 30, 40, 0, DateTimeKind.Unspecified) },
                    { new Guid("3408c6f5-bcf0-467e-a068-b8b8bbb0689f"), new Guid("72c94129-2cfb-47a7-9c94-4ff094671e14"), new DateTime(2024, 1, 13, 12, 50, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3408c6f5-bcf0-467e-a068-b8b8bbb0689f"), new Guid("838a0d7a-4777-4999-b0ca-798962218c82"), new DateTime(2024, 1, 13, 20, 11, 5, 0, DateTimeKind.Unspecified) },
                    { new Guid("3408c6f5-bcf0-467e-a068-b8b8bbb0689f"), new Guid("b2f9023f-6c16-43e8-a750-742e40885bb7"), new DateTime(2024, 1, 13, 10, 15, 30, 0, DateTimeKind.Unspecified) },
                    { new Guid("3408c6f5-bcf0-467e-a068-b8b8bbb0689f"), new Guid("ba5dfee8-5de5-4965-b482-e84b0a80027c"), new DateTime(2024, 1, 13, 10, 20, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3408c6f5-bcf0-467e-a068-b8b8bbb0689f"), new Guid("c89acb7c-f3b9-4401-99de-9d4b33cbe399"), new DateTime(2024, 1, 13, 13, 1, 20, 0, DateTimeKind.Unspecified) },
                    { new Guid("3408c6f5-bcf0-467e-a068-b8b8bbb0689f"), new Guid("cc048a44-ab17-4314-8a65-4a7b8848bd3e"), new DateTime(2024, 1, 13, 19, 56, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3408c6f5-bcf0-467e-a068-b8b8bbb0689f"), new Guid("db8789bd-cd24-405a-8efa-9443de243db6"), new DateTime(2024, 1, 13, 12, 55, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3408c6f5-bcf0-467e-a068-b8b8bbb0689f"), new Guid("deddda20-f1f0-4e03-a80d-19061f1fbd90"), new DateTime(2024, 1, 13, 13, 3, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3408c6f5-bcf0-467e-a068-b8b8bbb0689f"), new Guid("fd062277-2258-4c28-ace0-010fcb7c8146"), new DateTime(2024, 1, 13, 11, 30, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4189917d-7073-405b-8c47-a391f23fa31b"), new Guid("0cbf9c89-d97c-4f3d-a063-570d16f47808"), new DateTime(2024, 1, 13, 10, 20, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4189917d-7073-405b-8c47-a391f23fa31b"), new Guid("131f8219-eccf-46ff-9bcf-bab4af4ca13e"), new DateTime(2024, 1, 13, 13, 1, 20, 0, DateTimeKind.Unspecified) },
                    { new Guid("4189917d-7073-405b-8c47-a391f23fa31b"), new Guid("201545bc-8c7e-413a-8f9e-03a804370032"), new DateTime(2024, 1, 13, 19, 56, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4189917d-7073-405b-8c47-a391f23fa31b"), new Guid("38aad1d5-c710-4be2-b478-2e5a27ad0a3b"), new DateTime(2024, 1, 13, 12, 55, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4189917d-7073-405b-8c47-a391f23fa31b"), new Guid("4a207e32-be67-4f41-94c0-68b9d94aaf32"), new DateTime(2024, 1, 13, 15, 9, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4189917d-7073-405b-8c47-a391f23fa31b"), new Guid("535536bc-716f-47cf-82e5-6e8b281ea20f"), new DateTime(2024, 1, 13, 20, 11, 5, 0, DateTimeKind.Unspecified) },
                    { new Guid("4189917d-7073-405b-8c47-a391f23fa31b"), new Guid("8caee912-d7aa-4e63-80ec-63fc4d05f5e2"), new DateTime(2024, 1, 13, 10, 30, 40, 0, DateTimeKind.Unspecified) },
                    { new Guid("4189917d-7073-405b-8c47-a391f23fa31b"), new Guid("8dac7bfa-1112-4744-85bc-db41d39399c2"), new DateTime(2024, 1, 13, 23, 37, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4189917d-7073-405b-8c47-a391f23fa31b"), new Guid("b2f9023f-6c16-43e8-a750-742e40885bb7"), new DateTime(2024, 1, 13, 12, 40, 30, 0, DateTimeKind.Unspecified) },
                    { new Guid("4189917d-7073-405b-8c47-a391f23fa31b"), new Guid("ba5dfee8-5de5-4965-b482-e84b0a80027c"), new DateTime(2024, 1, 13, 12, 50, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4189917d-7073-405b-8c47-a391f23fa31b"), new Guid("c4439bcb-9ab7-4f75-b1e7-146018d1672c"), new DateTime(2024, 1, 13, 11, 20, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4189917d-7073-405b-8c47-a391f23fa31b"), new Guid("cc048a44-ab17-4314-8a65-4a7b8848bd3e"), new DateTime(2024, 1, 13, 17, 23, 10, 0, DateTimeKind.Unspecified) },
                    { new Guid("4189917d-7073-405b-8c47-a391f23fa31b"), new Guid("d75c9d95-82ab-410b-ae61-66e963366428"), new DateTime(2024, 1, 13, 11, 30, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4189917d-7073-405b-8c47-a391f23fa31b"), new Guid("db8789bd-cd24-405a-8efa-9443de243db6"), new DateTime(2024, 1, 13, 13, 3, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4189917d-7073-405b-8c47-a391f23fa31b"), new Guid("deddda20-f1f0-4e03-a80d-19061f1fbd90"), new DateTime(2024, 1, 13, 14, 6, 20, 0, DateTimeKind.Unspecified) },
                    { new Guid("4189917d-7073-405b-8c47-a391f23fa31b"), new Guid("fc5ddfd3-2496-4dab-9a67-33fdb1fac662"), new DateTime(2024, 1, 13, 10, 15, 30, 0, DateTimeKind.Unspecified) },
                    { new Guid("7999d70a-1a31-428e-9078-3c392dc1f4a8"), new Guid("201545bc-8c7e-413a-8f9e-03a804370032"), new DateTime(2024, 1, 13, 13, 1, 20, 0, DateTimeKind.Unspecified) },
                    { new Guid("7999d70a-1a31-428e-9078-3c392dc1f4a8"), new Guid("27a642cc-f02d-4cc1-870e-8986eb8be384"), new DateTime(2024, 1, 13, 15, 9, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7999d70a-1a31-428e-9078-3c392dc1f4a8"), new Guid("4114451e-08f6-4dd3-a22c-bf0a43b11b7c"), new DateTime(2024, 1, 13, 19, 56, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7999d70a-1a31-428e-9078-3c392dc1f4a8"), new Guid("454d5e28-f151-474e-bb08-1f2e89af65f3"), new DateTime(2024, 1, 13, 12, 40, 30, 0, DateTimeKind.Unspecified) },
                    { new Guid("7999d70a-1a31-428e-9078-3c392dc1f4a8"), new Guid("4a207e32-be67-4f41-94c0-68b9d94aaf32"), new DateTime(2024, 1, 13, 17, 23, 10, 0, DateTimeKind.Unspecified) },
                    { new Guid("7999d70a-1a31-428e-9078-3c392dc1f4a8"), new Guid("4ade1e67-4124-4c67-98be-74c5892b0929"), new DateTime(2024, 1, 13, 11, 20, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7999d70a-1a31-428e-9078-3c392dc1f4a8"), new Guid("535536bc-716f-47cf-82e5-6e8b281ea20f"), new DateTime(2024, 1, 13, 12, 50, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7999d70a-1a31-428e-9078-3c392dc1f4a8"), new Guid("5fea97fc-c769-4ec5-84ed-ed427739267e"), new DateTime(2024, 1, 13, 10, 20, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7999d70a-1a31-428e-9078-3c392dc1f4a8"), new Guid("838a0d7a-4777-4999-b0ca-798962218c82"), new DateTime(2024, 1, 13, 13, 3, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7999d70a-1a31-428e-9078-3c392dc1f4a8"), new Guid("8dac7bfa-1112-4744-85bc-db41d39399c2"), new DateTime(2024, 1, 13, 11, 30, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7999d70a-1a31-428e-9078-3c392dc1f4a8"), new Guid("c43bc3d1-c4f0-43c3-9ee0-ee9dc0dd8926"), new DateTime(2024, 1, 13, 10, 15, 30, 0, DateTimeKind.Unspecified) },
                    { new Guid("7999d70a-1a31-428e-9078-3c392dc1f4a8"), new Guid("c72017a9-74c3-41af-a435-e78143ca258c"), new DateTime(2024, 1, 13, 10, 30, 40, 0, DateTimeKind.Unspecified) },
                    { new Guid("7999d70a-1a31-428e-9078-3c392dc1f4a8"), new Guid("c89acb7c-f3b9-4401-99de-9d4b33cbe399"), new DateTime(2024, 1, 13, 23, 37, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7999d70a-1a31-428e-9078-3c392dc1f4a8"), new Guid("cc048a44-ab17-4314-8a65-4a7b8848bd3e"), new DateTime(2024, 1, 13, 14, 6, 20, 0, DateTimeKind.Unspecified) },
                    { new Guid("7999d70a-1a31-428e-9078-3c392dc1f4a8"), new Guid("ce35d5c4-c88e-40d3-ac87-3a1f405207ae"), new DateTime(2024, 1, 13, 12, 55, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7999d70a-1a31-428e-9078-3c392dc1f4a8"), new Guid("deddda20-f1f0-4e03-a80d-19061f1fbd90"), new DateTime(2024, 1, 13, 20, 11, 5, 0, DateTimeKind.Unspecified) },
                    { new Guid("8b854df4-b93f-421b-8f52-76c7bf95fde9"), new Guid("059df751-ae7f-4e2e-9fad-8994ffb19cfd"), new DateTime(2024, 1, 13, 23, 37, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8b854df4-b93f-421b-8f52-76c7bf95fde9"), new Guid("0cbf9c89-d97c-4f3d-a063-570d16f47808"), new DateTime(2024, 1, 13, 19, 56, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8b854df4-b93f-421b-8f52-76c7bf95fde9"), new Guid("2debf88b-ed60-4aca-83af-c1ae01a574e0"), new DateTime(2024, 1, 13, 13, 3, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8b854df4-b93f-421b-8f52-76c7bf95fde9"), new Guid("454d5e28-f151-474e-bb08-1f2e89af65f3"), new DateTime(2024, 1, 13, 10, 30, 40, 0, DateTimeKind.Unspecified) },
                    { new Guid("8b854df4-b93f-421b-8f52-76c7bf95fde9"), new Guid("4ade1e67-4124-4c67-98be-74c5892b0929"), new DateTime(2024, 1, 13, 11, 30, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8b854df4-b93f-421b-8f52-76c7bf95fde9"), new Guid("535536bc-716f-47cf-82e5-6e8b281ea20f"), new DateTime(2024, 1, 13, 10, 20, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8b854df4-b93f-421b-8f52-76c7bf95fde9"), new Guid("5fea97fc-c769-4ec5-84ed-ed427739267e"), new DateTime(2024, 1, 13, 12, 50, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8b854df4-b93f-421b-8f52-76c7bf95fde9"), new Guid("8caee912-d7aa-4e63-80ec-63fc4d05f5e2"), new DateTime(2024, 1, 13, 20, 11, 5, 0, DateTimeKind.Unspecified) },
                    { new Guid("8b854df4-b93f-421b-8f52-76c7bf95fde9"), new Guid("8dac7bfa-1112-4744-85bc-db41d39399c2"), new DateTime(2024, 1, 13, 11, 20, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8b854df4-b93f-421b-8f52-76c7bf95fde9"), new Guid("9723d8f3-83cd-45c2-883b-d4f439bb9c10"), new DateTime(2024, 1, 13, 13, 1, 20, 0, DateTimeKind.Unspecified) },
                    { new Guid("8b854df4-b93f-421b-8f52-76c7bf95fde9"), new Guid("a70f4451-eaa1-456a-803b-428f3636ad08"), new DateTime(2024, 1, 13, 15, 9, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8b854df4-b93f-421b-8f52-76c7bf95fde9"), new Guid("c43bc3d1-c4f0-43c3-9ee0-ee9dc0dd8926"), new DateTime(2024, 1, 13, 12, 55, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8b854df4-b93f-421b-8f52-76c7bf95fde9"), new Guid("c72017a9-74c3-41af-a435-e78143ca258c"), new DateTime(2024, 1, 13, 12, 40, 30, 0, DateTimeKind.Unspecified) },
                    { new Guid("8b854df4-b93f-421b-8f52-76c7bf95fde9"), new Guid("ce35d5c4-c88e-40d3-ac87-3a1f405207ae"), new DateTime(2024, 1, 13, 10, 15, 30, 0, DateTimeKind.Unspecified) },
                    { new Guid("8b854df4-b93f-421b-8f52-76c7bf95fde9"), new Guid("fc5ddfd3-2496-4dab-9a67-33fdb1fac662"), new DateTime(2024, 1, 13, 17, 23, 10, 0, DateTimeKind.Unspecified) },
                    { new Guid("8c2c8480-978f-4a8f-89ac-a70a49bed05a"), new Guid("059df751-ae7f-4e2e-9fad-8994ffb19cfd"), new DateTime(2024, 1, 13, 15, 9, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8c2c8480-978f-4a8f-89ac-a70a49bed05a"), new Guid("0cbf9c89-d97c-4f3d-a063-570d16f47808"), new DateTime(2024, 1, 13, 13, 1, 20, 0, DateTimeKind.Unspecified) },
                    { new Guid("8c2c8480-978f-4a8f-89ac-a70a49bed05a"), new Guid("12195f99-9979-482a-ae86-c95b4165e221"), new DateTime(2024, 1, 13, 19, 56, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8c2c8480-978f-4a8f-89ac-a70a49bed05a"), new Guid("2debf88b-ed60-4aca-83af-c1ae01a574e0"), new DateTime(2024, 1, 13, 10, 30, 40, 0, DateTimeKind.Unspecified) },
                    { new Guid("8c2c8480-978f-4a8f-89ac-a70a49bed05a"), new Guid("7b6c81ba-aa1f-468d-8669-980fba398f2f"), new DateTime(2024, 1, 13, 10, 20, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8c2c8480-978f-4a8f-89ac-a70a49bed05a"), new Guid("8caee912-d7aa-4e63-80ec-63fc4d05f5e2"), new DateTime(2024, 1, 13, 14, 6, 20, 0, DateTimeKind.Unspecified) },
                    { new Guid("8c2c8480-978f-4a8f-89ac-a70a49bed05a"), new Guid("94e1a1dc-70f6-4221-8e2c-853a7ca3ec36"), new DateTime(2024, 1, 13, 11, 20, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8c2c8480-978f-4a8f-89ac-a70a49bed05a"), new Guid("9723d8f3-83cd-45c2-883b-d4f439bb9c10"), new DateTime(2024, 1, 13, 10, 15, 30, 0, DateTimeKind.Unspecified) },
                    { new Guid("8c2c8480-978f-4a8f-89ac-a70a49bed05a"), new Guid("9a231f48-4e1a-4bfb-bfbf-11b374bd1e53"), new DateTime(2024, 1, 13, 12, 55, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8c2c8480-978f-4a8f-89ac-a70a49bed05a"), new Guid("a70f4451-eaa1-456a-803b-428f3636ad08"), new DateTime(2024, 1, 13, 11, 30, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8c2c8480-978f-4a8f-89ac-a70a49bed05a"), new Guid("bac347b3-aca6-4e14-acb7-c9c7e91a2ea6"), new DateTime(2024, 1, 13, 13, 3, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8c2c8480-978f-4a8f-89ac-a70a49bed05a"), new Guid("c4439bcb-9ab7-4f75-b1e7-146018d1672c"), new DateTime(2024, 1, 13, 17, 23, 10, 0, DateTimeKind.Unspecified) },
                    { new Guid("8c2c8480-978f-4a8f-89ac-a70a49bed05a"), new Guid("d75c9d95-82ab-410b-ae61-66e963366428"), new DateTime(2024, 1, 13, 20, 11, 5, 0, DateTimeKind.Unspecified) },
                    { new Guid("8c2c8480-978f-4a8f-89ac-a70a49bed05a"), new Guid("ecbc94d1-ab61-4bab-a914-72ed2b7546ab"), new DateTime(2024, 1, 13, 23, 37, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8c2c8480-978f-4a8f-89ac-a70a49bed05a"), new Guid("fc5ddfd3-2496-4dab-9a67-33fdb1fac662"), new DateTime(2024, 1, 13, 12, 50, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8c2c8480-978f-4a8f-89ac-a70a49bed05a"), new Guid("fe27c13d-6023-4d38-a12a-6154ef14a9b8"), new DateTime(2024, 1, 13, 12, 40, 30, 0, DateTimeKind.Unspecified) },
                    { new Guid("ec719221-7073-4694-897f-bfeabc02c22e"), new Guid("0cbf9c89-d97c-4f3d-a063-570d16f47808"), new DateTime(2024, 1, 13, 10, 30, 40, 0, DateTimeKind.Unspecified) },
                    { new Guid("ec719221-7073-4694-897f-bfeabc02c22e"), new Guid("2debf88b-ed60-4aca-83af-c1ae01a574e0"), new DateTime(2024, 1, 13, 13, 1, 20, 0, DateTimeKind.Unspecified) },
                    { new Guid("ec719221-7073-4694-897f-bfeabc02c22e"), new Guid("454d5e28-f151-474e-bb08-1f2e89af65f3"), new DateTime(2024, 1, 13, 19, 56, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ec719221-7073-4694-897f-bfeabc02c22e"), new Guid("4ade1e67-4124-4c67-98be-74c5892b0929"), new DateTime(2024, 1, 13, 17, 23, 10, 0, DateTimeKind.Unspecified) },
                    { new Guid("ec719221-7073-4694-897f-bfeabc02c22e"), new Guid("7b6c81ba-aa1f-468d-8669-980fba398f2f"), new DateTime(2024, 1, 13, 13, 3, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ec719221-7073-4694-897f-bfeabc02c22e"), new Guid("838a0d7a-4777-4999-b0ca-798962218c82"), new DateTime(2024, 1, 13, 23, 37, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ec719221-7073-4694-897f-bfeabc02c22e"), new Guid("8caee912-d7aa-4e63-80ec-63fc4d05f5e2"), new DateTime(2024, 1, 13, 10, 15, 30, 0, DateTimeKind.Unspecified) },
                    { new Guid("ec719221-7073-4694-897f-bfeabc02c22e"), new Guid("94e1a1dc-70f6-4221-8e2c-853a7ca3ec36"), new DateTime(2024, 1, 13, 12, 55, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ec719221-7073-4694-897f-bfeabc02c22e"), new Guid("9723d8f3-83cd-45c2-883b-d4f439bb9c10"), new DateTime(2024, 1, 13, 14, 6, 20, 0, DateTimeKind.Unspecified) },
                    { new Guid("ec719221-7073-4694-897f-bfeabc02c22e"), new Guid("9a231f48-4e1a-4bfb-bfbf-11b374bd1e53"), new DateTime(2024, 1, 13, 11, 20, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ec719221-7073-4694-897f-bfeabc02c22e"), new Guid("a70f4451-eaa1-456a-803b-428f3636ad08"), new DateTime(2024, 1, 13, 12, 50, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ec719221-7073-4694-897f-bfeabc02c22e"), new Guid("bac347b3-aca6-4e14-acb7-c9c7e91a2ea6"), new DateTime(2024, 1, 13, 10, 20, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ec719221-7073-4694-897f-bfeabc02c22e"), new Guid("c43bc3d1-c4f0-43c3-9ee0-ee9dc0dd8926"), new DateTime(2024, 1, 13, 15, 9, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ec719221-7073-4694-897f-bfeabc02c22e"), new Guid("ce35d5c4-c88e-40d3-ac87-3a1f405207ae"), new DateTime(2024, 1, 13, 20, 11, 5, 0, DateTimeKind.Unspecified) },
                    { new Guid("ec719221-7073-4694-897f-bfeabc02c22e"), new Guid("fc5ddfd3-2496-4dab-9a67-33fdb1fac662"), new DateTime(2024, 1, 13, 11, 30, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ec719221-7073-4694-897f-bfeabc02c22e"), new Guid("fe27c13d-6023-4d38-a12a-6154ef14a9b8"), new DateTime(2024, 1, 13, 12, 40, 30, 0, DateTimeKind.Unspecified) },
                    { new Guid("ffda4624-660e-46a1-8a71-74e685fe6353"), new Guid("059df751-ae7f-4e2e-9fad-8994ffb19cfd"), new DateTime(2024, 1, 13, 23, 37, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ffda4624-660e-46a1-8a71-74e685fe6353"), new Guid("12195f99-9979-482a-ae86-c95b4165e221"), new DateTime(2024, 1, 13, 14, 6, 20, 0, DateTimeKind.Unspecified) },
                    { new Guid("ffda4624-660e-46a1-8a71-74e685fe6353"), new Guid("131f8219-eccf-46ff-9bcf-bab4af4ca13e"), new DateTime(2024, 1, 13, 10, 30, 40, 0, DateTimeKind.Unspecified) },
                    { new Guid("ffda4624-660e-46a1-8a71-74e685fe6353"), new Guid("38aad1d5-c710-4be2-b478-2e5a27ad0a3b"), new DateTime(2024, 1, 13, 11, 30, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ffda4624-660e-46a1-8a71-74e685fe6353"), new Guid("6f9327c5-abe2-4407-85ff-cb77b5467f40"), new DateTime(2024, 1, 13, 12, 40, 30, 0, DateTimeKind.Unspecified) },
                    { new Guid("ffda4624-660e-46a1-8a71-74e685fe6353"), new Guid("72c94129-2cfb-47a7-9c94-4ff094671e14"), new DateTime(2024, 1, 13, 10, 20, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ffda4624-660e-46a1-8a71-74e685fe6353"), new Guid("b2f9023f-6c16-43e8-a750-742e40885bb7"), new DateTime(2024, 1, 13, 12, 55, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ffda4624-660e-46a1-8a71-74e685fe6353"), new Guid("ba5dfee8-5de5-4965-b482-e84b0a80027c"), new DateTime(2024, 1, 13, 12, 50, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ffda4624-660e-46a1-8a71-74e685fe6353"), new Guid("c4439bcb-9ab7-4f75-b1e7-146018d1672c"), new DateTime(2024, 1, 13, 20, 11, 5, 0, DateTimeKind.Unspecified) },
                    { new Guid("ffda4624-660e-46a1-8a71-74e685fe6353"), new Guid("d75c9d95-82ab-410b-ae61-66e963366428"), new DateTime(2024, 1, 13, 13, 3, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ffda4624-660e-46a1-8a71-74e685fe6353"), new Guid("db8789bd-cd24-405a-8efa-9443de243db6"), new DateTime(2024, 1, 13, 10, 15, 30, 0, DateTimeKind.Unspecified) },
                    { new Guid("ffda4624-660e-46a1-8a71-74e685fe6353"), new Guid("ecbc94d1-ab61-4bab-a914-72ed2b7546ab"), new DateTime(2024, 1, 13, 13, 1, 20, 0, DateTimeKind.Unspecified) },
                    { new Guid("ffda4624-660e-46a1-8a71-74e685fe6353"), new Guid("fd062277-2258-4c28-ace0-010fcb7c8146"), new DateTime(2024, 1, 13, 11, 20, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Users_who_joined_chats",
                columns: new[] { "Chat_id", "User_id" },
                values: new object[,]
                {
                    { new Guid("3408c6f5-bcf0-467e-a068-b8b8bbb0689f"), new Guid("1b6e43d2-3000-41ef-9aa8-24a5bb961f4c") },
                    { new Guid("4189917d-7073-405b-8c47-a391f23fa31b"), new Guid("1b6e43d2-3000-41ef-9aa8-24a5bb961f4c") },
                    { new Guid("8c2c8480-978f-4a8f-89ac-a70a49bed05a"), new Guid("1b6e43d2-3000-41ef-9aa8-24a5bb961f4c") },
                    { new Guid("ec719221-7073-4694-897f-bfeabc02c22e"), new Guid("1b6e43d2-3000-41ef-9aa8-24a5bb961f4c") },
                    { new Guid("ffda4624-660e-46a1-8a71-74e685fe6353"), new Guid("1b6e43d2-3000-41ef-9aa8-24a5bb961f4c") },
                    { new Guid("4189917d-7073-405b-8c47-a391f23fa31b"), new Guid("1b854f16-2261-42b1-a614-5f9106a03b63") },
                    { new Guid("7999d70a-1a31-428e-9078-3c392dc1f4a8"), new Guid("1b854f16-2261-42b1-a614-5f9106a03b63") },
                    { new Guid("8b854df4-b93f-421b-8f52-76c7bf95fde9"), new Guid("1b854f16-2261-42b1-a614-5f9106a03b63") },
                    { new Guid("ffda4624-660e-46a1-8a71-74e685fe6353"), new Guid("1b854f16-2261-42b1-a614-5f9106a03b63") },
                    { new Guid("3408c6f5-bcf0-467e-a068-b8b8bbb0689f"), new Guid("213c170b-0b1c-499f-8e18-d35e5a7707ff") },
                    { new Guid("4189917d-7073-405b-8c47-a391f23fa31b"), new Guid("213c170b-0b1c-499f-8e18-d35e5a7707ff") },
                    { new Guid("7999d70a-1a31-428e-9078-3c392dc1f4a8"), new Guid("213c170b-0b1c-499f-8e18-d35e5a7707ff") },
                    { new Guid("8b854df4-b93f-421b-8f52-76c7bf95fde9"), new Guid("213c170b-0b1c-499f-8e18-d35e5a7707ff") },
                    { new Guid("8c2c8480-978f-4a8f-89ac-a70a49bed05a"), new Guid("213c170b-0b1c-499f-8e18-d35e5a7707ff") },
                    { new Guid("3408c6f5-bcf0-467e-a068-b8b8bbb0689f"), new Guid("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983") },
                    { new Guid("4189917d-7073-405b-8c47-a391f23fa31b"), new Guid("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983") },
                    { new Guid("7999d70a-1a31-428e-9078-3c392dc1f4a8"), new Guid("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983") },
                    { new Guid("8b854df4-b93f-421b-8f52-76c7bf95fde9"), new Guid("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983") },
                    { new Guid("8c2c8480-978f-4a8f-89ac-a70a49bed05a"), new Guid("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983") },
                    { new Guid("ffda4624-660e-46a1-8a71-74e685fe6353"), new Guid("32025f9e-c14c-4bd8-bbe7-a0d1a9c88983") },
                    { new Guid("3408c6f5-bcf0-467e-a068-b8b8bbb0689f"), new Guid("57692189-acbb-4aa2-b2c9-6a5291e611af") },
                    { new Guid("4189917d-7073-405b-8c47-a391f23fa31b"), new Guid("57692189-acbb-4aa2-b2c9-6a5291e611af") },
                    { new Guid("8b854df4-b93f-421b-8f52-76c7bf95fde9"), new Guid("57692189-acbb-4aa2-b2c9-6a5291e611af") },
                    { new Guid("8c2c8480-978f-4a8f-89ac-a70a49bed05a"), new Guid("57692189-acbb-4aa2-b2c9-6a5291e611af") },
                    { new Guid("ec719221-7073-4694-897f-bfeabc02c22e"), new Guid("57692189-acbb-4aa2-b2c9-6a5291e611af") },
                    { new Guid("ffda4624-660e-46a1-8a71-74e685fe6353"), new Guid("57692189-acbb-4aa2-b2c9-6a5291e611af") },
                    { new Guid("4189917d-7073-405b-8c47-a391f23fa31b"), new Guid("70693fa5-9180-4f05-854d-5d86aa286535") },
                    { new Guid("7999d70a-1a31-428e-9078-3c392dc1f4a8"), new Guid("70693fa5-9180-4f05-854d-5d86aa286535") },
                    { new Guid("8c2c8480-978f-4a8f-89ac-a70a49bed05a"), new Guid("70693fa5-9180-4f05-854d-5d86aa286535") },
                    { new Guid("ec719221-7073-4694-897f-bfeabc02c22e"), new Guid("70693fa5-9180-4f05-854d-5d86aa286535") },
                    { new Guid("ffda4624-660e-46a1-8a71-74e685fe6353"), new Guid("70693fa5-9180-4f05-854d-5d86aa286535") },
                    { new Guid("4189917d-7073-405b-8c47-a391f23fa31b"), new Guid("81e75865-2b69-4440-af1d-bcbd2817abbe") },
                    { new Guid("7999d70a-1a31-428e-9078-3c392dc1f4a8"), new Guid("81e75865-2b69-4440-af1d-bcbd2817abbe") },
                    { new Guid("8b854df4-b93f-421b-8f52-76c7bf95fde9"), new Guid("81e75865-2b69-4440-af1d-bcbd2817abbe") },
                    { new Guid("8c2c8480-978f-4a8f-89ac-a70a49bed05a"), new Guid("81e75865-2b69-4440-af1d-bcbd2817abbe") },
                    { new Guid("ec719221-7073-4694-897f-bfeabc02c22e"), new Guid("81e75865-2b69-4440-af1d-bcbd2817abbe") },
                    { new Guid("ffda4624-660e-46a1-8a71-74e685fe6353"), new Guid("81e75865-2b69-4440-af1d-bcbd2817abbe") },
                    { new Guid("4189917d-7073-405b-8c47-a391f23fa31b"), new Guid("85fd205e-86a0-419b-8d59-7dc80f5b734e") },
                    { new Guid("7999d70a-1a31-428e-9078-3c392dc1f4a8"), new Guid("85fd205e-86a0-419b-8d59-7dc80f5b734e") },
                    { new Guid("8b854df4-b93f-421b-8f52-76c7bf95fde9"), new Guid("85fd205e-86a0-419b-8d59-7dc80f5b734e") },
                    { new Guid("8c2c8480-978f-4a8f-89ac-a70a49bed05a"), new Guid("85fd205e-86a0-419b-8d59-7dc80f5b734e") },
                    { new Guid("ec719221-7073-4694-897f-bfeabc02c22e"), new Guid("85fd205e-86a0-419b-8d59-7dc80f5b734e") },
                    { new Guid("ffda4624-660e-46a1-8a71-74e685fe6353"), new Guid("85fd205e-86a0-419b-8d59-7dc80f5b734e") },
                    { new Guid("3408c6f5-bcf0-467e-a068-b8b8bbb0689f"), new Guid("8bb3ec1e-07e9-4bad-ab1f-15691b291e9d") },
                    { new Guid("4189917d-7073-405b-8c47-a391f23fa31b"), new Guid("8bb3ec1e-07e9-4bad-ab1f-15691b291e9d") },
                    { new Guid("7999d70a-1a31-428e-9078-3c392dc1f4a8"), new Guid("8bb3ec1e-07e9-4bad-ab1f-15691b291e9d") },
                    { new Guid("8b854df4-b93f-421b-8f52-76c7bf95fde9"), new Guid("8bb3ec1e-07e9-4bad-ab1f-15691b291e9d") },
                    { new Guid("8c2c8480-978f-4a8f-89ac-a70a49bed05a"), new Guid("8bb3ec1e-07e9-4bad-ab1f-15691b291e9d") },
                    { new Guid("ec719221-7073-4694-897f-bfeabc02c22e"), new Guid("8bb3ec1e-07e9-4bad-ab1f-15691b291e9d") },
                    { new Guid("ffda4624-660e-46a1-8a71-74e685fe6353"), new Guid("8bb3ec1e-07e9-4bad-ab1f-15691b291e9d") },
                    { new Guid("3408c6f5-bcf0-467e-a068-b8b8bbb0689f"), new Guid("8bc1ae99-62b1-4c3b-936a-ed89898adceb") },
                    { new Guid("4189917d-7073-405b-8c47-a391f23fa31b"), new Guid("8bc1ae99-62b1-4c3b-936a-ed89898adceb") },
                    { new Guid("7999d70a-1a31-428e-9078-3c392dc1f4a8"), new Guid("8bc1ae99-62b1-4c3b-936a-ed89898adceb") },
                    { new Guid("8c2c8480-978f-4a8f-89ac-a70a49bed05a"), new Guid("8bc1ae99-62b1-4c3b-936a-ed89898adceb") },
                    { new Guid("ec719221-7073-4694-897f-bfeabc02c22e"), new Guid("8bc1ae99-62b1-4c3b-936a-ed89898adceb") },
                    { new Guid("ffda4624-660e-46a1-8a71-74e685fe6353"), new Guid("8bc1ae99-62b1-4c3b-936a-ed89898adceb") },
                    { new Guid("3408c6f5-bcf0-467e-a068-b8b8bbb0689f"), new Guid("8cbc3199-5acc-4e26-8e4b-3e84c563dfca") },
                    { new Guid("4189917d-7073-405b-8c47-a391f23fa31b"), new Guid("8cbc3199-5acc-4e26-8e4b-3e84c563dfca") },
                    { new Guid("7999d70a-1a31-428e-9078-3c392dc1f4a8"), new Guid("8cbc3199-5acc-4e26-8e4b-3e84c563dfca") },
                    { new Guid("8b854df4-b93f-421b-8f52-76c7bf95fde9"), new Guid("8cbc3199-5acc-4e26-8e4b-3e84c563dfca") },
                    { new Guid("8c2c8480-978f-4a8f-89ac-a70a49bed05a"), new Guid("8cbc3199-5acc-4e26-8e4b-3e84c563dfca") },
                    { new Guid("ec719221-7073-4694-897f-bfeabc02c22e"), new Guid("8cbc3199-5acc-4e26-8e4b-3e84c563dfca") },
                    { new Guid("3408c6f5-bcf0-467e-a068-b8b8bbb0689f"), new Guid("99ba6920-55ac-4657-8712-c7241f23c9bf") },
                    { new Guid("4189917d-7073-405b-8c47-a391f23fa31b"), new Guid("99ba6920-55ac-4657-8712-c7241f23c9bf") },
                    { new Guid("7999d70a-1a31-428e-9078-3c392dc1f4a8"), new Guid("99ba6920-55ac-4657-8712-c7241f23c9bf") },
                    { new Guid("8b854df4-b93f-421b-8f52-76c7bf95fde9"), new Guid("99ba6920-55ac-4657-8712-c7241f23c9bf") },
                    { new Guid("8c2c8480-978f-4a8f-89ac-a70a49bed05a"), new Guid("99ba6920-55ac-4657-8712-c7241f23c9bf") },
                    { new Guid("ec719221-7073-4694-897f-bfeabc02c22e"), new Guid("99ba6920-55ac-4657-8712-c7241f23c9bf") },
                    { new Guid("3408c6f5-bcf0-467e-a068-b8b8bbb0689f"), new Guid("9b419875-e449-4d74-9dd7-7c9630374799") },
                    { new Guid("4189917d-7073-405b-8c47-a391f23fa31b"), new Guid("9b419875-e449-4d74-9dd7-7c9630374799") },
                    { new Guid("7999d70a-1a31-428e-9078-3c392dc1f4a8"), new Guid("9b419875-e449-4d74-9dd7-7c9630374799") },
                    { new Guid("8b854df4-b93f-421b-8f52-76c7bf95fde9"), new Guid("9b419875-e449-4d74-9dd7-7c9630374799") },
                    { new Guid("8c2c8480-978f-4a8f-89ac-a70a49bed05a"), new Guid("9b419875-e449-4d74-9dd7-7c9630374799") },
                    { new Guid("ec719221-7073-4694-897f-bfeabc02c22e"), new Guid("9b419875-e449-4d74-9dd7-7c9630374799") },
                    { new Guid("4189917d-7073-405b-8c47-a391f23fa31b"), new Guid("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3") },
                    { new Guid("7999d70a-1a31-428e-9078-3c392dc1f4a8"), new Guid("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3") },
                    { new Guid("8b854df4-b93f-421b-8f52-76c7bf95fde9"), new Guid("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3") },
                    { new Guid("8c2c8480-978f-4a8f-89ac-a70a49bed05a"), new Guid("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3") },
                    { new Guid("ec719221-7073-4694-897f-bfeabc02c22e"), new Guid("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3") },
                    { new Guid("ffda4624-660e-46a1-8a71-74e685fe6353"), new Guid("bf786b8b-e8aa-46fe-a309-f6c64b0deaf3") },
                    { new Guid("3408c6f5-bcf0-467e-a068-b8b8bbb0689f"), new Guid("c8d49eba-1396-41f3-9414-8bfd2021b793") },
                    { new Guid("7999d70a-1a31-428e-9078-3c392dc1f4a8"), new Guid("c8d49eba-1396-41f3-9414-8bfd2021b793") },
                    { new Guid("8b854df4-b93f-421b-8f52-76c7bf95fde9"), new Guid("c8d49eba-1396-41f3-9414-8bfd2021b793") },
                    { new Guid("8c2c8480-978f-4a8f-89ac-a70a49bed05a"), new Guid("c8d49eba-1396-41f3-9414-8bfd2021b793") },
                    { new Guid("3408c6f5-bcf0-467e-a068-b8b8bbb0689f"), new Guid("c9772f81-2145-4338-ad2d-9504b4b3dc6a") },
                    { new Guid("4189917d-7073-405b-8c47-a391f23fa31b"), new Guid("c9772f81-2145-4338-ad2d-9504b4b3dc6a") },
                    { new Guid("7999d70a-1a31-428e-9078-3c392dc1f4a8"), new Guid("c9772f81-2145-4338-ad2d-9504b4b3dc6a") },
                    { new Guid("8b854df4-b93f-421b-8f52-76c7bf95fde9"), new Guid("c9772f81-2145-4338-ad2d-9504b4b3dc6a") },
                    { new Guid("8c2c8480-978f-4a8f-89ac-a70a49bed05a"), new Guid("c9772f81-2145-4338-ad2d-9504b4b3dc6a") },
                    { new Guid("ffda4624-660e-46a1-8a71-74e685fe6353"), new Guid("c9772f81-2145-4338-ad2d-9504b4b3dc6a") },
                    { new Guid("3408c6f5-bcf0-467e-a068-b8b8bbb0689f"), new Guid("cd61d42e-6981-480e-aaf5-4869d78b9b81") },
                    { new Guid("4189917d-7073-405b-8c47-a391f23fa31b"), new Guid("cd61d42e-6981-480e-aaf5-4869d78b9b81") },
                    { new Guid("7999d70a-1a31-428e-9078-3c392dc1f4a8"), new Guid("cd61d42e-6981-480e-aaf5-4869d78b9b81") },
                    { new Guid("8b854df4-b93f-421b-8f52-76c7bf95fde9"), new Guid("cd61d42e-6981-480e-aaf5-4869d78b9b81") },
                    { new Guid("ec719221-7073-4694-897f-bfeabc02c22e"), new Guid("cd61d42e-6981-480e-aaf5-4869d78b9b81") },
                    { new Guid("ffda4624-660e-46a1-8a71-74e685fe6353"), new Guid("cd61d42e-6981-480e-aaf5-4869d78b9b81") },
                    { new Guid("3408c6f5-bcf0-467e-a068-b8b8bbb0689f"), new Guid("e22141d8-f3ce-49db-bcf9-cdd1961b48b5") },
                    { new Guid("7999d70a-1a31-428e-9078-3c392dc1f4a8"), new Guid("e22141d8-f3ce-49db-bcf9-cdd1961b48b5") },
                    { new Guid("8b854df4-b93f-421b-8f52-76c7bf95fde9"), new Guid("e22141d8-f3ce-49db-bcf9-cdd1961b48b5") },
                    { new Guid("8c2c8480-978f-4a8f-89ac-a70a49bed05a"), new Guid("e22141d8-f3ce-49db-bcf9-cdd1961b48b5") },
                    { new Guid("ec719221-7073-4694-897f-bfeabc02c22e"), new Guid("e22141d8-f3ce-49db-bcf9-cdd1961b48b5") },
                    { new Guid("ffda4624-660e-46a1-8a71-74e685fe6353"), new Guid("e22141d8-f3ce-49db-bcf9-cdd1961b48b5") },
                    { new Guid("3408c6f5-bcf0-467e-a068-b8b8bbb0689f"), new Guid("ebcc0f14-937b-4c82-a021-5ff55809dec3") },
                    { new Guid("4189917d-7073-405b-8c47-a391f23fa31b"), new Guid("ebcc0f14-937b-4c82-a021-5ff55809dec3") },
                    { new Guid("7999d70a-1a31-428e-9078-3c392dc1f4a8"), new Guid("ebcc0f14-937b-4c82-a021-5ff55809dec3") },
                    { new Guid("8b854df4-b93f-421b-8f52-76c7bf95fde9"), new Guid("ebcc0f14-937b-4c82-a021-5ff55809dec3") },
                    { new Guid("8c2c8480-978f-4a8f-89ac-a70a49bed05a"), new Guid("ebcc0f14-937b-4c82-a021-5ff55809dec3") },
                    { new Guid("ec719221-7073-4694-897f-bfeabc02c22e"), new Guid("ebcc0f14-937b-4c82-a021-5ff55809dec3") },
                    { new Guid("ffda4624-660e-46a1-8a71-74e685fe6353"), new Guid("ebcc0f14-937b-4c82-a021-5ff55809dec3") },
                    { new Guid("3408c6f5-bcf0-467e-a068-b8b8bbb0689f"), new Guid("fc029e14-d132-4bf3-a958-490d18320df7") },
                    { new Guid("4189917d-7073-405b-8c47-a391f23fa31b"), new Guid("fc029e14-d132-4bf3-a958-490d18320df7") },
                    { new Guid("8c2c8480-978f-4a8f-89ac-a70a49bed05a"), new Guid("fc029e14-d132-4bf3-a958-490d18320df7") },
                    { new Guid("ec719221-7073-4694-897f-bfeabc02c22e"), new Guid("fc029e14-d132-4bf3-a958-490d18320df7") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chats_Owner_user_id",
                table: "Chats",
                column: "Owner_user_id");

            migrationBuilder.CreateIndex(
                name: "IX_Chats_voice_recordings_Voice_recording_id",
                table: "Chats_voice_recordings",
                column: "Voice_recording_id");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Username",
                table: "Users",
                column: "Username",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_relationships_User_friend_id",
                table: "Users_relationships",
                column: "User_friend_id");

            migrationBuilder.CreateIndex(
                name: "IX_Users_who_joined_chats_Chat_id",
                table: "Users_who_joined_chats",
                column: "Chat_id");

            migrationBuilder.CreateIndex(
                name: "IX_Voice_recordings_Owner_user_id",
                table: "Voice_recordings",
                column: "Owner_user_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chats_voice_recordings");

            migrationBuilder.DropTable(
                name: "Users_relationships");

            migrationBuilder.DropTable(
                name: "Users_who_joined_chats");

            migrationBuilder.DropTable(
                name: "Voice_recordings");

            migrationBuilder.DropTable(
                name: "Chats");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
