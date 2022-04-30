using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SharedObjects.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class ApplicationDbContext :IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base()
        {

        }
        public ApplicationDbContext()
        {

        }
        //Scaffold-DbContext "Data Source=VNHCMC0SQL81;Initial Catalog=BAV;User Id=BAV_User;Password=Jabil@2022!;MultipleActiveResultSets=true;" Microsoft.EntityFrameworkCore.SqlServer -Tables "Log" -OutputDir Models2
        public virtual DbSet<Accessory> Accessory { get; set; }
        public virtual DbSet<AccessRole> AccessRole { get; set; }
        public virtual DbSet<AccessUserRole> AccessUserRole { get; set; }
        public virtual DbSet<Log> Log { get; set; }
        public virtual DbQuery<VAccessory> VAccessory { get; set; }
        public virtual DbQuery<VConfiguration> VConfiguration { get; set; }
        public virtual DbQuery<VUserRole> VUserRole { get; set; }
        public virtual DbQuery<VRole> VRole { get; set; }
        public virtual DbQuery<VLog> VLog { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=VNHCMC0SQL81;Initial Catalog=BAV;User Id=BAV_User;Password=Jabil@2022!;MultipleActiveResultSets=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Accessory>(entity =>
            {
                entity.HasNoKey();
                entity.ToTable("Accessory");
                //entity.HasKey(e => e.AccessoryId);
                entity.Property(e => e.AccessoryId).HasColumnName("accessoryId");

                entity.Property(e => e.Accessory1)
                    .HasColumnName("accessory")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedEmail)
                    .HasColumnName("createdEmail")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedName)
                    .HasColumnName("createdName")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creationDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(250);

                entity.Property(e => e.FileName)
                    .HasColumnName("fileName")
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("updateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updatedBy")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedEmail)
                    .HasColumnName("updatedEmail")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedName)
                    .HasColumnName("updatedName")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });
            modelBuilder.Entity<AccessRole>(entity =>
            {
                entity.HasKey(e => e.RoleId);

                entity.ToTable("Access_Role");

                entity.Property(e => e.RoleId)
                    .HasColumnName("roleID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedEmail)
                    .HasColumnName("createdEmail")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedName)
                    .HasColumnName("createdName")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creationDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.RoleDescr)
                    .HasColumnName("roleDescr")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RoleName)
                    .HasColumnName("roleName")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("updateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updatedBy")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedEmail)
                    .HasColumnName("updatedEmail")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedName)
                    .HasColumnName("updatedName")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });
            modelBuilder.Entity<AccessUserRole>(entity =>
            {
                entity.HasKey(e => e.UserRoleId);

                entity.ToTable("Access_UserRole");

                entity.Property(e => e.UserRoleId).HasColumnName("userRoleId");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedEmail)
                    .HasColumnName("createdEmail")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedName)
                    .HasColumnName("createdName")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creationDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CustId).HasColumnName("custID");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.Ntlogin)
                    .HasColumnName("NTLogin")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PlantId).HasColumnName("plantID");

                entity.Property(e => e.RoleId).HasColumnName("roleID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("updateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updatedBy")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedEmail)
                    .HasColumnName("updatedEmail")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedName)
                    .HasColumnName("updatedName")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasColumnName("userName")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });
            modelBuilder.Entity<Log>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AccessoryList)
                    .HasColumnName("accessoryList")
                    .HasMaxLength(250);

                entity.Property(e => e.AssemblyNumber)
                    .HasColumnName("assemblyNumber")
                    .HasMaxLength(250);

                entity.Property(e => e.BoxNumber)
                    .HasColumnName("boxNumber")
                    .HasMaxLength(250);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedEmail)
                    .HasColumnName("createdEmail")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedName)
                    .HasColumnName("createdName")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creationDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.LogId)
                    .HasColumnName("logId")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Revision)
                    .HasColumnName("revision")
                    .HasMaxLength(250);

                entity.Property(e => e.SerailNumber)
                    .HasColumnName("serailNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TestResult)
                    .HasColumnName("testResult")
                    .HasMaxLength(250);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("updateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updatedBy")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedEmail)
                    .HasColumnName("updatedEmail")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedName)
                    .HasColumnName("updatedName")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

        }

     
    }
}
