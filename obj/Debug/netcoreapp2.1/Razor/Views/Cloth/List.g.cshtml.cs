#pragma checksum "C:\Users\User\source\repos\YourStore\Views\Cloth\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10044a66e2304321eadc401bf0489ec01cef4cbd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cloth_List), @"mvc.1.0.view", @"/Views/Cloth/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cloth/List.cshtml", typeof(AspNetCore.Views_Cloth_List))]
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
#line 1 "C:\Users\User\source\repos\YourStore\Views\_ViewImports.cshtml"
using YourStore.ViewModels;

#line default
#line hidden
#line 2 "C:\Users\User\source\repos\YourStore\Views\_ViewImports.cshtml"
using YourStore.Data.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10044a66e2304321eadc401bf0489ec01cef4cbd", @"/Views/Cloth/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c86609ea441f3e2ae949b5aeb5c57cc425875755", @"/Views/_ViewImports.cshtml")]
    public class Views_Cloth_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ClothListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(28, 35, true);
            WriteLiteral("\r\n    <div class=\"row marginTop\">\r\n");
            EndContext();
#line 4 "C:\Users\User\source\repos\YourStore\Views\Cloth\List.cshtml"
         foreach (var cloth in Model.Clothes)
        {
            

#line default
#line hidden
            BeginContext(134, 37, false);
#line 6 "C:\Users\User\source\repos\YourStore\Views\Cloth\List.cshtml"
       Write(Html.Partial("ClothesSummary", cloth));

#line default
#line hidden
            EndContext();
#line 6 "C:\Users\User\source\repos\YourStore\Views\Cloth\List.cshtml"
                                                  
        }

#line default
#line hidden
            BeginContext(184, 11, true);
            WriteLiteral("    </div> ");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ClothListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
