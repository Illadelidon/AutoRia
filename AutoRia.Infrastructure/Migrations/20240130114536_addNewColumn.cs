﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoRia.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addNewColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MainImage",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MainImage",
                table: "Posts");
        }
    }
}
