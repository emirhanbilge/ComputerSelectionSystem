#pragma checksum "C:\Users\Ebb\Desktop\ComputerSelectionSENASONRADANYAPTI\ComputerSelection\Views\GPU\EditGPU.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b408e1d974a4d139a1f5703f2c55808ee0d575e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GPU_EditGPU), @"mvc.1.0.view", @"/Views/GPU/EditGPU.cshtml")]
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
#line 1 "C:\Users\Ebb\Desktop\ComputerSelectionSENASONRADANYAPTI\ComputerSelection\Views\_ViewImports.cshtml"
using ComputerSelection;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ebb\Desktop\ComputerSelectionSENASONRADANYAPTI\ComputerSelection\Views\_ViewImports.cshtml"
using ComputerSelection.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b408e1d974a4d139a1f5703f2c55808ee0d575e3", @"/Views/GPU/EditGPU.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3ec50d9d9922064009f375f53ee5581218d6006", @"/Views/_ViewImports.cshtml")]
    public class Views_GPU_EditGPU : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ComputerSelection.Models.GPUViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditGPU", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "GPU", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b408e1d974a4d139a1f5703f2c55808ee0d575e33924", async() => {
                WriteLiteral("\r\n        <div class=\"form-horizontal\">\r\n            <h4>GPU Information</h4>\r\n");
#nullable restore
#line 5 "C:\Users\Ebb\Desktop\ComputerSelectionSENASONRADANYAPTI\ComputerSelection\Views\GPU\EditGPU.cshtml"
             using (Html.BeginForm())
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Ebb\Desktop\ComputerSelectionSENASONRADANYAPTI\ComputerSelection\Views\GPU\EditGPU.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 10 "C:\Users\Ebb\Desktop\ComputerSelectionSENASONRADANYAPTI\ComputerSelection\Views\GPU\EditGPU.cshtml"
               Write(Html.LabelFor(model => model.Model, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <div class=\"col-md-10\">\r\n                        ");
#nullable restore
#line 12 "C:\Users\Ebb\Desktop\ComputerSelectionSENASONRADANYAPTI\ComputerSelection\Views\GPU\EditGPU.cshtml"
                   Write(Html.EditorFor(model => model.Model, new { htmlAttributes = new { @class = "form-control", @readonly = true } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 13 "C:\Users\Ebb\Desktop\ComputerSelectionSENASONRADANYAPTI\ComputerSelection\Views\GPU\EditGPU.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Model, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 17 "C:\Users\Ebb\Desktop\ComputerSelectionSENASONRADANYAPTI\ComputerSelection\Views\GPU\EditGPU.cshtml"
               Write(Html.LabelFor(model => model.Company, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <div class=\"col-md-10\">\r\n                        ");
#nullable restore
#line 19 "C:\Users\Ebb\Desktop\ComputerSelectionSENASONRADANYAPTI\ComputerSelection\Views\GPU\EditGPU.cshtml"
                   Write(Html.EditorFor(model => model.Company, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 20 "C:\Users\Ebb\Desktop\ComputerSelectionSENASONRADANYAPTI\ComputerSelection\Views\GPU\EditGPU.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Company, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 24 "C:\Users\Ebb\Desktop\ComputerSelectionSENASONRADANYAPTI\ComputerSelection\Views\GPU\EditGPU.cshtml"
               Write(Html.LabelFor(model => model.GPUChip, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <div class=\"col-md-10\">\r\n                        ");
#nullable restore
#line 26 "C:\Users\Ebb\Desktop\ComputerSelectionSENASONRADANYAPTI\ComputerSelection\Views\GPU\EditGPU.cshtml"
                   Write(Html.EditorFor(model => model.GPUChip, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 27 "C:\Users\Ebb\Desktop\ComputerSelectionSENASONRADANYAPTI\ComputerSelection\Views\GPU\EditGPU.cshtml"
                   Write(Html.ValidationMessageFor(model => model.GPUChip, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 31 "C:\Users\Ebb\Desktop\ComputerSelectionSENASONRADANYAPTI\ComputerSelection\Views\GPU\EditGPU.cshtml"
               Write(Html.LabelFor(model => model.Released, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <div class=\"col-md-10\">\r\n                        ");
#nullable restore
#line 33 "C:\Users\Ebb\Desktop\ComputerSelectionSENASONRADANYAPTI\ComputerSelection\Views\GPU\EditGPU.cshtml"
                   Write(Html.EditorFor(model => model.Released, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 34 "C:\Users\Ebb\Desktop\ComputerSelectionSENASONRADANYAPTI\ComputerSelection\Views\GPU\EditGPU.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Released, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 38 "C:\Users\Ebb\Desktop\ComputerSelectionSENASONRADANYAPTI\ComputerSelection\Views\GPU\EditGPU.cshtml"
               Write(Html.LabelFor(model => model.Bus, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <div class=\"col-md-10\">\r\n                        ");
#nullable restore
#line 40 "C:\Users\Ebb\Desktop\ComputerSelectionSENASONRADANYAPTI\ComputerSelection\Views\GPU\EditGPU.cshtml"
                   Write(Html.EditorFor(model => model.Bus, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 41 "C:\Users\Ebb\Desktop\ComputerSelectionSENASONRADANYAPTI\ComputerSelection\Views\GPU\EditGPU.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Bus, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 45 "C:\Users\Ebb\Desktop\ComputerSelectionSENASONRADANYAPTI\ComputerSelection\Views\GPU\EditGPU.cshtml"
               Write(Html.LabelFor(model => model.Memory, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <div class=\"col-md-10\">\r\n                        ");
#nullable restore
#line 47 "C:\Users\Ebb\Desktop\ComputerSelectionSENASONRADANYAPTI\ComputerSelection\Views\GPU\EditGPU.cshtml"
                   Write(Html.EditorFor(model => model.Memory, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 48 "C:\Users\Ebb\Desktop\ComputerSelectionSENASONRADANYAPTI\ComputerSelection\Views\GPU\EditGPU.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Memory, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 52 "C:\Users\Ebb\Desktop\ComputerSelectionSENASONRADANYAPTI\ComputerSelection\Views\GPU\EditGPU.cshtml"
               Write(Html.LabelFor(model => model.GPUclock, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <div class=\"col-md-10\">\r\n                        ");
#nullable restore
#line 54 "C:\Users\Ebb\Desktop\ComputerSelectionSENASONRADANYAPTI\ComputerSelection\Views\GPU\EditGPU.cshtml"
                   Write(Html.EditorFor(model => model.GPUclock, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 55 "C:\Users\Ebb\Desktop\ComputerSelectionSENASONRADANYAPTI\ComputerSelection\Views\GPU\EditGPU.cshtml"
                   Write(Html.ValidationMessageFor(model => model.GPUclock, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 59 "C:\Users\Ebb\Desktop\ComputerSelectionSENASONRADANYAPTI\ComputerSelection\Views\GPU\EditGPU.cshtml"
               Write(Html.LabelFor(model => model.Memoryclock, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <div class=\"col-md-10\">\r\n                        ");
#nullable restore
#line 61 "C:\Users\Ebb\Desktop\ComputerSelectionSENASONRADANYAPTI\ComputerSelection\Views\GPU\EditGPU.cshtml"
                   Write(Html.EditorFor(model => model.Memoryclock, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 62 "C:\Users\Ebb\Desktop\ComputerSelectionSENASONRADANYAPTI\ComputerSelection\Views\GPU\EditGPU.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Memoryclock, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 66 "C:\Users\Ebb\Desktop\ComputerSelectionSENASONRADANYAPTI\ComputerSelection\Views\GPU\EditGPU.cshtml"
               Write(Html.LabelFor(model => model.Shaders_TMUs_ROPs, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <div class=\"col-md-10\">\r\n                        ");
#nullable restore
#line 68 "C:\Users\Ebb\Desktop\ComputerSelectionSENASONRADANYAPTI\ComputerSelection\Views\GPU\EditGPU.cshtml"
                   Write(Html.EditorFor(model => model.Shaders_TMUs_ROPs, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 69 "C:\Users\Ebb\Desktop\ComputerSelectionSENASONRADANYAPTI\ComputerSelection\Views\GPU\EditGPU.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Shaders_TMUs_ROPs, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 73 "C:\Users\Ebb\Desktop\ComputerSelectionSENASONRADANYAPTI\ComputerSelection\Views\GPU\EditGPU.cshtml"
               Write(Html.LabelFor(model => model.PassmarkG3dMark, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <div class=\"col-md-10\">\r\n                        ");
#nullable restore
#line 75 "C:\Users\Ebb\Desktop\ComputerSelectionSENASONRADANYAPTI\ComputerSelection\Views\GPU\EditGPU.cshtml"
                   Write(Html.EditorFor(model => model.PassmarkG3dMark, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 76 "C:\Users\Ebb\Desktop\ComputerSelectionSENASONRADANYAPTI\ComputerSelection\Views\GPU\EditGPU.cshtml"
                   Write(Html.ValidationMessageFor(model => model.PassmarkG3dMark, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 80 "C:\Users\Ebb\Desktop\ComputerSelectionSENASONRADANYAPTI\ComputerSelection\Views\GPU\EditGPU.cshtml"
               Write(Html.LabelFor(model => model.Rank, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <div class=\"col-md-10\">\r\n                        ");
#nullable restore
#line 82 "C:\Users\Ebb\Desktop\ComputerSelectionSENASONRADANYAPTI\ComputerSelection\Views\GPU\EditGPU.cshtml"
                   Write(Html.EditorFor(model => model.Rank, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 83 "C:\Users\Ebb\Desktop\ComputerSelectionSENASONRADANYAPTI\ComputerSelection\Views\GPU\EditGPU.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Rank, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </div>
                </div>
                <div class=""form-group"">
                    <div class=""col-md-offset-2 col-md-10"">
                        <input type=""submit"" value=""Save"" class=""btn btn-default"" />
                    </div>
                </div>
");
#nullable restore
#line 91 "C:\Users\Ebb\Desktop\ComputerSelectionSENASONRADANYAPTI\ComputerSelection\Views\GPU\EditGPU.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div>\r\n                ");
#nullable restore
#line 93 "C:\Users\Ebb\Desktop\ComputerSelectionSENASONRADANYAPTI\ComputerSelection\Views\GPU\EditGPU.cshtml"
           Write(Html.ActionLink("Back to List", "GPUList"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <br /><br />\r\n            <br /><br />\r\n            <br /><br />\r\n            <br /><br />\r\n            <br />\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ComputerSelection.Models.GPUViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
