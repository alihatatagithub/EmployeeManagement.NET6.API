using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EmployeeManagement.Models
{
    public partial class FrontEndContext : DbContext
    {
        public FrontEndContext()
        {
        }

        public FrontEndContext(DbContextOptions<FrontEndContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblEmployee> TblEmployees { get; set; } = null!;

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("server=192.168.2.222; database=FrontEnd;User ID=alihatata;Password=ASDzxc123$@");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblEmployee>(entity =>
            {
                entity.HasKey(e => e.EmpId);

                entity.ToTable("tbl_employee");

                entity.Property(e => e.EmpId).HasColumnName("emp_id");

                entity.Property(e => e.EmpAddress)
                    .HasMaxLength(250)
                    .HasColumnName("emp_address");

                entity.Property(e => e.EmpEmail)
                    .HasMaxLength(150)
                    .HasColumnName("emp_email");

                entity.Property(e => e.EmpName)
                    .HasMaxLength(100)
                    .HasColumnName("emp_name");

                entity.Property(e => e.EmpPhone)
                    .HasMaxLength(50)
                    .HasColumnName("emp_phone");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
