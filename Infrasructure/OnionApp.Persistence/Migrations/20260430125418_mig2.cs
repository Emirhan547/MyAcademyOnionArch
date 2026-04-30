using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnionApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "AppRoleId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CarDescriptions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CarDescriptions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CarFeatures",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CarPricings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CarPricings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CarPricings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CarPricings",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FooterAddresses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RentACars",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RentACars",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TagClouds",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TagClouds",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "AppRoleId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pricings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pricings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pricings",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Abouts",
                columns: new[] { "Id", "Description", "ImageUrl", "Title" },
                values: new object[] { 1, "Türkiye genelinde hızlı ve güvenli araç kiralama hizmeti sunuyoruz.", "/images/about.jpg", "Hakkımızda" });

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "AppRoleId", "AppRoleName" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "Member" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Description", "ImageUrl", "Name" },
                values: new object[] { 1, "Araç kiralama ve seyahat rehberleri hazırlayan editör.", "/images/team-1.jpg", "OnionApp Editör" });

            migrationBuilder.InsertData(
                table: "Banners",
                columns: new[] { "Id", "Description", "Title", "VideoDescription", "VideoUrl" },
                values: new object[] { 1, "Dakikalar içinde rezervasyon yapın.", "Hayalinizdeki Aracı Kiralayın", "Tanıtım videosunu izleyin", "https://www.youtube.com/watch?v=dQw4w9WgXcQ" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "BMW" },
                    { 2, "Mercedes" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Araç İnceleme" },
                    { 2, "Seyahat Önerileri" }
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "Email", "Message", "Name", "SendDate", "Subject" },
                values: new object[] { 1, "demo@example.com", "Kurumsal kiralama hakkında bilgi almak istiyorum.", "Demo Kullanıcı", new DateTime(2026, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bilgi" });

            migrationBuilder.InsertData(
                table: "Features",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Klima" },
                    { 2, "Bluetooth" }
                });

            migrationBuilder.InsertData(
                table: "FooterAddresses",
                columns: new[] { "Id", "Address", "Description", "Email", "Phone" },
                values: new object[] { 1, "Maslak, İstanbul", "Bize her zaman ulaşabilirsiniz.", "info@onionapp.local", "+90 212 000 00 00" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "İstanbul Havalimanı" },
                    { 2, "Ankara Merkez" }
                });

            migrationBuilder.InsertData(
                table: "Pricings",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 2, "Daily" },
                    { 3, "Weekly" },
                    { 4, "Monthly" }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Description", "IconUrl", "Title" },
                values: new object[,]
                {
                    { 1, "Yolculuk boyunca destek ekibimiz yanınızda.", "flaticon-support", "7/24 Destek" },
                    { 2, "Tüm kiralamalarda geniş kapsamlı güvence.", "flaticon-insurance", "Tam Sigorta" }
                });

            migrationBuilder.InsertData(
                table: "SocialMedias",
                columns: new[] { "Id", "Icon", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "fab fa-instagram", "Instagram", "https://instagram.com/onionapp" },
                    { 2, "fab fa-linkedin", "LinkedIn", "https://linkedin.com/company/onionapp" }
                });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AppRoleId", "Email", "Name", "Password", "Surname", "Username" },
                values: new object[] { 1, 1, "admin@onionapp.local", "System", "Admin123!", "Admin", "admin" });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "AuthorId", "CategoryId", "CoverImageUrl", "CreatedDate", "Description", "Title" },
                values: new object[] { 1, 1, 2, "/images/blog-1.jpg", new DateTime(2026, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hafta sonu kısa kaçamaklar için önerilen rotalar.", "İstanbul'da Hafta Sonu Sürüş Rotası" });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "BigImageUrl", "BrandId", "CoverImageUrl", "Fuel", "Km", "Luggage", "Model", "Seat", "Transmission" },
                values: new object[,]
                {
                    { 1, "/images/car-1-big.jpg", 1, "/images/car-1.jpg", "Gasoline", 42000, (byte)3, "320i", (byte)5, "Automatic" },
                    { 2, "/images/car-2-big.jpg", 2, "/images/car-2.jpg", "Diesel", 36000, (byte)4, "C200", (byte)5, "Automatic" }
                });

            migrationBuilder.InsertData(
                table: "CarDescriptions",
                columns: new[] { "Id", "CarId", "Details" },
                values: new object[,]
                {
                    { 1, 1, "Şehir içi kullanım için konforlu ve ekonomik sedan model." },
                    { 2, 2, "Uzun yolculuklara uygun premium sürüş deneyimi sunar." }
                });

            migrationBuilder.InsertData(
                table: "CarFeatures",
                columns: new[] { "Id", "Available", "CarId", "FeatureId" },
                values: new object[,]
                {
                    { 1, true, 1, 1 },
                    { 2, true, 1, 2 },
                    { 3, true, 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "CarPricings",
                columns: new[] { "Id", "Amount", "CarId", "PricingId" },
                values: new object[,]
                {
                    { 1, 2500m, 1, 2 },
                    { 2, 15000m, 1, 3 },
                    { 3, 55000m, 1, 4 },
                    { 4, 3200m, 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "BlogId", "CreatedDate", "Description", "Email", "Name" },
                values: new object[] { 1, 1, new DateTime(2026, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harika öneriler, teşekkürler.", "ziyaretci@example.com", "Ziyaretçi" });

            migrationBuilder.InsertData(
                table: "RentACars",
                columns: new[] { "Id", "Available", "CarId", "LocationId" },
                values: new object[,]
                {
                    { 1, true, 1, 1 },
                    { 2, true, 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "Age", "CarId", "Description", "DriverLicenseYear", "DropOffLocationId", "Email", "Name", "Phone", "PickUpLocationId", "Status", "Surname" },
                values: new object[] { 1, 30, 1, "Bebek koltuğu talebi", 8, 2, "ahmet@example.com", "Ahmet", "05550000000", 1, "Onay Bekliyor", "Yılmaz" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CarId", "Comment", "CustomerImage", "CustomerName", "RaytingValue", "ReviewDate" },
                values: new object[] { 1, 1, "Araç temiz ve teslimat hızlıydı.", "/images/person_1.jpg", "Elif K.", "5", new DateTime(2026, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TagClouds",
                columns: new[] { "Id", "BlogId", "Title" },
                values: new object[,]
                {
                    { 1, 1, "istanbul" },
                    { 2, 1, "hafta sonu" }
                });
        }
    }
}
