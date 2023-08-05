using Microsoft.EntityFrameworkCore;
using Products.Models;
using System.Security.Cryptography.X509Certificates;

namespace Products.Infrastucture
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        
           public DbSet <Product> Products { get; set; }
           public DbSet<Category> Categories { get; set; }
    }
    }

