#pragma checksum "/Users/Guest/Desktop/FriendLetter/FriendLetter.Solution/FriendLetter/Views/Home/Postcard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9fd0e8592614b539ff44c825c80fb59e2ea9e2c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Postcard), @"mvc.1.0.view", @"/Views/Home/Postcard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Postcard.cshtml", typeof(AspNetCore.Views_Home_Postcard))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fd0e8592614b539ff44c825c80fb59e2ea9e2c3", @"/Views/Home/Postcard.cshtml")]
    public class Views_Home_Postcard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 34, true);
            WriteLiteral("<h1>Hello From Afar</h1>\r\n<p>Dear ");
            EndContext();
            BeginContext(35, 20, false);
#line 2 "/Users/Guest/Desktop/FriendLetter/FriendLetter.Solution/FriendLetter/Views/Home/Postcard.cshtml"
   Write(Model.GetRecipient());

#line default
#line hidden
            EndContext();
            BeginContext(55, 89, true);
            WriteLiteral(",</p>\r\n<p>How are you? I hope that you are having a nice weekend. I\'m vacationing in the ");
            EndContext();
            BeginContext(145, 25, false);
#line 3 "/Users/Guest/Desktop/FriendLetter/FriendLetter.Solution/FriendLetter/Views/Home/Postcard.cshtml"
                                                                             Write(Model.GetRandomLocation());

#line default
#line hidden
            EndContext();
            BeginContext(170, 37, true);
            WriteLiteral(" while I learn programming! </p>\r\n<p>");
            EndContext();
            BeginContext(208, 20, false);
#line 4 "/Users/Guest/Desktop/FriendLetter/FriendLetter.Solution/FriendLetter/Views/Home/Postcard.cshtml"
Write(Model.GetRecipient());

#line default
#line hidden
            EndContext();
            BeginContext(228, 219, true);
            WriteLiteral(", you would not believe how cold it is here. I should have gone to Hawaii instead.</p>\r\n<p>But I like programming a lot, so I\'ve got that going for me. </p>\r\n<p>Looking forward to seeing you soon. I\'ll bring you back a ");
            EndContext();
            BeginContext(448, 21, false);
#line 6 "/Users/Guest/Desktop/FriendLetter/FriendLetter.Solution/FriendLetter/Views/Home/Postcard.cshtml"
                                                        Write(Model.GetRandomSouv());

#line default
#line hidden
            EndContext();
            BeginContext(469, 46, true);
            WriteLiteral(" . </p>\r\n<p>Cheers,</p>\r\n<p>Travel Enthusiast ");
            EndContext();
            BeginContext(516, 17, false);
#line 8 "/Users/Guest/Desktop/FriendLetter/FriendLetter.Solution/FriendLetter/Views/Home/Postcard.cshtml"
                Write(Model.GetSender());

#line default
#line hidden
            EndContext();
            BeginContext(533, 6, true);
            WriteLiteral("</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
