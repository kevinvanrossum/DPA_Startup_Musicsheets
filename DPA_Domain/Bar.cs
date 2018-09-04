using System;
using System.Collections.Generic;
using System.Text;

namespace DPA_Domain
{
  public class Bar
  {
    private List<Note> _notes;
    public List<Note> Notes { get { return _notes; } set { _notes = value; } }

    public Bar(int noteCount, int defaultNote)
    {
      Notes = new List<Note>();
    }
  }
}
