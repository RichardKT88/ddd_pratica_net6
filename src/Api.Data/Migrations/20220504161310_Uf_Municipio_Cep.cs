using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class Uf_Municipio_Cep : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c2433ccc-787e-4cb7-9ce8-e7df5cd10787"));

            migrationBuilder.CreateTable(
                name: "Uf",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Sigla = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nome = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreateAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uf", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Municipio",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Nome = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CodIBGE = table.Column<int>(type: "int", nullable: false),
                    UfId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreateAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Municipio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Municipio_Uf_UfId",
                        column: x => x.UfId,
                        principalTable: "Uf",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cep",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Cep = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Logradouro = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Numero = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MunicipioId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreateAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cep", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cep_Municipio_MunicipioId",
                        column: x => x.MunicipioId,
                        principalTable: "Municipio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Uf",
                columns: new[] { "Id", "CreateAt", "Nome", "Sigla", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("1109ab04-a3a5-476e-bdce-6c3e2c2badee"), new DateTime(2022, 5, 4, 16, 13, 10, 302, DateTimeKind.Utc).AddTicks(392), "Paraíba", "PB", null },
                    { new Guid("1dd25850-6270-48f8-8b77-2f0f079480ab"), new DateTime(2022, 5, 4, 16, 13, 10, 302, DateTimeKind.Utc).AddTicks(396), "Paraná", "PR", null },
                    { new Guid("22ffbd18-cdb9-45cc-97b0-51e97700bf71"), new DateTime(2022, 5, 4, 16, 13, 10, 302, DateTimeKind.Utc).AddTicks(373), "Acre", "AC", null },
                    { new Guid("27f7a92b-1979-4e1c-be9d-cd3bb73552a8"), new DateTime(2022, 5, 4, 16, 13, 10, 302, DateTimeKind.Utc).AddTicks(388), "Minas Gerais", "MG", null },
                    { new Guid("29eec4d3-b061-427d-894f-7f0fecc7f65f"), new DateTime(2022, 5, 4, 16, 13, 10, 302, DateTimeKind.Utc).AddTicks(390), "Mato Grosso", "MT", null },
                    { new Guid("3739969c-fd8a-4411-9faa-3f718ca85e70"), new DateTime(2022, 5, 4, 16, 13, 10, 302, DateTimeKind.Utc).AddTicks(389), "Mato Grosso do Sul", "MS", null },
                    { new Guid("409b9043-88a4-4e86-9cca-ca1fb0d0d35b"), new DateTime(2022, 5, 4, 16, 13, 10, 302, DateTimeKind.Utc).AddTicks(379), "Amapá", "AP", null },
                    { new Guid("43a0f783-a042-4c46-8688-5dd4489d2ec7"), new DateTime(2022, 5, 4, 16, 13, 10, 302, DateTimeKind.Utc).AddTicks(397), "Rio de Janeiro", "RJ", null },
                    { new Guid("542668d1-50ba-4fca-bbc3-4b27af108ea3"), new DateTime(2022, 5, 4, 16, 13, 10, 302, DateTimeKind.Utc).AddTicks(398), "Rio Grande do Norte", "RN", null },
                    { new Guid("57a9e9f7-9aea-40fe-a783-65d4feb59fa8"), new DateTime(2022, 5, 4, 16, 13, 10, 302, DateTimeKind.Utc).AddTicks(386), "Maranhão", "MA", null },
                    { new Guid("5abca453-d035-4766-a81b-9f73d683a54b"), new DateTime(2022, 5, 4, 16, 13, 10, 302, DateTimeKind.Utc).AddTicks(380), "Bahia", "BA", null },
                    { new Guid("5ff1b59e-11e7-414d-827e-609dc5f7e333"), new DateTime(2022, 5, 4, 16, 13, 10, 302, DateTimeKind.Utc).AddTicks(382), "Ceará", "CE", null },
                    { new Guid("7cc33300-586e-4be8-9a4d-bd9f01ee9ad8"), new DateTime(2022, 5, 4, 16, 13, 10, 302, DateTimeKind.Utc).AddTicks(375), "Alagoas", "AL", null },
                    { new Guid("837a64d3-c649-4172-a4e0-2b20d3c85224"), new DateTime(2022, 5, 4, 16, 13, 10, 302, DateTimeKind.Utc).AddTicks(385), "Goiás", "GO", null },
                    { new Guid("8411e9bc-d3b2-4a9b-9d15-78633d64fc7c"), new DateTime(2022, 5, 4, 16, 13, 10, 302, DateTimeKind.Utc).AddTicks(391), "Pará", "PA", null },
                    { new Guid("88970a32-3a2a-4a95-8a18-2087b65f59d1"), new DateTime(2022, 5, 4, 16, 13, 10, 302, DateTimeKind.Utc).AddTicks(403), "Rio Grande do Sul", "RS", null },
                    { new Guid("924e7250-7d39-4e8b-86bf-a8578cbf4002"), new DateTime(2022, 5, 4, 16, 13, 10, 302, DateTimeKind.Utc).AddTicks(400), "Rondônia", "RO", null },
                    { new Guid("971dcb34-86ea-4f92-989d-064f749e23c9"), new DateTime(2022, 5, 4, 16, 13, 10, 302, DateTimeKind.Utc).AddTicks(411), "Tocantins", "TO", null },
                    { new Guid("9fd3c97a-dc68-4af5-bc65-694cca0f2869"), new DateTime(2022, 5, 4, 16, 13, 10, 302, DateTimeKind.Utc).AddTicks(402), "Roraima", "RR", null },
                    { new Guid("ad5969bd-82dc-4e23-ace2-d8495935dd2e"), new DateTime(2022, 5, 4, 16, 13, 10, 302, DateTimeKind.Utc).AddTicks(394), "Pernambuco", "PE", null },
                    { new Guid("b81f95e0-f226-4afd-9763-290001637ed4"), new DateTime(2022, 5, 4, 16, 13, 10, 302, DateTimeKind.Utc).AddTicks(404), "Santa Catarina", "SC", null },
                    { new Guid("bd08208b-bfca-47a4-9cd0-37e4e1fa5006"), new DateTime(2022, 5, 4, 16, 13, 10, 302, DateTimeKind.Utc).AddTicks(383), "Distrito Federal", "DF", null },
                    { new Guid("c623f804-37d8-4a19-92c1-67fd162862e6"), new DateTime(2022, 5, 4, 16, 13, 10, 302, DateTimeKind.Utc).AddTicks(384), "Espírito Santo", "ES", null },
                    { new Guid("cb9e6888-2094-45ee-bc44-37ced33c693a"), new DateTime(2022, 5, 4, 16, 13, 10, 302, DateTimeKind.Utc).AddTicks(377), "Amazonas", "AM", null },
                    { new Guid("e7e416de-477c-4fa3-a541-b5af5f35ccf6"), new DateTime(2022, 5, 4, 16, 13, 10, 302, DateTimeKind.Utc).AddTicks(406), "São Paulo", "SP", null },
                    { new Guid("f85a6cd0-2237-46b1-a103-d3494ab27774"), new DateTime(2022, 5, 4, 16, 13, 10, 302, DateTimeKind.Utc).AddTicks(395), "Piauí", "PI", null },
                    { new Guid("fe8ca516-034f-4249-bc5a-31c85ef220ea"), new DateTime(2022, 5, 4, 16, 13, 10, 302, DateTimeKind.Utc).AddTicks(405), "Sergipe", "SE", null }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreateAt", "Email", "Name", "UpdateAt" },
                values: new object[] { new Guid("a4c1e708-062f-4ac5-bb8a-8f348c51d171"), new DateTime(2022, 5, 4, 13, 13, 10, 302, DateTimeKind.Local).AddTicks(278), "admin@email.com", "Administrador", new DateTime(2022, 5, 4, 13, 13, 10, 302, DateTimeKind.Local).AddTicks(289) });

            migrationBuilder.CreateIndex(
                name: "IX_Cep_Cep",
                table: "Cep",
                column: "Cep",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cep_MunicipioId",
                table: "Cep",
                column: "MunicipioId");

            migrationBuilder.CreateIndex(
                name: "IX_Municipio_CodIBGE",
                table: "Municipio",
                column: "CodIBGE");

            migrationBuilder.CreateIndex(
                name: "IX_Municipio_UfId",
                table: "Municipio",
                column: "UfId");

            migrationBuilder.CreateIndex(
                name: "IX_Uf_Sigla",
                table: "Uf",
                column: "Sigla",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cep");

            migrationBuilder.DropTable(
                name: "Municipio");

            migrationBuilder.DropTable(
                name: "Uf");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a4c1e708-062f-4ac5-bb8a-8f348c51d171"));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreateAt", "Email", "Name", "UpdateAt" },
                values: new object[] { new Guid("c2433ccc-787e-4cb7-9ce8-e7df5cd10787"), new DateTime(2022, 4, 13, 18, 1, 33, 287, DateTimeKind.Local).AddTicks(4937), "admin@email.com", "Administrador", new DateTime(2022, 4, 13, 18, 1, 33, 287, DateTimeKind.Local).AddTicks(4946) });
        }
    }
}
