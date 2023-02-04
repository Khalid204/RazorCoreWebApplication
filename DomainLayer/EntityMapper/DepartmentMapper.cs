using DomainLayer.BaseEntity;
using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DomainLayer.EntityMapper
{
    public class DepartmentMapper : IEntityTypeConfiguration<Departments>
    {
        public void Configure(EntityTypeBuilder<Departments> entity)
        {
            entity.ToTable("Departments", "Emp");
            entity.HasKey(e => e.DeptId);
            entity.Property(e => e.CreatedOn);
            entity.Property(e => e.DeptName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdateOn);
        }
    }
}
