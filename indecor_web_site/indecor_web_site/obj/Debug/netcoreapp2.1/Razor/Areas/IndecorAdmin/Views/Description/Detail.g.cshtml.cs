#pragma checksum "C:\Users\Farid\Desktop\Final Project ASPNET CORE\indecor_web_site\indecor_web_site\Areas\IndecorAdmin\Views\Description\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b47289fffeb8ab87c3a0bb6c466fd3cd307ba6d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_IndecorAdmin_Views_Description_Detail), @"mvc.1.0.view", @"/Areas/IndecorAdmin/Views/Description/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/IndecorAdmin/Views/Description/Detail.cshtml", typeof(AspNetCore.Areas_IndecorAdmin_Views_Description_Detail))]
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
#line 1 "C:\Users\Farid\Desktop\Final Project ASPNET CORE\indecor_web_site\indecor_web_site\Areas\IndecorAdmin\Views\_ViewImports.cshtml"
using indecor_web_site.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b47289fffeb8ab87c3a0bb6c466fd3cd307ba6d", @"/Areas/IndecorAdmin/Views/Description/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ea1841dc3941e25c812dcb2288ac972f11158f9", @"/Areas/IndecorAdmin/Views/_ViewImports.cshtml")]
    public class Areas_IndecorAdmin_Views_Description_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Description>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Farid\Desktop\Final Project ASPNET CORE\indecor_web_site\indecor_web_site\Areas\IndecorAdmin\Views\Description\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
            BeginContext(63, 104, true);
            WriteLiteral("\r\n<div class=\"container-fluid\">\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-12\">\r\n            <h3>");
            EndContext();
            BeginContext(168, 11, false);
#line 10 "C:\Users\Farid\Desktop\Final Project ASPNET CORE\indecor_web_site\indecor_web_site\Areas\IndecorAdmin\Views\Description\Detail.cshtml"
           Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(179, 22, true);
            WriteLiteral("</h3>\r\n            <p>");
            EndContext();
            BeginContext(202, 14, false);
#line 11 "C:\Users\Farid\Desktop\Final Project ASPNET CORE\indecor_web_site\indecor_web_site\Areas\IndecorAdmin\Views\Description\Detail.cshtml"
          Write(Model.Descript);

#line default
#line hidden
            EndContext();
            BeginContext(216, 102, true);
            WriteLiteral("</p>\r\n\r\n\r\n       </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-12\">\r\n            ");
            EndContext();
            BeginContext(318, 81, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b6d12a006aa41268ee09d0fe2773c76", async() => {
                BeginContext(341, 54, true);
                WriteLiteral("<i class=\" far fa-arrow-alt-circle-left\"></i>  Go Back");
                EndContext();
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
            EndContext();
            BeginContext(399, 40, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Description> Html { get; private set; }
    }
}
#pragma warning restore 1591
