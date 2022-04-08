#pragma checksum "C:\Users\admin\Documents\GitHub\TelephoneDirectory\Presentation\TelephoneDirectory.Web\Views\Contact\AddContact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5a20304e267ca299dd7eaf911926fbb1b81c2d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_AddContact), @"mvc.1.0.view", @"/Views/Contact/AddContact.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5a20304e267ca299dd7eaf911926fbb1b81c2d9", @"/Views/Contact/AddContact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57218c316b6921e2cd61027a2387edc31a2d9471", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_AddContact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TelephoneDirectory.Libraries.Core.ContactDto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-md-8 order-md-1\">\r\n        <h4 class=\"mb-3\">Add Contact Form</h4>\r\n        <form class=\"needs-validation\" method=\"post\" asp-controller=\"Contact\" asp-action=\"AddContact\">\r\n            <input name=\"UserId\"");
            BeginWriteAttribute("value", " value=\"", 295, "\"", 322, 1);
#nullable restore
#line 6 "C:\Users\admin\Documents\GitHub\TelephoneDirectory\Presentation\TelephoneDirectory.Web\Views\Contact\AddContact.cshtml"
WriteAttributeValue("", 303, ViewData["userid"], 303, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" hidden />\r\n            <div class=\"row\">\r\n                <div class=\"col-md-6 mb-3\">\r\n                    <label for=\"firstName\">PhoneNumber</label>\r\n                    <input type=\"text\" class=\"form-control\" name=\"PhoneNumber\"");
            BeginWriteAttribute("placeholder", " placeholder=\"", 553, "\"", 567, 0);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 568, "\"", 576, 0);
            EndWriteAttribute();
            BeginWriteAttribute("required", " required=\"", 577, "\"", 588, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <div class=""invalid-feedback"">
                        Valid phone number is required.
                    </div>
                </div>
                <div class=""col-md-6 mb-3"">
                    <label for=""lastName"">Email</label>
                    <input type=""text"" class=""form-control"" name=""Email""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 927, "\"", 941, 0);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 942, "\"", 950, 0);
            EndWriteAttribute();
            BeginWriteAttribute("required", " required=\"", 951, "\"", 962, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <div class=""invalid-feedback"">
                        Valid email is required.
                    </div>
                </div>
            </div>

            <div class=""mb-3"">
                <label for=""address"">Location</label>
                <input type=""text"" class=""form-control"" name=""Location""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 1300, "\"", 1314, 0);
            EndWriteAttribute();
            BeginWriteAttribute("required", " required=\"", 1315, "\"", 1326, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                <div class=""invalid-feedback"">
                    Please enter your location.
                </div>
            </div>

            <hr class=""mb-4"">
            <button class=""btn btn-primary btn-lg btn-block"" type=""submit"">Save</button>
        </form>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TelephoneDirectory.Libraries.Core.ContactDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
