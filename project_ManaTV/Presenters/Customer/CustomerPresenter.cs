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

        //pagination
        private int pageNumber = 1;
        private int pageSize = 10;
        private int skip;
        private int totalCount;
        private int totalPage;
        public int TotalPage { get => totalPage;}
        public List<Customer> ListCustomerRender { get; set; }
        public CustomerPresenter()
        {
            _customerRepository = new CustomerRepository();
            ListCustomerRender = _customerRepository.GetAll().Where(x => x.IsDeleted == false).ToList();
            totalCount = ListCustomerRender.Count;
            totalPage = (int)Math.Ceiling((decimal)totalCount / pageSize);
        }

        public List<Customer> GetByPagination(int pageNumber, int pageSize)
        {
            var lstCustomer = ListCustomerRender.Where(x => x.IsDeleted == false);
            totalCount = ListCustomerRender.Count;
            totalPage = (int)Math.Ceiling((decimal)totalCount / pageSize);
            skip = pageNumber * pageSize - pageSize;
            return lstCustomer.Skip(skip).Take(pageSize).ToList();
        }

        public List<Customer> GetAll()
        {
            return _customerRepository.GetAll();
        }

        public Customer GetById(int id)
        {
            return _customerRepository.GetById(id);
        }

        public List<Customer> Search(string searchKey, string filterBy)
        {
            var lstResSearch = new List<Customer>();
            searchKey = searchKey.ToLower();
            if (filterBy == "id") return _customerRepository.GetAll().Where(x => x.Id.ToString().Contains(searchKey)).ToList();
            else if (filterBy == "fullname") return _customerRepository.GetAll().Where(x => x.FullName.ToLower().Contains(searchKey)).ToList();
            else if (filterBy == "email") return _customerRepository.GetAll().Where(x => x.Email.ToLower().Contains(searchKey)).ToList();
            else if (filterBy == "phonenumber") return _customerRepository.GetAll().Where(x => x.PhoneNumber.Contains(searchKey)).ToList();
            else if (filterBy == "address") return _customerRepository.GetAll().Where(x => x.Address.ToLower().Contains(searchKey)).ToList();
            return lstResSearch;
        }

        public void AddNew(Customer customer)
        {
            _customerRepository.AddNew(customer);
            Save();
        }

        public void Update(Customer customer)
        {
            _customerRepository.Update(customer);
            Save();
        }

        public void Delete(int id)
        {
            _customerRepository.Delete(id);
            Save();
        }

        public void SetDeleteStatus(int id, bool status)
        {
            _customerRepository.SetDeleteStatus(id, status);
            Save();
        }

        public void Save()
        {
            ListCustomerRender = _customerRepository.GetAll();
        }
    }
}
