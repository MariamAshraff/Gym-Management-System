using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gym_Management_System.Migrations
{
    /// <inheritdoc />
    public partial class UpdatingTraineeAttendence : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Offers_Subscriptions_SubscriptionId",
                table: "Offers");

            migrationBuilder.DropForeignKey(
                name: "FK_TraineeAttendances_Trainees_TraineeId",
                table: "TraineeAttendances");

            migrationBuilder.DropForeignKey(
                name: "FK_TraineeSubscriptions_Subscriptions_SubscriptionId",
                table: "TraineeSubscriptions");

            migrationBuilder.DropTable(
                name: "Subscriptions");

            migrationBuilder.RenameColumn(
                name: "SubscriptionId",
                table: "TraineeSubscriptions",
                newName: "TrainingProgramId");

            migrationBuilder.RenameIndex(
                name: "IX_TraineeSubscriptions_SubscriptionId",
                table: "TraineeSubscriptions",
                newName: "IX_TraineeSubscriptions_TrainingProgramId");

            migrationBuilder.RenameColumn(
                name: "TraineeId",
                table: "TraineeAttendances",
                newName: "TraineeSubscriptionId");

            migrationBuilder.RenameIndex(
                name: "IX_TraineeAttendances_TraineeId",
                table: "TraineeAttendances",
                newName: "IX_TraineeAttendances_TraineeSubscriptionId");

            migrationBuilder.AddColumn<int>(
                name: "PackageDays",
                table: "TraineeSubscriptions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "TraineeSubscriptions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "TrainingPrograms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AllowedDays = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingPrograms", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_TrainingPrograms_SubscriptionId",
                table: "Offers",
                column: "SubscriptionId",
                principalTable: "TrainingPrograms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TraineeAttendances_TraineeSubscriptions_TraineeSubscriptionId",
                table: "TraineeAttendances",
                column: "TraineeSubscriptionId",
                principalTable: "TraineeSubscriptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TraineeSubscriptions_TrainingPrograms_TrainingProgramId",
                table: "TraineeSubscriptions",
                column: "TrainingProgramId",
                principalTable: "TrainingPrograms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Offers_TrainingPrograms_SubscriptionId",
                table: "Offers");

            migrationBuilder.DropForeignKey(
                name: "FK_TraineeAttendances_TraineeSubscriptions_TraineeSubscriptionId",
                table: "TraineeAttendances");

            migrationBuilder.DropForeignKey(
                name: "FK_TraineeSubscriptions_TrainingPrograms_TrainingProgramId",
                table: "TraineeSubscriptions");

            migrationBuilder.DropTable(
                name: "TrainingPrograms");

            migrationBuilder.DropColumn(
                name: "PackageDays",
                table: "TraineeSubscriptions");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "TraineeSubscriptions");

            migrationBuilder.RenameColumn(
                name: "TrainingProgramId",
                table: "TraineeSubscriptions",
                newName: "SubscriptionId");

            migrationBuilder.RenameIndex(
                name: "IX_TraineeSubscriptions_TrainingProgramId",
                table: "TraineeSubscriptions",
                newName: "IX_TraineeSubscriptions_SubscriptionId");

            migrationBuilder.RenameColumn(
                name: "TraineeSubscriptionId",
                table: "TraineeAttendances",
                newName: "TraineeId");

            migrationBuilder.RenameIndex(
                name: "IX_TraineeAttendances_TraineeSubscriptionId",
                table: "TraineeAttendances",
                newName: "IX_TraineeAttendances_TraineeId");

            migrationBuilder.CreateTable(
                name: "Subscriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AllowedDays = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscriptions", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_Subscriptions_SubscriptionId",
                table: "Offers",
                column: "SubscriptionId",
                principalTable: "Subscriptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TraineeAttendances_Trainees_TraineeId",
                table: "TraineeAttendances",
                column: "TraineeId",
                principalTable: "Trainees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TraineeSubscriptions_Subscriptions_SubscriptionId",
                table: "TraineeSubscriptions",
                column: "SubscriptionId",
                principalTable: "Subscriptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
