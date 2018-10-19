namespace DPA_Domain.Models
{
    public class Tone
    {
        public Height Height { get; set; }
        public Octave Octave { get; set; }
        public Modifier Modifier { get; set; }

        public Tone()
        {
        }
    }
}