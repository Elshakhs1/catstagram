﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Web_Programming_Assignment_2021.Data;

namespace Web_Programming_Assignment_2023.Migrations
{
    [DbContext(typeof(CatstagramContext))]
    [Migration("20230420213916_inital")]
    partial class inital
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Web_Programming_Assignment_2021.Models.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Hashtag")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoFile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("PostId");

                    b.HasIndex("UserId");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            PostId = 1,
                            Comment = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quisquam necessitatibus incidunt ut officiis explicabo inventore.",
                            DateCreated = new DateTime(2023, 4, 20, 21, 39, 16, 105, DateTimeKind.Utc).AddTicks(1462),
                            DateModified = new DateTime(2023, 4, 20, 21, 39, 16, 105, DateTimeKind.Utc).AddTicks(2307),
                            Hashtag = "#cute #cutie #kitty #pretty",
                            PhotoFile = "img2.jpg",
                            UserId = 1
                        },
                        new
                        {
                            PostId = 2,
                            Comment = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quisquam necessitatibus incidunt ut officiis explicabo inventore.",
                            DateCreated = new DateTime(2023, 4, 20, 21, 39, 16, 105, DateTimeKind.Utc).AddTicks(3802),
                            DateModified = new DateTime(2023, 4, 20, 21, 39, 16, 105, DateTimeKind.Utc).AddTicks(3815),
                            Hashtag = "#cute #happy",
                            PhotoFile = "flower.jpg",
                            UserId = 1
                        },
                        new
                        {
                            PostId = 3,
                            Comment = "Quisquam necessitatibus incidunt ut officiis explicabo inventore.",
                            DateCreated = new DateTime(2023, 4, 20, 21, 39, 16, 105, DateTimeKind.Utc).AddTicks(3887),
                            DateModified = new DateTime(2023, 4, 20, 21, 39, 16, 105, DateTimeKind.Utc).AddTicks(3888),
                            Hashtag = "#kitty",
                            PhotoFile = "beautiful.jpg",
                            UserId = 2
                        },
                        new
                        {
                            PostId = 4,
                            Comment = "Ipsum dolor sit amet consectetur adipisicing elit.",
                            DateCreated = new DateTime(2023, 4, 20, 21, 39, 16, 105, DateTimeKind.Utc).AddTicks(3912),
                            DateModified = new DateTime(2023, 4, 20, 21, 39, 16, 105, DateTimeKind.Utc).AddTicks(3913),
                            Hashtag = "#smile #happy",
                            PhotoFile = "smile.jpg",
                            UserId = 3
                        });
                });

            modelBuilder.Entity("Web_Programming_Assignment_2021.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AvatarFile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            AvatarFile = "flower.jpg",
                            Email = "katrin@gmail.com",
                            Password = "PaS_S",
                            Status = "Love my life 😍",
                            Username = "_Cutie_34"
                        },
                        new
                        {
                            UserId = 2,
                            AvatarFile = "vdct5dfk.jpg",
                            Email = "lolita_hanta@gmail.com",
                            Password = "Ger34_",
                            Status = "Artist/Illustrator/Commissions Opened 💖",
                            Username = "LolitaKit"
                        },
                        new
                        {
                            UserId = 3,
                            Email = "thomasLi@gmail.com",
                            Password = "ToMik",
                            Username = "FunnyTom"
                        });
                });

            modelBuilder.Entity("Web_Programming_Assignment_2021.Models.Post", b =>
                {
                    b.HasOne("Web_Programming_Assignment_2021.Models.User", "User")
                        .WithMany("Posts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Web_Programming_Assignment_2021.Models.User", b =>
                {
                    b.Navigation("Posts");
                });
#pragma warning restore 612, 618
        }
    }
}
