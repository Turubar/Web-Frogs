#pragma checksum "D:\Solutions\WebFrogs\WebFrogs\Views\Shared\MetatagsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f708fe8cf55ee661831154e03565a9a8cd273820"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_MetatagsPartial), @"mvc.1.0.view", @"/Views/Shared/MetatagsPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f708fe8cf55ee661831154e03565a9a8cd273820", @"/Views/Shared/MetatagsPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26ea3bb8c81121fddc2b8da985cd3ce52a18b811", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_MetatagsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<title>Web Frogs</title>\r\n<meta charset=\"utf-8\" />\r\n<meta name=\"viewport\" content=\"width=device-width\" />\r\n\r\n");
            WriteLiteral(@"<link rel=""apple-touch-icon"" sizes=""180x180"" href=""/images/favicon/apple-touch-icon.png"">
<link rel=""icon"" type=""image/png"" sizes=""32x32"" href=""/images/favicon/favicon-32x32.png"">
<link rel=""icon"" type=""image/png"" sizes=""16x16"" href=""/images/favicon/favicon-16x16.png"">
<link rel=""manifest"" href=""/images/favicon/site.webmanifest"">
<link rel=""mask-icon"" href=""/images/favicon/safari-pinned-tab.svg"" color=""#5bbad5"">
<meta name=""msapplication-TileColor"" content=""#da532c"">
<meta name=""theme-color"" content=""#ffffff"">


");
#nullable restore
#line 15 "D:\Solutions\WebFrogs\WebFrogs\Views\Shared\MetatagsPartial.cshtml"
 if (ViewBag.Title != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <title>");
#nullable restore
#line 17 "D:\Solutions\WebFrogs\WebFrogs\Views\Shared\MetatagsPartial.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</title>\r\n");
#nullable restore
#line 18 "D:\Solutions\WebFrogs\WebFrogs\Views\Shared\MetatagsPartial.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <title>Web Frogs</title>\r\n");
#nullable restore
#line 22 "D:\Solutions\WebFrogs\WebFrogs\Views\Shared\MetatagsPartial.cshtml"
}

#line default
#line hidden
#nullable disable
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
