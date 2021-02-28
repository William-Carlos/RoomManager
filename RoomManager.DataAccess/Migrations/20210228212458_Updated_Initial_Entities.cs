using Microsoft.EntityFrameworkCore.Migrations;

namespace RoomManager.DataAccess.Migrations
{
    public partial class Updated_Initial_Entities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Room",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "FirstStepCoffeeSpaceId",
                table: "Person",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "FirstStepRoomId",
                table: "Person",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "SecondStepCoffeeSpaceId",
                table: "Person",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "SecondStepRoomId",
                table: "Person",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "CoffeeSpace",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Person_FirstStepCoffeeSpaceId",
                table: "Person",
                column: "FirstStepCoffeeSpaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_FirstStepRoomId",
                table: "Person",
                column: "FirstStepRoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_SecondStepCoffeeSpaceId",
                table: "Person",
                column: "SecondStepCoffeeSpaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_SecondStepRoomId",
                table: "Person",
                column: "SecondStepRoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_CoffeeSpace_FirstStepCoffeeSpaceId",
                table: "Person",
                column: "FirstStepCoffeeSpaceId",
                principalTable: "CoffeeSpace",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Person_CoffeeSpace_SecondStepCoffeeSpaceId",
                table: "Person",
                column: "SecondStepCoffeeSpaceId",
                principalTable: "CoffeeSpace",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Room_FirstStepRoomId",
                table: "Person",
                column: "FirstStepRoomId",
                principalTable: "Room",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Room_SecondStepRoomId",
                table: "Person",
                column: "SecondStepRoomId",
                principalTable: "Room",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Person_CoffeeSpace_FirstStepCoffeeSpaceId",
                table: "Person");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_CoffeeSpace_SecondStepCoffeeSpaceId",
                table: "Person");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_Room_FirstStepRoomId",
                table: "Person");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_Room_SecondStepRoomId",
                table: "Person");

            migrationBuilder.DropIndex(
                name: "IX_Person_FirstStepCoffeeSpaceId",
                table: "Person");

            migrationBuilder.DropIndex(
                name: "IX_Person_FirstStepRoomId",
                table: "Person");

            migrationBuilder.DropIndex(
                name: "IX_Person_SecondStepCoffeeSpaceId",
                table: "Person");

            migrationBuilder.DropIndex(
                name: "IX_Person_SecondStepRoomId",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Room");

            migrationBuilder.DropColumn(
                name: "FirstStepCoffeeSpaceId",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "FirstStepRoomId",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "SecondStepCoffeeSpaceId",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "SecondStepRoomId",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "CoffeeSpace");
        }
    }
}
