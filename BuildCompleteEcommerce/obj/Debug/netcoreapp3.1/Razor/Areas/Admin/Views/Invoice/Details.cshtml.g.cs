#pragma checksum "C:\Users\emres\OneDrive\Masaüstü\Yazılım Çalışmaları\Asp.Net Core Mvc\BuildCompleteEcommerce\BuildCompleteEcommerce\Areas\Admin\Views\Invoice\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f332945f8735c869cf534b4d8e1acd16f55003f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Invoice_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Invoice/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f332945f8735c869cf534b4d8e1acd16f55003f", @"/Areas/Admin/Views/Invoice/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Invoice_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "invoice", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "process", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\emres\OneDrive\Masaüstü\Yazılım Çalışmaları\Asp.Net Core Mvc\BuildCompleteEcommerce\BuildCompleteEcommerce\Areas\Admin\Views\Invoice\Details.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<section class=\"content-header\">\r\n    <h1>\r\n        Invoice\r\n        <small>");
#nullable restore
#line 9 "C:\Users\emres\OneDrive\Masaüstü\Yazılım Çalışmaları\Asp.Net Core Mvc\BuildCompleteEcommerce\BuildCompleteEcommerce\Areas\Admin\Views\Invoice\Details.cshtml"
          Write(ViewBag.invoice.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n    </h1>\r\n    <ol class=\"breadcrumb\">\r\n        <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f332945f8735c869cf534b4d8e1acd16f55003f5758", async() => {
                WriteLiteral("<i class=\"fa fa-dashboard\"></i> Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n    </ol>\r\n</section>\r\n<section class=\"invoice\">\r\n    <!-- title row -->\r\n    <div class=\"row\">\r\n        <div class=\"col-xs-12\">\r\n            <h2 class=\"page-header\">\r\n                <i class=\"fa fa-globe\"></i> ");
#nullable restore
#line 20 "C:\Users\emres\OneDrive\Masaüstü\Yazılım Çalışmaları\Asp.Net Core Mvc\BuildCompleteEcommerce\BuildCompleteEcommerce\Areas\Admin\Views\Invoice\Details.cshtml"
                                       Write(ViewBag.invoice.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <small class=\"pull-right\">Date: ");
#nullable restore
#line 21 "C:\Users\emres\OneDrive\Masaüstü\Yazılım Çalışmaları\Asp.Net Core Mvc\BuildCompleteEcommerce\BuildCompleteEcommerce\Areas\Admin\Views\Invoice\Details.cshtml"
                                           Write(ViewBag.invoice.Created.ToString("MM/dd/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</small>
            </h2>
        </div>
        <!-- /.col -->
    </div>
    <!-- info row -->
    <div class=""row invoice-info"">
        <!-- /.col -->
        <div class=""col-sm-4 invoice-col"">
            To
            <address>
                <strong>");
#nullable restore
#line 32 "C:\Users\emres\OneDrive\Masaüstü\Yazılım Çalışmaları\Asp.Net Core Mvc\BuildCompleteEcommerce\BuildCompleteEcommerce\Areas\Admin\Views\Invoice\Details.cshtml"
                   Write(ViewBag.invoice.Account.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong><br>\r\n                ");
#nullable restore
#line 33 "C:\Users\emres\OneDrive\Masaüstü\Yazılım Çalışmaları\Asp.Net Core Mvc\BuildCompleteEcommerce\BuildCompleteEcommerce\Areas\Admin\Views\Invoice\Details.cshtml"
           Write(ViewBag.invoice.Account.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n                Phone: ");
#nullable restore
#line 34 "C:\Users\emres\OneDrive\Masaüstü\Yazılım Çalışmaları\Asp.Net Core Mvc\BuildCompleteEcommerce\BuildCompleteEcommerce\Areas\Admin\Views\Invoice\Details.cshtml"
                  Write(ViewBag.invoice.Account.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n                Email: ");
#nullable restore
#line 35 "C:\Users\emres\OneDrive\Masaüstü\Yazılım Çalışmaları\Asp.Net Core Mvc\BuildCompleteEcommerce\BuildCompleteEcommerce\Areas\Admin\Views\Invoice\Details.cshtml"
                  Write(ViewBag.invoice.Account.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </address>
        </div>

    </div>
    <!-- /.row -->
    <!-- Table row -->
    <div class=""row"">
        <div class=""col-xs-12 table-responsive"">
            <table class=""table table-striped"">
                <thead>
                    <tr>
                        <th>Product Id</th>
                        <th>Product Name</th>
                        <th>Price</th>
                        <th>Quantity</th>
                        <th>Sub Total</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 55 "C:\Users\emres\OneDrive\Masaüstü\Yazılım Çalışmaları\Asp.Net Core Mvc\BuildCompleteEcommerce\BuildCompleteEcommerce\Areas\Admin\Views\Invoice\Details.cshtml"
                     foreach (var invoiceDetail in ViewBag.invoice.InvoiceDetailses)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 58 "C:\Users\emres\OneDrive\Masaüstü\Yazılım Çalışmaları\Asp.Net Core Mvc\BuildCompleteEcommerce\BuildCompleteEcommerce\Areas\Admin\Views\Invoice\Details.cshtml"
                           Write(invoiceDetail.Product.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 59 "C:\Users\emres\OneDrive\Masaüstü\Yazılım Çalışmaları\Asp.Net Core Mvc\BuildCompleteEcommerce\BuildCompleteEcommerce\Areas\Admin\Views\Invoice\Details.cshtml"
                           Write(invoiceDetail.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 60 "C:\Users\emres\OneDrive\Masaüstü\Yazılım Çalışmaları\Asp.Net Core Mvc\BuildCompleteEcommerce\BuildCompleteEcommerce\Areas\Admin\Views\Invoice\Details.cshtml"
                           Write(invoiceDetail.Product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 61 "C:\Users\emres\OneDrive\Masaüstü\Yazılım Çalışmaları\Asp.Net Core Mvc\BuildCompleteEcommerce\BuildCompleteEcommerce\Areas\Admin\Views\Invoice\Details.cshtml"
                           Write(invoiceDetail.Product.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 62 "C:\Users\emres\OneDrive\Masaüstü\Yazılım Çalışmaları\Asp.Net Core Mvc\BuildCompleteEcommerce\BuildCompleteEcommerce\Areas\Admin\Views\Invoice\Details.cshtml"
                            Write(invoiceDetail.Product.Price * invoiceDetail.Product.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 64 "C:\Users\emres\OneDrive\Masaüstü\Yazılım Çalışmaları\Asp.Net Core Mvc\BuildCompleteEcommerce\BuildCompleteEcommerce\Areas\Admin\Views\Invoice\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n        <!-- /.col -->\r\n    </div>\r\n");
#nullable restore
#line 70 "C:\Users\emres\OneDrive\Masaüstü\Yazılım Çalışmaları\Asp.Net Core Mvc\BuildCompleteEcommerce\BuildCompleteEcommerce\Areas\Admin\Views\Invoice\Details.cshtml"
     if (ViewBag.invoice.Status == 1)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row no-print\">\r\n            <div class=\"col-xs-12\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f332945f8735c869cf534b4d8e1acd16f55003f13763", async() => {
                WriteLiteral("\r\n                    <button type=\"submit\" class=\"btn btn-success pull-right\">\r\n                        <i class=\"fa fa-credit-card\"></i> Submit Payment\r\n                    </button>\r\n                    <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 2878, "\"", 2905, 1);
#nullable restore
#line 78 "C:\Users\emres\OneDrive\Masaüstü\Yazılım Çalışmaları\Asp.Net Core Mvc\BuildCompleteEcommerce\BuildCompleteEcommerce\Areas\Admin\Views\Invoice\Details.cshtml"
WriteAttributeValue("", 2886, ViewBag.invoice.Id, 2886, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 82 "C:\Users\emres\OneDrive\Masaüstü\Yazılım Çalışmaları\Asp.Net Core Mvc\BuildCompleteEcommerce\BuildCompleteEcommerce\Areas\Admin\Views\Invoice\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</section>");
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
