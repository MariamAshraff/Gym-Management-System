using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gym_Management_System.Migrations
{
    /// <inheritdoc />
    public partial class TraineeAttendanceAndThisRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DurationDays",
                table: "Subscriptions",
                newName: "AllowedDays");

            migrationBuilder.AddColumn<int>(
                name: "UsedDays",
                table: "TraineeSubscriptions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "TraineeAttendances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TraineeId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckIn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TraineeAttendances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TraineeAttendances_Trainees_TraineeId",
                        column: x => x.TraineeId,
                        principalTable: "Trainees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TraineeAttendances_TraineeId",
                table: "TraineeAttendances",
                column: "TraineeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TraineeAttendances");

            migrationBuilder.DropColumn(
                name: "UsedDays",
                table: "TraineeSubscriptions");

            migrationBuilder.RenameColumn(
                name: "AllowedDays",
                table: "Subscriptions",
                newName: "DurationDays");
        }
    }
}
