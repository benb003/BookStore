﻿// <auto-generated />
using System;
using BookStore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookStore.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231216202336_shoppingcart")]
    partial class shoppingcart
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookStore.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDateTime = new DateTime(2023, 12, 16, 21, 23, 35, 807, DateTimeKind.Local).AddTicks(3105),
                            DisplayOrder = 1,
                            Name = "History"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDateTime = new DateTime(2023, 12, 16, 21, 23, 35, 807, DateTimeKind.Local).AddTicks(3167),
                            DisplayOrder = 2,
                            Name = "Science"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDateTime = new DateTime(2023, 12, 16, 21, 23, 35, 807, DateTimeKind.Local).AddTicks(3169),
                            DisplayOrder = 3,
                            Name = "Literature"
                        });
                });

            modelBuilder.Entity("BookStore.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 4,
                            Author = "Yuval Noah Harari",
                            CategoryId = 1,
                            Description = "Yuval Noah Harari, author of the critically acclaimed New York Times best seller and international phenomenon Sapiens, returns with an equally original, compelling, and provocative book, turning his focus toward humanity's future and our quest to upgrade humans into gods.",
                            ISBN = "B01MYZ4OUW",
                            Price = 250.0,
                            Title = "Homo Deus: A Brief History of Tomorrow"
                        },
                        new
                        {
                            Id = 5,
                            Author = "Bill Bryson",
                            CategoryId = 1,
                            Description = "One of the world’s most beloved and bestselling writers takes his ultimate journey -- into the most intriguing and intractable questions that science seeks to answer.",
                            ISBN = "B0000U7N00",
                            Price = 205.0,
                            Title = "A Short History of Nearly Everything"
                        },
                        new
                        {
                            Id = 6,
                            Author = "Stephen Fry",
                            CategoryId = 1,
                            Description = "Here are the thrills, grandeur, and unabashed fun of the Greek myths, stylishly retold by Stephen Fry. The legendary writer, actor, and comedian breathes life into ancient tales, from Pandora's box to Prometheus's fire, and transforms the adventures of Zeus and the Olympians into emotionally resonant and deeply funny stories, without losing any of their original wonder. Learned notes from the author offer rich cultural context. ",
                            ISBN = "B07WKRP2F2",
                            Price = 295.0,
                            Title = "Mythos "
                        },
                        new
                        {
                            Id = 7,
                            Author = "Padraic Colum",
                            CategoryId = 1,
                            Description = "Before time as we know it began, gods and goddesses lived in the city of Asgard. Odin All Father crossed the Rainbow Bridge to walk among men in Midgard. Thor defended Asgard with his mighty hammer. Mischievous Loki was constantly getting into trouble with the other gods, and dragons and giants walked free.",
                            ISBN = "B071KZGP84",
                            Price = 195.0,
                            Title = "The Children of Odin"
                        },
                        new
                        {
                            Id = 8,
                            Author = "George RR Martin",
                            CategoryId = 3,
                            Description = "Winter is coming. Such is the stern motto of House Stark, the northernmost of the fiefdoms that owe allegiance to King Robert Baratheon in far-off King's Landing. There Eddard Stark of Winterfell rules in Robert's name.",
                            ISBN = "B0001DBI1Q",
                            Price = 305.0,
                            Title = "A Game of Thrones"
                        },
                        new
                        {
                            Id = 9,
                            Author = "J.R.R. Tolkien",
                            CategoryId = 3,
                            Description = "With its first broadcast on BBC Radio 4 on March 8th, 1981, this dramatised tale of Middle Earth became an instant global classic. It boasts a truly outstanding cast including Ian Holm (as Frodo), Sir Michael Hordern (as Gandalf), Robert Stephens (as Aragorn), Bill Nighy (as Sam Gamgee) and John Le Mesurier (as Bilbo).",
                            ISBN = "B000VTQAVS",
                            Price = 345.0,
                            Title = "The Lord of the Rings: The Fellowship of the Ring"
                        },
                        new
                        {
                            Id = 10,
                            Author = "Mark Miodowink",
                            CategoryId = 3,
                            Description = "Why is glass see-through? What makes elastic stretchy? Why does a paper clip bend? These are the sorts of questions that Mark Miodownik is constantly asking himself. A globally renowned materials scientist, Miodownik has spent his life exploring objects as ordinary as an envelope and as unexpected as concrete cloth, uncovering the fascinating secrets that hold together our physical world.",
                            ISBN = "B00LOMPF5S",
                            Price = 275.0,
                            Title = "Stuff Matters"
                        },
                        new
                        {
                            Id = 11,
                            Author = "Tim James",
                            CategoryId = 3,
                            Description = "In 2016, with the addition of four final elements - nihonium, moscovium, tennessine and oganesson - to make a total of 118 elements, the periodic table was finally complete, rendering any pre-existing books on the subject obsolete.",
                            ISBN = "B07D5GTVYQ",
                            Price = 220.0,
                            Title = "How the Periodic Table Can Now Explain Everything"
                        },
                        new
                        {
                            Id = 12,
                            Author = "Nancy Forbes",
                            CategoryId = 3,
                            Description = "Two of the boldest and most creative scientists of all time were Michael Faraday (1791-1867) and James Clerk Maxwell (1831-1879). This is the story of how these two men - separated in age by 40 years - discovered the existence of the electromagnetic field and devised a radically new theory which overturned the strictly mechanical view of the world that had prevailed since Newton's time. ",
                            ISBN = "B08QTQGQP4",
                            Price = 260.0,
                            Title = "How Two Men Revolutionized Physics"
                        },
                        new
                        {
                            Id = 13,
                            Author = "Michael G. Raymer",
                            CategoryId = 3,
                            Description = "Around 1900, physicists started to discover particles like electrons, protons, and neutrons, and with these discoveries believed they could predict the internal behavior of the atom. However, once their predictions were compared to the results of experiments in the real world, it became clear that the principles of classical physics and mechanics were far from capable of explaining phenomena on the atomic scale.",
                            ISBN = "B07LFK95Y2",
                            Price = 235.0,
                            Title = "Quantum Physics"
                        },
                        new
                        {
                            Id = 14,
                            Author = "Albert Einstein",
                            CategoryId = 3,
                            Description = "Albert Einstein described Relativity as a \"popular explosion\" of his famous theory. Written in 1916, it introduced the lay audience to the remarkable perspective that had overturned theoretical physics.",
                            ISBN = "B002XGLDAA",
                            Price = 175.0,
                            Title = "The Special and the General Theory "
                        });
                });

            modelBuilder.Entity("BookStore.Models.ShoppingCart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ApplicationUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("ProductId");

                    b.ToTable("ShoppingCarts");
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

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(21)
                        .HasColumnType("nvarchar(21)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

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

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("BookStore.Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAddress")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("ApplicationUser");
                });

            modelBuilder.Entity("BookStore.Models.Product", b =>
                {
                    b.HasOne("BookStore.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BookStore.Models.ShoppingCart", b =>
                {
                    b.HasOne("BookStore.Models.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookStore.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationUser");

                    b.Navigation("Product");
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
