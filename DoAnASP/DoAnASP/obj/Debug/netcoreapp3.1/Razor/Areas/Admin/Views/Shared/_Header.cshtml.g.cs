#pragma checksum "C:\HOC TAP\ASP\DoAnASP\DoAnASP\Areas\Admin\Views\Shared\_Header.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "531b0c9e0671f70a4fa37e09b1488dea9cebc773"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__Header), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_Header.cshtml")]
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
#line 1 "C:\HOC TAP\ASP\DoAnASP\DoAnASP\Areas\Admin\Views\_ViewImports.cshtml"
using DoAnASP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\HOC TAP\ASP\DoAnASP\DoAnASP\Areas\Admin\Views\_ViewImports.cshtml"
using DoAnASP.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"531b0c9e0671f70a4fa37e09b1488dea9cebc773", @"/Areas/Admin/Views/Shared/_Header.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e41c8f12160b4158443b76ffed93fd2231c0e0d7", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared__Header : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#search-results.html"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<div class=\"menu-right\">\r\n    <div class=\"navbar user-panel-top\">\r\n        <div class=\"search-box\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "531b0c9e0671f70a4fa37e09b1488dea9cebc7734040", async() => {
                WriteLiteral("\r\n                <input class=\"search-input\" placeholder=\"Search Here...\" type=\"search\" id=\"search\">\r\n                <button class=\"search-submit\"");
                BeginWriteAttribute("value", " value=\"", 310, "\"", 318, 0);
                EndWriteAttribute();
                WriteLiteral("><span class=\"fa fa-search\"></span></button>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
        <div class=""user-dropdown-details d-flex"">
            <div class=""profile_details_left"">
                <ul class=""nofitications-dropdown"">
                    <li class=""dropdown"">
                        <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"" aria-expanded=""false""><i class=""fa fa-bell-o""></i><span class=""badge blue"">3</span></a>
                        <ul class=""dropdown-menu"">
                            <li>
                                <div class=""notification_header"">
                                    <h3>You have 3 new notifications</h3>
                                </div>
                            </li>
                            <li>
                                <a href=""#"" class=""grid"">
                                    <div class=""user_img""><img src=""assets/images/avatar1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 1260, "\"", 1266, 0);
            EndWriteAttribute();
            WriteLiteral(@"></div>
                                    <div class=""notification_desc"">
                                        <p>Johnson purchased template</p>
                                        <span>Just Now</span>
                                    </div>
                                </a>
                            </li>
                            <li class=""odd"">
                                <a href=""#"" class=""grid"">
                                    <div class=""user_img""><img src=""assets/images/avatar2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 1799, "\"", 1805, 0);
            EndWriteAttribute();
            WriteLiteral(@"></div>
                                    <div class=""notification_desc"">
                                        <p>New customer registered </p>
                                        <span>1 hour ago</span>
                                    </div>
                                </a>
                            </li>
                            <li>
                                <a href=""#"" class=""grid"">
                                    <div class=""user_img""><img src=""assets/images/avatar3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 2326, "\"", 2332, 0);
            EndWriteAttribute();
            WriteLiteral(@"></div>
                                    <div class=""notification_desc"">
                                        <p>Lorem ipsum dolor sit amet </p>
                                        <span>2 hours ago</span>
                                    </div>
                                </a>
                            </li>
                            <li>
                                <div class=""notification_bottom"">
                                    <a href=""#all"" class=""bg-primary"">See all notifications</a>
                                </div>
                            </li>
                        </ul>
                    </li>
                    <li class=""dropdown"">
                        <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"" aria-expanded=""false""><i class=""fa fa-comment-o""></i><span class=""badge blue"">4</span></a>
                        <ul class=""dropdown-menu"">
                            <li>
                                <div class=""notifica");
            WriteLiteral(@"tion_header"">
                                    <h3>You have 4 new messages</h3>
                                </div>
                            </li>
                            <li>
                                <a href=""#"" class=""grid"">
                                    <div class=""user_img""><img src=""assets/images/avatar1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 3704, "\"", 3710, 0);
            EndWriteAttribute();
            WriteLiteral(@"></div>
                                    <div class=""notification_desc"">
                                        <p>Johnson purchased template</p>
                                        <span>Just Now</span>
                                    </div>
                                </a>
                            </li>
                            <li class=""odd"">
                                <a href=""#"" class=""grid"">
                                    <div class=""user_img""><img src=""assets/images/avatar2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 4243, "\"", 4249, 0);
            EndWriteAttribute();
            WriteLiteral(@"></div>
                                    <div class=""notification_desc"">
                                        <p>New customer registered </p>
                                        <span>1 hour ago</span>
                                    </div>
                                </a>
                            </li>
                            <li>
                                <a href=""#"" class=""grid"">
                                    <div class=""user_img""><img src=""assets/images/avatar3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 4770, "\"", 4776, 0);
            EndWriteAttribute();
            WriteLiteral(@"></div>
                                    <div class=""notification_desc"">
                                        <p>Lorem ipsum dolor sit amet </p>
                                        <span>2 hours ago</span>
                                    </div>
                                </a>
                            </li>
                            <li>
                                <a href=""#"" class=""grid"">
                                    <div class=""user_img""><img src=""assets/images/avatar1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 5301, "\"", 5307, 0);
            EndWriteAttribute();
            WriteLiteral(@"></div>
                                    <div class=""notification_desc"">
                                        <p>Johnson purchased template</p>
                                        <span>Just Now</span>
                                    </div>
                                </a>
                            </li>
                            <li>
                                <div class=""notification_bottom"">
                                    <a href=""#all"" class=""bg-primary"">See all messages</a>
                                </div>
                            </li>
                        </ul>
                    </li>
                </ul>
            </div>
            <div class=""profile_details"">
                <ul>
                    <li class=""dropdown profile_details_drop"">
                        <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"" id=""dropdownMenu3"" aria-haspopup=""true"" aria-expanded=""false"">
                            <div class=""profil");
            WriteLiteral("e_img\">\r\n                                <img src=\"assets/images/profileimg.jpg\" class=\"rounded-circle\"");
            BeginWriteAttribute("alt", " alt=\"", 6435, "\"", 6441, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                <div class=""user-active"">
                                    <span></span>
                                </div>
                            </div>
                        </a>
                        <ul class=""dropdown-menu drp-mnu"" aria-labelledby=""dropdownMenu3"">
                            <li class=""user-info"">
                                <h5 class=""user-name"">John Deo</h5>
                                <span class=""status ml-2"">Available</span>
                            </li>
                            <li> <a href=""#""><i class=""lnr lnr-user""></i>My Profile</a> </li>
                            <li> <a href=""#""><i class=""lnr lnr-users""></i>1k Followers</a> </li>
                            <li> <a href=""#""><i class=""lnr lnr-cog""></i>Setting</a> </li>
                            <li> <a href=""#""><i class=""lnr lnr-heart""></i>100 Likes</a> </li>
                            <li class=""logout""> <a href=""#sign-up.html""><i class=""fa fa-power-off""></i");
            WriteLiteral("> Logout</a> </li>\r\n                        </ul>\r\n                    </li>\r\n                </ul>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
