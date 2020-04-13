﻿// <auto-generated />
using DevCollApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DevCollApi.Migrations
{
    [DbContext(typeof(DevCollectContext))]
    [Migration("20200404084113_UpdatedTopic")]
    partial class UpdatedTopic
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("DevCollApi.Models.Collection", b =>
                {
                    b.Property<int>("CollId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Date")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsPublic")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MembId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("CollId");

                    b.ToTable("Collections");
                });

            modelBuilder.Entity("DevCollApi.Models.Link", b =>
                {
                    b.Property<int>("LinkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CollId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Discription")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsPublic")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MembId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TopId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UrlPath")
                        .HasColumnType("TEXT");

                    b.HasKey("LinkId");

                    b.ToTable("Links");
                });

            modelBuilder.Entity("DevCollApi.Models.Member", b =>
                {
                    b.Property<int>("MembId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.HasKey("MembId");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("DevCollApi.Models.Message", b =>
                {
                    b.Property<int>("MessId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsRead")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MessageText")
                        .HasColumnType("TEXT");

                    b.Property<int>("ReceiverId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SendDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("SenderId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Subject")
                        .HasColumnType("TEXT");

                    b.HasKey("MessId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("DevCollApi.Models.Note", b =>
                {
                    b.Property<int>("NoteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CollId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Discription")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsPublic")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MembId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TextContent")
                        .HasColumnType("TEXT");

                    b.Property<int>("TopId")
                        .HasColumnType("INTEGER");

                    b.HasKey("NoteId");

                    b.ToTable("Notes");
                });

            modelBuilder.Entity("DevCollApi.Models.Topic", b =>
                {
                    b.Property<int>("TopId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CollId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Date")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsPublic")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MembId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("TopId");

                    b.ToTable("Topics");
                });
#pragma warning restore 612, 618
        }
    }
}