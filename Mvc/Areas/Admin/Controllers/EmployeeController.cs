using Business.Interfaces;
using Common.DTO;
using Entities.Entities;
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
    public class EmployeeController : Controller
    {
        private readonly IEmployeeBusiness _employeeBusiness;
        public EmployeeController(IEmployeeBusiness employeeBusiness)
        {
            _employeeBusiness = employeeBusiness;
        }
        [Area("Admin")]
        [HttpGet]
        public IActionResult Index(int page=1,int pageSize=5)
        {
            try
            {
                var employeeDtos = _employeeBusiness.SelectByQuantityItem(page, pageSize);
                var total = _employeeBusiness.GetTotal();
                var mapperEmployee = new DtoViewModel();
                var pagination = new PaginationModel();
                var employeeViewModels = new List<EmployeeViewModel>();
                if (total > 0 )
                {
                    foreach (var item in employeeDtos)
                    {
                        employeeViewModels.Add(mapperEmployee.EmployeeDtoToViewModel(item));
                    }
                    pagination.Total = total;
                    pagination.Show = (total != 0 ? ((page - 1) * pageSize) + 1 : 0);
                    pagination.ShowTo = (((page - 1) * pageSize) + 1) + employeeDtos.Count() - 1;
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
                    return View(employeeViewModels);
                }
                else
                {
                    return View();
                }
            }
            catch(Exception ex)
            {
                return NotFound();
            }
            
        }
        [Area("Admin")]
        [HttpGet]
        public IActionResult Edit(string id)
        {
            if (string.IsNullOrEmpty(id)) throw new ArgumentNullException(nameof(id));
            try
            {
                long ID = long.Parse(id);
                var employeeDto = _employeeBusiness.GetEmployeeById(ID);
                var mapperDtoView = new DtoViewModel();
                var employeeViewModel = new EmployeeViewModel();
                var _dropdownList = new DropdownListItem();
                ViewData["TypeSex"] = new SelectList(_dropdownList.DropdownListTypeSex(), "Value", "Text");
                ViewData["Type"] = new SelectList(_dropdownList.DropdownListTypeEmployee(), "Value", "Text");
                employeeViewModel = mapperDtoView.EmployeeDtoToViewModel(employeeDto);
                return View(employeeViewModel);
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }
        [Area("Admin")]
        [HttpPost]
        public IActionResult Edit(EmployeeViewModel employeeViewModel)
        {
            var _dropdownList = new DropdownListItem();
            var mapperDtoView = new DtoViewModel();
            ViewData["Type"] = new SelectList(_dropdownList.DropdownListTypeEmployee(), "Value", "Text");
            ViewData["TypeSex"] = new SelectList(_dropdownList.DropdownListTypeSex(), "Value", "Text");
            if (!ModelState.IsValid) return View(employeeViewModel);
            try
            {
                var employeeDto = new EmployeeDTO();
                employeeDto = mapperDtoView.EmployeeViewModelToDto(employeeViewModel);
                var check = _employeeBusiness.EditEmployee(employeeDto);
                if (check)
                {
                    return Redirect("/Admin/Employee");
                }
                else
                {
                    ViewBag.Message = "Thay đổi nhân sự không thành công";
                    return View(employeeViewModel);
                }
            }
            catch(Exception ex)
            {
                return NotFound();
            }
        }
        [Area("Admin")]
        [HttpPost]
        public IActionResult Delete(string id)
        {
            if (string.IsNullOrEmpty(id)) throw new ArgumentNullException(nameof(id));
            try
            {
                _employeeBusiness.DeleteEmployee(long.Parse(id));
                return Json(new
                {
                    Status = true
                });
            }
            catch(Exception ex)
            {
                return Json(new
                {
                    Status = false
                });
            }
        }
        [Area("Admin")]
        [HttpGet]
        public IActionResult Create()
        {
            var _dropdownList = new DropdownListItem();
            ViewData["Type"] = new SelectList(_dropdownList.DropdownListTypeEmployee(), "Value", "Text");
            ViewData["TypeSex"] = new SelectList(_dropdownList.DropdownListTypeSex(), "Value", "Text");
            return View();
        }
        [Area("Admin")]
        [HttpPost]
        public IActionResult Create(EmployeeViewModel employeeViewModel)
        {
            var _dropdownList = new DropdownListItem();
            var mapperDtoView = new DtoViewModel();
            ViewData["Type"] = new SelectList(_dropdownList.DropdownListTypeEmployee(), "Value", "Text");
            ViewData["TypeSex"] = new SelectList(_dropdownList.DropdownListTypeSex(), "Value", "Text");
            if (!ModelState.IsValid) return View(employeeViewModel);
            try
            {
                var employeeDto = new EmployeeDTO();
                var check = false;
                employeeDto = mapperDtoView.EmployeeViewModelToDto(employeeViewModel);
                employeeDto.CreatedBy = 1;

                check = _employeeBusiness.CreateEmployee(employeeDto);
                if (check)
                {
                    return Redirect("/Admin/Employee");
                }
                else ViewBag.Message = "Email đã tồn tại";
                return View(employeeViewModel);
            }
            catch(Exception ex)
            {
                return NotFound();
            }
            
        }
    }
}
