#pragma checksum "C:\Code\GuessWho\Pages\Shared\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d10c38fd6cf029fff250fa626627e2c46f12fa9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(GuessWho.Pages.Shared.Pages_Shared_Index), @"mvc.1.0.view", @"/Pages/Shared/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Pages/Shared/Index.cshtml", typeof(GuessWho.Pages.Shared.Pages_Shared_Index))]
namespace GuessWho.Pages.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Code\GuessWho\Pages\_ViewImports.cshtml"
using GuessWho;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d10c38fd6cf029fff250fa626627e2c46f12fa9", @"/Pages/Shared/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3728c1cf617364dd993d589ab129753e71d7ed4a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IndexModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PictureUpload", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Code\GuessWho\Pages\Shared\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
            BeginContext(64, 1397, true);
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Welcome To<br /> Azure Guess Who</h1>
    <p>Can Azure Cognitive Service: Vision guess the right person?</p>
</div>
<div class=""container"">
    <div class=""row"">
        <div class=""col-sm"">
            <h4>Ellinor Lorraine</h4>
            <ul>
                <li>Name: Ellinor</li>
                <li>Birthdate: 02/24/2011</li>
            </ul>
            <img src=""https://bike.shimano.com/content/dam/productsite/shimano-europe/img/square-banner/RIDING_STYLE/MTB-Enduro-Discipline-Icon.jpg"" />
        </div>
        <div class=""col-sm"">
            <h4>Emrey Rae</h4>
            <ul>
                <li>Name: Ellinor</li>
                <li>Birthdate: 02/24/2011</li>
            </ul>
            <img src=""https://bike.shimano.com/content/dam/productsite/shimano-europe/img/square-banner/RIDING_STYLE/MTB-Enduro-Discipline-Icon.jpg"" />
        </div>
        <div class=""col-sm"">
            <h4>Quinton Paul</h4>
            <ul>
");
            WriteLiteral(@"                <li>Name: Ellinor</li>
                <li>Birthdate: 02/24/2011</li>
            </ul>
            <img src=""https://bike.shimano.com/content/dam/productsite/shimano-europe/img/square-banner/RIDING_STYLE/MTB-Enduro-Discipline-Icon.jpg"" />
        </div>
    </div>
    <div class=""row"">
        <div class=""col-sm"">
            <hr />
            ");
            EndContext();
            BeginContext(1461, 571, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d10c38fd6cf029fff250fa626627e2c46f12fa95992", async() => {
                BeginContext(1560, 465, true);
                WriteLiteral(@"
                <div class=""form-group"">
                    <div class=""col-md-10"">
                        <p>Upload A Picture:</p>
                        <input type=""file"" name=""file"" />
                    </div>
                </div>
                <div class=""form-group"">
                    <div class=""col-md-10"">
                        <input type=""submit"" value=""Upload"" />
                    </div>
                </div>
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2032, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 54 "C:\Code\GuessWho\Pages\Shared\Index.cshtml"
         if (Model.FileUploaded)
        {

#line default
#line hidden
            BeginContext(2095, 31, true);
            WriteLiteral("            <h1>Uplaoded</h1>\r\n");
            EndContext();
#line 57 "C:\Code\GuessWho\Pages\Shared\Index.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(2162, 27, true);
            WriteLiteral("            <h2>nope</h2>\r\n");
            EndContext();
#line 61 "C:\Code\GuessWho\Pages\Shared\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2200, 20, true);
            WriteLiteral("    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
