﻿// <auto-generated />
using System;
using IdentidadIntegral.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IdentidadIntegral.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("IdentidadIntegral.Models.Action", b =>
                {
                    b.Property<int>("IdAction")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdAction"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<int>("IdModule")
                        .HasColumnType("int");

                    b.Property<int>("ModuleIdModule")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("IdAction");

                    b.HasIndex("ModuleIdModule");

                    b.ToTable("Actions");
                });

            modelBuilder.Entity("IdentidadIntegral.Models.Company", b =>
                {
                    b.Property<int>("IdCompany")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCompany"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("IdCompany");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("IdentidadIntegral.Models.Module", b =>
                {
                    b.Property<int>("IdModule")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdModule"));

                    b.Property<string>("BaseUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<int>("IdProject")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProjectIdProject")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("IdModule");

                    b.HasIndex("ProjectIdProject");

                    b.ToTable("Modules");
                });

            modelBuilder.Entity("IdentidadIntegral.Models.Project", b =>
                {
                    b.Property<int>("IdProject")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProject"));

                    b.Property<string>("BaseUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CompanyIdCompany")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<int>("IdCompany")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("IdProject");

                    b.HasIndex("CompanyIdCompany");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("IdentidadIntegral.Models.Role", b =>
                {
                    b.Property<int>("IdRole")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdRole"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("IdRole");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("IdentidadIntegral.Models.RoleAction", b =>
                {
                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("ActionId")
                        .HasColumnType("int");

                    b.HasKey("RoleId", "ActionId");

                    b.HasIndex("ActionId");

                    b.ToTable("RoleAction");
                });

            modelBuilder.Entity("IdentidadIntegral.Models.User", b =>
                {
                    b.Property<int>("IdUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdUser"));

                    b.Property<string>("AzureAD")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CompanyIdCompany")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdCompany")
                        .HasColumnType("int");

                    b.Property<int?>("IdEmployeeSIAF")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdUser");

                    b.HasIndex("CompanyIdCompany");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("IdentidadIntegral.Models.UserProject", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "ProjectId");

                    b.HasIndex("ProjectId");

                    b.ToTable("UserProject");
                });

            modelBuilder.Entity("RoleUser", b =>
                {
                    b.Property<int>("RolesIdRole")
                        .HasColumnType("int");

                    b.Property<int>("UsersIdUser")
                        .HasColumnType("int");

                    b.HasKey("RolesIdRole", "UsersIdUser");

                    b.HasIndex("UsersIdUser");

                    b.ToTable("RoleUser");
                });

            modelBuilder.Entity("IdentidadIntegral.Models.Action", b =>
                {
                    b.HasOne("IdentidadIntegral.Models.Module", "Module")
                        .WithMany("Actions")
                        .HasForeignKey("ModuleIdModule")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Module");
                });

            modelBuilder.Entity("IdentidadIntegral.Models.Module", b =>
                {
                    b.HasOne("IdentidadIntegral.Models.Project", "Project")
                        .WithMany("Modules")
                        .HasForeignKey("ProjectIdProject")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");
                });

            modelBuilder.Entity("IdentidadIntegral.Models.Project", b =>
                {
                    b.HasOne("IdentidadIntegral.Models.Company", null)
                        .WithMany("Projects")
                        .HasForeignKey("CompanyIdCompany");
                });

            modelBuilder.Entity("IdentidadIntegral.Models.RoleAction", b =>
                {
                    b.HasOne("IdentidadIntegral.Models.Action", "Action")
                        .WithMany("RoleActions")
                        .HasForeignKey("ActionId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("IdentidadIntegral.Models.Role", "Role")
                        .WithMany("RoleActions")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Action");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("IdentidadIntegral.Models.User", b =>
                {
                    b.HasOne("IdentidadIntegral.Models.Company", "Company")
                        .WithMany("Users")
                        .HasForeignKey("CompanyIdCompany")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("IdentidadIntegral.Models.UserProject", b =>
                {
                    b.HasOne("IdentidadIntegral.Models.Project", "Project")
                        .WithMany("UserProjects")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("IdentidadIntegral.Models.User", "User")
                        .WithMany("UserProjects")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Project");

                    b.Navigation("User");
                });

            modelBuilder.Entity("RoleUser", b =>
                {
                    b.HasOne("IdentidadIntegral.Models.Role", null)
                        .WithMany()
                        .HasForeignKey("RolesIdRole")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IdentidadIntegral.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UsersIdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IdentidadIntegral.Models.Action", b =>
                {
                    b.Navigation("RoleActions");
                });

            modelBuilder.Entity("IdentidadIntegral.Models.Company", b =>
                {
                    b.Navigation("Projects");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("IdentidadIntegral.Models.Module", b =>
                {
                    b.Navigation("Actions");
                });

            modelBuilder.Entity("IdentidadIntegral.Models.Project", b =>
                {
                    b.Navigation("Modules");

                    b.Navigation("UserProjects");
                });

            modelBuilder.Entity("IdentidadIntegral.Models.Role", b =>
                {
                    b.Navigation("RoleActions");
                });

            modelBuilder.Entity("IdentidadIntegral.Models.User", b =>
                {
                    b.Navigation("UserProjects");
                });
#pragma warning restore 612, 618
        }
    }
}
