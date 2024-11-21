using CW_13.Entityes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_13.Configes
{
    internal class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(i => i.ProductId);
            builder.Property(p => p.ProductName).IsRequired().HasMaxLength(40);
            builder.Property(p => p.QuantityPerUnit).HasMaxLength(20);
            builder.Property(p => p.Discontinued).IsRequired();
            builder.HasOne(x=>x.Supplier).WithMany(x=>x.Products).HasForeignKey(x=>x.SupplierId);
            builder.HasOne(x=>x.category).WithMany(x=>x.Products).HasForeignKey(x=> x.CategoryId);
           
        }
    }
}
