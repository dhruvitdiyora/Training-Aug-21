using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CharityAPI.Migrations.CharityAPI
{
    public partial class charity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    AdminId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(maxLength: 50, nullable: false),
                    EmailAddress = table.Column<string>(maxLength: 50, nullable: false),
                    PasswordHash = table.Column<string>(maxLength: 100, nullable: false),
                    MobileNo = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedBy = table.Column<string>(maxLength: 50, nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsPublished = table.Column<bool>(nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.AdminId);
                });

            migrationBuilder.CreateTable(
                name: "Organisations",
                columns: table => new
                {
                    OrganisationId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(maxLength: 50, nullable: false),
                    EmailAddress = table.Column<string>(maxLength: 50, nullable: false),
                    PasswordHash = table.Column<string>(maxLength: 100, nullable: false),
                    MobileNo = table.Column<string>(maxLength: 50, nullable: false),
                    Otp = table.Column<long>(nullable: true),
                    OtpCreatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedBy = table.Column<string>(maxLength: 50, nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsPublished = table.Column<bool>(nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organisations", x => x.OrganisationId);
                });

            migrationBuilder.CreateTable(
                name: "RequirementType",
                columns: table => new
                {
                    RequirementTypeId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequirementTypeName = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedBy = table.Column<string>(maxLength: 50, nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsPublished = table.Column<bool>(nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequirementType", x => x.RequirementTypeId);
                });

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    StateId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateName = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedBy = table.Column<string>(maxLength: 50, nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsPublished = table.Column<bool>(nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.StateId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(maxLength: 50, nullable: false),
                    EmailAddress = table.Column<string>(maxLength: 50, nullable: false),
                    PasswordHash = table.Column<string>(maxLength: 100, nullable: false),
                    MobileNo = table.Column<string>(maxLength: 50, nullable: false),
                    Otp = table.Column<long>(nullable: true),
                    OtpCreatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedBy = table.Column<string>(maxLength: 50, nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsPublished = table.Column<bool>(nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "WebApiExceptionLog",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SiteId = table.Column<int>(nullable: true),
                    Message = table.Column<string>(type: "ntext", nullable: true),
                    StackTrace = table.Column<string>(type: "ntext", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    IpAddress = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__WebApiEx__5E548648866B858C", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "WebApiRequestLog",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDescription = table.Column<string>(type: "ntext", nullable: true),
                    SiteId = table.Column<int>(nullable: true),
                    RequestUri = table.Column<string>(maxLength: 500, nullable: true),
                    ControllerName = table.Column<string>(maxLength: 300, nullable: true),
                    ActionName = table.Column<string>(maxLength: 100, nullable: true),
                    StartTime = table.Column<TimeSpan>(nullable: true),
                    Timespan = table.Column<TimeSpan>(nullable: true),
                    CreatedOn = table.Column<DateTimeOffset>(nullable: true),
                    CreatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    IpAddress = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__WebApiRe__5E54864822104AD2", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "OrganisationData",
                columns: table => new
                {
                    OrganisationDataId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrganisationUserId = table.Column<long>(nullable: false),
                    OrganisationName = table.Column<string>(maxLength: 50, nullable: false),
                    OrganisationAddress = table.Column<string>(nullable: false),
                    OrganisationContactNo = table.Column<string>(maxLength: 50, nullable: true),
                    OrganisationLogoURL = table.Column<string>(nullable: false),
                    IsVerified = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedBy = table.Column<string>(maxLength: 50, nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsPublished = table.Column<bool>(nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganisationData", x => x.OrganisationDataId);
                    table.ForeignKey(
                        name: "FK_OrgUser",
                        column: x => x.OrganisationUserId,
                        principalTable: "Organisations",
                        principalColumn: "OrganisationId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateId = table.Column<long>(nullable: false),
                    CityName = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedBy = table.Column<string>(maxLength: 50, nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsPublished = table.Column<bool>(nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityId);
                    table.ForeignKey(
                        name: "FK_Cities",
                        column: x => x.StateId,
                        principalTable: "States",
                        principalColumn: "StateId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pincode",
                columns: table => new
                {
                    PincodeId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostOfficeName = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Pincode = table.Column<long>(nullable: false),
                    CityId = table.Column<long>(nullable: false),
                    District = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    StateId = table.Column<long>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedBy = table.Column<string>(maxLength: 50, nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsPublished = table.Column<bool>(nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pincode", x => x.PincodeId);
                    table.ForeignKey(
                        name: "FK_PincodeCity",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PincodeState",
                        column: x => x.StateId,
                        principalTable: "States",
                        principalColumn: "StateId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CharityEvent",
                columns: table => new
                {
                    EventId = table.Column<long>(nullable: false),
                    EventName = table.Column<string>(maxLength: 50, nullable: false),
                    EventDescription = table.Column<string>(type: "text", nullable: false),
                    EventOrganiserId = table.Column<long>(nullable: false),
                    EventBannerUrl = table.Column<string>(nullable: true),
                    EventStartDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    EventEndDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsVerified = table.Column<bool>(nullable: false),
                    EventType = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedBy = table.Column<string>(maxLength: 50, nullable: false),
                    PincodeId = table.Column<long>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsPublished = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    IsCompleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharityEvent", x => x.EventId);
                    table.ForeignKey(
                        name: "FK_CharityOrganisationId",
                        column: x => x.EventOrganiserId,
                        principalTable: "OrganisationData",
                        principalColumn: "OrganisationDataId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CharityEventPincodeId",
                        column: x => x.PincodeId,
                        principalTable: "Pincode",
                        principalColumn: "PincodeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserData",
                columns: table => new
                {
                    UserId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    Gender = table.Column<string>(maxLength: 10, nullable: false),
                    ProfileImage = table.Column<string>(nullable: true),
                    UserDescription = table.Column<string>(maxLength: 500, nullable: true),
                    UserName = table.Column<string>(maxLength: 50, nullable: false),
                    EmailAddress = table.Column<string>(maxLength: 50, nullable: false),
                    MobileNo = table.Column<string>(maxLength: 50, nullable: false),
                    TotalPostCount = table.Column<long>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedBy = table.Column<string>(maxLength: 50, nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsPublished = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    Users = table.Column<long>(nullable: false),
                    CityId = table.Column<long>(nullable: false),
                    StateId = table.Column<long>(nullable: false),
                    PincodeId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__UserData__1788CC4C1C5A4F30", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_UserCity",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserPin",
                        column: x => x.PincodeId,
                        principalTable: "Pincode",
                        principalColumn: "PincodeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserState",
                        column: x => x.StateId,
                        principalTable: "States",
                        principalColumn: "StateId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users",
                        column: x => x.Users,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CharityEventOrganiser",
                columns: table => new
                {
                    CharityEventOrganiserId = table.Column<long>(nullable: false),
                    EventOrganiserId = table.Column<long>(nullable: false),
                    EventId = table.Column<long>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedBy = table.Column<string>(maxLength: 50, nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsPublished = table.Column<bool>(nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharityEventOrganiser", x => x.CharityEventOrganiserId);
                    table.ForeignKey(
                        name: "FK_CharityEventOrganiserEvent",
                        column: x => x.EventId,
                        principalTable: "CharityEvent",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CharityEventOrganiserEventOrganiser",
                        column: x => x.EventOrganiserId,
                        principalTable: "OrganisationData",
                        principalColumn: "OrganisationDataId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CharityEventInteract",
                columns: table => new
                {
                    CharityEventInteractId = table.Column<long>(nullable: false),
                    EventId = table.Column<long>(nullable: false),
                    UserId = table.Column<long>(nullable: false),
                    IsInterested = table.Column<bool>(nullable: false),
                    IsGoing = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedBy = table.Column<string>(maxLength: 50, nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsPublished = table.Column<bool>(nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharityEventInteract", x => x.CharityEventInteractId);
                    table.ForeignKey(
                        name: "FK_CharityEventInteractEvent",
                        column: x => x.EventId,
                        principalTable: "CharityEvent",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CharityEventInteractUser",
                        column: x => x.UserId,
                        principalTable: "UserData",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CharityEventPost",
                columns: table => new
                {
                    CharityEventPostId = table.Column<long>(nullable: false),
                    EventId = table.Column<long>(nullable: false),
                    UserId = table.Column<long>(nullable: false),
                    PostUrl = table.Column<string>(nullable: false),
                    Content = table.Column<string>(type: "text", nullable: true),
                    CreatedBy = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedBy = table.Column<string>(maxLength: 50, nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsPublished = table.Column<bool>(nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharityEventPost", x => x.CharityEventPostId);
                    table.ForeignKey(
                        name: "FK_CharityEventPostEvent",
                        column: x => x.EventId,
                        principalTable: "CharityEvent",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CharityEventPostUser",
                        column: x => x.UserId,
                        principalTable: "UserData",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Post",
                columns: table => new
                {
                    PostId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(nullable: false),
                    PostDescription = table.Column<string>(type: "text", nullable: false),
                    RequirementTypeId = table.Column<long>(nullable: false),
                    LocationName = table.Column<string>(maxLength: 50, nullable: false),
                    Longitude = table.Column<decimal>(type: "decimal(12, 9)", nullable: false),
                    Latitude = table.Column<decimal>(type: "decimal(12, 9)", nullable: false),
                    HelpRequiredCount = table.Column<long>(nullable: false),
                    CityId = table.Column<long>(nullable: false),
                    StateId = table.Column<long>(nullable: false),
                    ImageURL = table.Column<string>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedBy = table.Column<string>(maxLength: 50, nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsPublished = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    IsClosed = table.Column<bool>(nullable: false),
                    CloseAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    PincodeId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post", x => x.PostId);
                    table.ForeignKey(
                        name: "FK_PostCity",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PostPin",
                        column: x => x.PincodeId,
                        principalTable: "Pincode",
                        principalColumn: "PincodeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RequirementType",
                        column: x => x.RequirementTypeId,
                        principalTable: "RequirementType",
                        principalColumn: "RequirementTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PostState",
                        column: x => x.StateId,
                        principalTable: "States",
                        principalColumn: "StateId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PostUserId",
                        column: x => x.UserId,
                        principalTable: "UserData",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Volunteer",
                columns: table => new
                {
                    VolunteerId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VolunteerUserId = table.Column<long>(nullable: false),
                    OrganisationId = table.Column<long>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedBy = table.Column<string>(maxLength: 50, nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsPublished = table.Column<bool>(nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Volunteer", x => x.VolunteerId);
                    table.ForeignKey(
                        name: "FK_VolunteerOrg",
                        column: x => x.OrganisationId,
                        principalTable: "OrganisationData",
                        principalColumn: "OrganisationDataId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Volunteer",
                        column: x => x.VolunteerUserId,
                        principalTable: "UserData",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CharityEventPostLike",
                columns: table => new
                {
                    CharityEventPostLikeId = table.Column<long>(nullable: false),
                    CharityEventPostId = table.Column<long>(nullable: false),
                    UserId = table.Column<long>(nullable: false),
                    Likes = table.Column<long>(nullable: false),
                    DisLike = table.Column<long>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedBy = table.Column<string>(maxLength: 50, nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharityEventPostLike", x => x.CharityEventPostLikeId);
                    table.ForeignKey(
                        name: "FK_CharityEventPost",
                        column: x => x.CharityEventPostId,
                        principalTable: "CharityEventPost",
                        principalColumn: "CharityEventPostId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CharityEventLikeByUser",
                        column: x => x.UserId,
                        principalTable: "UserData",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClusterLocations",
                columns: table => new
                {
                    ClusterLocationId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(nullable: false),
                    PostId = table.Column<long>(nullable: false),
                    RequirementTypeId = table.Column<long>(nullable: false),
                    Locations = table.Column<string>(maxLength: 50, nullable: false),
                    CityId = table.Column<long>(nullable: false),
                    StateId = table.Column<long>(nullable: false),
                    PeopleCount = table.Column<long>(nullable: false),
                    IsVerified = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedBy = table.Column<string>(maxLength: 50, nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsPublished = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    PincodeId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cluster", x => x.ClusterLocationId);
                    table.ForeignKey(
                        name: "FK_ClusterCity",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClusterPin",
                        column: x => x.PincodeId,
                        principalTable: "Pincode",
                        principalColumn: "PincodeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClusterPostId",
                        column: x => x.PostId,
                        principalTable: "Post",
                        principalColumn: "PostId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClusterControId",
                        column: x => x.RequirementTypeId,
                        principalTable: "RequirementType",
                        principalColumn: "RequirementTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClusterState",
                        column: x => x.StateId,
                        principalTable: "States",
                        principalColumn: "StateId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClusterUserId",
                        column: x => x.UserId,
                        principalTable: "UserData",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Spam",
                columns: table => new
                {
                    SpamId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostId = table.Column<long>(nullable: false),
                    UserId = table.Column<long>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedBy = table.Column<string>(maxLength: 50, nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsPublished = table.Column<bool>(nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spam", x => x.SpamId);
                    table.ForeignKey(
                        name: "FK_SpamPost",
                        column: x => x.PostId,
                        principalTable: "Post",
                        principalColumn: "PostId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SpamUser",
                        column: x => x.UserId,
                        principalTable: "UserData",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Urgency",
                columns: table => new
                {
                    UrgencyId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostId = table.Column<long>(nullable: false),
                    UserId = table.Column<long>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedBy = table.Column<string>(maxLength: 50, nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsPublished = table.Column<bool>(nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Urgency", x => x.UrgencyId);
                    table.ForeignKey(
                        name: "FK_UrgentPost",
                        column: x => x.PostId,
                        principalTable: "Post",
                        principalColumn: "PostId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UrgentUser",
                        column: x => x.UserId,
                        principalTable: "UserData",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "UQ__Admins__49A14740F2462EB0",
                table: "Admins",
                column: "EmailAddress",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__Admins__D60E46A21E3C5CB5",
                table: "Admins",
                column: "PasswordHash",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__Admins__C9F2845604A6A39E",
                table: "Admins",
                column: "UserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CharityEvent_EventOrganiserId",
                table: "CharityEvent",
                column: "EventOrganiserId");

            migrationBuilder.CreateIndex(
                name: "IX_CharityEvent_PincodeId",
                table: "CharityEvent",
                column: "PincodeId");

            migrationBuilder.CreateIndex(
                name: "IX_CharityEventInteract_EventId",
                table: "CharityEventInteract",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_CharityEventInteract_UserId",
                table: "CharityEventInteract",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CharityEventOrganiser_EventId",
                table: "CharityEventOrganiser",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "UK_CharityEventOrganiserEventNOrganiser",
                table: "CharityEventOrganiser",
                columns: new[] { "EventOrganiserId", "EventId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CharityEventPost_EventId",
                table: "CharityEventPost",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_CharityEventPost_UserId",
                table: "CharityEventPost",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CharityEventPostLike_UserId",
                table: "CharityEventPostLike",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "UK_CharityEventPostUser",
                table: "CharityEventPostLike",
                columns: new[] { "CharityEventPostId", "UserId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cities_StateId",
                table: "Cities",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_ClusterLocations_CityId",
                table: "ClusterLocations",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_ClusterLocations_PincodeId",
                table: "ClusterLocations",
                column: "PincodeId");

            migrationBuilder.CreateIndex(
                name: "IX_ClusterLocations_PostId",
                table: "ClusterLocations",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_ClusterLocations_RequirementTypeId",
                table: "ClusterLocations",
                column: "RequirementTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ClusterLocations_StateId",
                table: "ClusterLocations",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_ClusterLocations_UserId",
                table: "ClusterLocations",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganisationData_OrganisationUserId",
                table: "OrganisationData",
                column: "OrganisationUserId");

            migrationBuilder.CreateIndex(
                name: "UQ__Organisa__49A14740F5747692",
                table: "Organisations",
                column: "EmailAddress",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__Organisa__D60E46A20B37A83E",
                table: "Organisations",
                column: "PasswordHash",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__Organisa__C9F28456FBA0EFCA",
                table: "Organisations",
                column: "UserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pincode_CityId",
                table: "Pincode",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Pincode_StateId",
                table: "Pincode",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_Post_CityId",
                table: "Post",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Post_PincodeId",
                table: "Post",
                column: "PincodeId");

            migrationBuilder.CreateIndex(
                name: "IX_Post_RequirementTypeId",
                table: "Post",
                column: "RequirementTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Post_StateId",
                table: "Post",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_Post_UserId",
                table: "Post",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Spam_UserId",
                table: "Spam",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "UK_SpamUser",
                table: "Spam",
                columns: new[] { "PostId", "UserId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__States__554763152132CFC1",
                table: "States",
                column: "StateName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Urgency_UserId",
                table: "Urgency",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "UK_UrgencyUser",
                table: "Urgency",
                columns: new[] { "PostId", "UserId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserData_CityId",
                table: "UserData",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "UQ__UserData__49A1474046C79309",
                table: "UserData",
                column: "EmailAddress",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserData_PincodeId",
                table: "UserData",
                column: "PincodeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserData_StateId",
                table: "UserData",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "UQ__UserData__C9F28456473A8913",
                table: "UserData",
                column: "UserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__UserData__64B85EBE6FC9070D",
                table: "UserData",
                column: "Users",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__Users__49A14740F0748FF3",
                table: "Users",
                column: "EmailAddress",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__Users__D60E46A24297F69A",
                table: "Users",
                column: "PasswordHash",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__Users__C9F28456EE2EEC8C",
                table: "Users",
                column: "UserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Volunteer_OrganisationId",
                table: "Volunteer",
                column: "OrganisationId");

            migrationBuilder.CreateIndex(
                name: "IX_Volunteer_VolunteerUserId",
                table: "Volunteer",
                column: "VolunteerUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "CharityEventInteract");

            migrationBuilder.DropTable(
                name: "CharityEventOrganiser");

            migrationBuilder.DropTable(
                name: "CharityEventPostLike");

            migrationBuilder.DropTable(
                name: "ClusterLocations");

            migrationBuilder.DropTable(
                name: "Spam");

            migrationBuilder.DropTable(
                name: "Urgency");

            migrationBuilder.DropTable(
                name: "Volunteer");

            migrationBuilder.DropTable(
                name: "WebApiExceptionLog");

            migrationBuilder.DropTable(
                name: "WebApiRequestLog");

            migrationBuilder.DropTable(
                name: "CharityEventPost");

            migrationBuilder.DropTable(
                name: "Post");

            migrationBuilder.DropTable(
                name: "CharityEvent");

            migrationBuilder.DropTable(
                name: "RequirementType");

            migrationBuilder.DropTable(
                name: "UserData");

            migrationBuilder.DropTable(
                name: "OrganisationData");

            migrationBuilder.DropTable(
                name: "Pincode");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Organisations");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "States");
        }
    }
}
