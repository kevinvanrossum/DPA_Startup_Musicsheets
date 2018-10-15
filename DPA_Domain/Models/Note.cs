using System;
using System.Collections.Generic;
using System.Text;

namespace DPA_Domain
{
  public class Note
  {
    public enum NoteValue { A, B, C, D, E, F, G, H, rest};
    public enum PitchValue { flat, sharp }

    private NoteValue _value;
    private PitchValue _pitch;
    private int _length;

    public NoteValue Value { get { return _value; } set { _value = value; } }
    public PitchValue Pitch { get { return _pitch; } set { _pitch = value; } }
    public int Length { get { return _length; } set { _length = value; } }

    public Note()
    {

    }




  }
}
