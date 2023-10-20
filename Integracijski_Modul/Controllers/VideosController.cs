using Integracijski_Modul.Data.Models;
using Integracijski_Modul.Data.Services;
using Integracijski_Modul.Data.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Integracijski_Modul.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideosController : ControllerBase
    {
        public VideosService _videosService;
        public VideosController(VideosService videoservice)
        {
            _videosService = videoservice;
        }

        [HttpGet("get-all-videos")]
        public IActionResult GetAllVideos()
        {
            var allVideos = _videosService.GetAllVideos();
            return Ok(allVideos);
        }

        [HttpGet("get-video-by-id/{id}")]
        public IActionResult GetVideoById(int id)
        {
            var video = _videosService.GetVideoById(id);
            return Ok(video);
        }

        [HttpPost("add-video")]
        public IActionResult AddVideos([FromBody] Video video)
        {
            _videosService.AddVideos(video);
            return Ok();
        }

        [HttpPut("update-video-by-id/{id}")]
        public IActionResult UpdateVideoById(int id, [FromBody] VideoVM video)
        {
            var updatedVideo = _videosService.UpdateVideoById(id, video);
            return Ok(updatedVideo);
        }


        [HttpDelete("delete-video-by-ud/{id}")]
        public IActionResult DeleteBookById(int id)
        {
            _videosService.DeleteVideoById(id);
            return Ok();
        }




    }
}

