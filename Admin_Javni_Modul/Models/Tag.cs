using System.ComponentModel.DataAnnotations;

namespace Admin_Javni_Modul.Models
{
    public class Tag
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Name")]
        public string Name { get; set; }

        public List<VideoTag> VideoTags { get; set; }
      
    }
}
