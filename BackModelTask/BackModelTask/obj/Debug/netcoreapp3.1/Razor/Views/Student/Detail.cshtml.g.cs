#pragma checksum "C:\Users\umid_\source\repos\BackModelTask\BackModelTask\Views\Student\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6cd7a215e7088cdba20615cf15fdf28f8fa2222"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Detail), @"mvc.1.0.view", @"/Views/Student/Detail.cshtml")]
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
#line 1 "C:\Users\umid_\source\repos\BackModelTask\BackModelTask\Views\_ViewImports.cshtml"
using BackModelTask.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\umid_\source\repos\BackModelTask\BackModelTask\Views\_ViewImports.cshtml"
using BackModelTask.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6cd7a215e7088cdba20615cf15fdf28f8fa2222", @"/Views/Student/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c755598e7d29ac33921f3fc29637c7599d5ae5fa", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Student_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Student>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Student detail sehifesi</h1>\r\n\r\n<p>Students Info</p>\r\n<ul>\r\n    <li>ID:");
#nullable restore
#line 6 "C:\Users\umid_\source\repos\BackModelTask\BackModelTask\Views\Student\Detail.cshtml"
      Write(Model.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Name:");
#nullable restore
#line 7 "C:\Users\umid_\source\repos\BackModelTask\BackModelTask\Views\Student\Detail.cshtml"
        Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Point:");
#nullable restore
#line 8 "C:\Users\umid_\source\repos\BackModelTask\BackModelTask\Views\Student\Detail.cshtml"
         Write(Model.Point);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Student> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
