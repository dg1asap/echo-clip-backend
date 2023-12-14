using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EchoClip.Models.Migrations
{
    /// <inheritdoc />
    public partial class foreignKeyChsdaf222hafaf2314s : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chats_voice_recordings_Chats_ChatsChat_id",
                table: "Chats_voice_recordings");

            migrationBuilder.DropForeignKey(
                name: "FK_Chats_voice_recordings_Voice_recordings_Voice_recordingsVoi~",
                table: "Chats_voice_recordings");

            migrationBuilder.DropIndex(
                name: "IX_Chats_voice_recordings_ChatsChat_id",
                table: "Chats_voice_recordings");

            migrationBuilder.DropIndex(
                name: "IX_Chats_voice_recordings_Voice_recordingsVoide_recoding_id",
                table: "Chats_voice_recordings");

            migrationBuilder.DropColumn(
                name: "ChatsChat_id",
                table: "Chats_voice_recordings");

            migrationBuilder.DropColumn(
                name: "Voice_recordingsVoide_recoding_id",
                table: "Chats_voice_recordings");

            migrationBuilder.CreateIndex(
                name: "IX_Chats_voice_recordings_Voice_recording_id",
                table: "Chats_voice_recordings",
                column: "Voice_recording_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Chats_voice_recordings_Chats_Chat_id",
                table: "Chats_voice_recordings",
                column: "Chat_id",
                principalTable: "Chats",
                principalColumn: "Chat_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Chats_voice_recordings_Voice_recordings_Voice_recording_id",
                table: "Chats_voice_recordings",
                column: "Voice_recording_id",
                principalTable: "Voice_recordings",
                principalColumn: "Voide_recoding_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chats_voice_recordings_Chats_Chat_id",
                table: "Chats_voice_recordings");

            migrationBuilder.DropForeignKey(
                name: "FK_Chats_voice_recordings_Voice_recordings_Voice_recording_id",
                table: "Chats_voice_recordings");

            migrationBuilder.DropIndex(
                name: "IX_Chats_voice_recordings_Voice_recording_id",
                table: "Chats_voice_recordings");

            migrationBuilder.AddColumn<Guid>(
                name: "ChatsChat_id",
                table: "Chats_voice_recordings",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "Voice_recordingsVoide_recoding_id",
                table: "Chats_voice_recordings",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Chats_voice_recordings_ChatsChat_id",
                table: "Chats_voice_recordings",
                column: "ChatsChat_id");

            migrationBuilder.CreateIndex(
                name: "IX_Chats_voice_recordings_Voice_recordingsVoide_recoding_id",
                table: "Chats_voice_recordings",
                column: "Voice_recordingsVoide_recoding_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Chats_voice_recordings_Chats_ChatsChat_id",
                table: "Chats_voice_recordings",
                column: "ChatsChat_id",
                principalTable: "Chats",
                principalColumn: "Chat_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Chats_voice_recordings_Voice_recordings_Voice_recordingsVoi~",
                table: "Chats_voice_recordings",
                column: "Voice_recordingsVoide_recoding_id",
                principalTable: "Voice_recordings",
                principalColumn: "Voide_recoding_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
