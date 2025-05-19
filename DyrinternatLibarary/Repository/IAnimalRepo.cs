using DyrinternatLibarary.Model;
namespace DyrinternatLibarary.Repository
{
    public interface IAnimalRepo
    {

        List<Animal> GetAll();
        void Add(Animal animals);
        void Remove(int chipNumber);
        void AddVisits(int chipNumber, string visits);
    }
}
