using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project_ManaTV.Models;
using project_ManaTV.Repository;

namespace project_ManaTV.Presenters
{
    public class CustomerPresenter
    {
        private CustomerRepository _customerRepository;
        public CustomerPresenter()
        {
            _customerRepository = new CustomerRepository();
        }

        public List<Customer> GetAll()
        {
            return _customerRepository.GetAll().ToList();
        }

        public Customer GetById(int id)
        {
            return _customerRepository.GetById(id);
        }

        public void AddNew(Customer customer)
        {
            _customerRepository.AddNew(customer);
        }

        public void Update(Customer customer)
        {
            _customerRepository.Update(customer);
        }

        public void Delete(int id)
        {
            _customerRepository.Delete(id);
        }
    }
}
