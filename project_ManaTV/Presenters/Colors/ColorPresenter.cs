using project_ManaTV.Repository;
using System;
using project_ManaTV.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
