#pragma checksum "C:\Users\Neolabs\source\repos\FinalExamWork\FinalExamWork\Views\Shop\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55ebdd5071bcb51de14823211c9a78a220764aa7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Index), @"mvc.1.0.view", @"/Views/Shop/Index.cshtml")]
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
#line 1 "C:\Users\Neolabs\source\repos\FinalExamWork\FinalExamWork\Views\_ViewImports.cshtml"
using FinalExamWork;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Neolabs\source\repos\FinalExamWork\FinalExamWork\Views\_ViewImports.cshtml"
using FinalExamWork.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Neolabs\source\repos\FinalExamWork\FinalExamWork\Views\Shop\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55ebdd5071bcb51de14823211c9a78a220764aa7", @"/Views/Shop/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"726f556da5a71c1fdeddae4e77e74dacb7bfa5ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IndexPaginatorModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Neolabs\source\repos\FinalExamWork\FinalExamWork\Views\Shop\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Основная страница</h1>\r\n");
#nullable restore
#line 11 "C:\Users\Neolabs\source\repos\FinalExamWork\FinalExamWork\Views\Shop\Index.cshtml"
 if (SignInManager.IsSignedIn(User))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55ebdd5071bcb51de14823211c9a78a220764aa74979", async() => {
                WriteLiteral("Добавить новое заведение");
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
            WriteLiteral("\r\n</p>\r\n");
#nullable restore
#line 16 "C:\Users\Neolabs\source\repos\FinalExamWork\FinalExamWork\Views\Shop\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55ebdd5071bcb51de14823211c9a78a220764aa76326", async() => {
                WriteLiteral("\r\n    <div class=\"form-inline form-group\">\r\n        <label class=\"control-label\">Имя: </label>\r\n        <input name=\"name\" class=\"form-control\" />\r\n\r\n        <input type=\"submit\" value=\"Фильтр\" class=\"btn btn-default\" />\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<div class=\"row\">\r\n");
#nullable restore
#line 26 "C:\Users\Neolabs\source\repos\FinalExamWork\FinalExamWork\Views\Shop\Index.cshtml"
      
        int Count = 0;
        foreach (var item in Model.Models)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card col-3\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 828, "\"", 887, 1);
#nullable restore
#line 31 "C:\Users\Neolabs\source\repos\FinalExamWork\FinalExamWork\Views\Shop\Index.cshtml"
WriteAttributeValue("", 835, Url.Action("Details", "Shop", new { Id = item.Id }), 835, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 936, "\"", 1002, 2);
            WriteAttributeValue("", 942, "data:image/jpeg;base64,", 942, 23, true);
#nullable restore
#line 32 "C:\Users\Neolabs\source\repos\FinalExamWork\FinalExamWork\Views\Shop\Index.cshtml"
WriteAttributeValue("", 965, Convert.ToBase64String(item.Image), 965, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\">\r\n                </a>\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title\"><a");
            BeginWriteAttribute("href", " href=\"", 1135, "\"", 1194, 1);
#nullable restore
#line 35 "C:\Users\Neolabs\source\repos\FinalExamWork\FinalExamWork\Views\Shop\Index.cshtml"
WriteAttributeValue("", 1142, Url.Action("Details", "Shop", new { Id = item.Id }), 1142, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Наименование: ");
#nullable restore
#line 35 "C:\Users\Neolabs\source\repos\FinalExamWork\FinalExamWork\Views\Shop\Index.cshtml"
                                                                                                                    Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h5>\r\n                    <h5 class=\"card-title\">Автор: ");
#nullable restore
#line 36 "C:\Users\Neolabs\source\repos\FinalExamWork\FinalExamWork\Views\Shop\Index.cshtml"
                                              Write(item.UserLogin);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <h5 class=\"card-title\">Количество отзывов: ");
#nullable restore
#line 37 "C:\Users\Neolabs\source\repos\FinalExamWork\FinalExamWork\Views\Shop\Index.cshtml"
                                                           Write(item.CommentsCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <h5 class=\"card-title\">Рейтинг: ");
#nullable restore
#line 38 "C:\Users\Neolabs\source\repos\FinalExamWork\FinalExamWork\Views\Shop\Index.cshtml"
                                                Write(item.Raiting);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 41 "C:\Users\Neolabs\source\repos\FinalExamWork\FinalExamWork\Views\Shop\Index.cshtml"

        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 45 "C:\Users\Neolabs\source\repos\FinalExamWork\FinalExamWork\Views\Shop\Index.cshtml"
Write(Html.ActionLink("Назад", "Index", "Shop", new { Left = true, Page = Model.Page}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 46 "C:\Users\Neolabs\source\repos\FinalExamWork\FinalExamWork\Views\Shop\Index.cshtml"
Write(Html.ActionLink("Вперед", "Index", "Shop", new { Right = true, Page = Model.Page}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<FinalExamWork.DAL.Entites.User> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<FinalExamWork.DAL.Entites.User> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexPaginatorModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
