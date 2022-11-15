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
    public class RewardController : Controller
    {
        private readonly IRewardBusiness _rewardBusiness;
        private readonly IEmployeeBusiness _employeeBusiness;
        private readonly IEmployeeSalaryBusiness _employeeSalaryBusiness;
        public RewardController(IRewardBusiness rewardBusiness,IEmployeeBusiness employeeBusiness,IEmployeeSalaryBusiness employeeSalaryBusiness)
        {
            _rewardBusiness = rewardBusiness;
            _employeeBusiness = employeeBusiness;
            _employeeSalaryBusiness = employeeSalaryBusiness;
        }
        [Area("Admin")]
        public IActionResult Index(int page = 1, int pageSize = 5)
        {
            try
            {
                var model = _rewardBusiness.SelectByQuantityItem(page, pageSize);
                var rewardViewModel = new List<RewardViewModel>();
                var mapperReward = new DtoViewModel();
                var pagination = new PaginationModel();
                var employeeDto = _employeeBusiness.SelectAll();
                var total = _rewardBusiness.GetTotal();
                var dtoViewModel = new DtoViewModel();
                if (model != null)
                {
                    foreach(var item in employeeDto)
                    {
                        foreach (var child  in model)
                        {
                            if (item.ID == child.IDEmployee)
                            {
                                var viewModel = mapperReward.RewardDtoToViewModel(child);
                                viewModel.Name = item.Name;
                                rewardViewModel.Add(viewModel);
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
                return View(rewardViewModel);
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
            var dropdownList = new DropdownListItem();
            ViewData["ListName"] = new SelectList(dropdownList.DropdownListName(employeeDto), "Value", "Text");
            return View();
        }
        [Area("Admin")]
        [HttpPost]
        public IActionResult Create(RewardViewModel rewardViewModel)
        {
            var employeeDto = _employeeBusiness.SelectAll();
            var dropdownList = new DropdownListItem();
            var listName = dropdownList.DropdownListName(employeeDto);
            ViewData["ListName"] = new SelectList(listName, "Value", "Text");
            if (!ModelState.IsValid) return View(rewardViewModel);
                var mapperReward = new DtoViewModel();
                rewardViewModel.IDEmployee = long.Parse(rewardViewModel.Name);
                var rewardDto = mapperReward.RewardViewModelToDto(rewardViewModel);
                rewardDto.CreatedBy = 1;
                _rewardBusiness.CreateReward(rewardDto);
                return Redirect("/Admin/Reward");
        }
        [Area("Admin")]
        [HttpPost]
        public IActionResult Delete(string id)
        {
            if (string.IsNullOrEmpty(id)) throw new ArgumentNullException(nameof(id));
            var ID = long.Parse(id);
            try
            {
                _rewardBusiness.DeleteReward(ID);
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
                var rewardDto = new RewardDTO();
                var dtoViewModel = new DtoViewModel();
                var rewardViewModel = new RewardViewModel();
                rewardDto = _rewardBusiness.GetRewardById(ID);
                rewardViewModel = dtoViewModel.RewardDtoToViewModel(rewardDto);
                var employeeDto = _employeeBusiness.SelectAll();
                rewardViewModel.Name = employeeDto.SingleOrDefault(x => x.ID == rewardViewModel.IDEmployee).Name;
                return View(rewardViewModel);
            }
            catch(Exception ex)
            {
                return NotFound();
            }
        }
        [Area("Admin")]
        [HttpPost]
        public IActionResult Edit(RewardViewModel rewardViewModel)
        {
            if (!ModelState.IsValid) return View(rewardViewModel);
            try
            {
                var rewardDto = new RewardDTO();
                var mapperReward = new DtoViewModel();
                rewardDto = mapperReward.RewardViewModelToDto(rewardViewModel);
                _rewardBusiness.EditReward(rewardDto);
                return Redirect("/Admin/Reward");
            }
            catch(Exception ex)
            {
                return NotFound();
            }
        }
    }
}
