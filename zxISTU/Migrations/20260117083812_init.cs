using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "employeeEntities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    LastName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    FirstName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Patronymic = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    Position = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Department = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    HireDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employeeEntities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "instructionTypeEntities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TypeName = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    ValidityPeriodMonths = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_instructionTypeEntities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "instructionProgramEntities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProgramName = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Version = table.Column<int>(type: "integer", nullable: false),
                    Content = table.Column<string>(type: "text", nullable: true),
                    DurationMinutes = table.Column<int>(type: "integer", nullable: true),
                    InstructionTypeId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_instructionProgramEntities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_instructionProgramEntities_instructionTypeEntities_Instruct~",
                        column: x => x.InstructionTypeId,
                        principalTable: "instructionTypeEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "instructionScheduleEntities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PlannedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    NotificationSent = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EmployeeId = table.Column<int>(type: "integer", nullable: false),
                    ProgramId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_instructionScheduleEntities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_instructionScheduleEntities_employeeEntities_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "employeeEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_instructionScheduleEntities_instructionProgramEntities_Prog~",
                        column: x => x.ProgramId,
                        principalTable: "instructionProgramEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "instructionsEntities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    InstructionDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    NextInstructionDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Status = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    Score = table.Column<decimal>(type: "numeric(5,2)", nullable: true),
                    ProtocolNumber = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    Notes = table.Column<string>(type: "text", nullable: true),
                    EmployeeId = table.Column<int>(type: "integer", nullable: false),
                    ProgramId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_instructionsEntities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_instructionsEntities_employeeEntities_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "employeeEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_instructionsEntities_instructionProgramEntities_ProgramId",
                        column: x => x.ProgramId,
                        principalTable: "instructionProgramEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "instructionDocumentEntities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FileName = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    FilePath = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    UploadedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    InstructionId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_instructionDocumentEntities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_instructionDocumentEntities_instructionsEntities_Instructio~",
                        column: x => x.InstructionId,
                        principalTable: "instructionsEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_instructionDocumentEntities_InstructionId",
                table: "instructionDocumentEntities",
                column: "InstructionId");

            migrationBuilder.CreateIndex(
                name: "IX_instructionProgramEntities_InstructionTypeId",
                table: "instructionProgramEntities",
                column: "InstructionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_instructionScheduleEntities_EmployeeId",
                table: "instructionScheduleEntities",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_instructionScheduleEntities_ProgramId",
                table: "instructionScheduleEntities",
                column: "ProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_instructionsEntities_EmployeeId",
                table: "instructionsEntities",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_instructionsEntities_ProgramId",
                table: "instructionsEntities",
                column: "ProgramId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "instructionDocumentEntities");

            migrationBuilder.DropTable(
                name: "instructionScheduleEntities");

            migrationBuilder.DropTable(
                name: "instructionsEntities");

            migrationBuilder.DropTable(
                name: "employeeEntities");

            migrationBuilder.DropTable(
                name: "instructionProgramEntities");

            migrationBuilder.DropTable(
                name: "instructionTypeEntities");
        }
    }
}
