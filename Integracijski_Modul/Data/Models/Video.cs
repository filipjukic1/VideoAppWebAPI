namespace Integracijski_Modul.Data.Models
{
    public class Video
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        
        public string Image { get; set; }
        public int TotalTime { get; set; }
        public string StreamingUrl { get; set; }
        
        public List<Tag> Tags { get; set; }

        //zanr videa
        public int GenreId { get; set; }
        
        public Genre Genre { get; set; }



    }
}
