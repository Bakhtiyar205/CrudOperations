#pragma checksum "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson9CrudOperation\FrontToBack\FrontToBack\Views\Home\Basket.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e040a820569ed7abcf8475b11491a1f6168041f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Basket), @"mvc.1.0.view", @"/Views/Home/Basket.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e040a820569ed7abcf8475b11491a1f6168041f0", @"/Views/Home/Basket.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81052c4d0d671e0e46db3449fbc1cb187fb05a64", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Basket : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BasketDetailVM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson9CrudOperation\FrontToBack\FrontToBack\Views\Home\Basket.cshtml"
  
    ViewData["Title"] = "Basket";
    int count = 1;
    decimal price = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div class=""container"">
    <div class=""row"">
        <div class=""header d-flex justify-content-between mt-3"">
            <h1>Basket</h1>

        </div>
        <div class=""table-responsive"">
            <table class=""table table-striped"">
                <thead>
                    <tr>
                        <th>
                            Number
                        </th>
                        <th>
                            Image
                        </th>
                        <th>
                            Name
                        </th>
                        <th>
                            Count
                        </th>
                        <th>
                            Price
                        </th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 38 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson9CrudOperation\FrontToBack\FrontToBack\Views\Home\Basket.cshtml"
                     foreach (var item in Model)
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 43 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson9CrudOperation\FrontToBack\FrontToBack\Views\Home\Basket.cshtml"
                           Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 1264, "\"", 1288, 1);
#nullable restore
#line 46 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson9CrudOperation\FrontToBack\FrontToBack\Views\Home\Basket.cshtml"
WriteAttributeValue("", 1270, item.ProductImage, 1270, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"150\" />\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 49 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson9CrudOperation\FrontToBack\FrontToBack\Views\Home\Basket.cshtml"
                           Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 52 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson9CrudOperation\FrontToBack\FrontToBack\Views\Home\Basket.cshtml"
                           Write(item.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 55 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson9CrudOperation\FrontToBack\FrontToBack\Views\Home\Basket.cshtml"
                           Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 58 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson9CrudOperation\FrontToBack\FrontToBack\Views\Home\Basket.cshtml"
                        count++;
                        price += item.Price;

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <h3>Total Price:");
#nullable restore
#line 63 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson9CrudOperation\FrontToBack\FrontToBack\Views\Home\Basket.cshtml"
                               Write(price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BasketDetailVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591