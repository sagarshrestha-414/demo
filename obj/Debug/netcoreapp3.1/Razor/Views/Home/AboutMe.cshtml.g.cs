#pragma checksum "C:\Users\sagar\Source\Repos\TestingNetNetCore\TestingNetNetCore\Views\Home\AboutMe.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ba253d3e54a12555263e60f6a02156e90eea161"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AboutMe), @"mvc.1.0.view", @"/Views/Home/AboutMe.cshtml")]
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
#line 1 "C:\Users\sagar\Source\Repos\TestingNetNetCore\TestingNetNetCore\Views\_ViewImports.cshtml"
using TestingNetNetCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sagar\Source\Repos\TestingNetNetCore\TestingNetNetCore\Views\_ViewImports.cshtml"
using TestingNetNetCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ba253d3e54a12555263e60f6a02156e90eea161", @"/Views/Home/AboutMe.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec2bd435182ba9a1e02efbdac9b340bc0170895b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AboutMe : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "C:\Users\sagar\Source\Repos\TestingNetNetCore\TestingNetNetCore\Views\Home\AboutMe.cshtml"
  
    ViewData["Title"] = "AboutMe";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>AboutMe</h1>
<table border=""1"">
    <tr>
        <td>Name</td>
        <td>Address</td>
        <td>Age</td>
        <td>Ethnicity</td>
        <td>Language</td>
    </tr>
    <tr>
        <td>Bhusan Dahal</td>
        <td>Kathmandu</td>
        <td>55</td>
        <td>Bhramin</td>
        <td>Nepali</td>
    </tr>
</table>

");
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
