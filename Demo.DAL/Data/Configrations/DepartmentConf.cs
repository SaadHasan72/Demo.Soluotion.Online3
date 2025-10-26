﻿using Demo.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Demo.DAL.Data.Configurations
{
    internal class DepartmentConf : IEntityTypeConfiguration<Department>
    {
     

        void IEntityTypeConfiguration<Department>.Configure(EntityTypeBuilder<Department> builder)
        {
            builder.Property(D => D.Id).UseIdentityColumn(10,10);
            builder.Property(D => D.Name).HasColumnType("varchar(20)");
            builder.Property(D => D.Code).HasColumnType("varchar(20)");
            builder.Property(D => D.description).HasColumnType("varchar(20)");
            builder.Property(D => D.CreatedOn).HasDefaultValueSql ("GETDATE()");
            builder.Property(D => D.LastModifiedOn).HasDefaultValueSql ("GETDATE()");

        }
    }
}
