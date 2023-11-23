using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Seeds
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(new Product
            {
                Id = 1,
                CategoryId = 1,
                Name = "1984",
                Price = 100,
                Stock = 20,
                CreatedAt = DateTime.UtcNow.AddHours(4)
            },
            new Product
            {
                Id = 2,
                CategoryId = 1,
                Name = "The Great Gatsby",
                Price = 85,
                Stock = 10,
                CreatedAt = DateTime.UtcNow.AddHours(4)
            },
            new Product
            {
                Id = 3,
                CategoryId = 2,
                Name = "Simple Notebook",
                Price = 20,
                Stock = 100,
                CreatedAt = DateTime.UtcNow.AddHours(4)
            },
             new Product
             {
                 Id = 4,
                 CategoryId = 2,
                 Name = "Big Notebook",
                 Price = 40,
                 Stock = 99,
                 CreatedAt = DateTime.UtcNow.AddHours(4)
             },
             new Product
             {
                 Id = 5,
                 CategoryId = 3,
                 Name = "Black Pen",
                 Price = 10,
                 Stock = 500,
                 CreatedAt = DateTime.UtcNow.AddHours(4)
             },
              new Product
              {
                  Id = 6,
                  CategoryId = 3,
                  Name = "Red Pen",
                  Price = 10,
                  Stock = 300,
                  CreatedAt = DateTime.UtcNow.AddHours(4)
              }
            );
        }
    }
}
