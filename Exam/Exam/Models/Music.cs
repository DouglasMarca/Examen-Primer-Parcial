using System.ComponentModel.DataAnnotations;

namespace MusicModel
{
    public class Music
    {
        [Key]
        public int IdMusic { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int NumberReproductions { get; set; }
        public int IdDisk { get; set; }
    }
}