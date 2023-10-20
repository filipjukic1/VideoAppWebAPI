using Integracijski_Modul.Data.Models;
using Integracijski_Modul.Data.ViewModels;

namespace Integracijski_Modul.Data.Services
{
    public class VideosService
    {
        private AppDbContext _context;

        public VideosService(AppDbContext context)
        {
            _context = context;
        }


        public void AddVideos(Video video)
        {
            var _videos = new Video()
            {
                Name = video.Name,
                Description = video.Description,
                Image=video.Image,
                TotalTime = video.TotalTime,
                StreamingUrl = video.StreamingUrl,
                GenreId=video.GenreId
                

            };
            _context.Videos.Add(_videos);
            _context.SaveChanges();
        }

        public List<Video> GetAllVideos() => _context.Videos.ToList();
        public Video GetVideoById(int videoId) => _context.Videos.FirstOrDefault(n => n.Id == videoId);

        public Video UpdateVideoById(int videoId, VideoVM video)
        {
            var _video = _context.Videos.FirstOrDefault(n => n.Id == videoId);
            if (_video != null)
            {
                _video.Name = video.Name;
                _video.Description = video.Description;
                _video.Image = video.Image;
                _video.TotalTime = video.TotalTime;
                
                _video.StreamingUrl = video.StreamingUrl;
                

                _context.SaveChanges();
            }

            return _video;
        }

        public void DeleteVideoById(int videoId)
        {
            var _video = _context.Videos.FirstOrDefault(n => n.Id == videoId);
            if (_video != null)
            {
                _context.Videos.Remove(_video);
                _context.SaveChanges();
            }
        }


    }
}

