#pragma checksum "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\BAV\BAV\Views\BAV\Configuration_Get.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5603d74f354e8decb09d22ab54aafb1b18fe63df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BAV_Configuration_Get), @"mvc.1.0.view", @"/Views/BAV/Configuration_Get.cshtml")]
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
#nullable restore
#line 1 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\BAV\BAV\Views\_ViewImports.cshtml"
using BAV;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\BAV\BAV\Views\_ViewImports.cshtml"
using BAV.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5603d74f354e8decb09d22ab54aafb1b18fe63df", @"/Views/BAV/Configuration_Get.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a7311f396b10fd19d5cc9c3a472abe24ea75097", @"/Views/_ViewImports.cshtml")]
    public class Views_BAV_Configuration_Get : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SharedObjects.ValueObjects.VConfiguration>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
    <table class=""table table-bordered table-hover table-striped"">
        <thead>
            <tr class=""text-center bold"">
                <td>No.</td>
                <td>Model</td>
                <td>Family</td>
                <td>Revision</td>
                <td>Accessory</td>
                <td>Description</td>
                <td>Creation Date</td>
                <td>Created By</td>
                <td>Created Name</td>
                <td style=""width:100px"">Modification</td>
            </tr>
        </thead>
        <tbody id=""table-data"">

");
            WriteLiteral(@"            <tr class=""text-center"">
                <td></td>
                <td><input type=""text"" id=""txt-model"" /></td>
                <td><input type=""text"" id=""txt-family"" /></td>
                <td><input type=""text"" id=""txt-revision"" /></td>
                <td><input type=""text"" id=""txt-accessory"" /></td>
                <td><input type=""text"" id=""txt-description"" /></td>
                <td></td>
                <td></td>
                <td></td>
                <td class=""text-center"">
                    <a id=""btn-add"" class=""btn default btn-xs purple update"" title=""Add""> <span class=""glyphicon glyphicon-plus""></span></a>
                </td>
            </tr>
");
#nullable restore
#line 77 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\BAV\BAV\Views\BAV\Configuration_Get.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"text-center\">\r\n\r\n\r\n                    <td");
            BeginWriteAttribute("id", " id=\"", 3533, "\"", 3538, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 82 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\BAV\BAV\Views\BAV\Configuration_Get.cshtml"
                         Write(item.rc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td");
            BeginWriteAttribute("id", " id=\"", 3578, "\"", 3583, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 83 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\BAV\BAV\Views\BAV\Configuration_Get.cshtml"
                         Write(item.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td");
            BeginWriteAttribute("id", " id=\"", 3626, "\"", 3631, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 84 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\BAV\BAV\Views\BAV\Configuration_Get.cshtml"
                         Write(item.Family);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td");
            BeginWriteAttribute("id", " id=\"", 3675, "\"", 3680, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 85 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\BAV\BAV\Views\BAV\Configuration_Get.cshtml"
                         Write(item.Revision);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td");
            BeginWriteAttribute("id", " id=\"", 3726, "\"", 3731, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 86 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\BAV\BAV\Views\BAV\Configuration_Get.cshtml"
                         Write(item.Accessory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td");
            BeginWriteAttribute("id", " id=\"", 3778, "\"", 3783, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 87 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\BAV\BAV\Views\BAV\Configuration_Get.cshtml"
                         Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td");
            BeginWriteAttribute("id", " id=\"", 3832, "\"", 3837, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 88 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\BAV\BAV\Views\BAV\Configuration_Get.cshtml"
                         Write(item.CreationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td");
            BeginWriteAttribute("id", " id=\"", 3887, "\"", 3892, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 89 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\BAV\BAV\Views\BAV\Configuration_Get.cshtml"
                         Write(item.CreatedBy);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td");
            BeginWriteAttribute("id", " id=\"", 3939, "\"", 3944, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 90 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\BAV\BAV\Views\BAV\Configuration_Get.cshtml"
                         Write(item.CreatedName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"text-center\">\r\n                        <a id=\"btn-delete\" class=\"btn default btn-xs red delete\" data-id=\"");
#nullable restore
#line 92 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\BAV\BAV\Views\BAV\Configuration_Get.cshtml"
                                                                                     Write(item.ConfigId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" title=\"Delete\"> <span class=\"glyphicon glyphicon-remove\"></span></a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 95 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\BAV\BAV\Views\BAV\Configuration_Get.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SharedObjects.ValueObjects.VConfiguration>> Html { get; private set; }
    }
}
#pragma warning restore 1591
