#pragma checksum "C:\Users\Administrator\Downloads\Web_Programming_Assignment_2021-master\Web_Programming_Assignment_2021-master\Web_Programming_Assignment_2021\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7cf000148cd39f6bdfc78590e855ecce5c3aca64"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
#line 1 "C:\Users\Administrator\Downloads\Web_Programming_Assignment_2021-master\Web_Programming_Assignment_2021-master\Web_Programming_Assignment_2021\Views\_ViewImports.cshtml"
using Web_Programming_Assignment_2021;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\Downloads\Web_Programming_Assignment_2021-master\Web_Programming_Assignment_2021-master\Web_Programming_Assignment_2021\Views\_ViewImports.cshtml"
using Web_Programming_Assignment_2021.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Administrator\Downloads\Web_Programming_Assignment_2021-master\Web_Programming_Assignment_2021-master\Web_Programming_Assignment_2021\Views\_ViewImports.cshtml"
using Web_Programming_Assignment_2021.ViewModels.Post;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Administrator\Downloads\Web_Programming_Assignment_2021-master\Web_Programming_Assignment_2021-master\Web_Programming_Assignment_2021\Views\_ViewImports.cshtml"
using Web_Programming_Assignment_2021.ViewModels.Accounts;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cf000148cd39f6bdfc78590e855ecce5c3aca64", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c5dfc5b15956322cfdf0e8752aa3d08387da305", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Web_Programming_Assignment_2021.Models.Post>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:450px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-size:20px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Administrator\Downloads\Web_Programming_Assignment_2021-master\Web_Programming_Assignment_2021-master\Web_Programming_Assignment_2021\Views\Home\Details.cshtml"
   Layout = "_Layout"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 5 "C:\Users\Administrator\Downloads\Web_Programming_Assignment_2021-master\Web_Programming_Assignment_2021-master\Web_Programming_Assignment_2021\Views\Home\Details.cshtml"
   ViewData["Title"] = "Details"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Details</h1>
<div class=""row"">

        <div class=""bs-example"" style="" margin: 20px;"">
            <ul class=""nav nav-tabs"">
                <li class=""nav-item"">
                    <a href=""#author"" class=""nav-link"" data-toggle=""tab"">Author</a>
                </li>
                <li class=""nav-item"">
                    <a href=""#post"" class=""nav-link active"" data-toggle=""tab"">Post</a>
                </li>
            </ul>
            <div class=""tab-content"">
                <div class=""tab-pane fade "" id=""author"">
                    
                    <div class=""profile"">

                        <div class=""profile-image"">
");
#nullable restore
#line 25 "C:\Users\Administrator\Downloads\Web_Programming_Assignment_2021-master\Web_Programming_Assignment_2021-master\Web_Programming_Assignment_2021\Views\Home\Details.cshtml"
                             if (Model.User.AvatarFile != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <img");
            BeginWriteAttribute("src", " src=\"", 895, "\"", 980, 4);
            WriteAttributeValue("", 901, "/Catstagram/User/images/avatars/", 901, 32, true);
#nullable restore
#line 27 "C:\Users\Administrator\Downloads\Web_Programming_Assignment_2021-master\Web_Programming_Assignment_2021-master\Web_Programming_Assignment_2021\Views\Home\Details.cshtml"
WriteAttributeValue("", 933, Model.UserId.ToString(), 933, 24, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 957, "/", 957, 1, true);
#nullable restore
#line 27 "C:\Users\Administrator\Downloads\Web_Programming_Assignment_2021-master\Web_Programming_Assignment_2021-master\Web_Programming_Assignment_2021\Views\Home\Details.cshtml"
WriteAttributeValue("", 958, Model.User.AvatarFile, 958, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"height: 250px; width: 250px\">\n");
#nullable restore
#line 28 "C:\Users\Administrator\Downloads\Web_Programming_Assignment_2021-master\Web_Programming_Assignment_2021-master\Web_Programming_Assignment_2021\Views\Home\Details.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <img src=\"/Catstagram/User/images/noavatar.png\" style=\"width:250px\">\n");
#nullable restore
#line 32 "C:\Users\Administrator\Downloads\Web_Programming_Assignment_2021-master\Web_Programming_Assignment_2021-master\Web_Programming_Assignment_2021\Views\Home\Details.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </div>\n\n                        <div class=\"profile-user-settings\">\n\n                            <h1 class=\"profile-user-name\">");
#nullable restore
#line 38 "C:\Users\Administrator\Downloads\Web_Programming_Assignment_2021-master\Web_Programming_Assignment_2021-master\Web_Programming_Assignment_2021\Views\Home\Details.cshtml"
                                                     Write(Model.User.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\n                        </div>\n                        <div class=\"profile-bio\">\n\n                            <h1 class=\"profile-user-name\">");
#nullable restore
#line 43 "C:\Users\Administrator\Downloads\Web_Programming_Assignment_2021-master\Web_Programming_Assignment_2021-master\Web_Programming_Assignment_2021\Views\Home\Details.cshtml"
                                                     Write(Model.User.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n                            <p><span class=\"profile-real-name\">Status: </span>");
#nullable restore
#line 44 "C:\Users\Administrator\Downloads\Web_Programming_Assignment_2021-master\Web_Programming_Assignment_2021-master\Web_Programming_Assignment_2021\Views\Home\Details.cshtml"
                                                                         Write(Model.User.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>

                        </div>

                    </div>
                </div>
                <div class=""tab-pane fade show active"" id=""post"">
                    <div style=""float:left; width:30%; margin: 10px 170px 10px 30px"">

                        <table style=""text-align:justify"">
                            <tr>
                                <th>Created:</th>
                                <th>Modified:</th>
                            </tr>
                            <tr>
                                <td> ");
#nullable restore
#line 59 "C:\Users\Administrator\Downloads\Web_Programming_Assignment_2021-master\Web_Programming_Assignment_2021-master\Web_Programming_Assignment_2021\Views\Home\Details.cshtml"
                                Write(Html.DisplayFor(model => model.DateCreated));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td> ");
#nullable restore
#line 60 "C:\Users\Administrator\Downloads\Web_Programming_Assignment_2021-master\Web_Programming_Assignment_2021-master\Web_Programming_Assignment_2021\Views\Home\Details.cshtml"
                                Write(Html.DisplayFor(model => model.DateModified));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                            </tr>
                            <tr>
                                <th style=""color:white"">
                                    .
                                </th>
                            </tr>
                            <tr>
                                <th colspan=""2"">
                                    Comment:
                                </th>
                            </tr>
                            <tr>
                                <td colspan=""2"">
                                    ");
#nullable restore
#line 74 "C:\Users\Administrator\Downloads\Web_Programming_Assignment_2021-master\Web_Programming_Assignment_2021-master\Web_Programming_Assignment_2021\Views\Home\Details.cshtml"
                               Write(Html.DisplayFor(model => model.Comment));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <th style=""color:white"">
                                    .
                                </th>
                            </tr>
                            <tr>
                                <th colspan=""2"">
                                    Hastags:
                                </th>
                            </tr>
");
#nullable restore
#line 87 "C:\Users\Administrator\Downloads\Web_Programming_Assignment_2021-master\Web_Programming_Assignment_2021-master\Web_Programming_Assignment_2021\Views\Home\Details.cshtml"
                             foreach (var tag in Model.Hashtag.ToString().Split(' '))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\n                                    <td colspan=\"2\">\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 3668, "\"", 3710, 2);
            WriteAttributeValue("", 3675, "/Home/HashtagGallery/", 3675, 21, true);
#nullable restore
#line 91 "C:\Users\Administrator\Downloads\Web_Programming_Assignment_2021-master\Web_Programming_Assignment_2021-master\Web_Programming_Assignment_2021\Views\Home\Details.cshtml"
WriteAttributeValue("", 3696, tag.Trim('#'), 3696, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 91 "C:\Users\Administrator\Downloads\Web_Programming_Assignment_2021-master\Web_Programming_Assignment_2021-master\Web_Programming_Assignment_2021\Views\Home\Details.cshtml"
                                                                                 Write(tag);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                                    </td>\n\n\n                                </tr>\n");
#nullable restore
#line 96 "C:\Users\Administrator\Downloads\Web_Programming_Assignment_2021-master\Web_Programming_Assignment_2021-master\Web_Programming_Assignment_2021\Views\Home\Details.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </table>\n\n                    </div>\n                    <div style=\"float:left;\">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7cf000148cd39f6bdfc78590e855ecce5c3aca6414902", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3975, "~/Catstagram/User/images/posts/", 3975, 31, true);
#nullable restore
#line 102 "C:\Users\Administrator\Downloads\Web_Programming_Assignment_2021-master\Web_Programming_Assignment_2021-master\Web_Programming_Assignment_2021\Views\Home\Details.cshtml"
AddHtmlAttributeValue("", 4006, Model.PostId.ToString(), 4006, 24, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 4030, "/", 4030, 1, true);
#nullable restore
#line 102 "C:\Users\Administrator\Downloads\Web_Programming_Assignment_2021-master\Web_Programming_Assignment_2021-master\Web_Programming_Assignment_2021\Views\Home\Details.cshtml"
AddHtmlAttributeValue("", 4031, Model.PhotoFile, 4031, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    </div>\n                </div>\n            </div>\n        </div>\n</div>\n\n<div>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7cf000148cd39f6bdfc78590e855ecce5c3aca6417083", async() => {
                WriteLiteral("Back to List &#10509");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Web_Programming_Assignment_2021.Models.Post> Html { get; private set; }
    }
}
#pragma warning restore 1591