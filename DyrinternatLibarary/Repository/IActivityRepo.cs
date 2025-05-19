using DyrinternatLibarary.Model;
namespace DyrinternatLibarary.Repository
{
    public interface IActivityRepo
    {

        List<Activity> GetAll();
        void Add(Activity activity);
        void Remove(int title);
      

    }
}
