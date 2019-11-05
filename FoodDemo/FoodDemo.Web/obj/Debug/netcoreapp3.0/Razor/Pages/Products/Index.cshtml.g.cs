#pragma checksum "C:\Users\Roshan\Documents\GitHub\FoodDemo\FoodDemo\FoodDemo.Web\Pages\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6829d420deef02966163cc41294b256c9a167676"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FoodDemo.Web.Pages.Products.Pages_Products_Index), @"mvc.1.0.razor-page", @"/Pages/Products/Index.cshtml")]
namespace FoodDemo.Web.Pages.Products
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
#line 1 "C:\Users\Roshan\Documents\GitHub\FoodDemo\FoodDemo\FoodDemo.Web\Pages\_ViewImports.cshtml"
using FoodDemo;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6829d420deef02966163cc41294b256c9a167676", @"/Pages/Products/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"198c565d38c567dd882400a84a7ebb9bda87be96", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Products_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Roshan\Documents\GitHub\FoodDemo\FoodDemo\FoodDemo.Web\Pages\Products\Index.cshtml"
  
    ViewData["Title"] = "Products";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Products List</h1>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\Roshan\Documents\GitHub\FoodDemo\FoodDemo\FoodDemo.Web\Pages\Products\Index.cshtml"
  

    if (@Model.Products != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Roshan\Documents\GitHub\FoodDemo\FoodDemo\FoodDemo.Web\Pages\Products\Index.cshtml"
         foreach (var product in Model.Products)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card\" style=\"width: 18rem;\">\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title\">");
#nullable restore
#line 17 "C:\Users\Roshan\Documents\GitHub\FoodDemo\FoodDemo\FoodDemo.Web\Pages\Products\Index.cshtml"
                                      Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <p class=\"card-text\">");
#nullable restore
#line 18 "C:\Users\Roshan\Documents\GitHub\FoodDemo\FoodDemo\FoodDemo.Web\Pages\Products\Index.cshtml"
                                    Write(product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <a href=\"#\" class=\"btn btn-primary\">");
#nullable restore
#line 19 "C:\Users\Roshan\Documents\GitHub\FoodDemo\FoodDemo\FoodDemo.Web\Pages\Products\Index.cshtml"
                                                   Write(product.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 22 "C:\Users\Roshan\Documents\GitHub\FoodDemo\FoodDemo\FoodDemo.Web\Pages\Products\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Roshan\Documents\GitHub\FoodDemo\FoodDemo\FoodDemo.Web\Pages\Products\Index.cshtml"
         

    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3>Sorry no products available!</h3>\r\n");
#nullable restore
#line 28 "C:\Users\Roshan\Documents\GitHub\FoodDemo\FoodDemo\FoodDemo.Web\Pages\Products\Index.cshtml"
    }


#line default
#line hidden
#nullable disable
            WriteLiteral("    <button type=\"button\" class=\"btn btn-primary\" data-toggle=\"modal\" data-target=\"#exampleModalCenter\">\r\n        Launch demo modal\r\n    </button>\r\n");
            WriteLiteral(@"    <!-- Modal -->
    <div class=""modal fade"" id=""exampleModalCenter"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
        <div class=""modal-dialog modal-dialog-centered"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalCenterTitle"">Modal title</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    ...
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                    <button type=""button"" class=""btn btn-primary"">Save changes</button>
                </div>
            </div>
        </div>
    ");
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FoodDemo.Web.Pages.Products.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FoodDemo.Web.Pages.Products.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FoodDemo.Web.Pages.Products.IndexModel>)PageContext?.ViewData;
        public FoodDemo.Web.Pages.Products.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
