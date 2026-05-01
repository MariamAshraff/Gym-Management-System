using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gym_Management_System.Migrations
{
    /// <inheritdoc />
    public partial class UpdatingTraineeSubscriptionTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PackageDays",
                table: "TraineeSubscriptions",
                newName: "PackageTotalDays");

            migrationBuilder.AddColumn<int>(
                name: "Months",
                table: "TraineeSubscriptions",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Months",
                table: "TraineeSubscriptions");

            migrationBuilder.RenameColumn(
                name: "PackageTotalDays",
                table: "TraineeSubscriptions",
                newName: "PackageDays");
        }
    }
}
