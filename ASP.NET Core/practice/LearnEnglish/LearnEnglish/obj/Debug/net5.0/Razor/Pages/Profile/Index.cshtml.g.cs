#pragma checksum "C:\Users\aleks\OneDrive\Desktop\Илья\ASP.NET Core\practice\LearnEnglish\LearnEnglish\Pages\Profile\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac3e3633f314d5337441078af178a01da675fa1d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(EmptyRazorPagesApp.Pages.Profile.Pages_Profile_Index), @"mvc.1.0.razor-page", @"/Pages/Profile/Index.cshtml")]
namespace EmptyRazorPagesApp.Pages.Profile
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
#line 1 "C:\Users\aleks\OneDrive\Desktop\Илья\ASP.NET Core\practice\LearnEnglish\LearnEnglish\Pages\_ViewImports.cshtml"
using EmptyRazorPagesApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac3e3633f314d5337441078af178a01da675fa1d", @"/Pages/Profile/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"096d39a7a3d184fc0e9f8241fe782213141e8b94", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Profile_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac3e3633f314d5337441078af178a01da675fa1d3586", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"css/profile-style.css\">\r\n    <link rel=\"stylesheet\" href=\"css/modal-style.css\">\r\n    <title>Profile</title>\r\n");
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
            WriteLiteral(@"
<div class=""main-profile"">
    <div class=""container"">
        <div class=""profile__body"">
            <div class=""profile-body__row"">
                <div class=""profile__info"">
                    <div class=""profile-cover"">
                        <img src=""https://sun9-78.userapi.com/impg/7l4enVTgAtgOUCSUXV1bxRhA-EJyiNsAvJ0iXg/NTgZYE_Ijlg.jpg?size=899x673&quality=95&sign=a508813fa4a792f15c198ab1f933d02a&type=album"" alt=""profile cover"">
                    </div>
                    <div class=""profile-desc"">
                        <h3 class=""title"">");
#nullable restore
#line 18 "C:\Users\aleks\OneDrive\Desktop\Илья\ASP.NET Core\practice\LearnEnglish\LearnEnglish\Pages\Profile\Index.cshtml"
                                     Write(Model.UserLogin);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        <p class=\"text\">English: Undefined</p>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 896, "\"", 943, 2);
            WriteAttributeValue("", 903, "Profile/Edit?profileId=", 903, 23, true);
#nullable restore
#line 20 "C:\Users\aleks\OneDrive\Desktop\Илья\ASP.NET Core\practice\LearnEnglish\LearnEnglish\Pages\Profile\Index.cshtml"
WriteAttributeValue("", 926, Model.Profile.Id, 926, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn blue edit-btn\">Edit profile</a>\r\n                        <p class=\"text\">");
#nullable restore
#line 21 "C:\Users\aleks\OneDrive\Desktop\Илья\ASP.NET Core\practice\LearnEnglish\LearnEnglish\Pages\Profile\Index.cshtml"
                                   Write(Model?.Profile?.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    </div>
                </div>
                <div class=""profile__body"">
                    <div class=""profile-body__row"">
                        <div class=""profile__dictionaries"">
                            <h3 class=""title"">Dictionaries</h3>
                            <a href=""#"" class=""btn blue create-dictionary open-modal"">Add new</a>
                            <div class=""dictionaries__container"">
");
#nullable restore
#line 30 "C:\Users\aleks\OneDrive\Desktop\Илья\ASP.NET Core\practice\LearnEnglish\LearnEnglish\Pages\Profile\Index.cshtml"
                                 foreach (var dic in @Model.UserDictionaries) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a");
            BeginWriteAttribute("href", " href=\"", 1624, "\"", 1652, 2);
            WriteAttributeValue("", 1631, "Dictionary?id=", 1631, 14, true);
#nullable restore
#line 31 "C:\Users\aleks\OneDrive\Desktop\Илья\ASP.NET Core\practice\LearnEnglish\LearnEnglish\Pages\Profile\Index.cshtml"
WriteAttributeValue("", 1645, dic.Id, 1645, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn\">");
#nullable restore
#line 31 "C:\Users\aleks\OneDrive\Desktop\Илья\ASP.NET Core\practice\LearnEnglish\LearnEnglish\Pages\Profile\Index.cshtml"
                                                                           Write(dic.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 32 "C:\Users\aleks\OneDrive\Desktop\Илья\ASP.NET Core\practice\LearnEnglish\LearnEnglish\Pages\Profile\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <div id=\"myModal\" class=\"modal\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac3e3633f314d5337441078af178a01da675fa1d8612", async() => {
                WriteLiteral(@"
                            <div class=""modal-content"">
                                <span class=""close"">&times;</span>
                                <div class=""modal-content__header"">
                                    <h3 class=""title"">Create new dictionary</h3>
                                </div>
                                <div class=""modal-content__body"">
                                    <p class=""text"">Title</p>
                                    <input name=""dictionaryTitle"" type=""text"" class=""textbox"" placeholder=""Dictionary title"">
                                </div>
                                <div class=""modal-content__footer"">
                                    <input type=""submit"" value=""Create"" class=""btn green""/>
                                </div>
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
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<script src=\"js/modal-script.js\"></script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LearnEnglish.Pages.Profile.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LearnEnglish.Pages.Profile.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LearnEnglish.Pages.Profile.IndexModel>)PageContext?.ViewData;
        public LearnEnglish.Pages.Profile.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
