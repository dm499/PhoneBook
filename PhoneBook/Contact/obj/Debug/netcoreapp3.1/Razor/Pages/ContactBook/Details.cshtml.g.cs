#pragma checksum "C:\Users\Max\Desktop\ASP.NET\GitHubProjects\PhoneBook\Contact\Pages\ContactBook\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02d50e4265b43a8ea65f434cb82f5ff27a613699"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Contact.Pages.ContactBook.Pages_ContactBook_Details), @"mvc.1.0.razor-page", @"/Pages/ContactBook/Details.cshtml")]
namespace Contact.Pages.ContactBook
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
#line 1 "C:\Users\Max\Desktop\ASP.NET\GitHubProjects\PhoneBook\Contact\Pages\_ViewImports.cshtml"
using Contact;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02d50e4265b43a8ea65f434cb82f5ff27a613699", @"/Pages/ContactBook/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa682968e68af61e21df1943d040bba7b043ccb6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ContactBook_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Users\Max\Desktop\ASP.NET\GitHubProjects\PhoneBook\Contact\Pages\ContactBook\Details.cshtml"
  
    ViewData["Title"] = "Contact Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<h2 class=\"text-info\">Contact Details</h2>\r\n<br />\r\n\r\n<div class=\"border container\" style=\"padding:30px;\">\r\n    <table class=\"table table-striped\">\r\n        <thead>\r\n            <tr>\r\n                <th scope=\"col\">");
#nullable restore
#line 15 "C:\Users\Max\Desktop\ASP.NET\GitHubProjects\PhoneBook\Contact\Pages\ContactBook\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Phones.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th scope=\"col\">");
#nullable restore
#line 16 "C:\Users\Max\Desktop\ASP.NET\GitHubProjects\PhoneBook\Contact\Pages\ContactBook\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Phones.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th scope=\"col\">");
#nullable restore
#line 17 "C:\Users\Max\Desktop\ASP.NET\GitHubProjects\PhoneBook\Contact\Pages\ContactBook\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Phones.LonestarNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th scope=\"col\">");
#nullable restore
#line 18 "C:\Users\Max\Desktop\ASP.NET\GitHubProjects\PhoneBook\Contact\Pages\ContactBook\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Phones.OrangeNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th scope=\"col\">");
#nullable restore
#line 19 "C:\Users\Max\Desktop\ASP.NET\GitHubProjects\PhoneBook\Contact\Pages\ContactBook\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Phones.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n            <tr>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\Max\Desktop\ASP.NET\GitHubProjects\PhoneBook\Contact\Pages\ContactBook\Details.cshtml"
               Write(Html.DisplayFor(model => model.Phones.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\Max\Desktop\ASP.NET\GitHubProjects\PhoneBook\Contact\Pages\ContactBook\Details.cshtml"
               Write(Html.DisplayFor(model => model.Phones.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\Max\Desktop\ASP.NET\GitHubProjects\PhoneBook\Contact\Pages\ContactBook\Details.cshtml"
               Write(Html.DisplayFor(model => model.Phones.LonestarNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\Max\Desktop\ASP.NET\GitHubProjects\PhoneBook\Contact\Pages\ContactBook\Details.cshtml"
               Write(Html.DisplayFor(model => model.Phones.OrangeNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\Max\Desktop\ASP.NET\GitHubProjects\PhoneBook\Contact\Pages\ContactBook\Details.cshtml"
               Write(Html.DisplayFor(model => model.Phones.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n        </tbody>\r\n    </table>\r\n    <div class=\"row mt-5\">\r\n        <div class=\"col-1\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02d50e4265b43a8ea65f434cb82f5ff27a6136997535", async() => {
                WriteLiteral("Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Contact.Pages.ContactBook.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Contact.Pages.ContactBook.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Contact.Pages.ContactBook.DetailsModel>)PageContext?.ViewData;
        public Contact.Pages.ContactBook.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
