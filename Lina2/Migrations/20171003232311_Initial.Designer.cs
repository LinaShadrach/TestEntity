using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Lina2.Models;

namespace Lina2.Migrations
{
    [DbContext(typeof(Lina2DbContext))]
    [Migration("20171003232311_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2");

            modelBuilder.Entity("Lina2.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Cost");

                    b.Property<string>("Description");

                    b.Property<string>("Image");

                    b.Property<string>("Method");

                    b.Property<string>("Name");

                    b.Property<string>("Season");

                    b.Property<string>("Size");

                    b.Property<string>("Source");

                    b.HasKey("ProductId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Lina2.Models.Subscriber", b =>
                {
                    b.Property<int>("SubscriberId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Birthday");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("Zip");

                    b.HasKey("SubscriberId");

                    b.ToTable("Subscribers");
                });
        }
    }
}
