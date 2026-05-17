using Cw7.Models;
using Microsoft.EntityFrameworkCore;

namespace Cw7.Infrastructure;

public class DatabaseContext(DbContextOptions opt) : DbContext(opt)
{
    public DbSet<Component> Components { get; set; }
    public DbSet<ComponentManufacturer> ComponentManufacturers { get; set; }
    public DbSet<ComponentType> ComponentTypes { get; set; }
    public DbSet<PC> PCs { get; set; }
    public DbSet<PCcomponent> PCcomponents { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<ComponentType>().HasData([
            new ComponentType
            {
                Id = 1,
                Abbreviation = "CT",
                Name = "ComponentType1"
            },
            new ComponentType
            {
                Id = 2,
                Abbreviation = "CT1",
                Name = "ComponentType2"
            },
            new ComponentType
            {
                Id = 3,
                Abbreviation = "CT",
                Name = "ComponentType3"
            }
        ]);
        modelBuilder.Entity<ComponentManufacturer>().HasData([
            new ComponentManufacturer
            {
                Id = 1,
                Abrreviation = "cos1",
                FullName = "Dell",
                FoundationDate = new DateTime(2020, 1, 1)
            },
            new ComponentManufacturer
            {
                Id = 2,
                Abrreviation = "cos2",
                FullName = "Dell1",
                FoundationDate = new DateTime(2020, 1, 1)
            },
            new ComponentManufacturer
            {
                Id = 3,
                Abrreviation = "cos2",
                FullName = "Dell2",
                FoundationDate = new DateTime(2020, 1, 1)
            }
        ]);
        modelBuilder.Entity<Component>().HasData([
            new Component
            {
                Code = "0000000000",
                Name = "Component0",
                Description = "Description0",
                ComponentManufacturersId = 1,
                ComponentTypesId = 1
            },
            new Component
            {
                Code = "0000000001",
                Name = "Component1",
                Description = "Description1",
                ComponentManufacturersId = 2,
                ComponentTypesId = 2
            },
            new Component
            {
                Code = "0000000002",
                Name = "Component2",
                Description = "Description2",
                ComponentManufacturersId = 1,
                ComponentTypesId = 2
            }
        ]);
        modelBuilder.Entity<PC>().HasData([
            new PC
            {
                Id = 1,
                Name = "PC1",
                Weight = 5.5m,
                Warranty = 2,
                CreatedAt = new DateTime(2020, 1, 1),
                Stock = 20
            },
            new PC
            {
                Id = 2,
                Name = "PC2",
                Weight = 2.5m,
                Warranty = 3,
                CreatedAt = new DateTime(2020, 1, 1),
                Stock = 10
            },
            new PC
            {
                Id = 3,
                Name = "PC3",
                Weight = 8.5m,
                Warranty = 1,
                CreatedAt = new DateTime(2020, 1, 1),
                Stock = 3
            }
        ]);
        modelBuilder.Entity<PCcomponent>().HasData([
            new PCcomponent
            {
                PCId = 1,
                ComponentCode = "0000000000",
                Amount = 10
            },
            new PCcomponent
            {
                PCId = 2,
                ComponentCode = "0000000001",
                Amount = 30
            },
            new PCcomponent
            {
                PCId = 1,
                ComponentCode = "0000000002",
                Amount = 20
            },
        ]);
    }
}