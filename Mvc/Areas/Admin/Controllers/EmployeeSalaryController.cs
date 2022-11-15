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
    public class EmployeeSalaryController : Controller
    {
        private readonly IEmployeeSalaryBusiness _employeeSalaryBusiness;
        private readonly IEmployeeBusiness _employeeBusiness;
        private readonly IRewardBusiness _rewardBusiness;
        private readonly IDisciplineBusiness _disciplineBusiness;
        public EmployeeSalaryController(IEmployeeSalaryBusiness employeeSalaryBusiness,IEmployeeBusiness employeeBusiness,IRewardBusiness rewardBusiness,IDisciplineBusiness disciplineBusiness)
        {
            _employeeSalaryBusiness = employeeSalaryBusiness;
            _employeeBusiness = employeeBusiness;
            _rewardBusiness = rewardBusiness;
            _disciplineBusiness = disciplineBusiness;
        }
        [Area("Admin")]
        [HttpGet]
        public IActionResult Index(int page=1,int pageSize=5)
        {
            try
            {
                var model = _employeeSalaryBusiness.SelectByQuantityItem(page, pageSize);
                var salaryViewModel = new List<EmployeeSalaryViewModel>();
                var mapperSalary = new DtoViewModel();
                var pagination = new PaginationModel();
                var total = _employeeSalaryBusiness.GetTotal();
                var employeeDto = _employeeBusiness.SelectAll();
                if (total != 0)
                {
                    foreach (var item in model)
                    {
                        salaryViewModel.Add(mapperSalary.EmployeeSalaryDtoToViewModel(item));
                    }
                    foreach (var item in salaryViewModel)
                    {
                        foreach (var child in employeeDto)
                        {
                            if (item.IDEmployee == child.ID)
                            {
                                item.Name = child.Name;
                                break;
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
                    return View(salaryViewModel);
                }
                else
                {
                    return View();
                }
            }
            catch (Exception ex)
            {
                return Redirect("/");
            }
        }
        [Area("Admin")]
        [HttpGet]
        public IActionResult Create()
        {
            var employeeDto = _employeeBusiness.SelectAll();
            var dropdownList = new DropdownListItem();
            var listName = dropdownList.DropdownListName(employeeDto);
            ViewData["ListName"] = new SelectList(listName, "Value", "Text");
            return View();
        }
        [Area("Admin")]
        [HttpPost]
        public IActionResult Delete(string id)
        {
            if (string.IsNullOrEmpty(id)) throw new ArgumentNullException(id);
            try
            {
                _employeeSalaryBusiness.Delete(long.Parse(id));
                return Json(new
                {
                    status = true
                });
            }
            catch(Exception ex)
            {
                return Json(new
                {
                    status = false
                });;
            }
        }
        [Area("Admin")]
        [HttpPost]
        public IActionResult Create(EmployeeSalaryViewModel employeeSalaryViewModel)
        {
            var employeeDto = _employeeBusiness.SelectAll();
            var dropdownList = new DropdownListItem();
            var listName = dropdownList.DropdownListName(employeeDto);
            ViewData["ListName"] = new SelectList(listName, "Value", "Text");
            if (!ModelState.IsValid) return View(employeeSalaryViewModel);
            try
            {
                var salaryDto = new EmployeeSalaryDTO();
                var mapperSalary = new DtoViewModel();
                employeeSalaryViewModel.IDEmployee = long.Parse(employeeSalaryViewModel.Name);
                employeeSalaryViewModel.CreatedBy = 1;
                salaryDto = mapperSalary.EmployeeSalaryViewModelToDto(employeeSalaryViewModel);
                var check = _employeeSalaryBusiness.UpdateSalary(salaryDto);
                if (check)
                {
                    return Redirect("/Admin/EmployeeSalary");
                }
                else
                {
                    ViewBag.Message = "Tạo lương nhân viên thất bại";
                    return View(employeeSalaryViewModel);
                }
            }
            catch (Exception ex)
            {
                ViewBag.Message = "Tạo lương nhân viên thất bại";
                return View(employeeSalaryViewModel);
            }
        }
        [Area("Admin")]
        [HttpGet]
        public IActionResult Edit(string id)
        {
            if (string.IsNullOrEmpty(id)) throw new ArgumentNullException(nameof(id));
            try
            {
                var employeeDto = _employeeBusiness.SelectAll();
                var model = _employeeSalaryBusiness.SelectById(long.Parse(id));
                var dtoViewModel = new DtoViewModel();
                var salaryViewModel = new EmployeeSalaryViewModel();
                salaryViewModel = dtoViewModel.EmployeeSalaryDtoToViewModel(model);
                salaryViewModel.Name = employeeDto.SingleOrDefault(item => item.ID == model.IDEmployee).Name;
                return View(salaryViewModel);
            }
            catch(Exception ex)
            {
                return NotFound();
            }
            
        }
        [Area("Admin")]
        [HttpPost]
        public IActionResult Edit(EmployeeSalaryViewModel employeeSalaryViewModel)
        {
            if (!ModelState.IsValid) return View(employeeSalaryViewModel);
            try
            {
                var salaryDto = new EmployeeSalaryDTO();
                var mapperSalary = new DtoViewModel();
                salaryDto = mapperSalary.EmployeeSalaryViewModelToDto(employeeSalaryViewModel);
                var check = _employeeSalaryBusiness.EditSalary(salaryDto);
                if (check)
                {
                    return Redirect("/Admin/EmployeeSalary");
                }
                else
                {
                    ViewBag.Message = "Thay đổi lương nhân viên thất bại";
                    return View(employeeSalaryViewModel);
                }
            }
            catch (Exception ex)
            {
                ViewBag.Message = "Thay đổi lương nhân viên thất bại";
                return View(employeeSalaryViewModel);
            }
        }
    }
}
