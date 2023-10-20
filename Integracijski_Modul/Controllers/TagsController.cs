using Integracijski_Modul.Data.Services;
using Integracijski_Modul.Data.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Integracijski_Modul.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagsController : ControllerBase
    {
        public TagsService _tagsService;
        public TagsController(TagsService tagservice)
        {
            _tagsService = tagservice;
        }

        [HttpGet("get-all-tags")]
        public IActionResult GetAllTags()
        {
            var allTags = _tagsService.GetAllTags();
            return Ok(allTags);
        }

        [HttpGet("get-tag-by-id/{id}")]
        public IActionResult GetTagById(int id)
        {
            var tag = _tagsService.GetTagById(id);
            return Ok(tag);
        }

        [HttpPost("add-tag")]
        public IActionResult AddTags([FromBody] TagVM tag)
        {
            _tagsService.AddTags(tag);
            return Ok();
        }

        [HttpPut("update-tag-by-id/{id}")]
        public IActionResult UpdateTagById(int id, [FromBody] TagVM tag)
        {
            var updatedTag = _tagsService.UpdateTagById(id, tag);
            return Ok(updatedTag);
        }


        [HttpDelete("delete-tag-by-ud/{id}")]
        public IActionResult DeleteBookById(int id)
        {
            _tagsService.DeleteTagById(id);
            return Ok();
        }
    }
}
