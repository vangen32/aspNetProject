#pragma checksum "D:\WebApplication1\Views\Shared\_Layaout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f5c76fb71aaea89270969fbb6ddb47fda15cf33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layaout), @"mvc.1.0.view", @"/Views/Shared/_Layaout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layaout.cshtml", typeof(AspNetCore.Views_Shared__Layaout))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f5c76fb71aaea89270969fbb6ddb47fda15cf33", @"/Views/Shared/_Layaout.cshtml")]
    public class Views_Shared__Layaout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 25, true);
            WriteLiteral("<!DOCTYPE HTML>\r\n<html>\r\n");
            EndContext();
            BeginContext(25, 106, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f5c76fb71aaea89270969fbb6ddb47fda15cf332887", async() => {
                BeginContext(31, 5, true);
                WriteLiteral("\r\n   ");
                EndContext();
                BeginContext(37, 42, false);
#line 4 "D:\WebApplication1\Views\Shared\_Layaout.cshtml"
Write(await Html.PartialAsync("MetatagsPartial"));

#line default
#line hidden
                EndContext();
                BeginContext(79, 5, true);
                WriteLiteral("\r\n   ");
                EndContext();
                BeginContext(85, 37, false);
#line 5 "D:\WebApplication1\Views\Shared\_Layaout.cshtml"
Write(await Html.PartialAsync("CssPartial"));

#line default
#line hidden
                EndContext();
                BeginContext(122, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(131, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(133, 516, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f5c76fb71aaea89270969fbb6ddb47fda15cf334735", async() => {
                BeginContext(139, 39, true);
                WriteLiteral("\r\n    <div id=\"page-wrapper\">\r\n        ");
                EndContext();
                BeginContext(179, 40, false);
#line 9 "D:\WebApplication1\Views\Shared\_Layaout.cshtml"
   Write(await Html.PartialAsync("HeaderPartial"));

#line default
#line hidden
                EndContext();
                BeginContext(219, 212, true);
                WriteLiteral("\r\n\r\n        <!-- Main -->\r\n        <div id=\"main\">\r\n            <div class=\"container\">\r\n                <div class=\"row main-row\">\r\n                    <div class=\"col-4 col-12-medium\">\r\n                        ");
                EndContext();
                BeginContext(432, 12, false);
#line 16 "D:\WebApplication1\Views\Shared\_Layaout.cshtml"
                   Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(444, 96, true);
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n      ");
                EndContext();
                BeginContext(541, 40, false);
#line 21 "D:\WebApplication1\Views\Shared\_Layaout.cshtml"
 Write(await Html.PartialAsync("FooterPartial"));

#line default
#line hidden
                EndContext();
                BeginContext(581, 18, true);
                WriteLiteral("\r\n    </div>\r\n    ");
                EndContext();
                BeginContext(600, 40, false);
#line 23 "D:\WebApplication1\Views\Shared\_Layaout.cshtml"
Write(await Html.PartialAsync("ScriptPartial"));

#line default
#line hidden
                EndContext();
                BeginContext(640, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(649, 9, true);
            WriteLiteral("\r\n</html>");
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
