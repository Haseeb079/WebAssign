﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAss.Controllers;

#nullable disable

namespace ESite.Migrations
{
    [DbContext(typeof(DBConTextProd))]
    partial class DBcontextModel : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ESite.Model.EsiteHome", b =>
            {
                b.Property<string>("productNmae")
                    .HasColumnType("nvarchar(450)");

                b.Property<string>("productID")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("product_price")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("productNmae");

                b.ToTable("esiteHomes");
            });
#pragma warning restore 612, 618
        }
    }
}
