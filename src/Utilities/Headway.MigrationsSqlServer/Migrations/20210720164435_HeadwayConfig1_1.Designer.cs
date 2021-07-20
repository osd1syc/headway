﻿// <auto-generated />
using System;
using Headway.Repository.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Headway.MigrationsSqlServer.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210720164435_HeadwayConfig1_1")]
    partial class HeadwayConfig1_1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "6.0.0-preview.4.21253.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Headway.Core.Model.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ModuleId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<string>("Permission")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.HasIndex("ModuleId");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasFilter("[Name] IS NOT NULL");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Headway.Core.Model.Config", b =>
                {
                    b.Property<int>("ConfigId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Component")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ConfigTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModelApi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("NavigateBack")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NavigateTo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NavigateToConfig")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NavigateToPropertyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ConfigId");

                    b.HasIndex("ConfigTypeId");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasFilter("[Name] IS NOT NULL");

                    b.ToTable("Configs");
                });

            modelBuilder.Entity("Headway.Core.Model.ConfigItem", b =>
                {
                    b.Property<int>("ConfigItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Component")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ConfigId")
                        .HasColumnType("int");

                    b.Property<bool>("IsIdentity")
                        .HasColumnType("bit");

                    b.Property<bool>("IsTitle")
                        .HasColumnType("bit");

                    b.Property<string>("Label")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<string>("PropertyName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ConfigItemId");

                    b.HasIndex("ConfigId");

                    b.ToTable("ConfigItems");
                });

            modelBuilder.Entity("Headway.Core.Model.ConfigType", b =>
                {
                    b.Property<int>("ConfigTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ConfigTypeId");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasFilter("[Name] IS NOT NULL");

                    b.ToTable("ConfigTypes");
                });

            modelBuilder.Entity("Headway.Core.Model.FieldConfig", b =>
                {
                    b.Property<int>("FieldConfigId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DynamicComponentTypeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsIdField")
                        .HasColumnType("bit");

                    b.Property<bool>("IsTitleField")
                        .HasColumnType("bit");

                    b.Property<int?>("ModelConfigId")
                        .HasColumnType("int");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<string>("PropertyName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FieldConfigId");

                    b.HasIndex("ModelConfigId");

                    b.ToTable("FieldConfigs");
                });

            modelBuilder.Entity("Headway.Core.Model.ListConfig", b =>
                {
                    b.Property<int>("ListConfigId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Component")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConfigApi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("NavigateTo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NavigateToConfig")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NavigationPropertyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ListConfigId");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasFilter("[Name] IS NOT NULL");

                    b.ToTable("ListConfigs");
                });

            modelBuilder.Entity("Headway.Core.Model.ListItemConfig", b =>
                {
                    b.Property<int>("ListItemConfigId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("HeaderName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ListConfigId")
                        .HasColumnType("int");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<string>("PropertyName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ListItemConfigId");

                    b.HasIndex("ListConfigId");

                    b.ToTable("ListItemConfigs");
                });

            modelBuilder.Entity("Headway.Core.Model.MenuItem", b =>
                {
                    b.Property<int>("MenuItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ImageClass")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Permission")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MenuItemId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasFilter("[Name] IS NOT NULL");

                    b.ToTable("MenuItems");
                });

            modelBuilder.Entity("Headway.Core.Model.ModelConfig", b =>
                {
                    b.Property<int>("ModelConfigId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConfigApi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NavigateText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NavigateTo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ModelConfigId");

                    b.HasIndex("Model")
                        .IsUnique()
                        .HasFilter("[Model] IS NOT NULL");

                    b.ToTable("ModelConfigs");
                });

            modelBuilder.Entity("Headway.Core.Model.Module", b =>
                {
                    b.Property<int>("ModuleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<string>("Permission")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ModuleId");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasFilter("[Name] IS NOT NULL");

                    b.ToTable("Modules");
                });

            modelBuilder.Entity("Headway.Core.Model.Permission", b =>
                {
                    b.Property<int>("PermissionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("PermissionId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("Headway.Core.Model.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("RoleId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Headway.Core.Model.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("UserId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("PermissionRole", b =>
                {
                    b.Property<int>("PermissionsPermissionId")
                        .HasColumnType("int");

                    b.Property<int>("RolesRoleId")
                        .HasColumnType("int");

                    b.HasKey("PermissionsPermissionId", "RolesRoleId");

                    b.HasIndex("RolesRoleId");

                    b.ToTable("PermissionRole");
                });

            modelBuilder.Entity("PermissionUser", b =>
                {
                    b.Property<int>("PermissionsPermissionId")
                        .HasColumnType("int");

                    b.Property<int>("UsersUserId")
                        .HasColumnType("int");

                    b.HasKey("PermissionsPermissionId", "UsersUserId");

                    b.HasIndex("UsersUserId");

                    b.ToTable("PermissionUser");
                });

            modelBuilder.Entity("RoleUser", b =>
                {
                    b.Property<int>("RolesRoleId")
                        .HasColumnType("int");

                    b.Property<int>("UsersUserId")
                        .HasColumnType("int");

                    b.HasKey("RolesRoleId", "UsersUserId");

                    b.HasIndex("UsersUserId");

                    b.ToTable("RoleUser");
                });

            modelBuilder.Entity("Headway.Core.Model.Category", b =>
                {
                    b.HasOne("Headway.Core.Model.Module", "Module")
                        .WithMany("Categories")
                        .HasForeignKey("ModuleId");

                    b.Navigation("Module");
                });

            modelBuilder.Entity("Headway.Core.Model.Config", b =>
                {
                    b.HasOne("Headway.Core.Model.ConfigType", "ConfigType")
                        .WithMany()
                        .HasForeignKey("ConfigTypeId");

                    b.Navigation("ConfigType");
                });

            modelBuilder.Entity("Headway.Core.Model.ConfigItem", b =>
                {
                    b.HasOne("Headway.Core.Model.Config", null)
                        .WithMany("ConfigItems")
                        .HasForeignKey("ConfigId");
                });

            modelBuilder.Entity("Headway.Core.Model.FieldConfig", b =>
                {
                    b.HasOne("Headway.Core.Model.ModelConfig", null)
                        .WithMany("FieldConfigs")
                        .HasForeignKey("ModelConfigId");
                });

            modelBuilder.Entity("Headway.Core.Model.ListItemConfig", b =>
                {
                    b.HasOne("Headway.Core.Model.ListConfig", null)
                        .WithMany("ListItemConfigs")
                        .HasForeignKey("ListConfigId");
                });

            modelBuilder.Entity("Headway.Core.Model.MenuItem", b =>
                {
                    b.HasOne("Headway.Core.Model.Category", "Category")
                        .WithMany("MenuItems")
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("PermissionRole", b =>
                {
                    b.HasOne("Headway.Core.Model.Permission", null)
                        .WithMany()
                        .HasForeignKey("PermissionsPermissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Headway.Core.Model.Role", null)
                        .WithMany()
                        .HasForeignKey("RolesRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PermissionUser", b =>
                {
                    b.HasOne("Headway.Core.Model.Permission", null)
                        .WithMany()
                        .HasForeignKey("PermissionsPermissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Headway.Core.Model.User", null)
                        .WithMany()
                        .HasForeignKey("UsersUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RoleUser", b =>
                {
                    b.HasOne("Headway.Core.Model.Role", null)
                        .WithMany()
                        .HasForeignKey("RolesRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Headway.Core.Model.User", null)
                        .WithMany()
                        .HasForeignKey("UsersUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Headway.Core.Model.Category", b =>
                {
                    b.Navigation("MenuItems");
                });

            modelBuilder.Entity("Headway.Core.Model.Config", b =>
                {
                    b.Navigation("ConfigItems");
                });

            modelBuilder.Entity("Headway.Core.Model.ListConfig", b =>
                {
                    b.Navigation("ListItemConfigs");
                });

            modelBuilder.Entity("Headway.Core.Model.ModelConfig", b =>
                {
                    b.Navigation("FieldConfigs");
                });

            modelBuilder.Entity("Headway.Core.Model.Module", b =>
                {
                    b.Navigation("Categories");
                });
#pragma warning restore 612, 618
        }
    }
}
