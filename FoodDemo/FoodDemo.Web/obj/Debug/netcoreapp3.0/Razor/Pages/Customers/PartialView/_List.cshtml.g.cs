#pragma checksum "C:\Users\Roshan\Documents\GitHub\FoodDemo\FoodDemo\FoodDemo.Web\Pages\Customers\PartialView\_List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a459393d267121cc5fd09230996350e9e9e96131"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FoodDemo.Web.Pages.Customers.PartialView.Pages_Customers_PartialView__List), @"mvc.1.0.view", @"/Pages/Customers/PartialView/_List.cshtml")]
namespace FoodDemo.Web.Pages.Customers.PartialView
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
#nullable restore
#line 1 "C:\Users\Roshan\Documents\GitHub\FoodDemo\FoodDemo\FoodDemo.Web\Pages\Customers\PartialView\_List.cshtml"
using FoodDemo.Data.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a459393d267121cc5fd09230996350e9e9e96131", @"/Pages/Customers/PartialView/_List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"198c565d38c567dd882400a84a7ebb9bda87be96", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Customers_PartialView__List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Customer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n    <div class=\"card margin border-color-strip\" style=\"width: 18rem;\">\r\n        <div class=\"card-body\">\r\n            <label class=\"card-title font-weight-bold\">");
#nullable restore
#line 7 "C:\Users\Roshan\Documents\GitHub\FoodDemo\FoodDemo\FoodDemo.Web\Pages\Customers\PartialView\_List.cshtml"
                                                  Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 7 "C:\Users\Roshan\Documents\GitHub\FoodDemo\FoodDemo\FoodDemo.Web\Pages\Customers\PartialView\_List.cshtml"
                                                                   Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            <hr />\r\n            <label class=\"small\">Mobile No:</label>\r\n            <p class=\"card-text\">");
#nullable restore
#line 10 "C:\Users\Roshan\Documents\GitHub\FoodDemo\FoodDemo\FoodDemo.Web\Pages\Customers\PartialView\_List.cshtml"
                            Write(Model.MobileNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <label class=\"small\">Email: </label>\r\n            <span class=\"badge badge-secondary\">");
#nullable restore
#line 12 "C:\Users\Roshan\Documents\GitHub\FoodDemo\FoodDemo\FoodDemo.Web\Pages\Customers\PartialView\_List.cshtml"
                                           Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
            <hr />
            <div class=""btn-group"" role=""group"" aria-label=""Basic example"">
                <button type=""button"" class=""btn btn-outline-info btn-sm"">More</button>
                <button type=""button"" class=""btn btn-warning btn-sm"">Edit</button>
                <button type=""button"" class=""btn btn-danger btn-sm"">Remove</button>
            </div>
        </div>
    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Customer> Html { get; private set; }
    }
}
#pragma warning restore 1591