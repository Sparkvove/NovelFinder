using System.ComponentModel.DataAnnotations;

namespace NovelFinder.Models
{
    public class Novel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string title { get; set; }
        public string rating { get; set; }
        public string numberOfRatings { get; set; }
        public string chapters { get; set; }
        public string status { get; set; }

    }
}
