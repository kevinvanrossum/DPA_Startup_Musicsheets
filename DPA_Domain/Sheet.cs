using System;
using System.Collections.Generic;
using System.Text;

namespace DPA_Domain
{
  public class Sheet
  {
    private int _noteCount;
    private int _defaultNote;
    private List<Bar> _bars;

    /// <summary>
    /// Aantal tellen per maat
    /// </summary>
    public int NoteCount { get { return _noteCount; } set { _noteCount = value; } }

    /// <summary>
    /// Tel die 1 seconde duurt.
    /// </summary>
    public int DefaultNote { get { return _defaultNote; } set { _defaultNote = value; } }

    public List<Bar> Bars { get { return _bars; } set { _bars = value; } }

    public Sheet(int noteCount, int defaultNote)
    {
      NoteCount = noteCount;
      DefaultNote = defaultNote;
    }
  }
}
