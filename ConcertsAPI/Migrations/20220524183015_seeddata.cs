using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConcertsAPI.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Genre",
                table: "Concerts");

            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "Concerts");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Places",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "ArtistName", "ContactEmail", "ContactPhoneNumber", "ManagerLastName", "ManagerName", "Nationality" },
                values: new object[,]
                {
                    { 1, "Nirvana", "dannyg@nirvana.com", "4647478", "Goldberg", "Danny", "American" },
                    { 2, "Kat Frankie", "carolj@manager.com", "31638268", "Jordan", "Carol", "Australian" },
                    { 3, "Tarkan", "benjamink@tarkan.com", "5646467", "Kaya", "Benjamin", "Turkish" }
                });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "AdressDetails", "City", "ContactEmail", "ContactPhoneNumber", "Country", "Name" },
                values: new object[,]
                {
                    { 1, "Visnezade, Dolmabahce No:1, 34357", "Istanbul", "management@vodafonearena.com", "12412422", "Turkey", "Vodafone Arena" },
                    { 2, "Peninsula Square, London SE10 0DX", "London", "management@o2arena.com", "12892422", "UK", "The O2 Arena" },
                    { 3, "2-3 Kitanomarukoen, Chiyoda City, Tokyo 102-8321", "Tokyo", "management@nipponbudokann.com", "398923221", "Japan", "Nippon Budokann" }
                });

            migrationBuilder.InsertData(
                table: "Concerts",
                columns: new[] { "Id", "ArtistId", "Date", "EventRules", "PlaceId", "PosterImageUrl", "TicketPrice" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "-There is 18 age limit.- Participants / viewers must follow the rules received under COVID-19.", 1, "", 240.0 },
                    { 2, 1, new DateTime(2022, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "-There is 18 age limit.- Participants / viewers must follow the rules received under COVID-19.", 2, "", 100.0 },
                    { 3, 2, new DateTime(2022, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "-There is 18 age limit.- Participants / viewers must follow the rules received under COVID-19.", 1, "", 150.0 },
                    { 4, 2, new DateTime(2022, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "-There is 18 age limit.- Participants / viewers must follow the rules received under COVID-19.", 3, "", 1000.0 },
                    { 5, 3, new DateTime(2022, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "-There is 18 age limit.- Participants / viewers must follow the rules received under COVID-19.", 1, "", 300.0 },
                    { 6, 3, new DateTime(2022, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "-There is 18 age limit.- Participants / viewers must follow the rules received under COVID-19.", 2, "", 530.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Places");

            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "Concerts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "Concerts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
