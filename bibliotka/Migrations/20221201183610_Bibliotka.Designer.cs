// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using bibliotka.Models;

#nullable disable

namespace bibliotka.Migrations
{
    [DbContext(typeof(Dbcontext))]
    [Migration("20221201183610_Bibliotka")]
    partial class Bibliotka
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("KnigaKnigiMqsto", b =>
                {
                    b.Property<int>("KnigiRaftoveId")
                        .HasColumnType("int");

                    b.Property<Guid>("knigiKnigaID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("KnigiRaftoveId", "knigiKnigaID");

                    b.HasIndex("knigiKnigaID");

                    b.ToTable("KnigaKnigiMqsto");
                });

            modelBuilder.Entity("bibliotka.Models.Kniga", b =>
                {
                    b.Property<Guid>("KnigaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pisatel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Stranici")
                        .HasColumnType("int");

                    b.HasKey("KnigaID");

                    b.ToTable("Knigas");
                });

            modelBuilder.Entity("bibliotka.Models.KnigiMqsto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("KnigaId")
                        .HasColumnType("int");

                    b.Property<int>("Nomer")
                        .HasColumnType("int");

                    b.Property<string>("OtdelPisatel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Red")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("KnigiMqstos");
                });

            modelBuilder.Entity("KnigaKnigiMqsto", b =>
                {
                    b.HasOne("bibliotka.Models.KnigiMqsto", null)
                        .WithMany()
                        .HasForeignKey("KnigiRaftoveId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("bibliotka.Models.Kniga", null)
                        .WithMany()
                        .HasForeignKey("knigiKnigaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
