#pragma checksum "D:\DOJO\CSharp\DojoDachi\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37b772272e54dc6e33ed509d8c4a4e663180bed3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "D:\DOJO\CSharp\DojoDachi\Views\_ViewImports.cshtml"
using DojoDachi;

#line default
#line hidden
#line 37 "D:\DOJO\CSharp\DojoDachi\Views\Home\Index.cshtml"
using DojoDachi.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37b772272e54dc6e33ed509d8c4a4e663180bed3", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bce70f5dafba3f05b5d94a87a662fc8c5511826", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Pet>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/pet.gif"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 37, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            EndContext();
            BeginContext(37, 741, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b6b2a73e4d824548aecc99565f817ee2", async() => {
                BeginContext(43, 728, true);
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">
    <title>Dojo Dachi Game</title>
    <style>
        body {
            width: 800px;
            margin: 0px auto;
        }

        ul,
        li {
            display: inline-block;
            padding: 5px;
            margin: 0px auto;
            margin-left: 32px;
        }

        #content {
            text-align: center;
            border: 1px solid rgb(48, 3, 3);
            width: 600px;
            height: 400px;
            ;
        }
        #content img{
            padding: 50px 30px;
        }
    </style>
");
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
            BeginContext(778, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(782, 754, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69cf04bb79ca4f4781ed29203b6760d5", async() => {
                BeginContext(788, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(819, 4, true);
                WriteLiteral("    ");
                EndContext();
                BeginContext(835, 51, true);
                WriteLiteral("    <div>\r\n        <ul>\r\n            <li>Fullness: ");
                EndContext();
                BeginContext(887, 16, false);
#line 41 "D:\DOJO\CSharp\DojoDachi\Views\Home\Index.cshtml"
                     Write(ViewBag.Fullness);

#line default
#line hidden
                EndContext();
                BeginContext(903, 34, true);
                WriteLiteral("</li>\r\n            <li>Happniess: ");
                EndContext();
                BeginContext(938, 17, false);
#line 42 "D:\DOJO\CSharp\DojoDachi\Views\Home\Index.cshtml"
                      Write(ViewBag.Happiness);

#line default
#line hidden
                EndContext();
                BeginContext(955, 30, true);
                WriteLiteral("</li>\r\n            <li>Meals: ");
                EndContext();
                BeginContext(986, 13, false);
#line 43 "D:\DOJO\CSharp\DojoDachi\Views\Home\Index.cshtml"
                  Write(ViewBag.Meals);

#line default
#line hidden
                EndContext();
                BeginContext(999, 31, true);
                WriteLiteral("</li>\r\n            <li>Energy: ");
                EndContext();
                BeginContext(1031, 14, false);
#line 44 "D:\DOJO\CSharp\DojoDachi\Views\Home\Index.cshtml"
                   Write(ViewBag.Energy);

#line default
#line hidden
                EndContext();
                BeginContext(1045, 66, true);
                WriteLiteral("</li>\r\n        </ul>\r\n    </div>\r\n    <div id=\"content\">\r\n        ");
                EndContext();
                BeginContext(1111, 28, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "eb05f8dfca8348c2aa09499eb25bd737", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1139, 17, true);
                WriteLiteral("<br>\r\n        <a>");
                EndContext();
                BeginContext(1157, 12, false);
#line 49 "D:\DOJO\CSharp\DojoDachi\Views\Home\Index.cshtml"
      Write(ViewBag.text);

#line default
#line hidden
                EndContext();
                BeginContext(1169, 28, true);
                WriteLiteral("</a>\r\n    </div>\r\n    <br>\r\n");
                EndContext();
#line 52 "D:\DOJO\CSharp\DojoDachi\Views\Home\Index.cshtml"
     if(@ViewBag.button != null){
        

#line default
#line hidden
                BeginContext(1241, 24, false);
#line 53 "D:\DOJO\CSharp\DojoDachi\Views\Home\Index.cshtml"
   Write(Html.Raw(ViewBag.button));

#line default
#line hidden
                EndContext();
#line 53 "D:\DOJO\CSharp\DojoDachi\Views\Home\Index.cshtml"
                                 
    }else{

#line default
#line hidden
                BeginContext(1279, 241, true);
                WriteLiteral("    <a href=\"/feed\"><button>Feed</button></a>\r\n    <a href=\"/play\"><button>Play</button></a>\r\n    <a href=\"/work\"><button>Work</button></a>\r\n    <a href=\"/sleep\"><button>Sleep</button></a>\r\n    <a href=\"/test\"><button>Test 100</button></a>\r\n");
                EndContext();
#line 60 "D:\DOJO\CSharp\DojoDachi\Views\Home\Index.cshtml"
    }

#line default
#line hidden
                BeginContext(1527, 2, true);
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
            BeginContext(1536, 11, true);
            WriteLiteral("\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pet> Html { get; private set; }
    }
}
#pragma warning restore 1591