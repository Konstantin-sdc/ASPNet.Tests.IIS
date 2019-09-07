using System.Data.Entity;
using TestClassses.TestForEFGenerator;

namespace AspNetMVC_iisTest.Models {
  public class AspTestContext : DbContext {
    public AspTestContext() : base("AspTestDataBase") { }
    public DbSet<Manufacturer> Manufacturers { get; set; }
    public DbSet<Material> Materials { get; set; }
    public DbSet<Cargo> Cargos { get; set; }
    public DbSet<Hantel> Hantels { get; set; }
  }

  public class AspTestInitialiser : DropCreateDatabaseAlways<AspTestContext> {
    protected override void Seed(AspTestContext db) {
      db.Cargos.Add(new Cargo() { Name = "Cargo1" });
      db.Materials.Add(new Material() { Name = "Material1" });
      db.Hantels.Add(new Hantel() { Name = "Hantel1" });
      base.Seed(db);
    }
    
  }
}