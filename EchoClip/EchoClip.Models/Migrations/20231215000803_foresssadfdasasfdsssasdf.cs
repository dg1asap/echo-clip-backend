using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EchoClip.Models.Migrations
{
    /// <inheritdoc />
    public partial class foresssadfdasasfdsssasdf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "CK_UserRelationship_Status",
                table: "Users_relationships");

            migrationBuilder.AddCheckConstraint(
                name: "CK_USER_STAT",
                table: "Users_relationships",
                sql: "\"Status\" IN ('PENDING', 'ACCEPTED', 'REJECTED')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "CK_USER_STAT",
                table: "Users_relationships");

            migrationBuilder.AddCheckConstraint(
                name: "CK_UserRelationship_Status",
                table: "Users_relationships",
                sql: "\"Status\" IN ('PENDING', 'ACCEPTED', 'REJECTED')");
        }
    }
}
