using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace VirtualPetCare.Repository.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HealthStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Species",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ScientificName = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Species", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Age = table.Column<int>(type: "integer", nullable: false),
                    HealthStatusId = table.Column<int>(type: "integer", nullable: false),
                    SpeciesId = table.Column<int>(type: "integer", nullable: false),
                    OwnerId = table.Column<int>(type: "integer", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pets_HealthStatuses_HealthStatusId",
                        column: x => x.HealthStatusId,
                        principalTable: "HealthStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pets_Species_SpeciesId",
                        column: x => x.SpeciesId,
                        principalTable: "Species",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pets_Users_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ActivityPet",
                columns: table => new
                {
                    ActivitiesId = table.Column<int>(type: "integer", nullable: false),
                    PetsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityPet", x => new { x.ActivitiesId, x.PetsId });
                    table.ForeignKey(
                        name: "FK_ActivityPet_Activities_ActivitiesId",
                        column: x => x.ActivitiesId,
                        principalTable: "Activities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActivityPet_Pets_PetsId",
                        column: x => x.PetsId,
                        principalTable: "Pets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FoodPet",
                columns: table => new
                {
                    FoodsId = table.Column<int>(type: "integer", nullable: false),
                    PetsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodPet", x => new { x.FoodsId, x.PetsId });
                    table.ForeignKey(
                        name: "FK_FoodPet_Foods_FoodsId",
                        column: x => x.FoodsId,
                        principalTable: "Foods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodPet_Pets_PetsId",
                        column: x => x.PetsId,
                        principalTable: "Pets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActivityPet_PetsId",
                table: "ActivityPet",
                column: "PetsId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodPet_PetsId",
                table: "FoodPet",
                column: "PetsId");

            migrationBuilder.CreateIndex(
                name: "IX_Pets_HealthStatusId",
                table: "Pets",
                column: "HealthStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Pets_OwnerId",
                table: "Pets",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Pets_SpeciesId",
                table: "Pets",
                column: "SpeciesId");

            migrationBuilder.InsertData(
                table: "Species",
                columns: new[] { "Id", "Name", "ScientificName", "Description", "IsActive", "CreatedDate", "UpdatedDate", },
                values: new object[,]
                {
                    { 1, "Cat", "Felis catus", "Small carnivorous mammal known for its playful behavior, distinctive meowing, and variety of coat colors and patterns. Popular worldwide as a companion animal.", true, DateTime.UtcNow, DateTime.UtcNow },
                    { 2, "Dog", "Canis lupus familiaris", "Domesticated mammal known for its loyalty, diverse breeds, and varied sizes. Often kept as a loyal companion, working partner, or for various tasks. Comes in a wide range of coat types and colors.", true, DateTime.UtcNow, DateTime.UtcNow},
                    { 3, "Budgerigar", "Melopsittacus undulatus", "Small, colorful parakeet species known for its playful nature and ability to mimic sounds and speech. Popular as a pet bird due to its vibrant plumage and friendly demeanor. Commonly kept in cages in households worldwide.", true, DateTime.UtcNow, DateTime.UtcNow},
                    { 4, "Hamster", "Cricetus cricetus", "Small, nocturnal rodent characterized by its furry coat, short legs, and cheek pouches for storing food. Popular as a pet due to its manageable size and cute, energetic behavior. Typically kept in cages and known for its grooming habits and burrowing instincts", true, DateTime.UtcNow, DateTime.UtcNow},
                    { 5, "Guppy", "Poecilia reticulata", "Small, vibrant freshwater fish known for their colorful and ornate tails. Popular in aquariums, guppies are easy to care for and come in a variety of colors, making them a favorite among fish enthusiasts.", true, DateTime.UtcNow, DateTime.UtcNow},
                    { 6, "Rabbit", "Oryctolagus cuniculus", "This small mammal is characterized by its soft fur, long ears, and a relatively small size. Domestic rabbits come in various breeds and colors, and they are often kept as pets due to their friendly nature. They are herbivores and have a well-developed sense of hearing and smell. Rabbits are known for their agility and the ability to hop or run at high speeds.", true, DateTime.UtcNow, DateTime.UtcNow},
                    { 7, "Turtle", "Trachemys scripta elegans", "Aquatic turtle species with a distinctive red stripe on each side of the head. Known for its friendly demeanor, adaptability to various environments, and popularity as a pet reptile.", true, DateTime.UtcNow, DateTime.UtcNow}
                });
            migrationBuilder.InsertData(
                table: "Species",
                columns: new[] { "Id", "Name", "ScientificName", "Description", "IsActive", "CreatedDate", "UpdatedDate", },
                values: new object[,]
                {
                    { 1, "Cat", "Felis catus", "Small carnivorous mammal known for its playful behavior, distinctive meowing, and variety of coat colors and patterns. Popular worldwide as a companion animal.", true, DateTime.UtcNow, DateTime.UtcNow },
                    { 2, "Dog", "Canis lupus familiaris", "Domesticated mammal known for its loyalty, diverse breeds, and varied sizes. Often kept as a loyal companion, working partner, or for various tasks. Comes in a wide range of coat types and colors.", true, DateTime.UtcNow, DateTime.UtcNow},
                    { 3, "Budgerigar", "Melopsittacus undulatus", "Small, colorful parakeet species known for its playful nature and ability to mimic sounds and speech. Popular as a pet bird due to its vibrant plumage and friendly demeanor. Commonly kept in cages in households worldwide.", true, DateTime.UtcNow, DateTime.UtcNow},
                    { 4, "Hamster", "Cricetus cricetus", "Small, nocturnal rodent characterized by its furry coat, short legs, and cheek pouches for storing food. Popular as a pet due to its manageable size and cute, energetic behavior. Typically kept in cages and known for its grooming habits and burrowing instincts", true, DateTime.UtcNow, DateTime.UtcNow},
                    { 5, "Guppy", "Poecilia reticulata", "Small, vibrant freshwater fish known for their colorful and ornate tails. Popular in aquariums, guppies are easy to care for and come in a variety of colors, making them a favorite among fish enthusiasts.", true, DateTime.UtcNow, DateTime.UtcNow},
                    { 6, "Rabbit", "Oryctolagus cuniculus", "This small mammal is characterized by its soft fur, long ears, and a relatively small size. Domestic rabbits come in various breeds and colors, and they are often kept as pets due to their friendly nature. They are herbivores and have a well-developed sense of hearing and smell. Rabbits are known for their agility and the ability to hop or run at high speeds.", true, DateTime.UtcNow, DateTime.UtcNow},
                    { 7, "Turtle", "Trachemys scripta elegans", "Aquatic turtle species with a distinctive red stripe on each side of the head. Known for its friendly demeanor, adaptability to various environments, and popularity as a pet reptile.", true, DateTime.UtcNow, DateTime.UtcNow}
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivityPet");

            migrationBuilder.DropTable(
                name: "FoodPet");

            migrationBuilder.DropTable(
                name: "Activities");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Pets");

            migrationBuilder.DropTable(
                name: "HealthStatuses");

            migrationBuilder.DropTable(
                name: "Species");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
