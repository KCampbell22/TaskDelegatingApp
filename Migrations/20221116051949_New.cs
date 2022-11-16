using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskDelegatingApp.Migrations
{
    /// <inheritdoc />
    public partial class New : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Day",
                columns: table => new
                {
                    DayId = table.Column<int>(type: "int", nullable: false),
                    DayName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Day", x => x.DayId);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AvailableMonday = table.Column<bool>(type: "bit", nullable: false),
                    AvailableTuesday = table.Column<bool>(type: "bit", nullable: false),
                    AvailableWednsday = table.Column<bool>(type: "bit", nullable: false),
                    AvailableThursday = table.Column<bool>(type: "bit", nullable: false),
                    AvailableFriday = table.Column<bool>(type: "bit", nullable: false),
                    AvailableSaturday = table.Column<bool>(type: "bit", nullable: false),
                    AvailableSunday = table.Column<bool>(type: "bit", nullable: false),
                    DayId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Person_Day_DayId",
                        column: x => x.DayId,
                        principalTable: "Day",
                        principalColumn: "DayId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaskItem",
                columns: table => new
                {
                    TaskItemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TimeofDay = table.Column<int>(type: "int", nullable: false),
                    DayId = table.Column<int>(type: "int", nullable: false),
                    PersonID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskItem", x => x.TaskItemID);
                    table.ForeignKey(
                        name: "FK_TaskItem_Day_DayId",
                        column: x => x.DayId,
                        principalTable: "Day",
                        principalColumn: "DayId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaskItem_Person_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Person",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Person_DayId",
                table: "Person",
                column: "DayId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskItem_DayId",
                table: "TaskItem",
                column: "DayId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskItem_PersonID",
                table: "TaskItem",
                column: "PersonID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TaskItem");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "Day");
        }
    }
}
