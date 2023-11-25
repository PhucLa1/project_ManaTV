using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuButton;
using project_ManaTV.Models;
using project_ManaTV.Repository;

namespace project_ManaTV.Presenters
{
    public class PaginationPresenter<T> where T: class
    {
        //pagination
        private int _pageNumber = 1;
        private int _pageSize = 10;
        private int _skip;
        private int _totalCount;
        private int _totalPage;

        //PAGINATION event
        private EventHandler btnPageHandler;
        private EventHandler btnPrevHandler;
        private EventHandler btnNextHandler;

        //Data client
        private List<T> _lstData;
        private List<BunifuButton> _lstButton;
        private BunifuDropdown _dropdown;
        private BunifuButton _btnPrev;
        private BunifuButton _btnNext;
        private BunifuButton _btn1;
        private BunifuButton _btn2;
        private BunifuButton _btn3;
        public PaginationPresenter(List<T> lstData, BunifuButton btn1, BunifuButton btn2, BunifuButton btn3, BunifuButton btnPrev, BunifuButton btnNext, BunifuDropdown dropdown)
        {
            _lstData = lstData;
            _btn1 = btn1;
            _btn2 = btn2;
            _btn3 = btn3;
            _btnNext = btnNext;
            _btnPrev = btnPrev;
            _dropdown = dropdown;

            _lstButton = new List<BunifuButton> { _btn1, _btn2, _btn3 };
            //properties
            UpdateProperties(1, 10, _lstData);

           
            //add event
            AddEventPagination();
            HandlePagination();
        }
        public void ReInit(int pageNumber, int pageSize, List<T> lstData = null)
        {
            UpdateProperties(pageNumber, pageSize, lstData);
            HandlePagination();
        }

        private void UpdateProperties(int pageNumber, int pageSize, List<T> lstData = null)
        {
            if (lstData != null) _lstData = lstData;
            _totalCount = _lstData.Count;
            _pageNumber = pageNumber;
            _pageSize = pageSize;

            _totalPage = (int)Math.Ceiling((decimal)_totalCount / _pageSize);
            _skip = _pageNumber * _pageSize - _pageSize;

        }

        public void UpdateData(List<T> lstData)
        {
            _lstData = lstData;
        }

        public List<T> GetListByPagination()
        {
            //UpdateProperties(pageNumber, pageSize);
            return _lstData.Skip(_skip).Take(_pageSize).ToList();
        }

        //event
        private void AddEventPagination()
        {
            foreach (var btnPageNumber in _lstButton)
            {
                btnPageHandler = (s, e) =>MoveToPage(int.Parse(btnPageNumber.Text));
                btnPageNumber.Click += btnPageHandler;
            }
            btnPrevHandler = (s, e) => MoveToPage(_pageNumber - 1);
            btnNextHandler = (s, e) => MoveToPage(_pageNumber + 1);
            _btnPrev.Click += btnPrevHandler;
            _btnNext.Click += btnNextHandler;

            _dropdown.SelectedIndexChanged += (s, e) =>
            {
                _pageNumber = 1;
                _pageSize = int.Parse(_dropdown.Text);
                UpdateProperties(_pageNumber, _pageSize);
                HandlePagination();
            };
        }

        private void MoveToPage(int pageNumber)
        {
            if (pageNumber > _totalPage || pageNumber < 1) return;
            UpdateProperties(pageNumber, _pageSize);
            if (_totalPage > 3 && pageNumber >= 3 && pageNumber < _totalPage)
            {
                _btn1.Text = (pageNumber - 1).ToString();
                _btn3.Text = (pageNumber + 1).ToString();
                _btn2.Text = pageNumber.ToString();
            }
            else if (pageNumber < 3)
            {
                _btn1.Text = "1";
                _btn2.Text = "2";
                _btn3.Text = "3";

            }
            SetActivePage(pageNumber);
        }

        
        private void HandlePagination()
        {
            ResetPageButtonDefault();
            if (_totalPage <= 2) { _btn3.Visible = false; }
            if (_totalPage <= 1) { _btn2.Visible = false; }
            
            SetActivePage(1);
            _dropdown.Text = _pageSize.ToString();
           

        }

        private void ResetPageButtonDefault()
        {
            foreach (var btnPage in _lstButton)
            {
                btnPage.Text = btnPage.Tag.ToString();
                btnPage.Visible = true;
            }

        }

        private void SetActivePage(int pageNumber)
        {
            foreach (var btnPageNumber in _lstButton)
            {
                if (btnPageNumber.Text == pageNumber.ToString())
                {
                    btnPageNumber.BackColor = System.Drawing.Color.FromArgb(105, 181, 255);
                    //btnPageNumber.ForeColor = Color.White;
                }
                else
                {
                    btnPageNumber.BackColor = System.Drawing.Color.Transparent;
                    //btnPageNumber.ForeColor = Color.FromArgb(40, 96, 144);
                }
            }
        }


    }
}
