using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DaryaAlexeevaKT4120.Migrations
{
    /// <inheritdoc />
    public partial class createDatabaseGroup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Specializations",
                columns: table => new
                {
                    spec_id = table.Column<int>(type: "int", nullable: false, comment: "Идентификатор специальности")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    spec_name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, comment: "Специальность")
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_(TableName) spec_id", x => x.spec_id);
                });

            migrationBuilder.CreateTable(
                name: "Group",
                columns: table => new
                {
                    group_id = table.Column<int>(type: "int", nullable: false, comment: "Идентификатор записи группы")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    num_group = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, comment: "Номер группы"),
                    group_year = table.Column<int>(type: "int", maxLength: 100, nullable: false, comment: "Год поступления"),
                    group_exist = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, comment: "Факт существования группы"),
                    spec_id = table.Column<int>(type: "int", maxLength: 100, nullable: false, comment: "Идентификатор специальности")
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_(TableName) group_id", x => x.group_id);
                    table.ForeignKey(
                        name: "fk_f_spec_id",
                        column: x => x.spec_id,
                        principalTable: "Specializations",
                        principalColumn: "spec_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "idx_Group_fk_f_spec_id",
                table: "Group",
                column: "spec_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Group");

            migrationBuilder.DropTable(
                name: "Specializations");
        }
    }
}
