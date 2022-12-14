#pragma checksum "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Discipline\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0cd7d1a350bff943bf9877546596d7e173d24b92"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Discipline_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Discipline/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0cd7d1a350bff943bf9877546596d7e173d24b92", @"/Areas/Admin/Views/Discipline/Index.cshtml")]
    public class Areas_Admin_Views_Discipline_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Mvc.Areas.Admin.Models.DisciplineViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/../Areas/Admin/assets/js/Discipline.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Discipline\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/Layout/_Layout.cshtml";
    var pagination = (Mvc.Models.PaginationModel)ViewData["Pagination"];

#line default
#line hidden
#nullable disable
            DefineSection("js", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0cd7d1a350bff943bf9877546596d7e173d24b923416", async() => {
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
            WriteLiteral("<div class=\"container-fluid\">\r\n    <!-- DataTales Example -->\r\n");
#nullable restore
#line 12 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Discipline\Index.cshtml"
     if (Model != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""card shadow mb-4"">
            <div class=""card-header py-3"">
                <h6 class=""m-0 font-weight-bold text-primary"">Danh s??ch k?? lu???t</h6>
            </div>
            <div class=""card-body"">

                <div class=""table-responsive"">
                    <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                        <thead>
                            <tr>
                                <th>T??n k??? lu???t</th>
                                <th>T??n</th>
                                <th>S??? ti???n</th>
                                <th>C??ng c???</th>
                            </tr>
                        </thead>
                        <tfoot>
                            <tr>
                                <th>T??n k??? lu???t</th>
                                <th>T??n</th>
                                <th>S??? ti???n</th>
                                <th>C??ng c???</th>
                            </tr>
       ");
            WriteLiteral("                 </tfoot>\r\n                        <tbody>\r\n");
#nullable restore
#line 39 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Discipline\Index.cshtml"
                             foreach (var item in Model)
                            {
                                var tick = "fa-solid fa-check color-tick";
                                var xmask = "fa-solid fa-xmark color-xmask";

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr");
            BeginWriteAttribute("class", " class=\"", 1789, "\"", 1810, 2);
            WriteAttributeValue("", 1797, "item-", 1797, 5, true);
#nullable restore
#line 43 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Discipline\Index.cshtml"
WriteAttributeValue("", 1802, item.ID, 1802, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <td>");
#nullable restore
#line 44 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Discipline\Index.cshtml"
                                   Write(item.NameDiscipline);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 46 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Discipline\Index.cshtml"
                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>");
#nullable restore
#line 48 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Discipline\Index.cshtml"
                                   Write(item.Money);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 2160, "\"", 2198, 2);
            WriteAttributeValue("", 2167, "/Admin/Discipline/Edit/", 2167, 23, true);
#nullable restore
#line 50 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Discipline\Index.cshtml"
WriteAttributeValue("", 2190, item.ID, 2190, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"margin-right: 2px\"><i class=\"fa-solid fa-pen color-edit\"></i></a>\r\n                                        <span class=\"_deleteDiscipline\" data-bs-toggle=\"modal\" data-bs-target=\"#deleteDiscipline\" data-id=\"");
#nullable restore
#line 51 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Discipline\Index.cshtml"
                                                                                                                                      Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" style=\"cursor: pointer; margin-right: 2px\"><i class=\"fa-solid fa-trash color-trash\"></i></span>\r\n                                        <i");
            BeginWriteAttribute("class", " class=\"", 2562, "\"", 2607, 1);
#nullable restore
#line 52 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Discipline\Index.cshtml"
WriteAttributeValue("", 2570, item.Status == true ? tick : xmask, 2570, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 55 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Discipline\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </tbody>
                    </table>
                </div>
                <div class=""row"" style=""justify-content: space-between;"">
                    <div class=""col-sm-12 col-md-5"">
                        <div class=""dataTables_info"" id=""dataTable_info"" role=""status"" aria-live=""polite"">Showing ");
#nullable restore
#line 61 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Discipline\Index.cshtml"
                                                                                                             Write(pagination.Show);

#line default
#line hidden
#nullable disable
            WriteLiteral(" to ");
#nullable restore
#line 61 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Discipline\Index.cshtml"
                                                                                                                                 Write(pagination.ShowTo);

#line default
#line hidden
#nullable disable
            WriteLiteral(" of ");
#nullable restore
#line 61 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Discipline\Index.cshtml"
                                                                                                                                                       Write(pagination.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral(" entries</div>\r\n                    </div>\r\n                    <div class=\"col-md-4\">\r\n                        <div class=\"dataTables_paginate paging_simple_numbers\" id=\"dataTable_paginate\">\r\n                            <ul class=\"pagination\">\r\n");
#nullable restore
#line 66 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Discipline\Index.cshtml"
                                 if (pagination.Total > 1)
                                {
                                    var pageDisplay = (int)(pagination.MaxPage);
                                    long totalPage = (long)(pagination.TotalPage);
                                    int currentPage = (int)(pagination.Page);
                                    var start = 1;
                                    var end = totalPage;
                                    var link = "/Admin/Discipline";
                                    if (currentPage > 1)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li class=\"paginate_button page-item previous\" id=\"dataTable_previous\">\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 4139, "\"", 4173, 3);
#nullable restore
#line 77 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Discipline\Index.cshtml"
WriteAttributeValue("", 4146, link, 4146, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4151, "?page=", 4151, 6, true);
#nullable restore
#line 77 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Discipline\Index.cshtml"
WriteAttributeValue("", 4157, pagination.Prev, 4157, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-controls=\"dataTable\" data-dt-idx=\"0\" tabindex=\"0\" class=\"page-link\">Previous</a>\r\n                                        </li>\r\n");
#nullable restore
#line 79 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Discipline\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li class=\"paginate_button page-item previous disabled\" id=\"dataTable_previous\">\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 4597, "\"", 4631, 3);
#nullable restore
#line 83 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Discipline\Index.cshtml"
WriteAttributeValue("", 4604, link, 4604, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4609, "?page=", 4609, 6, true);
#nullable restore
#line 83 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Discipline\Index.cshtml"
WriteAttributeValue("", 4615, pagination.Prev, 4615, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-controls=\"dataTable\" data-dt-idx=\"0\" tabindex=\"0\" class=\"page-link\">Previous</a>\r\n                                        </li>\r\n");
#nullable restore
#line 85 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Discipline\Index.cshtml"
                                    }
                                    for (int i = start; i <= end; i++)
                                    {
                                        if (currentPage == i)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li class=\"paginate_button page-item active\">\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 5164, "\"", 5184, 3);
#nullable restore
#line 91 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Discipline\Index.cshtml"
WriteAttributeValue("", 5171, link, 5171, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5176, "?page=", 5176, 6, true);
#nullable restore
#line 91 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Discipline\Index.cshtml"
WriteAttributeValue("", 5182, i, 5182, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-controls=\"dataTable\" data-dt-idx=\"");
#nullable restore
#line 91 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Discipline\Index.cshtml"
                                                                                                          Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" tabindex=\"0\" class=\"page-link\">");
#nullable restore
#line 91 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Discipline\Index.cshtml"
                                                                                                                                             Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            </li>\r\n");
#nullable restore
#line 93 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Discipline\Index.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li class=\"paginate_button page-item \">\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 5586, "\"", 5606, 3);
#nullable restore
#line 97 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Discipline\Index.cshtml"
WriteAttributeValue("", 5593, link, 5593, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5598, "?page=", 5598, 6, true);
#nullable restore
#line 97 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Discipline\Index.cshtml"
WriteAttributeValue("", 5604, i, 5604, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-controls=\"dataTable\" data-dt-idx=\"");
#nullable restore
#line 97 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Discipline\Index.cshtml"
                                                                                                          Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" tabindex=\"0\" class=\"page-link\">");
#nullable restore
#line 97 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Discipline\Index.cshtml"
                                                                                                                                             Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            </li>\r\n");
#nullable restore
#line 99 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Discipline\Index.cshtml"
                                        }
                                    }
                                    if (currentPage < totalPage)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li class=\"paginate_button page-item next\" id=\"dataTable_next\">\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 6079, "\"", 6113, 3);
#nullable restore
#line 104 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Discipline\Index.cshtml"
WriteAttributeValue("", 6086, link, 6086, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6091, "?page=", 6091, 6, true);
#nullable restore
#line 104 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Discipline\Index.cshtml"
WriteAttributeValue("", 6097, pagination.Next, 6097, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-controls=\"dataTable\" data-dt-idx=\"");
#nullable restore
#line 104 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Discipline\Index.cshtml"
                                                                                                                    Write(pagination.Next);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" tabindex=\"0\" class=\"page-link\">Next</a>\r\n                                        </li>\r\n");
#nullable restore
#line 106 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Discipline\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li class=\"paginate_button page-item next disabled\" id=\"dataTable_next\">\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 6540, "\"", 6574, 3);
#nullable restore
#line 110 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Discipline\Index.cshtml"
WriteAttributeValue("", 6547, link, 6547, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6552, "?page=", 6552, 6, true);
#nullable restore
#line 110 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Discipline\Index.cshtml"
WriteAttributeValue("", 6558, pagination.Next, 6558, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-controls=\"dataTable\" data-dt-idx=\"");
#nullable restore
#line 110 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Discipline\Index.cshtml"
                                                                                                                    Write(pagination.Next);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" tabindex=\"0\" class=\"page-link\">Next</a>\r\n                                        </li>\r\n");
#nullable restore
#line 112 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Discipline\Index.cshtml"
                                    }
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </ul>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 120 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\Discipline\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>

<div class=""modal fade"" id=""deleteDiscipline"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h1 class=""modal-title fs-5"" id=""exampleModalLabel"">Modal title</h1>
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body"">
                B???n c?? ch???c l?? mu???n x??a nh??n vi??n n??y?
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-bs-dismiss=""modal"">Quay l???i</button>
                <button type=""button"" class=""btn btn-primary btn-submit"">?????ng ??</button>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Mvc.Areas.Admin.Models.DisciplineViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
