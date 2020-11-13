using Microsoft.EntityFrameworkCore.Migrations;

namespace Demo1.Migrations
{
    public partial class letuan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    Password = table.Column<int>(nullable: false),
                    Imageurl = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FullName", "Imageurl", "Password", "UserName" },
                values: new object[] { 1, "levantuanpxu@gmail.com", "Le Van Tuan", "2d1e4f89-3477-4bce-8203-74c6a6e89b02.jpg", 123456, "Tuan Le" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
