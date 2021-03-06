﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using lightweight.data.Context;

namespace lightweight.data.Migrations
{
    [DbContext(typeof(lwContext))]
    [Migration("20190827105546_first0000")]
    partial class first0000
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("lightweight.data.Model.Users", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("email");

                    b.Property<string>("firstName");

                    b.Property<string>("lastName");

                    b.Property<string>("password");

                    b.Property<string>("role");

                    b.Property<bool>("status");

                    b.HasKey("id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            id = 1,
                            email = "i@berkanarikan.com.tr",
                            firstName = "Berkan",
                            lastName = "ARIKAN",
                            password = "vFTlduBZkNsjuhjbDazejw==",
                            status = false
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
