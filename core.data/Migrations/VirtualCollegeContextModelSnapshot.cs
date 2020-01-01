﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using core.data;

namespace core.data.Migrations
{
    [DbContext(typeof(VirtualCollegeContext))]
    partial class VirtualCollegeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("core.data.Model.Address.Address", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PinCodeID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("PinCodeID");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("core.data.Model.Address.City", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DistrictID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("DistrictID");

                    b.ToTable("City");
                });

            modelBuilder.Entity("core.data.Model.Address.District", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StateID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("StateID");

                    b.ToTable("District");
                });

            modelBuilder.Entity("core.data.Model.Address.PinCode", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CityID")
                        .HasColumnType("int");

                    b.Property<int>("Pincode")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CityID");

                    b.ToTable("PinCode");
                });

            modelBuilder.Entity("core.data.Model.Address.State", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Name")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("State");
                });

            modelBuilder.Entity("core.data.Model.Member.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MemberID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MemberID");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("core.data.Model.Member.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Semester")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("core.data.Model.Member.Document", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AcceptedById")
                        .HasColumnType("int");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("DocumentType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAccepted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsMedia")
                        .HasColumnType("bit");

                    b.Property<int?>("MemberID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("AcceptedById");

                    b.HasIndex("MemberID");

                    b.ToTable("Document");
                });

            modelBuilder.Entity("core.data.Model.Member.Member", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfJoining")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateOfLeaving")
                        .HasColumnType("datetime2");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("core.data.Model.Member.Section", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Name")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Section");
                });

            modelBuilder.Entity("core.data.Model.Member.SemesterData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("StudentDataId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudentDataId");

                    b.ToTable("SemesterData");
                });

            modelBuilder.Entity("core.data.Model.Member.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MemberID")
                        .HasColumnType("int");

                    b.Property<int?>("SectionId")
                        .HasColumnType("int");

                    b.Property<int?>("StudentDataId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MemberID");

                    b.HasIndex("SectionId");

                    b.HasIndex("StudentDataId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("core.data.Model.Member.StudentData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CourseId")
                        .HasColumnType("int");

                    b.Property<int?>("SectionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("SectionId");

                    b.ToTable("StudentData");
                });

            modelBuilder.Entity("core.data.Model.Person.Contact", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AddressID")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("AddressID");

                    b.HasIndex("PersonId")
                        .IsUnique();

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("core.data.Model.Person.Person", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MemberId")
                        .HasColumnType("int");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PinCodeID")
                        .HasColumnType("int");

                    b.Property<int?>("StateID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("MemberId")
                        .IsUnique()
                        .HasFilter("[MemberId] IS NOT NULL");

                    b.HasIndex("PinCodeID");

                    b.HasIndex("StateID");

                    b.ToTable("People");
                });

            modelBuilder.Entity("core.data.Model.Person.Relative", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ContactID")
                        .HasColumnType("int");

                    b.Property<int>("Relation")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ContactID");

                    b.ToTable("Relative");
                });

            modelBuilder.Entity("core.data.Model.Person.Remark", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GivenByID")
                        .HasColumnType("int");

                    b.Property<int>("PersonID")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("GivenByID");

                    b.HasIndex("PersonID");

                    b.ToTable("Remark");
                });

            modelBuilder.Entity("core.data.Model.Address.Address", b =>
                {
                    b.HasOne("core.data.Model.Address.PinCode", "PinCode")
                        .WithMany()
                        .HasForeignKey("PinCodeID");
                });

            modelBuilder.Entity("core.data.Model.Address.City", b =>
                {
                    b.HasOne("core.data.Model.Address.District", "District")
                        .WithMany()
                        .HasForeignKey("DistrictID");
                });

            modelBuilder.Entity("core.data.Model.Address.District", b =>
                {
                    b.HasOne("core.data.Model.Address.State", "State")
                        .WithMany()
                        .HasForeignKey("StateID");
                });

            modelBuilder.Entity("core.data.Model.Address.PinCode", b =>
                {
                    b.HasOne("core.data.Model.Address.City", "City")
                        .WithMany()
                        .HasForeignKey("CityID");
                });

            modelBuilder.Entity("core.data.Model.Member.Admin", b =>
                {
                    b.HasOne("core.data.Model.Member.Member", "Member")
                        .WithMany()
                        .HasForeignKey("MemberID");
                });

            modelBuilder.Entity("core.data.Model.Member.Document", b =>
                {
                    b.HasOne("core.data.Model.Member.Admin", "AcceptedBy")
                        .WithMany()
                        .HasForeignKey("AcceptedById");

                    b.HasOne("core.data.Model.Member.Member", "Member")
                        .WithMany("Documents")
                        .HasForeignKey("MemberID");
                });

            modelBuilder.Entity("core.data.Model.Member.SemesterData", b =>
                {
                    b.HasOne("core.data.Model.Member.StudentData", null)
                        .WithMany("SemestersData")
                        .HasForeignKey("StudentDataId");
                });

            modelBuilder.Entity("core.data.Model.Member.Student", b =>
                {
                    b.HasOne("core.data.Model.Member.Member", "Member")
                        .WithMany()
                        .HasForeignKey("MemberID");

                    b.HasOne("core.data.Model.Member.Section", null)
                        .WithMany("Students")
                        .HasForeignKey("SectionId");

                    b.HasOne("core.data.Model.Member.StudentData", "StudentData")
                        .WithMany()
                        .HasForeignKey("StudentDataId");
                });

            modelBuilder.Entity("core.data.Model.Member.StudentData", b =>
                {
                    b.HasOne("core.data.Model.Member.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId");

                    b.HasOne("core.data.Model.Member.Section", "Section")
                        .WithMany()
                        .HasForeignKey("SectionId");
                });

            modelBuilder.Entity("core.data.Model.Person.Contact", b =>
                {
                    b.HasOne("core.data.Model.Address.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressID");

                    b.HasOne("core.data.Model.Person.Person", "Person")
                        .WithOne("Contact")
                        .HasForeignKey("core.data.Model.Person.Contact", "PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("core.data.Model.Person.Person", b =>
                {
                    b.HasOne("core.data.Model.Member.Member", "Member")
                        .WithOne("Person")
                        .HasForeignKey("core.data.Model.Person.Person", "MemberId");

                    b.HasOne("core.data.Model.Address.PinCode", null)
                        .WithMany("People")
                        .HasForeignKey("PinCodeID");

                    b.HasOne("core.data.Model.Address.State", null)
                        .WithMany("People")
                        .HasForeignKey("StateID");
                });

            modelBuilder.Entity("core.data.Model.Person.Relative", b =>
                {
                    b.HasOne("core.data.Model.Person.Contact", null)
                        .WithMany("Relatives")
                        .HasForeignKey("ContactID");
                });

            modelBuilder.Entity("core.data.Model.Person.Remark", b =>
                {
                    b.HasOne("core.data.Model.Member.Member", "GivenBy")
                        .WithMany()
                        .HasForeignKey("GivenByID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("core.data.Model.Person.Person", "Person")
                        .WithMany("Remarks")
                        .HasForeignKey("PersonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
