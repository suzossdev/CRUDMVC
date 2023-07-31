//using BulkyBook.Models;
using CRUDMVC.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CRUDMVC.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    public DbSet<Category> Categories { get; set; }
}

