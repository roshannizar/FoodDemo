#pragma checksum "C:\Users\Roshan\Documents\GitHub\FoodDemo\FoodDemo\FoodDemo.Web\Pages\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d67ddc04f83867b51e2c7077094984796926b39"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d67ddc04f83867b51e2c7077094984796926b39", @"/Pages/Products/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"198c565d38c567dd882400a84a7ebb9bda87be96", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Products_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Users\Roshan\Documents\GitHub\FoodDemo\FoodDemo\FoodDemo.Web\Pages\Products\Index.cshtml"
  
    ViewData["Title"] = "Products";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"container-fluid\">\r\n        <h2>Products</h2>\r\n\r\n        <button type=\"button\" class=\"btn btn-outline-secondary btn-sm\" data-toggle=\"modal\" data-target=\"#exampleModalCenter\">New Product</button>\r\n        <br/><br/>\r\n");
            WriteLiteral("            <div class=\"container-fluid\">\r\n                <div class=\"row\">\r\n\r\n");
#nullable restore
#line 16 "C:\Users\Roshan\Documents\GitHub\FoodDemo\FoodDemo\FoodDemo.Web\Pages\Products\Index.cshtml"
                     if (@Model.Products != null)
                    {

                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Roshan\Documents\GitHub\FoodDemo\FoodDemo\FoodDemo.Web\Pages\Products\Index.cshtml"
                         foreach (var product in Model.Products)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"card margin border-color-strip\" style=\"width: 18rem;\">\r\n                                <div class=\"card-body\">\r\n                                    <label class=\"card-title font-weight-bold\">");
#nullable restore
#line 23 "C:\Users\Roshan\Documents\GitHub\FoodDemo\FoodDemo\FoodDemo.Web\Pages\Products\Index.cshtml"
                                                                          Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                                    <span class=\"badge badge-secondary right\">Quantity: ");
#nullable restore
#line 24 "C:\Users\Roshan\Documents\GitHub\FoodDemo\FoodDemo\FoodDemo.Web\Pages\Products\Index.cshtml"
                                                                                   Write(product.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    <hr />\r\n                                    <label class=\"small\">Description:</label>\r\n                                    <p class=\"card-text\">");
#nullable restore
#line 27 "C:\Users\Roshan\Documents\GitHub\FoodDemo\FoodDemo\FoodDemo.Web\Pages\Products\Index.cshtml"
                                                    Write(product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                    <hr />
                                    <div class=""btn-group"" role=""group"" aria-label=""Basic example"">
                                        <button type=""button"" class=""btn btn-warning btn-sm"">Edit</button>
                                        <button type=""button"" class=""btn btn-danger btn-sm"">Remove</button>
                                    </div>
                                </div>
                           </div>
");
#nullable restore
#line 35 "C:\Users\Roshan\Documents\GitHub\FoodDemo\FoodDemo\FoodDemo.Web\Pages\Products\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\Roshan\Documents\GitHub\FoodDemo\FoodDemo\FoodDemo.Web\Pages\Products\Index.cshtml"
                         

                     }
                     else
                     {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h3>Sorry no products available!</h3>\r\n");
#nullable restore
#line 41 "C:\Users\Roshan\Documents\GitHub\FoodDemo\FoodDemo\FoodDemo.Web\Pages\Products\Index.cshtml"
                     }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n");
            WriteLiteral(@"            <div class=""modal fade"" id=""exampleModalCenter"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
                <div class=""modal-dialog modal-dialog-centered"" role=""document"">
                    <div class=""modal-content"">
                        <div class=""modal-header"">
                            <h5 class=""modal-title"" id=""exampleModalCenterTitle"">Add New Product</h5>
                            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                <span aria-hidden=""true"">&times;</span>
                            </button>
                        </div>
                        <div class=""container-fluid"">
                            <br/>
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d67ddc04f83867b51e2c7077094984796926b398217", async() => {
                WriteLiteral(@"
                                <div class=""form-group"">
                                    <label class=""small font-weight-bold"" for=""Name"">Product Name: </label>
                                    <input type=""text"" class=""form-control"" name=""Name"" id=""Name"" placeholder=""eg: Orange"">
                                </div>
                                <div class=""form-group"">
                                    <label class=""small font-weight-bold"" for=""description"">Description:</label>
                                    <textarea class=""form-control"" placeholder=""Give a description about the product"" name=""Description"" id=""description"" rows=""3""></textarea>
                                </div>
                                <div class=""form-row"">
                                    <div class=""form-group col-md-4"">
                                        <label class=""small font-weight-bold"" for=""UnitPrice"">Unit Price:</label>
                                        <input type=""number""");
                WriteLiteral(@" class=""form-control"" placeholder=""12.00"" name=""UnitPrice"" id=""UnitPrice"">
                                    </div>
                                    <div class=""form-group col-md-4"">
                                        <label class=""small font-weight-bold"" for=""Quantity"">Quantity:</label>
                                        <input type=""number"" class=""form-control"" placeholder=""10"" name=""Quantity"" id=""Quantity"">
                                    </div>
                                </div>
                                <div class=""modal-footer"">
                                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                                    <button type=""submit"" class=""btn btn-primary"">Save changes</button>
                                </div>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            WriteLiteral("    </div>");
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
