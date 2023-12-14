using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EchoClip.Models.Migrations
{
    /// <inheritdoc />
    public partial class foreignKeyChsdaf222 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Friend_invates");

            migrationBuilder.DropTable(
                name: "Friends");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Friend_invates",
                columns: table => new
                {
                    User_id = table.Column<Guid>(type: "uuid", nullable: false),
                    User_friend_invates_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Friend_invates", x => x.User_id);
                });

            migrationBuilder.CreateTable(
                name: "Friends",
                columns: table => new
                {
                    User_id = table.Column<Guid>(type: "uuid", nullable: false),
                    User_friend_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Friends", x => x.User_id);
                });
        }
    }
}
