#pragma checksum "C:\Projects\ArgonDashboardTheme\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24883a49fee6d342a28ab1edd4c3306f96a1fff9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Projects\ArgonDashboardTheme\Views\_ViewImports.cshtml"
using ArgonDashboardTheme;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\ArgonDashboardTheme\Views\_ViewImports.cshtml"
using ArgonDashboardTheme.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24883a49fee6d342a28ab1edd4c3306f96a1fff9", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f6444a1a64b3f80da479bbcec3f576463f1edc0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Breadcrumbs", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Projects\ArgonDashboardTheme\Views\Home\Index.cshtml"
   ViewData["Title"] = "Dashboard"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-xl-8"">
        <div class=""card bg-default"">
            <div class=""card-header bg-transparent"">
                <div class=""row align-items-center"">
                    <div class=""col"">
                        <h6 class=""text-light text-uppercase ls-1 mb-1"">Overview</h6>
                        <h5 class=""h3 text-white mb-0"">Sales value</h5>
                    </div>
                    <div class=""col"">
                        <ul class=""nav nav-pills justify-content-end"">
                            <li class=""nav-item mr-2 mr-md-0"" data-toggle=""chart"" data-target=""#chart-sales-dark"" data-update='{""data"":{""datasets"":[{""data"":[0, 20, 10, 30, 15, 40, 20, 60, 60]}]}}' data-prefix=""$"" data-suffix=""k"">
                                <a href=""#"" class=""nav-link py-2 px-3 active"" data-toggle=""tab"">
                                    <span class=""d-none d-md-block"">Month</span>
                                    <span class=""d-md-none"">M</span>
         ");
            WriteLiteral(@"                       </a>
                            </li>
                            <li class=""nav-item"" data-toggle=""chart"" data-target=""#chart-sales-dark"" data-update='{""data"":{""datasets"":[{""data"":[0, 20, 5, 25, 10, 30, 15, 40, 40]}]}}' data-prefix=""$"" data-suffix=""k"">
                                <a href=""#"" class=""nav-link py-2 px-3"" data-toggle=""tab"">
                                    <span class=""d-none d-md-block"">Week</span>
                                    <span class=""d-md-none"">W</span>
                                </a>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
            <div class=""card-body"">
                <!-- Chart -->
                <div class=""chart"">
                    <!-- Chart wrapper -->
                    <canvas id=""chart-sales-dark"" class=""chart-canvas""></canvas>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-x");
            WriteLiteral(@"l-4"">
        <div class=""card"">
            <div class=""card-header bg-transparent"">
                <div class=""row align-items-center"">
                    <div class=""col"">
                        <h6 class=""text-uppercase text-muted ls-1 mb-1"">Performance</h6>
                        <h5 class=""h3 mb-0"">Total orders</h5>
                    </div>
                </div>
            </div>
            <div class=""card-body"">
                <!-- Chart -->
                <div class=""chart"">
                    <canvas id=""chart-bars"" class=""chart-canvas""></canvas>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""row"">
    <div class=""col-xl-8"">
        <div class=""card"">
            <div class=""card-header border-0"">
                <div class=""row align-items-center"">
                    <div class=""col"">
                        <h3 class=""mb-0"">Page visits</h3>
                    </div>
                    <div class=""col text-right"">
  ");
            WriteLiteral(@"                      <a href=""#!"" class=""btn btn-sm btn-primary"">See all</a>
                    </div>
                </div>
            </div>
            <div class=""table-responsive"">
                <!-- Projects table -->
                <table class=""table align-items-center table-flush"">
                    <thead class=""thead-light"">
                        <tr>
                            <th scope=""col"">Page name</th>
                            <th scope=""col"">Visitors</th>
                            <th scope=""col"">Unique users</th>
                            <th scope=""col"">Bounce rate</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <th scope=""row"">
                                /argon/
                            </th>
                            <td>
                                4,569
                            </td>
                            <td>
           ");
            WriteLiteral(@"                     340
                            </td>
                            <td>
                                <i class=""fas fa-arrow-up text-success mr-3""></i> 46,53%
                            </td>
                        </tr>
                        <tr>
                            <th scope=""row"">
                                /argon/index.html
                            </th>
                            <td>
                                3,985
                            </td>
                            <td>
                                319
                            </td>
                            <td>
                                <i class=""fas fa-arrow-down text-warning mr-3""></i> 46,53%
                            </td>
                        </tr>
                        <tr>
                            <th scope=""row"">
                                /argon/charts.html
                            </th>
                            <td>
        ");
            WriteLiteral(@"                        3,513
                            </td>
                            <td>
                                294
                            </td>
                            <td>
                                <i class=""fas fa-arrow-down text-warning mr-3""></i> 36,49%
                            </td>
                        </tr>
                        <tr>
                            <th scope=""row"">
                                /argon/tables.html
                            </th>
                            <td>
                                2,050
                            </td>
                            <td>
                                147
                            </td>
                            <td>
                                <i class=""fas fa-arrow-up text-success mr-3""></i> 50,87%
                            </td>
                        </tr>
                        <tr>
                            <th scope=""row"">
                 ");
            WriteLiteral(@"               /argon/profile.html
                            </th>
                            <td>
                                1,795
                            </td>
                            <td>
                                190
                            </td>
                            <td>
                                <i class=""fas fa-arrow-down text-danger mr-3""></i> 46,53%
                            </td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
    </div>
    <div class=""col-xl-4"">
        <div class=""card"">
            <div class=""card-header border-0"">
                <div class=""row align-items-center"">
                    <div class=""col"">
                        <h3 class=""mb-0"">Social traffic</h3>
                    </div>
                    <div class=""col text-right"">
                        <a href=""#!"" class=""btn btn-sm btn-primary"">See all</a>
                    </div>");
            WriteLiteral(@"
                </div>
            </div>
            <div class=""table-responsive"">
                <!-- Projects table -->
                <table class=""table align-items-center table-flush"">
                    <thead class=""thead-light"">
                        <tr>
                            <th scope=""col"">Referral</th>
                            <th scope=""col"">Visitors</th>
                            <th scope=""col""></th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <th scope=""row"">
                                Facebook
                            </th>
                            <td>
                                1,480
                            </td>
                            <td>
                                <div class=""d-flex align-items-center"">
                                    <span class=""mr-2"">60%</span>
                                    <div>
       ");
            WriteLiteral(@"                                 <div class=""progress"">
                                            <div class=""progress-bar bg-gradient-danger"" role=""progressbar"" aria-valuenow=""60"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 60%;""></div>
                                        </div>
                                    </div>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <th scope=""row"">
                                Facebook
                            </th>
                            <td>
                                5,480
                            </td>
                            <td>
                                <div class=""d-flex align-items-center"">
                                    <span class=""mr-2"">70%</span>
                                    <div>
                                        <div class=""progress"">
                                  ");
            WriteLiteral(@"          <div class=""progress-bar bg-gradient-success"" role=""progressbar"" aria-valuenow=""70"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 70%;""></div>
                                        </div>
                                    </div>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <th scope=""row"">
                                Google
                            </th>
                            <td>
                                4,807
                            </td>
                            <td>
                                <div class=""d-flex align-items-center"">
                                    <span class=""mr-2"">80%</span>
                                    <div>
                                        <div class=""progress"">
                                            <div class=""progress-bar bg-gradient-primary"" role=""progressbar"" aria-valuenow=""80");
            WriteLiteral(@""" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 80%;""></div>
                                        </div>
                                    </div>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <th scope=""row"">
                                Instagram
                            </th>
                            <td>
                                3,678
                            </td>
                            <td>
                                <div class=""d-flex align-items-center"">
                                    <span class=""mr-2"">75%</span>
                                    <div>
                                        <div class=""progress"">
                                            <div class=""progress-bar bg-gradient-info"" role=""progressbar"" aria-valuenow=""75"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 75%;""></div>
                        ");
            WriteLiteral(@"                </div>
                                    </div>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <th scope=""row"">
                                twitter
                            </th>
                            <td>
                                2,645
                            </td>
                            <td>
                                <div class=""d-flex align-items-center"">
                                    <span class=""mr-2"">30%</span>
                                    <div>
                                        <div class=""progress"">
                                            <div class=""progress-bar bg-gradient-warning"" role=""progressbar"" aria-valuenow=""30"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 30%;""></div>
                                        </div>
                                    </div>
                       ");
            WriteLiteral("         </div>\r\n                            </td>\r\n                        </tr>\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("DashboardCards", async() => {
                WriteLiteral(@"
    <!-- 2nd Row: Card stats (only for dashboard) -->
    <div class=""row"">
        <div class=""col-xl-3 col-md-6"">
            <div class=""card card-stats"">
                <!-- Card body -->
                <div class=""card-body"">
                    <div class=""row"">
                        <div class=""col"">
                            <h5 class=""card-title text-uppercase text-muted mb-0"">Total traffic</h5>
                            <span class=""h2 font-weight-bold mb-0"">350,897</span>
                        </div>
                        <div class=""col-auto"">
                            <div class=""icon icon-shape bg-gradient-red text-white rounded-circle shadow"">
                                <i class=""ni ni-active-40""></i>
                            </div>
                        </div>
                    </div>
                    <p class=""mt-3 mb-0 text-sm"">
                        <span class=""text-success mr-2""><i class=""fa fa-arrow-up""></i> 3.48%</span>
               ");
                WriteLiteral(@"         <span class=""text-nowrap"">Since last month</span>
                    </p>
                </div>
            </div>
        </div>
        <div class=""col-xl-3 col-md-6"">
            <div class=""card card-stats"">
                <!-- Card body -->
                <div class=""card-body"">
                    <div class=""row"">
                        <div class=""col"">
                            <h5 class=""card-title text-uppercase text-muted mb-0"">New users</h5>
                            <span class=""h2 font-weight-bold mb-0"">2,356</span>
                        </div>
                        <div class=""col-auto"">
                            <div class=""icon icon-shape bg-gradient-orange text-white rounded-circle shadow"">
                                <i class=""ni ni-chart-pie-35""></i>
                            </div>
                        </div>
                    </div>
                    <p class=""mt-3 mb-0 text-sm"">
                        <span class=""text-success ");
                WriteLiteral(@"mr-2""><i class=""fa fa-arrow-up""></i> 3.48%</span>
                        <span class=""text-nowrap"">Since last month</span>
                    </p>
                </div>
            </div>
        </div>
        <div class=""col-xl-3 col-md-6"">
            <div class=""card card-stats"">
                <!-- Card body -->
                <div class=""card-body"">
                    <div class=""row"">
                        <div class=""col"">
                            <h5 class=""card-title text-uppercase text-muted mb-0"">Sales</h5>
                            <span class=""h2 font-weight-bold mb-0"">924</span>
                        </div>
                        <div class=""col-auto"">
                            <div class=""icon icon-shape bg-gradient-green text-white rounded-circle shadow"">
                                <i class=""ni ni-money-coins""></i>
                            </div>
                        </div>
                    </div>
                    <p class=""mt-3 mb-0 tex");
                WriteLiteral(@"t-sm"">
                        <span class=""text-success mr-2""><i class=""fa fa-arrow-up""></i> 3.48%</span>
                        <span class=""text-nowrap"">Since last month</span>
                    </p>
                </div>
            </div>
        </div>
        <div class=""col-xl-3 col-md-6"">
            <div class=""card card-stats"">
                <!-- Card body -->
                <div class=""card-body"">
                    <div class=""row"">
                        <div class=""col"">
                            <h5 class=""card-title text-uppercase text-muted mb-0"">Performance</h5>
                            <span class=""h2 font-weight-bold mb-0"">49,65%</span>
                        </div>
                        <div class=""col-auto"">
                            <div class=""icon icon-shape bg-gradient-info text-white rounded-circle shadow"">
                                <i class=""ni ni-chart-bar-32""></i>
                            </div>
                        </div>
    ");
                WriteLiteral(@"                </div>
                    <p class=""mt-3 mb-0 text-sm"">
                        <span class=""text-success mr-2""><i class=""fa fa-arrow-up""></i> 3.48%</span>
                        <span class=""text-nowrap"">Since last month</span>
                    </p>
                </div>
            </div>
        </div>
    </div>
");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("Breadcrumbs", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "24883a49fee6d342a28ab1edd4c3306f96a1fff921626", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
            WriteLiteral("\r\n");
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
