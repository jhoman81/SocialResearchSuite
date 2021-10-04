using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SRS.EntityFramework.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    EventType = table.Column<int>(type: "INTEGER", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    BeginDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Facts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Content = table.Column<string>(type: "TEXT", nullable: true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Families",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ParentOne = table.Column<int>(type: "INTEGER", nullable: true),
                    ParentTwo = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Families", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Relations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PersonOneId = table.Column<int>(type: "INTEGER", nullable: true),
                    PersonTwoId = table.Column<int>(type: "INTEGER", nullable: true),
                    RelationTerm = table.Column<string>(type: "TEXT", nullable: true),
                    ReverseRelationTerm = table.Column<string>(type: "TEXT", nullable: true),
                    RelationType = table.Column<int>(type: "INTEGER", nullable: true),
                    PedigreeLink = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Relations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    Username = table.Column<string>(type: "TEXT", nullable: false),
                    Surname = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Password = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Places",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    AlternateName = table.Column<string>(type: "TEXT", nullable: true),
                    ParentPlaceId = table.Column<int>(type: "INTEGER", nullable: true),
                    PlaceType = table.Column<int>(type: "INTEGER", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Latitude = table.Column<string>(type: "TEXT", nullable: true),
                    Longitude = table.Column<string>(type: "TEXT", nullable: true),
                    FoundationDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DesertedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Address = table.Column<string>(type: "TEXT", nullable: true),
                    Country = table.Column<string>(type: "TEXT", nullable: true),
                    Province = table.Column<string>(type: "TEXT", nullable: true),
                    District = table.Column<string>(type: "TEXT", nullable: true),
                    ZipCode = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    Population = table.Column<int>(type: "INTEGER", nullable: true),
                    AccessibleByRoad = table.Column<bool>(type: "INTEGER", nullable: true),
                    AccessibleByPlane = table.Column<bool>(type: "INTEGER", nullable: true),
                    AccessibleByRiver = table.Column<bool>(type: "INTEGER", nullable: true),
                    AccessibleByTrail = table.Column<bool>(type: "INTEGER", nullable: true),
                    HasElectricity = table.Column<bool>(type: "INTEGER", nullable: true),
                    HasPotableWater = table.Column<bool>(type: "INTEGER", nullable: true),
                    EventId = table.Column<int>(type: "INTEGER", nullable: true),
                    FactId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Places", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Places_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Places_Facts_FactId",
                        column: x => x.FactId,
                        principalTable: "Facts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: true),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projects_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Communities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LocationId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Communities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Communities_Places_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Places",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Households",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LocationId = table.Column<int>(type: "INTEGER", nullable: true),
                    MovedInDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CommunityId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Households", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Households_Communities_CommunityId",
                        column: x => x.CommunityId,
                        principalTable: "Communities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Households_Places_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Places",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Notes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DateLastModified = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Content = table.Column<string>(type: "TEXT", nullable: true),
                    NoteType = table.Column<int>(type: "INTEGER", nullable: true),
                    EventId = table.Column<int>(type: "INTEGER", nullable: true),
                    FactId = table.Column<int>(type: "INTEGER", nullable: true),
                    HouseholdId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notes_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Notes_Facts_FactId",
                        column: x => x.FactId,
                        principalTable: "Facts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Notes_Households_HouseholdId",
                        column: x => x.HouseholdId,
                        principalTable: "Households",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    SecondName = table.Column<string>(type: "TEXT", nullable: true),
                    AlternateName = table.Column<string>(type: "TEXT", nullable: true),
                    PaternalSurname = table.Column<string>(type: "TEXT", nullable: false),
                    MaternalSurname = table.Column<string>(type: "TEXT", nullable: true),
                    BirthPlaceId = table.Column<int>(type: "INTEGER", nullable: true),
                    DeathPlaceId = table.Column<int>(type: "INTEGER", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DateOfDeath = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Gender = table.Column<int>(type: "INTEGER", nullable: true),
                    Hand = table.Column<int>(type: "INTEGER", nullable: true),
                    Religion = table.Column<int>(type: "INTEGER", nullable: true),
                    Education = table.Column<int>(type: "INTEGER", nullable: true),
                    IsMarried = table.Column<bool>(type: "INTEGER", nullable: true),
                    HasChildren = table.Column<bool>(type: "INTEGER", nullable: true),
                    ResidenceId = table.Column<int>(type: "INTEGER", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    CommunityId = table.Column<int>(type: "INTEGER", nullable: true),
                    EventId = table.Column<int>(type: "INTEGER", nullable: true),
                    FamilyId = table.Column<int>(type: "INTEGER", nullable: true),
                    HouseholdId = table.Column<int>(type: "INTEGER", nullable: true),
                    RelationId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                    table.ForeignKey(
                        name: "FK_People_Communities_CommunityId",
                        column: x => x.CommunityId,
                        principalTable: "Communities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_People_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_People_Families_FamilyId",
                        column: x => x.FamilyId,
                        principalTable: "Families",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_People_Households_HouseholdId",
                        column: x => x.HouseholdId,
                        principalTable: "Households",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_People_Places_BirthPlaceId",
                        column: x => x.BirthPlaceId,
                        principalTable: "Places",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_People_Places_DeathPlaceId",
                        column: x => x.DeathPlaceId,
                        principalTable: "Places",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_People_Places_ResidenceId",
                        column: x => x.ResidenceId,
                        principalTable: "Places",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_People_Relations_RelationId",
                        column: x => x.RelationId,
                        principalTable: "Relations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Media",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FileName = table.Column<string>(type: "TEXT", nullable: false),
                    FileExtension = table.Column<string>(type: "TEXT", nullable: true),
                    FileLocation = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    FileSize = table.Column<double>(type: "REAL", nullable: true),
                    EventId = table.Column<int>(type: "INTEGER", nullable: true),
                    NoteId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Media", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Media_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Media_Notes_NoteId",
                        column: x => x.NoteId,
                        principalTable: "Notes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FactPerson",
                columns: table => new
                {
                    FactsId = table.Column<int>(type: "INTEGER", nullable: false),
                    PeopleId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FactPerson", x => new { x.FactsId, x.PeopleId });
                    table.ForeignKey(
                        name: "FK_FactPerson_Facts_FactsId",
                        column: x => x.FactsId,
                        principalTable: "Facts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FactPerson_People_PeopleId",
                        column: x => x.PeopleId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NotePerson",
                columns: table => new
                {
                    NotesId = table.Column<int>(type: "INTEGER", nullable: false),
                    PeopleId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotePerson", x => new { x.NotesId, x.PeopleId });
                    table.ForeignKey(
                        name: "FK_NotePerson_Notes_NotesId",
                        column: x => x.NotesId,
                        principalTable: "Notes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NotePerson_People_PeopleId",
                        column: x => x.PeopleId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "References",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    PublicationDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    DateAdded = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DateLastModified = table.Column<DateTime>(type: "TEXT", nullable: true),
                    PublicationTitle = table.Column<string>(type: "TEXT", nullable: true),
                    Pages = table.Column<string>(type: "TEXT", nullable: true),
                    Publisher = table.Column<string>(type: "TEXT", nullable: true),
                    PublisherLocation = table.Column<string>(type: "TEXT", nullable: true),
                    PubType = table.Column<int>(type: "INTEGER", nullable: true),
                    ReferenceFileId = table.Column<int>(type: "INTEGER", nullable: true),
                    EventId = table.Column<int>(type: "INTEGER", nullable: true),
                    FactId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_References", x => x.Id);
                    table.ForeignKey(
                        name: "FK_References_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_References_Facts_FactId",
                        column: x => x.FactId,
                        principalTable: "Facts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_References_Media_ReferenceFileId",
                        column: x => x.ReferenceFileId,
                        principalTable: "Media",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Author",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    SecondName = table.Column<string>(type: "TEXT", nullable: true),
                    AlternateName = table.Column<string>(type: "TEXT", nullable: true),
                    PaternalSurname = table.Column<string>(type: "TEXT", nullable: false),
                    MaternalSurname = table.Column<string>(type: "TEXT", nullable: true),
                    ReferenceId = table.Column<int>(type: "INTEGER", nullable: true),
                    ReferenceId1 = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Author_References_ReferenceId",
                        column: x => x.ReferenceId,
                        principalTable: "References",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Author_References_ReferenceId1",
                        column: x => x.ReferenceId1,
                        principalTable: "References",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NoteReference",
                columns: table => new
                {
                    NotesId = table.Column<int>(type: "INTEGER", nullable: false),
                    ReferencesId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NoteReference", x => new { x.NotesId, x.ReferencesId });
                    table.ForeignKey(
                        name: "FK_NoteReference_Notes_NotesId",
                        column: x => x.NotesId,
                        principalTable: "Notes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NoteReference_References_ReferencesId",
                        column: x => x.ReferencesId,
                        principalTable: "References",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Author_ReferenceId",
                table: "Author",
                column: "ReferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_Author_ReferenceId1",
                table: "Author",
                column: "ReferenceId1");

            migrationBuilder.CreateIndex(
                name: "IX_Communities_LocationId",
                table: "Communities",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_FactPerson_PeopleId",
                table: "FactPerson",
                column: "PeopleId");

            migrationBuilder.CreateIndex(
                name: "IX_Households_CommunityId",
                table: "Households",
                column: "CommunityId");

            migrationBuilder.CreateIndex(
                name: "IX_Households_LocationId",
                table: "Households",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Media_EventId",
                table: "Media",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Media_NoteId",
                table: "Media",
                column: "NoteId");

            migrationBuilder.CreateIndex(
                name: "IX_NotePerson_PeopleId",
                table: "NotePerson",
                column: "PeopleId");

            migrationBuilder.CreateIndex(
                name: "IX_NoteReference_ReferencesId",
                table: "NoteReference",
                column: "ReferencesId");

            migrationBuilder.CreateIndex(
                name: "IX_Notes_EventId",
                table: "Notes",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Notes_FactId",
                table: "Notes",
                column: "FactId");

            migrationBuilder.CreateIndex(
                name: "IX_Notes_HouseholdId",
                table: "Notes",
                column: "HouseholdId");

            migrationBuilder.CreateIndex(
                name: "IX_People_BirthPlaceId",
                table: "People",
                column: "BirthPlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_People_CommunityId",
                table: "People",
                column: "CommunityId");

            migrationBuilder.CreateIndex(
                name: "IX_People_DeathPlaceId",
                table: "People",
                column: "DeathPlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_People_EventId",
                table: "People",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_People_FamilyId",
                table: "People",
                column: "FamilyId");

            migrationBuilder.CreateIndex(
                name: "IX_People_HouseholdId",
                table: "People",
                column: "HouseholdId");

            migrationBuilder.CreateIndex(
                name: "IX_People_RelationId",
                table: "People",
                column: "RelationId");

            migrationBuilder.CreateIndex(
                name: "IX_People_ResidenceId",
                table: "People",
                column: "ResidenceId");

            migrationBuilder.CreateIndex(
                name: "IX_Places_EventId",
                table: "Places",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Places_FactId",
                table: "Places",
                column: "FactId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_UserId",
                table: "Projects",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_References_EventId",
                table: "References",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_References_FactId",
                table: "References",
                column: "FactId");

            migrationBuilder.CreateIndex(
                name: "IX_References_ReferenceFileId",
                table: "References",
                column: "ReferenceFileId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Author");

            migrationBuilder.DropTable(
                name: "FactPerson");

            migrationBuilder.DropTable(
                name: "NotePerson");

            migrationBuilder.DropTable(
                name: "NoteReference");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "References");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Families");

            migrationBuilder.DropTable(
                name: "Relations");

            migrationBuilder.DropTable(
                name: "Media");

            migrationBuilder.DropTable(
                name: "Notes");

            migrationBuilder.DropTable(
                name: "Households");

            migrationBuilder.DropTable(
                name: "Communities");

            migrationBuilder.DropTable(
                name: "Places");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Facts");
        }
    }
}
