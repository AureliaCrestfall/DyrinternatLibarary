using DyrinternatLibarary.Model;

namespace DyrinternatLibarary.Repository
{
    public interface ICustomerRepo
    {
        List<Customer> GetAll();
        void Add(Customer customer);
        void Remove(int phoneNumber);
    }
}
