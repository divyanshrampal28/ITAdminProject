#pragma checksum "C:\Users\JigyasaChopra\Desktop\IT Adminn Projecttt\ITAdminProject\Views\Login\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b639b97e15290b613212cfbdea155d47b0546587"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Index), @"mvc.1.0.view", @"/Views/Login/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Login/Index.cshtml", typeof(AspNetCore.Views_Login_Index))]
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
#line 1 "C:\Users\JigyasaChopra\Desktop\IT Adminn Projecttt\ITAdminProject\Views\_ViewImports.cshtml"
using ITAdminProject;

#line default
#line hidden
#line 2 "C:\Users\JigyasaChopra\Desktop\IT Adminn Projecttt\ITAdminProject\Views\_ViewImports.cshtml"
using ITAdminProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b639b97e15290b613212cfbdea155d47b0546587", @"/Views/Login/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b350f1b4def0de1b5655bb6d12956f8730e813e5", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ITAdminProject.Models.Employeechk>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Email"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("inp"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "password", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Password"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "welcome", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("sign-up-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("body-login"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 22, true);
            WriteLiteral("\r\n\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(64, 4638, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06da93e7cd324790b898401d73bfa8bc", async() => {
                BeginContext(70, 3755, true);
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
    <link rel=""stylesheet"" href=""https://pro.fontawesome.com/releases/v5.10.0/css/all.css"" integrity=""sha384-AYmEC3Yw5cVb3ZcuHtOA93w35dYTsvhLPVnYs9eStHfGJvOvKxVfELGroGkvsg+p"" crossorigin=""anonymous"" />
    <style>
        .body-login {
            height: 100vh;
            width: 100vw;
            overflow-x: hidden;
            overflow-y: hidden;
            margin-left: 13% !important;
        }

        .container-login{
            display: flex;
            justify-content: space-between;
            width: 70%;
            height: 80vh;
            background: #fff;
            border-radius: 15px;
            box-shadow: 0 4px 20px 0 rgba(0, 0, 0, 0.3), 0 6px 20px 0 rgba(0, 0, 0, 0.3);
            overflow: hidden;
        }

        .signin-signup {
            top: 0;
            left: 0;
            width: 50%;
            height: 100%;
            display: flex;");
                WriteLiteral(@"
            align-items: center;
            justify-content: space-around;
            z-index: 5;
        }

        form {
            display: flex;
            align-items: center;
            justify-content: center;
            flex-direction: column;
            width: 40%;
            min-width: 238px;
            padding: 0 10px;
        }


        .title {
            font-size: 35px;
            color: #082c3c;
            margin-bottom: 10px;
        }

        .input-field {
            width: 150%;
            height: 50px;
            margin: 10px 0;
            border: 2px solid #082c3c;
            border-radius: 50px;
            display: flex;
            align-items: center;
        }

        .input-field i {
            flex: 1;
            text-align: center;
            color: #666;
            font-size: 18px;
        }

        .input-field input {
            flex: 5;
            background: none;
            border: none;
            o");
                WriteLiteral(@"utline: none;
            width: 100%;
            font-size: 18px;
            color: #444;
        }

        .btn {
            width: 150px;
            height: 50px;
            border: none;
            border-radius: 50px;
            background: #082c3c;
            color: #fff;
            font-weight: 600;
            margin: 10px 0;
            text-transform: uppercase;
            cursor: pointer;
        }

            .btn:hover {
                background: #0c4056;
            }

        a {
            text-decoration: none;
        }

        .panels-container {
            width: 50%;
            height: 100%;
            display: flex;
            flex-direction: column;
            justify-content: center;
            align-items: center;
            background-color: #082c3c;
        }

        .panel-login {
            display: flex;
            flex-direction: column;
            align-items: center;
            justify-content: space-around;");
                WriteLiteral(@"
            width: 35%;
            min-width: 238px;
            padding: 0 10px;
            text-align: center;
            z-index: 6;
        }

        .left-panel {
            pointer-events: none;
        }

        .panel-login h3 {
            font-size: 24px;
            font-weight: 600;
        }

        .panel-login p {
            font-size: 15px;
            padding: 10px 0;
        }

        .panel-login h1 {
            color: #fff;
            margin-top: 2rem;
            font-size: 3rem;
            font-family: 'Poppins', sans-serif;
        }

        .content-login img {
            width: 300px;
        }

        ");
                EndContext();
                BeginContext(3826, 151, true);
                WriteLiteral("@media (max-width:779px) {\r\n            .container {\r\n                width: 100vw;\r\n                height: 100vh;\r\n            }\r\n        }\r\n        ");
                EndContext();
                BeginContext(3978, 599, true);
                WriteLiteral(@"@media (max-width:635px) {

            form {
                width: 80%;
            }

            .panels-container {
                display: none;
            }

            .signin-signup{
                width: 50%;
                height: 100%;
                display: flex;
                justify-content: center;
                margin-left: 7rem;
            }
            .account-text {
                display: initial;
                margin-top: 30px;
            }

            .input-field {
                width: 90%;
            }
        }
        ");
                EndContext();
                BeginContext(4578, 117, true);
                WriteLiteral("@media (max-width:320px) {\r\n            form {\r\n                width: 90%;\r\n            }\r\n        }\r\n    </style>\r\n");
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
            BeginContext(4702, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(4704, 2479, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "149f2597a4034df19d500cee8406a1a9", async() => {
                BeginContext(4729, 518, true);
                WriteLiteral(@"
    <div class=""container-login"">
        <div class=""panels-container"">
            <div class=""panel-login left-panel"">
                <div class=""content-login"">
                    <img src=""https://skillfinity.cginfinity.com/static/media/Cginfinitylogo.89c539294b8e6745a0c62a8ae4cffed8.svg"">
                    <h1>CGI IT ADMIN</h1>
                </div>
                <img src=""signin.svg"" alt="""" class=""image"">
            </div>
        </div>
        <div class=""signin-signup"">
            ");
                EndContext();
                BeginContext(5247, 655, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf53d328a1d8426bb0d66b3e387e8a9c", async() => {
                    BeginContext(5332, 166, true);
                    WriteLiteral("\r\n                <h2 class=\"title\">Sign In</h2>\r\n                <div class=\"input-field\">\r\n                    <i class=\"fas fa-envelope\"></i>\r\n                    ");
                    EndContext();
                    BeginContext(5498, 73, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "95e82a7ff55049e0b204d5a5043336e1", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 207 "C:\Users\JigyasaChopra\Desktop\IT Adminn Projecttt\ITAdminProject\Views\Login\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Email);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                    BeginWriteTagHelperAttribute();
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(5571, 138, true);
                    WriteLiteral("\r\n                </div>\r\n                <div class=\"input-field\">\r\n                    <i class=\"fas fa-lock\"></i>\r\n                    ");
                    EndContext();
                    BeginContext(5709, 74, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "68ab9b4c42b5437b9026807230cd92e7", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 211 "C:\Users\JigyasaChopra\Desktop\IT Adminn Projecttt\ITAdminProject\Views\Login\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Password);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                    BeginWriteTagHelperAttribute();
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(5783, 112, true);
                    WriteLiteral("\r\n                </div>\r\n                <input type=\"submit\" value=\"Login\" class=\"btn\" id=\"sub\">\r\n            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5902, 1274, true);
                WriteLiteral(@"
        </div>
    </div>

    <script>
        const sub = document.getElementById('sub').addEventListener(""click"", function () {
        let value = document.getElementById(""inp"");
        console.log('user', JSON.stringify(value.value))
        localStorage.setItem('user', JSON.stringify(value.value));

            $.ajax({
                url: '/Login/GetloginDetails',
                type: 'GET',
                data: { ""Email"": value.value.toString()},
                dataType: 'json',
                success: function (data) {
                   // alert(data.Result);
                    alert(data);
                    localStorage.setItem('role', JSON.stringify(data));


                },
                error: function (xhr, ajaxOptions, thrownError) {
                    alert(""Why is Error"");
                }
            });
        const par = document.getElementById(""prnt"");
        var u = document.createElement('ul');
        u.className = 'nav navbar-nav';
    ");
                WriteLiteral("    var li3 = document.createElement(\'li\');\r\n        var a3 = document.createElement(\'a\');\r\n        a3.href = \'/Dashboard/Index\';\r\n        a3.textContent = \'View\';\r\n        li3.appendChild(a3);\r\n        u.appendChild(li3);\r\n    });\r\n\r\n    </script>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7183, 13, true);
            WriteLiteral("\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ITAdminProject.Models.Employeechk> Html { get; private set; }
    }
}
#pragma warning restore 1591
