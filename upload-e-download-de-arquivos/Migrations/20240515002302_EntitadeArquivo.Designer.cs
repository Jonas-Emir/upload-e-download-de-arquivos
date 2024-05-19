﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using upload_e_download_de_arquivos.Infraestruture;

#nullable disable

namespace uploadedownloaddearquivos.Migrations
{
    [DbContext(typeof(ArquivoContext))]
    [Migration("20240515002302_EntitadeArquivo")]
    partial class EntitadeArquivo
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("upload_e_download_de_arquivos.Models.ArquivoModel", b =>
                {
                    b.Property<int>("Id_Arquivo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Arquivo"));

                    b.Property<string>("ContentType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Dados")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<DateTime>("DataEnvio")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Arquivo");

                    b.ToTable("Arquivos");
                });
#pragma warning restore 612, 618
        }
    }
}
