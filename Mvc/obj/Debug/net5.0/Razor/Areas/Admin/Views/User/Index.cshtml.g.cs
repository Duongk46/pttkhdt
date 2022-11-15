#pragma checksum "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16bc04a82afacc36607c2abdd21b85e057887a47"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_User_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/User/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16bc04a82afacc36607c2abdd21b85e057887a47", @"/Areas/Admin/Views/User/Index.cshtml")]
    public class Areas_Admin_Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Mvc.Areas.Admin.Models.UserViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/../Areas/Admin/assets/js/User.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\User\Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Areas/Admin/Views/Shared/Layout/_Layout.cshtml";
    var pagination = (Mvc.Models.PaginationModel)ViewData["Pagination"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("css", async() => {
                WriteLiteral("\r\n\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("js", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16bc04a82afacc36607c2abdd21b85e057887a473555", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral(@"<div class=""container-fluid"">
    <!-- DataTales Example -->
    <div class=""card shadow mb-4"">
        <div class=""card-header py-3"">
            <h6 class=""m-0 font-weight-bold text-primary"">Danh sách user</h6>
        </div>
        <div class=""card-body"">
            <div class=""table-responsive"">
                <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                    <thead>
                        <tr>
                            <th>Tên</th>
                            <th>Tài khoản</th>
                            <th>Ngày sinh</th>
                            <th>Nơi ở</th>
                            <th>Sdt</th>
                            <th>Giới tính</th>
                            <th>Email</th>
                            <th>Loại user</th>
                            <th>Công cụ</th>
                        </tr>
                    </thead>
                    <tfoot>
                        <tr>
                          ");
            WriteLiteral(@"  <th>Tên</th>
                            <th>Tài khoản</th>
                            <th>Ngày sinh</th>
                            <th>Nơi ở</th>
                            <th>Sdt</th>
                            <th>Giới tính</th>
                            <th>Email</th>
                            <th>Loại user</th>
                            <th>Công cụ</th>
                        </tr>
                    </tfoot>
                    <tbody>
");
#nullable restore
#line 51 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\User\Index.cshtml"
                         if (Model != null)
                            {
                                foreach (var item in Model)
                                {
                                    var getYear = @item.BirthDay.Day + "/" + @item.BirthDay.Month + "/" + @item.BirthDay.Year;
                                    var tick = "fa-solid fa-check color-tick";
                                    var xmask = "fa-solid fa-xmark color-xmask";
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr");
            BeginWriteAttribute("class", " class=\"", 2339, "\"", 2360, 2);
            WriteAttributeValue("", 2347, "item-", 2347, 5, true);
#nullable restore
#line 58 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 2352, item.ID, 2352, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 60 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\User\Index.cshtml"
                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>");
#nullable restore
#line 62 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\User\Index.cshtml"
                                       Write(item.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 63 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\User\Index.cshtml"
                                       Write(getYear);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 64 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\User\Index.cshtml"
                                       Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 65 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\User\Index.cshtml"
                                       Write(item.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 66 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\User\Index.cshtml"
                                        Write(item.Sex == true ? "Nam" : "Nữ");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 67 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\User\Index.cshtml"
                                       Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 68 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\User\Index.cshtml"
                                        Write(item.UserType == 1 ? "Quản lý" : "Người dùng");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 3101, "\"", 3133, 2);
            WriteAttributeValue("", 3108, "/Admin/User/Edit/", 3108, 17, true);
#nullable restore
#line 70 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 3125, item.ID, 3125, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"margin-right: 2px\"><i class=\"fa-solid fa-pen color-edit\"></i></a>\r\n                                            <span class=\"_deleteUser\" data-bs-toggle=\"modal\" data-bs-target=\"#deleteUser\" data-id=\"");
#nullable restore
#line 71 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\User\Index.cshtml"
                                                                                                                              Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" style=\"cursor: pointer; margin-right: 2px\"><i class=\"fa-solid fa-trash color-trash\"></i></span>\r\n                                            <i");
            BeginWriteAttribute("class", " class=\"", 3493, "\"", 3538, 1);
#nullable restore
#line 72 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 3501, item.Status == true ? tick : xmask, 3501, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 75 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\User\Index.cshtml"
                                }
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </tbody>
                </table>
            </div>
            <div class=""row"" style=""justify-content: space-between;"">
                <div class=""col-sm-12 col-md-5"">
                    <div class=""dataTables_info"" id=""dataTable_info"" role=""status"" aria-live=""polite"">Showing ");
#nullable restore
#line 83 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\User\Index.cshtml"
                                                                                                         Write(pagination.Show);

#line default
#line hidden
#nullable disable
            WriteLiteral(" to ");
#nullable restore
#line 83 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\User\Index.cshtml"
                                                                                                                             Write(pagination.ShowTo);

#line default
#line hidden
#nullable disable
            WriteLiteral(" of ");
#nullable restore
#line 83 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\User\Index.cshtml"
                                                                                                                                                   Write(pagination.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral(" entries</div>\r\n                </div>\r\n                <div class=\"col-md-4\">\r\n                    <div class=\"dataTables_paginate paging_simple_numbers\" id=\"dataTable_paginate\">\r\n                        <ul class=\"pagination\">\r\n");
#nullable restore
#line 88 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\User\Index.cshtml"
                             if (pagination.Total > 1)
                                {
                                    var pageDisplay = (int)(pagination.MaxPage);
                                    long totalPage = (long)(pagination.TotalPage);
                                    int currentPage = (int)(pagination.Page);
                                    var start = 1;
                                    var end = totalPage;
                                    var link = "/admin/user";
                                    if (currentPage > 1)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li class=\"paginate_button page-item previous\" id=\"dataTable_previous\">\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 5065, "\"", 5099, 3);
#nullable restore
#line 99 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 5072, link, 5072, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5077, "?page=", 5077, 6, true);
#nullable restore
#line 99 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 5083, pagination.Prev, 5083, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-controls=\"dataTable\" data-dt-idx=\"0\" tabindex=\"0\" class=\"page-link\">Previous</a>\r\n                                        </li>\r\n");
#nullable restore
#line 101 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\User\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li class=\"paginate_button page-item previous disabled\" id=\"dataTable_previous\">\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 5523, "\"", 5557, 3);
#nullable restore
#line 105 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 5530, link, 5530, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5535, "?page=", 5535, 6, true);
#nullable restore
#line 105 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 5541, pagination.Prev, 5541, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-controls=\"dataTable\" data-dt-idx=\"0\" tabindex=\"0\" class=\"page-link\">Previous</a>\r\n                                        </li>\r\n");
#nullable restore
#line 107 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\User\Index.cshtml"
                                    }
                                    for (int i = start; i <= end; i++)
                                    {
                                        if (currentPage == i)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li class=\"paginate_button page-item active\">\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 6090, "\"", 6110, 3);
#nullable restore
#line 113 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 6097, link, 6097, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6102, "?page=", 6102, 6, true);
#nullable restore
#line 113 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 6108, i, 6108, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-controls=\"dataTable\" data-dt-idx=\"");
#nullable restore
#line 113 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\User\Index.cshtml"
                                                                                                          Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" tabindex=\"0\" class=\"page-link\">");
#nullable restore
#line 113 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\User\Index.cshtml"
                                                                                                                                             Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            </li>\r\n");
#nullable restore
#line 115 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\User\Index.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li class=\"paginate_button page-item \">\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 6512, "\"", 6532, 3);
#nullable restore
#line 119 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 6519, link, 6519, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6524, "?page=", 6524, 6, true);
#nullable restore
#line 119 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 6530, i, 6530, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-controls=\"dataTable\" data-dt-idx=\"");
#nullable restore
#line 119 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\User\Index.cshtml"
                                                                                                          Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" tabindex=\"0\" class=\"page-link\">");
#nullable restore
#line 119 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\User\Index.cshtml"
                                                                                                                                             Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            </li>\r\n");
#nullable restore
#line 121 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\User\Index.cshtml"
                                        }
                                    }
                                    if (currentPage < totalPage)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li class=\"paginate_button page-item next\" id=\"dataTable_next\">\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 7005, "\"", 7039, 3);
#nullable restore
#line 126 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 7012, link, 7012, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7017, "?page=", 7017, 6, true);
#nullable restore
#line 126 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 7023, pagination.Next, 7023, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-controls=\"dataTable\" data-dt-idx=\"");
#nullable restore
#line 126 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\User\Index.cshtml"
                                                                                                                    Write(pagination.Next);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" tabindex=\"0\" class=\"page-link\">Next</a>\r\n                                        </li>\r\n");
#nullable restore
#line 128 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\User\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li class=\"paginate_button page-item next disabled\" id=\"dataTable_next\">\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 7466, "\"", 7500, 3);
#nullable restore
#line 132 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 7473, link, 7473, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7478, "?page=", 7478, 6, true);
#nullable restore
#line 132 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 7484, pagination.Next, 7484, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-controls=\"dataTable\" data-dt-idx=\"");
#nullable restore
#line 132 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\User\Index.cshtml"
                                                                                                                    Write(pagination.Next);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" tabindex=\"0\" class=\"page-link\">Next</a>\r\n                                        </li>\r\n");
#nullable restore
#line 134 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\User\Index.cshtml"
                                    }
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""modal fade"" id=""deleteUser"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h1 class=""modal-title fs-5"" id=""exampleModalLabel"">Modal title</h1>
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body"">
                Bạn có chắc là muốn xóa người dùng này?
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-bs-dismiss=""modal"">Quay lại</button>
                <button type=""button"" class=""btn btn-primary btn-submit"">Đồng ý</button>
            </div>
        </div>
    </div>
</div>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Mvc.Areas.Admin.Models.UserViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591