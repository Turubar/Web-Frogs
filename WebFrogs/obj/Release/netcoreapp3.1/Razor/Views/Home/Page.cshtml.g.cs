#pragma checksum "D:\Solutions\WebFrogs\WebFrogs\Views\Home\Page.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52c94829c669925a9e39b3d4cc4fcd5158a69d79"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Page), @"mvc.1.0.view", @"/Views/Home/Page.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52c94829c669925a9e39b3d4cc4fcd5158a69d79", @"/Views/Home/Page.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26ea3bb8c81121fddc2b8da985cd3ce52a18b811", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Page : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<style>
    .main-icon {
        background-image: url(../images/icon_active.png);
    }

    .mytab {
        color: white;
    }
</style>

<div class=""container-fluid mt-5"">
    <div class=""row home-div"">
        <div class=""col-lg-5 img-container"">
            <img src=""../images/homepage_gif.gif""");
            BeginWriteAttribute("alt", " alt=\"", 314, "\"", 320, 0);
            EndWriteAttribute();
            WriteLiteral(@">
        </div>
        <div class=""col-lg-7 text-container justify-content-center"">
            <div class=""text-name"">
                <h1><span class=""web-span"">Web </span><span class=""frogs-span"">Frogs</span></h1>
                <h2><span class=""web-span"">Все о мире </span><span class=""frogs-span"">лягушек и жаб</span></h2>
            </div>
            <div class=""text-stack"">
                <h3>Проект создан с помощью:</h3>
                <h4>ASP.NET Core 3.1 MVC</h4>
                <h4>Entity Framework Core, MSSQL</h4>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
