#pragma checksum "C:\Users\t-zhoya\source\repos\TeamsBot\microsoft-teams-sample-tabs\PersonalTabMVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f54e1c151d280fea2d83dcc70184b7191079f294"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f54e1c151d280fea2d83dcc70184b7191079f294", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\t-zhoya\source\repos\TeamsBot\microsoft-teams-sample-tabs\PersonalTabMVC\Views\Home\Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 style=\"color:#6364a5\">Hello, world!</h1>\r\n\r\n\r\n<div>\r\n\r\n    Welcome to your new application.<br />\r\n\r\n</div>\r\n\r\n<div>\r\n\r\n    <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 183, "\"", 218, 3);
            WriteAttributeValue("", 193, "alert(\'", 193, 7, true);
#nullable restore
#line 16 "C:\Users\t-zhoya\source\repos\TeamsBot\microsoft-teams-sample-tabs\PersonalTabMVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 200, ViewBag.Message, 200, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 216, "\')", 216, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"appButton\">Click Me!</button>\r\n\r\n</div>\r\n");
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
