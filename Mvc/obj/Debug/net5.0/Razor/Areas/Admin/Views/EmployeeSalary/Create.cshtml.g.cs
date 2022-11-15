#pragma checksum "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\EmployeeSalary\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1de54c9d113dcceb70d68cfad807133b888061ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_EmployeeSalary_Create), @"mvc.1.0.view", @"/Areas/Admin/Views/EmployeeSalary/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1de54c9d113dcceb70d68cfad807133b888061ce", @"/Areas/Admin/Views/EmployeeSalary/Create.cshtml")]
    public class Areas_Admin_Views_EmployeeSalary_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Mvc.Areas.Admin.Models.EmployeeSalaryViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\EmployeeSalary\Create.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Areas/Admin/Views/Shared/Layout/_Layout.cshtml";
    var listName = (SelectList)ViewData["ListName"];

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"col-md-12\">\r\n");
#nullable restore
#line 10 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\EmployeeSalary\Create.cshtml"
         using (Html.BeginForm("", "", FormMethod.Post, new { action = "/Admin/EmployeeSalary/Create" }))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\EmployeeSalary\Create.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"form-horizontal\">\r\n            <h4>Tạo lương nhân viên</h4>\r\n            <hr />\r\n            ");
#nullable restore
#line 16 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\EmployeeSalary\Create.cshtml"
       Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 17 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\EmployeeSalary\Create.cshtml"
             if (ViewBag.Message != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"alert alert-danger\">");
#nullable restore
#line 19 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\EmployeeSalary\Create.cshtml"
                                           Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 20 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\EmployeeSalary\Create.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 22 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\EmployeeSalary\Create.cshtml"
           Write(Html.LabelFor(model => model.Name, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div");
            BeginWriteAttribute("class", " class=\"", 915, "\"", 923, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 24 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\EmployeeSalary\Create.cshtml"
               Write(Html.DropDownListFor(model => model.Name, listName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 25 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\EmployeeSalary\Create.cshtml"
               Write(Html.ValidationMessageFor(model => model.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 29 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\EmployeeSalary\Create.cshtml"
           Write(Html.LabelFor(model => model.Salary, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"form-width-txt\">\r\n                    ");
#nullable restore
#line 31 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\EmployeeSalary\Create.cshtml"
               Write(Html.TextBoxFor(model => model.Salary, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 32 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\EmployeeSalary\Create.cshtml"
               Write(Html.ValidationMessageFor(model => model.Salary, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 36 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\EmployeeSalary\Create.cshtml"
           Write(Html.LabelFor(model => model.Status, htmlAttributes: new { @class = "control-label " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div>\r\n                    ");
#nullable restore
#line 38 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\EmployeeSalary\Create.cshtml"
               Write(Html.CheckBoxFor(model => model.Status, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 39 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\EmployeeSalary\Create.cshtml"
               Write(Html.ValidationMessageFor(model => model.Status, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
            </div>
            <div class=""form-group"">
                <div class=""col-md-offset-2"">
                    <input type=""submit"" value=""Thay đổi"" class=""btn btn-success"" />
                </div>
            </div>
        </div>
");
#nullable restore
#line 48 "D:\pttkhdt\Web\Mvc\Areas\Admin\Views\EmployeeSalary\Create.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Mvc.Areas.Admin.Models.EmployeeSalaryViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
