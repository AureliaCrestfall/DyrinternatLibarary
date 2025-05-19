using DyrinternatLibarary.Model;

namespace DyrinternatLibarary.Repository
{
    public interface IBlogRepo
    {

        List<Blog> GetAll();
        void Add(Blog blog);
        void Remove(int title);
    }
}
