#pragma checksum "D:\.net\1-learn\4- Projects\3-iti e_commerce project .net5(mvc core) vs19\EbayAdminSideWebSite\EbayAdminSideWebSite my github\EbayView\Views\Comment\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af4dfd69392708b9789befee4ded7267ce01f602"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(EbayView.Views.Comment.Views_Comment_Index), @"mvc.1.0.view", @"/Views/Comment/Index.cshtml")]
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
#line 2 "D:\.net\1-learn\4- Projects\3-iti e_commerce project .net5(mvc core) vs19\EbayAdminSideWebSite\EbayAdminSideWebSite my github\EbayView\Views\_ViewImports.cshtml"
using EbayView;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\.net\1-learn\4- Projects\3-iti e_commerce project .net5(mvc core) vs19\EbayAdminSideWebSite\EbayAdminSideWebSite my github\EbayView\Views\_ViewImports.cshtml"
using EbayView.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af4dfd69392708b9789befee4ded7267ce01f602", @"/Views/Comment/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"888fc3c05d16ba269ab96bfefaac907c93321ff4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Comment_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EbayView.Models.ViewModel.Comments.GetCommentOutputModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h1 style=""width:100%;text-align:center;display:block;margin:10px auto;"">View All Comment </h1>
 
<table class=""table table-striped table-bordered table-hover"">
    <thead class=""thead-dark"">
        <tr>
            <th>#</th>
            <th>
                ");
#nullable restore
#line 10 "D:\.net\1-learn\4- Projects\3-iti e_commerce project .net5(mvc core) vs19\EbayAdminSideWebSite\EbayAdminSideWebSite my github\EbayView\Views\Comment\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "D:\.net\1-learn\4- Projects\3-iti e_commerce project .net5(mvc core) vs19\EbayAdminSideWebSite\EbayAdminSideWebSite my github\EbayView\Views\Comment\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "D:\.net\1-learn\4- Projects\3-iti e_commerce project .net5(mvc core) vs19\EbayAdminSideWebSite\EbayAdminSideWebSite my github\EbayView\Views\Comment\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "D:\.net\1-learn\4- Projects\3-iti e_commerce project .net5(mvc core) vs19\EbayAdminSideWebSite\EbayAdminSideWebSite my github\EbayView\Views\Comment\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th> \r\n            <th>\r\n                Delete\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 27 "D:\.net\1-learn\4- Projects\3-iti e_commerce project .net5(mvc core) vs19\EbayAdminSideWebSite\EbayAdminSideWebSite my github\EbayView\Views\Comment\Index.cshtml"
            int i = 1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "D:\.net\1-learn\4- Projects\3-iti e_commerce project .net5(mvc core) vs19\EbayAdminSideWebSite\EbayAdminSideWebSite my github\EbayView\Views\Comment\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 30 "D:\.net\1-learn\4- Projects\3-iti e_commerce project .net5(mvc core) vs19\EbayAdminSideWebSite\EbayAdminSideWebSite my github\EbayView\Views\Comment\Index.cshtml"
           Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                ");
#nullable restore
#line 32 "D:\.net\1-learn\4- Projects\3-iti e_commerce project .net5(mvc core) vs19\EbayAdminSideWebSite\EbayAdminSideWebSite my github\EbayView\Views\Comment\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n                ");
#nullable restore
#line 33 "D:\.net\1-learn\4- Projects\3-iti e_commerce project .net5(mvc core) vs19\EbayAdminSideWebSite\EbayAdminSideWebSite my github\EbayView\Views\Comment\Index.cshtml"
           Write(Html.ActionLink("View All", "FilterByUserId", new { UserId=item.UserId },new {@class="btn btn-primary m-3"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 36 "D:\.net\1-learn\4- Projects\3-iti e_commerce project .net5(mvc core) vs19\EbayAdminSideWebSite\EbayAdminSideWebSite my github\EbayView\Views\Comment\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 37 "D:\.net\1-learn\4- Projects\3-iti e_commerce project .net5(mvc core) vs19\EbayAdminSideWebSite\EbayAdminSideWebSite my github\EbayView\Views\Comment\Index.cshtml"
           Write(Html.ActionLink("View All", "FilterByProdId", new {ProdId=item.ProductId },new {@class="btn btn-primary m-3"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "D:\.net\1-learn\4- Projects\3-iti e_commerce project .net5(mvc core) vs19\EbayAdminSideWebSite\EbayAdminSideWebSite my github\EbayView\Views\Comment\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "D:\.net\1-learn\4- Projects\3-iti e_commerce project .net5(mvc core) vs19\EbayAdminSideWebSite\EbayAdminSideWebSite my github\EbayView\Views\Comment\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            \r\n            <td>\r\n");
            WriteLiteral("                ");
#nullable restore
#line 49 "D:\.net\1-learn\4- Projects\3-iti e_commerce project .net5(mvc core) vs19\EbayAdminSideWebSite\EbayAdminSideWebSite my github\EbayView\Views\Comment\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { UserId=item.UserId,  ProdId=item.ProductId },new {@class="btn btn-primary"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n");
#nullable restore
#line 51 "D:\.net\1-learn\4- Projects\3-iti e_commerce project .net5(mvc core) vs19\EbayAdminSideWebSite\EbayAdminSideWebSite my github\EbayView\Views\Comment\Index.cshtml"
                    i++;

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n");
#nullable restore
#line 53 "D:\.net\1-learn\4- Projects\3-iti e_commerce project .net5(mvc core) vs19\EbayAdminSideWebSite\EbayAdminSideWebSite my github\EbayView\Views\Comment\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EbayView.Models.ViewModel.Comments.GetCommentOutputModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
