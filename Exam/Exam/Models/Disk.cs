using System.ComponentModel.DataAnnotations;

namespace DiskModel
{
    public class Diskk
    {
        [Key]
        public int IdDisk { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
    }
}