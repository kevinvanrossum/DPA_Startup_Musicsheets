using System.Collections.Generic;

namespace DPA_Domain.Models
{
  public class Repeat
  {
    private List<Bar> _bars;
    public List<Bar> Bars { get { return _bars; } set { _bars = value; } }

    public Repeat()
    {

    }

  }
}
