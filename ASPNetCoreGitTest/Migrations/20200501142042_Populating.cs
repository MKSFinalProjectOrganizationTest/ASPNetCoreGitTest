using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPNetCoreGitTest.Migrations
{
    public partial class Populating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert Into TestModels (Name) Values ('Model1'), ('Model2')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
