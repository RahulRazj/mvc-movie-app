﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCMockDemo.Migrations
{
    public partial class addeddeletedflag : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Movies",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Movies");
        }
    }
}
