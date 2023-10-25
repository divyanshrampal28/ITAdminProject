#pragma checksum "C:\Users\NamanMalik\Desktop\wed_morn\ITAdminProject\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "149a4cf496628d7ae2794e756a47030127cad1d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Index), @"mvc.1.0.view", @"/Views/Dashboard/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Dashboard/Index.cshtml", typeof(AspNetCore.Views_Dashboard_Index))]
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
#line 1 "C:\Users\NamanMalik\Desktop\wed_morn\ITAdminProject\Views\_ViewImports.cshtml"
using ITAdminProject;

#line default
#line hidden
#line 2 "C:\Users\NamanMalik\Desktop\wed_morn\ITAdminProject\Views\_ViewImports.cshtml"
using ITAdminProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"149a4cf496628d7ae2794e756a47030127cad1d0", @"/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b350f1b4def0de1b5655bb6d12956f8730e813e5", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ITAdminProject.Models.Dashboard>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 894, true);
            WriteLiteral(@"
<div id=""empcount"">
    <div>Users</div>
</div>
<div id=""devnum"">
    <div>No. of Devices</div>
</div>
<div id=""unallotednum"">
    <div>Unalloted Devices</div>
</div>
<div style=""width: 80%; margin: 0 auto;"">
    <canvas id=""myPieChart""></canvas>
    <canvas id=""myBarChart"" width=""400"" height=""200""></canvas>
</div>




<script src=""https://cdn.jsdelivr.net/npm/chart.js""></script>
<script src=""https://code.jquery.com/jquery-3.6.0.min.js""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/Chart.is/2.8.0/Chart.bundle.min.js""></script>

<script>
    function getRandomColor() {
        var letters = '0123456789ABCDEF';
        var color = '#';
        for (var i = 0; i < 6; i++) {
            color += letters[Math.floor(Math.random() * 16)];
        }
        return color;
    }

    $(document).ready(function () {
        var pieChartData = ");
            EndContext();
            BeginContext(935, 39, false);
#line 35 "C:\Users\NamanMalik\Desktop\wed_morn\ITAdminProject\Views\Dashboard\Index.cshtml"
                      Write(Html.Raw(Json.Serialize(Model.pielist)));

#line default
#line hidden
            EndContext();
            BeginContext(974, 29, true);
            WriteLiteral(";\r\n\r\n\r\n        var empdata = ");
            EndContext();
            BeginContext(1004, 35, false);
#line 38 "C:\Users\NamanMalik\Desktop\wed_morn\ITAdminProject\Views\Dashboard\Index.cshtml"
                 Write(Html.Raw(Json.Serialize(Model.emp)));

#line default
#line hidden
            EndContext();
            BeginContext(1039, 219, true);
            WriteLiteral(";\r\n\r\n        var empticket = document.getElementById(\"empcount\");\r\n\r\n        var tkt = document.createElement(\"div\");\r\n        tkt.innerHTML = empdata;\r\n        empticket.appendChild(tkt);\r\n\r\n\r\n\r\n         var devdata = ");
            EndContext();
            BeginContext(1259, 35, false);
#line 48 "C:\Users\NamanMalik\Desktop\wed_morn\ITAdminProject\Views\Dashboard\Index.cshtml"
                  Write(Html.Raw(Json.Serialize(Model.dev)));

#line default
#line hidden
            EndContext();
            BeginContext(1294, 229, true);
            WriteLiteral(";\r\n\r\n        var devticket = document.getElementById(\"devnum\");\r\n\r\n        var devtkt = document.createElement(\"div\");\r\n        devtkt.innerHTML = devdata;\r\n        devticket.appendChild(devtkt);\r\n\r\n          var unalloteddata = ");
            EndContext();
            BeginContext(1524, 46, false);
#line 56 "C:\Users\NamanMalik\Desktop\wed_morn\ITAdminProject\Views\Dashboard\Index.cshtml"
                         Write(Html.Raw(Json.Serialize(Model.unalottedcount)));

#line default
#line hidden
            EndContext();
            BeginContext(1570, 1099, true);
            WriteLiteral(@";

        var unallotedticket = document.getElementById(""unallotednum"");

        var unallotedtkt = document.createElement(""div"");
        unallotedtkt.innerHTML = unalloteddata;
        unallotedticket.appendChild(unallotedtkt);

        var labels = pieChartData.map(item => item.firstName);
        var dataValues = pieChartData.map(item => item.deviceCount);

        var colors = labels.map(item => getRandomColor());

        var ctx = document.getElementById(""myPieChart"").getContext('2d');

        var myPieChart = new Chart(ctx, {
            type: 'pie',
            data: {
                labels: labels,
                datasets: [{
                    data: dataValues,
                    backgroundColor: colors,
                    borderColor: colors,
                    borderWidth: 1
                }]
            },
            options: {
            }
        });

        var cht2 = document.getElementById(""myBarChart"").getContext('2d');

    var myBarChart = new");
            WriteLiteral(" Chart(cht2, {\r\n        type: \'bar\',\r\n        data: {\r\n            labels: ");
            EndContext();
            BeginContext(2670, 63, false);
#line 91 "C:\Users\NamanMalik\Desktop\wed_morn\ITAdminProject\Views\Dashboard\Index.cshtml"
               Write(Html.Raw(Json.Serialize(Model.barlist.Select(c => c.Category))));

#line default
#line hidden
            EndContext();
            BeginContext(2733, 88, true);
            WriteLiteral(",\r\n            datasets: [{\r\n                label: \'Bar Chart\',\r\n                data: ");
            EndContext();
            BeginContext(2822, 68, false);
#line 94 "C:\Users\NamanMalik\Desktop\wed_morn\ITAdminProject\Views\Dashboard\Index.cshtml"
                 Write(Html.Raw(Json.Serialize(Model.barlist.Select(c => c.CategoryCount))));

#line default
#line hidden
            EndContext();
            BeginContext(2890, 455, true);
            WriteLiteral(@",
                backgroundColor: 'rgba(75, 192, 192, 0.2)',
                borderColor: 'rgba(75, 192, 192, 1)',
                borderWidth: 1
            }]
        },
        options: {
            title: {
                display: true,
                text: ""Category Details""
            },
            scales: {
                y: {
                    beginAtZero: true
                }
            }
        }
    });



");
            EndContext();
            BeginContext(4266, 18, true);
            WriteLiteral("    });\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ITAdminProject.Models.Dashboard> Html { get; private set; }
    }
}
#pragma warning restore 1591