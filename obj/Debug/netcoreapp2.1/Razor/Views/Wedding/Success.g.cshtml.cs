#pragma checksum "D:\CodingDojo\csharp\WeddingPlanner\Views\Wedding\Success.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "672e2034a74966d8b53d6abd7b5b77a4191f41db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Wedding_Success), @"mvc.1.0.view", @"/Views/Wedding/Success.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Wedding/Success.cshtml", typeof(AspNetCore.Views_Wedding_Success))]
namespace AspNetCore
{
    #line hidden
    using System;
#line 1 "D:\CodingDojo\csharp\WeddingPlanner\Views\Wedding\Success.cshtml"
using System.Collections.Generic;

#line default
#line hidden
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\CodingDojo\csharp\WeddingPlanner\Views\_ViewImports.cshtml"
using LoginReg;

#line default
#line hidden
#line 2 "D:\CodingDojo\csharp\WeddingPlanner\Views\Wedding\Success.cshtml"
using LoginReg.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"672e2034a74966d8b53d6abd7b5b77a4191f41db", @"/Views/Wedding/Success.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32cffb413b3ff31940133525c56529196ca370a7", @"/Views/_ViewImports.cshtml")]
    public class Views_Wedding_Success : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Wedding>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(81, 212, true);
            WriteLiteral("\r\n<a href =\"/logout\">Logout</a>\r\n<a href =\"/add/wedding\">Add Wedding</a>\r\n    <table style=\"width:50%\">\r\n    <tr>\r\n    <th>Wedding</th>\r\n    <th>Date</th> \r\n    <th>Guests</th>\r\n    <th>Action</th>\r\n    </tr>\r\n\r\n");
            EndContext();
#line 15 "D:\CodingDojo\csharp\WeddingPlanner\Views\Wedding\Success.cshtml"
     foreach(var w in @Model)
    {

#line default
#line hidden
            BeginContext(331, 18, true);
            WriteLiteral("  <tr>\r\n    <td><a");
            EndContext();
            BeginWriteAttribute("href", " href = \"", 349, "\"", 376, 2);
            WriteAttributeValue("", 358, "/view/", 358, 6, true);
#line 18 "D:\CodingDojo\csharp\WeddingPlanner\Views\Wedding\Success.cshtml"
WriteAttributeValue("", 364, w.WeddingId, 364, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(377, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(379, 11, false);
#line 18 "D:\CodingDojo\csharp\WeddingPlanner\Views\Wedding\Success.cshtml"
                                  Write(w.WedderOne);

#line default
#line hidden
            EndContext();
            BeginContext(390, 3, true);
            WriteLiteral(" & ");
            EndContext();
            BeginContext(394, 11, false);
#line 18 "D:\CodingDojo\csharp\WeddingPlanner\Views\Wedding\Success.cshtml"
                                                 Write(w.WedderTwo);

#line default
#line hidden
            EndContext();
            BeginContext(405, 19, true);
            WriteLiteral("</a></td>\r\n    <td>");
            EndContext();
            BeginContext(425, 6, false);
#line 19 "D:\CodingDojo\csharp\WeddingPlanner\Views\Wedding\Success.cshtml"
   Write(w.Date);

#line default
#line hidden
            EndContext();
            BeginContext(431, 15, true);
            WriteLiteral("</td>\r\n    <td>");
            EndContext();
            BeginContext(447, 14, false);
#line 20 "D:\CodingDojo\csharp\WeddingPlanner\Views\Wedding\Success.cshtml"
   Write(w.Guests.Count);

#line default
#line hidden
            EndContext();
            BeginContext(461, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 21 "D:\CodingDojo\csharp\WeddingPlanner\Views\Wedding\Success.cshtml"
     if(@w.Guests.Any(g => g.UserId == @ViewBag.UserId))
    {

#line default
#line hidden
            BeginContext(533, 10, true);
            WriteLiteral("    <td><a");
            EndContext();
            BeginWriteAttribute("href", " href =\"", 543, "\"", 587, 4);
            WriteAttributeValue("", 551, "/remove/", 551, 8, true);
#line 23 "D:\CodingDojo\csharp\WeddingPlanner\Views\Wedding\Success.cshtml"
WriteAttributeValue("", 559, ViewBag.UserId, 559, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 574, "/", 574, 1, true);
#line 23 "D:\CodingDojo\csharp\WeddingPlanner\Views\Wedding\Success.cshtml"
WriteAttributeValue("", 575, w.WeddingId, 575, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(588, 19, true);
            WriteLiteral(">Un-RSPV</a></td>\r\n");
            EndContext();
#line 24 "D:\CodingDojo\csharp\WeddingPlanner\Views\Wedding\Success.cshtml"
    }else if(@w.Guests.Count ==0)
    {

#line default
#line hidden
            BeginContext(649, 14, true);
            WriteLiteral("        <td><a");
            EndContext();
            BeginWriteAttribute("href", " href =\"", 663, "\"", 704, 4);
            WriteAttributeValue("", 671, "/add/", 671, 5, true);
#line 26 "D:\CodingDojo\csharp\WeddingPlanner\Views\Wedding\Success.cshtml"
WriteAttributeValue("", 676, ViewBag.UserId, 676, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 691, "/", 691, 1, true);
#line 26 "D:\CodingDojo\csharp\WeddingPlanner\Views\Wedding\Success.cshtml"
WriteAttributeValue("", 692, w.WeddingId, 692, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(705, 16, true);
            WriteLiteral(">RSPV</a></td>\r\n");
            EndContext();
#line 27 "D:\CodingDojo\csharp\WeddingPlanner\Views\Wedding\Success.cshtml"
    } 
    else
    {

#line default
#line hidden
            BeginContext(746, 10, true);
            WriteLiteral("    <td><a");
            EndContext();
            BeginWriteAttribute("href", " href =\"", 756, "\"", 797, 4);
            WriteAttributeValue("", 764, "/add/", 764, 5, true);
#line 30 "D:\CodingDojo\csharp\WeddingPlanner\Views\Wedding\Success.cshtml"
WriteAttributeValue("", 769, ViewBag.UserId, 769, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 784, "/", 784, 1, true);
#line 30 "D:\CodingDojo\csharp\WeddingPlanner\Views\Wedding\Success.cshtml"
WriteAttributeValue("", 785, w.WeddingId, 785, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(798, 16, true);
            WriteLiteral(">RSPV</a></td>\r\n");
            EndContext();
#line 31 "D:\CodingDojo\csharp\WeddingPlanner\Views\Wedding\Success.cshtml"
    }

#line default
#line hidden
            BeginContext(821, 9, true);
            WriteLiteral("  </tr>\r\n");
            EndContext();
#line 33 "D:\CodingDojo\csharp\WeddingPlanner\Views\Wedding\Success.cshtml"

    }

#line default
#line hidden
            BeginContext(839, 18, true);
            WriteLiteral("  \r\n\r\n  </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Wedding>> Html { get; private set; }
    }
}
#pragma warning restore 1591
