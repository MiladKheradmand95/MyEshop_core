// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyEshop.Data;

namespace MyEshop.Migrations
{
    [DbContext(typeof(MyEshopContext))]
    [Migration("20220501053345_SeedDataCategoryMig")]
    partial class SeedDataCategoryMig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyEshop.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "انواع لباس  ورزشی",
                            Name = "لباس ورزشی"
                        },
                        new
                        {
                            Id = 2,
                            Description = "انواع لباس خانگی و خواب",
                            Name = "لباس راحتی"
                        },
                        new
                        {
                            Id = 3,
                            Description = "انواع لباس مجلسی",
                            Name = "لباس مجلسی"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
