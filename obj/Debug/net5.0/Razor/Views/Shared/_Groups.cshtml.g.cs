#pragma checksum "D:\Pro\ASP.Core\MyEshop\MyEshop_core\Views\Shared\_Groups.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80ed834e5ebb9506472b5df2244a1836ae36ca62"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Groups), @"mvc.1.0.view", @"/Views/Shared/_Groups.cshtml")]
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
#line 1 "D:\Pro\ASP.Core\MyEshop\MyEshop_core\Views\_ViewImports.cshtml"
using MyEshop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Pro\ASP.Core\MyEshop\MyEshop_core\Views\_ViewImports.cshtml"
using MyEshop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Pro\ASP.Core\MyEshop\MyEshop_core\Views\Shared\_Groups.cshtml"
using MyEshop.Data.Repositories;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80ed834e5ebb9506472b5df2244a1836ae36ca62", @"/Views/Shared/_Groups.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a8216f524d7ee13ea87b096575790f2a3183837", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__Groups : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<li class=""nav-item dropdown show"">
    <a class=""nav-link dropdown-toggle"" href=""http://example.com"" id=""dropdown09"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""true"">گروه ها</a>
    <div class=""dropdown-menu show"" aria-labelledby=""dropdown09"">
");
#nullable restore
#line 7 "D:\Pro\ASP.Core\MyEshop\MyEshop_core\Views\Shared\_Groups.cshtml"
         foreach (var item in _groupRepository.GetAllCategories())
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a class=\"dropdown-item\"");
            BeginWriteAttribute("href", " href=\"", 459, "\"", 492, 4);
            WriteAttributeValue("", 466, "/Group/", 466, 7, true);
#nullable restore
#line 9 "D:\Pro\ASP.Core\MyEshop\MyEshop_core\Views\Shared\_Groups.cshtml"
WriteAttributeValue("", 473, item.Id, 473, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 481, "/", 481, 1, true);
#nullable restore
#line 9 "D:\Pro\ASP.Core\MyEshop\MyEshop_core\Views\Shared\_Groups.cshtml"
WriteAttributeValue("", 482, item.Name, 482, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 9 "D:\Pro\ASP.Core\MyEshop\MyEshop_core\Views\Shared\_Groups.cshtml"
                                                                  Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 10 "D:\Pro\ASP.Core\MyEshop\MyEshop_core\Views\Shared\_Groups.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n    </div>\r\n</li>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IGroupRepository _groupRepository { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
