using System;
using System.Collections.Generic;
using System.Text;

namespace DPA_Domain
{
  public class Sheet
  {
    private int _noteCount;
    private int _defaultNote;

    /// <summary>
    /// Aantal tellen per maat
    /// </summary>
    public int NoteCount { get { return _noteCount; } set { _noteCount = value; } }

    /// <summary>
    /// Tel die 1 seconde duurt.
    /// </summary>
    public int DefaultNote { get { return _defaultNote; } set { _defaultNote = value; } }
  }
}
