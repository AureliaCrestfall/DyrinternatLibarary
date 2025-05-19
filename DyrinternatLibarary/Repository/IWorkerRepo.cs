using DyrinternatLibarary.Model;

namespace DyrinternatLibarary.Repository
{
    public interface IWorkerRepo
    {

        List<Worker> GetAll();
        void Add(Worker woker);
        void Remove(int id);
    }
}
