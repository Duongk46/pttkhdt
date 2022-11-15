using Business.Interfaces;
using Common.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Mvc.Areas.Admin.DropdownList;
using Mvc.Areas.Admin.Mapper;
using Mvc.Areas.Admin.Models;
using Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc.Areas.Admin.Controllers
{
    public class DisciplineController : Controller
    {
        private readonly IDisciplineBusiness _disciplineBusiness;
        private readonly IEmployeeBusiness _employeeBusiness;
        public DisciplineController(IDisciplineBusiness disciplineBusiness,IEmployeeBusiness employeeBusiness)
        {
            _disciplineBusiness = disciplineBusiness;
            _employeeBusiness = employeeBusiness;
        }
        [Area("Admin")]
        [HttpGet]
        public IActionResult Index(int page = 1, int pageSize = 5)
        {
            try
            {
                var model = _disciplineBusiness.SelectByQuantityItem(page, pageSize);
                var disciplineViewModel = new List<DisciplineViewModel>();
                var mapperDiscipline = new DtoViewModel();
                var pagination = new PaginationModel();
                var employeeDto = _employeeBusiness.SelectAll();
                var total = _disciplineBusiness.GetTotal();
                if (model != null)
                {
                    foreach (var item in employeeDto)
                    {
                        foreach (var child in model)
                        {
                            if (item.ID == child.IDEmployee)
                            {
                                var viewModel = mapperDiscipline.DisciplineDtoToViewModel(child);
                                viewModel.Name = item.Name;
                                disciplineViewModel.Add(viewModel);
                            }
                        }
                    }
                    pagination.Total = total;
                    pagination.Show = (total != 0 ? ((page - 1) * pageSize) + 1 : 0);
                    pagination.ShowTo = (((page - 1) * pageSize) + 1) + model.Count() - 1;
                    pagination.Page = page;
                    int maxPage = 5;
                    int totalPage = 0;
                    totalPage = (int)Math.Ceiling((double)((double)total / (double)pageSize));
                    pagination.TotalPage = totalPage;
                    pagination.MaxPage = 5;
                    pagination.First = 1;
                    pagination.Last = totalPage;
                    pagination.Next = page + 1;
                    pagination.Prev = page - 1;
                    ViewData["Pagination"] = pagination;
                }
                return View(disciplineViewModel);
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }
        [Area("Admin")]
        [HttpGet]
        public IActionResult Create()
        {
            var employeeDto = _employeeBusiness.SelectAll();
            var dropdownList =  new DropdownListItem();
            var listName = dropdownList.DropdownListName(employeeDto);
            ViewData["ListName"] = new SelectList(listName, "Value", "Text");
            return View();
        }
        [Area("Admin")]
        [HttpPost]
        public IActionResult Create(DisciplineViewModel disciplineViewModel)
        {
            var employeeDto = _employeeBusiness.SelectAll();
            var dropdownList = new DropdownListItem();
            var listName = dropdownList.DropdownListName(employeeDto);
            ViewData["ListName"] = new SelectList(listName, "Value", "Text");
            if (!ModelState.IsValid) return View(disciplineViewModel);
            try
            {
                var mapperDiscipline = new DtoViewModel();
                disciplineViewModel.IDEmployee = long.Parse(disciplineViewModel.Name);
                var disciplineDto = mapperDiscipline.DisciplineViewModelToDto(disciplineViewModel);
                disciplineDto.CreatedBy = 1;
                _disciplineBusiness.CreateDiscipline(disciplineDto);
                return Redirect("/Admin/Discipline");
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }
        [Area("Admin")]
        [HttpPost]
        public IActionResult Delete(string id)
        {
            if (string.IsNullOrEmpty(id)) throw new ArgumentNullException(nameof(id));
            var ID = long.Parse(id);
            try
            {
                _disciplineBusiness.DeleteDiscipline(ID);
                return Json(new
                {
                    status = true
                });
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    status = false
                });
            }
        }
        [HttpGet]
        [Area("Admin")]
        public IActionResult Edit(string id)
        {
            if (string.IsNullOrEmpty(id)) throw new ArgumentNullException(nameof(id));
            try
            {
                var ID = long.Parse(id);
                var disciplineDto = new DisciplineDTO();
                var dtoViewModel = new DtoViewModel();
                var disciplineViewModel = new DisciplineViewModel();
                disciplineDto = _disciplineBusiness.GetDisciplineById(ID);
                disciplineViewModel = dtoViewModel.DisciplineDtoToViewModel(disciplineDto);
                var employeeDto = _employeeBusiness.SelectAll();
                disciplineViewModel.Name = employeeDto.SingleOrDefault(x => x.ID == disciplineViewModel.IDEmployee).Name;
                return View(disciplineViewModel);
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }
        [Area("Admin")]
        [HttpPost]
        public IActionResult Edit(DisciplineViewModel  disciplineViewModel)
        {
            if (!ModelState.IsValid) return View(disciplineViewModel);
            try
            {
                var disciplineDto = new DisciplineDTO();
                var mapperDiscipline = new DtoViewModel();
                disciplineDto = mapperDiscipline.DisciplineViewModelToDto(disciplineViewModel);
                _disciplineBusiness.EditDiscipline(disciplineDto);
                return Redirect("/Admin/Discipline");
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }
    }
}
