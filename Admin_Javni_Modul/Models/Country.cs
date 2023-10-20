using System.ComponentModel.DataAnnotations;

namespace Admin_Javni_Modul.Models
{
    public class Country
    {
        [Key]
        public int Id { get; set; }

        //anotacije za cshtml 
        [Display(Name = "Code")]
        public char Code { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }
    }
}
