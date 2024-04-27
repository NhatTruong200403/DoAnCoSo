using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoAnCNTT.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAmenitiesProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IconImage",
                table: "Amenities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Amenities",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IconImage",
                table: "Amenities");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Amenities");
        }
    }
}
