#pragma checksum "\\vmware-host\Shared Folders\Escritorio\V2-API-CSHARP\Pages\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b41836a38ff465af2fb0e5ae12ce727dda94c44e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(V2_API_CSHARP.Pages.Shared.Pages_Shared__Layout), @"mvc.1.0.view", @"/Pages/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Pages/Shared/_Layout.cshtml", typeof(V2_API_CSHARP.Pages.Shared.Pages_Shared__Layout))]
namespace V2_API_CSHARP.Pages.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "\\vmware-host\Shared Folders\Escritorio\V2-API-CSHARP\Pages\_ViewImports.cshtml"
using V2_API_CSHARP;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b41836a38ff465af2fb0e5ae12ce727dda94c44e", @"/Pages/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d28f7ed3c2a7918525f6f547725f5a8da50cef46", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor/materialize/css/materialize.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("media", new global::Microsoft.AspNetCore.Html.HtmlString("screen,projection"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/custom.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor/jQuery/jquery.3.3.1.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor/materialize/js/materialize.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor/jquery.validate/jquery.validate.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(25, 653, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a69a71075246426585d669bcdcb86ce0", async() => {
                BeginContext(31, 182, true);
                WriteLiteral("\r\n    <!--Import Google Icon Font-->\r\n    <link href=\"https://fonts.googleapis.com/icon?family=Material+Icons\"\r\n          rel=\"stylesheet\" />\r\n    <!--Import materialize.css-->\r\n    ");
                EndContext();
                BeginContext(213, 152, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d5c7e1e8dc7f4bbcb918c00fc6c14689", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(365, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(373, 124, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8ace85ba20b542f6919eb0bb6644feb3", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(497, 174, true);
                WriteLiteral("\r\n\r\n    <!--Let browser know website is optimized for mobile-->\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>API Envios</title>\r\n");
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
            BeginContext(678, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(680, 11173, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b948a704f0a54627bc491154c2bb288e", async() => {
                BeginContext(686, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(695, 12, false);
#line 24 "\\vmware-host\Shared Folders\Escritorio\V2-API-CSHARP\Pages\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(707, 68, true);
                WriteLiteral("\r\n\r\n    <!--JavaScript at end of body for optimized loading-->\r\n    ");
                EndContext();
                BeginContext(775, 91, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3be7b7208ae4e79a1ca58b3f4ed06d9", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(866, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(872, 102, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75cd619117b346e99f1be5246d6e4292", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(974, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(980, 103, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba753edaea474daab0a49bf6f213dde9", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1083, 1324, true);
                WriteLiteral(@"
    <script src=""https://unpkg.com/sweetalert/dist/sweetalert.min.js""></script>
    
    <script>
        
        $(document).ready(function() {
          $(""textarea#textarea1"").characterCounter();
          $(""select"").formSelect();
          $("".tabs"").tabs();

        });


        $(document).on(""click"", ""li a"", function() {
            if ($(this).hasClass(""active"")) {
            $(""#regform"")
                .get()[0]
                .reset();
            $(""#valform"")
                .get()[0]
                .reset();
            }
        });

        //authentication
        $(""#tokenform"").validate({
            rules: {
            api: {
                required: true
            }
            },
            messages: {
            api: {
                required: ""Requerido""
            }
            },
            errorElement: ""span"",
            errorPlacement: function(error, element) {
            var placement = $(element).data(""error"");
         ");
                WriteLiteral(@"   if (placement) {
                $(placement).append(error);
            } else {
                error.insertAfter(element);
            }
            },
            submitHandler: function () {

            let this_key = $(""#api"").val()

            $.ajax({

                url: """);
                EndContext();
                BeginContext(2408, 36, false);
#line 83 "\\vmware-host\Shared Folders\Escritorio\V2-API-CSHARP\Pages\Shared\_Layout.cshtml"
                 Write(Html.Raw(@Url.Action("Auth", "sms")));

#line default
#line hidden
                EndContext();
                BeginContext(2444, 1485, true);
                WriteLiteral(@""",
                method: ""post"",
                data: {
                    action_cmd: ""auth"",
                    api_key: this_key
                },
                success: res => {
                    
                res = JSON.parse(res);
                if (res.code != ""auth_02"") {
                    swal({
                    title: ""Mensaje"",
                    text: res.message,
                    icon: ""info""
                    });
                    return;
                }

                $(""#token"").val(res.token);
                $(""#token"")
                    .parent()
                    .find(""label"")
                    .addClass(""active"");
                swal({
                    title: ""Mensaje"",
                    text: res.message,
                    icon: ""info""
                });
                }
            });
            }
        });

        //credits
        $(""#request_credits"").on(""click"", e => {
          $(e.currentTarget");
                WriteLiteral(@").addClass(""disabled"");
            var token = $(""#token"").val();
 
          if ( token.trim() == """") {
            swal({
            title: ""Advertencia"",
            text:
                ""Debes introducir tu ApiKey y generar un token para poder enviar mensajes"",
            icon: ""warning""
            });
              $(""#request_credits"").removeClass(""disabled"");
            return;
          }

          $.ajax({
              url: """);
                EndContext();
                BeginContext(3930, 39, false);
#line 133 "\\vmware-host\Shared Folders\Escritorio\V2-API-CSHARP\Pages\Shared\_Layout.cshtml"
               Write(Html.Raw(@Url.Action("Credits", "sms")));

#line default
#line hidden
                EndContext();
                BeginContext(3969, 2814, true);
                WriteLiteral(@""",
              data: {
                  action_cmd: ""credits"",
                  token: token
               },
            type: ""POST"",
              success: res => {

                  $(""#request_credits"").removeClass(""disabled"");
                  res = JSON.parse(res);
              if (res.success == true) {
                $(""#apiform"")
                  .get()[0]
                  .reset();
                swal({
                  title: ""Mensaje"",
                  text: ""Cr\u00E9ditos disponibles:  "" + res.credit,
                  icon: ""info""
                });
              } else {
                $(""#apiform"")
                  .get()[0]
                  .reset();
                swal({
                  title: ""Información no Disponible"",
                  text: """",
                  icon: ""warning""
                });
              }
            }
          });
        });

        //send
        $(""#apiform"").validate({
            rules: {
        ");
                WriteLiteral(@"    destination: {
                required: true,
                minlength: 10
            },
            content: {
                required: true,
                maxlength: 160
            }
            },
            messages: {
            destination: {
                required: ""Requerido"",
                minlength: ""M\u00EDnimo 10 d\u00EDgitos""
            },
            content: {
                required: ""Requerido"",
                maxlength: ""No puede exceder 160 caracteres""
            }
            },
            errorElement: ""span"",
            errorPlacement: function(error, element) {
            var placement = $(element).data(""error"");
            if (placement) {
                $(placement).append(error);
            } else {
                error.insertAfter(element);
            }
            },
            submitHandler: function() {
            var api = $(""#api"").val();
            var token = $(""#token"").val();
            var nombre = $(""#nombre""");
                WriteLiteral(@").val();
            var sandbox = """";

            if ($(""#sandbox:checked"").length) {
                sandbox = 1;
            } else {
                sandbox = 0;
            }

            if (api.trim() == """" || token.trim() == """") {
                swal({
                title: ""Advertencia"",
                text:
                    ""Debes introducir tu ApiKey y generar un token para poder enviar mensajes"",
                icon: ""warning""
                });
                return;
            }

            let this_c = $(""#country option:selected"").text();
            let this_dest = $(""#destination"").val();
            let this_texto = $(""#textarea1"").val();

                
            $.ajax({

                url: """);
                EndContext();
                BeginContext(6784, 36, false);
#line 226 "\\vmware-host\Shared Folders\Escritorio\V2-API-CSHARP\Pages\Shared\_Layout.cshtml"
                 Write(Html.Raw(@Url.Action("Send", "sms")));

#line default
#line hidden
                EndContext();
                BeginContext(6820, 2236, true);
                WriteLiteral(@""",
                data: {
                    action_cmd: ""send"",
                    token: token,
                    c: this_c,
                    dest: this_dest,
                    texto: this_texto,
                    sand: sandbox,
                    nombre: nombre
                },
                method: ""post"",
                success: res => {

                res = JSON.parse(res);
                        
                $(""#apiform"")
                    .get()[0]
                    .reset();

                swal({
                    title: ""Mensaje"",
                    text: res.message,
                    icon: ""info""
                });
                }

            });
            }
        });

        //2faregister
        $(""#regform"").validate({
          rules: {
            destination: {
              required: true,
              minlength: 10
            }
          },
          messages: {
            destination: {
              r");
                WriteLiteral(@"equired: ""Requerido"",
              minlength: ""M\u00EDnimo 10 d\u00EDgitos""
            }
          },
          errorElement: ""span"",
          errorPlacement: function(error, element) {
            var placement = $(element).data(""error"");
            if (placement) {
              $(placement).append(error);
            } else {
              error.insertAfter(element);
            }
          },
          submitHandler: function() {
            var api = $(""#api"").val();
            var token = $(""#token"").val();
            var nombre = $(""#nombre"").val();
            var digitos = $(""input[name=group1]:checked"").val();
            var formato = $(""input[name=group2]:checked"").val();
            var this_c = $(""#country option:selected"").text();
            var this_dest = $(""#destination"").val();

            if (api.trim() == """" || token.trim() == """") {
              swal({
                title: ""Advertencia"",
                text:
                  ""Debes introducir tu ApiK");
                WriteLiteral("ey y generar un token para poder enviar mensajes\",\r\n                icon: \"warning\"\r\n              });\r\n              return;\r\n            }\r\n\r\n            $.ajax({\r\n                url: \"");
                EndContext();
                BeginContext(9057, 40, false);
#line 299 "\\vmware-host\Shared Folders\Escritorio\V2-API-CSHARP\Pages\Shared\_Layout.cshtml"
                 Write(Html.Raw(@Url.Action("Register", "sms")));

#line default
#line hidden
                EndContext();
                BeginContext(9097, 2146, true);
                WriteLiteral(@""",
                data: {
                    action_cmd: ""2fa_register"",
                    token: token,
                    nombre: nombre,
                    c: this_c,
                    dest: this_dest,
                    digitos: digitos,
                    formato: formato                
                },
                method: ""post"",
                success: res => {
                
                $(""#regform"")
                  .get()[0]
                  .reset();
                swal({
                  title: ""Mensaje"",
                  text: res,
                  icon: ""info""
                });
              }
            });
          }
        });

        //2faverification
    $(""#valform"").validate({
      rules: {
        destination_ve: {
          required: true,
          minlength: 10
        },
        verification: {
          required: true,
          minlength: 4
        }
      },
      messages: {
        destination_ve: {
   ");
                WriteLiteral(@"       required: ""Requerido"",
          minlength: ""M\u00EDnimo 10 d\u00EDgitos""
        },
        verification: {
          required: ""Requerido"",
          maxlength: ""Deben ser por lo menos 4 caracteres""
        }
      },
      errorElement: ""span"",
      errorPlacement: function(error, element) {
        var placement = $(element).data(""error"");
        if (placement) {
          $(placement).append(error);
        } else {
          error.insertAfter(element);
        }
      },
        submitHandler: function () {

        var api = $(""#api"").val();
        var token = $(""#token"").val();
        var formato = $(""input[name=group3]:checked"").val();
        var this_dest = $(""#destination_ve"").val();
     
        var code = $(""#verification"").val();

        if (api.trim() == """" || token.trim() == """") {
          swal({
            title: ""Advertencia"",
            text:
              ""Debes introducir tu ApiKey y generar un token para poder enviar mensajes"",
            ");
                WriteLiteral("icon: \"warning\"\r\n          });\r\n          return;\r\n        }\r\n\r\n        $.ajax({\r\n          url: \"");
                EndContext();
                BeginContext(11244, 40, false);
#line 376 "\\vmware-host\Shared Folders\Escritorio\V2-API-CSHARP\Pages\Shared\_Layout.cshtml"
           Write(Html.Raw(@Url.Action("Validate", "sms")));

#line default
#line hidden
                EndContext();
                BeginContext(11284, 562, true);
                WriteLiteral(@""",
            data: {
                action_cmd: ""2fa_validate"",
                token: token,
                code: code,
                dest: this_dest,
                formato: formato                
            },
            method: ""post"",
            success: res => {
            $(""#valform"")
              .get()[0]
              .reset();
            swal({
              title: ""Mensaje"",
              text: res,
              icon: ""info""
            });
          }
        });
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
            BeginContext(11853, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
