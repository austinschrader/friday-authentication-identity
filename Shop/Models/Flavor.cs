using System.Collections.Generic;

namespace Shop.Models
{
  public class Flavor
  {
    public Flavor()
    {
      this.Treats = new HashSet<TreatFlavor>();
    }

    public int FlavorId { get; set; }
    public string Name { get; set; }

    public ICollection<TreatFlavor> Treats { get; }
  }

}