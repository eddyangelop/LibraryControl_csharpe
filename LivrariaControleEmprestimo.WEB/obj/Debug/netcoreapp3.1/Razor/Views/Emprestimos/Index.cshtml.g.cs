#pragma checksum "C:\Users\edson\Downloads\Documents\Dotnet\LibraryControl_csharpe\LivrariaControleEmprestimo.WEB\Views\Emprestimos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ade1e940809894fc73b8424fea785691d49eef2d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Emprestimos_Index), @"mvc.1.0.view", @"/Views/Emprestimos/Index.cshtml")]
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
#line 1 "C:\Users\edson\Downloads\Documents\Dotnet\LibraryControl_csharpe\LivrariaControleEmprestimo.WEB\Views\_ViewImports.cshtml"
using LivrariaControleEmprestimo.WEB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\edson\Downloads\Documents\Dotnet\LibraryControl_csharpe\LivrariaControleEmprestimo.WEB\Views\_ViewImports.cshtml"
using LivrariaControleEmprestimo.WEB.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ade1e940809894fc73b8424fea785691d49eef2d", @"/Views/Emprestimos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58927f7e280d4bc1168352282f8c07094813292c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Emprestimos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LivrariaControleEmprestimo.DATA.Models.VwLivroClienteEmprestimo>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(" btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success m-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary  m-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger  m-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\edson\Downloads\Documents\Dotnet\LibraryControl_csharpe\LivrariaControleEmprestimo.WEB\Views\Emprestimos\Index.cshtml"
  
    ViewData["Title"] = "Emprestimos";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Emprestimos</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ade1e940809894fc73b8424fea785691d49eef2d6339", async() => {
                WriteLiteral("Novo emprestimo");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table id=\"myTable\" class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\edson\Downloads\Documents\Dotnet\LibraryControl_csharpe\LivrariaControleEmprestimo.WEB\Views\Emprestimos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CliCpf));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\edson\Downloads\Documents\Dotnet\LibraryControl_csharpe\LivrariaControleEmprestimo.WEB\Views\Emprestimos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CliNome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\edson\Downloads\Documents\Dotnet\LibraryControl_csharpe\LivrariaControleEmprestimo.WEB\Views\Emprestimos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LivroNome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\edson\Downloads\Documents\Dotnet\LibraryControl_csharpe\LivrariaControleEmprestimo.WEB\Views\Emprestimos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LceDataEmprestimo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\edson\Downloads\Documents\Dotnet\LibraryControl_csharpe\LivrariaControleEmprestimo.WEB\Views\Emprestimos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LceDataEntrega));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\edson\Downloads\Documents\Dotnet\LibraryControl_csharpe\LivrariaControleEmprestimo.WEB\Views\Emprestimos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LceEntregue));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 37 "C:\Users\edson\Downloads\Documents\Dotnet\LibraryControl_csharpe\LivrariaControleEmprestimo.WEB\Views\Emprestimos\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\edson\Downloads\Documents\Dotnet\LibraryControl_csharpe\LivrariaControleEmprestimo.WEB\Views\Emprestimos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CliCpf));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\edson\Downloads\Documents\Dotnet\LibraryControl_csharpe\LivrariaControleEmprestimo.WEB\Views\Emprestimos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CliNome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\edson\Downloads\Documents\Dotnet\LibraryControl_csharpe\LivrariaControleEmprestimo.WEB\Views\Emprestimos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LivroNome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\edson\Downloads\Documents\Dotnet\LibraryControl_csharpe\LivrariaControleEmprestimo.WEB\Views\Emprestimos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LceDataEmprestimo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\Users\edson\Downloads\Documents\Dotnet\LibraryControl_csharpe\LivrariaControleEmprestimo.WEB\Views\Emprestimos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LceDataEntrega));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "C:\Users\edson\Downloads\Documents\Dotnet\LibraryControl_csharpe\LivrariaControleEmprestimo.WEB\Views\Emprestimos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LceEntregue));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n                <td class=\"row\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ade1e940809894fc73b8424fea785691d49eef2d12491", async() => {
                WriteLiteral("Alterar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 58 "C:\Users\edson\Downloads\Documents\Dotnet\LibraryControl_csharpe\LivrariaControleEmprestimo.WEB\Views\Emprestimos\Index.cshtml"
                                                                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ade1e940809894fc73b8424fea785691d49eef2d14824", async() => {
                WriteLiteral("Detalhes");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 59 "C:\Users\edson\Downloads\Documents\Dotnet\LibraryControl_csharpe\LivrariaControleEmprestimo.WEB\Views\Emprestimos\Index.cshtml"
                                                                           WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n                    <!-- Button trigger modal -->\r\n                    <button type=\"button\" class=\"btn btn-danger m-1\" data-toggle=\"modal\" data-target=\"#DeleteModal-");
#nullable restore
#line 63 "C:\Users\edson\Downloads\Documents\Dotnet\LibraryControl_csharpe\LivrariaControleEmprestimo.WEB\Views\Emprestimos\Index.cshtml"
                                                                                                              Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                        Excluir\r\n                    </button>\r\n\r\n                    <!-- Modal -->\r\n                    <div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 2222, "\"", 2247, 2);
            WriteAttributeValue("", 2227, "DeleteModal-", 2227, 12, true);
#nullable restore
#line 68 "C:\Users\edson\Downloads\Documents\Dotnet\LibraryControl_csharpe\LivrariaControleEmprestimo.WEB\Views\Emprestimos\Index.cshtml"
WriteAttributeValue("", 2239, item.Id, 2239, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""DeleteModalLabel"" aria-hidden=""true"">
                        <div class=""modal-dialog"" role=""document"">
                            <div class=""modal-content"">
                                <div class=""modal-header"">
                                    <h5 class=""modal-title"" id=""DeleteModalLabel"">Excluir cliente</h5>
                                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                        <span aria-hidden=""true"">&times;</span>
                                    </button>
                                </div>
                                <div class=""modal-body"">
                                    Deseja realmente excluir o emprestimo ");
#nullable restore
#line 78 "C:\Users\edson\Downloads\Documents\Dotnet\LibraryControl_csharpe\LivrariaControleEmprestimo.WEB\Views\Emprestimos\Index.cshtml"
                                                                     Write(item.CliNome);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" ?
                                </div>
                                <div class=""modal-footer"">
                                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Não</button>
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ade1e940809894fc73b8424fea785691d49eef2d19749", async() => {
                WriteLiteral("Sim");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 82 "C:\Users\edson\Downloads\Documents\Dotnet\LibraryControl_csharpe\LivrariaControleEmprestimo.WEB\Views\Emprestimos\Index.cshtml"
                                                                                         WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n\r\n                </td>\r\n        </tr>\r\n");
#nullable restore
#line 90 "C:\Users\edson\Downloads\Documents\Dotnet\LibraryControl_csharpe\LivrariaControleEmprestimo.WEB\Views\Emprestimos\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $('#myTable').DataTable({
                ""language"": {
                    ""url"": ""//cdn.datatables.net/plug-ins/9dcbecd42ad/i18n/Portuguese-Brasil.json""
                }
            });
        });
    </script>
");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LivrariaControleEmprestimo.DATA.Models.VwLivroClienteEmprestimo>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
