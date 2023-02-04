using DomainLayer.BaseEntity;
using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DomainLayer.EntityMapper
{
    public class EmployeeMapper : IEntityTypeConfiguration<Employees>
    {

        public void Configure(EntityTypeBuilder<Employees> entity)
        {
            entity.ToTable("Employees", "Emp");
            entity.HasKey(e => e.EmpId);
            entity.Property(e => e.Address)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.AddressType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedOn);
            entity.Property(e => e.EmpCode)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Salary);
            entity.Property(e => e.UpdateOn);
        }
    }
}
