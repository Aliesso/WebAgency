#pragma checksum "D:\Compar\compar academy\ASP\K102AgencyWeb\K102AgencyWeb\Areas\K102Admin\Views\AdminSection1\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d0ca21c84f492a9a96993f5b265318ec05a51cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_K102Admin_Views_AdminSection1_Edit), @"mvc.1.0.view", @"/Areas/K102Admin/Views/AdminSection1/Edit.cshtml")]
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
#line 1 "D:\Compar\compar academy\ASP\K102AgencyWeb\K102AgencyWeb\Areas\K102Admin\Views\_ViewImports.cshtml"
using K102AgencyWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Compar\compar academy\ASP\K102AgencyWeb\K102AgencyWeb\Areas\K102Admin\Views\_ViewImports.cshtml"
using K102AgencyWeb.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Compar\compar academy\ASP\K102AgencyWeb\K102AgencyWeb\Areas\K102Admin\Views\_ViewImports.cshtml"
using K102AgencyWeb.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d0ca21c84f492a9a96993f5b265318ec05a51cd", @"/Areas/K102Admin/Views/AdminSection1/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d429e9255614e130797674b4aaf42eabab9ce8c", @"/Areas/K102Admin/Views/_ViewImports.cshtml")]
    public class Areas_K102Admin_Views_AdminSection1_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Section1>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<h3>");
#nullable restore
#line 7 "D:\Compar\compar academy\ASP\K102AgencyWeb\K102AgencyWeb\Areas\K102Admin\Views\AdminSection1\Edit.cshtml"
Write(Model.Header);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d0ca21c84f492a9a96993f5b265318ec05a51cd4513", async() => {
                WriteLiteral("\r\n    <div class=\"form-group\">\r\n        <label for=\"Header\">Header</label>\r\n        <input type=\"text\" name=\"Header\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 360, "\"", 381, 1);
#nullable restore
#line 12 "D:\Compar\compar academy\ASP\K102AgencyWeb\K102AgencyWeb\Areas\K102Admin\Views\AdminSection1\Edit.cshtml"
WriteAttributeValue("", 368, Model.Header, 368, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" id=\"Header\" placeholder=\"Header\">\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label for=\"SubHeader\">Sub Header</label>\r\n        <input type=\"text\" name=\"SubHeader\" class=\"form-control\"");
                BeginWriteAttribute("value", "  value=\"", 575, "\"", 600, 1);
#nullable restore
#line 16 "D:\Compar\compar academy\ASP\K102AgencyWeb\K102AgencyWeb\Areas\K102Admin\Views\AdminSection1\Edit.cshtml"
WriteAttributeValue("", 584, Model.SubHeader, 584, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" id=\"SubHeader\" placeholder=\"Sub Header\">\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label for=\"WorkArea\">Work Area</label>\r\n        <input type=\"text\" name=\"WorkArea\" class=\"form-control\" id=\"WorkArea\"");
                BeginWriteAttribute("value", "  value=\"", 812, "\"", 836, 1);
#nullable restore
#line 20 "D:\Compar\compar academy\ASP\K102AgencyWeb\K102AgencyWeb\Areas\K102Admin\Views\AdminSection1\Edit.cshtml"
WriteAttributeValue("", 821, Model.WorkArea, 821, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Work Area"">
    </div>
    <div class=""form-group"">
        <label for=""Photo"">Photo</label>
        <input type=""file"" name=""Photo"" class=""form-control"" id=""Photo"">
    </div>
    <button type=""submit"" class=""btn btn-primary"">Submit</button>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Section1> Html { get; private set; }
    }
}
#pragma warning restore 1591
