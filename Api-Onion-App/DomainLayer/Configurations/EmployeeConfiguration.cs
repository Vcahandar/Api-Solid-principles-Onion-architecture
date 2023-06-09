﻿using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DomainLayer.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Property(m => m.FullName).HasMaxLength(50).IsRequired(false);
            builder.Property(m => m.SoftDelete).IsRequired(false).HasDefaultValue(false);
            builder.Property(m=>m.CreatedAt).IsRequired(false).HasDefaultValue(DateTime.Now);
            builder.Property(m => m.Address).IsRequired().HasMaxLength(250);
            builder.Property(m => m.Age).IsRequired();
        }
    }
}
