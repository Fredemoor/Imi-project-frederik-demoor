using Microsoft.EntityFrameworkCore.Migrations;
using System;

#nullable disable

namespace Imi.Project.Api.Infrastructure.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Birthdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HasApprovedTermsAndConditions = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Breeds",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AnimalBreed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Breeds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    IsFull = table.Column<bool>(type: "bit", nullable: false),
                    IsCleaned = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Medias",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", maxLength: 20, nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    BreedId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MediaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsFed = table.Column<bool>(type: "bit", nullable: false),
                    IsWalked = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Animals_Breeds_BreedId",
                        column: x => x.BreedId,
                        principalTable: "Breeds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Animals_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Animals_Medias_MediaId",
                        column: x => x.MediaId,
                        principalTable: "Medias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthdate", "ConcurrencyStamp", "Email", "EmailConfirmed", "HasApprovedTermsAndConditions", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "85d6a8c4-eca7-4b1d-88b6-3459187bc55a", 0, new DateTime(1920, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ca103527-9a0a-4930-a8f5-ab24faf6e25b", "user@imi.com", true, true, false, null, "USER@IMI.COM", "IMIUSER", "AQAAAAEAACcQAAAAEPhnhW3xEyuN+awEuni8S3jC3H5tjkkSKd9Q1oroU1f5yAkXVmk9z5t/gM/SMm7Ksg==", null, false, "3be7d480-12a2-49be-aedc-a16004f2259d", false, "ImiUser" },
                    { "88b2b517-2b35-40d8-8377-513a3b7abd68", 0, new DateTime(1920, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b680ff58-fa62-47cd-b4a1-f573ce877f67", "refuser@imi.com", true, false, false, null, "REFUSER@IMI.COM", "IMIREFUSER", "AQAAAAEAACcQAAAAEHa2BQJ9AuFu62GvtiUJXfbVlM8U18mWOIkFk9MW6Q4Yyv9RcH1LhtPMuCRgFWNiEA==", null, false, "9e05cbdc-b722-413d-806c-1ff5dd305ae2", false, "ImiRefuser" },
                    { "c858c98b-3c32-4c5d-a635-a26f42bbc177", 0, new DateTime(2000, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "0f9ef293-1f10-4927-9feb-35e95a7123fc", "admin@imi.com", true, true, false, null, "ADMIN@IMI.COM", "IMIADMIN", "AQAAAAEAACcQAAAAELzGjTtmNqXWy+ec6jhUv/QcS4oL6NlzIXo6M5VQsXpw94zjoZBNFipzPWtptyBRNw==", null, false, "8f31e384-cd4b-44f7-b738-a201c871647e", false, "ImiAdmin" }
                });

            migrationBuilder.InsertData(
                table: "Breeds",
                columns: new[] { "Id", "AnimalBreed", "CreatedDate", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0b311f69-59ea-4600-b3ad-d537a61d9752"), "Malteser", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1f38cd5d-8d4d-4a5b-9272-6c27ad85744e"), "Alaskan Malamute Dog", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1fc45bf0-f27d-4daf-9543-4ee985bef359"), "Podenco", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("25785be5-7771-4d26-9e48-71e93f09d01f"), "Australian Cattle dog", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4ad42c96-00d6-4bfd-8cb4-6e674aa6eb52"), "AKita inu", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9221c836-84b3-4628-837e-b40641542e96"), "American Cocker Spaniel", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a0a7ee73-9fa5-441e-a6ba-1e1c6195c38b"), "Labrador", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a19527f4-5630-4c81-b127-8bd76e5063db"), "Pincher", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d228b0cc-8fef-43da-a084-ee899e6ee763"), "Akita", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e4669f7d-f1f9-4fc0-ba66-05385fe3540d"), "Stafford", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Capacity", "CreatedDate", "IsCleaned", "IsFull", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("16610986-79f2-477d-bc39-e2fa61494e66"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, "Kennel 8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1a861a7c-ea87-4a29-9f2a-57d75cc5e643"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, "Kennel 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("344077d8-346d-4ba5-aa21-236061be3ebd"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, "Kennel 9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("397e120c-b602-4d3c-942f-0e40fc3f5dc8"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, "Kennel 1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5da3ce69-ea3c-4ce8-88de-391d803b6a76"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, "Kennel 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6b2846ac-8d70-439b-b557-5b5d7216908f"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, "Kennel 10", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7a34a55f-03f9-43d8-b8b5-aeb53873c07a"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, "Kennel 10", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b8669444-c84f-47d0-bd21-b97470bfd05e"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, "Kennel 7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c27bd595-3a25-4670-ae32-ac99717f59a7"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, "Kennel 4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e072526d-bc1c-413d-aaac-10beb42118d4"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, "Kennel 11", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e57acf2c-dfd1-4d5e-95cb-e6ea97862522"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, "Kennel 6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fcaf1783-1efe-42e0-8a0a-dc3e7c28667e"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, "Kennel 5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "CreatedDate", "ImageUrl", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("01ee01ce-0e13-4d86-a9b4-8735c826d3e7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Img/img9.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1938cc46-c18e-4018-afd8-cc175f02d7db"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Img/img10.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("299438ff-fa52-49f4-a9d5-278460e77484"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Img/img0.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4384690b-3798-41d5-9b1d-26d4f9937759"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Img/img6.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("67276207-3ea6-4249-aec3-e48a00c1630b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Img/img1.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("76f18402-f0f1-47fa-8a8b-49aee69d15e1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Img/img5.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7fe7642b-3496-4d51-9581-727cec5a54ec"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Img/img3.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a672c408-6e72-4028-8a09-a18145b92a62"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Img/img4.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d744dce4-e9cb-427e-b510-01853545ef4c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Img/img11.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dc4ad261-5613-4a30-a582-678f908cd095"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Img/img7.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ee7fe468-e7ae-4478-a797-dab258fa8053"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Img/img2.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f729b55c-e2b0-48fe-a2cb-18220b3fa9b0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Img/img8.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "BirthDate", "BreedId", "CreatedDate", "Description", "Gender", "IsFed", "IsWalked", "LocationId", "MediaId", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("12af35b5-a7b3-4e3a-ab06-ffcc952ba742"), new DateTime(2018, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1fc45bf0-f27d-4daf-9543-4ee985bef359"), new DateTime(2023, 1, 2, 19, 8, 25, 56, DateTimeKind.Utc).AddTicks(9207), "Zacht karaKter, redelijk schuw.", 0, false, false, new Guid("397e120c-b602-4d3c-942f-0e40fc3f5dc8"), new Guid("299438ff-fa52-49f4-a9d5-278460e77484"), "Chappie", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1f07e57e-7c72-4322-86dc-60e3faa03cba"), new DateTime(2018, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0b311f69-59ea-4600-b3ad-d537a61d9752"), new DateTime(2023, 1, 2, 19, 8, 25, 56, DateTimeKind.Utc).AddTicks(9212), "Speelse rakker, zeer energetisch.", 0, false, false, new Guid("c27bd595-3a25-4670-ae32-ac99717f59a7"), new Guid("7fe7642b-3496-4d51-9581-727cec5a54ec"), "Bobbie", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("208c0ca8-1e53-4a69-8171-6f067a704bdb"), new DateTime(2018, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9221c836-84b3-4628-837e-b40641542e96"), new DateTime(2023, 1, 2, 19, 8, 25, 56, DateTimeKind.Utc).AddTicks(9220), "Zacht karacter, redelijk schuw.", 0, false, false, new Guid("7a34a55f-03f9-43d8-b8b5-aeb53873c07a"), new Guid("01ee01ce-0e13-4d86-a9b4-8735c826d3e7"), "Sjonnie", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("35eed6d6-cdac-4675-9d86-f0e4ffd5a6e4"), new DateTime(2018, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("25785be5-7771-4d26-9e48-71e93f09d01f"), new DateTime(2023, 1, 2, 19, 8, 25, 56, DateTimeKind.Utc).AddTicks(9215), "Goede familie hond, fan van water polo.", 0, false, false, new Guid("e57acf2c-dfd1-4d5e-95cb-e6ea97862522"), new Guid("76f18402-f0f1-47fa-8a8b-49aee69d15e1"), "Marco", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("55fda0ff-7c42-4973-9f33-af3cdfb218d3"), new DateTime(2018, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1f38cd5d-8d4d-4a5b-9272-6c27ad85744e"), new DateTime(2023, 1, 2, 19, 8, 25, 56, DateTimeKind.Utc).AddTicks(9219), "Zacht karacter, redelijk schuw.", 1, false, false, new Guid("344077d8-346d-4ba5-aa21-236061be3ebd"), new Guid("f729b55c-e2b0-48fe-a2cb-18220b3fa9b0"), "Cindy", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("75c80a76-49d1-4d66-b885-ec2dfd106844"), new DateTime(2018, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d228b0cc-8fef-43da-a084-ee899e6ee763"), new DateTime(2023, 1, 2, 19, 8, 25, 56, DateTimeKind.Utc).AddTicks(9216), "Zacht karacter, redelijk schuw.", 0, false, false, new Guid("b8669444-c84f-47d0-bd21-b97470bfd05e"), new Guid("4384690b-3798-41d5-9b1d-26d4f9937759"), "Polo", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("decde536-e3a2-46ad-9392-4d030568e025"), new DateTime(2018, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a19527f4-5630-4c81-b127-8bd76e5063db"), new DateTime(2023, 1, 2, 19, 8, 25, 56, DateTimeKind.Utc).AddTicks(9209), "Zeer energetisch karakter", 1, false, false, new Guid("5da3ce69-ea3c-4ce8-88de-391d803b6a76"), new Guid("67276207-3ea6-4249-aec3-e48a00c1630b"), "Ozzy", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e939ddf0-331f-499c-9e86-8d8feaee8526"), new DateTime(2018, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a0a7ee73-9fa5-441e-a6ba-1e1c6195c38b"), new DateTime(2023, 1, 2, 19, 8, 25, 56, DateTimeKind.Utc).AddTicks(9211), "Niet voor beginnelingen, kan agressief zijn.", 0, false, false, new Guid("1a861a7c-ea87-4a29-9f2a-57d75cc5e643"), new Guid("ee7fe468-e7ae-4478-a797-dab258fa8053"), "Kiba", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("eaeb8c3b-8f2d-4f0f-9c15-8110ae0c936c"), new DateTime(2018, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e4669f7d-f1f9-4fc0-ba66-05385fe3540d"), new DateTime(2023, 1, 2, 19, 8, 25, 56, DateTimeKind.Utc).AddTicks(9214), "Niet voor beginnelingen, redelijk boosaardig.", 0, false, false, new Guid("fcaf1783-1efe-42e0-8a0a-dc3e7c28667e"), new Guid("a672c408-6e72-4028-8a09-a18145b92a62"), "Weppie", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fa069a42-993c-4a8f-b1e1-87b24cb25f8e"), new DateTime(2018, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4ad42c96-00d6-4bfd-8cb4-6e674aa6eb52"), new DateTime(2023, 1, 2, 19, 8, 25, 56, DateTimeKind.Utc).AddTicks(9218), "Linda gaat graag zwemmen.", 1, false, false, new Guid("16610986-79f2-477d-bc39-e2fa61494e66"), new Guid("dc4ad261-5613-4a30-a582-678f908cd095"), "Linda", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[,]
                {
                    { 1, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "admin", "c858c98b-3c32-4c5d-a635-a26f42bbc177" },
                    { 2, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "user", "88b2b517-2b35-40d8-8377-513a3b7abd68" },
                    { 3, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "user", "85d6a8c4-eca7-4b1d-88b6-3459187bc55a" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Animals_BreedId",
                table: "Animals",
                column: "BreedId");

            migrationBuilder.CreateIndex(
                name: "IX_Animals_LocationId",
                table: "Animals",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Animals_MediaId",
                table: "Animals",
                column: "MediaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Breeds");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Medias");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
