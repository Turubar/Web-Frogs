#pragma checksum "D:\Solutions\WebFrogs\WebFrogs\Views\Shared\HeaderPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f56001f58b199c23dc92ccc8d968311df39ec290"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_HeaderPartial), @"mvc.1.0.view", @"/Views/Shared/HeaderPartial.cshtml")]
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
#line 2 "D:\Solutions\WebFrogs\WebFrogs\Views\_ViewImports.cshtml"
using WebFrogs.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Solutions\WebFrogs\WebFrogs\Views\_ViewImports.cshtml"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f56001f58b199c23dc92ccc8d968311df39ec290", @"/Views/Shared/HeaderPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26ea3bb8c81121fddc2b8da985cd3ce52a18b811", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_HeaderPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<nav class=\"navbar navbar-expand-lg main-nav\">\r\n    <div class=\"container-fluid\">\r\n        <a class=\"navbar-brand main-icon\"");
            BeginWriteAttribute("asp-area", " asp-area=\"", 124, "\"", 135, 0);
            EndWriteAttribute();
            WriteLiteral(@" asp-controller=""Home"" asp-action=""Page"" href=""/Home/Page""></a>
        <button class=""navbar-toggler"" type=""button"" data-bs-toggle=""collapse""
                data-bs-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent"" aria-expanded=""false""
                aria-label=""Toggle navigation"">
            <span class=""navbar-toggler-icon""></span>
        </button>
        <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
            <ul class=""navbar-nav me-auto mb-2 mb-lg-0"">
                <li class=""nav-item"">
                    <a class=""nav-link mytab main-tab""");
            BeginWriteAttribute("asp-area", " asp-area=\"", 750, "\"", 761, 0);
            EndWriteAttribute();
            WriteLiteral(" asp-controller=\"Main\" asp-action=\"Page\" href=\"/Main/Page\">??????????????</a>\r\n                </li>\r\n                <li class=\"nav-item\">\r\n                    <a class=\"nav-link mytab toad-tab\"");
            BeginWriteAttribute("asp-area", " asp-area=\"", 950, "\"", 961, 0);
            EndWriteAttribute();
            WriteLiteral(" asp-controller=\"Toad\" asp-action=\"Page\" href=\"/Toad/Page\">??????????</a>\r\n                </li>\r\n                <li class=\"nav-item\">\r\n                    <a class=\"nav-link mytab frog-tab\"");
            BeginWriteAttribute("asp-area", " asp-area=\"", 1148, "\"", 1159, 0);
            EndWriteAttribute();
            WriteLiteral(" asp-controller=\"Frog\" asp-action=\"Page\" href=\"/Frog/Page\">??????????????</a>\r\n                </li>\r\n            </ul>\r\n        </div>\r\n    </div>\r\n</nav>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
