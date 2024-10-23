﻿// <auto-generated />
using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WeCareWebApp.EF;

namespace WeCareWebApp.Migrations
{
    [DbContext(typeof(WeCareDbContext))]
    [Migration("20210627103523_InitialMIgrationxx")]
    partial class InitialMIgrationxx
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WeCareWebApp.Entities.Barber", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasAnnotation("DatabaseGenerated", DatabaseGeneratedOption.None);

                    b.Property<Guid?>("CreatedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOnDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(125)")
                        .HasMaxLength(125);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Names")
                        .HasColumnType("nvarchar(125)")
                        .HasMaxLength(125);

                    b.Property<int?>("PartnerId")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CreatedById");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasFilter("[Email] IS NOT NULL");

                    b.HasIndex("PartnerId");

                    b.HasIndex("Phone")
                        .IsUnique()
                        .HasFilter("[Phone] IS NOT NULL");

                    b.HasIndex("UserId");

                    b.ToTable("Barber","Bzn");
                });

            modelBuilder.Entity("WeCareWebApp.Entities.BusinessClient", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<DateTime>("CreatedOnDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(125)")
                        .HasMaxLength(125);

                    b.Property<string>("SerialNumber")
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.HasKey("Id");

                    b.ToTable("BusinessClient","Bzn");
                });

            modelBuilder.Entity("WeCareWebApp.Entities.BusinessService", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasAnnotation("DatabaseGenerated", DatabaseGeneratedOption.None);

                    b.Property<DateTime>("CreatedOnDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(125)")
                        .HasMaxLength(125);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasFilter("[Name] IS NOT NULL");

                    b.ToTable("BusinessService","Bzn");
                });

            modelBuilder.Entity("WeCareWebApp.Entities.ClientMovement", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasAnnotation("DatabaseGenerated", DatabaseGeneratedOption.None);

                    b.Property<string>("ClientId")
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime>("CreatedOnDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DestinationLatitude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DestinationLongitude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OriginLatitude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OriginLongitude")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("ClientMovement","Security");
                });

            modelBuilder.Entity("WeCareWebApp.Entities.Partner", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasAnnotation("DatabaseGenerated", DatabaseGeneratedOption.None);

                    b.Property<Guid?>("CreatedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOnDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DestinationLatitude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DestinationLongitude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(125)")
                        .HasMaxLength(125);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.Property<string>("MomoCode")
                        .HasColumnType("nvarchar(8)")
                        .HasMaxLength(8);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CreatedById");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasFilter("[Email] IS NOT NULL");

                    b.HasIndex("MomoCode")
                        .IsUnique()
                        .HasFilter("[MomoCode] IS NOT NULL");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasFilter("[Name] IS NOT NULL");

                    b.HasIndex("Phone")
                        .IsUnique()
                        .HasFilter("[Phone] IS NOT NULL");

                    b.HasIndex("UserId");

                    b.ToTable("Partner","Bzn");
                });

            modelBuilder.Entity("WeCareWebApp.Entities.PartnerService", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasAnnotation("DatabaseGenerated", DatabaseGeneratedOption.None);

                    b.Property<int>("BusinessServiceId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOnDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int?>("MinDuration")
                        .HasColumnType("int");

                    b.Property<int>("PartnerId")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int?>("Seats")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BusinessServiceId");

                    b.HasIndex("PartnerId");

                    b.ToTable("PartnerService","Bzn");
                });

            modelBuilder.Entity("WeCareWebApp.Entities.PartnerServiceImage", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasAnnotation("DatabaseGenerated", DatabaseGeneratedOption.None);

                    b.Property<byte[]>("ImageData")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.ToTable("PartnerServiceImage","Bzn");
                });

            modelBuilder.Entity("WeCareWebApp.Entities.Reservation", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(11)")
                        .HasMaxLength(11);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("BusinessClientId")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(6)")
                        .HasMaxLength(6);

                    b.Property<int?>("PartnerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReservationDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ReservationStatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BusinessClientId");

                    b.HasIndex("PartnerId");

                    b.HasIndex("ReservationStatusId");

                    b.ToTable("Reservation","Bzn");
                });

            modelBuilder.Entity("WeCareWebApp.Entities.ReservationDetail", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(13)")
                        .HasMaxLength(13);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("BarberId")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(6)")
                        .HasMaxLength(6);

                    b.Property<bool>("IsServed")
                        .HasColumnType("bit");

                    b.Property<int>("PartnerServiceId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReservationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ReservationId")
                        .HasColumnType("nvarchar(11)");

                    b.HasKey("Id");

                    b.HasIndex("BarberId");

                    b.HasIndex("PartnerServiceId");

                    b.HasIndex("ReservationId");

                    b.ToTable("ReservationDetail","Bzn");
                });

            modelBuilder.Entity("WeCareWebApp.Entities.ReservationStatus", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasAnnotation("DatabaseGenerated", DatabaseGeneratedOption.None);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(125)")
                        .HasMaxLength(125);

                    b.HasKey("Id");

                    b.ToTable("ReservationStatus","Bzn");
                });

            modelBuilder.Entity("WeCareWebApp.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasAnnotation("DatabaseGenerated", DatabaseGeneratedOption.None);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(125)")
                        .HasMaxLength(125);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasFilter("[Name] IS NOT NULL");

                    b.ToTable("Role","Security");
                });

            modelBuilder.Entity("WeCareWebApp.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOnDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Names")
                        .HasColumnType("nvarchar(125)")
                        .HasMaxLength(125);

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(125)")
                        .HasMaxLength(125);

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(125)")
                        .HasMaxLength(125);

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("Username")
                        .IsUnique()
                        .HasFilter("[Username] IS NOT NULL");

                    b.ToTable("User","Security");
                });

            modelBuilder.Entity("WeCareWebApp.Models.PartnerDto", b =>
                {
                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("CreatedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOnDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DestinationLatitude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DestinationLongitude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MomoCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.ToTable("PartnerDtos");
                });

            modelBuilder.Entity("WeCareWebApp.Models.PartnerServiceDispDto", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Partner")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PartnerId")
                        .HasColumnType("int");

                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.Property<byte[]>("ServiceImage")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("ServiceName")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("PartnerServiceDispDtos");
                });

            modelBuilder.Entity("WeCareWebApp.Models.PartnerServiceDto", b =>
                {
                    b.Property<DateTime>("CreatedOnDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DestinationLatitude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DestinationLongitude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<byte[]>("ImageData")
                        .HasColumnType("varbinary(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int?>("MinDuration")
                        .HasColumnType("int");

                    b.Property<string>("Partner")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PartnerId")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int?>("Seats")
                        .HasColumnType("int");

                    b.Property<string>("Service")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.ToTable("PartnerServiceDtos");
                });

            modelBuilder.Entity("WeCareWebApp.Models.ReservationDto", b =>
                {
                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("Client")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClientId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Partner")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PartnerId")
                        .HasColumnType("int");

                    b.Property<string>("ReservationStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ReservationStatusId")
                        .HasColumnType("int");

                    b.ToTable("ReservationDtos");
                });

            modelBuilder.Entity("WeCareWebApp.Models.ScalarValueDto", b =>
                {
                    b.Property<string>("Result")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("ScalarValueDtos");
                });

            modelBuilder.Entity("WeCareWebApp.Models.UserAuthenticationDto", b =>
                {
                    b.Property<string>("ClientId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOnDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Names")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PartnerId")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("UserAuthenticationDtos");
                });

            modelBuilder.Entity("WeCareWebApp.Models.UserDto", b =>
                {
                    b.Property<DateTime>("CreatedOnDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Names")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("UserDtos");
                });

            modelBuilder.Entity("WeCareWebApp.Entities.Barber", b =>
                {
                    b.HasOne("WeCareWebApp.Entities.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById");

                    b.HasOne("WeCareWebApp.Entities.Partner", "Partner")
                        .WithMany()
                        .HasForeignKey("PartnerId");

                    b.HasOne("WeCareWebApp.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("WeCareWebApp.Entities.ClientMovement", b =>
                {
                    b.HasOne("WeCareWebApp.Entities.BusinessClient", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId");
                });

            modelBuilder.Entity("WeCareWebApp.Entities.Partner", b =>
                {
                    b.HasOne("WeCareWebApp.Entities.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById");

                    b.HasOne("WeCareWebApp.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WeCareWebApp.Entities.PartnerService", b =>
                {
                    b.HasOne("WeCareWebApp.Entities.BusinessService", "BusinessService")
                        .WithMany()
                        .HasForeignKey("BusinessServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WeCareWebApp.Entities.Partner", "Partner")
                        .WithMany()
                        .HasForeignKey("PartnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WeCareWebApp.Entities.Reservation", b =>
                {
                    b.HasOne("WeCareWebApp.Entities.BusinessClient", "BusinessClient")
                        .WithMany()
                        .HasForeignKey("BusinessClientId");

                    b.HasOne("WeCareWebApp.Entities.Partner", "Partner")
                        .WithMany()
                        .HasForeignKey("PartnerId");

                    b.HasOne("WeCareWebApp.Entities.ReservationStatus", "ReservationStatus")
                        .WithMany()
                        .HasForeignKey("ReservationStatusId");
                });

            modelBuilder.Entity("WeCareWebApp.Entities.ReservationDetail", b =>
                {
                    b.HasOne("WeCareWebApp.Entities.Barber", "Barber")
                        .WithMany()
                        .HasForeignKey("BarberId");

                    b.HasOne("WeCareWebApp.Entities.PartnerService", "PartnerService")
                        .WithMany()
                        .HasForeignKey("PartnerServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WeCareWebApp.Entities.Reservation", "Reservation")
                        .WithMany("Details")
                        .HasForeignKey("ReservationId");
                });

            modelBuilder.Entity("WeCareWebApp.Entities.User", b =>
                {
                    b.HasOne("WeCareWebApp.Entities.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
