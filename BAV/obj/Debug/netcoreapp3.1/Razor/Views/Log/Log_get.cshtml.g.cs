#pragma checksum "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\BAV\BAV\Views\Log\Log_get.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28b1ddfe1a8dd6bb74720c342ce06b69a7d70243"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Log_Log_get), @"mvc.1.0.view", @"/Views/Log/Log_get.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28b1ddfe1a8dd6bb74720c342ce06b69a7d70243", @"/Views/Log/Log_get.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a7311f396b10fd19d5cc9c3a472abe24ea75097", @"/Views/_ViewImports.cshtml")]
    public class Views_Log_Log_get : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SharedObjects.ValueObjects.VLog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<table class=""table table-bordered table-hover table-striped"">
    <thead>
        <tr class=""text-center bold"">
            <td>No.</td>
            <td>Serail Number</td>
            <td>Box Number</td>
            <td>Assembly Number</td>
            <td>Revision</td>
            <td>Accessory List</td>
            <td>Test Result</td>
            <td>Tester Name</td>
            <td>Created By</td>
            <td>Creation Date</td>
        </tr>
    </thead>
    <tbody id=""table-data"">

");
#nullable restore
#line 20 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\BAV\BAV\Views\Log\Log_get.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr class=\"text-center\">\r\n                <td");
            BeginWriteAttribute("id", " id=\"", 669, "\"", 674, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 23 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\BAV\BAV\Views\Log\Log_get.cshtml"
                     Write(item.rc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td");
            BeginWriteAttribute("id", " id=\"", 710, "\"", 715, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 24 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\BAV\BAV\Views\Log\Log_get.cshtml"
                     Write(item.SerailNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td");
            BeginWriteAttribute("id", " id=\"", 761, "\"", 766, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 25 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\BAV\BAV\Views\Log\Log_get.cshtml"
                     Write(item.BoxNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td");
            BeginWriteAttribute("id", " id=\"", 809, "\"", 814, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 26 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\BAV\BAV\Views\Log\Log_get.cshtml"
                     Write(item.AssemblyNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td");
            BeginWriteAttribute("id", " id=\"", 862, "\"", 867, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 27 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\BAV\BAV\Views\Log\Log_get.cshtml"
                     Write(item.Revision);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td");
            BeginWriteAttribute("id", " id=\"", 909, "\"", 914, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 28 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\BAV\BAV\Views\Log\Log_get.cshtml"
                     Write(item.AccessoryList);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td");
            BeginWriteAttribute("id", " id=\"", 961, "\"", 966, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 29 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\BAV\BAV\Views\Log\Log_get.cshtml"
                     Write(item.TestResult);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td");
            BeginWriteAttribute("id", " id=\"", 1010, "\"", 1015, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 30 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\BAV\BAV\Views\Log\Log_get.cshtml"
                     Write(item.TesterName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td");
            BeginWriteAttribute("id", " id=\"", 1059, "\"", 1064, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 31 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\BAV\BAV\Views\Log\Log_get.cshtml"
                     Write(item.CreatedBy);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td");
            BeginWriteAttribute("id", " id=\"", 1107, "\"", 1112, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 32 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\BAV\BAV\Views\Log\Log_get.cshtml"
                     Write(item.CreationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>              \r\n            </tr>\r\n");
#nullable restore
#line 34 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\BAV\BAV\Views\Log\Log_get.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SharedObjects.ValueObjects.VLog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
