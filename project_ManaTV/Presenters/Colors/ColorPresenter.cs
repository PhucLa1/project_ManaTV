using project_ManaTV.Repository;
using System;
using project_ManaTV.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_ManaTV.Presenters.Colors
{
    public class ColorPresenter
    {
        private ColorRepository _colorRepository;
        private int pageNumber = 1;
        private int pageSize = 10;
        private int skip;
        private int totalCount;
        private int totalPage;

        public int TotalPage { get => totalPage; }
        public List<Color> ListColorRender { get; set; }

        public ColorPresenter()
        {
            _colorRepository = new ColorRepository();
        }

        public List<Color> GetAll()
        {
            return _colorRepository.GetAll();
        }

        public Color GetById(int id)
        {
            return _colorRepository.GetById(id);
        }

        public void AddNew(Color color)
        {
            _colorRepository.AddNew(color);
            Save();
        }
        public void Save()
        {
            ListColorRender = _colorRepository.GetAll();
        }

        public void Update(Color color)
        {
            _colorRepository.Update(color);
            Save();
        }

        public void DeleteById(Color color)
        {
            _colorRepository.DeleteById(color);
            Save();
        }

        public void Delete(int id)
        {
            _colorRepository.Delete(id);
            Save();
        }
        public List<Color> Search(string searchKey, string filterBy)
        {
            var lstResSearch = new List<Color>();
            searchKey = searchKey.ToLower();
            if (filterBy == "id") return _colorRepository.GetAll().Where(x => x.Id.ToString().Contains(searchKey)).ToList();
            else if (filterBy == "name") return _colorRepository.GetAll().Where(x => x.Name.ToLower().Contains(searchKey)).ToList(); 
            else if (filterBy == "value") return _colorRepository.GetAll().Where(x => x.Value.ToLower().Contains(searchKey)).ToList();
            return lstResSearch;
        }

        public List<Color> GetByPagination(int pageNumber, int pageSize)
        {
            var lstColor = _colorRepository.GetAll();
            totalCount = lstColor.Count;
            totalPage = (int)Math.Ceiling((decimal)totalCount / pageSize);
            skip = pageNumber * pageSize - pageSize;
            return lstColor.Skip(0).Take(pageSize).ToList();
        }

    }
}
