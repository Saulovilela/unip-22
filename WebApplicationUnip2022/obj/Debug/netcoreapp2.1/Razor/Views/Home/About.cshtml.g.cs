#pragma checksum "C:\Users\Saulo\workspace\WebApplicationUnip2022\WebApplicationUnip2022\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fdbf8fa6180d38ff9b3391401492cff7e1672a66"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
#line 1 "C:\Users\Saulo\workspace\WebApplicationUnip2022\WebApplicationUnip2022\Views\_ViewImports.cshtml"
using WebApplicationUnip2022;

#line default
#line hidden
#line 2 "C:\Users\Saulo\workspace\WebApplicationUnip2022\WebApplicationUnip2022\Views\_ViewImports.cshtml"
using WebApplicationUnip2022.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdbf8fa6180d38ff9b3391401492cff7e1672a66", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89c83d45a358e75351086153240f00b4c76a617e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Saulo\workspace\WebApplicationUnip2022\WebApplicationUnip2022\Views\Home\About.cshtml"
  
    ViewData["Title"] = "Sobre os membros de nosso trabalho ";

#line default
#line hidden
            BeginContext(71, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(76, 17, false);
#line 4 "C:\Users\Saulo\workspace\WebApplicationUnip2022\WebApplicationUnip2022\Views\Home\About.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(93, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(105, 19, false);
#line 5 "C:\Users\Saulo\workspace\WebApplicationUnip2022\WebApplicationUnip2022\Views\Home\About.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(124, 495, true);
            WriteLiteral(@"</h3>

<p>Membros do grupo:</p>
<ol>
    
    <li><a href=""https://www.linkedin.com/in/jade-maria-467883164/"">Jade Maria</a></li>
    <li><a href=""https://www.linkedin.com/in/laryssa-p%C3%A9per-119502137/"">Laryssa Péper</a></li>
    <li><a href=""https://www.linkedin.com/in/saulo-vilela-barbosa-531902130/"">Saulo Vilela</a></li>
    <li><a href=""https://www.linkedin.com/in/thiagomaciel19/"">Thiago Eid</a></li>
    <li><a href=""https://github.com/Vinicius029"">Vinícius</a></li>
</ol>
");
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
