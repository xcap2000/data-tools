﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarpeDiem.DataTools.Tasks.Contexts.Migrations.Sqlite
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable
            (
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table => table.PrimaryKey("PK_Tasks", x => x.Id)
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "Tasks");
        }
    }
}