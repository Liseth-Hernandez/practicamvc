#pragma checksum "C:\Users\HP\source\repos\SeguridadWeb\SeguridadWeb\SeguridadWeb.UI.AppWebAspCore\Views\Usuario\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7c5b715eb091fbfd5422f683e2824b5964bd399"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Index), @"mvc.1.0.view", @"/Views/Usuario/Index.cshtml")]
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
#line 1 "C:\Users\HP\source\repos\SeguridadWeb\SeguridadWeb\SeguridadWeb.UI.AppWebAspCore\Views\_ViewImports.cshtml"
using SeguridadWeb.UI.AppWebAspCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\source\repos\SeguridadWeb\SeguridadWeb\SeguridadWeb.UI.AppWebAspCore\Views\_ViewImports.cshtml"
using SeguridadWeb.UI.AppWebAspCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7c5b715eb091fbfd5422f683e2824b5964bd399", @"/Views/Usuario/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"867f18ff429c9e5ea670d3061be22fe9e77c9d66", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SeguridadWeb.EntidadesDeNegocio.Usuario>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\HP\source\repos\SeguridadWeb\SeguridadWeb\SeguridadWeb.UI.AppWebAspCore\Views\Usuario\Index.cshtml"
   ViewData["Title"] = "Index";
                int numPage = 1;
                int numRegistros = 0;
                int numRegistrosPorPage = 10;
                int[] tops = { 10, 20, 50, 100, 500, 1000, 10000, -1 };
                int topActual = Convert.ToInt32(ViewBag.Top);
                List<SeguridadWeb.EntidadesDeNegocio.Rol> roles = ViewBag.Roles as List<SeguridadWeb.EntidadesDeNegocio.Rol>; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Buscar</h1>\n<div class=\"row\">\n    <div class=\"col-md-12\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7c5b715eb091fbfd5422f683e2824b5964bd3996188", async() => {
                WriteLiteral(@"
            <div class=""row"">
                <div class=""col-md-3"">
                    <div class=""form-group"">
                        <label class=""control-label"">Nombre</label>
                        <input type=""text"" class=""form-control"" name=""nombre"" />
                    </div>
                </div>
                <div class=""col-md-3"">
                    <div class=""form-group"">
                        <label class=""control-label"">Apellido</label>
                        <input type=""text"" class=""form-control"" name=""apellido"" />
                    </div>
                </div>
                <div class=""col-md-3"">
                    <div class=""form-group"">
                        <label class=""control-label"">Login</label>
                        <input type=""text"" class=""form-control"" name=""login"" />
                    </div>
                </div>
                <div class=""col-md-3"">
                    <div class=""form-group"">
                        <label class=""control-label"">Estat");
                WriteLiteral("us</label>\n                        <select name=\"estatus\" class=\"form-control\">\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7c5b715eb091fbfd5422f683e2824b5964bd3997660", async() => {
                    WriteLiteral("SELECCIONAR");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7c5b715eb091fbfd5422f683e2824b5964bd3999237", async() => {
                    WriteLiteral("ACTIVO");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7c5b715eb091fbfd5422f683e2824b5964bd39910486", async() => {
                    WriteLiteral("INACTIVO");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </select>
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-md-4"">
                    <div class=""form-group"">
                        <label class=""control-label"">Fecha Registro</label>
                        <input type=""date"" name=""fechaRegistro"" class=""form-control"" />
                    </div>
                </div>
                <!--Aqui inici el autocomplete-->
                <!-- <div class=""col-md-4"">
    <div class=""form-group"">
        <label class=""control-label"">Rol</label>
        <input type=""text"" name=""idRol"" class=""form-control"">
                <!-- <select name=""idRol"" class=""form-control"">
        <option selected value=""0"">SELECCIONAR</option>
        <option selected value=""0"">SELECCIONAR</option>
       <");
                WriteLiteral("@foreach (var item in roles)\n        {\n    <option value=\"<");
                WriteLiteral("@item.Id\"><");
                WriteLiteral(@"@item.Nombre</option>}
    </select>-->
                <!--   </div>
            </div>
                <!--Aqui finaliza el autocomplete-->
                <link rel=""stylesheet"" href=""//code.jquery.com/ui/1.13.0/themes/base/jquery-ui.css"">
                <link rel=""stylesheet"" href=""/resources/demos/style.css"">
                <script src=""https://code.jquery.com/jquery-3.6.0.js""></script>
                <script src=""https://code.jquery.com/ui/1.13.0/jquery-ui.js""></script>
                <script>
                    $(function () {
                        var availableTags = [

                            ""AppleScript"",
                            ""Asp"",
                            ""BASIC"",
                            ""C"",
                            ""C++"",
                            ""Clojure"",
                            ""COBOL"",
                            ""ColdFusion"",
                            ""Erlang"",
                            ""Fortran"",
                            ""Groovy"",
                ");
                WriteLiteral(@"            ""Haskell"",
                            ""Java"",
                            ""JavaScript"",
                            ""Lisp"",
                            ""Perl"",
                            ""PHP"",
                            ""Python"",
                            ""Ruby"",
                            ""Scala"",
                            ""Scheme""
                        ];
                        $(""#idRol"").autocomplete({
                            source: availableTags
                        });
                    });
                </script>
                <div class=""col-md-4"">
                    <div class=""form-group"">
                        <div class=""ui-widget"">
                            <label for=""idRol"" class=""control-label"">Rol</label>
                            <input id=""idRol"" name=""idRol"" class=""form-control"">
                        </div>
                    </div>
                </div>

                <div class=""col-md-2"">
                    <div class=""form-group"">
  ");
                WriteLiteral("                      <label class=\"control-label\">Top</label>\n                        <select name=\"top_aux\" class=\"form-control\">\n");
#nullable restore
#line 114 "C:\Users\HP\source\repos\SeguridadWeb\SeguridadWeb\SeguridadWeb.UI.AppWebAspCore\Views\Usuario\Index.cshtml"
                             foreach (var item in tops)
                            {
                                string strItem = item != -1 ? item.ToString() : "Todos";
                                if (item != topActual)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7c5b715eb091fbfd5422f683e2824b5964bd39915613", async() => {
#nullable restore
#line 119 "C:\Users\HP\source\repos\SeguridadWeb\SeguridadWeb\SeguridadWeb.UI.AppWebAspCore\Views\Usuario\Index.cshtml"
                                 Write(strItem);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 119 "C:\Users\HP\source\repos\SeguridadWeb\SeguridadWeb\SeguridadWeb.UI.AppWebAspCore\Views\Usuario\Index.cshtml"
                   WriteLiteral(item);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(" ");
#nullable restore
#line 119 "C:\Users\HP\source\repos\SeguridadWeb\SeguridadWeb\SeguridadWeb.UI.AppWebAspCore\Views\Usuario\Index.cshtml"
                                                        }
                                else
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7c5b715eb091fbfd5422f683e2824b5964bd39917878", async() => {
#nullable restore
#line 122 "C:\Users\HP\source\repos\SeguridadWeb\SeguridadWeb\SeguridadWeb.UI.AppWebAspCore\Views\Usuario\Index.cshtml"
                                          Write(strItem);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 122 "C:\Users\HP\source\repos\SeguridadWeb\SeguridadWeb\SeguridadWeb.UI.AppWebAspCore\Views\Usuario\Index.cshtml"
                            WriteLiteral(item);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
#nullable restore
#line 122 "C:\Users\HP\source\repos\SeguridadWeb\SeguridadWeb\SeguridadWeb.UI.AppWebAspCore\Views\Usuario\Index.cshtml"
                                                                }
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </select>\n                    </div>\n                </div>\n            </div>\n            <div class=\"form-group\">\n                <input type=\"submit\" value=\"Buscar\" class=\"btn btn-primary\" />\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7c5b715eb091fbfd5422f683e2824b5964bd39920648", async() => {
                    WriteLiteral("Crear");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n            </div>\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n</div>\n<table class=\"table table-responsive paginationjs\">\n    <thead>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 139 "C:\Users\HP\source\repos\SeguridadWeb\SeguridadWeb\SeguridadWeb.UI.AppWebAspCore\Views\Usuario\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 142 "C:\Users\HP\source\repos\SeguridadWeb\SeguridadWeb\SeguridadWeb.UI.AppWebAspCore\Views\Usuario\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 145 "C:\Users\HP\source\repos\SeguridadWeb\SeguridadWeb\SeguridadWeb.UI.AppWebAspCore\Views\Usuario\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Login));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 148 "C:\Users\HP\source\repos\SeguridadWeb\SeguridadWeb\SeguridadWeb.UI.AppWebAspCore\Views\Usuario\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Estatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 151 "C:\Users\HP\source\repos\SeguridadWeb\SeguridadWeb\SeguridadWeb.UI.AppWebAspCore\Views\Usuario\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IdRol));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 154 "C:\Users\HP\source\repos\SeguridadWeb\SeguridadWeb\SeguridadWeb.UI.AppWebAspCore\Views\Usuario\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FechaRegistro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th colspan=\"3\">Acciones</th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 160 "C:\Users\HP\source\repos\SeguridadWeb\SeguridadWeb\SeguridadWeb.UI.AppWebAspCore\Views\Usuario\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr data-page=\"");
#nullable restore
#line 162 "C:\Users\HP\source\repos\SeguridadWeb\SeguridadWeb\SeguridadWeb.UI.AppWebAspCore\Views\Usuario\Index.cshtml"
          Write(numPage);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\n    <td>\n        ");
#nullable restore
#line 164 "C:\Users\HP\source\repos\SeguridadWeb\SeguridadWeb\SeguridadWeb.UI.AppWebAspCore\Views\Usuario\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 167 "C:\Users\HP\source\repos\SeguridadWeb\SeguridadWeb\SeguridadWeb.UI.AppWebAspCore\Views\Usuario\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 170 "C:\Users\HP\source\repos\SeguridadWeb\SeguridadWeb\SeguridadWeb.UI.AppWebAspCore\Views\Usuario\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.Login));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n");
#nullable restore
#line 172 "C:\Users\HP\source\repos\SeguridadWeb\SeguridadWeb\SeguridadWeb.UI.AppWebAspCore\Views\Usuario\Index.cshtml"
     if (item.Estatus == 1)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<td>ACTIVO</td> ");
#nullable restore
#line 174 "C:\Users\HP\source\repos\SeguridadWeb\SeguridadWeb\SeguridadWeb.UI.AppWebAspCore\Views\Usuario\Index.cshtml"
                }
                else if (item.Estatus == 2)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<td>INACTIVO</td> ");
#nullable restore
#line 177 "C:\Users\HP\source\repos\SeguridadWeb\SeguridadWeb\SeguridadWeb.UI.AppWebAspCore\Views\Usuario\Index.cshtml"
                  }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<td></td>");
#nullable restore
#line 180 "C:\Users\HP\source\repos\SeguridadWeb\SeguridadWeb\SeguridadWeb.UI.AppWebAspCore\Views\Usuario\Index.cshtml"
         }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <td>\n        ");
#nullable restore
#line 182 "C:\Users\HP\source\repos\SeguridadWeb\SeguridadWeb\SeguridadWeb.UI.AppWebAspCore\Views\Usuario\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.Rol.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 185 "C:\Users\HP\source\repos\SeguridadWeb\SeguridadWeb\SeguridadWeb.UI.AppWebAspCore\Views\Usuario\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.FechaRegistro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td class=\"botonestabla\">\n        ");
#nullable restore
#line 188 "C:\Users\HP\source\repos\SeguridadWeb\SeguridadWeb\SeguridadWeb.UI.AppWebAspCore\Views\Usuario\Index.cshtml"
   Write(Html.ActionLink("Modificar", "Edit", new { id = item.Id }, new { @class = "btn btn-success" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td class=\"botonestabla\">\n        ");
#nullable restore
#line 191 "C:\Users\HP\source\repos\SeguridadWeb\SeguridadWeb\SeguridadWeb.UI.AppWebAspCore\Views\Usuario\Index.cshtml"
   Write(Html.ActionLink("Ver", "Details", new { id = item.Id }, new { @class = "btn btn-info" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td class=\"botonestabla\">\n        ");
#nullable restore
#line 194 "C:\Users\HP\source\repos\SeguridadWeb\SeguridadWeb\SeguridadWeb.UI.AppWebAspCore\Views\Usuario\Index.cshtml"
   Write(Html.ActionLink("Eliminar", "Delete", new { id = item.Id }, new { @class = "btn btn-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n</tr>                ");
#nullable restore
#line 196 "C:\Users\HP\source\repos\SeguridadWeb\SeguridadWeb\SeguridadWeb.UI.AppWebAspCore\Views\Usuario\Index.cshtml"
                     numRegistros++;
                if (numRegistros == numRegistrosPorPage)
                {
                    numPage++;
                    numRegistros = 0;
                }
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 203 "C:\Users\HP\source\repos\SeguridadWeb\SeguridadWeb\SeguridadWeb.UI.AppWebAspCore\Views\Usuario\Index.cshtml"
           if (numRegistros == 0)
                        {
                            numPage--;
                        } 

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n");
#nullable restore
#line 209 "C:\Users\HP\source\repos\SeguridadWeb\SeguridadWeb\SeguridadWeb.UI.AppWebAspCore\Views\Usuario\Index.cshtml"
 if (numPage > 1)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\" style=\"overflow:auto\">\n    <div class=\"col-md-12\">\n        <ul class=\"pagination paginationjs\" data-numpage=\"");
#nullable restore
#line 213 "C:\Users\HP\source\repos\SeguridadWeb\SeguridadWeb\SeguridadWeb.UI.AppWebAspCore\Views\Usuario\Index.cshtml"
                                                     Write(numPage);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-pageactive=\"1\">\n            <li class=\"page-item\" data-typepage=\"Previous\"><a class=\"page-link\" href=\"#\">Previous</a></li>\n");
#nullable restore
#line 215 "C:\Users\HP\source\repos\SeguridadWeb\SeguridadWeb\SeguridadWeb.UI.AppWebAspCore\Views\Usuario\Index.cshtml"
             for (var i = 1; i <= numPage; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<li class=\"page-item\" data-page=\"");
#nullable restore
#line 217 "C:\Users\HP\source\repos\SeguridadWeb\SeguridadWeb\SeguridadWeb.UI.AppWebAspCore\Views\Usuario\Index.cshtml"
                            Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-typepage=\"Item\"><a class=\"page-link\" href=\"#\">");
#nullable restore
#line 217 "C:\Users\HP\source\repos\SeguridadWeb\SeguridadWeb\SeguridadWeb.UI.AppWebAspCore\Views\Usuario\Index.cshtml"
                                                                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>");
#nullable restore
#line 217 "C:\Users\HP\source\repos\SeguridadWeb\SeguridadWeb\SeguridadWeb.UI.AppWebAspCore\Views\Usuario\Index.cshtml"
                                                                                                   }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\" data-typepage=\"Next\"><a class=\"page-link\" href=\"#\">Next</a></li>\n        </ul>\n    </div>\n</div>");
#nullable restore
#line 221 "C:\Users\HP\source\repos\SeguridadWeb\SeguridadWeb\SeguridadWeb.UI.AppWebAspCore\Views\Usuario\Index.cshtml"
      }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SeguridadWeb.EntidadesDeNegocio.Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
