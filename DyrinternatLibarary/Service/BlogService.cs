using DyrinternatLibarary.Repository;
using DyrinternatLibarary.Model;


namespace DyrinternatLibarary.Service
{
    public class BlogService
    {

        IBlogRepo _blogRepo;

        public void Add(Blog blog)
        {
            _blogRepo.Add(blog);
        }
        public void Remove(int title)
        {
            _blogRepo.Remove(title);
        }
        public List<Blog> GetAll()
        {
            return _blogRepo.GetAll();
        }
    }
}
