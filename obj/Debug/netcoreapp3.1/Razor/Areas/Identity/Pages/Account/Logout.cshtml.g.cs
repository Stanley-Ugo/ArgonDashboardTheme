#pragma checksum "C:\Projects\ArgonDashboardTheme\Areas\Identity\Pages\Account\Logout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "717290da7507f9329619df9fc5a00aa15ca987a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ArgonDashboardTheme.Areas.Identity.Pages.Account.Areas_Identity_Pages_Account_Logout), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/Logout.cshtml")]
namespace ArgonDashboardTheme.Areas.Identity.Pages.Account
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
#line 1 "C:\Projects\ArgonDashboardTheme\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\ArgonDashboardTheme\Areas\Identity\Pages\_ViewImports.cshtml"
using ArgonDashboardTheme.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Projects\ArgonDashboardTheme\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using ArgonDashboardTheme.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"717290da7507f9329619df9fc5a00aa15ca987a3", @"/Areas/Identity/Pages/Account/Logout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39efc2f6798ddb4544212430417bd3f13101e635", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9eabb9a545df0094ba6b3425eaf2af7db6d8e3b3", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Logout : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Projects\ArgonDashboardTheme\Areas\Identity\Pages\Account\Logout.cshtml"
  
    ViewData["Title"] = "Log out";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<header>\n    <h1>");
#nullable restore
#line 8 "C:\Projects\ArgonDashboardTheme\Areas\Identity\Pages\Account\Logout.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n    <p>You have successfully logged out of the application.</p>\n</header>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LogoutModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LogoutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LogoutModel>)PageContext?.ViewData;
        public LogoutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
