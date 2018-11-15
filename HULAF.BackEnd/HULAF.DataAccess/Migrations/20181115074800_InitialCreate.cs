using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HULAF.DataAccess.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Characteristics",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ApproxHeight = table.Column<int>(nullable: false),
                    ApproxWeight = table.Column<int>(nullable: false),
                    HairColor = table.Column<int>(nullable: false),
                    EyeColor = table.Column<int>(nullable: false),
                    ApproxAgeMin = table.Column<int>(nullable: false),
                    ApproxAgeMax = table.Column<int>(nullable: false),
                    KnownNames = table.Column<List<string>>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characteristics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SeenLocation",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    City = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeenLocation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MissingPerson",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    LastSeenLocationId = table.Column<Guid>(nullable: true),
                    CharacteristicsId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MissingPerson", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MissingPerson_Characteristics_CharacteristicsId",
                        column: x => x.CharacteristicsId,
                        principalTable: "Characteristics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MissingPerson_SeenLocation_LastSeenLocationId",
                        column: x => x.LastSeenLocationId,
                        principalTable: "SeenLocation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MissingPerson_CharacteristicsId",
                table: "MissingPerson",
                column: "CharacteristicsId");

            migrationBuilder.CreateIndex(
                name: "IX_MissingPerson_LastSeenLocationId",
                table: "MissingPerson",
                column: "LastSeenLocationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MissingPerson");

            migrationBuilder.DropTable(
                name: "Characteristics");

            migrationBuilder.DropTable(
                name: "SeenLocation");
        }
    }
}
