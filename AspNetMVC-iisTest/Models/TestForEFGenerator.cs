namespace TestClassses.TestForEFGenerator {

  public abstract class AbstractBase {
    public int Id { get; set; }
    public string Name { get; set; }
  }

  public class Manufacturer : AbstractBase {
    public string Site { get; set; }
  }

  public abstract class AbstractElement : AbstractBase {
    public string Model { get; set; }
    public Manufacturer Manufacturer { get; set; }
  }

  public class Material : AbstractElement {
    public double Density { get; set; }
  }

  public abstract class HantelDetail : AbstractElement {
    public Material Material { get; set; }
    public int Length { get; set; }
  }

  public class Cargo : HantelDetail {
    public Material FillerMaterial { get; set; }
  }

  public class Hantel : Cargo {
    public Cargo CargoPart { get; set; }
  }

}
