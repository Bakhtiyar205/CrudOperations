#pragma checksum "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson9CrudOperation\FrontToBack\FrontToBack\Views\Shared\Components\Header\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06f5b27b3d990c1777cc17fa29f276a1f5ef7583"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Header_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Header/Default.cshtml")]
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
#line 1 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson9CrudOperation\FrontToBack\FrontToBack\Views\_ViewImports.cshtml"
using FrontToBack;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson9CrudOperation\FrontToBack\FrontToBack\Views\_ViewImports.cshtml"
using FrontToBack.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson9CrudOperation\FrontToBack\FrontToBack\Views\_ViewImports.cshtml"
using FrontToBack.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06f5b27b3d990c1777cc17fa29f276a1f5ef7583", @"/Views/Shared/Components/Header/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81052c4d0d671e0e46db3449fbc1cb187fb05a64", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Header_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dictionary<string,string>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "basket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<header>
    <!-- Info About Covid Delay -->
    <div class=""info-header"">
        <div class=""container"">
            <p class=""d-flex align-items-center justify-content-center"">
                Due to the &nbsp; <strong>
                    Covid-19
                    &nbsp;
                </strong> epidemic, orders may be processed with slight a delay
            </p>
        </div>
    </div>

    <!-- Link Contact Language  -->
    <div class=""link-contact-language-header d-xl-block d-lg-none d-md-none d-sm-none"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-4 d-flex align-content-center"">
                    <div class=""links"">

                        <!-- links -->
                        <ul class=""d-flex"">
                            <li><a href=""./about.html"">About Us</a></li>
                            <li><a href=""./login.html"">My Account</a></li>
                            <li><a href=""./card.html"">Wishlist</a></li");
            WriteLiteral(@">
                            <li><a href=""#"">Order Tracking</a></li>
                        </ul>
                    </div>
                </div>

                <!-- Secur Delivering-->
                <div class=""col-lg-4 d-flex align-items-lg-center"">
                    <div class=""right-vertical-line"">
                        <p>

                            <i class=""fa-solid fa-hand-dots fa-2x""></i>
                            100% Secure delivery without contacting the courier
                        </p>
                    </div>
                </div>

                <!-- Contact -->
                <div class=""col-lg-2 number"">
                    <p>
                        Need help? Call Us: <span class=""secondary""><a href=""#"">");
#nullable restore
#line 47 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson9CrudOperation\FrontToBack\FrontToBack\Views\Shared\Components\Header\Default.cshtml"
                                                                           Write(Model["HotCall"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></span>
                    </p>
                </div>

                <!-- Language & Exchange -->
                <div class=""col-lg-2 d-flex"">
                    <div class=""dropdown-language"">
                        <button class=""dropbtn-language dropbtn-language-home-page"">English <i class=""fa-solid fa-chevron-down""></i></button>
                        <div class=""dropdown-content-language"">
                            <a href=""#"">Azerbaijan</a>
                            <a href=""#"">Turkish</a>
                        </div>
                    </div>

                    <!-- Exchange -->
                    <div class=""dropdown-language"">
                        <button class=""dropbtn-language dropbtn-language-home-page"">USD <i class=""fa-solid fa-chevron-down""></i></button>
                        <div class=""dropdown-content-language"">
                            <a href=""#"">AZN</a>
                            <a href=""#"">TL</a>
                        </div>
         ");
            WriteLiteral("           </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <!-- Main Header First -->\r\n    <div class=\"container mt-2\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-2\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06f5b27b3d990c1777cc17fa29f276a1f5ef75838318", async() => {
                WriteLiteral("\r\n                    <img class=\"desktop-logo hide-mobile d-lg-block d-md-block d-sm-none\"");
                BeginWriteAttribute("src", "\r\n                         src=\"", 3248, "\"", 3294, 1);
#nullable restore
#line 79 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson9CrudOperation\FrontToBack\FrontToBack\Views\Shared\Components\Header\Default.cshtml"
WriteAttributeValue("", 3280, Model["Logo"], 3280, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("\r\n                         alt=\"Bacola ??? Grocery Market and Food Theme\" style=\"width: 100%;\">\r\n                    <img class=\"mobile-logo hide-desktop d-lg-none d-md-none d-sm-block\"");
                BeginWriteAttribute("src", "\r\n                         src=\"", 3478, "\"", 3530, 1);
#nullable restore
#line 82 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson9CrudOperation\FrontToBack\FrontToBack\Views\Shared\Components\Header\Default.cshtml"
WriteAttributeValue("", 3510, Model["LogoMobile"], 3510, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("\r\n                         alt=\"Bacola ??? Grocery Market and Food Theme\" style=\"width: 100%;\">\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
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
            <div class=""col-lg-2"">
                <!-- Button trigger modal -->
                <button type=""button"" class=""btn modal-custom"" data-bs-toggle=""modal""
                        data-bs-target=""#staticBackdrop"">
                    <div class=""row"">
                        <div class=""col-lg-10"">
                            <p style=""font-size: 11px; color: #8f95ac; margin:2px; margin-left: -40px;"">
                                Your
                                Location
                            </p>
                            <p>Select your Location</p>
                        </div>
                        <div class=""col-lg-1"" style=""margin-left: -4%; margin-top:2%;"">
                            <i class=""fa-solid fa-chevron-down""></i>
                        </div>
                    </div>
                </button>

                <!-- Modal -->
                <div class=""modal fade"" id=""staticBackdrop"" data-bs-backdrop=""static"" data-bs-ke");
            WriteLiteral(@"yboard=""false""
                     tabindex=""-1"" aria-labelledby=""staticBackdropLabel"" aria-hidden=""true"">
                    <div class=""modal-dialog"">
                        <div class=""modal-content"">
                            <div class=""modal-header"">
                                <h5 class=""modal-title"" id=""staticBackdropLabel"">Modal title</h5>
                                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal""
                                        aria-label=""Close""></button>
                            </div>
                            <div style=""height: 200px; overflow-y: scroll;"">
                                <div class=""px-2"">
                                    <div class=""modal-search"">
                                        <input type=""search""");
            BeginWriteAttribute("name", " name=\"", 5493, "\"", 5500, 0);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 5501, "\"", 5506, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""w-100"">
                                        <i class=""fa-solid fa-magnifying-glass""></i>
                                    </div>
                                    <div class=""modal-body border-bottom"">
                                        Azerbaijan
                                    </div>
                                    <div class=""modal-body border-bottom"">
                                        Turkey
                                    </div>
                                    <div class=""modal-body border-bottom"">
                                        Austria
                                    </div>
                                    <div class=""modal-body border-bottom"">
                                        USA
                                    </div>
                                    <div class=""modal-body border-bottom"">
                                        Georgia
                                    </div>
                                  ");
            WriteLiteral(@"  <div class=""modal-body border-bottom"">
                                        UK
                                    </div>
                                    <div class=""modal-body border-bottom"">
                                        Hungary
                                    </div>
                                </div>
                            </div>
                            <div class=""modal-footer"">
                                <button type=""button"" class=""btn btn-secondary""
                                        data-bs-dismiss=""modal"">
                                    Close
                                </button>
                                <button type=""button"" class=""btn btn-primary"">Understood</button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <!-- Search -->
            <div class=""col-lg-6"">
                <div class=""header-search"" style=""widt");
            WriteLiteral(@"h: 100%; position: relative;"">
                    <input type=""search"" placeholder=""Seacrh"" class=""w-100"" style=""height:50px;"">
                    <i class=""fa-solid fa-magnifying-glass"" style=""position: absolute;right: 10px; top: 17px;""></i>
                </div>
            </div>
            <div class=""col-lg-2 d-flex person-basket"">
                <div class=""person-header"">
                    <i class=""fa-solid fa-user""></i>
                </div>
                <p>$0.0</p>
                <div class=""hover-basket"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06f5b27b3d990c1777cc17fa29f276a1f5ef758315931", async() => {
                WriteLiteral("\r\n                        <div class=\"person-header basket-header\">\r\n                            <i class=\"fa-solid fa-basket-shopping\"></i>\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <div class=\"hovered-basket d-lg-block d-sm-none\">\r\n                        <div class=\"text-align-center border-bottom\" id=\"hovered-basket\">\r\n\r\n                            ");
#nullable restore
#line 176 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson9CrudOperation\FrontToBack\FrontToBack\Views\Shared\Components\Header\Default.cshtml"
                       Write(await Component.InvokeAsync("Basket"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                        We reduce shipping price only to 2.49$
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Main header 2 -->
    <div class=""container mt-3 border-bottom pb-2"">
        <div class=""row"">
            <div class=""col-lg-4"">
                <div class=""dropdown"">
                    <button class=""btn btn-secondary dropdown-toggle btn-all-category"" type=""button""
                            id=""dropdownMenuButton"" data-toggle=""dropdown"" aria-expanded=""false"">
                        <i class=""fas fa-bars""></i>
                        All Categories
                    </button>
                    <div class=""dropdown-menu toolgroup-custom mt-3"" aria-labelledby=""dropdownMenuButton"">
                        <ul class=""toolgroup"">
                            ");
#nullable restore
#line 196 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson9CrudOperation\FrontToBack\FrontToBack\Views\Shared\Components\Header\Default.cshtml"
                       Write(await Component.InvokeAsync("Category"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </ul>\r\n                        <div class=\"second-ul\">\r\n                            <ul>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 9680, "\"", 9687, 0);
            EndWriteAttribute();
            WriteLiteral(">Value Of The Day</a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 9754, "\"", 9761, 0);
            EndWriteAttribute();
            WriteLiteral(">Top 100 Offers</a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 9826, "\"", 9833, 0);
            EndWriteAttribute();
            WriteLiteral(@">New Arrivals</a></li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
            <!-- Cross Fast -->
            <div class=""col-lg-8"">
                <nav class=""navbar navbar-expand-lg navbar-light navbar-background navbar-background-home-page"">
                    <div class=""collapse navbar-collapse navbar-background navbar-background-home-page"" id=""navbarNavDropdown"">
                        <ul class=""navbar-nav navbar-background navbar-background-home-page"">
                            <li class=""nav-item dropdown"">
                                <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbarDropdownMenuLink""
                                   role=""button"" data-toggle=""dropdown"" aria-expanded=""false"">
                                    Home
                                </a>
                                <div class=""dropdown-menu mt-3"" aria-labelledby=""navbarDropdownMenuLink"">
     ");
            WriteLiteral(@"                               <a class=""dropdown-item"" href=""#"">Home 1</a>
                                    <a class=""dropdown-item"" href=""#"">Home 2</a>
                                    <a class=""dropdown-item"" href=""#"">Home 3</a>
                                    <a class=""dropdown-item"" href=""#"">Home 4</a>
                                    <a class=""dropdown-item"" href=""#"">Home 5</a>
                                </div>
                            </li>
                            <li class=""nav-item dropdown"">
                                <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbarDropdownMenuLink""
                                   role=""button"" data-toggle=""dropdown"" aria-expanded=""false"">
                                    Shop
                                </a>
                                <div class=""dropdown-menu mt-3"" aria-labelledby=""navbarDropdownMenuLink"">
                                    <div class=""row shop-background-header"">
                 ");
            WriteLiteral(@"                       <div class=""col-4"">
                                            <a class=""dropdown-item"" href=""./shop.html"">Shop 1</a>
                                            <a class=""dropdown-item"" href=""./shop.html"">Shop 1</a>
                                            <a class=""dropdown-item"" href=""./shop.html"">Shop 1</a>
                                            <a class=""dropdown-item"" href=""./shop.html"">Shop 1</a>
                                            <a class=""dropdown-item"" href=""./shop.html"">Shop 1</a>
                                            <a class=""dropdown-item"" href=""./shop.html"">Shop 1</a>
                                        </div>
                                        <div class=""col-4"">
                                            <a class=""dropdown-item"" href=""./shop.html"">Shop 2</a>
                                            <a class=""dropdown-item"" href=""./shop.html"">Shop 2</a>
                                            <a class=""dropdown-item"" hr");
            WriteLiteral(@"ef=""./shop.html"">Shop 2</a>
                                            <a class=""dropdown-item"" href=""./shop.html"">Shop 2</a>
                                            <a class=""dropdown-item"" href=""./shop.html"">Shop 2</a>
                                            <a class=""dropdown-item"" href=""./shop.html"">Shop 2</a>
                                        </div>
                                        <div class=""col-4"">
                                            <a class=""dropdown-item"" href=""./shop.html"">Shop 3</a>
                                            <a class=""dropdown-item"" href=""./shop.html"">Shop 3</a>
                                            <a class=""dropdown-item"" href=""./shop.html"">Shop 3</a>
                                            <a class=""dropdown-item"" href=""./shop.html"">Shop 3</a>
                                            <a class=""dropdown-item"" href=""./shop.html"">Shop 3</a>
                                            <a class=""dropdown-item"" href=""./shop.html");
            WriteLiteral(@""">Shop 3</a>
                                        </div>
                                    </div>
                                </div>
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link"" href=""#"">
                                    <i class=""fa-solid fa-drumstick-bite""></i>Meats &
                                    Seafood
                                </a>
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link"" href=""#""><i class=""fa-solid fa-bread-slice""></i> Bakery</a>
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link"" href=""#""><i class=""fa-solid fa-mug-saucer""></i> Tea</a>
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link"" href=""./blog.html"">Blog</a>");
            WriteLiteral(@"
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link"" href=""./contact.html"">Contact</a>
                            </li>
                        </ul>
                    </div>
                </nav>
            </div>
        </div>
    </div>
</header>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dictionary<string,string>> Html { get; private set; }
    }
}
#pragma warning restore 1591
