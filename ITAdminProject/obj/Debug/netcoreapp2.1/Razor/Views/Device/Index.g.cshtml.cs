#pragma checksum "C:\Users\NamanMalik\Desktop\clone_ITAdmin\ITAdminProject\Views\Device\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "619278fdb76dd53354d333fd8e780a2015755806"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Device_Index), @"mvc.1.0.view", @"/Views/Device/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Device/Index.cshtml", typeof(AspNetCore.Views_Device_Index))]
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
#line 1 "C:\Users\NamanMalik\Desktop\clone_ITAdmin\ITAdminProject\Views\_ViewImports.cshtml"
using ITAdminProject;

#line default
#line hidden
#line 2 "C:\Users\NamanMalik\Desktop\clone_ITAdmin\ITAdminProject\Views\_ViewImports.cshtml"
using ITAdminProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"619278fdb76dd53354d333fd8e780a2015755806", @"/Views/Device/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b350f1b4def0de1b5655bb6d12956f8730e813e5", @"/Views/_ViewImports.cshtml")]
    public class Views_Device_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ITAdminProject.Models.Inventory>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Device", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\NamanMalik\Desktop\clone_ITAdmin\ITAdminProject\Views\Device\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(94, 30, true);
            WriteLiteral("\r\n\r\n<h2>Index in device</h2>\r\n");
            EndContext();
            BeginContext(124, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "366818ba33f44accb46c32a6aeca4d28", async() => {
                BeginContext(171, 19, true);
                WriteLiteral("create new category");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(194, 14, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
            EndContext();
#line 15 "C:\Users\NamanMalik\Desktop\clone_ITAdmin\ITAdminProject\Views\Device\Index.cshtml"
  

    ViewData["Title"] = "Search table";


#line default
#line hidden
            BeginContext(260, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(267, 17, false);
#line 21 "C:\Users\NamanMalik\Desktop\clone_ITAdmin\ITAdminProject\Views\Device\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(284, 48, true);
            WriteLiteral("</h2>\r\n\r\n<!DOCTYPE html>\r\n\r\n<html lang=\"en\">\r\n\r\n");
            EndContext();
            BeginContext(332, 466, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de52c24519514288b88a1aba7840c339", async() => {
                BeginContext(338, 453, true);
                WriteLiteral(@"

    <title>Bootstrap Example</title>

    <meta charset=""utf-8"">

    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">

    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"">

    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.6.4/jquery.min.js""></script>

    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js""></script>

");
                EndContext();
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
            EndContext();
            BeginContext(798, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(802, 5279, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e947d0e36cf4b49a0c151da21f91260", async() => {
                BeginContext(808, 441, true);
                WriteLiteral(@"

    <div class=""container"">

        <h2>Filterable Table</h2>

        <p>Type something in the input field to search the table for first names, last names or emails:</p>

        <input class=""form-control"" id=""myInput"" type=""text"" placeholder=""Search.."">

        <br>

        <input type=""number"" id=""entriesToShow"" placeholder=""Entries to Show"">

        <button id=""showEntriesButton"">Show</button>

        <br />
");
                EndContext();
#line 60 "C:\Users\NamanMalik\Desktop\clone_ITAdmin\ITAdminProject\Views\Device\Index.cshtml"
         if (Model.Count() > 0)
        {

#line default
#line hidden
                BeginContext(1293, 320, true);
                WriteLiteral(@"            <table class=""table table-bordered table-striped"" style=""width:100%"">
                <thread>
                    <tr>
                        <th>
                            Category Name
                        </th>

                    </tr>
                </thread>
                <tbody>
");
                EndContext();
#line 72 "C:\Users\NamanMalik\Desktop\clone_ITAdmin\ITAdminProject\Views\Device\Index.cshtml"
                     foreach (var obj in Model)
                    {

#line default
#line hidden
                BeginContext(1685, 74, true);
                WriteLiteral("                        <tr>\r\n                            <td width=\"50%\">");
                EndContext();
                BeginContext(1760, 14, false);
#line 75 "C:\Users\NamanMalik\Desktop\clone_ITAdmin\ITAdminProject\Views\Device\Index.cshtml"
                                       Write(obj.DeviceName);

#line default
#line hidden
                EndContext();
                BeginContext(1774, 38, true);
                WriteLiteral("</td>\r\n                        </tr>\r\n");
                EndContext();
#line 77 "C:\Users\NamanMalik\Desktop\clone_ITAdmin\ITAdminProject\Views\Device\Index.cshtml"
                    }

#line default
#line hidden
                BeginContext(1835, 48, true);
                WriteLiteral("                </tbody>\r\n            </table>\r\n");
                EndContext();
#line 80 "C:\Users\NamanMalik\Desktop\clone_ITAdmin\ITAdminProject\Views\Device\Index.cshtml"
        }
        else
        {

#line default
#line hidden
                BeginContext(1919, 44, true);
                WriteLiteral("            <p>No category exists.....</p>\r\n");
                EndContext();
#line 84 "C:\Users\NamanMalik\Desktop\clone_ITAdmin\ITAdminProject\Views\Device\Index.cshtml"
        }

#line default
#line hidden
                BeginContext(1974, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(2584, 3490, true);
                WriteLiteral(@"
        <p>Note that we start the search in tbody, to prevent filtering the table headers.</p>

        <nav aria-label=""..."">

            <ul class=""pagination"">

                <li class=""page-item disabled"">

                    <a class=""page-link"">Previous</a>

                </li>

                <li class=""page-item""><a class=""page-link"" href=""#"">1</a></li>

                <li class=""page-item active"" aria-current=""page"">

                    <a class=""page-link"" href=""#"">2</a>

                </li>

                <li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>

                <li class=""page-item"">

                    <a class=""page-link"" href=""#"">Next</a>

                </li>

            </ul>

        </nav>

    </div>

    <script>

        $(document).ready(function () {

            $(""#myInput"").on(""keyup"", function () {

                var value = $(this).val().toLowerCase();

                $(""#myTable tr"").filter(funct");
                WriteLiteral(@"ion () {

                    $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)

                });

            });

        });



        document.addEventListener(""DOMContentLoaded"", function () {

            var myInput = document.getElementById(""myInput"");

            var myTable = document.getElementById(""myTable"");

            var entryCount = document.getElementById(""entryCount"");

            var entriesToShowInput = document.getElementById(""entriesToShow"");

            var showEntriesButton = document.getElementById(""showEntriesButton"");

            var displayedEntriesCount = document.getElementById(""displayedEntriesCount""); // Get the displayed entries count element



            showEntriesButton.addEventListener(""click"", function () {

                displayEntries();

            });



            function displayEntries() {

                var value = myInput.value.toLowerCase();

                var rows = myTable.getElementsBy");
                WriteLiteral(@"TagName(""tr"");

                var entriesToShow = parseInt(entriesToShowInput.value); // Get the number of entries to show



                for (var i = 0; i < rows.length; i++) {

                    var row = rows[i];

                    var cells = row.getElementsByTagName(""td"");

                    var shouldShow = false;



                    for (var j = 0; j < cells.length; j++) {

                        var cell = cells[j];

                        if (cell.textContent.toLowerCase().indexOf(value) > -1) {

                            shouldShow = true;

                            break;

                        }

                    }



                    if (shouldShow) {

                        if (i < entriesToShow) {

                            row.style.display = """";

                        } else {

                            row.style.display = ""none"";

                        }

                    } else {

                        ");
                WriteLiteral(@"row.style.display = ""none"";

                    }

                }



                // Calculate and display the number of displayed entries

                var displayedCount = Array.from(rows).filter(row => row.style.display !== ""none"").length;

                displayedEntriesCount.textContent = ""Displayed Entries: "" + displayedCount;

            }

        });





    </script>

");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6081, 13, true);
            WriteLiteral("\r\n\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ITAdminProject.Models.Inventory>> Html { get; private set; }
    }
}
#pragma warning restore 1591
