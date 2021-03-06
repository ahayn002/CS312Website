#pragma checksum "C:\Users\drewh\source\repos\CS312CustomWebsite\CS312CustomWebsite\Pages\Statistics.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2e7e4a598503bbbd7ef769c2b6eee7c6d47efab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CS312CustomWebsite.Pages.Pages_Statistics), @"mvc.1.0.razor-page", @"/Pages/Statistics.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Statistics.cshtml", typeof(CS312CustomWebsite.Pages.Pages_Statistics), null)]
namespace CS312CustomWebsite.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\drewh\source\repos\CS312CustomWebsite\CS312CustomWebsite\Pages\_ViewImports.cshtml"
using CS312CustomWebsite;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2e7e4a598503bbbd7ef769c2b6eee7c6d47efab", @"/Pages/Statistics.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"801baac040b25611e28b4bb1c71b4c84b4f23f1d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Statistics : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\drewh\source\repos\CS312CustomWebsite\CS312CustomWebsite\Pages\Statistics.cshtml"
  
    ViewData["Title"] = "Death Penalty Statistics";

#line default
#line hidden
            BeginContext(91, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(96, 17, false);
#line 6 "C:\Users\drewh\source\repos\CS312CustomWebsite\CS312CustomWebsite\Pages\Statistics.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(113, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(125, 13, false);
#line 7 "C:\Users\drewh\source\repos\CS312CustomWebsite\CS312CustomWebsite\Pages\Statistics.cshtml"
Write(Model.Message);

#line default
#line hidden
            EndContext();
            BeginContext(138, 1904, true);
            WriteLiteral(@"</h3>

<p>If you want to see if the death penalty is allowed in your state, check out <a href=""https://deathpenaltyinfo.org/state_by_state"">the State-by-State Database</a>, provided by the Death Penalty Information Center.</p>
<ul>
    <h4>The Totals</h4>
    <li>
        Since the current-era of execution policies began in 1976, there have been 1488 executions. There was a gradual increase till executions peaked in 1999, with 98 executions being carried out. After this peak, executions gradually decreased until 2016, where they dropped to 20. Since then, totals have hovered around 20-25 annually.
    </li>
    <h4>Racial Distribution</h4>
    <li>
        As if the death penalty isn’t controversial enough, let’s bring race into. Nearly 56% of defendants executed are white. Roughly 34% are black. The remaining 10% are other minorities. Looking at victims, roughly 50% of murder victims are white. However, over 75% of death penalty sentences involved a white murder victim. Apparently, the lesson learn");
            WriteLiteral(@"ed here is that if you’re going to murder someone, you should try to make sure they’re not a white person. Also, don’t murder someone.
    </li>
    <h4>Near Misses</h4>
    <li>
        Since 1973, there have been 164 inmates on death row that have been exonerated from their crimes as new evidence has surfaced.
    </li>
    <h4>Weapon of Choice</h4>
    <li>
        Of the 1488 executions committed, 1311 have been from lethal injection. Electruction accounts for 160, gas chambers composed 11, 3 from hanging, and 3 from firing squad.
    </li>
    <h4>Don't Forget the Women and Children</h4>
    <li>
        Currently, 53 women sit on death row. Sixteen women have been executed since 1976. There have been 22 executions as a result of crimes committed as juveniles. However, Roper v. Simmons ended the death penalty for children in 2005
    </li>
</ul>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StatisticsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<StatisticsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<StatisticsModel>)PageContext?.ViewData;
        public StatisticsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
