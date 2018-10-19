using System.Collections.Generic;

namespace DPA_Domain.Models
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
