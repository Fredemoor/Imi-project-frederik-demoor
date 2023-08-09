using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Imi.Project.Api.Infrastructure.Migrations
{
    public partial class NewwestMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("01d0ba40-e0b4-407a-a616-c60c4af1ad9e"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("2ecb504a-fa78-4f94-abaa-b5ac488969a4"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("5611af77-2f53-4584-befe-8ce96f3c689e"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("631ac7ea-7a95-4afb-86ba-2efccdebeb57"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("6dc7baf3-542f-4db1-854c-c0376d78b9c5"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("7dfc78ed-6a7b-4b16-bc1c-f59496e5ad32"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("845e7f05-9dac-4cc5-98d3-333d985f756e"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("9ec560a7-f4fc-46c0-a95a-0b4c840687e0"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("a6c14a8c-51b6-4d78-aa85-c7378fa4bd0e"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("c8f91813-61d5-441d-b2ed-4e35c460222e"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "383fb1a7-1d97-4852-a892-40d1b0870069");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8b1cfc27-21ae-4466-8045-c1e504ce2294");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc532db8-2d89-4ce2-9e56-c04266f676c2");

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("1986688d-8824-4858-b9b0-8d99686ab758"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("41e706f0-a267-46f9-9b43-49ad99e028c9"));

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: new Guid("1393edac-22ed-4c9a-b287-49c00ccc8452"));

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: new Guid("51fa54b5-25e3-4758-ae2a-82aac9e7de2d"));

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: new Guid("0b5e56aa-c6e5-46fe-8d4d-12eafd2be5f8"));

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: new Guid("38bade0d-f486-42b4-876f-0fbf20843ba5"));

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: new Guid("4470f516-05a0-4346-a9a7-d7bc67bf52b6"));

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: new Guid("4a1a747f-d108-49c4-853d-c80a2c6a0eda"));

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: new Guid("4b2866a2-a8e6-4fcb-9e39-6a0e95f9f17a"));

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: new Guid("7d478bc4-a4af-4037-b5de-a422d087410b"));

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: new Guid("80561590-eb0c-41e7-a1e7-1f856cd5e53a"));

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: new Guid("ca91a793-78c3-466b-86e8-69bc76e476cc"));

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: new Guid("d5d8bb93-c79f-42bc-b16d-516aeb2cc390"));

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: new Guid("d5dde7fe-b5f4-4e87-a93d-7b7c278e130f"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("0fa835d9-0785-4649-8f60-1d92ee2d306a"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("2fc4eea1-7823-4ecc-b997-3ff9466ec2e1"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("343b6c45-2ce4-46e9-8f2a-472eb92d1619"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("5b54ca57-a9a2-4a56-a77a-0b0ce3097c5c"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("98c7a8e4-4a53-42eb-b64e-cc4c4ba0df55"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("9a88b9d4-5663-450d-9861-376c495beede"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("9cfbb935-60e3-4532-895b-a3a5323838c5"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("c692ba50-786e-401d-9b95-8fcc86c7cdd7"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("dd82cdf3-2c82-4f26-acbb-d097ab8356da"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("fbdefe0c-3337-43ca-bf88-d09cf2754278"));

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: new Guid("00472728-ad46-4494-8744-afe903eb7de8"));

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: new Guid("14de15d0-222e-4654-bc7a-76baec1d0845"));

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: new Guid("2a0ea7af-7b51-4557-ba30-bb9736ad3483"));

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: new Guid("38fc9f67-f9b6-42e4-a8f8-fc46cfc4e445"));

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: new Guid("3a376173-2eab-4bcf-97db-3ba9424ed87d"));

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: new Guid("431d4af2-e9c8-4bfc-9e4c-51a1dbeb391c"));

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: new Guid("5dd1a5c1-c1d7-4cdf-ad52-e1b999cfc612"));

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: new Guid("7286d154-5451-4ede-b887-b97ace1e3e98"));

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: new Guid("d068101a-fd73-4dca-afc5-c19733f51cc6"));

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: new Guid("e975ab6d-ec68-4285-906c-95f41034db8a"));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthdate", "ConcurrencyStamp", "Email", "EmailConfirmed", "HasApprovedTermsAndConditions", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1ff2bcf5-69ad-4f7c-ac1f-1a65718430be", 0, new DateTime(1920, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "10aa3635-04da-4a7d-b058-cadf7eae46a1", "refuser@imi.com", true, false, false, null, "REFUSER@IMI.COM", "IMIREFUSER", "AQAAAAEAACcQAAAAEAlvlwXeBstmbyQ/+chzd3tE5CJH6xmzYgt+i5uP9CRxTsKN8r2ioUNS5np38UlJ3w==", null, false, "04e69a51-9771-4353-83c6-dc2b36759c31", false, "ImiRefuser" },
                    { "ad73bed5-e0ba-4680-a6e1-c1a6be5fbb0d", 0, new DateTime(1920, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6ae4a956-3072-42e5-8361-b60d7d462ad9", "user@imi.com", true, true, false, null, "USER@IMI.COM", "IMIUSER", "AQAAAAEAACcQAAAAENLBrFWQ24hUIs5S8SlDDypqaCodnoLTQYlKMXrhp8GXrhoLVQtQuuQEypg2YxW2Mw==", null, false, "0552d9d2-43df-42ac-a611-68579a09efc3", false, "ImiUser" },
                    { "dbd73b05-0a3b-46e9-a4bc-52dbb267993c", 0, new DateTime(2000, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "c224316e-3b18-4643-a30f-9e3445966435", "admin@imi.com", true, true, false, null, "ADMIN@IMI.COM", "IMIADMIN", "AQAAAAEAACcQAAAAEEqbSFHZ1rikQSE3cCcaIkW+BE0qcBaiqA8CRPgMh8rJV3oU+SXEJVQ2GCiJztOP6g==", null, false, "e449b2c5-d2bc-461a-ada8-c46293222256", false, "ImiAdmin" }
                });

            migrationBuilder.InsertData(
                table: "Breeds",
                columns: new[] { "Id", "AnimalBreed", "CreatedDate", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("06f091ef-2d9d-4550-9d38-d30fa74fde87"), "Alaskan Malamute Dog", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1440967a-0fe8-43d5-9ae6-761e71a0dfaa"), "Akita", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("28f8a3cf-d545-42df-b2da-0a9c1beccdb4"), "American Cocker Spaniel", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2bc90b7f-3008-4cf6-a3fa-a8423dc31eb9"), "Malteser", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2e3b3f9f-58b4-480d-ad90-8bbdbe308b64"), "Australian Cattle dog", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2f37041c-8434-45ca-acdc-2ec76cf15ae2"), "AKita inu", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4042efe6-dbe4-4b05-bb1a-72ca5b1916de"), "Pincher", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5d999ad1-7f11-4bca-adea-73378a502efb"), "Podenco", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d553c237-b6cc-4d60-987f-7b885da10cd7"), "Stafford", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e23584f4-f376-4140-bf27-067b9e36f0c7"), "Labrador", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Capacity", "CreatedDate", "IsCleaned", "IsFull", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("31edb7e4-ee92-4c00-825e-4962f9dd0ff6"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, "Kennel 9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("35e287bc-4d6f-4aeb-8de3-ae236ead640c"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, "Kennel 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("65d950f1-6cd6-4460-9957-15ea6b843a38"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, "Kennel 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6897f7fc-4228-4b10-b993-655c6a4a7ce4"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, "Kennel 4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("69cf1dbc-ebd4-417d-8020-ef70d1e70d6d"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, "Kennel 1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9973c768-55be-4f34-b228-879af122d1ff"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, "Kennel 8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9eeae77f-fd48-46b6-a0ba-8a31c3195d85"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, "Kennel 7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b5bddd4e-b1ac-4f3c-83eb-72c1ca9487a9"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, "Kennel 10", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cb58933e-ad80-49e0-889b-a48206e40fb5"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, "Kennel 10", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d146632a-4b3b-43cb-8fdc-0b72dbb45e6a"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, "Kennel 5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dfc3edaa-19be-409b-b742-5b2a01aea10c"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, "Kennel 11", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fa7b93d7-ee95-4626-ad1f-a3dc4836ebc8"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, "Kennel 6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "CreatedDate", "ImageUrl", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("1f585cbf-c773-4ec7-9786-09bb574e1845"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Img/img11.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("23c7d1dc-010b-404b-ac38-b45a9a22f692"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Img/img7.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("41fa19a8-b036-4eee-952f-7bb4cd0fed75"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Img/img0.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("52bf9c1b-3e81-41ed-ac21-27a13219d974"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Img/img9.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6ef10476-8a4b-48ae-a8b7-c607156ded86"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Img/img10.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7ab4a128-f9fe-44f9-8cf8-8b1b0a29b534"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Img/img4.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9765dc63-3f5e-42f3-bf2c-32a30e09b6d0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Img/img2.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9a4ed161-ceaf-49b0-94da-3a04dc688397"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Img/img5.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a24b8b64-777b-41e5-bc47-744408f089ee"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Img/img3.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cdd7f0a3-b263-4d06-aff4-c6167573a6d4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Img/img6.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cfb56d2c-cdbb-4d85-aa0a-f1d5b64c9b48"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Img/img8.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e6c318d7-a7ce-4761-9d71-2b223ce19ff7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Img/img1.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "BirthDate", "BreedId", "CreatedDate", "Description", "Gender", "IsFed", "IsWalked", "LocationId", "MediaId", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("1eff255a-f8fd-44ad-8d6b-f46ab3289a15"), new DateTime(2018, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2e3b3f9f-58b4-480d-ad90-8bbdbe308b64"), new DateTime(2023, 8, 9, 18, 27, 26, 413, DateTimeKind.Utc).AddTicks(8522), "Goede familie hond, fan van water polo.", 0, false, false, new Guid("fa7b93d7-ee95-4626-ad1f-a3dc4836ebc8"), new Guid("9a4ed161-ceaf-49b0-94da-3a04dc688397"), "Marco", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("266644c1-f61c-48b9-bb15-a917e8ec5e52"), new DateTime(2018, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("28f8a3cf-d545-42df-b2da-0a9c1beccdb4"), new DateTime(2023, 8, 9, 18, 27, 26, 413, DateTimeKind.Utc).AddTicks(8527), "Zacht karacter, redelijk schuw.", 0, false, false, new Guid("cb58933e-ad80-49e0-889b-a48206e40fb5"), new Guid("52bf9c1b-3e81-41ed-ac21-27a13219d974"), "Sjonnie", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("390d06b9-909c-49df-87d8-49a97524db51"), new DateTime(2018, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("06f091ef-2d9d-4550-9d38-d30fa74fde87"), new DateTime(2023, 8, 9, 18, 27, 26, 413, DateTimeKind.Utc).AddTicks(8526), "Zacht karacter, redelijk schuw.", 1, false, false, new Guid("31edb7e4-ee92-4c00-825e-4962f9dd0ff6"), new Guid("cfb56d2c-cdbb-4d85-aa0a-f1d5b64c9b48"), "Cindy", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3a49b356-1e89-4a22-8c3e-e43a428b2936"), new DateTime(2018, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1440967a-0fe8-43d5-9ae6-761e71a0dfaa"), new DateTime(2023, 8, 9, 18, 27, 26, 413, DateTimeKind.Utc).AddTicks(8523), "Zacht karacter, redelijk schuw.", 0, false, false, new Guid("9eeae77f-fd48-46b6-a0ba-8a31c3195d85"), new Guid("cdd7f0a3-b263-4d06-aff4-c6167573a6d4"), "Polo", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("53b9b7eb-c9e4-41d8-b2ce-62f53b0e9924"), new DateTime(2018, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2f37041c-8434-45ca-acdc-2ec76cf15ae2"), new DateTime(2023, 8, 9, 18, 27, 26, 413, DateTimeKind.Utc).AddTicks(8524), "Linda gaat graag zwemmen.", 1, false, false, new Guid("9973c768-55be-4f34-b228-879af122d1ff"), new Guid("23c7d1dc-010b-404b-ac38-b45a9a22f692"), "Linda", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5b1c6796-3bc1-4550-825e-c23801cadd5a"), new DateTime(2018, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5d999ad1-7f11-4bca-adea-73378a502efb"), new DateTime(2023, 8, 9, 18, 27, 26, 413, DateTimeKind.Utc).AddTicks(8514), "Zacht karaKter, redelijk schuw.", 0, false, false, new Guid("69cf1dbc-ebd4-417d-8020-ef70d1e70d6d"), new Guid("41fa19a8-b036-4eee-952f-7bb4cd0fed75"), "Chappie", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5f52cbfb-28da-4d9d-b0ed-0a368c2dfa4c"), new DateTime(2018, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4042efe6-dbe4-4b05-bb1a-72ca5b1916de"), new DateTime(2023, 8, 9, 18, 27, 26, 413, DateTimeKind.Utc).AddTicks(8517), "Zeer energetisch karakter", 1, false, false, new Guid("65d950f1-6cd6-4460-9957-15ea6b843a38"), new Guid("e6c318d7-a7ce-4761-9d71-2b223ce19ff7"), "Ozzy", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8c13dd88-0087-42af-8487-e6986aeea18f"), new DateTime(2018, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d553c237-b6cc-4d60-987f-7b885da10cd7"), new DateTime(2023, 8, 9, 18, 27, 26, 413, DateTimeKind.Utc).AddTicks(8521), "Niet voor beginnelingen, redelijk boosaardig.", 0, false, false, new Guid("d146632a-4b3b-43cb-8fdc-0b72dbb45e6a"), new Guid("7ab4a128-f9fe-44f9-8cf8-8b1b0a29b534"), "Weppie", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9285b7c5-156d-4613-96a0-a3df74e13c17"), new DateTime(2018, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2bc90b7f-3008-4cf6-a3fa-a8423dc31eb9"), new DateTime(2023, 8, 9, 18, 27, 26, 413, DateTimeKind.Utc).AddTicks(8519), "Speelse rakker, zeer energetisch.", 0, false, false, new Guid("6897f7fc-4228-4b10-b993-655c6a4a7ce4"), new Guid("a24b8b64-777b-41e5-bc47-744408f089ee"), "Bobbie", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("eb41b5cb-86d3-47e9-ba13-8a65b6e4768a"), new DateTime(2018, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e23584f4-f376-4140-bf27-067b9e36f0c7"), new DateTime(2023, 8, 9, 18, 27, 26, 413, DateTimeKind.Utc).AddTicks(8518), "Niet voor beginnelingen, kan agressief zijn.", 0, false, false, new Guid("35e287bc-4d6f-4aeb-8de3-ae236ead640c"), new Guid("9765dc63-3f5e-42f3-bf2c-32a30e09b6d0"), "Kiba", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: "dbd73b05-0a3b-46e9-a4bc-52dbb267993c");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserId",
                value: "1ff2bcf5-69ad-4f7c-ac1f-1a65718430be");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "UserId",
                value: "ad73bed5-e0ba-4680-a6e1-c1a6be5fbb0d");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("1eff255a-f8fd-44ad-8d6b-f46ab3289a15"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("266644c1-f61c-48b9-bb15-a917e8ec5e52"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("390d06b9-909c-49df-87d8-49a97524db51"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("3a49b356-1e89-4a22-8c3e-e43a428b2936"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("53b9b7eb-c9e4-41d8-b2ce-62f53b0e9924"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("5b1c6796-3bc1-4550-825e-c23801cadd5a"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("5f52cbfb-28da-4d9d-b0ed-0a368c2dfa4c"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("8c13dd88-0087-42af-8487-e6986aeea18f"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("9285b7c5-156d-4613-96a0-a3df74e13c17"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("eb41b5cb-86d3-47e9-ba13-8a65b6e4768a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ff2bcf5-69ad-4f7c-ac1f-1a65718430be");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad73bed5-e0ba-4680-a6e1-c1a6be5fbb0d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbd73b05-0a3b-46e9-a4bc-52dbb267993c");

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("b5bddd4e-b1ac-4f3c-83eb-72c1ca9487a9"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("dfc3edaa-19be-409b-b742-5b2a01aea10c"));

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: new Guid("1f585cbf-c773-4ec7-9786-09bb574e1845"));

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: new Guid("6ef10476-8a4b-48ae-a8b7-c607156ded86"));

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: new Guid("06f091ef-2d9d-4550-9d38-d30fa74fde87"));

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: new Guid("1440967a-0fe8-43d5-9ae6-761e71a0dfaa"));

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: new Guid("28f8a3cf-d545-42df-b2da-0a9c1beccdb4"));

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: new Guid("2bc90b7f-3008-4cf6-a3fa-a8423dc31eb9"));

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: new Guid("2e3b3f9f-58b4-480d-ad90-8bbdbe308b64"));

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: new Guid("2f37041c-8434-45ca-acdc-2ec76cf15ae2"));

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: new Guid("4042efe6-dbe4-4b05-bb1a-72ca5b1916de"));

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: new Guid("5d999ad1-7f11-4bca-adea-73378a502efb"));

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: new Guid("d553c237-b6cc-4d60-987f-7b885da10cd7"));

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: new Guid("e23584f4-f376-4140-bf27-067b9e36f0c7"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("31edb7e4-ee92-4c00-825e-4962f9dd0ff6"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("35e287bc-4d6f-4aeb-8de3-ae236ead640c"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("65d950f1-6cd6-4460-9957-15ea6b843a38"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6897f7fc-4228-4b10-b993-655c6a4a7ce4"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("69cf1dbc-ebd4-417d-8020-ef70d1e70d6d"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("9973c768-55be-4f34-b228-879af122d1ff"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("9eeae77f-fd48-46b6-a0ba-8a31c3195d85"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("cb58933e-ad80-49e0-889b-a48206e40fb5"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("d146632a-4b3b-43cb-8fdc-0b72dbb45e6a"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("fa7b93d7-ee95-4626-ad1f-a3dc4836ebc8"));

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: new Guid("23c7d1dc-010b-404b-ac38-b45a9a22f692"));

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: new Guid("41fa19a8-b036-4eee-952f-7bb4cd0fed75"));

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: new Guid("52bf9c1b-3e81-41ed-ac21-27a13219d974"));

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: new Guid("7ab4a128-f9fe-44f9-8cf8-8b1b0a29b534"));

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: new Guid("9765dc63-3f5e-42f3-bf2c-32a30e09b6d0"));

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: new Guid("9a4ed161-ceaf-49b0-94da-3a04dc688397"));

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: new Guid("a24b8b64-777b-41e5-bc47-744408f089ee"));

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: new Guid("cdd7f0a3-b263-4d06-aff4-c6167573a6d4"));

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: new Guid("cfb56d2c-cdbb-4d85-aa0a-f1d5b64c9b48"));

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: new Guid("e6c318d7-a7ce-4761-9d71-2b223ce19ff7"));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthdate", "ConcurrencyStamp", "Email", "EmailConfirmed", "HasApprovedTermsAndConditions", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "383fb1a7-1d97-4852-a892-40d1b0870069", 0, new DateTime(1920, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c9535d24-67f5-4e04-8c7e-7de57c177fe8", "refuser@imi.com", true, false, false, null, "REFUSER@IMI.COM", "IMIREFUSER", "AQAAAAEAACcQAAAAEIgvmZP9vgecDjw//kW85SQ2NMAFr31GRkM7Ec8Dz6MBlySNTA2+cq0mPKmneYL1HQ==", null, false, "93007535-a270-4e4c-b28b-689044cc446b", false, "ImiRefuser" },
                    { "8b1cfc27-21ae-4466-8045-c1e504ce2294", 0, new DateTime(1920, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "87a08750-4689-4c79-90e1-72e2c3456e38", "user@imi.com", true, true, false, null, "USER@IMI.COM", "IMIUSER", "AQAAAAEAACcQAAAAEMcplQPC/jcCTxuOrV/5k1maB+vPpwZhC7nDMKZ6AiEz3midPsNByyPZXjNeTOQo1w==", null, false, "5bbef44d-5a38-4014-9073-c51593d29a8b", false, "ImiUser" },
                    { "cc532db8-2d89-4ce2-9e56-c04266f676c2", 0, new DateTime(2000, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "b08c66da-2437-4f93-bce4-8fcbd6776065", "admin@imi.com", true, true, false, null, "ADMIN@IMI.COM", "IMIADMIN", "AQAAAAEAACcQAAAAEKO7zJY3Hylj9pDz+h1u7eUwfT5inB2n3VT/rEnN4Ft8xv3lifbI3L9A5t31cZIcoA==", null, false, "0e0d7815-8aca-45ff-90b8-fa16da03120d", false, "ImiAdmin" }
                });

            migrationBuilder.InsertData(
                table: "Breeds",
                columns: new[] { "Id", "AnimalBreed", "CreatedDate", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0b5e56aa-c6e5-46fe-8d4d-12eafd2be5f8"), "Australian Cattle dog", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("38bade0d-f486-42b4-876f-0fbf20843ba5"), "AKita inu", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4470f516-05a0-4346-a9a7-d7bc67bf52b6"), "Podenco", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4a1a747f-d108-49c4-853d-c80a2c6a0eda"), "Malteser", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4b2866a2-a8e6-4fcb-9e39-6a0e95f9f17a"), "Stafford", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7d478bc4-a4af-4037-b5de-a422d087410b"), "Alaskan Malamute Dog", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("80561590-eb0c-41e7-a1e7-1f856cd5e53a"), "American Cocker Spaniel", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ca91a793-78c3-466b-86e8-69bc76e476cc"), "Pincher", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d5d8bb93-c79f-42bc-b16d-516aeb2cc390"), "Akita", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d5dde7fe-b5f4-4e87-a93d-7b7c278e130f"), "Labrador", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Capacity", "CreatedDate", "IsCleaned", "IsFull", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0fa835d9-0785-4649-8f60-1d92ee2d306a"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, "Kennel 5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1986688d-8824-4858-b9b0-8d99686ab758"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, "Kennel 11", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2fc4eea1-7823-4ecc-b997-3ff9466ec2e1"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, "Kennel 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("343b6c45-2ce4-46e9-8f2a-472eb92d1619"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, "Kennel 9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("41e706f0-a267-46f9-9b43-49ad99e028c9"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, "Kennel 10", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5b54ca57-a9a2-4a56-a77a-0b0ce3097c5c"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, "Kennel 10", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("98c7a8e4-4a53-42eb-b64e-cc4c4ba0df55"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, "Kennel 4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9a88b9d4-5663-450d-9861-376c495beede"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, "Kennel 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9cfbb935-60e3-4532-895b-a3a5323838c5"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, "Kennel 7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c692ba50-786e-401d-9b95-8fcc86c7cdd7"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, "Kennel 6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dd82cdf3-2c82-4f26-acbb-d097ab8356da"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, "Kennel 8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fbdefe0c-3337-43ca-bf88-d09cf2754278"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, "Kennel 1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "CreatedDate", "ImageUrl", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("00472728-ad46-4494-8744-afe903eb7de8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Img/img3.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1393edac-22ed-4c9a-b287-49c00ccc8452"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Img/img10.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("14de15d0-222e-4654-bc7a-76baec1d0845"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Img/img1.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2a0ea7af-7b51-4557-ba30-bb9736ad3483"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Img/img8.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("38fc9f67-f9b6-42e4-a8f8-fc46cfc4e445"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Img/img5.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3a376173-2eab-4bcf-97db-3ba9424ed87d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Img/img6.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("431d4af2-e9c8-4bfc-9e4c-51a1dbeb391c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Img/img4.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("51fa54b5-25e3-4758-ae2a-82aac9e7de2d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Img/img11.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5dd1a5c1-c1d7-4cdf-ad52-e1b999cfc612"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Img/img9.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7286d154-5451-4ede-b887-b97ace1e3e98"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Img/img0.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d068101a-fd73-4dca-afc5-c19733f51cc6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Img/img2.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e975ab6d-ec68-4285-906c-95f41034db8a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Img/img7.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "BirthDate", "BreedId", "CreatedDate", "Description", "Gender", "IsFed", "IsWalked", "LocationId", "MediaId", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("01d0ba40-e0b4-407a-a616-c60c4af1ad9e"), new DateTime(2018, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("38bade0d-f486-42b4-876f-0fbf20843ba5"), new DateTime(2023, 1, 3, 17, 5, 9, 524, DateTimeKind.Utc).AddTicks(8418), "Linda gaat graag zwemmen.", 1, false, false, new Guid("dd82cdf3-2c82-4f26-acbb-d097ab8356da"), new Guid("e975ab6d-ec68-4285-906c-95f41034db8a"), "Linda", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2ecb504a-fa78-4f94-abaa-b5ac488969a4"), new DateTime(2018, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("80561590-eb0c-41e7-a1e7-1f856cd5e53a"), new DateTime(2023, 1, 3, 17, 5, 9, 524, DateTimeKind.Utc).AddTicks(8423), "Zacht karacter, redelijk schuw.", 0, false, false, new Guid("5b54ca57-a9a2-4a56-a77a-0b0ce3097c5c"), new Guid("5dd1a5c1-c1d7-4cdf-ad52-e1b999cfc612"), "Sjonnie", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5611af77-2f53-4584-befe-8ce96f3c689e"), new DateTime(2018, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7d478bc4-a4af-4037-b5de-a422d087410b"), new DateTime(2023, 1, 3, 17, 5, 9, 524, DateTimeKind.Utc).AddTicks(8419), "Zacht karacter, redelijk schuw.", 1, false, false, new Guid("343b6c45-2ce4-46e9-8f2a-472eb92d1619"), new Guid("2a0ea7af-7b51-4557-ba30-bb9736ad3483"), "Cindy", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("631ac7ea-7a95-4afb-86ba-2efccdebeb57"), new DateTime(2018, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0b5e56aa-c6e5-46fe-8d4d-12eafd2be5f8"), new DateTime(2023, 1, 3, 17, 5, 9, 524, DateTimeKind.Utc).AddTicks(8415), "Goede familie hond, fan van water polo.", 0, false, false, new Guid("c692ba50-786e-401d-9b95-8fcc86c7cdd7"), new Guid("38fc9f67-f9b6-42e4-a8f8-fc46cfc4e445"), "Marco", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6dc7baf3-542f-4db1-854c-c0376d78b9c5"), new DateTime(2018, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4470f516-05a0-4346-a9a7-d7bc67bf52b6"), new DateTime(2023, 1, 3, 17, 5, 9, 524, DateTimeKind.Utc).AddTicks(8406), "Zacht karaKter, redelijk schuw.", 0, false, false, new Guid("fbdefe0c-3337-43ca-bf88-d09cf2754278"), new Guid("7286d154-5451-4ede-b887-b97ace1e3e98"), "Chappie", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7dfc78ed-6a7b-4b16-bc1c-f59496e5ad32"), new DateTime(2018, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d5dde7fe-b5f4-4e87-a93d-7b7c278e130f"), new DateTime(2023, 1, 3, 17, 5, 9, 524, DateTimeKind.Utc).AddTicks(8410), "Niet voor beginnelingen, kan agressief zijn.", 0, false, false, new Guid("2fc4eea1-7823-4ecc-b997-3ff9466ec2e1"), new Guid("d068101a-fd73-4dca-afc5-c19733f51cc6"), "Kiba", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("845e7f05-9dac-4cc5-98d3-333d985f756e"), new DateTime(2018, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4a1a747f-d108-49c4-853d-c80a2c6a0eda"), new DateTime(2023, 1, 3, 17, 5, 9, 524, DateTimeKind.Utc).AddTicks(8412), "Speelse rakker, zeer energetisch.", 0, false, false, new Guid("98c7a8e4-4a53-42eb-b64e-cc4c4ba0df55"), new Guid("00472728-ad46-4494-8744-afe903eb7de8"), "Bobbie", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9ec560a7-f4fc-46c0-a95a-0b4c840687e0"), new DateTime(2018, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ca91a793-78c3-466b-86e8-69bc76e476cc"), new DateTime(2023, 1, 3, 17, 5, 9, 524, DateTimeKind.Utc).AddTicks(8408), "Zeer energetisch karakter", 1, false, false, new Guid("9a88b9d4-5663-450d-9861-376c495beede"), new Guid("14de15d0-222e-4654-bc7a-76baec1d0845"), "Ozzy", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a6c14a8c-51b6-4d78-aa85-c7378fa4bd0e"), new DateTime(2018, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d5d8bb93-c79f-42bc-b16d-516aeb2cc390"), new DateTime(2023, 1, 3, 17, 5, 9, 524, DateTimeKind.Utc).AddTicks(8416), "Zacht karacter, redelijk schuw.", 0, false, false, new Guid("9cfbb935-60e3-4532-895b-a3a5323838c5"), new Guid("3a376173-2eab-4bcf-97db-3ba9424ed87d"), "Polo", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c8f91813-61d5-441d-b2ed-4e35c460222e"), new DateTime(2018, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4b2866a2-a8e6-4fcb-9e39-6a0e95f9f17a"), new DateTime(2023, 1, 3, 17, 5, 9, 524, DateTimeKind.Utc).AddTicks(8414), "Niet voor beginnelingen, redelijk boosaardig.", 0, false, false, new Guid("0fa835d9-0785-4649-8f60-1d92ee2d306a"), new Guid("431d4af2-e9c8-4bfc-9e4c-51a1dbeb391c"), "Weppie", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: "cc532db8-2d89-4ce2-9e56-c04266f676c2");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserId",
                value: "383fb1a7-1d97-4852-a892-40d1b0870069");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "UserId",
                value: "8b1cfc27-21ae-4466-8045-c1e504ce2294");
        }
    }
}
