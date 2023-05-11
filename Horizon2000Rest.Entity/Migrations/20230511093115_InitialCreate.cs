using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Horizon2000Rest.Entity.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Advert",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advert", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HouseNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HouseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Locality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VatNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ParentCourse",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TestConditions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkillCardCost = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParentCourse", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategory",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategory", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ScrollingText",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScrollText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScrollingText", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCard = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Postcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateRegistered = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Repair",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    Complaint = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Repair", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Repair_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NormalHour = table.Column<byte>(type: "tinyint", nullable: false),
                    NormalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RapidHour = table.Column<byte>(type: "tinyint", nullable: false),
                    RapidPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ParentCourseId = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Course_ParentCourse_ParentCourseId",
                        column: x => x.ParentCourseId,
                        principalTable: "ParentCourse",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Product_ProductCategory_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "ProductCategory",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentCourseSkillCard",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentCourseID = table.Column<int>(type: "int", nullable: false),
                    StudentID = table.Column<int>(type: "int", nullable: false),
                    SkillCard = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentCourseSkillCard", x => x.ID);
                    table.ForeignKey(
                        name: "FK_StudentCourseSkillCard_ParentCourse_ParentCourseID",
                        column: x => x.ParentCourseID,
                        principalTable: "ParentCourse",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentCourseSkillCard_Student_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Student",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserRole_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRole_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserSession",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Session = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateExpire = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSession", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserSession_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Schedule",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedule", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Schedule_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Booking",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScheduleId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    Paid = table.Column<bool>(type: "bit", nullable: false),
                    PaymentType = table.Column<short>(type: "smallint", nullable: true),
                    Complete = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    SkillCardNo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Booking_Schedule_ScheduleId",
                        column: x => x.ScheduleId,
                        principalTable: "Schedule",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Booking_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ParentCourse",
                columns: new[] { "ID", "DateCreated", "ImagePath", "IsActive", "Name", "SkillCardCost", "TestConditions" },
                values: new object[,]
                {
                    { 2, new DateTime(2023, 5, 11, 11, 31, 15, 412, DateTimeKind.Local).AddTicks(3782), "C:\\Images\\ECDL_logo.png", false, "ECDL Base & Standard", null, null },
                    { 4, new DateTime(2023, 5, 11, 11, 31, 15, 412, DateTimeKind.Local).AddTicks(3802), "C:\\Images\\ECDL_Logo.png", true, "ECDL Advanced", null, null },
                    { 5, new DateTime(2023, 5, 11, 11, 31, 15, 412, DateTimeKind.Local).AddTicks(3815), "C:\\Images\\Matsec.png", true, "Matsec", null, null },
                    { 6, new DateTime(2023, 5, 11, 11, 31, 15, 412, DateTimeKind.Local).AddTicks(3868), "C:\\\\Images\\icdl_logo.png", false, "ICDL", null, null }
                });

            migrationBuilder.InsertData(
                table: "ProductCategory",
                columns: new[] { "ID", "DateCreated", "IsActive", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 11, 9, 31, 15, 412, DateTimeKind.Utc).AddTicks(3884), true, "Mice" },
                    { 2, new DateTime(2023, 5, 11, 9, 31, 15, 412, DateTimeKind.Utc).AddTicks(3897), true, "Joysticks" },
                    { 3, new DateTime(2023, 5, 11, 9, 31, 15, 412, DateTimeKind.Utc).AddTicks(3907), true, "Cables" },
                    { 4, new DateTime(2023, 5, 11, 9, 31, 15, 412, DateTimeKind.Utc).AddTicks(3917), true, "Storage Media" },
                    { 5, new DateTime(2023, 5, 11, 9, 31, 15, 412, DateTimeKind.Utc).AddTicks(3926), true, "Routers" },
                    { 6, new DateTime(2023, 5, 11, 9, 31, 15, 412, DateTimeKind.Utc).AddTicks(3937), true, "UPS" },
                    { 7, new DateTime(2023, 5, 11, 9, 31, 15, 412, DateTimeKind.Utc).AddTicks(3946), true, "Hubs" },
                    { 1002, new DateTime(2023, 5, 11, 9, 31, 15, 412, DateTimeKind.Utc).AddTicks(3955), false, "Mice" },
                    { 1003, new DateTime(2023, 5, 11, 9, 31, 15, 412, DateTimeKind.Utc).AddTicks(3964), false, "Mice" },
                    { 1004, new DateTime(2023, 5, 11, 9, 31, 15, 412, DateTimeKind.Utc).AddTicks(3974), false, "Mice" },
                    { 1005, new DateTime(2023, 5, 11, 9, 31, 15, 412, DateTimeKind.Utc).AddTicks(3984), true, "Laptops" },
                    { 1006, new DateTime(2023, 5, 11, 9, 31, 15, 412, DateTimeKind.Utc).AddTicks(3993), true, "Towers (CPU)" },
                    { 1007, new DateTime(2023, 5, 11, 9, 31, 15, 412, DateTimeKind.Utc).AddTicks(4002), true, "Tablets" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "User" }
                });

            migrationBuilder.InsertData(
                table: "ScrollingText",
                columns: new[] { "ID", "Active", "DateCreated", "ScrollText" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2023, 5, 11, 9, 31, 15, 412, DateTimeKind.Utc).AddTicks(4040), "Website still in progress..." },
                    { 2, true, new DateTime(2023, 5, 11, 9, 31, 15, 412, DateTimeKind.Utc).AddTicks(4052), "BACK TO SCHOOL:  MATSEC COMPUTING starting 15th October 2020;  ECDL Standard and Advanced ECDL starting on 28th October 2020 " },
                    { 3, true, new DateTime(2023, 5, 11, 9, 31, 15, 412, DateTimeKind.Utc).AddTicks(4064), "BACK TO SCHOOL:  MATSEC COMPUTING starting 15th October 2020;  ECDL Standard and Advanced ECDL starting on 28th October 2020; A+Computer Technician starting on 3rd November 2020.......BOOK Now call us on 79462236 or email horizon2000computers@gmail.com " },
                    { 4, true, new DateTime(2023, 5, 11, 9, 31, 15, 412, DateTimeKind.Utc).AddTicks(4075), "BACK TO SCHOOL:  MATSEC COMPUTING starting 15th October 2020;  ECDL Standard and Advanced ECDL starting on 28th October 2020; A+Computer Technician starting on 3rd November 2020.......BOOK Now call us on 79462236 or email horizon2000computers@gmail.com " },
                    { 5, true, new DateTime(2023, 5, 11, 9, 31, 15, 412, DateTimeKind.Utc).AddTicks(4084), "BACK TO SCHOOL:  MATSEC COMPUTING starting 15th October 2020;  ECDL Standard and Advanced ECDL starting on 28th October 2020; A+Computer Technician starting on 3rd November 2020.......BOOK Now call us on 79462236 or email horizon2000computers@gmail.com " },
                    { 6, true, new DateTime(2023, 5, 11, 9, 31, 15, 412, DateTimeKind.Utc).AddTicks(4094), "New courses ECDL Standard and ECDL Advanced......BOOK Now call us on 79462236 or email horizon2000computers@gmail.com " },
                    { 7, true, new DateTime(2023, 5, 11, 9, 31, 15, 412, DateTimeKind.Utc).AddTicks(4104), "New courses ECDL Standard and ECDL Advanced......BOOK Now call us on 79462236 or email horizon2000computers@gmail.com " },
                    { 8, true, new DateTime(2023, 5, 11, 9, 31, 15, 412, DateTimeKind.Utc).AddTicks(4114), "New courses ECDL Standard and ECDL Advanced......BOOK Now call us on 79462236 or email horizon2000computers@gmail.com     We wish a Happy New Year 2021 for all our customers, please note that we are operating in full at 94, Triq De Rohan, Haz-Zebbug" },
                    { 9, true, new DateTime(2023, 5, 11, 9, 31, 15, 412, DateTimeKind.Utc).AddTicks(4124), "New courses ECDL Standard and ECDL Advanced......BOOK Now call us on 79462236 or email horizon2000computers@gmail.com     We wish a Happy New Year 2021 for all our customers, please note that we are operating in full at 94, Triq De Rohan, Haz-Zebbug" },
                    { 1008, true, new DateTime(2023, 5, 11, 9, 31, 15, 412, DateTimeKind.Utc).AddTicks(4135), "New courses ECDL Standard and ECDL Advanced......BOOK Now call us on 79462236 or email horizon2000computers@gmail.com     We are fully in operation from  94, TRIQ DE ROHAN, HAZ-ZEBBUG (near the Boys Museum Triq De Rohan, Haz-Zebbug)" },
                    { 1009, true, new DateTime(2023, 5, 11, 9, 31, 15, 412, DateTimeKind.Utc).AddTicks(4145), "New courses ECDL Standard and ECDL Advanced......BOOK Now call us on 79462236 or email horizon2000computers@gmail.com     We are fully in operation from  94, TRIQ DE ROHAN, HAZ-ZEBBUG (near the Boys Museum Triq De Rohan, Haz-Zebbug) Opening Hours from 4pm - 7pm Mon - Fri and Sat from 9am - 12pm" },
                    { 1010, true, new DateTime(2023, 5, 11, 9, 31, 15, 412, DateTimeKind.Utc).AddTicks(4155), "New courses ECDL Standard and ECDL Advanced......BOOK Now call us on 2146 22 36 or 79462236 or email horizon2000computers@gmail.com     We are fully in operation from  94, TRIQ DE ROHAN, HAZ-ZEBBUG (near the Boys Museum Triq De Rohan, Haz-Zebbug) Opening Hours from 4pm - 7pm Mon - Fri and Sat from 9am - 12pm" },
                    { 1011, true, new DateTime(2023, 5, 11, 9, 31, 15, 412, DateTimeKind.Utc).AddTicks(4222), "New courses ECDL Standard and ECDL Advanced......BOOK Now call us on 2146 22 36 or 79462236 or email horizon2000computers@gmail.com     We are fully in operation from  HORIZON 2000 Computer Training Centre, TRIQ DE ROHAN, HAZ-ZEBBUG (near the Boys Museum Triq De Rohan, Haz-Zebbug) Opening Hours from 4pm - 7pm Mon - Fri and Sat from 9am - 12pm" },
                    { 1012, true, new DateTime(2023, 5, 11, 9, 31, 15, 412, DateTimeKind.Utc).AddTicks(4233), "New courses ECDL Standard and ECDL Advanced......BOOK Now call us on 2146 22 36 or 79462236 or email horizon2000computers@gmail.com      HORIZON 2000 Computer Training Centre, TRIQ DE ROHAN, HAZ-ZEBBUG (near the Boys Museum Triq De Rohan, Haz-Zebbug) Opening Hours from 4pm - 7pm Mon - Fri and Sat from 9am - 12pm" },
                    { 1013, true, new DateTime(2023, 5, 11, 9, 31, 15, 412, DateTimeKind.Utc).AddTicks(4243), "New courses ECDL Standard and ECDL Advanced......BOOK Now call us on 2146 22 36 or 79462236 or email horizon2000computers@gmail.com  -------    HORIZON 2000 Computer Training Centre, TRIQ DE ROHAN, HAZ-ZEBBUG (near the Boys Museum Haz-Zebbug) Opening Hours from 10am - 7pm Mon - Fri and Sat from 9am - 12pm" },
                    { 1014, true, new DateTime(2023, 5, 11, 9, 31, 15, 412, DateTimeKind.Utc).AddTicks(4254), "New courses ICDL Standard and ICDL Advanced......BOOK Now call us on 2146 22 36 or 79462236 or email horizon2000computers@gmail.com  -------    HORIZON 2000 Computer Training Centre, TRIQ DE ROHAN, HAZ-ZEBBUG (near the Boys Museum Haz-Zebbug) Opening Hours from 10am - 7pm Mon - Fri and Sat from 9am - 12pm                      STARTING ON 16/08/2022 ICDL Advanced course Booking open" },
                    { 1015, true, new DateTime(2023, 5, 11, 9, 31, 15, 412, DateTimeKind.Utc).AddTicks(4264), "New courses ICDL Standard and ICDL Advanced......BOOK Now call us on 2146 22 36 or 79462236 or email horizon2000computers@gmail.com  -------    HORIZON 2000 Computer Training Centre, TRIQ DE ROHAN, HAZ-ZEBBUG (near the Boys Museum Haz-Zebbug) Opening Hours from 10am - 7pm Mon - Fri and Sat from 9am - 12pm                      STARTING ON 16/08/2022 ICDL Advanced course Booking open" },
                    { 2014, true, new DateTime(2023, 5, 11, 9, 31, 15, 412, DateTimeKind.Utc).AddTicks(4275), "New courses ICDL Standard and ICDL Advanced......BOOK Now call us on 2146 22 36 or 79462236 or email horizon2000computers@gmail.com  -------    HORIZON 2000 Computer Training Centre, TRIQ DE ROHAN, HAZ-ZEBBUG (near the Boys Museum Haz-Zebbug) Opening Hours from 10am - 7pm Mon - Fri and Sat from 9am - 12pm         BACK TO SCHOOL Winter Schedule lessons NOW AVAILABLE.......BOOK NOW" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "ID", "Active", "DateRegistered", "Email", "Name", "Password", "Surname", "Username" },
                values: new object[,]
                {
                    { 2, false, new DateTime(2023, 5, 11, 11, 31, 15, 412, DateTimeKind.Local).AddTicks(4288), "horizon2000computers@gmail.com", "Martin", "5F7C6C6AEC4B3C1930C473E2FAB6FA2450165F6BBBE4859698682C7670FC8DFDCE560CB51CCD07807F79F3AFB4AE87E5B2C6D2AFB941BE4DB985D1840FC7E05B", "Sultana", "MSULTANA" },
                    { 3, true, new DateTime(2023, 5, 11, 11, 31, 15, 412, DateTimeKind.Local).AddTicks(4300), "horizon2000support@gmail.com", "Antoine", "69C06F6AAC655F931E600F78BB2A6DF3DF6FBF782E074C0880137AC17BA50FBD7E8D50FF15698BD70A76B65BA6BC18EB523D2BA6815F8AF1B18E5E4DF976AA2E", "Schembri", "antoine" },
                    { 1002, true, new DateTime(2023, 5, 11, 11, 31, 15, 412, DateTimeKind.Local).AddTicks(4311), "horizon2000computers@gmail.com", "Martin", "E2DCA7EA23086019C94DEDB30BC3A262BD23B3DBE124FB828E144DDEC0C6F6CC7A139156EEB43EC4A0CA50093B9C90C9449C6ECE2AE5DA11898F280484151A97", "Sultana", "SultanaM" },
                    { 1003, false, new DateTime(2023, 5, 11, 11, 31, 15, 412, DateTimeKind.Local).AddTicks(4321), "horizon2000sales@gmail.com", "Abigail", "17B510A656C9B8D9A0FBF14172FE35E2CC18428D4DA605AA1F8BD1FC4D6F33828F817E977D832ED78D32D9057B6737113017B0BA03061DE341ED8691F1A14DBE", "Sultana", "sales" }
                });

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "ID", "Active", "DateCreated", "RoleId", "UserId" },
                values: new object[,]
                {
                    { 2, false, new DateTime(2023, 5, 11, 11, 31, 15, 412, DateTimeKind.Local).AddTicks(4336), 1, 2 },
                    { 3, true, new DateTime(2023, 5, 11, 11, 31, 15, 412, DateTimeKind.Local).AddTicks(4350), 1, 3 },
                    { 1002, true, new DateTime(2023, 5, 11, 11, 31, 15, 412, DateTimeKind.Local).AddTicks(4361), 1, 1002 },
                    { 1003, true, new DateTime(2023, 5, 11, 11, 31, 15, 412, DateTimeKind.Local).AddTicks(4373), 1, 1003 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Booking_ScheduleId",
                table: "Booking",
                column: "ScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_StudentId",
                table: "Booking",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Course_ParentCourseId",
                table: "Course",
                column: "ParentCourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryID",
                table: "Product",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Repair_ClientId",
                table: "Repair",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedule_CourseId",
                table: "Schedule",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourseSkillCard_ParentCourseID",
                table: "StudentCourseSkillCard",
                column: "ParentCourseID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourseSkillCard_StudentID",
                table: "StudentCourseSkillCard",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_RoleId",
                table: "UserRole",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_UserId",
                table: "UserRole",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSession_UserId",
                table: "UserSession",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Advert");

            migrationBuilder.DropTable(
                name: "Booking");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Repair");

            migrationBuilder.DropTable(
                name: "ScrollingText");

            migrationBuilder.DropTable(
                name: "StudentCourseSkillCard");

            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.DropTable(
                name: "UserSession");

            migrationBuilder.DropTable(
                name: "Schedule");

            migrationBuilder.DropTable(
                name: "ProductCategory");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropTable(
                name: "ParentCourse");
        }
    }
}
