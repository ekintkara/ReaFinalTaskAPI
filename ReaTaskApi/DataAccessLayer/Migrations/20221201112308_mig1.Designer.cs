// <auto-generated />
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20221201112308_mig1")]
    partial class mig1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("EntityLayer.Concrete.ToDo", b =>
                {
                    b.Property<int>("TodoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsComplete")
                        .HasColumnType("bit");

                    b.Property<string>("TodoDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TodoName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TodoOwner")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("todoStatus")
                        .HasColumnType("int");

                    b.HasKey("TodoID");

                    b.ToTable("toDos");
                });
#pragma warning restore 612, 618
        }
    }
}
