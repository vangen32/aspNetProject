#pragma checksum "D:\WebApplication1\Views\Shared\MetatagsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e9198b4c440cfb08a15ac164b7829bac6040133"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_MetatagsPartial), @"mvc.1.0.view", @"/Views/Shared/MetatagsPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/MetatagsPartial.cshtml", typeof(AspNetCore.Views_Shared_MetatagsPartial))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e9198b4c440cfb08a15ac164b7829bac6040133", @"/Views/Shared/MetatagsPartial.cshtml")]
    public class Views_Shared_MetatagsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 116, true);
            WriteLiteral("<meta charset=\"utf-8\" />\r\n<meta name=\"viewport\" content=\"width=device-width, initial-scale=1, user-scalable=no\" />\r\n");
            EndContext();
#line 3 "D:\WebApplication1\Views\Shared\MetatagsPartial.cshtml"
 if (ViewBag != null)
{

#line default
#line hidden
            BeginContext(142, 11, true);
            WriteLiteral("    <title>");
            EndContext();
            BeginContext(154, 13, false);
#line 5 "D:\WebApplication1\Views\Shared\MetatagsPartial.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(167, 10, true);
            WriteLiteral("</title>\r\n");
            EndContext();
#line 6 "D:\WebApplication1\Views\Shared\MetatagsPartial.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(189, 33, true);
            WriteLiteral("    <title>?????? ????????????????</title>\r\n");
            EndContext();
#line 10 "D:\WebApplication1\Views\Shared\MetatagsPartial.cshtml"
}

#line default
#line hidden
#line 11 "D:\WebApplication1\Views\Shared\MetatagsPartial.cshtml"
 if (ViewBag.Discription != null)
{

#line default
#line hidden
            BeginContext(263, 28, true);
            WriteLiteral("    <meta name=\"description\"");
            EndContext();
            BeginWriteAttribute("content", " content=\"", 291, "\"", 321, 1);
#line 13 "D:\WebApplication1\Views\Shared\MetatagsPartial.cshtml"
WriteAttributeValue("", 301, ViewBag.Discription, 301, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(322, 4, true);
            WriteLiteral("/>\r\n");
            EndContext();
#line 14 "D:\WebApplication1\Views\Shared\MetatagsPartial.cshtml"
}

#line default
#line hidden
#line 15 "D:\WebApplication1\Views\Shared\MetatagsPartial.cshtml"
 if (ViewBag.Keywords != null)
{

#line default
#line hidden
            BeginContext(364, 25, true);
            WriteLiteral("    <meta name=\"keywords\"");
            EndContext();
            BeginWriteAttribute("content", " content=\"", 389, "\"", 416, 1);
#line 17 "D:\WebApplication1\Views\Shared\MetatagsPartial.cshtml"
WriteAttributeValue("", 399, ViewBag.Keywords, 399, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(417, 4, true);
            WriteLiteral("/>\r\n");
            EndContext();
#line 18 "D:\WebApplication1\Views\Shared\MetatagsPartial.cshtml"
}

#line default
#line hidden
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
