﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlgeriaConfirmedFlight.API.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Compagnie",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compagnie", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VolComfirme",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    CompagnieId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VilleDepart = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VilleArrivee = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateFin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    JourDeVol = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VolComfirme", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VolComfirme_Compagnie_CompagnieId",
                        column: x => x.CompagnieId,
                        principalTable: "Compagnie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VolComfirme_CompagnieId",
                table: "VolComfirme",
                column: "CompagnieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VolComfirme");

            migrationBuilder.DropTable(
                name: "Compagnie");
        }
    }
}
