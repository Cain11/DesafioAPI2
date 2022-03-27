using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DesafioAPI2.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    Uf = table.Column<string>(type: "nvarchar(2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pessoas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(300)", nullable: false),
                    Cpf = table.Column<string>(type: "nvarchar(16)", nullable: false),
                    Id_Cidade = table.Column<int>(type: "int", nullable: false),
                    Idade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoas", x => x.Id);
                    table.ForeignKey(
                         name: "FK_Pessoas_Cidades_Id_Cidade",
                         column: x => x.Id_Cidade,
                         principalTable: "Cidades",
                         principalColumn: "Id",
                         onUpdate: ReferentialAction.Cascade,
                         onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
            name: "Pessoas_CidadeId",
            table: "Pessoas",
            column: "Id_Cidade");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cidades");

            migrationBuilder.DropTable(
                name: "Pessoas");
        }
    }
}
