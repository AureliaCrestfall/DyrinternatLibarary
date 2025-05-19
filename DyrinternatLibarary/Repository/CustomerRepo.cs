using DyrinternatLibarary.Model;

namespace DyrinternatLibarary.Repository
{
    public class CustomerRepo : ICustomerRepo
    {

        List<Customer> _customers;

        public CustomerRepo()
        {
            _customers = new List<Customer>();
        }

        public List<Customer> GetAll()
        {
            return _customers;
        }

        public void Add(Customer customer)
        {
            _customers.Add(customer);
        }

        public void Remove(int phoneNumber)
        {
            _customers.RemoveAt(phoneNumber);
        }

    }
}
