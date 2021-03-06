#pragma checksum "C:\Users\murat\Desktop\Projeler\ToDoNKatman\ToDo.UI.MVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de1dc1d1af44735f4756e3d338c79b822d2a7ce5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 2 "C:\Users\murat\Desktop\Projeler\ToDoNKatman\ToDo.UI.MVC\Views\_ViewImports.cshtml"
using ToDo.ViewModel.PeopleViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\murat\Desktop\Projeler\ToDoNKatman\ToDo.UI.MVC\Views\_ViewImports.cshtml"
using ToDo.ViewModel.ToDoItemViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\murat\Desktop\Projeler\ToDoNKatman\ToDo.UI.MVC\Views\_ViewImports.cshtml"
using ToDo.ViewModel.HomeViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\murat\Desktop\Projeler\ToDoNKatman\ToDo.UI.MVC\Views\_ViewImports.cshtml"
using ToDo.ViewModel.Enums;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de1dc1d1af44735f4756e3d338c79b822d2a7ce5", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd4542cb2911be283ee033ce4dc31047a094a5bb", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\murat\Desktop\Projeler\ToDoNKatman\ToDo.UI.MVC\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"



<div class=""container"">

    <div class=""row"">

        <div class=""col-sm"">

            <div class=""card bg-light mb-3"" style=""max-width: 18rem;"">
                <div class=""card-header"">Total People</div>
                <div class=""card-body"">
                   
                        <h5 class=""card-title"">");
#nullable restore
#line 18 "C:\Users\murat\Desktop\Projeler\ToDoNKatman\ToDo.UI.MVC\Views\Home\Index.cshtml"
                                          Write(ViewBag.UserToTal.Data.PeopleTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                    
                </div>
            </div>

        </div>

        
        <div class=""col-sm"">

            <div class=""card text-white bg-secondary mb-3"" style=""max-width: 18rem;"">
                <div class=""card-header"">Total ToDo</div>
                <div class=""card-body"">
");
#nullable restore
#line 31 "C:\Users\murat\Desktop\Projeler\ToDoNKatman\ToDo.UI.MVC\Views\Home\Index.cshtml"
                     foreach (var item in ViewBag.ToDoToTal.Data)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h5 class=\"card-title\">");
#nullable restore
#line 33 "C:\Users\murat\Desktop\Projeler\ToDoNKatman\ToDo.UI.MVC\Views\Home\Index.cshtml"
                                          Write(item.ToDoTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 34 "C:\Users\murat\Desktop\Projeler\ToDoNKatman\ToDo.UI.MVC\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>

        </div>





        <div class=""col-sm"">

            <div class=""card text-white bg-info mb-3"" style=""max-width: 18rem;"">
                <div class=""card-header"">Total Doing</div>
                <div class=""card-body"">
");
#nullable restore
#line 49 "C:\Users\murat\Desktop\Projeler\ToDoNKatman\ToDo.UI.MVC\Views\Home\Index.cshtml"
                     foreach (var item in ViewBag.ToDoToTal.Data)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h5 class=\"card-title\">");
#nullable restore
#line 51 "C:\Users\murat\Desktop\Projeler\ToDoNKatman\ToDo.UI.MVC\Views\Home\Index.cshtml"
                                          Write(item.DoingToTal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 52 "C:\Users\murat\Desktop\Projeler\ToDoNKatman\ToDo.UI.MVC\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>

        </div>

        <div class=""col-sm"">

            <div class=""card bg-light mb-3"" style=""max-width: 18rem;"">
                <div class=""card-header"">Total Done</div>
                <div class=""card-body"">
");
#nullable restore
#line 63 "C:\Users\murat\Desktop\Projeler\ToDoNKatman\ToDo.UI.MVC\Views\Home\Index.cshtml"
                     foreach (var item in ViewBag.ToDoToTal.Data)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h5 class=\"card-title\">");
#nullable restore
#line 65 "C:\Users\murat\Desktop\Projeler\ToDoNKatman\ToDo.UI.MVC\Views\Home\Index.cshtml"
                                          Write(item.DoneToTal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 66 "C:\Users\murat\Desktop\Projeler\ToDoNKatman\ToDo.UI.MVC\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>

        </div>

    </div>

</div>

<div class=""container"">
<div class=""card text-center"">
  <div class=""card-header"">
    Software Developer
  </div>
  <div class=""card-body"">
    <h5 class=""card-title"">ToDo N-tier Core Project</h5>
    <p class=""card-text"">Bootstrap - Mssql - Core</p>
    <a href=""www.murathantandogan.com"" target=""_blank"" class=""btn btn-primary"">Murathan Tando??an</a>
  </div>
</div>
</div>
");
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
