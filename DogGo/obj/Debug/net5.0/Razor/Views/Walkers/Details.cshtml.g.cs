#pragma checksum "C:\Users\harde\workspace\back-end\DogGo\DogGo\Views\Walkers\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ff0ff744f6e665576de7c014922ada823b7e9ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Walkers_Details), @"mvc.1.0.view", @"/Views/Walkers/Details.cshtml")]
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
#line 1 "C:\Users\harde\workspace\back-end\DogGo\DogGo\Views\_ViewImports.cshtml"
using DogGo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\harde\workspace\back-end\DogGo\DogGo\Views\_ViewImports.cshtml"
using DogGo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ff0ff744f6e665576de7c014922ada823b7e9ca", @"/Views/Walkers/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12b50fd1f91f777ae09abf39d99992ea9d25da6c", @"/Views/_ViewImports.cshtml")]
    public class Views_Walkers_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DogGo.Models.ViewModels.WalkerViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\harde\workspace\back-end\DogGo\DogGo\Views\Walkers\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    <h4>Walker Profile</h4>\r\n    <section class=\"container\">\r\n        <img style=\"width:100px;float:left;margin-right:20px\"");
            BeginWriteAttribute("src", "\r\n             src=\"", 221, "\"", 263, 1);
#nullable restore
#line 9 "C:\Users\harde\workspace\back-end\DogGo\DogGo\Views\Walkers\Details.cshtml"
WriteAttributeValue("", 241, Model.Walker.ImageUrl, 241, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <div>\r\n            <label class=\"font-weight-bold\">Name:</label>\r\n            <span>");
#nullable restore
#line 12 "C:\Users\harde\workspace\back-end\DogGo\DogGo\Views\Walkers\Details.cshtml"
             Write(Model.Walker.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n        <div>\r\n            <label class=\"font-weight-bold\">Neighborhood:</label>\r\n            <span>");
#nullable restore
#line 16 "C:\Users\harde\workspace\back-end\DogGo\DogGo\Views\Walkers\Details.cshtml"
             Write(Model.Walker.Neighborhood.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
        </div>
    </section>
    <hr class=""mt-5"" />
    <div class=""clearfix""></div>
    <div class=""row"">
        <section class=""col-8 container mt-5"">
            <h1 class=""text-left"">Recent Walks</h1>
            <table class=""table"">
                <thead>
                    <tr>
                        <th>");
#nullable restore
#line 27 "C:\Users\harde\workspace\back-end\DogGo\DogGo\Views\Walkers\Details.cshtml"
                       Write(Html.DisplayNameFor(item => Model.Walks.FirstOrDefault().Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th>Client</th>\r\n");
            WriteLiteral("                        <th>");
#nullable restore
#line 30 "C:\Users\harde\workspace\back-end\DogGo\DogGo\Views\Walkers\Details.cshtml"
                       Write(Html.DisplayNameFor(item => Model.Walks.FirstOrDefault().Duration));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 34 "C:\Users\harde\workspace\back-end\DogGo\DogGo\Views\Walkers\Details.cshtml"
                     foreach (Walk walk in Model.Walks)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 38 "C:\Users\harde\workspace\back-end\DogGo\DogGo\Views\Walkers\Details.cshtml"
                           Write(walk.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 41 "C:\Users\harde\workspace\back-end\DogGo\DogGo\Views\Walkers\Details.cshtml"
                           Write(walk.Owner.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n");
            WriteLiteral("                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 47 "C:\Users\harde\workspace\back-end\DogGo\DogGo\Views\Walkers\Details.cshtml"
                            Write(walk.Duration);

#line default
#line hidden
#nullable disable
            WriteLiteral(" min\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 50 "C:\Users\harde\workspace\back-end\DogGo\DogGo\Views\Walkers\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </section>\r\n        <section class=\"mt-5\">\r\n            <dl>\r\n                <dt>Total Walk Time:</dt>\r\n                <dd>");
#nullable restore
#line 57 "C:\Users\harde\workspace\back-end\DogGo\DogGo\Views\Walkers\Details.cshtml"
               Write(Model.Walks.Sum(item => item.Duration));

#line default
#line hidden
#nullable disable
            WriteLiteral(" min</dd>\r\n            </dl>\r\n        </section>\r\n    </div>\r\n    <div>\r\n        ");
#nullable restore
#line 62 "C:\Users\harde\workspace\back-end\DogGo\DogGo\Views\Walkers\Details.cshtml"
   Write(Html.ActionLink("Edit", "Edit", new {  id = Model.Walker.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ff0ff744f6e665576de7c014922ada823b7e9ca8421", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DogGo.Models.ViewModels.WalkerViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
