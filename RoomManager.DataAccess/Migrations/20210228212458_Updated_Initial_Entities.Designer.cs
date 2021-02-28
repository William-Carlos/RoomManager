﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RoomManager.DataAccess.Context;

namespace RoomManager.DataAccess.Migrations
{
    [DbContext(typeof(ManagerRoomContext))]
    [Migration("20210228212458_Updated_Initial_Entities")]
    partial class Updated_Initial_Entities
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RoomManager.Domain.Entities.CoffeeSpace", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.Property<int>("Quantity")
                        .HasColumnType("int")
                        .HasColumnName("Quantity");

                    b.HasKey("Id");

                    b.ToTable("CoffeeSpace");
                });

            modelBuilder.Entity("RoomManager.Domain.Entities.Person", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("FirstStepCoffeeSpaceId")
                        .HasColumnType("bigint");

                    b.Property<long>("FirstStepRoomId")
                        .HasColumnType("bigint");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("LastName");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.Property<long>("SecondStepCoffeeSpaceId")
                        .HasColumnType("bigint");

                    b.Property<long>("SecondStepRoomId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("FirstStepCoffeeSpaceId");

                    b.HasIndex("FirstStepRoomId");

                    b.HasIndex("SecondStepCoffeeSpaceId");

                    b.HasIndex("SecondStepRoomId");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("RoomManager.Domain.Entities.Room", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Capacity")
                        .HasColumnType("int")
                        .HasColumnName("Capacity");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.Property<int>("Quantity")
                        .HasColumnType("int")
                        .HasColumnName("Quantity");

                    b.HasKey("Id");

                    b.ToTable("Room");
                });

            modelBuilder.Entity("RoomManager.Domain.Entities.Person", b =>
                {
                    b.HasOne("RoomManager.Domain.Entities.CoffeeSpace", "FirstStepCoffeeSpace")
                        .WithMany()
                        .HasForeignKey("FirstStepCoffeeSpaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RoomManager.Domain.Entities.Room", "FirstStepRoom")
                        .WithMany()
                        .HasForeignKey("FirstStepRoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RoomManager.Domain.Entities.CoffeeSpace", "SecondStepCoffeeSpace")
                        .WithMany()
                        .HasForeignKey("SecondStepCoffeeSpaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RoomManager.Domain.Entities.Room", "SecondStepRoom")
                        .WithMany()
                        .HasForeignKey("SecondStepRoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FirstStepCoffeeSpace");

                    b.Navigation("FirstStepRoom");

                    b.Navigation("SecondStepCoffeeSpace");

                    b.Navigation("SecondStepRoom");
                });
#pragma warning restore 612, 618
        }
    }
}
