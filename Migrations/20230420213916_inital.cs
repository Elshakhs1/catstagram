using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web_Programming_Assignment_2023.Migrations
{
    public partial class inital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AvatarFile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    PostId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhotoFile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hashtag = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.PostId);
                    table.ForeignKey(
                        name: "FK_Posts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "AvatarFile", "Email", "Message", "Password", "Status", "Username" },
                values: new object[] { 1, "flower.jpg", "katrin@gmail.com", null, "PaS_S", "Love my life 😍", "_Cutie_34" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "AvatarFile", "Email", "Message", "Password", "Status", "Username" },
                values: new object[] { 2, "vdct5dfk.jpg", "lolita_hanta@gmail.com", null, "Ger34_", "Artist/Illustrator/Commissions Opened 💖", "LolitaKit" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "AvatarFile", "Email", "Message", "Password", "Status", "Username" },
                values: new object[] { 3, null, "thomasLi@gmail.com", null, "ToMik", null, "FunnyTom" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "Comment", "DateCreated", "DateModified", "Hashtag", "PhotoFile", "UserId" },
                values: new object[,]
                {
                    { 1, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quisquam necessitatibus incidunt ut officiis explicabo inventore.", new DateTime(2023, 4, 20, 21, 39, 16, 105, DateTimeKind.Utc).AddTicks(1462), new DateTime(2023, 4, 20, 21, 39, 16, 105, DateTimeKind.Utc).AddTicks(2307), "#cute #cutie #kitty #pretty", "img2.jpg", 1 },
                    { 2, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quisquam necessitatibus incidunt ut officiis explicabo inventore.", new DateTime(2023, 4, 20, 21, 39, 16, 105, DateTimeKind.Utc).AddTicks(3802), new DateTime(2023, 4, 20, 21, 39, 16, 105, DateTimeKind.Utc).AddTicks(3815), "#cute #happy", "flower.jpg", 1 },
                    { 3, "Quisquam necessitatibus incidunt ut officiis explicabo inventore.", new DateTime(2023, 4, 20, 21, 39, 16, 105, DateTimeKind.Utc).AddTicks(3887), new DateTime(2023, 4, 20, 21, 39, 16, 105, DateTimeKind.Utc).AddTicks(3888), "#kitty", "beautiful.jpg", 2 },
                    { 4, "Ipsum dolor sit amet consectetur adipisicing elit.", new DateTime(2023, 4, 20, 21, 39, 16, 105, DateTimeKind.Utc).AddTicks(3912), new DateTime(2023, 4, 20, 21, 39, 16, 105, DateTimeKind.Utc).AddTicks(3913), "#smile #happy", "smile.jpg", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Posts_UserId",
                table: "Posts",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
