#pragma checksum "D:\.net\1-learn\4- Projects\1-iti e_commerce project\EbayAdminSideWebSite\EbayView\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a881a5fde9cc97acd205cb11458517c1c7238abe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(EbayView.Views.Home.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace EbayView.Views.Home
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a881a5fde9cc97acd205cb11458517c1c7238abe", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"888fc3c05d16ba269ab96bfefaac907c93321ff4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EbayView.Models.ViewModel.GetStatisticsOutputModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\.net\1-learn\4- Projects\1-iti e_commerce project\EbayAdminSideWebSite\EbayView\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("styleslink", async() => {
                WriteLiteral("\r\n");
                WriteLiteral(@"      <link href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.13.0/css/all.min.css"" rel=""stylesheet"">
       <link rel=""stylesheet"" href=""https://cdn.linearicons.com/free/1.0.0/icon-font.min.css"">
     
     <style>
         a{
              color:white;
              text-decoration:none;
         }
     </style>
");
            }
            );
            WriteLiteral(@"<div class=""tab-content"">
	<div class=""tab-pane tabs-animation fade active show"" id=""tab-content-1"" role=""tabpanel"">
        <div class=""row"">
            <div class=""col-md-4"">
                <div class=""card mb-3 bg-primary widget-chart text-white card-border"">
                    <div class=""icon-wrapper rounded-circle"">
                        <div class=""icon-wrapper-bg bg-white opacity-1""></div>
                        <i class=""lnr lnr-user text-white""></i>
                    </div>
                    <div class=""widget-numbers"">3</div>
                    <div class=""widget-subheading"">Total Users</div>
                    <div class=""widget-description text-success"">
                        <a");
            BeginWriteAttribute("href", " href=\"", 2597, "\"", 2633, 1);
#nullable restore
#line 75 "D:\.net\1-learn\4- Projects\1-iti e_commerce project\EbayAdminSideWebSite\EbayView\Views\Home\Index.cshtml"
WriteAttributeValue("", 2604, Url.Action("Index", "Users"), 2604, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            <i class=""fa fa-angle-up ""> </i>
                            <span class=""pl-1"">view</span>
                        </a> 
                    </div>
                </div>
            </div>
            <div class=""col-md-4"">
                <div class=""card mb-3 bg-success widget-chart text-white card-border""> 
                    <div class=""icon-wrapper rounded-circle"" style=""border-radius:50%;background-color: lightgreen;"">
                        <div class=""icon-wrapper-bg opacity-10""></div> 
");
            WriteLiteral(@"                          <img style=""width:50px;display:block;margin:auto;""
                            src=""https://img.icons8.com/external-itim2101-fill-itim2101/64/000000/external-admin-network-technology-itim2101-fill-itim2101-1.png""/>
                     </div>
                    <div class=""widget-numbers"">");
#nullable restore
#line 90 "D:\.net\1-learn\4- Projects\1-iti e_commerce project\EbayAdminSideWebSite\EbayView\Views\Home\Index.cshtml"
                                           Write(Model.AdminCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"widget-subheading\">Admin</div>\r\n                    <div class=\"widget-description text-white\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 3755, "\"", 3792, 1);
#nullable restore
#line 93 "D:\.net\1-learn\4- Projects\1-iti e_commerce project\EbayAdminSideWebSite\EbayView\Views\Home\Index.cshtml"
WriteAttributeValue("", 3762, Url.Action("Index", "Admins"), 3762, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            <span class=""pr-1"">view</span>
                            <i class=""fa fa-arrow-left ""> </i>
                        </a>       
                    </div>
                </div>
            </div>
            <div class=""col-md-4"">
                <div class=""card mb-3 bg-warning widget-chart text-white card-border"">
                    <div class=""icon-wrapper rounded-circle"">
                        <div class=""icon-wrapper-bg bg-white opacity-2""></div>
");
            WriteLiteral(@"                        <img  style=""width:30px;display:block;margin:auto;""
                        src=""https://img.icons8.com/external-sbts2018-mixed-sbts2018/58/000000/external-new-product-cyber-monday-sbts2018-mixed-sbts2018.png""/>
                    </div>
                    <div class=""widget-numbers"">");
#nullable restore
#line 108 "D:\.net\1-learn\4- Projects\1-iti e_commerce project\EbayAdminSideWebSite\EbayView\Views\Home\Index.cshtml"
                                           Write(Model.ProductCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"widget-subheading\">New Product </div>\r\n                    <div class=\"widget-description text-white\"> \r\n                         <a");
            BeginWriteAttribute("href", " href=\"", 4874, "\"", 4913, 1);
#nullable restore
#line 111 "D:\.net\1-learn\4- Projects\1-iti e_commerce project\EbayAdminSideWebSite\EbayView\Views\Home\Index.cshtml"
WriteAttributeValue("", 4881, Url.Action("Index", "Products"), 4881, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                             <span class=""pl-1"">view</span>
                            <i class=""fa fa-arrow-left""> </i> 
                        </a> 
                    </div>
                </div>
            </div>
            <div class=""col-md-4"">
                <div class=""card mb-3 bg-focus widget-chart text-white card-border"">
                    <div class=""icon-wrapper rounded-circle"">
                        <div class=""icon-wrapper-bg bg-info opacity-5""></div>
                        <img style=""width:30px;display:block;margin:auto;""
                        src=""https://img.icons8.com/office/16/000000/category.png""/>
                    </div>
                    <div class=""widget-numbers"">");
#nullable restore
#line 125 "D:\.net\1-learn\4- Projects\1-iti e_commerce project\EbayAdminSideWebSite\EbayView\Views\Home\Index.cshtml"
                                           Write(Model.CategoryCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"widget-subheading\">Total Categories</div>\r\n                    <div class=\"widget-description text-info\"> \r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 5841, "\"", 5882, 1);
#nullable restore
#line 128 "D:\.net\1-learn\4- Projects\1-iti e_commerce project\EbayAdminSideWebSite\EbayView\Views\Home\Index.cshtml"
WriteAttributeValue("", 5848, Url.Action("Index", "Categories"), 5848, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            <i class=""fa fa-arrow-right""> </i>
                            <span class=""pl-1"">view</span>
                        </a> 
                    </div>
                </div>
            </div>
            <div class=""col-md-4"">
                <div class=""card mb-3 bg-danger widget-chart text-white card-border"">
                    <div class=""icon-wrapper rounded"">
                        <div class=""icon-wrapper-bg bg-white opacity-2""></div>
                        <i class=""lnr lnr-list text-white""></i> 
                    </div>
                    <div class=""widget-numbers"">");
#nullable restore
#line 141 "D:\.net\1-learn\4- Projects\1-iti e_commerce project\EbayAdminSideWebSite\EbayView\Views\Home\Index.cshtml"
                                           Write(Model.SubCategoryCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"widget-subheading\">Total SubCategory</div>\r\n                    <div class=\"widget-description text-white\"> \r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 6713, "\"", 6757, 1);
#nullable restore
#line 144 "D:\.net\1-learn\4- Projects\1-iti e_commerce project\EbayAdminSideWebSite\EbayView\Views\Home\Index.cshtml"
WriteAttributeValue("", 6720, Url.Action("Index", "SubCategories"), 6720, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            <i class=""fa fa-angle-up""> </i>
                            <span class=""pl-1"">view</span>
                        </a> 
                    </div>
                </div>
            </div>
            <div class=""col-md-4"">
                <div class=""card mb-3 bg-info widget-chart text-white card-border"">
                    <div class=""icon-wrapper rounded"">
                        <div class=""icon-wrapper-bg bg-focus opacity-5""></div>
                        <img  style=""width:50px;display:block;margin:auto;""
                         src=""https://img.icons8.com/external-outline-geotatah/64/000000/external-brand-brand-positioning-outline-geotatah-6.png""/>
                     </div>
                    <div class=""widget-numbers"">");
#nullable restore
#line 158 "D:\.net\1-learn\4- Projects\1-iti e_commerce project\EbayAdminSideWebSite\EbayView\Views\Home\Index.cshtml"
                                           Write(Model.BrandCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"widget-subheading\">Total Brand</div>\r\n                    <div class=\"widget-description text-white\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 7731, "\"", 7768, 1);
#nullable restore
#line 161 "D:\.net\1-learn\4- Projects\1-iti e_commerce project\EbayAdminSideWebSite\EbayView\Views\Home\Index.cshtml"
WriteAttributeValue("", 7738, Url.Action("Index", "Brands"), 7738, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            <i class=""fa fa-arrow-right""> </i>
                            <span class=""pl-1"">view</span>
                        </a>  
                    </div>
                </div>
            </div>
        </div>
        <div class=""divider mt-0"" style=""margin-bottom: 30px;""></div>
        <div class=""row"">
            <div class=""col-md-4"">
                <div class=""card mb-3 bg-arielle-smile widget-chart text-white card-border"">
                    <div class=""icon-wrapper rounded-circle"">
                        <div class=""icon-wrapper-bg bg-white opacity-10""></div>
                        <i class=""lnr-cog icon-gradient bg-arielle-smile""></i>
                    </div>
                    <div class=""widget-numbers"">");
#nullable restore
#line 177 "D:\.net\1-learn\4- Projects\1-iti e_commerce project\EbayAdminSideWebSite\EbayView\Views\Home\Index.cshtml"
                                           Write(Model.OfferCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"widget-subheading\">Total Offers in Website</div>\r\n                    <div class=\"widget-description text-dark\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 8741, "\"", 8778, 1);
#nullable restore
#line 180 "D:\.net\1-learn\4- Projects\1-iti e_commerce project\EbayAdminSideWebSite\EbayView\Views\Home\Index.cshtml"
WriteAttributeValue("", 8748, Url.Action("Index", "Offers"), 8748, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            <i class=""fa fa-angle-up ""> </i>
                            <span class=""pl-1"">view</span>
                        </a> 
                    </div>
                </div>
            </div>
            <div class=""col-md-4"">
                <div class=""card mb-3 bg-warm-flame widget-chart text-white card-border"">
                    <div class=""icon-wrapper rounded"">
                        <div class=""icon-wrapper-bg bg-white opacity-10""></div>
                        <i class=""lnr-screen icon-gradient bg-warm-flame""></i>
                    </div>
                    <div class=""widget-numbers"">");
#nullable restore
#line 193 "D:\.net\1-learn\4- Projects\1-iti e_commerce project\EbayAdminSideWebSite\EbayView\Views\Home\Index.cshtml"
                                           Write(Model.StockCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"widget-subheading\">Stock places</div>\r\n                    <div class=\"widget-description text-white\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 9614, "\"", 9651, 1);
#nullable restore
#line 196 "D:\.net\1-learn\4- Projects\1-iti e_commerce project\EbayAdminSideWebSite\EbayView\Views\Home\Index.cshtml"
WriteAttributeValue("", 9621, Url.Action("Index", "Stocks"), 9621, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            <span class=""pr-1"">view</span>
                            <i class=""fa fa-arrow-left ""> </i>
                        </a> 
                    </div>
                </div>
            </div>
            <div class=""col-md-4"">
                <div class=""card mb-3 bg-ripe-malin widget-chart text-white card-border"">
                    <div class=""icon-wrapper rounded"">
                        <div class=""icon-wrapper-bg bg-white opacity-2""></div>
                        <i class=""lnr-laptop-phone text-white""></i>
                    </div>
                    <div class=""widget-numbers"">");
#nullable restore
#line 209 "D:\.net\1-learn\4- Projects\1-iti e_commerce project\EbayAdminSideWebSite\EbayView\Views\Home\Index.cshtml"
                                           Write(Model.ShipperCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"widget-subheading\">Shipper Companies</div>\r\n                    <div class=\"widget-description text-white\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 10484, "\"", 10523, 1);
#nullable restore
#line 212 "D:\.net\1-learn\4- Projects\1-iti e_commerce project\EbayAdminSideWebSite\EbayView\Views\Home\Index.cshtml"
WriteAttributeValue("", 10491, Url.Action("Index", "Shippers"), 10491, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            <span class=""pl-1"">view</span>
                            <i class=""fa fa-angle-up ""> </i>
                        </a> 
                    </div>
                </div>
            </div>
            <div class=""col-md-4"">
                <div class=""card mb-3 bg-mixed-hopes widget-chart text-white card-border"">
                    <div class=""icon-wrapper rounded"">
                        <div class=""icon-wrapper-bg bg-dark opacity-9""></div>
                        <i class=""lnr-graduation-hat text-white""></i>
                    </div>
                    <div class=""widget-numbers"">");
#nullable restore
#line 225 "D:\.net\1-learn\4- Projects\1-iti e_commerce project\EbayAdminSideWebSite\EbayView\Views\Home\Index.cshtml"
                                           Write(Model.OrderCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"widget-subheading\">Total Orders</div>\r\n                    <div class=\"widget-description text-dark\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 11348, "\"", 11385, 1);
#nullable restore
#line 228 "D:\.net\1-learn\4- Projects\1-iti e_commerce project\EbayAdminSideWebSite\EbayView\Views\Home\Index.cshtml"
WriteAttributeValue("", 11355, Url.Action("Index", "Orders"), 11355, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            <i class=""fa fa-arrow-right ""> </i>
                            <span class=""pl-1"">view</span></div>
                        </a>
                </div>
            </div> 
            <div class=""col-md-4"">
                <div class=""card mb-3 bg-grow-early widget-chart text-white card-border"">
                    <div class=""icon-wrapper rounded-circle"">
                        <div class=""icon-wrapper-bg bg-white opacity-2""></div>
                        <i class=""lnr-laptop-phone text-white""></i>
                    </div>
                    <div class=""widget-numbers"">");
#nullable restore
#line 240 "D:\.net\1-learn\4- Projects\1-iti e_commerce project\EbayAdminSideWebSite\EbayView\Views\Home\Index.cshtml"
                                           Write(Model.CommentCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"widget-subheading\">Total Comment</div>\r\n                    <div class=\"widget-description text-white\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 12200, "\"", 12238, 1);
#nullable restore
#line 243 "D:\.net\1-learn\4- Projects\1-iti e_commerce project\EbayAdminSideWebSite\EbayView\Views\Home\Index.cshtml"
WriteAttributeValue("", 12207, Url.Action("Index", "Comment"), 12207, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <span class=\"pl-1\">view</span>\r\n                            <i class=\"fa fa-angle-up \"> </i>\r\n                        </a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EbayView.Models.ViewModel.GetStatisticsOutputModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
