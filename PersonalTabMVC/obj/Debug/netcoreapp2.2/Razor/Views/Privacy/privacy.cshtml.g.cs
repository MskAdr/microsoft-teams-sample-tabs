#pragma checksum "C:\Users\t-zhoya\source\repos\TeamsBot\microsoft-teams-sample-tabs\PersonalTabMVC\Views\Privacy\privacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33d057a1cca1c02183f9700e3b6b32ffed2765fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Privacy_privacy), @"mvc.1.0.view", @"/Views/Privacy/privacy.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Privacy/privacy.cshtml", typeof(AspNetCore.Views_Privacy_privacy))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33d057a1cca1c02183f9700e3b6b32ffed2765fa", @"/Views/Privacy/privacy.cshtml")]
    public class Views_Privacy_privacy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\t-zhoya\source\repos\TeamsBot\microsoft-teams-sample-tabs\PersonalTabMVC\Views\Privacy\privacy.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(34, 71, true);
            WriteLiteral("\r\n<h1 style=\"color:#6364a5\">Application Privacy</h1><br />\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(106, 15, false);
#line 9 "C:\Users\t-zhoya\source\repos\TeamsBot\microsoft-teams-sample-tabs\PersonalTabMVC\Views\Privacy\privacy.cshtml"
Write(ViewBag.Message);

#line default
#line hidden
            EndContext();
            BeginContext(121, 8, true);
            WriteLiteral("\r\n</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
