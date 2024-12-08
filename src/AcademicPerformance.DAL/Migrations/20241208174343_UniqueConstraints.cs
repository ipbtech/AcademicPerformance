using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcademicPerformance.DAL.Migrations
{
    /// <inheritdoc />
    public partial class UniqueConstraints : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Scores_StudentId",
                table: "Scores");

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 1,
                column: "ScoreValue",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 3,
                column: "ScoreValue",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 11,
                column: "ScoreValue",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 12,
                column: "ScoreValue",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 13,
                column: "ScoreValue",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 16,
                column: "ScoreValue",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 18,
                column: "ScoreValue",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 20,
                column: "ScoreValue",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 21,
                column: "ScoreValue",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 22,
                column: "ScoreValue",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 23,
                column: "ScoreValue",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 24,
                column: "ScoreValue",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 25,
                column: "ScoreValue",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 26,
                column: "ScoreValue",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 28,
                column: "ScoreValue",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 29,
                column: "ScoreValue",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 31,
                column: "ScoreValue",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 35,
                column: "ScoreValue",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 36,
                column: "ScoreValue",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 37,
                column: "ScoreValue",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 39,
                column: "ScoreValue",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 41,
                column: "ScoreValue",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 44,
                column: "ScoreValue",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 45,
                column: "ScoreValue",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 47,
                column: "ScoreValue",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 48,
                column: "ScoreValue",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 49,
                column: "ScoreValue",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 50,
                column: "ScoreValue",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 51,
                column: "ScoreValue",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 53,
                column: "ScoreValue",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 54,
                column: "ScoreValue",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 55,
                column: "ScoreValue",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 56,
                column: "ScoreValue",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 57,
                column: "ScoreValue",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 59,
                column: "ScoreValue",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 60,
                column: "ScoreValue",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 61,
                column: "ScoreValue",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 69,
                column: "ScoreValue",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 73,
                column: "ScoreValue",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 76,
                column: "ScoreValue",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 77,
                column: "ScoreValue",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 78,
                column: "ScoreValue",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 79,
                column: "ScoreValue",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 80,
                column: "ScoreValue",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 81,
                column: "ScoreValue",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 82,
                column: "ScoreValue",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 83,
                column: "ScoreValue",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 84,
                column: "ScoreValue",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 85,
                column: "ScoreValue",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 86,
                column: "ScoreValue",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 88,
                column: "ScoreValue",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 89,
                column: "ScoreValue",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 90,
                column: "ScoreValue",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 92,
                column: "ScoreValue",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 93,
                column: "ScoreValue",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 95,
                column: "ScoreValue",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 97,
                column: "ScoreValue",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 98,
                column: "ScoreValue",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 99,
                column: "ScoreValue",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 100,
                column: "ScoreValue",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 104,
                column: "ScoreValue",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 105,
                column: "ScoreValue",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 106,
                column: "ScoreValue",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 108,
                column: "ScoreValue",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 110,
                column: "ScoreValue",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 111,
                column: "ScoreValue",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 115,
                column: "ScoreValue",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 116,
                column: "ScoreValue",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 117,
                column: "ScoreValue",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 118,
                column: "ScoreValue",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 120,
                column: "ScoreValue",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 122,
                column: "ScoreValue",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 123,
                column: "ScoreValue",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 124,
                column: "ScoreValue",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 126,
                column: "ScoreValue",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 127,
                column: "ScoreValue",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 128,
                column: "ScoreValue",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 129,
                column: "ScoreValue",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 130,
                column: "ScoreValue",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 131,
                column: "ScoreValue",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 133,
                column: "ScoreValue",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2006, 11, 1, 3, 26, 54, 869, DateTimeKind.Local).AddTicks(1948));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "BirthDate",
                value: new DateTime(1995, 9, 17, 5, 11, 57, 651, DateTimeKind.Local).AddTicks(9559));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "BirthDate",
                value: new DateTime(1998, 1, 19, 17, 7, 8, 948, DateTimeKind.Local).AddTicks(6233));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "BirthDate",
                value: new DateTime(2002, 11, 10, 18, 18, 5, 178, DateTimeKind.Local).AddTicks(8548));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                column: "BirthDate",
                value: new DateTime(1996, 3, 12, 17, 34, 35, 38, DateTimeKind.Local).AddTicks(6932));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                column: "BirthDate",
                value: new DateTime(1999, 1, 8, 15, 4, 45, 445, DateTimeKind.Local).AddTicks(4523));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                column: "BirthDate",
                value: new DateTime(1997, 6, 30, 19, 27, 34, 973, DateTimeKind.Local).AddTicks(4087));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                column: "BirthDate",
                value: new DateTime(1994, 12, 21, 12, 51, 11, 712, DateTimeKind.Local).AddTicks(5837));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                column: "BirthDate",
                value: new DateTime(2005, 11, 24, 15, 24, 18, 107, DateTimeKind.Local).AddTicks(6267));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                column: "BirthDate",
                value: new DateTime(1997, 3, 8, 0, 12, 1, 74, DateTimeKind.Local).AddTicks(7629));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11,
                column: "BirthDate",
                value: new DateTime(2007, 1, 27, 1, 38, 49, 780, DateTimeKind.Local).AddTicks(8583));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 12,
                column: "BirthDate",
                value: new DateTime(1996, 6, 7, 12, 13, 23, 521, DateTimeKind.Local).AddTicks(4206));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 13,
                column: "BirthDate",
                value: new DateTime(2001, 6, 14, 2, 40, 59, 787, DateTimeKind.Local).AddTicks(2341));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 14,
                column: "BirthDate",
                value: new DateTime(2009, 2, 24, 2, 46, 10, 578, DateTimeKind.Local).AddTicks(8750));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 15,
                column: "BirthDate",
                value: new DateTime(2007, 1, 19, 11, 47, 56, 953, DateTimeKind.Local).AddTicks(8966));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 16,
                column: "BirthDate",
                value: new DateTime(2001, 1, 30, 15, 0, 3, 910, DateTimeKind.Local).AddTicks(6559));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 17,
                column: "BirthDate",
                value: new DateTime(2006, 2, 20, 10, 54, 57, 233, DateTimeKind.Local).AddTicks(9166));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 18,
                column: "BirthDate",
                value: new DateTime(2003, 9, 5, 21, 33, 12, 275, DateTimeKind.Local).AddTicks(1892));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 19,
                column: "BirthDate",
                value: new DateTime(1996, 12, 27, 15, 8, 5, 103, DateTimeKind.Local).AddTicks(326));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 20,
                column: "BirthDate",
                value: new DateTime(1996, 7, 21, 0, 26, 26, 273, DateTimeKind.Local).AddTicks(3430));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 21,
                column: "BirthDate",
                value: new DateTime(2004, 12, 27, 21, 57, 5, 890, DateTimeKind.Local).AddTicks(4034));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 22,
                column: "BirthDate",
                value: new DateTime(1995, 11, 9, 6, 42, 35, 107, DateTimeKind.Local).AddTicks(7391));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 23,
                column: "BirthDate",
                value: new DateTime(2008, 11, 4, 17, 6, 35, 368, DateTimeKind.Local).AddTicks(109));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 24,
                column: "BirthDate",
                value: new DateTime(2000, 9, 18, 13, 55, 22, 513, DateTimeKind.Local).AddTicks(8454));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 25,
                column: "BirthDate",
                value: new DateTime(1995, 1, 30, 19, 42, 5, 597, DateTimeKind.Local).AddTicks(8847));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 26,
                column: "BirthDate",
                value: new DateTime(2004, 4, 29, 16, 15, 21, 831, DateTimeKind.Local).AddTicks(7693));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 27,
                column: "BirthDate",
                value: new DateTime(2002, 3, 11, 14, 11, 43, 818, DateTimeKind.Local).AddTicks(1747));

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_Name",
                table: "Subjects",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_Name",
                table: "Students",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Scores_StudentId_SubjectId",
                table: "Scores",
                columns: new[] { "StudentId", "SubjectId" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Subjects_Name",
                table: "Subjects");

            migrationBuilder.DropIndex(
                name: "IX_Students_Name",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Scores_StudentId_SubjectId",
                table: "Scores");

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 1,
                column: "ScoreValue",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 3,
                column: "ScoreValue",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 11,
                column: "ScoreValue",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 12,
                column: "ScoreValue",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 13,
                column: "ScoreValue",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 16,
                column: "ScoreValue",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 18,
                column: "ScoreValue",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 20,
                column: "ScoreValue",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 21,
                column: "ScoreValue",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 22,
                column: "ScoreValue",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 23,
                column: "ScoreValue",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 24,
                column: "ScoreValue",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 25,
                column: "ScoreValue",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 26,
                column: "ScoreValue",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 28,
                column: "ScoreValue",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 29,
                column: "ScoreValue",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 31,
                column: "ScoreValue",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 35,
                column: "ScoreValue",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 36,
                column: "ScoreValue",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 37,
                column: "ScoreValue",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 39,
                column: "ScoreValue",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 41,
                column: "ScoreValue",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 44,
                column: "ScoreValue",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 45,
                column: "ScoreValue",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 47,
                column: "ScoreValue",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 48,
                column: "ScoreValue",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 49,
                column: "ScoreValue",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 50,
                column: "ScoreValue",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 51,
                column: "ScoreValue",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 53,
                column: "ScoreValue",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 54,
                column: "ScoreValue",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 55,
                column: "ScoreValue",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 56,
                column: "ScoreValue",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 57,
                column: "ScoreValue",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 59,
                column: "ScoreValue",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 60,
                column: "ScoreValue",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 61,
                column: "ScoreValue",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 69,
                column: "ScoreValue",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 73,
                column: "ScoreValue",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 76,
                column: "ScoreValue",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 77,
                column: "ScoreValue",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 78,
                column: "ScoreValue",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 79,
                column: "ScoreValue",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 80,
                column: "ScoreValue",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 81,
                column: "ScoreValue",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 82,
                column: "ScoreValue",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 83,
                column: "ScoreValue",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 84,
                column: "ScoreValue",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 85,
                column: "ScoreValue",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 86,
                column: "ScoreValue",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 88,
                column: "ScoreValue",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 89,
                column: "ScoreValue",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 90,
                column: "ScoreValue",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 92,
                column: "ScoreValue",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 93,
                column: "ScoreValue",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 95,
                column: "ScoreValue",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 97,
                column: "ScoreValue",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 98,
                column: "ScoreValue",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 99,
                column: "ScoreValue",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 100,
                column: "ScoreValue",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 104,
                column: "ScoreValue",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 105,
                column: "ScoreValue",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 106,
                column: "ScoreValue",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 108,
                column: "ScoreValue",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 110,
                column: "ScoreValue",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 111,
                column: "ScoreValue",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 115,
                column: "ScoreValue",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 116,
                column: "ScoreValue",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 117,
                column: "ScoreValue",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 118,
                column: "ScoreValue",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 120,
                column: "ScoreValue",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 122,
                column: "ScoreValue",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 123,
                column: "ScoreValue",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 124,
                column: "ScoreValue",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 126,
                column: "ScoreValue",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 127,
                column: "ScoreValue",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 128,
                column: "ScoreValue",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 129,
                column: "ScoreValue",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 130,
                column: "ScoreValue",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 131,
                column: "ScoreValue",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: 133,
                column: "ScoreValue",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2006, 10, 29, 19, 16, 13, 402, DateTimeKind.Local).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "BirthDate",
                value: new DateTime(1995, 9, 14, 21, 1, 16, 185, DateTimeKind.Local).AddTicks(877));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "BirthDate",
                value: new DateTime(1998, 1, 17, 8, 56, 27, 481, DateTimeKind.Local).AddTicks(7510));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "BirthDate",
                value: new DateTime(2002, 11, 8, 10, 7, 23, 711, DateTimeKind.Local).AddTicks(9802));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                column: "BirthDate",
                value: new DateTime(1996, 3, 10, 9, 23, 53, 571, DateTimeKind.Local).AddTicks(8052));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                column: "BirthDate",
                value: new DateTime(1999, 1, 6, 6, 54, 3, 978, DateTimeKind.Local).AddTicks(5612));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                column: "BirthDate",
                value: new DateTime(1997, 6, 28, 11, 16, 53, 506, DateTimeKind.Local).AddTicks(5156));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                column: "BirthDate",
                value: new DateTime(1994, 12, 19, 4, 40, 30, 245, DateTimeKind.Local).AddTicks(6886));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                column: "BirthDate",
                value: new DateTime(2005, 11, 22, 7, 13, 36, 640, DateTimeKind.Local).AddTicks(7293));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                column: "BirthDate",
                value: new DateTime(1997, 3, 5, 16, 1, 19, 607, DateTimeKind.Local).AddTicks(8507));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11,
                column: "BirthDate",
                value: new DateTime(2007, 1, 24, 17, 28, 8, 313, DateTimeKind.Local).AddTicks(9444));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 12,
                column: "BirthDate",
                value: new DateTime(1996, 6, 5, 4, 2, 42, 54, DateTimeKind.Local).AddTicks(5041));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 13,
                column: "BirthDate",
                value: new DateTime(2001, 6, 11, 18, 30, 18, 320, DateTimeKind.Local).AddTicks(3149));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 14,
                column: "BirthDate",
                value: new DateTime(2009, 2, 21, 18, 35, 29, 111, DateTimeKind.Local).AddTicks(9540));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 15,
                column: "BirthDate",
                value: new DateTime(2007, 1, 17, 3, 37, 15, 486, DateTimeKind.Local).AddTicks(9737));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 16,
                column: "BirthDate",
                value: new DateTime(2001, 1, 28, 6, 49, 22, 443, DateTimeKind.Local).AddTicks(7319));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 17,
                column: "BirthDate",
                value: new DateTime(2006, 2, 18, 2, 44, 15, 766, DateTimeKind.Local).AddTicks(9907));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 18,
                column: "BirthDate",
                value: new DateTime(2003, 9, 3, 13, 22, 30, 808, DateTimeKind.Local).AddTicks(2616));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 19,
                column: "BirthDate",
                value: new DateTime(1996, 12, 25, 6, 57, 23, 636, DateTimeKind.Local).AddTicks(1031));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 20,
                column: "BirthDate",
                value: new DateTime(1996, 7, 18, 16, 15, 44, 806, DateTimeKind.Local).AddTicks(4112));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 21,
                column: "BirthDate",
                value: new DateTime(2004, 12, 25, 13, 46, 24, 423, DateTimeKind.Local).AddTicks(4689));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 22,
                column: "BirthDate",
                value: new DateTime(1995, 11, 6, 22, 31, 53, 640, DateTimeKind.Local).AddTicks(8028));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 23,
                column: "BirthDate",
                value: new DateTime(2008, 11, 2, 8, 55, 53, 901, DateTimeKind.Local).AddTicks(729));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 24,
                column: "BirthDate",
                value: new DateTime(2000, 9, 16, 5, 44, 41, 46, DateTimeKind.Local).AddTicks(9051));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 25,
                column: "BirthDate",
                value: new DateTime(1995, 1, 28, 11, 31, 24, 130, DateTimeKind.Local).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 26,
                column: "BirthDate",
                value: new DateTime(2004, 4, 27, 8, 4, 40, 364, DateTimeKind.Local).AddTicks(8254));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 27,
                column: "BirthDate",
                value: new DateTime(2002, 3, 9, 6, 1, 2, 351, DateTimeKind.Local).AddTicks(2282));

            migrationBuilder.CreateIndex(
                name: "IX_Scores_StudentId",
                table: "Scores",
                column: "StudentId");
        }
    }
}
