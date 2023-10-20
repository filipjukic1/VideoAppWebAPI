using System.ComponentModel.DataAnnotations;

namespace Admin_Javni_Modul.Models
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Name")]
        //[Required(ErrorMessage ="Name is required!")]
        [StringLength(25,MinimumLength =3, ErrorMessage ="Name must be between 3 and 25 chars")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        //[Required(ErrorMessage = "Description is required!")]
        public string Description { get; set; }
    }
}
