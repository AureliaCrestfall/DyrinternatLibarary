using DyrinternatLibarary.Model;
using DyrinternatLibarary.Repository;

namespace DyrinternatLibarary.Service
{
    public class WorkerService
    {

        IWorkerRepo _workerRepo;
        public List<Worker> GetAll()
        {
            return _workerRepo.GetAll();
        }
        public void Add(Worker woker)
        {
            _workerRepo.Add(woker);
        }
        public void Remove(int id)
        {
            _workerRepo.Remove(id);
        }
    }
}
