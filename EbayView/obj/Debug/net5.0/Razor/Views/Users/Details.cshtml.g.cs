#pragma checksum "D:\.net\1-learn\4- Projects\3-iti e_commerce project .net5(mvc core) vs19\EbayAdminSideWebSite\EbayAdminSideWebSite my github\EbayView\Views\Users\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bfc9e27be0955633cde14fe24278fedaacec8d4e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(EbayView.Views.Users.Views_Users_Details), @"mvc.1.0.view", @"/Views/Users/Details.cshtml")]
namespace EbayView.Views.Users
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bfc9e27be0955633cde14fe24278fedaacec8d4e", @"/Views/Users/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"888fc3c05d16ba269ab96bfefaac907c93321ff4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Users_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EbayView.Models.ViewModel.Users.GetUsserDetailsOutputModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary m-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n");
            DefineSection("styleslink", async() => {
                WriteLiteral(@"
       <style>
            body{
        color: #6F8BA4;
        margin-top:20px;
        }
        .section {
            padding: 100px 0;
            position: relative;
        }
        .gray-bg {
            background-color: #f5f5f5;
        }
        img {
            max-width: 100%;
        }
        img {
            vertical-align: middle;
            border-style: none;
        }
        /* About Me 
        ---------------------*/
        .about-text h3 {
          font-size: 45px;
          font-weight: 700;
          margin: 0 0 6px;
        }
        media (max-width: 767px) {
          .about-text h3 {
            font-size: 35px;
          }
        }
        .about-text h6 {
          font-weight: 600;
          margin-bottom: 15px;
        }
        media (max-width: 767px) {
          .about-text h6 {
            font-size: 18px;
          }
        }
        .about-text p {
          font-size: 18px;
          max-width: 450px;
        }
   ");
                WriteLiteral(@"     .about-text p mark {
          font-weight: 600;
          color: #20247b;
        }

        .about-list {
          padding-top: 10px;
        }
        .about-list .media {
          padding: 5px 0;
        }
        .about-list label {
          color: #20247b;
          font-weight: 600;
          width: 88px;
          margin: 0;
          position: relative;
        }
        .about-list label:after {
          content: """";
          position: absolute;
          top: 0;
          bottom: 0;
          right: 11px;
          width: 1px;
          height: 12px;
          background: #20247b;
          -moz-transform: rotate(15deg);
          -o-transform: rotate(15deg);
          -ms-transform: rotate(15deg);
          -webkit-transform: rotate(15deg);
          transform: rotate(15deg);
          margin: auto;
          opacity: 0.5;
        }
        .about-list p {
          margin: 0;
          font-size: 15px;
        }

        media (max-width: 991px) {");
                WriteLiteral(@"
          .about-avatar {
            margin-top: 30px;
          }
        }

        .about-section .counter {
          padding: 22px 20px;
          background: #ffffff;
          border-radius: 10px;
          box-shadow: 0 0 30px rgba(31, 45, 61, 0.125);
        }
        .about-section .counter .count-data {
          margin-top: 10px;
          margin-bottom: 10px;
        }
        .about-section .counter .count {
          font-weight: 700;
          color: #20247b;
          margin: 0 0 5px;
        }
        .about-section .counter p {
          font-weight: 600;
          margin: 0;
        }
        mark {
            background-image: linear-gradient(rgba(252, 83, 86, 0.6), rgba(252, 83, 86, 0.6));
            background-size: 100% 3px;
            background-repeat: no-repeat;
            background-position: 0 bottom;
            background-color: transparent;
            padding: 0;
            color: currentColor;
        }
        .theme-color {
        ");
                WriteLiteral("    color: #fc5356;\r\n        }\r\n        .dark-color {\r\n            color: #20247b;\r\n        }\r\n       </style>\r\n");
            }
            );
            WriteLiteral("<div>\r\n    <h4>User Details</h4>\r\n    <hr />\r\n");
            WriteLiteral(@"    <section class=""section about-section gray-bg"" id=""about"">
            <div class=""container"">
                <div class=""row align-items-center flex-row-reverse"">
                    <div class=""col-lg-6"">
                        <div class=""about-text go-to"">
                            <h3 class=""dark-color"">");
#nullable restore
#line 215 "D:\.net\1-learn\4- Projects\3-iti e_commerce project .net5(mvc core) vs19\EbayAdminSideWebSite\EbayAdminSideWebSite my github\EbayView\Views\Users\Details.cshtml"
                                              Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            <h6 class=\"theme-color lead\">");
#nullable restore
#line 216 "D:\.net\1-learn\4- Projects\3-iti e_commerce project .net5(mvc core) vs19\EbayAdminSideWebSite\EbayAdminSideWebSite my github\EbayView\Views\Users\Details.cshtml"
                                                    Write(Model.FistName);

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 216 "D:\.net\1-learn\4- Projects\3-iti e_commerce project .net5(mvc core) vs19\EbayAdminSideWebSite\EbayAdminSideWebSite my github\EbayView\Views\Users\Details.cshtml"
                                                                     Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n");
            WriteLiteral(@"                            <div class=""row about-list"">
                                <div class=""col-md-6""> 
                                    <div class=""media"">
                                        <label>Phone</label>
                                        <p>");
#nullable restore
#line 222 "D:\.net\1-learn\4- Projects\3-iti e_commerce project .net5(mvc core) vs19\EbayAdminSideWebSite\EbayAdminSideWebSite my github\EbayView\Views\Users\Details.cshtml"
                                      Write(Model.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                    <div class=\"media\">\r\n                                        <label>E-mail</label>\r\n                                        <p>");
#nullable restore
#line 226 "D:\.net\1-learn\4- Projects\3-iti e_commerce project .net5(mvc core) vs19\EbayAdminSideWebSite\EbayAdminSideWebSite my github\EbayView\Views\Users\Details.cshtml"
                                      Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                    </div>
                                </div>
                                <div class=""col-md-6"">
                                    <div class=""media"">
                                        <label>Country</label>
                                        <p>");
#nullable restore
#line 232 "D:\.net\1-learn\4- Projects\3-iti e_commerce project .net5(mvc core) vs19\EbayAdminSideWebSite\EbayAdminSideWebSite my github\EbayView\Views\Users\Details.cshtml"
                                      Write(Model.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                    <div class=\"media\">\r\n                                        <label>City</label>\r\n                                        <p>");
#nullable restore
#line 236 "D:\.net\1-learn\4- Projects\3-iti e_commerce project .net5(mvc core) vs19\EbayAdminSideWebSite\EbayAdminSideWebSite my github\EbayView\Views\Users\Details.cshtml"
                                      Write(Model.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div> \r\n                                    <div class=\"media\">\r\n                                        <label>ZIP</label>\r\n                                        <p>");
#nullable restore
#line 240 "D:\.net\1-learn\4- Projects\3-iti e_commerce project .net5(mvc core) vs19\EbayAdminSideWebSite\EbayAdminSideWebSite my github\EbayView\Views\Users\Details.cshtml"
                                      Write(Model.ZIP);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                    </div>
                                </div> 
                            </div> 
                            <div class=""row about-list col-md-12"">
                                <div class=""media w-100"">
                                <label class=""w-50"">Full Address Details</label>
                                <p>");
#nullable restore
#line 247 "D:\.net\1-learn\4- Projects\3-iti e_commerce project .net5(mvc core) vs19\EbayAdminSideWebSite\EbayAdminSideWebSite my github\EbayView\Views\Users\Details.cshtml"
                              Write(Model.FullAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-lg-6"">
                        <div class=""about-avatar"">
                            <img src=""https://bootdey.com/img/Content/avatar/avatar7.png""");
            BeginWriteAttribute("title", " title=\"", 8410, "\"", 8418, 0);
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 8419, "\"", 8425, 0);
            EndWriteAttribute();
            WriteLiteral("> \r\n");
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div> \r\n            </div>\r\n        </section>\r\n\r\n</div>\r\n<div> \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bfc9e27be0955633cde14fe24278fedaacec8d4e13574", async() => {
                WriteLiteral("Back to List");
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
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EbayView.Models.ViewModel.Users.GetUsserDetailsOutputModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
