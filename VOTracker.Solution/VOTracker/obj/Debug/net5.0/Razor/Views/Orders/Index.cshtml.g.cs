#pragma checksum "C:\Users\Marcus\Desktop\VOTracker\VOTracker.Solution\VOTracker\Views\Orders\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21cae6f4cd6c1366eb597cf4ba3cc8bccd088ed9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Index), @"mvc.1.0.view", @"/Views/Orders/Index.cshtml")]
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
#line 8 "C:\Users\Marcus\Desktop\VOTracker\VOTracker.Solution\VOTracker\Views\Orders\Index.cshtml"
using VOTracker.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21cae6f4cd6c1366eb597cf4ba3cc8bccd088ed9", @"/Views/Orders/Index.cshtml")]
    #nullable restore
    public class Views_Orders_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21cae6f4cd6c1366eb597cf4ba3cc8bccd088ed92904", async() => {
                WriteLiteral("\r\n  <meta charset=\"UTF-8\">\r\n  <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n  <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n  <title>Ordering Page</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21cae6f4cd6c1366eb597cf4ba3cc8bccd088ed94077", async() => {
                WriteLiteral("\r\n");
                WriteLiteral("\r\n  <h4>Hi</h4>\r\n  \r\n");
#nullable restore
#line 12 "C:\Users\Marcus\Desktop\VOTracker\VOTracker.Solution\VOTracker\Views\Orders\Index.cshtml"
 if (Model.Count == 0)
{

#line default
#line hidden
#nullable disable
                WriteLiteral("  <h4>Start your order below!</h4>\r\n");
#nullable restore
#line 15 "C:\Users\Marcus\Desktop\VOTracker\VOTracker.Solution\VOTracker\Views\Orders\Index.cshtml"
}

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 18 "C:\Users\Marcus\Desktop\VOTracker\VOTracker.Solution\VOTracker\Views\Orders\Index.cshtml"
       foreach(Order order in Model)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("      <div class=\"vendorDiv\"");
                BeginWriteAttribute("id", " id=\"", 404, "\"", 418, 1);
#nullable restore
#line 20 "C:\Users\Marcus\Desktop\VOTracker\VOTracker.Solution\VOTracker\Views\Orders\Index.cshtml"
WriteAttributeValue("", 409, order.Id, 409, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"margin: 2px; border-style: 1px solid\">\r\n      <ul><a");
                BeginWriteAttribute("href", " href=\"", 479, "\"", 509, 2);
                WriteAttributeValue("", 486, "/vendors/show/", 486, 14, true);
#nullable restore
#line 21 "C:\Users\Marcus\Desktop\VOTracker\VOTracker.Solution\VOTracker\Views\Orders\Index.cshtml"
WriteAttributeValue("", 500, order.Id, 500, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 21 "C:\Users\Marcus\Desktop\VOTracker\VOTracker.Solution\VOTracker\Views\Orders\Index.cshtml"
                                       Write(order.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></ul>\r\n          <li>Type: ");
#nullable restore
#line 22 "C:\Users\Marcus\Desktop\VOTracker\VOTracker.Solution\VOTracker\Views\Orders\Index.cshtml"
               Write(order.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n          <li>Order Id: ");
#nullable restore
#line 23 "C:\Users\Marcus\Desktop\VOTracker\VOTracker.Solution\VOTracker\Views\Orders\Index.cshtml"
                   Write(order.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n          <li>Vendor: ");
#nullable restore
#line 24 "C:\Users\Marcus\Desktop\VOTracker\VOTracker.Solution\VOTracker\Views\Orders\Index.cshtml"
                 Write(order.VendorId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n      </div>\r\n");
#nullable restore
#line 26 "C:\Users\Marcus\Desktop\VOTracker\VOTracker.Solution\VOTracker\Views\Orders\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n  <a href=\"/orders/new\"><button class=\"order\">Make an order now.</button></a>\r\n  <a href=\"/\"><button class=\"home\">Home</button></a>\r\n  \r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
