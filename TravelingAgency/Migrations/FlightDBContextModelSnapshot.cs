// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TravelingAgency.EF;

#nullable disable

namespace TravelingAgency.Migrations
{
    [DbContext(typeof(FlightDBContext))]
    partial class FlightDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.4");

            modelBuilder.Entity("TravelingAgency.CanceledTicket", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CancelDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Fcode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TicketId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("CanceledTickets");
                });

            modelBuilder.Entity("TravelingAgency.Flight", b =>
                {
                    b.Property<string>("Fcode")
                        .HasColumnType("TEXT");

                    b.Property<string>("Fcap")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fdate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Fdst")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Fsrc")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Fcode");

                    b.ToTable("Flights");
                });

            modelBuilder.Entity("TravelingAgency.Passenger", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Age")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PassportNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Passengers");
                });

            modelBuilder.Entity("TravelingAgency.Ticket", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Amount")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Fcode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PassengerId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Tickets");
                });
#pragma warning restore 612, 618
        }
    }
}
