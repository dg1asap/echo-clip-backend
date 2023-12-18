using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EchoClip.Models.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreates : Migration
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
                    Recording = table.Column<byte[]>(type: "bytea", nullable: false),
                    Upload_data_time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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
                    Date_of_added = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_Chats_Owner_user_id",
                table: "Chats",
                column: "Owner_user_id");

            migrationBuilder.CreateIndex(
                name: "IX_Chats_voice_recordings_Date_of_added",
                table: "Chats_voice_recordings",
                column: "Date_of_added",
                unique: true);

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
