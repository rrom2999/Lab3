#pragma checksum "C:\Users\Ronal\Desktop\Lab3\Lab3\Views\ArbolBinario\Rellenar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "743c46d48e2e587e6305bcd99c0143d254912a91"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ArbolBinario_Rellenar), @"mvc.1.0.view", @"/Views/ArbolBinario/Rellenar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ArbolBinario/Rellenar.cshtml", typeof(AspNetCore.Views_ArbolBinario_Rellenar))]
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
#line 1 "C:\Users\Ronal\Desktop\Lab3\Lab3\Views\_ViewImports.cshtml"
using Lab3;

#line default
#line hidden
#line 2 "C:\Users\Ronal\Desktop\Lab3\Lab3\Views\_ViewImports.cshtml"
using Lab3.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"743c46d48e2e587e6305bcd99c0143d254912a91", @"/Views/ArbolBinario/Rellenar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3ab7d75fe2e0e76f78a01f25c0020ed6eca01b6", @"/Views/_ViewImports.cshtml")]
    public class Views_ArbolBinario_Rellenar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Lab3.Entities.FarmacoEntity>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Actualizar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(48, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\Ronal\Desktop\Lab3\Lab3\Views\ArbolBinario\Rellenar.cshtml"
  
    ViewData["Title"] = "Rellenar";

#line default
#line hidden
            BeginContext(90, 28, true);
            WriteLiteral("\n<h2>Rellenar</h2>\n\n<p>\n    ");
            EndContext();
            BeginContext(118, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "557f2c55433e4a51bffb0db7f24c1fbb", async() => {
                BeginContext(145, 18, true);
                WriteLiteral("Rellenar productos");
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
            BeginContext(167, 86, true);
            WriteLiteral("\n</p>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
            EndContext();
            BeginContext(254, 42, false);
#line 16 "C:\Users\Ronal\Desktop\Lab3\Lab3\Views\ArbolBinario\Rellenar.cshtml"
           Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(296, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(349, 47, false);
#line 19 "C:\Users\Ronal\Desktop\Lab3\Lab3\Views\ArbolBinario\Rellenar.cshtml"
           Write(Html.DisplayNameFor(model => model.Descripcion));

#line default
#line hidden
            EndContext();
            BeginContext(396, 119, true);
            WriteLiteral("\n            </th>\n            <th>\n                Casa productora\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(516, 42, false);
#line 25 "C:\Users\Ronal\Desktop\Lab3\Lab3\Views\ArbolBinario\Rellenar.cshtml"
           Write(Html.DisplayNameFor(model => model.Precio));

#line default
#line hidden
            EndContext();
            BeginContext(558, 56, true);
            WriteLiteral(" ($)\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(615, 46, false);
#line 28 "C:\Users\Ronal\Desktop\Lab3\Lab3\Views\ArbolBinario\Rellenar.cshtml"
           Write(Html.DisplayNameFor(model => model.Existencia));

#line default
#line hidden
            EndContext();
            BeginContext(661, 80, true);
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
            EndContext();
#line 34 "C:\Users\Ronal\Desktop\Lab3\Lab3\Views\ArbolBinario\Rellenar.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(772, 46, true);
            WriteLiteral("        <tr>\n            <td>\n                ");
            EndContext();
            BeginContext(819, 41, false);
#line 37 "C:\Users\Ronal\Desktop\Lab3\Lab3\Views\ArbolBinario\Rellenar.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(860, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(913, 46, false);
#line 40 "C:\Users\Ronal\Desktop\Lab3\Lab3\Views\ArbolBinario\Rellenar.cshtml"
           Write(Html.DisplayFor(modelItem => item.Descripcion));

#line default
#line hidden
            EndContext();
            BeginContext(959, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1012, 49, false);
#line 43 "C:\Users\Ronal\Desktop\Lab3\Lab3\Views\ArbolBinario\Rellenar.cshtml"
           Write(Html.DisplayFor(modelItem => item.CasaProductora));

#line default
#line hidden
            EndContext();
            BeginContext(1061, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1114, 41, false);
#line 46 "C:\Users\Ronal\Desktop\Lab3\Lab3\Views\ArbolBinario\Rellenar.cshtml"
           Write(Html.DisplayFor(modelItem => item.Precio));

#line default
#line hidden
            EndContext();
            BeginContext(1155, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1208, 45, false);
#line 49 "C:\Users\Ronal\Desktop\Lab3\Lab3\Views\ArbolBinario\Rellenar.cshtml"
           Write(Html.DisplayFor(modelItem => item.Existencia));

#line default
#line hidden
            EndContext();
            BeginContext(1253, 46, true);
            WriteLiteral("\n            </td>\n            \n        </tr>\n");
            EndContext();
#line 53 "C:\Users\Ronal\Desktop\Lab3\Lab3\Views\ArbolBinario\Rellenar.cshtml"
}

#line default
#line hidden
            BeginContext(1301, 22, true);
            WriteLiteral("    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Lab3.Entities.FarmacoEntity>> Html { get; private set; }
    }
}
#pragma warning restore 1591
