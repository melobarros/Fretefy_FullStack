using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fretefy.Test.Infra.EntityFramework.Migrations
{
    public partial class AddedRegiao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("0a8248d1-3b62-4fb7-afc8-955b1c8ebc61"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("0a8e109c-ee00-40d6-9a01-040618746f2f"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("18e191f0-eef9-4451-bea1-de5f78d125f8"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("439a8192-2f0f-43a7-8a2c-ee9bbbd6c4d3"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("46698f17-4273-4e5c-a56d-dda97d426f26"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("4b4077ab-47f7-44b6-bf44-56f03ca18532"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("588c12b7-703c-4944-b5ba-0fbed191eb02"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("596df90c-e617-45cb-be33-826801519e46"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("653fcdce-73b1-47ac-9e98-a5380bec8788"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("6756d8f6-3f78-4886-91dd-e4753f9e72bc"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("6ab3cbd8-bcdf-4287-bee3-5885fb656d08"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("72b8cfd2-617d-435e-8f79-6e6e46aac155"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("784647e2-5430-459e-898b-4c915ee4b412"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("7d73f17e-90d6-4230-a391-31520365ca67"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("a3fc3b39-3c3c-4a58-8c50-fdd19209777f"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("a71ac957-1859-49b7-aa65-cc9327f4a3ce"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("afc12ff5-eacd-420a-835a-69e9b3b7821c"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("bb824c5c-a427-4a95-a7b4-f8183f3f8e94"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("c04bb270-65a7-4577-bd4c-631fa931d0e2"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("c215fc2e-bcda-4404-8efb-4b23c4433c5b"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("dc5ff91b-68d1-4759-9dba-4ade4bd4740d"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("e3dcbced-4326-4007-94df-c33f8c77a204"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("e7d03670-5d06-40dd-a4d8-41c4fe49a994"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("ec209ffa-37ea-4587-8bc6-8afe7cd00042"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("ec8390ca-f9a5-4a9e-9654-9405ccbabc7c"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("eff2ddee-6df9-4d52-80b7-1e4b1164e343"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("f8e6890f-e0d0-46ec-8f34-292de4b1f83b"));

            migrationBuilder.AddColumn<Guid>(
                name: "RegiaoId",
                table: "Cidade",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Regiao",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Ativa = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regiao", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("e6002033-7d57-41c9-a992-7e93ac10bce9"), "Rio Branco", null, "AC" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("43deea57-3a96-416c-81c7-48269e0e915a"), "São Paulo", null, "SP" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("1d4ffda6-e398-4956-b4d5-37f61b2e8fb1"), "Florianópolis", null, "SC" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("0da7d52b-2bf6-46c9-94d0-8a1f9000f414"), "Boa Vista", null, "RR" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("566bc5fb-d2bd-40ed-a3f6-e2234471f3eb"), "Porto Velho", null, "RO" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("07ff9f25-206c-4686-8dae-9f84666dad06"), "Porto Alegre", null, "RS" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("d686e62e-d2a4-473c-91f3-73690382564a"), "Natal", null, "RN" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("485cc758-bb5a-466e-bdd0-78a64b40e493"), "Rio de Janeiro", null, "RJ" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("602e7a0e-e829-443a-a5e7-7ab36073b70d"), "Teresina", null, "PI" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("c507ed5f-1118-44fe-bb78-dee9185e8dd2"), "Recife", null, "PE" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("0b1f31d5-76e1-4706-9508-877c6f11c7ab"), "Curitiba", null, "PR" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("971be917-d736-4f84-82f0-218a12dcaac7"), "João Pessoa", null, "PB" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("577546fa-40f9-4723-bc61-e8f1a29eff76"), "Aracaju", null, "SE" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("e73090b6-fee4-43cf-a13a-59cce8fba8fd"), "Belém", null, "PA" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("0190bb4b-4b97-4fd2-9270-33116a7a8865"), "Campo Grande", null, "MS" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("1f7a952d-9e2f-4dca-8e04-f3180e3234a1"), "Cuiabá", null, "MT" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("584e5a70-ba33-4f40-a7b7-8774710bee7b"), "São Luís", null, "MA" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("a3eb023b-8ae6-4ce8-aea8-6889083cee3a"), "Goiânia", null, "GO" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("0592898c-f2d5-4a12-a53a-28dfc5cae829"), "Vitória", null, "ES" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("ddd2c0bd-fa06-49a6-b06f-2f47ea12f728"), "Brasília", null, "DF" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("e1b60a4a-4790-4665-bfb9-9391823831c3"), "Fortaleza", null, " CE" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("81c1c5ac-5402-49a1-983b-6974b6bfff5d"), "Salvador", null, "BA" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("d15add3c-924a-4a20-b5eb-900cd2fcb3d1"), "Manaus", null, "AM" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("847a8090-9a89-4a9b-ac2b-514fb2a1b165"), "Macapá", null, "AP" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("760f49e6-68e6-4ca3-90d7-09e7dc208279"), "Maceió", null, "AL" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("1f5b9162-e38d-4b2a-9594-a8ae3f05eb00"), "Belo Horizonte", null, "MG" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("5b358b41-d88e-412e-ae5a-691a7df1ee24"), "Palmas", null, "TO" });

            migrationBuilder.CreateIndex(
                name: "IX_Cidade_RegiaoId",
                table: "Cidade",
                column: "RegiaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Regiao_Nome",
                table: "Regiao",
                column: "Nome",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cidade_Regiao_RegiaoId",
                table: "Cidade",
                column: "RegiaoId",
                principalTable: "Regiao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cidade_Regiao_RegiaoId",
                table: "Cidade");

            migrationBuilder.DropTable(
                name: "Regiao");

            migrationBuilder.DropIndex(
                name: "IX_Cidade_RegiaoId",
                table: "Cidade");

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("0190bb4b-4b97-4fd2-9270-33116a7a8865"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("0592898c-f2d5-4a12-a53a-28dfc5cae829"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("07ff9f25-206c-4686-8dae-9f84666dad06"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("0b1f31d5-76e1-4706-9508-877c6f11c7ab"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("0da7d52b-2bf6-46c9-94d0-8a1f9000f414"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("1d4ffda6-e398-4956-b4d5-37f61b2e8fb1"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("1f5b9162-e38d-4b2a-9594-a8ae3f05eb00"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("1f7a952d-9e2f-4dca-8e04-f3180e3234a1"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("43deea57-3a96-416c-81c7-48269e0e915a"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("485cc758-bb5a-466e-bdd0-78a64b40e493"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("566bc5fb-d2bd-40ed-a3f6-e2234471f3eb"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("577546fa-40f9-4723-bc61-e8f1a29eff76"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("584e5a70-ba33-4f40-a7b7-8774710bee7b"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("5b358b41-d88e-412e-ae5a-691a7df1ee24"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("602e7a0e-e829-443a-a5e7-7ab36073b70d"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("760f49e6-68e6-4ca3-90d7-09e7dc208279"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("81c1c5ac-5402-49a1-983b-6974b6bfff5d"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("847a8090-9a89-4a9b-ac2b-514fb2a1b165"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("971be917-d736-4f84-82f0-218a12dcaac7"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("a3eb023b-8ae6-4ce8-aea8-6889083cee3a"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("c507ed5f-1118-44fe-bb78-dee9185e8dd2"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("d15add3c-924a-4a20-b5eb-900cd2fcb3d1"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("d686e62e-d2a4-473c-91f3-73690382564a"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("ddd2c0bd-fa06-49a6-b06f-2f47ea12f728"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("e1b60a4a-4790-4665-bfb9-9391823831c3"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("e6002033-7d57-41c9-a992-7e93ac10bce9"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("e73090b6-fee4-43cf-a13a-59cce8fba8fd"));

            migrationBuilder.DropColumn(
                name: "RegiaoId",
                table: "Cidade");

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("afc12ff5-eacd-420a-835a-69e9b3b7821c"), "Rio Branco", "AC" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("c215fc2e-bcda-4404-8efb-4b23c4433c5b"), "São Paulo", "SP" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("a71ac957-1859-49b7-aa65-cc9327f4a3ce"), "Florianópolis", "SC" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("c04bb270-65a7-4577-bd4c-631fa931d0e2"), "Boa Vista", "RR" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("0a8248d1-3b62-4fb7-afc8-955b1c8ebc61"), "Porto Velho", "RO" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("ec209ffa-37ea-4587-8bc6-8afe7cd00042"), "Porto Alegre", "RS" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("f8e6890f-e0d0-46ec-8f34-292de4b1f83b"), "Natal", "RN" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("6756d8f6-3f78-4886-91dd-e4753f9e72bc"), "Rio de Janeiro", "RJ" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("0a8e109c-ee00-40d6-9a01-040618746f2f"), "Teresina", "PI" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("653fcdce-73b1-47ac-9e98-a5380bec8788"), "Recife", "PE" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("dc5ff91b-68d1-4759-9dba-4ade4bd4740d"), "Curitiba", "PR" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("eff2ddee-6df9-4d52-80b7-1e4b1164e343"), "João Pessoa", "PB" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("7d73f17e-90d6-4230-a391-31520365ca67"), "Aracaju", "SE" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("e7d03670-5d06-40dd-a4d8-41c4fe49a994"), "Belém", "PA" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("72b8cfd2-617d-435e-8f79-6e6e46aac155"), "Campo Grande", "MS" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("588c12b7-703c-4944-b5ba-0fbed191eb02"), "Cuiabá", "MT" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("18e191f0-eef9-4451-bea1-de5f78d125f8"), "São Luís", "MA" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("bb824c5c-a427-4a95-a7b4-f8183f3f8e94"), "Goiânia", "GO" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("439a8192-2f0f-43a7-8a2c-ee9bbbd6c4d3"), "Vitória", "ES" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("46698f17-4273-4e5c-a56d-dda97d426f26"), "Brasília", "DF" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("e3dcbced-4326-4007-94df-c33f8c77a204"), "Fortaleza", " CE" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("784647e2-5430-459e-898b-4c915ee4b412"), "Salvador", "BA" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("596df90c-e617-45cb-be33-826801519e46"), "Manaus", "AM" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("ec8390ca-f9a5-4a9e-9654-9405ccbabc7c"), "Macapá", "AP" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("a3fc3b39-3c3c-4a58-8c50-fdd19209777f"), "Maceió", "AL" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("4b4077ab-47f7-44b6-bf44-56f03ca18532"), "Belo Horizonte", "MG" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("6ab3cbd8-bcdf-4287-bee3-5885fb656d08"), "Palmas", "TO" });
        }
    }
}
