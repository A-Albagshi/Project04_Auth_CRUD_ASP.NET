﻿// <auto-generated />
using System;
using AppStore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AppStore.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210619121731_CustomUserName")]
    partial class CustomUserName
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AppStore.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("AppStore.Models.AppCategoryModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AppId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AppId");

                    b.HasIndex("CategoryId");

                    b.ToTable("AppsCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AppId = 1,
                            CategoryId = 1
                        },
                        new
                        {
                            Id = 2,
                            AppId = 1,
                            CategoryId = 3
                        },
                        new
                        {
                            Id = 3,
                            AppId = 2,
                            CategoryId = 2
                        },
                        new
                        {
                            Id = 4,
                            AppId = 2,
                            CategoryId = 3
                        },
                        new
                        {
                            Id = 5,
                            AppId = 3,
                            CategoryId = 1
                        },
                        new
                        {
                            Id = 6,
                            AppId = 3,
                            CategoryId = 2
                        },
                        new
                        {
                            Id = 7,
                            AppId = 3,
                            CategoryId = 3
                        },
                        new
                        {
                            Id = 8,
                            AppId = 4,
                            CategoryId = 4
                        },
                        new
                        {
                            Id = 9,
                            AppId = 4,
                            CategoryId = 5
                        },
                        new
                        {
                            Id = 10,
                            AppId = 4,
                            CategoryId = 6
                        },
                        new
                        {
                            Id = 11,
                            AppId = 5,
                            CategoryId = 6
                        },
                        new
                        {
                            Id = 12,
                            AppId = 5,
                            CategoryId = 7
                        },
                        new
                        {
                            Id = 13,
                            AppId = 6,
                            CategoryId = 4
                        },
                        new
                        {
                            Id = 14,
                            AppId = 6,
                            CategoryId = 8
                        });
                });

            modelBuilder.Entity("AppStore.Models.AppModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("AverageRating")
                        .HasColumnType("real");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DownloadsCount")
                        .HasColumnType("int");

                    b.Property<string>("GeneralCategory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Size")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Apps");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AverageRating = 0f,
                            Description = "Massenger App",
                            DownloadsCount = 0,
                            GeneralCategory = "Social Media",
                            Icon = "https://upload.wikimedia.org/wikipedia/commons/6/6b/WhatsApp.svg",
                            Name = "Whatsapp",
                            Size = "100MB"
                        },
                        new
                        {
                            Id = 2,
                            AverageRating = 0f,
                            Description = "Tweets App",
                            DownloadsCount = 0,
                            GeneralCategory = "Social Media",
                            Icon = "https://png.pngtree.com/png-clipart/20190613/original/pngtree-twitter-icon-png-image_3584901.jpg",
                            Name = "Twitter",
                            Size = "40MB"
                        },
                        new
                        {
                            Id = 3,
                            AverageRating = 0f,
                            Description = "Social Media App",
                            DownloadsCount = 0,
                            GeneralCategory = "Social Media",
                            Icon = "https://facebookbrand.com/wp-content/uploads/2019/04/f_logo_RGB-Hex-Blue_512.png?w=512&h=512",
                            Name = "FaceBook",
                            Size = "150MB"
                        },
                        new
                        {
                            Id = 4,
                            AverageRating = 0f,
                            Description = "League Of Legends On Mobile",
                            DownloadsCount = 0,
                            GeneralCategory = "Games",
                            Icon = "https://static.wikia.nocookie.net/leagueoflegends/images/b/be/Wild_Rift_icon.png/revision/latest?cb=20191018194406",
                            Name = "Wild Rift",
                            Size = "3GB"
                        },
                        new
                        {
                            Id = 5,
                            AverageRating = 0f,
                            Description = "Chess Game",
                            DownloadsCount = 0,
                            GeneralCategory = "Games",
                            Icon = "https://media.istockphoto.com/vectors/chess-icon-on-white-background-vector-id931757036",
                            Name = "Chess",
                            Size = "20MB"
                        },
                        new
                        {
                            Id = 6,
                            AverageRating = 0f,
                            Description = "Building, Survival Game",
                            DownloadsCount = 0,
                            GeneralCategory = "Games",
                            Icon = "https://external-preview.redd.it/INBHMCNdcPNCBvgGn3yQ-RH4jiAhFP4bde7-wCC2xiw.png?auto=webp&s=7fbcf884991ea6c916da84752af364fbf962687b",
                            Name = "Minecraft",
                            Size = "250MB"
                        });
                });

            modelBuilder.Entity("AppStore.Models.CategoryModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Chatting"
                        },
                        new
                        {
                            Id = 2,
                            Name = "News"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Social Networking"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Adventure"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Action"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Strategy"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Puzzle"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Building"
                        });
                });

            modelBuilder.Entity("AppStore.Models.DownloadModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AppId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DownloadDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("AppId");

                    b.HasIndex("UserId");

                    b.ToTable("Downloads");
                });

            modelBuilder.Entity("AppStore.Models.RatingModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AppId")
                        .HasColumnType("int");

                    b.Property<float>("Rating")
                        .HasColumnType("real");

                    b.Property<string>("Review")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReviewDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("AppId");

                    b.HasIndex("UserId");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("AppStore.Models.AppCategoryModel", b =>
                {
                    b.HasOne("AppStore.Models.AppModel", "App")
                        .WithMany("AppCategory")
                        .HasForeignKey("AppId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppStore.Models.CategoryModel", "Category")
                        .WithMany("AppCategory")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("App");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("AppStore.Models.DownloadModel", b =>
                {
                    b.HasOne("AppStore.Models.AppModel", "App")
                        .WithMany("Downloads")
                        .HasForeignKey("AppId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppStore.Data.ApplicationUser", "User")
                        .WithMany("Downloads")
                        .HasForeignKey("UserId");

                    b.Navigation("App");

                    b.Navigation("User");
                });

            modelBuilder.Entity("AppStore.Models.RatingModel", b =>
                {
                    b.HasOne("AppStore.Models.AppModel", "App")
                        .WithMany("Ratings")
                        .HasForeignKey("AppId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppStore.Data.ApplicationUser", "User")
                        .WithMany("Ratings")
                        .HasForeignKey("UserId");

                    b.Navigation("App");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("AppStore.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("AppStore.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppStore.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("AppStore.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AppStore.Data.ApplicationUser", b =>
                {
                    b.Navigation("Downloads");

                    b.Navigation("Ratings");
                });

            modelBuilder.Entity("AppStore.Models.AppModel", b =>
                {
                    b.Navigation("AppCategory");

                    b.Navigation("Downloads");

                    b.Navigation("Ratings");
                });

            modelBuilder.Entity("AppStore.Models.CategoryModel", b =>
                {
                    b.Navigation("AppCategory");
                });
#pragma warning restore 612, 618
        }
    }
}
