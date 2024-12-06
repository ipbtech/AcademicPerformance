using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AcademicPerformance.DAL.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "BirthDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2006, 10, 29, 19, 16, 13, 402, DateTimeKind.Local).AddTicks(4170), "Winfield Upton" },
                    { 2, new DateTime(1995, 9, 14, 21, 1, 16, 185, DateTimeKind.Local).AddTicks(877), "Randall Ritchie" },
                    { 3, new DateTime(1998, 1, 17, 8, 56, 27, 481, DateTimeKind.Local).AddTicks(7510), "Agustina Cormier" },
                    { 4, new DateTime(2002, 11, 8, 10, 7, 23, 711, DateTimeKind.Local).AddTicks(9802), "Lolita Vandervort" },
                    { 5, new DateTime(1996, 3, 10, 9, 23, 53, 571, DateTimeKind.Local).AddTicks(8052), "Claire Koepp" },
                    { 6, new DateTime(1999, 1, 6, 6, 54, 3, 978, DateTimeKind.Local).AddTicks(5612), "Rose Mann" },
                    { 7, new DateTime(1997, 6, 28, 11, 16, 53, 506, DateTimeKind.Local).AddTicks(5156), "Adalberto Weimann" },
                    { 8, new DateTime(1994, 12, 19, 4, 40, 30, 245, DateTimeKind.Local).AddTicks(6886), "Alberto Satterfield" },
                    { 9, new DateTime(2005, 11, 22, 7, 13, 36, 640, DateTimeKind.Local).AddTicks(7293), "Nico Nienow" },
                    { 10, new DateTime(1997, 3, 5, 16, 1, 19, 607, DateTimeKind.Local).AddTicks(8507), "Stefan Lebsack" },
                    { 11, new DateTime(2007, 1, 24, 17, 28, 8, 313, DateTimeKind.Local).AddTicks(9444), "Laurine Stehr" },
                    { 12, new DateTime(1996, 6, 5, 4, 2, 42, 54, DateTimeKind.Local).AddTicks(5041), "Antonina McLaughlin" },
                    { 13, new DateTime(2001, 6, 11, 18, 30, 18, 320, DateTimeKind.Local).AddTicks(3149), "Terrance DuBuque" },
                    { 14, new DateTime(2009, 2, 21, 18, 35, 29, 111, DateTimeKind.Local).AddTicks(9540), "Phoebe Waters" },
                    { 15, new DateTime(2007, 1, 17, 3, 37, 15, 486, DateTimeKind.Local).AddTicks(9737), "Jeramy Dickinson" },
                    { 16, new DateTime(2001, 1, 28, 6, 49, 22, 443, DateTimeKind.Local).AddTicks(7319), "Bessie Denesik" },
                    { 17, new DateTime(2006, 2, 18, 2, 44, 15, 766, DateTimeKind.Local).AddTicks(9907), "Carter Kris" },
                    { 18, new DateTime(2003, 9, 3, 13, 22, 30, 808, DateTimeKind.Local).AddTicks(2616), "Carissa Anderson" },
                    { 19, new DateTime(1996, 12, 25, 6, 57, 23, 636, DateTimeKind.Local).AddTicks(1031), "Renee Willms" },
                    { 20, new DateTime(1996, 7, 18, 16, 15, 44, 806, DateTimeKind.Local).AddTicks(4112), "Naomi Bednar" },
                    { 21, new DateTime(2004, 12, 25, 13, 46, 24, 423, DateTimeKind.Local).AddTicks(4689), "Franco Carroll" },
                    { 22, new DateTime(1995, 11, 6, 22, 31, 53, 640, DateTimeKind.Local).AddTicks(8028), "Amos Barton" },
                    { 23, new DateTime(2008, 11, 2, 8, 55, 53, 901, DateTimeKind.Local).AddTicks(729), "Myles Carroll" },
                    { 24, new DateTime(2000, 9, 16, 5, 44, 41, 46, DateTimeKind.Local).AddTicks(9051), "Winnifred Ward" },
                    { 25, new DateTime(1995, 1, 28, 11, 31, 24, 130, DateTimeKind.Local).AddTicks(9430), "Rosendo Ebert" },
                    { 26, new DateTime(2004, 4, 27, 8, 4, 40, 364, DateTimeKind.Local).AddTicks(8254), "Donna Lemke" },
                    { 27, new DateTime(2002, 3, 9, 6, 1, 2, 351, DateTimeKind.Local).AddTicks(2282), "Dejah Nitzsche" }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Math" },
                    { 2, "English" },
                    { 3, "IT" },
                    { 4, "Geography" },
                    { 5, "History" }
                });

            migrationBuilder.InsertData(
                table: "Scores",
                columns: new[] { "Id", "ScoreValue", "StudentId", "SubjectId" },
                values: new object[,]
                {
                    { 1, 3, 1, 1 },
                    { 2, 4, 1, 2 },
                    { 3, 2, 1, 3 },
                    { 4, 3, 1, 4 },
                    { 5, 3, 1, 5 },
                    { 6, 5, 2, 1 },
                    { 7, 2, 2, 2 },
                    { 8, 2, 2, 3 },
                    { 9, 4, 2, 4 },
                    { 10, 5, 2, 5 },
                    { 11, 2, 3, 1 },
                    { 12, 2, 3, 2 },
                    { 13, 3, 3, 3 },
                    { 14, 3, 3, 4 },
                    { 15, 5, 3, 5 },
                    { 16, 3, 4, 1 },
                    { 17, 3, 4, 2 },
                    { 18, 2, 4, 3 },
                    { 19, 4, 4, 4 },
                    { 20, 3, 4, 5 },
                    { 21, 2, 5, 1 },
                    { 22, 4, 5, 2 },
                    { 23, 2, 5, 3 },
                    { 24, 4, 5, 4 },
                    { 25, 3, 5, 5 },
                    { 26, 3, 6, 1 },
                    { 27, 5, 6, 2 },
                    { 28, 4, 6, 3 },
                    { 29, 4, 6, 4 },
                    { 30, 3, 6, 5 },
                    { 31, 4, 7, 1 },
                    { 32, 3, 7, 2 },
                    { 33, 3, 7, 3 },
                    { 34, 4, 7, 4 },
                    { 35, 2, 7, 5 },
                    { 36, 3, 8, 1 },
                    { 37, 4, 8, 2 },
                    { 38, 4, 8, 3 },
                    { 39, 4, 8, 4 },
                    { 40, 2, 8, 5 },
                    { 41, 4, 9, 1 },
                    { 42, 5, 9, 2 },
                    { 43, 2, 9, 3 },
                    { 44, 2, 9, 4 },
                    { 45, 5, 9, 5 },
                    { 46, 2, 10, 1 },
                    { 47, 4, 10, 2 },
                    { 48, 5, 10, 3 },
                    { 49, 2, 10, 4 },
                    { 50, 2, 10, 5 },
                    { 51, 2, 11, 1 },
                    { 52, 3, 11, 2 },
                    { 53, 4, 11, 3 },
                    { 54, 3, 11, 4 },
                    { 55, 3, 11, 5 },
                    { 56, 5, 12, 1 },
                    { 57, 4, 12, 2 },
                    { 58, 3, 12, 3 },
                    { 59, 2, 12, 4 },
                    { 60, 2, 12, 5 },
                    { 61, 2, 13, 1 },
                    { 62, 4, 13, 2 },
                    { 63, 4, 13, 3 },
                    { 64, 2, 13, 4 },
                    { 65, 3, 13, 5 },
                    { 66, 4, 14, 1 },
                    { 67, 4, 14, 2 },
                    { 68, 4, 14, 3 },
                    { 69, 3, 14, 4 },
                    { 70, 3, 14, 5 },
                    { 71, 4, 15, 1 },
                    { 72, 5, 15, 2 },
                    { 73, 4, 15, 3 },
                    { 74, 3, 15, 4 },
                    { 75, 5, 15, 5 },
                    { 76, 2, 16, 1 },
                    { 77, 3, 16, 2 },
                    { 78, 2, 16, 3 },
                    { 79, 5, 16, 4 },
                    { 80, 2, 16, 5 },
                    { 81, 5, 17, 1 },
                    { 82, 2, 17, 2 },
                    { 83, 3, 17, 3 },
                    { 84, 4, 17, 4 },
                    { 85, 3, 17, 5 },
                    { 86, 2, 18, 1 },
                    { 87, 5, 18, 2 },
                    { 88, 2, 18, 3 },
                    { 89, 3, 18, 4 },
                    { 90, 3, 18, 5 },
                    { 91, 5, 19, 1 },
                    { 92, 2, 19, 2 },
                    { 93, 4, 19, 3 },
                    { 94, 3, 19, 4 },
                    { 95, 2, 19, 5 },
                    { 96, 5, 20, 1 },
                    { 97, 2, 20, 2 },
                    { 98, 2, 20, 3 },
                    { 99, 4, 20, 4 },
                    { 100, 2, 20, 5 },
                    { 101, 3, 21, 1 },
                    { 102, 5, 21, 2 },
                    { 103, 3, 21, 3 },
                    { 104, 5, 21, 4 },
                    { 105, 3, 21, 5 },
                    { 106, 3, 22, 1 },
                    { 107, 5, 22, 2 },
                    { 108, 2, 22, 3 },
                    { 109, 3, 22, 4 },
                    { 110, 2, 22, 5 },
                    { 111, 4, 23, 1 },
                    { 112, 3, 23, 2 },
                    { 113, 4, 23, 3 },
                    { 114, 5, 23, 4 },
                    { 115, 3, 23, 5 },
                    { 116, 2, 24, 1 },
                    { 117, 3, 24, 2 },
                    { 118, 2, 24, 3 },
                    { 119, 5, 24, 4 },
                    { 120, 3, 24, 5 },
                    { 121, 4, 25, 1 },
                    { 122, 4, 25, 2 },
                    { 123, 3, 25, 3 },
                    { 124, 2, 25, 4 },
                    { 125, 4, 25, 5 },
                    { 126, 4, 26, 1 },
                    { 127, 3, 26, 2 },
                    { 128, 2, 26, 3 },
                    { 129, 3, 26, 4 },
                    { 130, 2, 26, 5 },
                    { 131, 2, 27, 1 },
                    { 132, 2, 27, 2 },
                    { 133, 4, 27, 3 },
                    { 134, 4, 27, 4 },
                    { 135, 4, 27, 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
