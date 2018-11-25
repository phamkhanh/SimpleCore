﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SimpleCore.Domain.Data.EF;

namespace SimpleCore.Domain.Data.EF.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<Guid>("RoleId");

                    b.HasKey("Id");

                    b.ToTable("AppRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.ToTable("AppUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("ProviderKey");

                    b.HasKey("UserId");

                    b.ToTable("AppUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("RoleId");

                    b.Property<Guid>("UserId");

                    b.HasKey("RoleId", "UserId");

                    b.ToTable("AppUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId");

                    b.ToTable("AppUserTokens");
                });

            modelBuilder.Entity("SimpleCore.Domain.Data.Entities.Announcement", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content")
                        .HasMaxLength(250);

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateModified");

                    b.Property<int>("Status");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Announcements");
                });

            modelBuilder.Entity("SimpleCore.Domain.Data.Entities.AnnouncementUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AnnouncementId")
                        .IsRequired();

                    b.Property<bool?>("HasRead");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("AnnouncementId");

                    b.ToTable("AnnouncementUsers");
                });

            modelBuilder.Entity("SimpleCore.Domain.Data.Entities.AppRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<string>("Description")
                        .HasMaxLength(250);

                    b.Property<string>("Name");

                    b.Property<string>("NormalizedName");

                    b.HasKey("Id");

                    b.ToTable("AppRoles");
                });

            modelBuilder.Entity("SimpleCore.Domain.Data.Entities.AppUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("Avatar");

                    b.Property<decimal>("Balance");

                    b.Property<DateTime?>("BirthDay");

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateModified");

                    b.Property<string>("Email");

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FullName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail");

                    b.Property<string>("NormalizedUserName");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<int>("Status");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("AppUsers");
                });

            modelBuilder.Entity("SimpleCore.Domain.Data.Entities.Function", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(128)");

                    b.Property<string>("IconCss");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("ParentId")
                        .HasMaxLength(128);

                    b.Property<int>("SortOrder");

                    b.Property<int>("Status");

                    b.Property<string>("URL")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("Functions");
                });

            modelBuilder.Entity("SimpleCore.Domain.Data.Entities.Permission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("CanCreate");

                    b.Property<bool>("CanDelete");

                    b.Property<bool>("CanRead");

                    b.Property<bool>("CanUpdate");

                    b.Property<string>("FunctionId")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<Guid>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("FunctionId");

                    b.HasIndex("RoleId");

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("SimpleCore.Domain.Data.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<string>("Content");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateModified");

                    b.Property<string>("Description")
                        .HasMaxLength(255);

                    b.Property<bool?>("HomeFlag");

                    b.Property<bool?>("HotFlag");

                    b.Property<string>("Image")
                        .HasMaxLength(255);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<decimal>("OriginalPrice");

                    b.Property<decimal>("Price");

                    b.Property<decimal?>("PromotionPrice");

                    b.Property<string>("SeoAlias")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("SeoDescription")
                        .HasMaxLength(255);

                    b.Property<string>("SeoKeywords")
                        .HasMaxLength(255);

                    b.Property<string>("SeoPageTitle");

                    b.Property<int>("Status");

                    b.Property<string>("Tags")
                        .HasMaxLength(255);

                    b.Property<string>("Unit")
                        .HasMaxLength(255);

                    b.Property<int?>("ViewCount");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("SimpleCore.Domain.Data.Entities.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateModified");

                    b.Property<string>("Description");

                    b.Property<bool?>("HomeFlag");

                    b.Property<int?>("HomeOrder");

                    b.Property<string>("Image");

                    b.Property<string>("Name");

                    b.Property<int?>("ParentId");

                    b.Property<string>("SeoAlias");

                    b.Property<string>("SeoDescription");

                    b.Property<string>("SeoKeywords");

                    b.Property<string>("SeoPageTitle");

                    b.Property<int>("SortOrder");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.ToTable("ProductCategories");
                });

            modelBuilder.Entity("SimpleCore.Domain.Data.Entities.ProductImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Caption")
                        .HasMaxLength(250);

                    b.Property<string>("Path")
                        .HasMaxLength(250);

                    b.Property<int>("ProductId");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductImages");
                });

            modelBuilder.Entity("SimpleCore.Domain.Data.Entities.ProductQuantity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ColorId");

                    b.Property<int>("ProductId");

                    b.Property<int>("Quantity");

                    b.Property<int>("SizeId");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductQuantities");
                });

            modelBuilder.Entity("SimpleCore.Domain.Data.Entities.ProductTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProductId");

                    b.Property<string>("TagId")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("TagId");

                    b.ToTable("ProductTags");
                });

            modelBuilder.Entity("SimpleCore.Domain.Data.Entities.Tag", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("SimpleCore.Domain.Data.Entities.Announcement", b =>
                {
                    b.HasOne("SimpleCore.Domain.Data.Entities.AppUser", "AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SimpleCore.Domain.Data.Entities.AnnouncementUser", b =>
                {
                    b.HasOne("SimpleCore.Domain.Data.Entities.Announcement", "Announcement")
                        .WithMany("AnnouncementUsers")
                        .HasForeignKey("AnnouncementId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SimpleCore.Domain.Data.Entities.Permission", b =>
                {
                    b.HasOne("SimpleCore.Domain.Data.Entities.Function", "Function")
                        .WithMany()
                        .HasForeignKey("FunctionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SimpleCore.Domain.Data.Entities.AppRole", "AppRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SimpleCore.Domain.Data.Entities.Product", b =>
                {
                    b.HasOne("SimpleCore.Domain.Data.Entities.ProductCategory", "ProductCategory")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SimpleCore.Domain.Data.Entities.ProductImage", b =>
                {
                    b.HasOne("SimpleCore.Domain.Data.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SimpleCore.Domain.Data.Entities.ProductQuantity", b =>
                {
                    b.HasOne("SimpleCore.Domain.Data.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SimpleCore.Domain.Data.Entities.ProductTag", b =>
                {
                    b.HasOne("SimpleCore.Domain.Data.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SimpleCore.Domain.Data.Entities.Tag", "Tag")
                        .WithMany()
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}