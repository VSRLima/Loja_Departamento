﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using loja_depr.DAL;

namespace loja_depr.Migrations
{
    [DbContext(typeof(StoreDepartContext))]
    partial class StoreDepartContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("loja_depr.Models.Colaborator.Colaborators", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DepartamentId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DepartamentId");

                    b.ToTable("Colaborators");
                });

            modelBuilder.Entity("loja_depr.Models.Departaments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departaments");
                });

            modelBuilder.Entity("loja_depr.Models.Suggestion.Suggestions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ColaboratorsId")
                        .HasColumnType("int");

                    b.Property<int>("DepartamentId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Suggestion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ColaboratorsId");

                    b.HasIndex("DepartamentId");

                    b.ToTable("Suggestions");
                });

            modelBuilder.Entity("loja_depr.Models.Colaborator.Colaborators", b =>
                {
                    b.HasOne("loja_depr.Models.Departaments", "Departament")
                        .WithMany("Colaborators")
                        .HasForeignKey("DepartamentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Departament");
                });

            modelBuilder.Entity("loja_depr.Models.Suggestion.Suggestions", b =>
                {
                    b.HasOne("loja_depr.Models.Colaborator.Colaborators", "Colaborators")
                        .WithMany("Suggestions")
                        .HasForeignKey("ColaboratorsId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("loja_depr.Models.Departaments", "Departament")
                        .WithMany("Suggestions")
                        .HasForeignKey("DepartamentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Colaborators");

                    b.Navigation("Departament");
                });

            modelBuilder.Entity("loja_depr.Models.Colaborator.Colaborators", b =>
                {
                    b.Navigation("Suggestions");
                });

            modelBuilder.Entity("loja_depr.Models.Departaments", b =>
                {
                    b.Navigation("Colaborators");

                    b.Navigation("Suggestions");
                });
#pragma warning restore 612, 618
        }
    }
}
