using Business.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Mvc.Areas.Admin.Mapper;
using Mvc.Areas.Admin.Models;
using Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mvc.Areas.Admin.DropdownList;
using Microsoft.AspNetCore.Mvc.Rendering;
using Common.DTO;

namespace Mvc.Areas.Admin.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserBusiness _userBusiness;

        public UserController(IUserBusiness userBusiness)
        {
            _userBusiness = userBusiness;
        }
        [Area("Admin")]
        public IActionResult Index(int page=1,int pageSize=5)
        {
            try
            {
                var model = _userBusiness.SelectByQuantityItem(page, pageSize);
                var userViewModels = new List<UserViewModel>();
                var mapperUser = new DtoViewModel();
                var pagination = new PaginationModel();
                var total = _userBusiness.GetTotal();
                foreach (var item in model)
                {
                    userViewModels.Add(mapperUser.UserDtoToUserViewModel(item));
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
                return View(userViewModels);
            }
            catch(Exception ex)
            {
                return Redirect("/");
            }
        }
        [Area("Admin")]
        [HttpPost]
        public IActionResult Delete(string id)
        {
            if (string.IsNullOrEmpty(id)) throw new ArgumentNullException(nameof(id));
            try
            {
                var check = _userBusiness.DeleteUser(long.Parse(id));
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
        public IActionResult Edit(string id)
        {
            if (string.IsNullOrEmpty(id)) throw new ArgumentNullException(nameof(id));
            try
            {
                long ID = long.Parse(id);
                var userDto  = _userBusiness.getUserDTOById(ID);
                var mapperDtoView = new DtoViewModel();
                var userViewModel = new UserViewModel();
                var _dropdownList = new DropdownListItem();
                ViewData["TypeUser"] = new SelectList(_dropdownList.DropdownListTypeUser(),"Value","Text");
                ViewData["TypeSex"] = new SelectList(_dropdownList.DropdownListTypeSex(), "Value", "Text");
                userViewModel = mapperDtoView.UserDtoToUserViewModel(userDto);
                return View(userViewModel);
            }
            catch(Exception ex)
            {
                return Redirect("/");
            }
        }
        [Area("Admin")]
        [HttpPost]
        public IActionResult Edit(UserViewModel userViewModel)
        {
            var _dropdownList = new DropdownListItem();
            var mapperDtoView = new DtoViewModel();
            ViewData["TypeUser"] = new SelectList(_dropdownList.DropdownListTypeUser(), "Value", "Text");
            ViewData["TypeSex"] = new SelectList(_dropdownList.DropdownListTypeSex(), "Value", "Text");
            if (!ModelState.IsValid) return View(userViewModel);
            try
            {
                var userDto = new UserDTO();
                var check = false;
                userDto = mapperDtoView.UserViewModelToUserDto(userViewModel);
                check = _userBusiness.EditUser(userDto);
                if (check)
                {
                    return Redirect("/Admin/User");
                }
                else
                {
                    ViewBag.Message = "Email đã tồn tại";
                    return View(userViewModel);
                }
            }
            catch(Exception ex)
            {
                ViewBag.Message = "Thay đổi người dùng thất bại";
                return View(userViewModel);
            }
                

            
        }
        [Area("Admin")]
        [HttpGet]
        public IActionResult Create()
        {
            var _dropdownList = new DropdownListItem();
            ViewData["TypeUser"] = new SelectList(_dropdownList.DropdownListTypeUser(), "Value", "Text");
            ViewData["TypeSex"] = new SelectList(_dropdownList.DropdownListTypeSex(), "Value", "Text");
            return View();
        }
        [Area("Admin")]
        [HttpPost]
        public IActionResult Create(UserViewModel userViewModel)
        {
            var _dropdownList = new DropdownListItem();
            var mapperDtoView = new DtoViewModel();
            ViewData["TypeUser"] = new SelectList(_dropdownList.DropdownListTypeUser(), "Value", "Text");
            ViewData["TypeSex"] = new SelectList(_dropdownList.DropdownListTypeSex(), "Value", "Text");
            if (!ModelState.IsValid) return View(userViewModel);
            try
            {
                var userDto = new UserDTO();
                var check = 0;
                userDto = mapperDtoView.UserViewModelToUserDto(userViewModel);
                userDto.CreatedDate = DateTime.Now;
                check = _userBusiness.CreateUser(userDto);
                if (check == 1)
                {
                    return Redirect("/Admin/User");
                }
                else if (check == 2) ViewBag.Message = "Tên tài khoản đã tồn tại";
                else ViewBag.Message = "Email đã tồn tại";
                return View(userViewModel);
            }
            catch(Exception ex)
            {
                ViewBag.Message = "Tạo người dùng không thành công";
                return View(userViewModel);
            }
        }
    }
}
