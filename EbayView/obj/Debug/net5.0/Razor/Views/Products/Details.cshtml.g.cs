#pragma checksum "D:\.net\1-learn\4- Projects\3-iti e_commerce project .net5(mvc core) vs19\EbayAdminSideWebSite\EbayAdminSideWebSite my github\EbayView\Views\Products\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c789410bfabfc9211413b677eff93e49cfa8fe2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(EbayView.Views.Products.Views_Products_Details), @"mvc.1.0.view", @"/Views/Products/Details.cshtml")]
namespace EbayView.Views.Products
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c789410bfabfc9211413b677eff93e49cfa8fe2", @"/Views/Products/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"888fc3c05d16ba269ab96bfefaac907c93321ff4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Products_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EbayView.Models.ViewModel.Products.GetProductDetailsOutputModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-right:10px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\.net\1-learn\4- Projects\3-iti e_commerce project .net5(mvc core) vs19\EbayAdminSideWebSite\EbayAdminSideWebSite my github\EbayView\Views\Products\Details.cshtml"
  
	ViewData["Title"] = "Details";
	Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("styleslink", async() => {
                WriteLiteral("  ");
                WriteLiteral(@"
<link href=""https://cdnjs.cloudflare.com/ajax/libs/bootstrap/5.0.2/css/bootstrap.min.css"" rel=""stylesheet"" />
<link href=""https://unpkg.com/swiper@6.5.4/swiper-bundle.min.css"" rel=""stylesheet"" />

<style>
	.product-thumbs .swiper-slide img {
		border: 2px solid transparent;
		object-fit: cover;
		cursor: pointer;
	}

	.product-thumbs .swiper-slide-active img {
		border-color: #bc4f38;
	}

	.product-slider .swiper-button-next:after,
	.product-slider .swiper-button-prev:after {
		font-size: 20px;
		color: #000;
		font-weight: bold;
	}
	li{
		list-style-type: none;
		display:inline;
	}
</style>

");
            }
            );
            WriteLiteral(@"<div class=""w-100 text-center"">
	<h1>Product Details</h1>
</div> 
<div> 
	 <hr /> 
	 <div class=""container pb-5"">
		<div class=""row"">
		   <div class=""col-lg-6 product-left mb-5 mb-lg-0"">
			<div class=""swiper-container product-slider mb-3"">
			 <div class=""swiper-wrapper"">
");
#nullable restore
#line 45 "D:\.net\1-learn\4- Projects\3-iti e_commerce project .net5(mvc core) vs19\EbayAdminSideWebSite\EbayAdminSideWebSite my github\EbayView\Views\Products\Details.cshtml"
                                 foreach (var img in Model.productImgs)
								{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t  <div class=\"swiper-slide\">\r\n\t\t\t\t   <img");
            BeginWriteAttribute("src", " src=\"", 1261, "\"", 1271, 1);
#nullable restore
#line 48 "D:\.net\1-learn\4- Projects\3-iti e_commerce project .net5(mvc core) vs19\EbayAdminSideWebSite\EbayAdminSideWebSite my github\EbayView\Views\Products\Details.cshtml"
WriteAttributeValue("", 1267, img, 1267, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"...\" class=\"img-fluid\">\r\n\t\t\t\t  </div>\r\n");
#nullable restore
#line 50 "D:\.net\1-learn\4- Projects\3-iti e_commerce project .net5(mvc core) vs19\EbayAdminSideWebSite\EbayAdminSideWebSite my github\EbayView\Views\Products\Details.cshtml"
								}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t </div>\r\n\t\t\t <div class=\"swiper-button-next\"></div>\r\n\t\t\t <div class=\"swiper-button-prev\"></div>\r\n\t\t\t</div>\r\n\t\t\t<div class=\"swiper-container product-thumbs\">\r\n\t\t\t <div class=\"swiper-wrapper\">\r\n");
#nullable restore
#line 57 "D:\.net\1-learn\4- Projects\3-iti e_commerce project .net5(mvc core) vs19\EbayAdminSideWebSite\EbayAdminSideWebSite my github\EbayView\Views\Products\Details.cshtml"
                                 foreach (var img in Model.productImgs)
								{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t  <div class=\"swiper-slide\">\r\n\t\t\t\t   <img");
            BeginWriteAttribute("src", " src=\"", 1628, "\"", 1638, 1);
#nullable restore
#line 60 "D:\.net\1-learn\4- Projects\3-iti e_commerce project .net5(mvc core) vs19\EbayAdminSideWebSite\EbayAdminSideWebSite my github\EbayView\Views\Products\Details.cshtml"
WriteAttributeValue("", 1634, img, 1634, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"...\" class=\"img-fluid\">\r\n\t\t\t\t  </div>\r\n");
#nullable restore
#line 62 "D:\.net\1-learn\4- Projects\3-iti e_commerce project .net5(mvc core) vs19\EbayAdminSideWebSite\EbayAdminSideWebSite my github\EbayView\Views\Products\Details.cshtml"
								}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t </div>\r\n\t\t\t</div>\r\n\t\t   </div>\r\n\t\t   <dl class=\"row col-lg-6\">\r\n\t\t\t\t<dt class=\"col-sm-5\">\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 68 "D:\.net\1-learn\4- Projects\3-iti e_commerce project .net5(mvc core) vs19\EbayAdminSideWebSite\EbayAdminSideWebSite my github\EbayView\Views\Products\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</dt>\r\n\t\t\t\t<dd class=\"col-sm-7\">\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 71 "D:\.net\1-learn\4- Projects\3-iti e_commerce project .net5(mvc core) vs19\EbayAdminSideWebSite\EbayAdminSideWebSite my github\EbayView\Views\Products\Details.cshtml"
                           Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</dd>\r\n\t\t\t\t<dt class=\"col-sm-5\">\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 74 "D:\.net\1-learn\4- Projects\3-iti e_commerce project .net5(mvc core) vs19\EbayAdminSideWebSite\EbayAdminSideWebSite my github\EbayView\Views\Products\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</dt>\r\n\t\t\t\t<dd class=\"col-sm-7\">\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 77 "D:\.net\1-learn\4- Projects\3-iti e_commerce project .net5(mvc core) vs19\EbayAdminSideWebSite\EbayAdminSideWebSite my github\EbayView\Views\Products\Details.cshtml"
                           Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</dd>\r\n\t\t\t\t<dt class=\"col-sm-5\">\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 80 "D:\.net\1-learn\4- Projects\3-iti e_commerce project .net5(mvc core) vs19\EbayAdminSideWebSite\EbayAdminSideWebSite my github\EbayView\Views\Products\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</dt>\r\n\t\t\t\t<dd class=\"col-sm-7\">\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 83 "D:\.net\1-learn\4- Projects\3-iti e_commerce project .net5(mvc core) vs19\EbayAdminSideWebSite\EbayAdminSideWebSite my github\EbayView\Views\Products\Details.cshtml"
                           Write(Html.DisplayFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</dd>\r\n\t\t\t\t<dt class=\"col-sm-5\">\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 86 "D:\.net\1-learn\4- Projects\3-iti e_commerce project .net5(mvc core) vs19\EbayAdminSideWebSite\EbayAdminSideWebSite my github\EbayView\Views\Products\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</dt>\r\n\t\t\t\t<dd class=\"col-sm-7\">\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 89 "D:\.net\1-learn\4- Projects\3-iti e_commerce project .net5(mvc core) vs19\EbayAdminSideWebSite\EbayAdminSideWebSite my github\EbayView\Views\Products\Details.cshtml"
                           Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</dd>\r\n\t\t\t\t<dt class=\"col-sm-5\">\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 92 "D:\.net\1-learn\4- Projects\3-iti e_commerce project .net5(mvc core) vs19\EbayAdminSideWebSite\EbayAdminSideWebSite my github\EbayView\Views\Products\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.brandName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</dt>\r\n\t\t\t\t<dd class=\"col-sm-7\">\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 95 "D:\.net\1-learn\4- Projects\3-iti e_commerce project .net5(mvc core) vs19\EbayAdminSideWebSite\EbayAdminSideWebSite my github\EbayView\Views\Products\Details.cshtml"
                           Write(Html.DisplayFor(model => model.brandName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</dd>\r\n\t\t\t\t<dt class=\"col-sm-5\">\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 98 "D:\.net\1-learn\4- Projects\3-iti e_commerce project .net5(mvc core) vs19\EbayAdminSideWebSite\EbayAdminSideWebSite my github\EbayView\Views\Products\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.AdminName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</dt>\r\n\t\t\t\t<dd class=\"col-sm-7\">\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 101 "D:\.net\1-learn\4- Projects\3-iti e_commerce project .net5(mvc core) vs19\EbayAdminSideWebSite\EbayAdminSideWebSite my github\EbayView\Views\Products\Details.cshtml"
                           Write(Html.DisplayFor(model => model.AdminName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</dd>\r\n\t\t\t\t<dt class=\"col-sm-5\">\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 104 "D:\.net\1-learn\4- Projects\3-iti e_commerce project .net5(mvc core) vs19\EbayAdminSideWebSite\EbayAdminSideWebSite my github\EbayView\Views\Products\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.categoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</dt>\r\n\t\t\t\t<dd class=\"col-sm-7\">\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 107 "D:\.net\1-learn\4- Projects\3-iti e_commerce project .net5(mvc core) vs19\EbayAdminSideWebSite\EbayAdminSideWebSite my github\EbayView\Views\Products\Details.cshtml"
                           Write(Html.DisplayFor(model => model.categoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</dd>\r\n\t\t\t\t<dt class=\"col-sm-5\">\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 110 "D:\.net\1-learn\4- Projects\3-iti e_commerce project .net5(mvc core) vs19\EbayAdminSideWebSite\EbayAdminSideWebSite my github\EbayView\Views\Products\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.subcategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</dt>\r\n\t\t\t\t<dd class=\"col-sm-7\">\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 113 "D:\.net\1-learn\4- Projects\3-iti e_commerce project .net5(mvc core) vs19\EbayAdminSideWebSite\EbayAdminSideWebSite my github\EbayView\Views\Products\Details.cshtml"
                           Write(Html.DisplayFor(model => model.subcategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</dd>\r\n\t\t\t\t<dt class=\"col-sm-5\">\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 116 "D:\.net\1-learn\4- Projects\3-iti e_commerce project .net5(mvc core) vs19\EbayAdminSideWebSite\EbayAdminSideWebSite my github\EbayView\Views\Products\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.stockName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</dt>\r\n\t\t\t\t<dd class=\"col-sm-7\">\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 119 "D:\.net\1-learn\4- Projects\3-iti e_commerce project .net5(mvc core) vs19\EbayAdminSideWebSite\EbayAdminSideWebSite my github\EbayView\Views\Products\Details.cshtml"
                           Write(Html.DisplayFor(model => model.stockName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</dd>\r\n\t\t\t\t<dt class=\"col-sm-5\">\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 122 "D:\.net\1-learn\4- Projects\3-iti e_commerce project .net5(mvc core) vs19\EbayAdminSideWebSite\EbayAdminSideWebSite my github\EbayView\Views\Products\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.rateNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</dt>\r\n\t\t\t\t<dd class=\"col-sm-7\">\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 125 "D:\.net\1-learn\4- Projects\3-iti e_commerce project .net5(mvc core) vs19\EbayAdminSideWebSite\EbayAdminSideWebSite my github\EbayView\Views\Products\Details.cshtml"
                           Write(Html.DisplayFor(model => model.rateNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t<ul class=\"rating\">\r\n");
#nullable restore
#line 127 "D:\.net\1-learn\4- Projects\3-iti e_commerce project .net5(mvc core) vs19\EbayAdminSideWebSite\EbayAdminSideWebSite my github\EbayView\Views\Products\Details.cshtml"
                          
							int x =Model.rateNumber;
						

#line default
#line hidden
#nullable disable
#nullable restore
#line 130 "D:\.net\1-learn\4- Projects\3-iti e_commerce project .net5(mvc core) vs19\EbayAdminSideWebSite\EbayAdminSideWebSite my github\EbayView\Views\Products\Details.cshtml"
                                     for (int i=1;i<=5;i++)
									{
										if (i<=x)
										{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t<li>\r\n\t\t\t\t\t\t\t\t\t\t\t  <i class=\"fas fa-star fa-sm text-primary\"></i>\r\n\t\t\t\t\t\t\t\t\t\t\t</li>\r\n");
#nullable restore
#line 137 "D:\.net\1-learn\4- Projects\3-iti e_commerce project .net5(mvc core) vs19\EbayAdminSideWebSite\EbayAdminSideWebSite my github\EbayView\Views\Products\Details.cshtml"
										}
										else
										{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t<li>\r\n\t\t\t\t\t\t\t\t\t\t\t\t<i class=\"far fa-star fa-sm text-primary\"></i>\r\n\t\t\t\t\t\t\t\t\t\t\t</li>\r\n");
#nullable restore
#line 143 "D:\.net\1-learn\4- Projects\3-iti e_commerce project .net5(mvc core) vs19\EbayAdminSideWebSite\EbayAdminSideWebSite my github\EbayView\Views\Products\Details.cshtml"
										}
									}  

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t  </ul>\r\n\t\t\t\t</dd>\r\n\t\t\t\t<dt class=\"col-sm-5\">\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 148 "D:\.net\1-learn\4- Projects\3-iti e_commerce project .net5(mvc core) vs19\EbayAdminSideWebSite\EbayAdminSideWebSite my github\EbayView\Views\Products\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.commentNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n\t\t\t\t</dt>\r\n\t\t\t\t<dd class=\"col-sm-7\">\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 151 "D:\.net\1-learn\4- Projects\3-iti e_commerce project .net5(mvc core) vs19\EbayAdminSideWebSite\EbayAdminSideWebSite my github\EbayView\Views\Products\Details.cshtml"
                           Write(Html.DisplayFor(model => model.commentNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</dd>\r\n\t\t   </dl>\r\n\t\t</div>\r\n\t </div>\r\n</div>\r\n<div style=\"display:block;width:100%;text-align:center\">\r\n ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c789410bfabfc9211413b677eff93e49cfa8fe220185", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 158 "D:\.net\1-learn\4- Projects\3-iti e_commerce project .net5(mvc core) vs19\EbayAdminSideWebSite\EbayAdminSideWebSite my github\EbayView\Views\Products\Details.cshtml"
                        WriteLiteral(Model.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c789410bfabfc9211413b677eff93e49cfa8fe222579", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
            DefineSection("Scriptslink", async() => {
                WriteLiteral("   ");
                WriteLiteral(@"
<script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.6.0/jquery.min.js""></script>
<script src=""https://unpkg.com/swiper@6.5.4/swiper-bundle.min.js""></script>
<script>
	/* product left start */
	if($("".product-left"").length){
		var productSlider = new Swiper('.product-slider', {
			spaceBetween: 0,
			centeredSlides: false,
			loop:true,
			direction: 'horizontal',
			loopedSlides: 5,
			navigation: {
				nextEl: "".swiper-button-next"",
				prevEl: "".swiper-button-prev"",
			},
			resizeObserver:true,
		});
		var productThumbs = new Swiper('.product-thumbs', {
			spaceBetween: 0,
			centeredSlides: true,
			loop: true,
			slideToClickedSlide: true,
			direction: 'horizontal',
			slidesPerView: 5,
			loopedSlides: 5,
		});
		productSlider.controller.control = productThumbs;
		productThumbs.controller.control = productSlider;




	}
	/* 	product left end */
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EbayView.Models.ViewModel.Products.GetProductDetailsOutputModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
