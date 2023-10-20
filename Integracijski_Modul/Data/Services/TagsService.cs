using Integracijski_Modul.Data.Models;
using Integracijski_Modul.Data.ViewModels;

namespace Integracijski_Modul.Data.Services
{
    public class TagsService
    {
        private AppDbContext _context;

        public TagsService(AppDbContext context)
        {
            _context = context;
        }


        public void AddTags(TagVM tag)
        {
            var _tags = new Tag()
            {
                Name = tag.Name
                

            };
            _context.Tags.Add(_tags);
            _context.SaveChanges();
        }

        public List<Tag> GetAllTags() => _context.Tags.ToList();
        public Tag GetTagById(int tagId) => _context.Tags.FirstOrDefault(n => n.Id == tagId);

        public Tag UpdateTagById(int tagId, TagVM tag)
        {
            var _tag = _context.Tags.FirstOrDefault(n => n.Id == tagId);
            if (_tag != null)
            {
                _tag.Name = tag.Name;
                

                _context.SaveChanges();
            }

            return _tag;
        }

        public void DeleteTagById(int tagId)
        {
            var _tag = _context.Tags.FirstOrDefault(n => n.Id == tagId);
            if (_tag != null)
            {
                _context.Tags.Remove(_tag);
                _context.SaveChanges();
            }
        }
    }
}
