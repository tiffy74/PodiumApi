#pragma checksum "C:\Users\Ebayer\Source\Repos\Podium.API\Podium.API\Pages\NoAccess.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e0ed2ce5989c9fc2068ed79651f4734faae1bb5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Podium.API.Pages.Pages_NoAccess), @"mvc.1.0.razor-page", @"/Pages/NoAccess.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/NoAccess.cshtml", typeof(Podium.API.Pages.Pages_NoAccess), null)]
namespace Podium.API.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Ebayer\Source\Repos\Podium.API\Podium.API\Pages\_ViewImports.cshtml"
using Podium.API;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e0ed2ce5989c9fc2068ed79651f4734faae1bb5", @"/Pages/NoAccess.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a57291d07b405e2ed6c5d3ed75fe858e5137e8b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_NoAccess : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Ebayer\Source\Repos\Podium.API\Podium.API\Pages\NoAccess.cshtml"
  
    ViewData["Title"] = "Sorry...";

#line default
#line hidden
            BeginContext(73, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(78, 17, false);
#line 6 "C:\Users\Ebayer\Source\Repos\Podium.API\Podium.API\Pages\NoAccess.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(95, 123, true);
            WriteLiteral("</h2>\r\n\r\n<p>Sorry you are not old enough to use this feature.  You must be 18 or over in order to access our products</p>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NoAccessModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<NoAccessModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<NoAccessModel>)PageContext?.ViewData;
        public NoAccessModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591