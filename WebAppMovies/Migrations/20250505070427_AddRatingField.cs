﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppMovies.Migrations
{
    /// <inheritdoc />
    public partial class AddRatingField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Rating",
                table: "Movie",
                type: "TEXT",
                nullable: false,
                defaultValue: "R");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Movie");
        }
    }
}
