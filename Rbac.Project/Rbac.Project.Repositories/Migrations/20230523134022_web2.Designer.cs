﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Rbac.Project.Repositories;

namespace Rbac.Project.Repositories.Migrations
{
    [DbContext(typeof(RbacDbContext))]
    [Migration("20230523134022_web2")]
    partial class web2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Rbac.Project.Domain.Menu", b =>
                {
                    b.Property<int>("MenuID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeleteName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("MenuAPI")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MenuName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MenuRoute")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MenuType")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ParentID")
                        .HasColumnType("int");

                    b.Property<string>("PutName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("PutTime")
                        .HasColumnType("datetime2");

                    b.HasKey("MenuID");

                    b.ToTable("Menu");
                });

            modelBuilder.Entity("Rbac.Project.Domain.Role", b =>
                {
                    b.Property<int>("RoleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeleteName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PutName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("PutTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleID");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("Rbac.Project.Domain.RoleMenu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MenuID")
                        .HasColumnType("int");

                    b.Property<int>("RoleID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MenuID");

                    b.HasIndex("RoleID");

                    b.ToTable("RoleMenu");
                });

            modelBuilder.Entity("Rbac.Project.Domain.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RoleID")
                        .HasColumnType("int");

                    b.Property<int>("U_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleID");

                    b.HasIndex("U_Id");

                    b.ToTable("UserRole");
                });

            modelBuilder.Entity("Rbac.Project.Domain.UserTable", b =>
                {
                    b.Property<int>("U_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeleteName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PutName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("PutTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("U_Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("U_LastLonginIP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("U_LastloginTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("U_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("U_Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("U_UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("U_Id");

                    b.ToTable("UserTable");
                });

            modelBuilder.Entity("Rbac.Project.Domain.RoleMenu", b =>
                {
                    b.HasOne("Rbac.Project.Domain.Menu", "FKMenu")
                        .WithMany()
                        .HasForeignKey("MenuID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Rbac.Project.Domain.Role", "FKRole")
                        .WithMany()
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FKMenu");

                    b.Navigation("FKRole");
                });

            modelBuilder.Entity("Rbac.Project.Domain.UserRole", b =>
                {
                    b.HasOne("Rbac.Project.Domain.Role", "FKRole")
                        .WithMany()
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Rbac.Project.Domain.UserTable", "FKUserTable")
                        .WithMany()
                        .HasForeignKey("U_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FKRole");

                    b.Navigation("FKUserTable");
                });
#pragma warning restore 612, 618
        }
    }
}