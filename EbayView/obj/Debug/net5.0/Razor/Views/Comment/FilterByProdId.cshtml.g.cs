#pragma checksum "D:\.net\1-learn\4- Projects\1-iti e_commerce project\EbayAdminSideWebSite\EbayView\Views\Comment\FilterByProdId.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "989475f1704d61906b11acc8b684569d5f8aa9e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(EbayView.Views.Comment.Views_Comment_FilterByProdId), @"mvc.1.0.view", @"/Views/Comment/FilterByProdId.cshtml")]
namespace EbayView.Views.Comment
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
#line 2 "D:\.net\1-learn\4- Projects\1-iti e_commerce project\EbayAdminSideWebSite\EbayView\Views\_ViewImports.cshtml"
using EbayView;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\.net\1-learn\4- Projects\1-iti e_commerce project\EbayAdminSideWebSite\EbayView\Views\_ViewImports.cshtml"
using EbayView.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"989475f1704d61906b11acc8b684569d5f8aa9e6", @"/Views/Comment/FilterByProdId.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"888fc3c05d16ba269ab96bfefaac907c93321ff4", @"/Views/_ViewImports.cshtml")]
    public class Views_Comment_FilterByProdId : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EbayView.Models.ViewModel.Comments.GetCommentOutputModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<h1 style=\"width:100%;text-align:center;display:block;margin:10px auto;\">\r\n    View All Comment and Filter By Product   <span class=\"btn-danger\">");
#nullable restore
#line 4 "D:\.net\1-learn\4- Projects\1-iti e_commerce project\EbayAdminSideWebSite\EbayView\Views\Comment\FilterByProdId.cshtml"
                                                                 Write(ViewBag.SelectedProdName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n</h1>\r\n \r\n<table class=\"table table-striped table-bordered table-hover\">\r\n    <thead class=\"thead-dark\">\r\n         <tr>\r\n            <th>#</th>\r\n            <th>\r\n                ");
#nullable restore
#line 12 "D:\.net\1-learn\4- Projects\1-iti e_commerce project\EbayAdminSideWebSite\EbayView\Views\Comment\FilterByProdId.cshtml"
           Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th> \r\n");
            WriteLiteral("            <th>\r\n                ");
#nullable restore
#line 18 "D:\.net\1-learn\4- Projects\1-iti e_commerce project\EbayAdminSideWebSite\EbayView\Views\Comment\FilterByProdId.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "D:\.net\1-learn\4- Projects\1-iti e_commerce project\EbayAdminSideWebSite\EbayView\Views\Comment\FilterByProdId.cshtml"
           Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th> \r\n            <th>\r\n                Delete\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 29 "D:\.net\1-learn\4- Projects\1-iti e_commerce project\EbayAdminSideWebSite\EbayView\Views\Comment\FilterByProdId.cshtml"
            int i = 1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "D:\.net\1-learn\4- Projects\1-iti e_commerce project\EbayAdminSideWebSite\EbayView\Views\Comment\FilterByProdId.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 32 "D:\.net\1-learn\4- Projects\1-iti e_commerce project\EbayAdminSideWebSite\EbayView\Views\Comment\FilterByProdId.cshtml"
           Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \r\n            <td>\r\n                ");
#nullable restore
#line 34 "D:\.net\1-learn\4- Projects\1-iti e_commerce project\EbayAdminSideWebSite\EbayView\Views\Comment\FilterByProdId.cshtml"
           Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "D:\.net\1-learn\4- Projects\1-iti e_commerce project\EbayAdminSideWebSite\EbayView\Views\Comment\FilterByProdId.cshtml"
           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "D:\.net\1-learn\4- Projects\1-iti e_commerce project\EbayAdminSideWebSite\EbayView\Views\Comment\FilterByProdId.cshtml"
           Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            \r\n            <td> \r\n                ");
#nullable restore
#line 44 "D:\.net\1-learn\4- Projects\1-iti e_commerce project\EbayAdminSideWebSite\EbayView\Views\Comment\FilterByProdId.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { UserId=item.UserId,  ProdId=item.ProductId },new {@class="btn btn-primary"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n");
#nullable restore
#line 46 "D:\.net\1-learn\4- Projects\1-iti e_commerce project\EbayAdminSideWebSite\EbayView\Views\Comment\FilterByProdId.cshtml"
                    i++;

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n");
#nullable restore
#line 48 "D:\.net\1-learn\4- Projects\1-iti e_commerce project\EbayAdminSideWebSite\EbayView\Views\Comment\FilterByProdId.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<div class=\"w-100 text-center\">\r\n\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "989475f1704d61906b11acc8b684569d5f8aa9e68687", async() => {
                WriteLiteral("Back to List To View All Comment");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EbayView.Models.ViewModel.Comments.GetCommentOutputModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
