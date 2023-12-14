using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EchoClip.Models.Migrations
{
    /// <inheritdoc />
    public partial class foreignKeyChsdaf222hafaf2314 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chats_voice_recordings_Voice_recordings_Voice_recordinSSgsV~",
                table: "Chats_voice_recordings");

            migrationBuilder.RenameColumn(
                name: "Voice_recordinSSgsVoide_recoding_id",
                table: "Chats_voice_recordings",
                newName: "Voice_recordingsVoide_recoding_id");

            migrationBuilder.RenameIndex(
                name: "IX_Chats_voice_recordings_Voice_recordinSSgsVoide_recoding_id",
                table: "Chats_voice_recordings",
                newName: "IX_Chats_voice_recordings_Voice_recordingsVoide_recoding_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Chats_voice_recordings_Voice_recordings_Voice_recordingsVoi~",
                table: "Chats_voice_recordings",
                column: "Voice_recordingsVoide_recoding_id",
                principalTable: "Voice_recordings",
                principalColumn: "Voide_recoding_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chats_voice_recordings_Voice_recordings_Voice_recordingsVoi~",
                table: "Chats_voice_recordings");

            migrationBuilder.RenameColumn(
                name: "Voice_recordingsVoide_recoding_id",
                table: "Chats_voice_recordings",
                newName: "Voice_recordinSSgsVoide_recoding_id");

            migrationBuilder.RenameIndex(
                name: "IX_Chats_voice_recordings_Voice_recordingsVoide_recoding_id",
                table: "Chats_voice_recordings",
                newName: "IX_Chats_voice_recordings_Voice_recordinSSgsVoide_recoding_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Chats_voice_recordings_Voice_recordings_Voice_recordinSSgsV~",
                table: "Chats_voice_recordings",
                column: "Voice_recordinSSgsVoide_recoding_id",
                principalTable: "Voice_recordings",
                principalColumn: "Voide_recoding_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
