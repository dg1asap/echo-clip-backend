using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EchoClip.Models.Migrations
{
    /// <inheritdoc />
    public partial class foreignKeyChsdaf222hafaf2314safafdsasdf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Voice_recoding_id",
                table: "Voice_recordings",
                newName: "Voice_recording_id");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date_of_added",
                table: "Chats_voice_recordings",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_Voice_recordings_Owner_user_id",
                table: "Voice_recordings",
                column: "Owner_user_id");

            migrationBuilder.CreateIndex(
                name: "IX_Chats_voice_recordings_Date_of_added",
                table: "Chats_voice_recordings",
                column: "Date_of_added",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Voice_recordings_Users_Owner_user_id",
                table: "Voice_recordings",
                column: "Owner_user_id",
                principalTable: "Users",
                principalColumn: "User_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Voice_recordings_Users_Owner_user_id",
                table: "Voice_recordings");

            migrationBuilder.DropIndex(
                name: "IX_Voice_recordings_Owner_user_id",
                table: "Voice_recordings");

            migrationBuilder.DropIndex(
                name: "IX_Chats_voice_recordings_Date_of_added",
                table: "Chats_voice_recordings");

            migrationBuilder.DropColumn(
                name: "Date_of_added",
                table: "Chats_voice_recordings");

            migrationBuilder.RenameColumn(
                name: "Voice_recording_id",
                table: "Voice_recordings",
                newName: "Voice_recoding_id");
        }
    }
}
