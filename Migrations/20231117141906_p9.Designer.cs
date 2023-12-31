﻿// <auto-generated />
using System;
using BancaApi.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BancaApi.Migrations
{
    [DbContext(typeof(BancaInfoContext))]
    [Migration("20231117141906_p9")]
    partial class p9
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BancaApi.Entities.AdminEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdBanca")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("IdBanca");

                    b.ToTable("Admins");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IdBanca = 1,
                            Password = "admin",
                            Role = "admin",
                            Token = "",
                            Username = "admin"
                        },
                        new
                        {
                            Id = 2,
                            IdBanca = 2,
                            Password = "admin1",
                            Role = "admin",
                            Token = "",
                            Username = "admin1"
                        },
                        new
                        {
                            Id = 3,
                            IdBanca = 3,
                            Password = "admin2",
                            Role = "admin",
                            Token = "",
                            Username = "admin2"
                        },
                        new
                        {
                            Id = 4,
                            IdBanca = 4,
                            Password = "admin3",
                            Role = "admin",
                            Token = "",
                            Username = "admin3"
                        });
                });

            modelBuilder.Entity("BancaApi.Entities.BancaEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Banche");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Fineco"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "BPM"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Che Banche!"
                        },
                        new
                        {
                            Id = 4,
                            Nome = "Intesa San Paolo"
                        },
                        new
                        {
                            Id = 5,
                            Nome = "Credit Agricole"
                        });
                });

            modelBuilder.Entity("BancaApi.Entities.BancheFunzionalitaEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdBanca")
                        .HasColumnType("int");

                    b.Property<int>("IdFunzionalita")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdBanca");

                    b.HasIndex("IdFunzionalita");

                    b.ToTable("BancheFunzionalita");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IdBanca = 1,
                            IdFunzionalita = 1
                        },
                        new
                        {
                            Id = 2,
                            IdBanca = 2,
                            IdFunzionalita = 2
                        },
                        new
                        {
                            Id = 3,
                            IdBanca = 2,
                            IdFunzionalita = 1
                        },
                        new
                        {
                            Id = 4,
                            IdBanca = 1,
                            IdFunzionalita = 3
                        },
                        new
                        {
                            Id = 5,
                            IdBanca = 3,
                            IdFunzionalita = 2
                        },
                        new
                        {
                            Id = 6,
                            IdBanca = 3,
                            IdFunzionalita = 4
                        },
                        new
                        {
                            Id = 7,
                            IdBanca = 1,
                            IdFunzionalita = 2
                        });
                });

            modelBuilder.Entity("BancaApi.Entities.ContoEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataUltimaOperazione")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IdUtente")
                        .HasColumnType("int");

                    b.Property<decimal>("Saldo")
                        .HasColumnType("decimal(10, 2)");

                    b.HasKey("Id");

                    b.HasIndex("IdUtente");

                    b.ToTable("Conti");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DataUltimaOperazione = new DateTime(2023, 11, 17, 15, 19, 5, 841, DateTimeKind.Local).AddTicks(4709),
                            IdUtente = 1,
                            Saldo = 1000m
                        },
                        new
                        {
                            Id = 2,
                            DataUltimaOperazione = new DateTime(2023, 11, 17, 15, 19, 5, 841, DateTimeKind.Local).AddTicks(4774),
                            IdUtente = 2,
                            Saldo = 2000m
                        },
                        new
                        {
                            Id = 3,
                            DataUltimaOperazione = new DateTime(2023, 11, 17, 15, 19, 5, 841, DateTimeKind.Local).AddTicks(4777),
                            IdUtente = 3,
                            Saldo = 2000m
                        },
                        new
                        {
                            Id = 4,
                            DataUltimaOperazione = new DateTime(2023, 11, 17, 15, 19, 5, 841, DateTimeKind.Local).AddTicks(4780),
                            IdUtente = 4,
                            Saldo = 2000m
                        });
                });

            modelBuilder.Entity("BancaApi.Entities.FunzionalitaEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Funzionalita");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Versamento"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Prelievo"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Saldo"
                        },
                        new
                        {
                            Id = 4,
                            Nome = "Registro Operazioni"
                        });
                });

            modelBuilder.Entity("BancaApi.Entities.OperazioneEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataOperazione")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Funzionalita")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("IdBanca")
                        .HasColumnType("int");

                    b.Property<int>("IdUtente")
                        .HasColumnType("int");

                    b.Property<decimal>("Quantita")
                        .HasColumnType("decimal(10, 2)");

                    b.HasKey("Id");

                    b.HasIndex("IdBanca");

                    b.HasIndex("IdUtente");

                    b.ToTable("Operazioni");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DataOperazione = new DateTime(2023, 11, 17, 15, 19, 5, 841, DateTimeKind.Local).AddTicks(4803),
                            Funzionalita = "Deposito",
                            IdBanca = 1,
                            IdUtente = 1,
                            Quantita = 500m
                        },
                        new
                        {
                            Id = 2,
                            DataOperazione = new DateTime(2023, 11, 17, 15, 19, 5, 841, DateTimeKind.Local).AddTicks(4807),
                            Funzionalita = "Prelievo",
                            IdBanca = 2,
                            IdUtente = 2,
                            Quantita = 300m
                        });
                });

            modelBuilder.Entity("BancaApi.Entities.UtenteEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Bloccato")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("IdBanca")
                        .HasColumnType("int");

                    b.Property<string>("NomeUtente")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("IdBanca");

                    b.ToTable("Utenti");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Bloccato = false,
                            IdBanca = 1,
                            NomeUtente = "dario",
                            Password = "dario",
                            Role = "teacher",
                            Token = ""
                        },
                        new
                        {
                            Id = 2,
                            Bloccato = false,
                            IdBanca = 2,
                            NomeUtente = "sidy",
                            Password = "sidy",
                            Role = "student",
                            Token = ""
                        },
                        new
                        {
                            Id = 3,
                            Bloccato = true,
                            IdBanca = 3,
                            NomeUtente = "sandro",
                            Password = "sandro",
                            Role = "student",
                            Token = ""
                        },
                        new
                        {
                            Id = 4,
                            Bloccato = true,
                            IdBanca = 2,
                            NomeUtente = "sara",
                            Password = "sara",
                            Role = "student",
                            Token = ""
                        });
                });

            modelBuilder.Entity("BancaApi.Entities.AdminEntity", b =>
                {
                    b.HasOne("BancaApi.Entities.BancaEntity", "Banca")
                        .WithMany()
                        .HasForeignKey("IdBanca")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Banca");
                });

            modelBuilder.Entity("BancaApi.Entities.BancheFunzionalitaEntity", b =>
                {
                    b.HasOne("BancaApi.Entities.BancaEntity", "Banca")
                        .WithMany()
                        .HasForeignKey("IdBanca")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BancaApi.Entities.FunzionalitaEntity", "Funzionalita")
                        .WithMany()
                        .HasForeignKey("IdFunzionalita")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Banca");

                    b.Navigation("Funzionalita");
                });

            modelBuilder.Entity("BancaApi.Entities.ContoEntity", b =>
                {
                    b.HasOne("BancaApi.Entities.UtenteEntity", "Utente")
                        .WithMany()
                        .HasForeignKey("IdUtente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Utente");
                });

            modelBuilder.Entity("BancaApi.Entities.OperazioneEntity", b =>
                {
                    b.HasOne("BancaApi.Entities.BancaEntity", "Banca")
                        .WithMany()
                        .HasForeignKey("IdBanca")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BancaApi.Entities.UtenteEntity", "Utente")
                        .WithMany()
                        .HasForeignKey("IdUtente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Banca");

                    b.Navigation("Utente");
                });

            modelBuilder.Entity("BancaApi.Entities.UtenteEntity", b =>
                {
                    b.HasOne("BancaApi.Entities.BancaEntity", "Banca")
                        .WithMany()
                        .HasForeignKey("IdBanca")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Banca");
                });
#pragma warning restore 612, 618
        }
    }
}
