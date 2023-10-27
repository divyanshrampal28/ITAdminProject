#pragma checksum "C:\Users\DivyanshRampal\Documents\ITAdmin2\ITAdminProject\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a495979749b9af5cc24a6bf5cc48bae076b37bb1"
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
#line 1 "C:\Users\DivyanshRampal\Documents\ITAdmin2\ITAdminProject\Views\_ViewImports.cshtml"
using ITAdminProject;

#line default
#line hidden
#line 2 "C:\Users\DivyanshRampal\Documents\ITAdmin2\ITAdminProject\Views\_ViewImports.cshtml"
using ITAdminProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a495979749b9af5cc24a6bf5cc48bae076b37bb1", @"/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b350f1b4def0de1b5655bb6d12956f8730e813e5", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ITAdminProject.Models.Dashboard>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(10447, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(13925, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(13967, 2559, true);
            WriteLiteral(@"

<style>
    .kuchbhi {
        margin-top: 5%;
        padding: 15px;
        font-size: 18px;
        background: #dbdfe5;
        margin-bottom: 4%;
        margin-left: 6.5%;
        
    }

    .sabkuch {
        margin-top: 5%;
        padding: 15px;
        font-size: 18px;
        background: pink;
        margin-bottom: 4%;
        margin-left: 6.5%;
    }

    .kuchnahi {
        margin-top: 5%;
        padding: 15px;
        font-size: 18px;
        background: red;
        margin-bottom: 4%;
        margin-left: 6.5%;
    }
</style>

<div class=""row"">

    <div class=""col-sm-3 kuchbhi"">
        <div id=""empcount"">
            <div>Users</div>
        </div>
    </div>




    <div class=""col-sm-3 sabkuch"">
        <div id=""devnum"">
            <div>No. of Devices</div>
        </div>
    </div>



    <div class=""col-sm-3 kuchnahi"">
        <div id=""unallotednum"">
            <div>Unalloted Devices</div>
        </div>
    </div>

</div>
");
            WriteLiteral(@"





    <div class=""row"">
        <div class=""col-md-8"">
            <div class=""panel panel-default"">
                <div class=""panel-heading"">
                    <h2 class=""panel-title"" style=""text-align:center; margin-bottom:5px;"">Categories</h2>
                    <canvas id=""myBarChart"" width=""200"" height=""100""></canvas>
                </div>
            </div>
        </div>
        <div class=""col-md-4"">
            <div class=""panel panel-default"">
                <div class=""panel-heading"">
                    <div class=""panel panel-default"">
                        <div class=""panel-heading"">
                            <h3 class=""panel-title"">Alloted Employees</h3>
                        </div>
                        <div class=""panel-body"">
                            <canvas id=""myPieChart""></canvas>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>


    <div class=""row"">
       ");
            WriteLiteral(@" <div class=""col-sm-8"">
            <div class=""demo-content scroll"" style=""min-height: 400px;"">
                <table class=""table table-striped table-bordered"">
                    <thead>
                        <tr>
                            <th>Category Name</th>
                            <th>Action</th>
                            <th>Updated At</th>
                            <th>Updated By</th>
                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 495 "C:\Users\DivyanshRampal\Documents\ITAdmin2\ITAdminProject\Views\Dashboard\Index.cshtml"
                         foreach (var item in Model.glist)
                        {

#line default
#line hidden
            BeginContext(16613, 70, true);
            WriteLiteral("                            <tr>\r\n                                <td>");
            EndContext();
            BeginContext(16684, 17, false);
#line 498 "C:\Users\DivyanshRampal\Documents\ITAdmin2\ITAdminProject\Views\Dashboard\Index.cshtml"
                               Write(item.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(16701, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(16745, 11, false);
#line 499 "C:\Users\DivyanshRampal\Documents\ITAdmin2\ITAdminProject\Views\Dashboard\Index.cshtml"
                               Write(item.Action);

#line default
#line hidden
            EndContext();
            BeginContext(16756, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(16800, 17, false);
#line 500 "C:\Users\DivyanshRampal\Documents\ITAdmin2\ITAdminProject\Views\Dashboard\Index.cshtml"
                               Write(item.UpdatedAtUtc);

#line default
#line hidden
            EndContext();
            BeginContext(16817, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(16861, 14, false);
#line 501 "C:\Users\DivyanshRampal\Documents\ITAdmin2\ITAdminProject\Views\Dashboard\Index.cshtml"
                               Write(item.UpdatedBy);

#line default
#line hidden
            EndContext();
            BeginContext(16875, 42, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n");
            EndContext();
#line 503 "C:\Users\DivyanshRampal\Documents\ITAdmin2\ITAdminProject\Views\Dashboard\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(16944, 1168, true);
            WriteLiteral(@"                    </tbody>
                </table>
            </div>
        </div>

        <div class="" col-md-4 col-sm-12 well pull-right-lg"" style=""border:0px solid; min-height: 400px;"">
            <p class=""well"" style=""padding:10px; margin-bottom:2px; text-align:center;"">
                Device History
            </p>
            <div class=""col-md-12"" style=""padding:0px;"">
                <br>
                <table class=""table table-bordered table-style table-responsive"">
                    <thead>
                        <tr>
                            <th>
                                <div class=""dateAndButton"">
                                    <button id=""left"">left</button>
                                    <div id=""calender""></div>
                                    <button id=""right"">right</button>
                                </div>
                            </th>
                        </tr>
                    </thead>
                    <tbody ");
            WriteLiteral("id=\"moreRows\"></tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"col-md-4\">\r\n\r\n    </div>\r\n\r\n");
            EndContext();
            BeginContext(18158, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(18322, 1538, true);
            WriteLiteral(@"


    <style>
        .table-style .today {
            background: #2A3F54;
            color: #ffffff;
        }

        .table-style th:nth-of-type(7), td:nth-of-type(7) {
            color: blue;
        }

        .table-style th:nth-of-type(1), td:nth-of-type(1) {
            color: red;
        }

        .table-style tr:first-child th {
            background-color: #F6F6F6;
            text-align: center;
            font-size: 15px;
        }

        .dateAndButton {
            display: flex;
            justify-content: space-between;
        }


        .demo-content {
            padding: 15px;
            font-size: 18px;
            background: #dbdfe5;
            margin-bottom: 10px;
        }



            .demo-content.bg-alt {
                background: #EEEEEE;
            }

        .scrooolll {
            overflow-y: scroll;
            height: 300px;
        }
    </style>


    <script src=""https://cdn.jsdelivr.net/npm/chart.js"">");
            WriteLiteral(@"</script>
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
            BeginContext(19861, 39, false);
#line 610 "C:\Users\DivyanshRampal\Documents\ITAdmin2\ITAdminProject\Views\Dashboard\Index.cshtml"
                      Write(Html.Raw(Json.Serialize(Model.pielist)));

#line default
#line hidden
            EndContext();
            BeginContext(19900, 29, true);
            WriteLiteral(";\r\n\r\n\r\n        var empdata = ");
            EndContext();
            BeginContext(19930, 35, false);
#line 613 "C:\Users\DivyanshRampal\Documents\ITAdmin2\ITAdminProject\Views\Dashboard\Index.cshtml"
                 Write(Html.Raw(Json.Serialize(Model.emp)));

#line default
#line hidden
            EndContext();
            BeginContext(19965, 219, true);
            WriteLiteral(";\r\n\r\n        var empticket = document.getElementById(\"empcount\");\r\n\r\n        var tkt = document.createElement(\"div\");\r\n        tkt.innerHTML = empdata;\r\n        empticket.appendChild(tkt);\r\n\r\n\r\n\r\n         var devdata = ");
            EndContext();
            BeginContext(20185, 35, false);
#line 623 "C:\Users\DivyanshRampal\Documents\ITAdmin2\ITAdminProject\Views\Dashboard\Index.cshtml"
                  Write(Html.Raw(Json.Serialize(Model.dev)));

#line default
#line hidden
            EndContext();
            BeginContext(20220, 229, true);
            WriteLiteral(";\r\n\r\n        var devticket = document.getElementById(\"devnum\");\r\n\r\n        var devtkt = document.createElement(\"div\");\r\n        devtkt.innerHTML = devdata;\r\n        devticket.appendChild(devtkt);\r\n\r\n          var unalloteddata = ");
            EndContext();
            BeginContext(20450, 46, false);
#line 631 "C:\Users\DivyanshRampal\Documents\ITAdmin2\ITAdminProject\Views\Dashboard\Index.cshtml"
                         Write(Html.Raw(Json.Serialize(Model.unalottedcount)));

#line default
#line hidden
            EndContext();
            BeginContext(20496, 1099, true);
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
            BeginContext(21596, 63, false);
#line 666 "C:\Users\DivyanshRampal\Documents\ITAdmin2\ITAdminProject\Views\Dashboard\Index.cshtml"
               Write(Html.Raw(Json.Serialize(Model.barlist.Select(c => c.Category))));

#line default
#line hidden
            EndContext();
            BeginContext(21659, 84, true);
            WriteLiteral(",\r\n            datasets: [{\r\n                label: \'count\',\r\n                data: ");
            EndContext();
            BeginContext(21744, 68, false);
#line 669 "C:\Users\DivyanshRampal\Documents\ITAdmin2\ITAdminProject\Views\Dashboard\Index.cshtml"
                 Write(Html.Raw(Json.Serialize(Model.barlist.Select(c => c.CategoryCount))));

#line default
#line hidden
            EndContext();
            BeginContext(21812, 419, true);
            WriteLiteral(@",
                backgroundColor: colors,
                borderColor: colors,
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
            BeginContext(23152, 76, true);
            WriteLiteral("    });\r\n\r\n\r\n    const historyappend = document.getElementById(\"history\");\r\n");
            EndContext();
            BeginContext(23343, 4210, true);
            WriteLiteral(@"    //alert(arr.length);
    //for (var i = 0; i < arr.length; i++) {
    //    if (arr[i] != null) {
    //        var childofhistory = document.createElement(""div"");
    //        childofhistory.innerHTML = arr[i];
    //        parofhistory.appendChild(childofhistory);
    //        console.log(arr[i]);
    //    }
    //}
    //historyappend.appendChild(parofhistory);





    const calenderappend = document.getElementById(""calender"");
    const left = document.getElementById(""left"");
    const right = document.getElementById(""right"");
    var currentDateTime = new Date();
    //const currentDateISO = currentDateTime.toISOString();


    const year = currentDateTime.getFullYear();
    const month = currentDateTime.getMonth();
    const day = currentDateTime.getDate();

    const currentDate = new Date(year, month, day);
    const options = { year: 'numeric', month: 'long', day: 'numeric' };
    const formattedDate = currentDate.toLocaleDateString('en-US', options);

    calen");
            WriteLiteral(@"derappend.innerHTML = formattedDate;
    //const currentDateISO = currentDateTime.toISOString();
    left.addEventListener(""click"", before);
    right.addEventListener(""click"", after);
    const rowAdd = document.getElementById(""moreRows"");

    async function before() {
        var currentDateISO = currentDateTime.toISOString();
        currentDate.setHours(currentDate.getHours() - 24);
        currentDateTime.setHours(currentDateTime.getHours() - 24);
        calenderappend.innerHTML = ''
        const options = { year: 'numeric', month: 'long', day: 'numeric' };
        const formattedDate = currentDate.toLocaleDateString('en-US', options);

        calenderappend.innerHTML = formattedDate;
        //calenderappend.innerHTML = currentDate;
        //currentDate = currentDateTime.Now.AddHours(-24);
        //alert(currentDate)
        $.ajax({
            url: '/Dashboard/CalenderBefore',
            type: 'GET',
            data: { currentDate: currentDateISO },
            //dataType");
            WriteLiteral(@": 'json',
            success: function (data) {
                //alert(data.Result);
                //var par = document.createElement("""");
                rowAdd.innerHTML = '';
                data.forEach(function (item) {
                    var child = document.createElement(""tr"");
                    var data = document.createElement(""td"");
                    data.innerHTML = item;
                    child.appendChild(data);
                    rowAdd.appendChild(child);
                    //alert(item);
                });
            },
            error: function (xhr, ajaxOptions, thrownError) {
                alert(""Why is Error"");
            }
        });
    }


    async function after() {
        var currentDateISO = currentDateTime.toISOString();
        currentDate.setHours(currentDate.getHours() + 24);
        currentDateTime.setHours(currentDateTime.getHours() + 24);
        calenderappend.innerHTML = ''
        const options = { year: 'numeric', month: 'lo");
            WriteLiteral(@"ng', day: 'numeric' };
        const formattedDate = currentDate.toLocaleDateString('en-US', options);
        calenderappend.innerHTML = formattedDate;
        //currentDate = currentDateTime.Now.AddHours(-24);
        //alert(currentDate)
        $.ajax({
            url: '/Dashboard/CalenderAfter',
            type: 'GET',
            data: { currentDate: currentDateISO },
            //dataType: 'json',
            success: function (data) {
                //alert(data.Result);
                //var par = document.createElement("""");
                rowAdd.innerHTML = '';
                data.forEach(function (item) {
                    var child = document.createElement(""tr"");
                    var data = document.createElement(""td"");
                    data.innerHTML = item;
                    child.appendChild(data);
                    rowAdd.appendChild(child);
                    //alert(item);
                });

            },
            error: function (xhr, ajaxOpt");
            WriteLiteral("ions, thrownError) {\r\n                alert(\"Why is Error\");\r\n            }\r\n        });\r\n    }\r\n    </script>\r\n\r\n");
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
