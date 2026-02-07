using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyWebApp.Migrations
{
    /// <inheritdoc />
    public partial class FixTypoInFriendId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tranactions_Friends_FriendId",
                table: "Tranactions");

            migrationBuilder.DropColumn(
                name: "FrientId",
                table: "Tranactions");

            migrationBuilder.AlterColumn<int>(
                name: "FriendId",
                table: "Tranactions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Tranactions_Friends_FriendId",
                table: "Tranactions",
                column: "FriendId",
                principalTable: "Friends",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tranactions_Friends_FriendId",
                table: "Tranactions");

            migrationBuilder.AlterColumn<int>(
                name: "FriendId",
                table: "Tranactions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "FrientId",
                table: "Tranactions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Tranactions_Friends_FriendId",
                table: "Tranactions",
                column: "FriendId",
                principalTable: "Friends",
                principalColumn: "Id");
        }
    }
}
