using project_ManaTV.Repository;
using System;
using System.Collections.Generic;
using project_ManaTV.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_ManaTV.Presenters.Designs
{
    public class DesignPresenter
    {
        private DesignRepository _designRepository;
        private int pageNumber = 1;
        private int pageSize = 10;
        private int skip;
        private int totalCount;
        private int totalPage;

        public int TotalPage { get => totalPage; }

        public List<Models.Designs> ListModelRender { get; set; }

        public void Save()
        {
            ListModelRender = _designRepository.GetAll();
        }
        public DesignPresenter()
        {
            _designRepository = new DesignRepository();
        }
        public List<Models.Designs> GetAll()
        {
            return _designRepository.GetAll();
        }

        public Models.Designs GetById(int id)
        {
            
            return _designRepository.GetById(id);
        }

        public void AddNew(Models.Designs design)
        {
            _designRepository.AddNew(design);
            Save();
        }

        public void Update(Models.Designs design)
        {
            _designRepository.Update(design);
            Save();
        }
        public void DeleteById(Models.Designs design)
        {
            _designRepository.DeleteById(design);
            Save();
        }

        public void Delete(int id)
        {
            _designRepository.Delete(id);
            Save();
        }
        public List<Models.Designs> Search(string searchKey, string filterBy)
        {
            var lstResSearch = new List<Models.Designs>();
            searchKey = searchKey.ToLower();
            if (filterBy == "id") return _designRepository.GetAll().Where(x => x.Id.ToString().Contains(searchKey)).ToList();
            else if (filterBy == "name") return _designRepository.GetAll().Where(x => x.Name.ToLower().Contains(searchKey)).ToList();
            return lstResSearch;
        }

        public List<Models.Designs> GetByPagination(int pageNumber, int pageSize)
        {
            var lstDesigns = _designRepository.GetAll();
            totalCount = lstDesigns.Count;
            totalPage = (int)Math.Ceiling((decimal)totalCount / pageSize);
            skip = pageNumber * pageSize - pageSize;
            return lstDesigns.Skip(0).Take(pageSize).ToList();
        }
    }
}
