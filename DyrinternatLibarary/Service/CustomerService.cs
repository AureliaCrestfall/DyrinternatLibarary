using DyrinternatLibarary.Model;
using DyrinternatLibarary.Repository;
namespace DyrinternatLibarary.Service
{
    public class CustomerService
    {
        ICustomerRepo _customerRepo;

        public void Add(Customer customer)
        {
            _customerRepo.Add(customer);
        }
        public void Remove(int phoneNumber)
        {
            _customerRepo.Remove(phoneNumber);
        }
        public List<Customer> GetAll()
        {
            return _customerRepo.GetAll();
        }

    }
}
