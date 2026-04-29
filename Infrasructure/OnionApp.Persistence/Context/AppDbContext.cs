using Microsoft.EntityFrameworkCore;
using OnionApp.Domain.Entities;
using OnionApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApp.Persistence.Context
{
    public class AppDbContext(DbContextOptions options):DbContext(options)
    {
        public DbSet<Category>Categories { get; set; }
        public DbSet<AppUser>AppUsers { get; set; }
        public DbSet<AppRole>AppRoles { get; set; }
        public DbSet<About>Abouts { get; set; }
        public DbSet<Banner>Banners { get; set; }
        public DbSet<Brand>Brands { get; set; }
        public DbSet<Car>Cars { get; set; }
        public DbSet<CarDescription>CarDescriptions { get; set; }
        public DbSet<CarFeature>CarFeatures { get; set; }
        public DbSet<CarPricing>CarPricings { get; set; }
        public DbSet<Contact>Contacts { get; set; }
        public DbSet<Feature>Features { get; set; }
        public DbSet<FooterAddress>FooterAddresses { get; set; }
        public DbSet<Location>Locations { get; set; }
        public DbSet<Pricing>Pricings { get; set; }
        public DbSet<Service>Services { get; set; }
        public DbSet<SocialMedia>SocialMedias { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<TagCloud> TagClouds { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<RentACar> RentACars { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reservation>()
                .HasOne(x => x.PickUpLocation)
                .WithMany(y => y.PickUpReservation)
                .HasForeignKey(z => z.PickUpLocationId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Reservation>()
                .HasOne(x => x.DropOffLocation)
                .WithMany(y => y.DropOffReservation)
                .HasForeignKey(z => z.DropOffLocationId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Pricing>().HasData(
      new Pricing { Id = (int)PricingType.Daily, Name = "Daily" },
                new Pricing { Id = (int)PricingType.Weekly, Name = "Weekly" },
                new Pricing { Id = (int)PricingType.Monthly, Name = "Monthly" }
            );

            modelBuilder.Entity<AppRole>().HasData(
                new AppRole { AppRoleId = 1, AppRoleName = "Admin" },
                new AppRole { AppRoleId = 2, AppRoleName = "Member" }
            );

            modelBuilder.Entity<AppUser>().HasData(
                new AppUser { Id = 1, Username = "admin", Name = "System", Surname = "Admin", Email = "admin@onionapp.local", Password = "Admin123!", AppRoleId = 1 }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Araç İnceleme" },
                new Category { Id = 2, Name = "Seyahat Önerileri" }
            );

            modelBuilder.Entity<Author>().HasData(
                new Author { Id = 1, Name = "OnionApp Editör", ImageUrl = "/images/team-1.jpg", Description = "Araç kiralama ve seyahat rehberleri hazırlayan editör." }
            );

            modelBuilder.Entity<About>().HasData(
                new About { Id = 1, Title = "Hakkımızda", Description = "Türkiye genelinde hızlı ve güvenli araç kiralama hizmeti sunuyoruz.", ImageUrl = "/images/about.jpg" }
            );

            modelBuilder.Entity<Banner>().HasData(
                new Banner { Id = 1, Title = "Hayalinizdeki Aracı Kiralayın", Description = "Dakikalar içinde rezervasyon yapın.", VideoDescription = "Tanıtım videosunu izleyin", VideoUrl = "https://www.youtube.com/watch?v=dQw4w9WgXcQ" }
            );

            modelBuilder.Entity<Brand>().HasData(
                new Brand { Id = 1, Name = "BMW" },
                new Brand { Id = 2, Name = "Mercedes" }
            );

            modelBuilder.Entity<Car>().HasData(
                new Car { Id = 1, BrandId = 1, Model = "320i", CoverImageUrl = "/images/car-1.jpg", Km = 42000, Transmission = "Automatic", Seat = 5, Luggage = 3, Fuel = "Gasoline", BigImageUrl = "/images/car-1-big.jpg" },
                new Car { Id = 2, BrandId = 2, Model = "C200", CoverImageUrl = "/images/car-2.jpg", Km = 36000, Transmission = "Automatic", Seat = 5, Luggage = 4, Fuel = "Diesel", BigImageUrl = "/images/car-2-big.jpg" }
            );

            modelBuilder.Entity<Feature>().HasData(
                new Feature { Id = 1, Name = "Klima" },
                new Feature { Id = 2, Name = "Bluetooth" }
            );

            modelBuilder.Entity<CarFeature>().HasData(
                new CarFeature { Id = 1, CarId = 1, FeatureId = 1, Available = true },
                new CarFeature { Id = 2, CarId = 1, FeatureId = 2, Available = true },
                new CarFeature { Id = 3, CarId = 2, FeatureId = 1, Available = true }
            );

            modelBuilder.Entity<CarDescription>().HasData(
                new CarDescription { Id = 1, CarId = 1, Details = "Şehir içi kullanım için konforlu ve ekonomik sedan model." },
                new CarDescription { Id = 2, CarId = 2, Details = "Uzun yolculuklara uygun premium sürüş deneyimi sunar." }
            );

            modelBuilder.Entity<CarPricing>().HasData(
                new CarPricing { Id = 1, CarId = 1, PricingId = (int)PricingType.Daily, Amount = 2500 },
                new CarPricing { Id = 2, CarId = 1, PricingId = (int)PricingType.Weekly, Amount = 15000 },
                new CarPricing { Id = 3, CarId = 1, PricingId = (int)PricingType.Monthly, Amount = 55000 },
                new CarPricing { Id = 4, CarId = 2, PricingId = (int)PricingType.Daily, Amount = 3200 }
            );

            modelBuilder.Entity<Blog>().HasData(
                new Blog { Id = 1, Title = "İstanbul'da Hafta Sonu Sürüş Rotası", AuthorId = 1, CoverImageUrl = "/images/blog-1.jpg", CreatedDate = new DateTime(2026, 4, 1), CategoryId = 2, Description = "Hafta sonu kısa kaçamaklar için önerilen rotalar." }
            );

            modelBuilder.Entity<TagCloud>().HasData(
                new TagCloud { Id = 1, Title = "istanbul", BlogId = 1 },
                new TagCloud { Id = 2, Title = "hafta sonu", BlogId = 1 }
            );

            modelBuilder.Entity<Comment>().HasData(
                new Comment { Id = 1, Name = "Ziyaretçi", Description = "Harika öneriler, teşekkürler.", Email = "ziyaretci@example.com", CreatedDate = new DateTime(2026, 4, 2), BlogId = 1 }
            );

            modelBuilder.Entity<Contact>().HasData(
                new Contact { Id = 1, Name = "Demo Kullanıcı", Email = "demo@example.com", Subject = "Bilgi", Message = "Kurumsal kiralama hakkında bilgi almak istiyorum.", SendDate = new DateTime(2026, 4, 3) }
            );

            modelBuilder.Entity<FooterAddress>().HasData(
                new FooterAddress { Id = 1, Description = "Bize her zaman ulaşabilirsiniz.", Address = "Maslak, İstanbul", Phone = "+90 212 000 00 00", Email = "info@onionapp.local" }
            );

            modelBuilder.Entity<Location>().HasData(
                new Location { Id = 1, Name = "İstanbul Havalimanı" },
                new Location { Id = 2, Name = "Ankara Merkez" }
            );

            modelBuilder.Entity<RentACar>().HasData(
                new RentACar { Id = 1, LocationId = 1, CarId = 1, Available = true },
                new RentACar { Id = 2, LocationId = 2, CarId = 2, Available = true }
            );

            modelBuilder.Entity<Reservation>().HasData(
                new Reservation { Id = 1, Name = "Ahmet", Surname = "Yılmaz", Email = "ahmet@example.com", Phone = "05550000000", PickUpLocationId = 1, DropOffLocationId = 2, CarId = 1, Age = 30, DriverLicenseYear = 8, Description = "Bebek koltuğu talebi", Status = "Onay Bekliyor" }
            );

            modelBuilder.Entity<Review>().HasData(
                new Review { Id = 1, CustomerName = "Elif K.", CustomerImage = "/images/person_1.jpg", Comment = "Araç temiz ve teslimat hızlıydı.", RaytingValue = "5", ReviewDate = new DateTime(2026, 4, 4), CarId = 1 }
            );

            modelBuilder.Entity<Service>().HasData(
                new Service { Id = 1, Title = "7/24 Destek", Description = "Yolculuk boyunca destek ekibimiz yanınızda.", IconUrl = "flaticon-support" },
                new Service { Id = 2, Title = "Tam Sigorta", Description = "Tüm kiralamalarda geniş kapsamlı güvence.", IconUrl = "flaticon-insurance" }
            );

            modelBuilder.Entity<SocialMedia>().HasData(
                new SocialMedia { Id = 1, Name = "Instagram", Icon = "fab fa-instagram", Url = "https://instagram.com/onionapp" },
                new SocialMedia { Id = 2, Name = "LinkedIn", Icon = "fab fa-linkedin", Url = "https://linkedin.com/company/onionapp" }
            );
        }

    }
}